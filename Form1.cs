using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            int l, k;
            for (l = 0; l < 3; l++)
            {
                dataGridView1.Rows[l].Height = dataGridView1.Height / 3;
            }
            for (k = 0; k < 3; k++)
            {
                dataGridView1.Columns[k].Width = dataGridView1.Width / 3;
            }

        }
        int p, q;
        Pen olovka = new Pen(Color.Blue);
        bool X = true;
        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            q = e.ColumnIndex;
            p = e.RowIndex;
            int[,] x = new int[p, q];
            if (X)
            {
                dataGridView1[q, p].Value = "X";

                X = false;
                label2.Text = "O";
            }
            else
            {
                dataGridView1[q, p].Value = "O";
                X = true;
                label2.Text = "X";
            }
            if (dataGridView1[0, 0].Value == "X" && dataGridView1[1, 1].Value == "X" && dataGridView1[2, 2].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, 0, 0, dataGridView1.Width, dataGridView1.Height);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;

            }
            else
                if (dataGridView1[0, 0].Value == "O" && dataGridView1[1, 1].Value == "O" && dataGridView1[2, 2].Value == "O")
                {

                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, 5, 5, dataGridView1.Width, dataGridView1.Height);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }
            if (dataGridView1[0, 0].Value == "X" && dataGridView1[1, 0].Value == "X" && dataGridView1[2, 0].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, 0, 26, dataGridView1.Width, dataGridView1.Height - 124);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;

            }
            else
                if (dataGridView1[0, 0].Value == "O" && dataGridView1[1, 0].Value == "O" && dataGridView1[2, 0].Value == "O")
                {
                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, 0, 28, dataGridView1.Width, dataGridView1.Height - 124);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }
            if (dataGridView1[0, 0].Value == "X" && dataGridView1[0, 1].Value == "X" && dataGridView1[0, 2].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, 41, 0, dataGridView1.Width, dataGridView1.Height + 60000);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;

            }
            else
                if (dataGridView1[0, 0].Value =="O" && dataGridView1[0, 1].Value =="O" && dataGridView1[0, 2].Value =="O")
                {
                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, 41, 0, dataGridView1.Width, dataGridView1.Height + 60000);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }
            if (dataGridView1[1, 0].Value == "X" && dataGridView1[1, 1].Value == "X" && dataGridView1[1, 2].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, 120, 0, dataGridView1.Width, dataGridView1.Height + 60000);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;

            }

            else
                if (dataGridView1[1, 0].Value == "O" && dataGridView1[1, 1].Value == "O" && dataGridView1[1, 2].Value == "O")
                {
                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, 120, 0, dataGridView1.Width, dataGridView1.Height + 60000);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }
            if (dataGridView1[2, 0].Value == "X" && dataGridView1[2, 1].Value == "X" && dataGridView1[2, 2].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, 200, 0, dataGridView1.Width, dataGridView1.Height + 60000);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;

            }
            else
                if (dataGridView1[2, 0].Value == "O" && dataGridView1[2, 1].Value == "O" && dataGridView1[2, 2].Value == "O")
                {
                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, 200, 0, dataGridView1.Width, dataGridView1.Height + 60000);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }
            if (dataGridView1[0, 1].Value == "X" && dataGridView1[1, 1].Value == "X" && dataGridView1[2, 1].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, -60000, 0, dataGridView1.Width + 60000, dataGridView1.Height);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;

            }
            else
                if (dataGridView1[0, 1].Value == "O" && dataGridView1[1, 1].Value == "O" && dataGridView1[2, 1].Value == "O")
                {
                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, -60000, 0, dataGridView1.Width + 60000, dataGridView1.Height);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }

            if (dataGridView1[0, 2].Value == "X" && dataGridView1[1, 2].Value == "X" && dataGridView1[2, 2].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, -260000, 0, dataGridView1.Width + 50000, dataGridView1.Height);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;

            }
            else
                if (dataGridView1[0, 2].Value == "O" && dataGridView1[1, 2].Value == "O" && dataGridView1[2, 2].Value == "O")
                {
                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, -260000, 0, dataGridView1.Width + 50000, dataGridView1.Height);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }
            if (dataGridView1[2, 0].Value == "X" && dataGridView1[1, 1].Value == "X" && dataGridView1[0, 2].Value == "X")
            {
                dataGridView1.Enabled = false;
                Graphics g = dataGridView1.CreateGraphics();
                g.DrawLine(olovka, 240, 0, dataGridView1.Width - 240, dataGridView1.Height);
                g.Dispose();
                label3.Text = "Pobednik je igrac X!";
                label1.Enabled = false;
                label2.Enabled = false;


            }
            else
                if (dataGridView1[2, 0].Value == "O" && dataGridView1[1, 1].Value == "O" && dataGridView1[0, 2].Value == "O")
                {
                    dataGridView1.Enabled = false;
                    Graphics g = dataGridView1.CreateGraphics();
                    g.DrawLine(olovka, 240, 2, dataGridView1.Width - 240, dataGridView1.Height + 0);
                    g.Dispose();
                    label3.Text = "Pobednik je igrac O!";
                    label1.Enabled = false;
                    label2.Enabled = false;

                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (p = 0; p < 3; p++)

                for (q = 0; q < 3; q++)

                    dataGridView1[q, p].Value = "";
            dataGridView1.Enabled = true;

            X = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label2.Text = "X";
            label3.Text = "";
            
        }
       

            
           
                    

          

    }
}


