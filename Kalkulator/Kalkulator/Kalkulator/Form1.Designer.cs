namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerDigitalClock = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńKolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tło1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tło2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolor3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolor4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolor5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innyKolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńSkórkęTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelDigitalClock = new System.Windows.Forms.Label();
            this.pokażZegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyfrowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyfrowyIAnalogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDigitalClock
            // 
            this.timerDigitalClock.Enabled = true;
            this.timerDigitalClock.Interval = 1000;
            this.timerDigitalClock.Tick += new System.EventHandler(this.timerDigitalClock_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zamknij\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(516, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(367, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(439, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(516, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(367, 137);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(439, 137);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 10;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(516, 137);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 11;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(367, 355);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(122, 50);
            this.button11.TabIndex = 12;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(596, 137);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 119);
            this.button12.TabIndex = 13;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(596, 70);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 14;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem,
            this.widokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńKolorTłaToolStripMenuItem,
            this.zmieńSkórkęTłaToolStripMenuItem,
            this.pokażZegarToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // zmieńKolorTłaToolStripMenuItem
            // 
            this.zmieńKolorTłaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tło1ToolStripMenuItem,
            this.tło2ToolStripMenuItem,
            this.kolor3ToolStripMenuItem,
            this.kolor4ToolStripMenuItem,
            this.kolor5ToolStripMenuItem,
            this.innyKolorToolStripMenuItem});
            this.zmieńKolorTłaToolStripMenuItem.Name = "zmieńKolorTłaToolStripMenuItem";
            this.zmieńKolorTłaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zmieńKolorTłaToolStripMenuItem.Text = "Zmień kolor tła";
            // 
            // tło1ToolStripMenuItem
            // 
            this.tło1ToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.tło1ToolStripMenuItem.Name = "tło1ToolStripMenuItem";
            this.tło1ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.tło1ToolStripMenuItem.Text = "Cyan";
            this.tło1ToolStripMenuItem.Click += new System.EventHandler(this.tło1ToolStripMenuItem_Click);
            // 
            // tło2ToolStripMenuItem
            // 
            this.tło2ToolStripMenuItem.BackColor = System.Drawing.Color.Magenta;
            this.tło2ToolStripMenuItem.Name = "tło2ToolStripMenuItem";
            this.tło2ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.tło2ToolStripMenuItem.Text = "Magenta";
            this.tło2ToolStripMenuItem.Click += new System.EventHandler(this.tło2ToolStripMenuItem_Click);
            // 
            // kolor3ToolStripMenuItem
            // 
            this.kolor3ToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.kolor3ToolStripMenuItem.Name = "kolor3ToolStripMenuItem";
            this.kolor3ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.kolor3ToolStripMenuItem.Text = "Lime";
            this.kolor3ToolStripMenuItem.Click += new System.EventHandler(this.kolor3ToolStripMenuItem_Click);
            // 
            // kolor4ToolStripMenuItem
            // 
            this.kolor4ToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.kolor4ToolStripMenuItem.Name = "kolor4ToolStripMenuItem";
            this.kolor4ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.kolor4ToolStripMenuItem.Text = "Yellow";
            this.kolor4ToolStripMenuItem.Click += new System.EventHandler(this.kolor4ToolStripMenuItem_Click);
            // 
            // kolor5ToolStripMenuItem
            // 
            this.kolor5ToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.kolor5ToolStripMenuItem.Name = "kolor5ToolStripMenuItem";
            this.kolor5ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.kolor5ToolStripMenuItem.Text = "Goldenrod";
            this.kolor5ToolStripMenuItem.Click += new System.EventHandler(this.kolor5ToolStripMenuItem_Click);
            // 
            // innyKolorToolStripMenuItem
            // 
            this.innyKolorToolStripMenuItem.Name = "innyKolorToolStripMenuItem";
            this.innyKolorToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.innyKolorToolStripMenuItem.Text = "inny kolor";
            this.innyKolorToolStripMenuItem.Click += new System.EventHandler(this.innyKolorToolStripMenuItem_Click);
            // 
            // zmieńSkórkęTłaToolStripMenuItem
            // 
            this.zmieńSkórkęTłaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wykresyToolStripMenuItem});
            this.zmieńSkórkęTłaToolStripMenuItem.Name = "zmieńSkórkęTłaToolStripMenuItem";
            this.zmieńSkórkęTłaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zmieńSkórkęTłaToolStripMenuItem.Text = "Zmień skórkę tła";
            // 
            // wykresyToolStripMenuItem
            // 
            this.wykresyToolStripMenuItem.Name = "wykresyToolStripMenuItem";
            this.wykresyToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.wykresyToolStripMenuItem.Text = "Wczytaj skorke";
            this.wykresyToolStripMenuItem.Click += new System.EventHandler(this.wykresyToolStripMenuItem_Click);
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWynik.Location = new System.Drawing.Point(56, 70);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.Size = new System.Drawing.Size(252, 64);
            this.textBoxWynik.TabIndex = 16;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(596, 275);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 130);
            this.button14.TabIndex = 17;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(367, 70);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 18;
            this.button15.Text = "C";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(516, 70);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 19;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(439, 70);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 20;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(516, 355);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 21;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // labelDigitalClock
            // 
            this.labelDigitalClock.AutoSize = true;
            this.labelDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDigitalClock.Location = new System.Drawing.Point(102, 179);
            this.labelDigitalClock.Name = "labelDigitalClock";
            this.labelDigitalClock.Size = new System.Drawing.Size(109, 39);
            this.labelDigitalClock.TabIndex = 22;
            this.labelDigitalClock.Text = "label1";
            // 
            // pokażZegarToolStripMenuItem
            // 
            this.pokażZegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cyfrowyToolStripMenuItem,
            this.analogowyToolStripMenuItem,
            this.cyfrowyIAnalogowyToolStripMenuItem});
            this.pokażZegarToolStripMenuItem.Name = "pokażZegarToolStripMenuItem";
            this.pokażZegarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pokażZegarToolStripMenuItem.Text = "Pokaż/ukryj zegar";
            // 
            // cyfrowyToolStripMenuItem
            // 
            this.cyfrowyToolStripMenuItem.Name = "cyfrowyToolStripMenuItem";
            this.cyfrowyToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.cyfrowyToolStripMenuItem.Text = "Pokaż Cyfrowy";
            this.cyfrowyToolStripMenuItem.Click += new System.EventHandler(this.cyfrowyToolStripMenuItem_Click);
            // 
            // analogowyToolStripMenuItem
            // 
            this.analogowyToolStripMenuItem.Name = "analogowyToolStripMenuItem";
            this.analogowyToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.analogowyToolStripMenuItem.Text = "Pokaż Analogowy";
            this.analogowyToolStripMenuItem.Click += new System.EventHandler(this.analogowyToolStripMenuItem_Click);
            // 
            // cyfrowyIAnalogowyToolStripMenuItem
            // 
            this.cyfrowyIAnalogowyToolStripMenuItem.Name = "cyfrowyIAnalogowyToolStripMenuItem";
            this.cyfrowyIAnalogowyToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.cyfrowyIAnalogowyToolStripMenuItem.Text = "Pokaż Cyfrowy i Analogowy";
            this.cyfrowyIAnalogowyToolStripMenuItem.Click += new System.EventHandler(this.cyfrowyIAnalogowyToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 147);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDigitalClock);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerDigitalClock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńKolorTłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tło1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tło2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolor3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolor4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolor5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innyKolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńSkórkęTłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelDigitalClock;
        private System.Windows.Forms.ToolStripMenuItem pokażZegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyfrowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analogowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyfrowyIAnalogowyToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
    }
}

