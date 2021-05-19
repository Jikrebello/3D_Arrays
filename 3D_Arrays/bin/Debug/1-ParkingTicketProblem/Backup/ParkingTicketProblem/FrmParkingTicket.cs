using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ParkingTicketProblem
{
    public partial class FrmParkingTicket : Form
    {
        public FrmParkingTicket()
        {
            InitializeComponent();
        }

        int [,,] Violations = new int[13,5,3];
        int[,] Difference = new int[13, 5];

        string [] Months = new string[13];
        string [] TicketType = new string [5];
        string [] Year = new string [3];
        
        private void FrmParkingTicket_Load(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\parking.txt";

            StreamReader read = new StreamReader(f);

            for (int slice = 1; slice <= 2; slice++)
            {
                for (int r = 1; r <= 12; r++)
                {
                    for (int c = 1; c <= 4; c++)
                    {
                        Violations[r, c,slice] = Convert.ToInt32(read.ReadLine());
                    }
                }
            }

            for (int r = 1; r <= 12; r++)
            {
                Months[r] = read.ReadLine();
            }

            for (int c = 1; c <= 4; c++)
            {
                TicketType[c] = read.ReadLine();
            }

            for (int slice = 1; slice <= 2; slice++)
            {
                Year[slice] = read.ReadLine();
            }


            read.Close();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Parking Violations Summary" + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            for(int slice=1;slice <=2;slice ++)
            {
                TxtDisplay.Text+=Year[slice]+ "\t";
                
                for (int c = 1; c <= 4; c++)
                {
                    TxtDisplay.Text += TicketType[c] + "\t";
                }

                TxtDisplay.Text += Environment.NewLine;

                for (int r = 1; r <= 12; r++)
                {
                    TxtDisplay.Text += Months[r] + "\t";
                    for (int c = 1; c <= 4; c++)
                    {
                        TxtDisplay.Text += Convert.ToString(Violations[r, c,slice]) + "\t";
                    }
                    TxtDisplay.Text += Environment.NewLine;
                }

                TxtDisplay.Text += Environment.NewLine;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            for (int r = 1; r <= 12; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    if (c != 3)
                    {
                        Violations[r, c, 2] *= 2;
                    }
                }
            }

            BtnDisplay.PerformClick();
        }

        private void BtnDifferences_Click(object sender, EventArgs e)
        {
            for (int r = 1; r <= 12; r++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    Difference[r, c] = Violations[r, c, 2] - Violations[r, c, 1];
                }
            }

            TxtDisplay.Clear();
            TxtDisplay.Text = "Change in Violations from 1982 to 1983" + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "\t";

            for (int c = 1; c <= 4; c++)
            {
                TxtDisplay.Text += TicketType[c] + "\t";
            }

            TxtDisplay.Text += Environment.NewLine;

            for (int r = 1; r <= 12; r++)
            {
                TxtDisplay.Text += Months[r] + "\t";
                for (int c = 1; c <= 4; c++)
                {
                    TxtDisplay.Text += Convert.ToString(Difference[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

        }


    }
}