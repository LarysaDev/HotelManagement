using HotelManagement.BookingForm;
using HotelManagement.Customers;
using HotelManagement.Rooms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using static HotelManagement.Reservation.ReservationWindow;
using static System.Net.WebRequestMethods;

namespace HotelManagement.Reservation
{
    /// <summary>
    /// Interaction logic for ReservationWindow.xaml
    /// </summary>
    public partial class ReservationWindow : Window
    {
        Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
        FileManager fileManager;
      
        public class Room
        {
            public String HotelName { get; set; }
            public int Stars { get; set; }
            public int Number { get; set; }
            public int Rooms { get; set; }
            public int Beds { get; set; }
            public int Windows { get; set; }
            public double Square { get; set; }
            public bool Appliances { get; set; }
            public double Price { get; set; }

          
        }
        ObservableCollection<Room> myObjects;

        public ReservationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingForm = new BookingWindow();
            bookingForm.ShowDialog();
            if(bookingForm.Visibility == Visibility.Hidden)
            {
                bookingForm.Close();
                DateTime userDateFrom = new DateTime();
                DateTime userDateTo = new DateTime();
                double userPriceFrom = 0;
                double userPriceTo = 0;
                int userStars = 0;

                if (dateFrom.SelectedDate != null)
                {
                    userDateFrom = dateFrom.SelectedDate.Value;
                    if (dateTo.SelectedDate != null)
                    {
                        userDateTo = dateTo.SelectedDate.Value;
                    }
                }
                String value = "";
                foreach (Room room in listOfRooms.SelectedItems)
                {
                    value = System.Convert.ToString(room.Number);
                   
                }
                Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
                if (value.StartsWith("2"))
                {
                    int roomN = System.Convert.ToInt32(value);
                    LuxRoom room = new LuxRoom();
                    foreach(var hotel in allHotels.getListOfHotels())
                    {
                        foreach(var luxRoom in hotel.getLuxRooms())
                        {
                            if (luxRoom.getNumber() == roomN) room = luxRoom;
                        }
                    }
                   
                    allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveLuxRoom(room, userDateFrom, userDateTo);
                }
                else
                {
                    int roomN = System.Convert.ToInt32(value);
                    StandartRoom room = new StandartRoom();
                    foreach (var hotel in allHotels.getListOfHotels())
                    {
                        foreach (var stRoom in hotel.getStandartRooms())
                        {
                            if (stRoom.getNumber() == roomN) room = stRoom;
                        }
                    }
                    allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveStandartRoom(room, userDateFrom, userDateTo);
                }
             
            }

        }


