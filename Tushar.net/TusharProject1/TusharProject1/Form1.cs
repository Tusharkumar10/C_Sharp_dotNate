using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TusharProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data saved");
            label8.Text = "Doctor name = " + textBox1.Text + ", Gender = " + comboBox2.SelectedItem + ", Specialization = " + comboBox1.SelectedItem + ", Date Of Birth = " + dateTimePicker1.Value.ToShortDateString() +", Contact number = " + textBox5.Text +", Availability = " +comboBox3.SelectedItem+", Address = " + textBox7.Text ;
            //dateTimePicker1.Value.ToLongDateString();
            //dateTimePicker1.Value = Convert.ToDateTime("24-July-2021");
            //ListViewItem l1=ListViewItem()
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
