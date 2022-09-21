using HotelManagement.Rooms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
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

namespace HotelManagement.Reservation
{
    /// <summary>
    /// Interaction logic for ReservationWindow.xaml
    /// </summary>
    public partial class ReservationWindow : Window
    {
        Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;

      
        public class Room
        {
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
            this.Hide();
            MainWindow mainW = new MainWindow();
            mainW.Show();
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
    }
    }

