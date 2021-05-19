using System;
using System.IO;
using System.Windows.Forms;

namespace _3D_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        string path = Application.StartupPath;

        const string MONTHS_PATH = @"\months.txt"; // rows
        const string VIOLATIONS_PATH = @"\violations.txt"; // columns
        const string YEARS_PATH = @"\years.txt"; // slices
        const string NUMBER_OF_VIOLATIONS_PATH = @"\number_of_violations.txt";

        string[,,] parkingViolations = new string[12, 4, 2]; // 12 rows, 4 columns, 2 slices
        string[] months = new string[12];
        string[] violationNames = new string[4];
        string[] years = new string[2];
        int[,] differenceBetweenYears = new int[12, 4];

        //1. Write a program segment which reads in all the appropriate data and echoes the data only.
        private void button1_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
            DisplayData();
        }
        private void LoadData()
        {
            using (StreamReader reader = new StreamReader(path + MONTHS_PATH))
            {
                for (int i = 0; i < months.Length; i++)
                {
                    months[i] = reader.ReadLine();
                }

                reader.Close();
            }

            using (StreamReader reader = new StreamReader(path + VIOLATIONS_PATH))
            {
                for (int i = 0; i < violationNames.Length; i++)
                {
                    violationNames[i] = reader.ReadLine();
                }

                reader.Close();
            }

            using (StreamReader reader = new StreamReader(path + YEARS_PATH))
            {
                for (int i = 0; i < years.Length; i++)
                {
                    years[i] = reader.ReadLine();
                }

                reader.Close();
            }

            using (StreamReader reader = new StreamReader(path + NUMBER_OF_VIOLATIONS_PATH))
            {
                for (int slice = 0; slice < 2; slice++) //slices
                {
                    for (int row = 0; row < 12; row++) //rows
                    {
                        for (int column = 0; column < 4; column++) // columns
                        {
                            parkingViolations[row, column, slice] = reader.ReadLine();
                        }
                    }
                }

                reader.Close();
            }
        }
        private void DisplayData()
        {

            for (int slice = 0; slice < years.Length; slice++) // group by years
            {
                // Display the table in TxtDisplay
                TxtDisplay.Text += years[slice] + "\t";

                for (int column = 0; column < violationNames.Length; column++)
                {
                    TxtDisplay.Text += violationNames[column] + ":" + "\t";
                }

                TxtDisplay.Text += Environment.NewLine;

                // set the rows --months--, to go underneath the columns, then drop down to the next row
                for (int row = 0; row < months.Length; row++)
                {
                    TxtDisplay.Text += months[row] + ":" + "\t";

                    for (int column = 0; column < violationNames.Length; column++)
                    {
                        TxtDisplay.Text += parkingViolations[row, column, slice] + "\t";
                    }

                    TxtDisplay.Text += Environment.NewLine;
                }

                TxtDisplay.Text += Environment.NewLine;

            }
        }

        //2. All the entries for 1983 were entered incorrectly by the secretary.They should all be
        //double what they are, except for the careless driving numbers, which are correct.
        //Make the proper modifications to the data stored.
        private void button2_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < months.Length; row++)
            {
                for (int column = 0; column < violationNames.Length; column++)
                {
                    for (int slice = 0; slice < years.Length; slice++)
                    {
                        if (violationNames[column] != "Careless")
                        {
                            parkingViolations[row, column, slice] = (Convert.ToInt32(parkingViolations[row, column, slice]) * 2).ToString();
                        }
                    }
                }
            }
            TxtDisplay.Text += Environment.NewLine;
            DisplayData();
        }

        //3. Write a program segment which creates a 2 dimensional array which stores the differences between the number of violations for successive years,
        //for corresponding months and violation types.Display this table with months and traffic violation names included.
        private void button3_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < months.Length; row++)
            {
                for (int column = 0; column < violationNames.Length; column++)
                {
                    differenceBetweenYears[row, column] = Convert.ToInt32(parkingViolations[row, column, 0]) - Convert.ToInt32(parkingViolations[row, column, 1]);
                }
            }
            
            TxtDisplay.Text += Environment.NewLine;

            // Display the table in TxtDisplay
            TxtDisplay.Text += "\t";

            // set the columns names
            for (int column = 0; column < violationNames.Length; column++)
            {
                TxtDisplay.Text += violationNames[column].ToString() + ":" + "\t";
            }

            TxtDisplay.Text += Environment.NewLine;

            // set the rows (candidates), to go underneath the columns, then drop down to the next row
            for (int row = 0; row < months.Length; row++)
            {
                TxtDisplay.Text += months[row] + ":" + "\t";

                for (int column = 0; column < violationNames.Length; column++)
                {
                    TxtDisplay.Text += differenceBetweenYears[row, column] + "\t";

                }
                TxtDisplay.Text += Environment.NewLine;

            }
            TxtDisplay.Text += Environment.NewLine;
        }
    }
}
