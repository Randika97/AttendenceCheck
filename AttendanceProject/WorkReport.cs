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
    public partial class WorkReport : Form
    {
        public WorkReport()
        {
            InitializeComponent();
        }

        private void WorkReport_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;



            int ID = int.Parse(txt1.Text);

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Degree Program\C# Projects\AttendanceProject\Attendance.mdf';Integrated Security=True;Connect Timeout=30");
            string Total = "select Sum(WorkHours),Sum(OtHours) FROM Attendence WHERE id = '" + ID + "' AND (CheckInDate >='" + date1 + "' AND CheckOutDate <='" + date2 + "') ";
            SqlCommand cmd2 = new SqlCommand(Total, con2);

            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
    }
}
