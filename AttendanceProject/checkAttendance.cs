using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceProject
{
    public partial class checkAttendance : Form
    {
        public checkAttendance()
        {
            InitializeComponent();
        }
        int ID;
        string chkInDate ;
        string chkInTime ;
        DateTime time2 ;
        DateTime time1 ;

        string chkOutDate ;
        string chkOutTime ;
        DateTime systime ;
        DateTime date1;
        int OT;

        string whours;

        private void Checkin_Click(object sender, EventArgs e)
        {
            chkInDate = DateTime.Now.ToLongDateString();
            chkInTime = DateTime.Now.ToLongTimeString();





            ID = int.Parse(id1.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Degree Program\C# Projects\AttendanceProject\Attendance.mdf';Integrated Security=True;Connect Timeout=30");
            con.Open();
            

            //Select checkout status
            string sqli = "select CheckOutStatus from Attendence tal1 where tal1.id = '" + ID + "' and tal1.CheckInDate = (select max(tal2.CheckInDate) from Attendence tal2 where tal2.id = tal1.id)";
            SqlCommand cmd2 = new SqlCommand(sqli, con);
            /*SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView1.DataSource = dt1;*/


            

           





            string checkOutStatus;

            var reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                checkOutStatus = reader["CheckOutStatus"].ToString();

                if (checkOutStatus.Equals("1"))
                {

                    //Insert check in details
                    
                    string sql = "INSERT INTO Attendence (Id,CheckInDate,CheckInTime,CheckInStatus) VALUES('" + ID + "','" + chkInDate + "','" + chkInTime + "','1')";
                    
                    try
                    {
                        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Degree Program\C# Projects\AttendanceProject\Attendance.mdf';Integrated Security=True;Connect Timeout=30");
                        con1.Open();
                        SqlCommand cmd = new SqlCommand(sql, con1);
                        cmd.ExecuteNonQuery();
                        DialogResult dialogResult = MessageBox.Show("You are successfully checked in ");
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show("" + se);
                    }
                    finally
                    {
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("Sorry You haven't checked out yesterday");
                }

            }

            id1.Clear();

        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            time2 = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
            chkOutDate = DateTime.Now.ToShortDateString();
            chkOutTime = DateTime.Now.ToLongTimeString();
            systime = Convert.ToDateTime(DateTime.Now.ToLongDateString());

            ID = int.Parse(id2.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Degree Program\C# Projects\AttendanceProject\Attendance.mdf';Integrated Security=True;Connect Timeout=30");
            con.Open();


            //Solving working hours
            string sqli = "select CheckInTime from Attendence tal1 where tal1.id = '" + ID + "' and tal1.CheckInDate = (select max(tal2.CheckInDate) from Attendence tal2 where tal2.id = tal1.id)";
            SqlCommand cmd2 = new SqlCommand(sqli, con);
            /*SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView1.DataSource = dt1;*/

            var reader = cmd2.ExecuteReader();

            string t1;

            while (reader.Read())
            {
                t1 = reader["CheckInTime"].ToString();
                time1 = Convert.ToDateTime(t1);


                
                whours = time2.Subtract(time1).Hours.ToString();
                
               int cal = int.Parse(whours);
                if (cal > 8)
                {
                    OT = cal - 8;
                }else
                { cal = 0; }
            }
            con.Close();


            //Update Query
            ID = int.Parse(id2.Text);
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Degree Program\C# Projects\AttendanceProject\Attendance.mdf';Integrated Security=True;Connect Timeout=30");
            
            con2.Open();


            //Select recent checkindate
            string datesql = "select CheckInDate from Attendence tal1 where tal1.id = '" + ID + "' and tal1.CheckInDate = (select max(tal2.CheckInDate) from Attendence tal2 where tal2.id = tal1.id)";
            
            SqlCommand cmd3 = new SqlCommand(datesql, con2);
            
            var reader1 = cmd3.ExecuteReader();

            string chkedDate;

            while (reader1.Read())
            {
                chkedDate = reader1["CheckInDate"].ToString();
                date1 = Convert.ToDateTime(chkedDate);
                


                if (date1 == systime)
                {   

                    

                    try
                    {
                        
                        SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Degree Program\C# Projects\AttendanceProject\Attendance.mdf';Integrated Security=True;Connect Timeout=30");
                        String updatesql = "UPDATE  Attendence SET CheckOutDate = '" + chkOutDate + "',CheckOutTime = '" + chkOutTime + "',CheckOutStatus = 1,WorkHours = '" + whours + "' , OtHours =  '" + OT + "' WHERE id = '" + ID + "' AND CheckInDate = '" + chkInDate + "'";
                        con3.Open();
                        SqlCommand cmd4 = new SqlCommand(updatesql, con3);
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("Goodbye, be on time tomorrow");
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show("" + se);
                    }
                }else
                {
                    MessageBox.Show("Sorry, You can't Checkout. Contact MANAGEMENT");
                }



            }
            id2.Clear();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WorkReport wr = new WorkReport();
            wr.Show();
        }

       
    }
}
