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
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
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
      
        public void openFile()
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
                if (System.IO.File.ReadAllLines(path).Length == 0) throw new EmptyFileException("");
            }
            catch (EmptyFileException ex)
            {
                MessageBox.Show(ex.Message);
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
                if (index != lines.Length && lines[index].StartsWith("hotel")){ 
                    list.Add(hotel1);
                    hotel1 = new Hotel();
                }
            }
            return list;
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
                str += item.HotelName+ " ";
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
