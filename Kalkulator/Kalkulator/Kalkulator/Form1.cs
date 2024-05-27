using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalkulator
{
    public partial class Form1 : Form
    {
        List<double> skladniki = new List<double>();
        List<string> operacje = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Umożliwienie przechwytywania zdarzeń klawiatury przez formularz
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress); // Dodanie obsługi zdarzenia KeyPress
            labelDigitalClock.Visible = false;
            pictureBox1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void tło1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            this.BackgroundImage = null;
            //ColorDialog colorDialog = new ColorDialog();
            //if (colorDialog.ShowDialog() == DialogResult.OK)
            //{
            //    this.BackColor = Color.Cyan;
            //}
        }

        private void tło2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
            this.BackgroundImage = null;
        }

        private void kolor4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.BackgroundImage = null;
        }

        private void innyKolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
                this.BackgroundImage = null;
            }
        }

        private void kolor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
            this.BackgroundImage = null;
        }

        private void kolor5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
            this.BackgroundImage = null;
        }

        private void wykresyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki obrazów|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Wczytanie obrazu z pliku
                    Image image = Image.FromFile(openFileDialog.FileName);
                    // Ustawienie obrazu jako tła formularza
                    this.BackgroundImage = image;
                    // Skalowanie tła, aby pasowało do rozmiaru formularza
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd wczytywania pliku: " + ex.Message);
                }
            }
        }

        private void tlo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(textBoxWynik.Text))
            {
                skladniki.Add(double.Parse(textBoxWynik.Text));
                operacje.Add(button.Text);
                textBoxWynik.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxWynik.Text))
            {
                skladniki.Add(double.Parse(textBoxWynik.Text));
            }

            double wynik = skladniki[0];
            for (int i = 0; i < operacje.Count; i++)
            {
                switch (operacje[i])
                {
                    case "+":
                        wynik += skladniki[i + 1];
                        break;
                    case "-":
                        wynik -= skladniki[i + 1];
                        break;
                    case "*":
                        wynik *= skladniki[i + 1];
                        break;
                    case "/":
                        if (skladniki[i + 1] != 0)
                            wynik /= skladniki[i + 1];
                        else
                        {
                            MessageBox.Show("Nie można dzielić przez zero!");
                            return;
                        }
                        break;
                }
            }
            textBoxWynik.Text = wynik.ToString();
            skladniki.Clear();
            operacje.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxWynik.Clear();
            skladniki.Clear();
            operacje.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(textBoxWynik.Text))
            {
                skladniki.Add(double.Parse(textBoxWynik.Text));
                operacje.Add(button.Text);
                textBoxWynik.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(textBoxWynik.Text))
            {
                skladniki.Add(double.Parse(textBoxWynik.Text));
                operacje.Add(button.Text);
                textBoxWynik.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(textBoxWynik.Text))
            {
                skladniki.Add(double.Parse(textBoxWynik.Text));
                operacje.Add(button.Text);
                textBoxWynik.Clear();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxWynik.Text += button.Text;
        }

        //private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Obsługa wciśnięcia klawisza
        //    switch (e.KeyChar)
        //    {
        //        case '1':
        //            button2.PerformClick();
        //            break;
        //        case '2':
        //            button3.PerformClick();
        //            break;
        //        case '3':
        //            button4.PerformClick();
        //            break;
        //        case '4':
        //            button5.PerformClick();
        //            break;
        //        case '5':
        //            button6.PerformClick();
        //            break;
        //        case '6':
        //            button7.PerformClick();
        //            break;
        //        case '7':
        //            button8.PerformClick();
        //            break;
        //        case '8':
        //            button9.PerformClick();
        //            break;
        //        case '9':
        //            button10.PerformClick();
        //            break;
        //        case '0':
        //            button11.PerformClick();
        //            break;
        //        case '+':
        //            button12.PerformClick();
        //            break;
        //        case '-':
        //            button13.PerformClick();
        //            break;
        //        case '*':
        //            button16.PerformClick();
        //            break;
        //        case '/':
        //            button17.PerformClick();
        //            break;
        //        case '=':
        //            button14.PerformClick();
        //            break;
        //        case 'c':
        //            button15.PerformClick();
        //            break;
        //        case ',':
        //            button18.PerformClick();
        //            break;
        //    }
        //}

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '=' || e.KeyChar == ',' || e.KeyChar == 'c')
            {
                if (e.KeyChar == '=')
                {
                    button14.PerformClick();
                }
                else if (e.KeyChar == 'c')
                {
                    button15.PerformClick();
                }
                else
                {
                    // Obsługa wprowadzania cyfr i znaków operacji
                    foreach (Control control in this.Controls)
                    {
                        if (control is Button && control.Text == e.KeyChar.ToString())
                        {
                            ((Button)control).PerformClick();
                            break;
                        }
                    }
                }
            }
            else
            {
                e.Handled = true; // Ignoruje wprowadzenie innych znaków
            }
        }

        private void UpdateDigitalClock()
        {
            // Aktualizacja tekstu cyfrowego zegara
            labelDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerDigitalClock_Tick(object sender, EventArgs e)
        {
            // Aktualizacja cyfrowego czasu co sekundę
            UpdateDigitalClock();
            pictureBox1.Invalidate();
        }

        private void cyfrowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Wyświetlenie zegara cyfrowego, ukrycie analogowego
            
            labelDigitalClock.Visible = !labelDigitalClock.Visible;
            if (labelDigitalClock.Visible)
            {
                cyfrowyToolStripMenuItem.Text = "Ukryj cyfrowy";
            }
            else
            {
                cyfrowyToolStripMenuItem.Text = "Pokaż cyfrowy";
            }
            if (pictureBox1.Visible && labelDigitalClock.Visible)
            {
                cyfrowyIAnalogowyToolStripMenuItem.Text = "Ukryj analogowy i cyfrowy";
            }
            else
            {
                cyfrowyIAnalogowyToolStripMenuItem.Text = "Pokaż analogowy i cyfrowy";
            }
            // Rozpoczęcie aktualizacji cyfrowego czasu
            timerDigitalClock.Start();
            // Aktualizacja cyfrowego czasu
            UpdateDigitalClock();
        }

        private void analogowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Wyświetlenie zegara analogowego, ukrycie cyfrowego
            pictureBox1.Visible = !pictureBox1.Visible;
            if (pictureBox1.Visible)
            {
                analogowyToolStripMenuItem.Text = "Ukryj analogowy";
            }
            else
            {
                analogowyToolStripMenuItem.Text = "Pokaż analogowy";
            }
            if (pictureBox1.Visible && labelDigitalClock.Visible)
            {
                cyfrowyIAnalogowyToolStripMenuItem.Text = "Ukryj analogowy i cyfrowy";
            }
            else
            {
                cyfrowyIAnalogowyToolStripMenuItem.Text = "Pokaż analogowy i cyfrowy";
            }

            // Zatrzymanie aktualizacji cyfrowego czasu
            timerDigitalClock.Start();
        }

        private void cyfrowyIAnalogowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Wyświetlenie zegara cyfrowego, ukrycie analogowego
            
            if(pictureBox1.Visible && labelDigitalClock.Visible)
            {
                pictureBox1.Visible = false;
                labelDigitalClock.Visible = false;
                cyfrowyIAnalogowyToolStripMenuItem.Text = "Pokaż analogowy i cyfrowy";
            }
            else
            {
                pictureBox1.Visible = true;
                labelDigitalClock.Visible = true;
                cyfrowyIAnalogowyToolStripMenuItem.Text = "Ukryj analogowy i cyfrowy";
            }
            // Rozpoczęcie aktualizacji cyfrowego czasu
            timerDigitalClock.Start();
            // Aktualizacja cyfrowego czasu
            UpdateDigitalClock();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = this.pictureBox1.Width / 2;
            int centerY = this.pictureBox1.Height / 2;
            DateTime now = DateTime.Now;
            Pen tarcza = new Pen(Color.Black, 5);
            Pen godz = new Pen(Color.Blue, 4);
            Pen min = new Pen(Color.Black, 3);
            Pen sec = new Pen(Color.Red, 2);
            g.DrawEllipse(tarcza, centerX - 50, centerY - 50, 100, 100); // Rysuje tarczę zegara

            // Sekundnik
            g.DrawLine(sec, centerX, centerY, centerX + 40 * (float)Math.Sin(Math.PI * now.Second / 30), centerY - 40 * (float)Math.Cos(Math.PI * now.Second / 30));

            // Minutowa
            g.DrawLine(min, centerX, centerY, centerX + 30 * (float)Math.Sin(Math.PI * now.Minute / 30), centerY - 30 * (float)Math.Cos(Math.PI * now.Minute / 30));

            // Godzinowa
            g.DrawLine(godz, centerX, centerY, centerX + 20 * (float)Math.Sin(Math.PI * now.Hour / 6), centerY - 20 * (float)Math.Cos(Math.PI * now.Hour / 6));

            tarcza.Dispose();
            godz.Dispose();
            min.Dispose();
            sec.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
