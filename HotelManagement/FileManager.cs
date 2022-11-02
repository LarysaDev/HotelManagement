using HotelManagement.Customers;
using HotelManagement.Exceptions;
using HotelManagement.Reservation.DataGridRoomClass;
using HotelManagement.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Xml.Linq;
using static HotelManagement.Reservation.ReservationWindow;

namespace HotelManagement
{
    public class FileManager
    {
        private String path = "";

        public FileManager() { }
        public FileManager(String path)
        {
            this.path = path;
        }
        public String getPath() { return path; }

        public int openFile(string purpose = null)
        {
            try
            {
                String filename = "";
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.DefaultExt = ".txt";
                dlg.Filter = "Text files (*.txt)|*.txt";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    filename = dlg.FileName;
                    this.path = filename;
                }
                try
                {
                    if (System.IO.File.ReadAllLines(path).Length == 0) throw new EmptyFileException("");
                    String[] lines = System.IO.File.ReadAllLines(path);
                    if (purpose == "hotel")
                        if (!lines[0].StartsWith("hotel")) throw new InvalidHotelInfoException(lines[0]);
                        else if (purpose == "booking")
                            if (lines[0].StartsWith("hotel")) throw new InvalidHotelInfoException(lines[0]);
                    return 0;
                }
                catch (InvalidHotelInfoException ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }

            }
            catch (EmptyFileException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public List<Hotel> createList()
        {
            List<Hotel> list = new List<Hotel>();
            List<StandartRoom> stRooms = new List<StandartRoom>();
            List<LuxRoom> luxRooms = new List<LuxRoom>();
            String[] lines = System.IO.File.ReadAllLines(path);
            String header = "";
            int index = 0;
            Hotel? hotel1 = new Hotel();
            foreach (var line in lines)
            {
                String[] wordsArr = line.Split(' ').ToArray();

                if (line.StartsWith("hotel")) header = line;
                else if (wordsArr[0].StartsWith("1"))
                {
                    int numberOfRoom = System.Convert.ToInt32(wordsArr[0]);
                    int rooms = System.Convert.ToInt32(wordsArr[1]);
                    int beds = System.Convert.ToInt32(wordsArr[2]);
                    int windows = System.Convert.ToInt32(wordsArr[3]);
                    double square = System.Convert.ToDouble(wordsArr[4]);
                    double price = System.Convert.ToDouble(wordsArr[5]);
                    hotel1.addRoom(new StandartRoom(
                        numberOfRoom, rooms, beds, windows, square, price
                    ));

                }
                else if (line.StartsWith("2"))
                {
                    int numberOfRoom = System.Convert.ToInt32(wordsArr[0]);
                    int rooms = System.Convert.ToInt32(wordsArr[1]);
                    int beds = System.Convert.ToInt32(wordsArr[2]);
                    int windows = System.Convert.ToInt32(wordsArr[3]);
                    double square = System.Convert.ToDouble(wordsArr[4]);
                    double price = System.Convert.ToDouble(wordsArr[5]);
                    hotel1.addLuxRoom(new LuxRoom(
                        numberOfRoom, rooms, beds, windows, square, price
                    ));
                }
                String[] data = header.Split(' ');
                hotel1.setName(data[1]);
                hotel1.setStars(System.Convert.ToInt32(data[2]));
                index++;
                if (index != lines.Length && lines[index].StartsWith("hotel"))
                {
                    list.Add(hotel1);
                    hotel1 = new Hotel();
                }
            }
            return list;
        }
        public void createListOfCustomers(Singleton_AllCustomers allCustomers)
        {
            Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
            List<Customer> customers = new List<Customer>();
            String[] lines = System.IO.File.ReadAllLines(path);
            Customer customer = new Customer();
            StandartRoom stRoom = new StandartRoom();
            LuxRoom luxRoom = new LuxRoom();
            char option = ' ';
            foreach (var line in lines)
            {
                String[] wordsArr = line.Split(' ').ToArray();
                DateTime dateTo = new DateTime();
                DateTime dateFrom = new DateTime();
                customer = new Customer(wordsArr[0], wordsArr[1], wordsArr[2], wordsArr[3], Convert.ToInt32(wordsArr[4]));
                if (wordsArr.Length > 5)
                {


                    String[] dateTimesFrom = wordsArr[6].Split('/').ToArray();
                    dateFrom = new DateTime(Convert.ToInt32(dateTimesFrom[2]), Convert.ToInt32(dateTimesFrom[1]), Convert.ToInt32(dateTimesFrom[0]));
                    if (wordsArr.Length > 6)
                    {
                        String[] dateTimesTo = wordsArr[7].Split('/').ToArray();
                        dateTo = new DateTime(Convert.ToInt32(dateTimesTo[2]), Convert.ToInt32(dateTimesTo[1]), Convert.ToInt32(dateTimesTo[0]));
                    }

                    if (wordsArr[5].StartsWith("1"))
                    {
                        option = 's';
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var room in hotel.getStandartRooms())
                            {
                                if (room.getNumber() == Convert.ToInt32(wordsArr[5])) stRoom = room; break;
                            }
                        }
                    }
                    else
                    {
                        option = 'l';
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var room in hotel.getLuxRooms())
                            {
                                if (room.getNumber() == Convert.ToInt32(wordsArr[5])) luxRoom = room; break;
                            }
                        }
                    }
                }
                else option = ' ';
                customers.Add(customer);
                allCustomers.addCustomer(customer);

                if (option == 's')
                {
                    allCustomers.getListOfCustomers().Where(x => x.getName() == customer.getName()).First().reserveStandartRoom(stRoom, dateFrom, dateTo);
                }
                else if (option == 'l')
                    allCustomers.getListOfCustomers().Where(x => x.getName() == customer.getName()).First().reserveLuxRoom(luxRoom, dateFrom, dateTo);
            }

        }

        public void saveChangesToExistingFile(ObservableCollection<Room> myObjects)
        {
            StreamWriter sw = new StreamWriter(path, false);
            String[] lines = new string[myObjects.Count];
            int i = 0;
            String str = "";
            foreach (var item in myObjects)
            {
                str += "hotel ";
                str += item.HotelName + " ";
                str += item.Stars;
                str += "\n";
                str += item.Number + " ";
                str += item.Rooms + " ";
                str += item.Beds + " ";
                str += item.Windows + " ";
                str += item.Square + " ";
                str += item.Price + " " + "\n";
                lines[i] = str;
                i++;

            }
            sw.Write(str);
            sw.Close();
        }
        public void saveAs(ObservableCollection<Room> myObjects)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;

                StreamWriter sw = new StreamWriter(filename, false);
                String[] lines = new string[myObjects.Count];
                int i = 0;
                String str = "";
                foreach (var item in myObjects)
                {
                    str += "hotel ";
                    str += item.HotelName + " ";
                    str += item.Stars;
                    str += "\n";
                    str += item.Number + " ";
                    str += item.Rooms + " ";
                    str += item.Beds + " ";
                    str += item.Windows + " ";
                    str += item.Square + " ";
                    str += item.Price + " " + "\n";
                    lines[i] = str;
                    i++;

                }
                sw.Write(str);
                sw.Close();
            }
        }
    }
}
