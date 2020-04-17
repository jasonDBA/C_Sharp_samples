using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jabin_Choi_Sec004_Excercise03
{
    public partial class Excercise03 : Form
    {
        public Excercise03()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "\r\n***NOTE: Please wait until all tasks are done completely.***\r\n\r\n";

            outputTextBox.AppendText("STARTING TASK TO CALCULATE FACTORIAL(46)\r\n");
            Task<TimeData> task1 = Task.Run(() => StartFactorial(46));

            outputTextBox.AppendText("STARTING TASK TO CALCULATE FIBONACCI(45)\r\n");
            Task<TimeData> task2 = Task.Run(() => StartFibonacci(45));

            outputTextBox.AppendText("STARTING TASK TO DISPLAY THE FACE OF A DIE WHICH APPEARED THE HIGHTEST NUMBER OF TIMES\r\n\r\n");
            Task<TimeData> task3 = Task.Run(() => StartRollDice(60000000));

            await Task.WhenAll(task1, task2, task3);

            DateTime startTime = (task1.Result.StartTime < task2.Result.StartTime) ?
                                    task1.Result.StartTime : task2.Result.StartTime;

            DateTime endTime = (task1.Result.EndTime > task2.Result.EndTime) ? 
                                task1.Result.EndTime : task2.Result.EndTime;

            double totalMins = (endTime - startTime).TotalMinutes;
            outputTextBox.AppendText($"Total Calculated Time between Factorial(46) and Fibonacci(45) = {totalMins:F6} mins\r\n");
        }

        TimeData StartFactorial(long n)
        {
            var result = new TimeData();

            AppendText($"Calculating Factorial({n})...");
            result.StartTime = DateTime.Now;
            long factorialValue = Factorial(n);
            result.EndTime = DateTime.Now;

            AppendText($"Factorial({n}) = {factorialValue}");

            double minutes = (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculated time = {minutes:F6} mins\r\n");

            return result;
        }

        TimeData StartFibonacci(long n)
        {
            var result = new TimeData();

            AppendText($"Calculating Fibonacci({n})...");
            result.StartTime = DateTime.Now;
            long fibonacciValue = Fibonacci(n);
            result.EndTime = DateTime.Now;

            AppendText($"Fibonacci({n}) = {fibonacciValue}");
            double minutes =
               (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculated time = {minutes:F6} mins\r\n");

            return result;
        }

        TimeData StartRollDice(int n)
        {
            var result = new TimeData();

            AppendText($"Calculating RollDice({n})...");
            result.StartTime = DateTime.Now;
            RollDie(n);
            result.EndTime = DateTime.Now;

            double minutes = (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"Calculated time = {minutes:F6} mins\r\n");

            return result;
        }

        public long Factorial (long n)
        {
            if (n == 0 || n == 1)
            {
                Thread.Sleep(2000);
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public void AppendText(String text)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
            }
            else
            {
                outputTextBox.AppendText(text + "\r\n");
            }
        }

        public void RollDie(int number)
        {
            var randomNumbers = new Random();

            int sixFaces = 6;
            int[] arr = new int[sixFaces + 1];
            int rollADice;

            for(var roll = 1; roll <= number; ++roll)
            {
                rollADice = randomNumbers.Next(1, 7);
                ++arr[rollADice];
            }

            AppendText("\r\n-------------------------------------------------------RESULTS----------------------------------------------------------");
            AppendText($"\r\n{"ROLL"}\t{"FREQUENCY", 9}");
            for(var element=1; element<arr.Length; ++element)
            {
                AppendText($"{element, 4}\t{arr[element], 10}");
            }
        }
    }
}
