using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //List<DataTest> ls = new List<DataTest>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////MessageBox.Show(comboBox1.SelectedItem.ToString());
            //string strDate = "2018/10/29";

            ////DateTime dt1 = Convert.ToDateTime(strDate);
            ////MessageBox.Show(dt1.ToShortDateString());
            //TestClass test = new TestClass(1);
            //test.times = 47;
            //MessageBox.Show(test.Times.ToString());
            dataGridView1.Rows[0].Cells["Soure"].Value = "SP";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<DataTest> ls = new List<DataTest>();
            ls.Add(new DataTest(1.11, 113, "Saxo"));
            ls.Add(new DataTest(1.11, 113, "Reture"));
            ls.Add(new DataTest(1.11, 113, "SP"));
            ls.Add(new DataTest(1.11, 113, "SP"));
            dataGridView1.DataSource = ls;
            dataGridView1.Refresh();




        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn GenderColumn = new DataGridViewComboBoxColumn();
            GenderColumn.Items.Add("男");
            GenderColumn.Items.Add("女");
            GenderColumn.Items.Add("未知");
            GenderColumn.DefaultCellStyle.NullValue = "男";
            dataGridView1.Columns.Add(GenderColumn);
        }

        private void dataGridView1_AllowUserToResizeRowsChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn GenderColumn = new DataGridViewComboBoxColumn();
            GenderColumn.Items.Add("男");
            GenderColumn.Items.Add("女");
            GenderColumn.Items.Add("未知");
            GenderColumn.DefaultCellStyle.NullValue = "男";
            dataGridView1.Columns.Add(GenderColumn);
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }
        static int i = 1;
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridViewComboBoxColumn GenderColumn = new DataGridViewComboBoxColumn();
            //GenderColumn.Items.Add("男");
            //GenderColumn.Items.Add("女");
            //GenderColumn.Items.Add("未知");
            //GenderColumn.DefaultCellStyle.NullValue = "男";
            //MessageBox.Show(i.ToString());
            //i++;
            //dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Rows[e.RowIndex].Cells.Count - 1].Value = "ffff";
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
           
        }
    }
    public class TestClass
    {
        public int times;
        public int Times
        {
            get
            {
                if(times<=20)
                {
                    return 20;
                }
                else
                {
                    return times;
                }
            }
            set
            {
                if(times<=20)
                {
                    times = 20;
                }
                else
                {
                    times = value;
                }
            }
        }

        public TestClass(int times)
        {
            this.times = times;
        }
    }

    public class DataTest
    {
        public double Bid { get; set; }
        public double Ask { get; set; }
        public string Soure { get; set; }
        public DataTest(double Bid, double Ask, string Soure)
        {
            this.Bid = Bid;
            this.Ask = Ask;
            this.Soure = Soure;
        }
    }
}
