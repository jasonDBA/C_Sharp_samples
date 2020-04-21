using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Threading;

namespace Jabin_Choi_Sec004_Excercise01
{
    public partial class JabinChoi_Form : Form
    {
        public JabinChoi_Form()
        {
            InitializeComponent();
        }

        // Excercise01 - a and b
        // a. Create a Window Form App to as shown in the screenshot of the introduction.
        // b. Caculate Factorial asynchronously.
        private async void btnAsync_Click(object sender, EventArgs e)
        {

            long number = long.Parse(txtInputAsync.Text);
            outputLabelAsync.Text = "Calculating...";

            Task<long> factorialTask = Task.Run(() => Factorial(number));
            await factorialTask;

            outputLabelAsync.Text = factorialTask.Result.ToString();

            if(long.Parse(outputLabelAsync.Text) <= 0)
            {
                MessageBox.Show("The result is out of range. Please input a valid number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                outputLabelAsync.Text = String.Empty;
                txtInputAsync.Text = String.Empty;
            }
        }

        public long Factorial(long n)
        {
            System.Threading.Thread.Sleep(25);

            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        // Excercise01 - c
        // Check for Even/Odd numbers - Create two methods (IsEven and IsOdd).
        public delegate bool CheckForEvenOdd(int number);
        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(txtInputEvenOdd.Text);
            CheckForEvenOdd checkNum = IsEven;
            outputLabelEven.Text = IsEven(inputNum).ToString();

            checkNum = IsOdd;
            outputLabelOdd.Text = IsOdd(inputNum).ToString();
        }

        private static bool IsEven(int number) => number % 2 == 0;
        private static bool IsOdd(int number) => number % 2 != 0;


        // Excercise01 - d - i)
        // Generate numbers depending on input data types.
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var intValues = Enumerable.Range(1, 10)
                                     .Select(x => random.Next(10, 99))
                                     .ToArray();
            var doubleValues = intValues.Select(x => random.NextDouble() * (99 - 10) + 10).ToArray();
            var chars = Enumerable.Range('A', 'Z' - 'A' + 1)
                                  .Select(c => (char)c)
                                  .ToList();

            if (radioInt.Checked)
            {
                outputListBox.Items.Clear();
                Parallel.For(0, 10, i =>
                    outputListBox.Items.Add(intValues[i]));
            }
            else if (radioDouble.Checked)
            {
                outputListBox.Items.Clear();
                Parallel.For(0, 10, i =>
                    outputListBox.Items.Add(Math.Round(doubleValues[i], 2)));
            }
            else if (radioChar.Checked)
            {
                outputListBox.Items.Clear();
                Parallel.For(0, 10, i =>
                    outputListBox.Items.Add(chars[i]));
            }
        }

        // Excercise01 - d - ii)
        // Search correctly an input value from the list of values in the listbox.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inputValue = txtSearch.Text;
            var listboxItems = new List<string>();

            foreach(var items in outputListBox.Items)
            {
                listboxItems.Add(items.ToString());
            }

            bool isContainsValue = SearchData(listboxItems, inputValue);
            if (isContainsValue)
            {
                MessageBox.Show($"{inputValue} is in the listbox!", "SEARCH RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{inputValue} is NOT in the listbox... Please input another number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool SearchData<T>(List<T> list, T value)
        {
            if (list.Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Excercise01 - d - iii)
        // Display the range of values between the valid index values 
        // from the list of values in the listbox.
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int lowIndex = int.Parse(txtLowIndex.Text);
            int highIndex = int.Parse(txtHighIndex.Text);
            var listboxItems = new List<string>();

            if(lowIndex > highIndex)
            {
                MessageBox.Show($"Low Index {lowIndex} is greater than High Index {highIndex}.. Please input valid numbers.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < outputListBox.Items.Count; i++)
                {
                    listboxItems.Add(outputListBox.Items[i].ToString());
                }

                Display(listboxItems, lowIndex, highIndex);
            }
        }

        public void Display<T>(List<T> listboxItems, int lowIndex, int highIndex)
        {
            txtOutputIndex.Clear();
            for(int i=lowIndex; i <= highIndex; i++)
            {
                txtOutputIndex.Text += $"{listboxItems[i]}  ";
            }
        }

    }
}
