using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_01
{
    public partial class Form1 : Form
    {
        public int x2;
        public int y2;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged+=ComboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged+=ComboBox1_SelectedValueChanged;
            //comboBox1.Text ="2";
            //button1.MouseEnter+=Button1_MouseEnter;
            //button1.MouseLeave+=Button1_MouseLeave;
            ////button1.MouseHover+=Button1_MouseHover;
            ////button1.MouseWheel+=Button1_MouseWheel;
            ////button1.MouseMove+=Button1_MouseMove;
            //button1.MouseDown+=Button1_MouseDown;
            //button1.MouseUp+=Button1_MouseUp;
            //button2.MouseMove+=Button2_MouseMove;
            //button2.MouseLeave+=Button2_MouseLeave;
            this.MouseMove+=Form1_MouseMove;
            //button2.MouseDown+=Button2_MouseDown;
            //button2.MouseMove+=Button2_MouseMove1;
            this.MouseDown+=Form1_MouseDown;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            //this.Text = "X :" + x2.ToString() + "   Y :" + y2.ToString();
            //button2.Location = new Point(x2, y2);
        }

        private void Button2_MouseMove1(object sender, MouseEventArgs e)
        {
            
        }

        private void Button2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            this.Text = "X :" + x2.ToString() + "   Y :" + y2.ToString();
            
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "MouseLeave";
        }

        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Text = "MouseMove";
            //this.Text = e.X.ToString();
            int x1 = e.X;
            int y1 = e.Y;
            button2.Location = new Point(x2+x1, y2+y1);
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Text = "MouseUp";
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Text = "MouseDown";
            button1.Location = new Point(x2, y2);
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = "MouseMove";
        }

        private void Button1_MouseWheel(object sender, MouseEventArgs e)
        {
            button1.Text = "MouseWheel";
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "MouseHover";
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "MouseLeave";
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "MouseEnter";
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedItem.ToString() == "3")
          if (comboBox1.SelectedText == "3")
                {
                this.BackColor = Color.Green;
            }

            //this.BackColor = Color.Orange;

            if (comboBox1.Items.Contains(1))
            {
                //this.Text =" OK";
            }
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Text ="Deneme";
            comboBox1.Items.Add("1");
            //comboBox1.Items.Add(2);
            //comboBox1.Items.Add("3");
            //if(comboBox1.Text ==string.Empty)
          if (comboBox1.Text =="")
            {
                this.Text ="OK";
            }

            //label1.Font = new Font(label1.Font.FontFamily,18);
            label1.Font = new Font(label1.Font,FontStyle.Bold);
            button1.Font = new Font(button1.Font,FontStyle.Bold);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = comboBox1.Text;
            //label1.Text = comboBox1.SelectedItem.GetType().Name;
            //this.Text = comboBox1.SelectedItem.ToString();
            if (!(comboBox1.Text == ""))
            {
                String name1 = comboBox1.SelectedItem.GetType().Name;
                label1.Text = name1;
                if (name1 == "String")
                {
                    this.Text= name1;
                }

                if (name1 =="Int32")
                {
                    this.Text = name1;
                }
            }
            else
            {
                MessageBox.Show("Selected");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