        private void cm_open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                fileManager = new FileManager(filename);
            }

            List<Hotel> list = new List<Hotel>();
            list = fileManager.createList();

            var dg = listOfRooms;
            myObjects = new ObservableCollection<Room>();

            foreach (Hotel hotel in list)
            {
                List<StandartRoom> stRooms = hotel.getStandartRooms();
                if (stRooms != null)
                    foreach (var room in stRooms)
                    {
                        myObjects.Add(new Room()
                        {
                            HotelName = hotel.getName(),
                            Stars = hotel.getStars(),
                            Number = room.getNumber(),
                            Rooms = room.getRoomsAmount(),
                            Beds = room.getBeds(),
                            Windows = room.getWindows(),
                            Square = room.getSquare(),
                            Appliances = room.hasHouseholdAppliances(),
                            Price = room.getPrice()
                        });
                    }
                List<LuxRoom> luxRooms = hotel.getLuxRooms();
                if (luxRooms != null)
                    foreach (var room in luxRooms)
                    {
                        myObjects.Add(new Room()
                        {
                            HotelName = hotel.getName(),
                            Stars = hotel.getStars(),
                            Number = room.getNumber(),
                            Rooms = room.getRoomsAmount(),
                            Beds = room.getBeds(),
                            Windows = room.getWindows(),
                            Square = room.getSquare(),
                            Appliances = room.hasHouseholdAppliances(),
                            Price = room.getPrice()
                        });
                    }
            }
            this.listOfRooms.ItemsSource = myObjects;

        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                fileManager = new FileManager(filename);
            }

            List<Hotel> list = new List<Hotel>();
            list = fileManager.createList();
            
            var dg = listOfRooms;
            myObjects = new ObservableCollection<Room>();

            foreach (Hotel hotel in list)
            {
                List<StandartRoom> stRooms = hotel.getStandartRooms();
                if (stRooms != null)
                    foreach (var room in stRooms)
                    {
                        myObjects.Add(new Room()
                        {
                            HotelName = hotel.getName(),
                            Stars = hotel.getStars(),
                            Number = room.getNumber(),
                            Rooms = room.getRoomsAmount(),
                            Beds = room.getBeds(),
                            Windows = room.getWindows(),
                            Square = room.getSquare(),
                            Appliances = room.hasHouseholdAppliances(),
                            Price = room.getPrice()
                        }) ; 
                    }
                List<LuxRoom> luxRooms = hotel.getLuxRooms();
                if (luxRooms != null)
                    foreach (var room in luxRooms)
                    {
                        myObjects.Add(new Room()
                        {
                            HotelName = hotel.getName(),
                            Stars = hotel.getStars(),
                            Number = room.getNumber(),
                            Rooms = room.getRoomsAmount(),
                            Beds = room.getBeds(),
                            Windows = room.getWindows(),
                            Square = room.getSquare(),
                            Appliances = room.hasHouseholdAppliances(),
                            Price = room.getPrice()
                        });
                    }
            }
            
            this.listOfRooms.ItemsSource = myObjects;
            
        }
        private void cm_save_Click(object sender, RoutedEventArgs e)
        {
            fileManager.saveChangesToExistingFile(myObjects);
        }
        private void cm_paste_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.GetText();
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            fileManager.saveChangesToExistingFile(myObjects);
        }
        private void saveAs_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                fileManager.saveAs(filename, myObjects);
            }
        }
        private void cm_saveAs_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                fileManager.saveAs(filename, myObjects);
            }
        }
        private void cut_Click(object sender, RoutedEventArgs e)
        {

        }
        private void copy_Click(object sender, RoutedEventArgs e)
        {

        }
        private void paste_Click(object sender, RoutedEventArgs e)
        {

        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        
            
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         
            var dg = listOfRooms;
            myObjects = new ObservableCollection<Room>();
            List<Hotel> hotels = allHotels.getListOfHotels();
            
            foreach (Hotel hotel in hotels)
              {
                List<StandartRoom> stRooms = hotel.getStandartRooms();
                 if(stRooms != null)
                     foreach (var room in stRooms)
                  {
                     myObjects.Add(new Room() {
                     HotelName = hotel.getName(),
                     Stars = hotel.getStars(),
                     Number = room.getNumber(),
                     Rooms = room.getRoomsAmount(),
                     Beds = room.getBeds(),
                     Windows = room.getWindows(),
                     Square = room.getSquare(),
                     Appliances = room.hasHouseholdAppliances(),
                     Price = room.getPrice()});
                  }
                List<LuxRoom> luxRooms = hotel.getLuxRooms();
                if (luxRooms != null)
                    foreach (var room in luxRooms)
                    {
                        myObjects.Add(new Room()
                        {
                            HotelName = hotel.getName(),
                            Stars = hotel.getStars(),
                            Number = room.getNumber(),
                            Rooms = room.getRoomsAmount(),
                            Beds = room.getBeds(),
                            Windows = room.getWindows(),
                            Square = room.getSquare(),
                            Appliances = room.hasHouseholdAppliances(),
                            Price = room.getPrice()
                        });
                    }
            }
            this.listOfRooms.ItemsSource = myObjects;
        }
        bool getStandart = false;
        bool getLux = false;
      
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DateTime userDateFrom = new DateTime() ;
            DateTime userDateTo = new DateTime();
            double userPriceFrom = 0;
            double userPriceTo = 0;
            int userStars = 0;

            if (dateFrom.SelectedDate != null)
            {
                userDateFrom = dateFrom.SelectedDate.Value;
                if (dateTo.SelectedDate != null) { 
                    userDateTo = dateTo.SelectedDate.Value;
                }
            }
            bool isInBudget = true;
            if (priceFrom.Text != "")
            {
                userPriceFrom = System.Convert.ToDouble(priceFrom.Text);
                if (priceTo.Text != "")
                {
                    userPriceTo = System.Convert.ToDouble(priceTo.Text);
                }
                else
                {

                }
            }
            if(stars.Value != 0)
            {
                userStars = (int)(stars.Value / 2 + 1);
            }

            myObjects.Clear();
            listOfRooms.Items.Refresh();

            if(checkboxSt.IsChecked == true)
            {
                getStandart = true;
            }
            if(checkboxSt.IsChecked == false)
            {
                getStandart = false;
            }
            if (checkboxLx.IsChecked == false)
            {
                getLux = false;
            }
            if (checkboxLx.IsChecked == true)
            {
                getLux = true;
            }
            bool isReserved = false;
            
            foreach (Hotel hotel in allHotels.getFiltratedHotels(userStars))
            {
              
                if (getStandart == true)
                {
                    List<StandartRoom> stRooms = hotel.getStandartRooms();
      
                    if (stRooms != null)
                        foreach (var room in stRooms)
                        {
                            if(dateFrom != null)
                            {
                                if(dateTo != null)
                                {
                                    isReserved = room.checkIfReserved(userDateFrom, userDateTo);
                                }else
                                {
                                    isReserved = room.checkIfReserved(userDateFrom, userDateFrom);
                                }
                            }
                            if(isReserved == false)
                            {
                                if (userPriceFrom != 0)
                                {
                                    if (userPriceTo != 0)
                                    {
                                        isInBudget = room.isAffordable(userPriceFrom, userPriceTo);
                                    }
                                    else isInBudget = room.isAffordable(userPriceFrom, userPriceFrom+1);
                                }
                                if (isInBudget)
                                {
                                    myObjects.Add(new Room()
                                    {
                                        HotelName = hotel.getName(),
                                        Stars = hotel.getStars(),
                                        Number = room.getNumber(),
                                        Rooms = room.getRoomsAmount(),
                                        Beds = room.getBeds(),
                                        Windows = room.getWindows(),
                                        Square = room.getSquare(),
                                        Appliances = room.hasHouseholdAppliances(),
                                        Price = room.getPrice()
                                    });
                                }
                               
                            } 
                           
                        }
                }
                   if(getLux == true)
                {
                    List<LuxRoom> luxRooms = hotel.getLuxRooms();
                    if (luxRooms != null)
                        foreach (var room in luxRooms)
                        {
                            if (dateFrom != null)
                            {
                                if (dateTo != null)
                                {
                                    isReserved = room.checkIfReserved(userDateFrom, userDateTo);
                                }
                                else
                                {
                                    isReserved = room.checkIfReserved(userDateFrom, userDateFrom);
                                }
                            }
                            if (isReserved == false)
                            {
                                if (userPriceFrom != 0)
                                {
                                    if (userPriceTo != 0)
                                    {
                                        isInBudget = room.isAffordable(userPriceFrom, userPriceTo);
                                    }
                                    else isInBudget = room.isAffordable(userPriceFrom, userPriceFrom + 1);
                                }
                                if (isInBudget)
                                {
                                    myObjects.Add(new Room()
                                    {
                                        HotelName = hotel.getName(),
                                        Stars = hotel.getStars(),
                                        Number = room.getNumber(),
                                        Rooms = room.getRoomsAmount(),
                                        Beds = room.getBeds(),
                                        Windows = room.getWindows(),
                                        Square = room.getSquare(),
                                        Appliances = room.hasHouseholdAppliances(),
                                        Price = room.getPrice()
                                    });
                                }
                            }
                        }
                }
                   
                }

            }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            getStandart = true;
        }

        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            getLux = false;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            getStandart = true;
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            getLux = true;
        }

        public bool checkStandartReservation(StandartRoom room, DateTime userDateFrom, DateTime userDateTo)
        {
            bool isReservedStandart = false;
           
            if (dateFrom != null)
            {
                if (dateTo != null)
                {
                    isReservedStandart = room.checkIfReserved(userDateFrom, userDateTo);
                }
                else
                {
                    isReservedStandart = room.checkIfReserved(userDateFrom, userDateFrom);
                }
            }
            return isReservedStandart;
        }
        public bool checkLuxReservation(LuxRoom room, DateTime userDateFrom, DateTime userDateTo)
        {
            bool isReservedLux = false;
            if (dateFrom != null)
            {
                if (dateTo != null)
                {
                    isReservedLux = room.checkIfReserved(userDateFrom, userDateTo);
                }
                else
                {
                    isReservedLux = room.checkIfReserved(userDateFrom, userDateFrom);
                }
            }
            return isReservedLux;
        }
       
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            myObjects.Clear();
            listOfRooms.Items.Refresh();
            //6.Знаходження найпопулярнішого запиту в діапазоні заданих дат.
            // визначення за кількістю бронювань до цього часу та який вільний у заданому діапазоні дат
            DateTime userDateFrom = new DateTime();
            DateTime userDateTo = new DateTime();

            bool getLux = true;
            bool getStandart = true;

            if (checkboxSt.IsChecked == true)
            {
                getStandart = true;
            }
            if (checkboxSt.IsChecked == false)
            {
                getStandart = false;
            }
            if (checkboxLx.IsChecked == false)
            {
                getLux = false;
            }
            if (checkboxLx.IsChecked == true)
            {
                getLux = true;
            }

            if (dateFrom.SelectedDate != null)
            {
                userDateFrom = dateFrom.SelectedDate.Value;
                if (dateTo.SelectedDate != null)
                {
                    userDateTo = dateTo.SelectedDate.Value;
                }
                else
                {
                    userDateTo = userDateFrom; 
                }
            }
           

            bool isReservedStandart = false;
            bool isReservedLux = false;
           
            if (getStandart == true)
            {

                StandartRoom bestStRoom = allHotels.getBestStRoom();
                isReservedStandart = checkStandartReservation(bestStRoom, userDateFrom, userDateTo);

                if (isReservedStandart == false)
                {
                    String name = "";
                    int stars = 0;
                    foreach(var hotel in allHotels.getListOfHotels())
                    {
                        foreach(var room in hotel.getStandartRooms())
                        {
                            if (room.getNumber() == bestStRoom.getNumber())
                            {
                                name = hotel.getName();
                                stars = hotel.getStars(); 
                            }
                        }
                    }
                    myObjects.Add(new Room()
                    {
                        HotelName = name,
                        Stars = stars,
                        Number = bestStRoom.getNumber(),
                        Rooms = bestStRoom.getRoomsAmount(),
                        Beds = bestStRoom.getBeds(),
                        Windows = bestStRoom.getWindows(),
                        Square = bestStRoom.getSquare(),
                        Appliances = bestStRoom.hasHouseholdAppliances(),
                        Price = bestStRoom.getPrice()
                    }); ;
                }
                else
                {
                    List<StandartRoom> stPropositions = allHotels.getStandartProposition();
                    foreach (var room in stPropositions)
                    {
                        isReservedStandart = checkStandartReservation(room, userDateFrom, userDateTo);
                        if (isReservedStandart == false)
                        {
                            String name = "";
                            int stars = 0;
                            foreach (var hotel in allHotels.getListOfHotels())
                            {
                                foreach (var room1 in hotel.getStandartRooms())
                                {
                                    if (room1.getNumber() == room.getNumber())
                                    {
                                        name = hotel.getName();
                                        stars = hotel.getStars();
                                    }
                                }
                            }
                            myObjects.Add(new Room()
                            {
                                HotelName=name,
                                Stars=stars,
                                Number = room.getNumber(),
                                Rooms = room.getRoomsAmount(),
                                Beds = room.getBeds(),
                                Windows = room.getWindows(),
                                Square = room.getSquare(),
                                Appliances = room.hasHouseholdAppliances(),
                                Price = room.getPrice()
                            });
                        }
                    }

                }
            }
            if (getLux == true)
            {
                LuxRoom bestLuxRoom = allHotels.getBestLuxRoom();
                isReservedLux = checkLuxReservation(bestLuxRoom, userDateFrom, userDateTo);

                if (isReservedLux == false)
                {
                    String name = "";
                    int stars = 0;
                    foreach (var hotel in allHotels.getListOfHotels())
                    {
                        foreach (var room in hotel.getLuxRooms())
                        {
                            if (room.getNumber() == bestLuxRoom.getNumber())
                            {
                                name = hotel.getName();
                                stars = hotel.getStars(); 
                            }
                        }
                    }
                    myObjects.Add(new Room()
                    {
                        HotelName = name,
                        Stars = stars,
                        Number = bestLuxRoom.getNumber(),
                        Rooms = bestLuxRoom.getRoomsAmount(),
                        Beds = bestLuxRoom.getBeds(),
                        Windows = bestLuxRoom.getWindows(),
                        Square = bestLuxRoom.getSquare(),
                        Appliances = bestLuxRoom.hasHouseholdAppliances(),
                        Price = bestLuxRoom.getPrice()
                    });
                }
                else
                {
                    List<LuxRoom> luxPropositions = allHotels.getLuxProposition();
                    foreach (var room in luxPropositions)
                    {
                        isReservedLux = checkLuxReservation(room, userDateFrom, userDateTo);
                        if (isReservedLux == false)
                        {
                            String name = "";
                            int stars = 0;
                            foreach (var hotel in allHotels.getListOfHotels())
                            {
                                foreach (var room1 in hotel.getLuxRooms())
                                {
                                    if (room1.getNumber() == room.getNumber())
                                    {
                                        name = hotel.getName();
                                        stars = hotel.getStars();
                                    }
                                }
                            }
                            myObjects.Add(new Room()
                            {
                                HotelName = name,
                                Stars = stars,
                                Number = room.getNumber(),
                                Rooms = room.getRoomsAmount(),
                                Beds = room.getBeds(),
                                Windows = room.getWindows(),
                                Square = room.getSquare(),
                                Appliances = room.hasHouseholdAppliances(),
                                Price = room.getPrice()
                            });
                        }
                    }
                }
            }
            //альтернатива, якшо нема вільних варіантів 
            //беремо інші номери (стандарт + люкс), які мають кі-сть бронювань на 1 меншу і які вільні у певні дати

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CustomersInfo customersInfo = new CustomersInfo();
            this.Hide();
            customersInfo.Show();
        }
    }
    }

