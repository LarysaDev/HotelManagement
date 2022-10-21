using HotelManagement.Customers;
using HotelManagement.Exceptions;
using HotelManagement.Rooms;
using System;
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

namespace HotelManagement.BookingForm
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        public BookingWindow()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
            int age = 0;
            String name = "", lastname="", email="", phone="";
            Customer customer;
            try
            {
                
                if(ageField.Text.Length == 0)
                {
                    throw new EmptyInputException("Age");
                } else age = System.Convert.ToInt32(ageField.Text);

                if (nameField.Text.Length == 0)
                {
                    throw new EmptyInputException("Name");
                }
                else name = nameField.Text;

                if (lastnameField.Text.Length == 0)
                {
                    throw new EmptyInputException("Lastname");
                }
                else lastname = lastnameField.Text;

                if (emailField.Text.Length == 0)
                {
                    throw new EmptyInputException("Email");
                }
                else email = emailField.Text;

                if (phoneField.Text.Length == 0)
                {
                    throw new EmptyInputException("Phone");
                }
                else phone = phoneField.Text;
                customer = new Customer(name, lastname, email, phone, age);
                allCustomers.addCustomer(customer);
                this.Hide();
            }
            catch (EmptyInputException ex)
            {
                MessageBox.Show(ex.Message);
            } 
            
        }
    }
}
