using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Air_line_Managment_System
{
    public partial class aeroplan_system : UserControl
    {
        public aeroplan_system()
        {
            InitializeComponent();
            seats1.Hide();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            string ticketclass = Ticketclassbox.Text;
            string Booking = Bookingbox.Text;
            string from = frombox.Text;
            string Emails = Air_line_Managment_System.Joinus.Email;
            int count = 0;
            ////if (string.Compare(ticketclass, "Ticket Class") != 1)
            ////{
            ////    Ticketclassbox.BackColor = Color.Red;
            ////    count++;
            ////}
            ////if (string.Compare(Booking, "Booking") == 1)
            ////{
            ////    Ticketclassbox.BackColor = Color.Red;
            ////    count++;
            ////}
            //if (string.Compare(from, "From") == 1)
            //{
            //    Ticketclassbox.BackColor = Color.Red;
            //    count++;
            //}
            //else
            //{
                SqlConnection con = new SqlConnection("Data Source=HASSAM_ALI\\HASSAMSQL;Initial Catalog=Aeroplane;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Booking values('" + Emails + "','" + ticketclass + "','" + Booking + "','" + from + "','')";
                cmd.ExecuteNonQuery();
                con.Close();
                seats1.Show();
            //}
            
        }
    }
}
