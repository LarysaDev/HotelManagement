using HotelManagement.Rooms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

       

        public List<Room> rooms = new List<Room>();
        
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

            for (int i = 1; i < 8; ++i)
            {
                var column = new DataGridTextColumn();
                switch (i)
                {
                    case 1:
                        column.Header = "Number";
                        break;
                    case 2:
                        column.Header = "Rooms";
                        break;
                    case 3:
                        column.Header = "Beds";
                        break;
                    case 4:
                        column.Header = "Windows";
                        break;
                    case 5:
                        column.Header = "Square";
                        break;
                    case 6:
                        column.Header = "Appliances";
                        break;
                    case 7:
                        column.Header = "Price";
                        break;
                }
               
                column.Binding = new Binding((string)column.Header);
                dg.Columns.Add(column);
            }

            HashSet<Hotel> hotels = allHotels.getListOfHotels();
              foreach (Hotel hotel in hotels)
              {
                HashSet<StandartRoom> stRooms = hotel.getStandartRooms();
                 if(stRooms != null)
                     foreach (var room in stRooms)
                  {
                     rooms.Add(new Room() {
                     Number = room.getNumber(),
                     Rooms = room.getRoomsAmount(),
                     Beds = room.getBeds(),
                     Windows = room.getWindows(),
                     Square = room.getSquare(),
                     Appliances = room.hasHouseholdAppliances(),
                     Price = room.getPrice()});
                  }
                HashSet<LuxRoom> luxRooms = hotel.getLuxRooms();
                if (luxRooms != null)
                    foreach (var room in luxRooms)
                    {
                        rooms.Add(new Room()
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
            

            foreach (var item in rooms)
            {
                dg.Items.Add(item);
            }

        }
    }
}
