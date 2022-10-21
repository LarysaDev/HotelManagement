using HotelManagement.BookingForm;
using HotelManagement.Customers;
using HotelManagement.Exceptions;
using HotelManagement.Reservation.DataGridRoomClass;
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
        FileManager fileManager = new FileManager();
     
        ObservableCollection<Room> myObjects;
        ObservableCollection<Room> allObjects;
        public ReservationWindow()
        {
            InitializeComponent();
            Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
            Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
        }
        private static ObservableCollection<Room> displayList(List<Hotel> list, DataGrid listOfRooms, ObservableCollection<Room> myObjects)
        {
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

            listOfRooms.ItemsSource = myObjects;

            return myObjects;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {

                if (dateFrom.Text.Length > 0)
                {


                    BookingWindow bookingForm = new BookingWindow();
                    bookingForm.ShowDialog();
                    if (bookingForm.Visibility == Visibility.Hidden)
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
                                userDateTo = dateTo.SelectedDate.Value;
                        }
                        String value = "";
                        foreach (Room room in listOfRooms.SelectedItems)
                            value = System.Convert.ToString(room.Number);

                        Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
                        if (value.StartsWith("2"))
                        {
                            int roomN = System.Convert.ToInt32(value);
                            LuxRoom room = new LuxRoom();
                            foreach (var hotel in allHotels.getListOfHotels())
                                foreach (var luxRoom in hotel.getLuxRooms())
                                    if (luxRoom.getNumber() == roomN) room = luxRoom;

                            allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveLuxRoom(room, userDateFrom, userDateTo);
                        }
                        else
                        {
                            int roomN = System.Convert.ToInt32(value);
                            StandartRoom room = new StandartRoom();
                            foreach (var hotel in allHotels.getListOfHotels())
                                foreach (var stRoom in hotel.getStandartRooms())
                                    if (stRoom.getNumber() == roomN) room = stRoom;

                            allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveStandartRoom(room, userDateFrom, userDateTo);
                        }

                    }

                }
                else throw new NoSetDataException("");
            
            }
            
            catch(NoSetDataException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cm_open_Click(object sender, RoutedEventArgs e)
        {
            List<Hotel> hotelSet = new List<Hotel>();
            List<LuxRoom> standartRooms1 = new List<LuxRoom>();
            List<LuxRoom> luxRooms1 = new List<LuxRoom>();  
            fileManager.openFile();
            List<Hotel> list = new List<Hotel>();
            list = fileManager.createList();
            myObjects = displayList(list,listOfRooms, myObjects);
            allHotels.addHotels(list);
            listOfRooms.ItemsSource = myObjects;
            allObjects = new ObservableCollection<Room>();
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            fileManager.openFile();
            List<Hotel> list = new List<Hotel>();
            list = fileManager.createList();
            myObjects = displayList(list, listOfRooms, myObjects);
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
           fileManager.saveAs(myObjects);
        }
        private void cm_saveAs_Click(object sender, RoutedEventArgs e)
        {
            fileManager.saveAs(myObjects);
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

            if (myObjects.Count > 0)
            {
                myObjects.Clear();
            }
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
            if(getStandart == true)
            {
               myObjects =  allHotels.filtrateStandartRooms(myObjects, userStars, userDateFrom, userDateTo, dateFrom, dateTo, userPriceFrom, userPriceTo);
            }
            if(getLux == true)
            {
                myObjects = allHotels.filtrateLuxRooms(myObjects, userStars, userDateFrom, userDateTo, dateFrom, dateTo, userPriceFrom, userPriceTo);
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
            //Знаходження найпопулярнішого запиту в діапазоні заданих дат.
            // визначення за кількістю бронювань до цього часу та який вільний у заданому діапазоні дат
            // альтернатива, якшо нема вільних варіантів
            //беремо інші номери (стандарт + люкс), які мають кі-сть бронювань від 1 разу і які вільні у певні дати
            DateTime userDateFrom = new DateTime();
            DateTime userDateTo = new DateTime();

            bool getLux = true;
            bool getStandart = true;

            if (checkboxSt.IsChecked == true)getStandart = true;
            if (checkboxSt.IsChecked == false) getStandart = false;
            if (checkboxLx.IsChecked == false) getLux = false;
            if (checkboxLx.IsChecked == true)getLux = true;

            try {
                if (dateFrom.Text.Length > 0)
                {
                    userDateFrom = dateFrom.SelectedDate.Value;
                    if (dateTo.SelectedDate != null) userDateTo = dateTo.SelectedDate.Value;
                    else userDateTo = userDateFrom;

                    bool isReservedStandart = false;
                    bool isReservedLux = false;

                    if (getStandart == true) myObjects = allHotels.getListOfBestStandartRooms(myObjects, userDateFrom, userDateTo, dateFrom, dateTo);
                    if (getLux == true) myObjects = allHotels.getListOfBestLuxRooms(myObjects, userDateFrom, userDateTo, dateFrom, dateTo);
                }
                else throw new NoSetDataException("");
            }
            catch(NoSetDataException ex)
            {
                MessageBox.Show(ex.Message);
            }   
           

        }   
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CustomersInfo customersInfo = new CustomersInfo();
            customersInfo.Show();
        }

        private void addNumber(object sender, RoutedEventArgs e)
        {
            NewRoom nRoom = new NewRoom();
            nRoom.ShowDialog();
            List<Hotel> list = new List<Hotel>();

            if (nRoom.Visibility == Visibility.Hidden)
            {
                myObjects.Clear();
                listOfRooms.Items.Refresh();
                list = allHotels.getListOfHotels();
                myObjects = displayList(list, listOfRooms, myObjects);
            }
        }
    }
    }

