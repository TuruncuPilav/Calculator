using System;
using System.Linq;
using System.Windows.Forms;

namespace Colculator
{
    public partial class Form1 : Form
    {
        private bool clear = false;
        private double num, result = 0, memory = 0;
        private char lastProcess;

        public void processButton(char process)
        {
            clear = false;
            num = Convert.ToDouble(screen.Text);

            if (num != 0)
            {
                if (memory == 0)
                {
                    memory = num;
                    lastProcess = process;

                    processScreen.Text = Convert.ToString(memory) + " " + process + " ";
                    screen.Text = "0";
                }
                else
                {
                    switch (lastProcess)
                    {
                        case '+':
                            result = memory + num;
                            memory = result;
                            break;
                        case '-':
                            result = memory - num;
                            memory = result;
                            break;
                        case 'x':
                            result = memory * num;
                            memory = result;
                            break;
                        case '/':
                            result = memory / num;
                            memory = result;
                            break;
                    }
                    processScreen.Text = Convert.ToString(memory) + " " + process + " ";
                    screen.Text = "0";
                }
                if (process == '=')
                {
                    screen.Text = Convert.ToString(memory);
                    processScreen.Text = "";
                    memory = 0;
                    clear = true;
                }
            }
        }

        /*
            Ekranı kontrol eder. Eğer ekranda 0 varsa yazıyı kaldırır ve girilmek istenilen sayının istenilen şekilde eklenmesini sağlar.
         */
        public void numbers()
        {
            if (screen.Text == "0")
            {
                screen.Text = "";
            }

            if (clear)
            {
                screen.Text = "";
                processScreen.Text = "";
                clear = false;
            }
        }

        /*
            Ondalıklı işlemler yapılmasını sağlayan virgülün eklenmesini sağlar. Birden fazla virgül eklenmesini engeller.
         */
        private void numberComma_Click(object sender, EventArgs e)
        {
            int x = screen.Text.Length;
            int y = screen.Text.LastIndexOf(",");
            if (screen.Text.Substring(x - 1, 1) != ",")
            {
                if (y == -1)
                {
                    clear = false;
                    screen.Text += ",";
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        // Ekrana butonla sayı girişi yapılmasını sağlar.
        private void number1_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "9";
        }
        private void number0_Click(object sender, EventArgs e)
        {
            numbers();
            screen.Text += "0";
        }

        // Ekranı temizler
        private void numberC_Click(object sender, EventArgs e)
        {
            clear = false;
            result = 0;
            memory = 0;
            processScreen.Text = "";
            screen.Text = "0";
        }
        //Yapılacak işlemleri seçer
        private void numberPlus_Click(object sender, EventArgs e)
        {
            processButton('+');
        }
        private void numberSubtract_Click(object sender, EventArgs e)
        {
            processButton('-');
        }
        private void numberDivide_Click(object sender, EventArgs e)
        {
            processButton('/');
        }

        private void numberMultiply_Click(object sender, EventArgs e)
        {
            processButton('x');
        }
        //Yanlış yazılan sayıları silmek
        private void nummberDelete_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text.Substring(0, screen.Text.Length - 1);
            if (screen.Text == "")
            {
                screen.Text = "0";
            }
        }

        private void numberEquals_Click(object sender, EventArgs e)
        {
            processButton('=');
        }

        //Klavye ile sayıların ekrana girilmesini, işlemlerin seçilmesini sağlar.
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            string selectNum = e.KeyData.ToString();
            char[] temp = selectNum.ToArray();
            char selectedNum = temp[selectNum.Length - 1];

            if (char.IsNumber(selectedNum))
            {
                numbers();
                screen.Text += selectedNum;
            }

            if(e.KeyData.ToString() == "Add")
            {
                processButton('+');
            }

            if (e.KeyData.ToString() == "Subtract")
            {
                processButton('-');
            }

            if (e.KeyData.ToString() == "Multiply")
            {
                processButton('x');
            }

            if (e.KeyData.ToString() == "Divide")
            {
                processButton('/');
            }

            if (e.KeyData.ToString() == "Return")
            {
                processButton('=');
            }

            if (e.KeyData.ToString() == "Back")
            {
                screen.Text = screen.Text.Substring(0, screen.Text.Length - 1);
                if (screen.Text == "")
                {
                    screen.Text = "0";
                }
            }

            if (e.KeyData.ToString() == "Delete")
            {
                clear = false;
                result = 0;
                memory = 0;
                processScreen.Text = "";
                screen.Text = "0";
            }

            if (e.KeyData.ToString() == "Decimal")
            {
                int x = screen.Text.Length;
                int y = screen.Text.LastIndexOf(",");
                if (screen.Text.Substring(x - 1, 1) != ",")
                {
                    if (y == -1)
                    {
                        clear = false;
                        screen.Text += ",";
                    }
                }
            }
        }
    }
}