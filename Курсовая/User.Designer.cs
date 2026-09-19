namespace Курсовая
{
    partial class basicuser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTabel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Close = new System.Windows.Forms.Button();
            this.Instrument = new System.Windows.Forms.TextBox();
            this.Инструмент = new System.Windows.Forms.Label();
            this.Contry = new System.Windows.Forms.TextBox();
            this.Страна = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.ФИО = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.GroupBox();
            this.Plase = new System.Windows.Forms.RadioButton();
            this.FIOsort = new System.Windows.Forms.RadioButton();
            this.Age = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.Button();
            this.Task1 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pianobutton = new System.Windows.Forms.RadioButton();
            this.skripkabutton = new System.Windows.Forms.RadioButton();
            this.guitarbutton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataTabel)).BeginInit();
            this.Sort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTabel
            // 
            this.DataTabel.AllowUserToAddRows = false;
            this.DataTabel.AllowUserToResizeColumns = false;
            this.DataTabel.AllowUserToResizeRows = false;
            this.DataTabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataTabel.Location = new System.Drawing.Point(1, 431);
            this.DataTabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataTabel.Name = "DataTabel";
            this.DataTabel.RowHeadersWidth = 51;
            this.DataTabel.RowTemplate.Height = 28;
            this.DataTabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataTabel.ShowRowErrors = false;
            this.DataTabel.Size = new System.Drawing.Size(1523, 500);
            this.DataTabel.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 26.73797F;
            this.Column1.HeaderText = "№";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Имя";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Отчество";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 83.608F;
            this.Column3.HeaderText = "Год рождения";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 111.3503F;
            this.Column4.HeaderText = "Страна";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 71.99984F;
            this.Column5.HeaderText = "Инструмент";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Место";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(1224, 64);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(251, 74);
            this.Close.TabIndex = 43;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Instrument
            // 
            this.Instrument.BackColor = System.Drawing.Color.Black;
            this.Instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instrument.ForeColor = System.Drawing.Color.White;
            this.Instrument.Location = new System.Drawing.Point(129, 333);
            this.Instrument.Margin = new System.Windows.Forms.Padding(4);
            this.Instrument.Name = "Instrument";
            this.Instrument.Size = new System.Drawing.Size(485, 38);
            this.Instrument.TabIndex = 41;
            this.Instrument.TextChanged += new System.EventHandler(this.Instrument_TextChanged);
            // 
            // Инструмент
            // 
            this.Инструмент.AutoSize = true;
            this.Инструмент.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Инструмент.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Инструмент.Location = new System.Drawing.Point(125, 275);
            this.Инструмент.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Инструмент.Name = "Инструмент";
            this.Инструмент.Size = new System.Drawing.Size(325, 38);
            this.Инструмент.TabIndex = 40;
            this.Инструмент.Text = "Поиск по инструменту";
            this.Инструмент.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contry
            // 
            this.Contry.BackColor = System.Drawing.Color.Black;
            this.Contry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contry.ForeColor = System.Drawing.Color.White;
            this.Contry.Location = new System.Drawing.Point(129, 208);
            this.Contry.Margin = new System.Windows.Forms.Padding(4);
            this.Contry.Name = "Contry";
            this.Contry.Size = new System.Drawing.Size(485, 38);
            this.Contry.TabIndex = 39;
            this.Contry.TextChanged += new System.EventHandler(this.Contry_TextChanged);
            // 
            // Страна
            // 
            this.Страна.AutoSize = true;
            this.Страна.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Страна.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Страна.Location = new System.Drawing.Point(123, 151);
            this.Страна.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Страна.Name = "Страна";
            this.Страна.Size = new System.Drawing.Size(245, 38);
            this.Страна.TabIndex = 38;
            this.Страна.Text = "Поиск по стране";
            // 
            // FIO
            // 
            this.FIO.BackColor = System.Drawing.Color.Black;
            this.FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.ForeColor = System.Drawing.Color.White;
            this.FIO.Location = new System.Drawing.Point(129, 100);
            this.FIO.Margin = new System.Windows.Forms.Padding(4);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(485, 38);
            this.FIO.TabIndex = 37;
            this.FIO.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // ФИО
            // 
            this.ФИО.AutoSize = true;
            this.ФИО.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ФИО.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ФИО.Location = new System.Drawing.Point(123, 34);
            this.ФИО.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ФИО.Name = "ФИО";
            this.ФИО.Size = new System.Drawing.Size(218, 38);
            this.ФИО.TabIndex = 36;
            this.ФИО.Text = "Поиск по ФИО";
            // 
            // Sort
            // 
            this.Sort.Controls.Add(this.Plase);
            this.Sort.Controls.Add(this.FIOsort);
            this.Sort.Controls.Add(this.Age);
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort.ForeColor = System.Drawing.Color.Black;
            this.Sort.Location = new System.Drawing.Point(660, 26);
            this.Sort.Margin = new System.Windows.Forms.Padding(4);
            this.Sort.Name = "Sort";
            this.Sort.Padding = new System.Windows.Forms.Padding(4);
            this.Sort.Size = new System.Drawing.Size(338, 203);
            this.Sort.TabIndex = 35;
            this.Sort.TabStop = false;
            this.Sort.Text = "Сортировать по";
            // 
            // Plase
            // 
            this.Plase.AutoSize = true;
            this.Plase.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plase.ForeColor = System.Drawing.Color.Black;
            this.Plase.Location = new System.Drawing.Point(31, 145);
            this.Plase.Margin = new System.Windows.Forms.Padding(4);
            this.Plase.Name = "Plase";
            this.Plase.Size = new System.Drawing.Size(106, 39);
            this.Plase.TabIndex = 7;
            this.Plase.TabStop = true;
            this.Plase.Text = "Месту";
            this.Plase.UseVisualStyleBackColor = true;
            this.Plase.CheckedChanged += new System.EventHandler(this.Plase_CheckedChanged);
            // 
            // FIOsort
            // 
            this.FIOsort.AutoSize = true;
            this.FIOsort.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOsort.ForeColor = System.Drawing.Color.Black;
            this.FIOsort.Location = new System.Drawing.Point(31, 96);
            this.FIOsort.Margin = new System.Windows.Forms.Padding(4);
            this.FIOsort.Name = "FIOsort";
            this.FIOsort.Size = new System.Drawing.Size(88, 39);
            this.FIOsort.TabIndex = 6;
            this.FIOsort.TabStop = true;
            this.FIOsort.Text = "ФИО";
            this.FIOsort.UseVisualStyleBackColor = true;
            this.FIOsort.CheckedChanged += new System.EventHandler(this.FIOsort_CheckedChanged);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.ForeColor = System.Drawing.Color.Black;
            this.Age.Location = new System.Drawing.Point(31, 50);
            this.Age.Margin = new System.Windows.Forms.Padding(4);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(139, 39);
            this.Age.TabIndex = 5;
            this.Age.TabStop = true;
            this.Age.Text = "Возросту";
            this.Age.UseVisualStyleBackColor = true;
            this.Age.CheckedChanged += new System.EventHandler(this.Age_CheckedChanged);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(1224, 155);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(251, 74);
            this.Back.TabIndex = 44;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Task1
            // 
            this.Task1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Task1.BackColor = System.Drawing.Color.Black;
            this.Task1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task1.ForeColor = System.Drawing.Color.White;
            this.Task1.Location = new System.Drawing.Point(1224, 239);
            this.Task1.Margin = new System.Windows.Forms.Padding(4);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(251, 74);
            this.Task1.TabIndex = 45;
            this.Task1.Text = "Task1";
            this.Task1.UseVisualStyleBackColor = false;
            this.Task1.Click += new System.EventHandler(this.Task_Click);
            // 
            // Task2
            // 
            this.Task2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Task2.BackColor = System.Drawing.Color.Black;
            this.Task2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task2.ForeColor = System.Drawing.Color.White;
            this.Task2.Location = new System.Drawing.Point(1224, 323);
            this.Task2.Margin = new System.Windows.Forms.Padding(4);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(251, 74);
            this.Task2.TabIndex = 46;
            this.Task2.Text = "Task2";
            this.Task2.UseVisualStyleBackColor = false;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pianobutton);
            this.groupBox1.Controls.Add(this.skripkabutton);
            this.groupBox1.Controls.Add(this.guitarbutton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(660, 226);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(347, 196);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты к TASK 1";
            // 
            // pianobutton
            // 
            this.pianobutton.AutoSize = true;
            this.pianobutton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pianobutton.ForeColor = System.Drawing.Color.Black;
            this.pianobutton.Location = new System.Drawing.Point(31, 117);
            this.pianobutton.Margin = new System.Windows.Forms.Padding(4);
            this.pianobutton.Name = "pianobutton";
            this.pianobutton.Size = new System.Drawing.Size(173, 39);
            this.pianobutton.TabIndex = 7;
            this.pianobutton.TabStop = true;
            this.pianobutton.Text = "Фортепиано";
            this.pianobutton.UseVisualStyleBackColor = true;
            // 
            // skripkabutton
            // 
            this.skripkabutton.AutoSize = true;
            this.skripkabutton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skripkabutton.ForeColor = System.Drawing.Color.Black;
            this.skripkabutton.Location = new System.Drawing.Point(31, 83);
            this.skripkabutton.Margin = new System.Windows.Forms.Padding(4);
            this.skripkabutton.Name = "skripkabutton";
            this.skripkabutton.Size = new System.Drawing.Size(132, 39);
            this.skripkabutton.TabIndex = 6;
            this.skripkabutton.TabStop = true;
            this.skripkabutton.Text = "Скрипка";
            this.skripkabutton.UseVisualStyleBackColor = true;
            // 
            // guitarbutton
            // 
            this.guitarbutton.AutoSize = true;
            this.guitarbutton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guitarbutton.ForeColor = System.Drawing.Color.Black;
            this.guitarbutton.Location = new System.Drawing.Point(31, 46);
            this.guitarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.guitarbutton.Name = "guitarbutton";
            this.guitarbutton.Size = new System.Drawing.Size(114, 39);
            this.guitarbutton.TabIndex = 5;
            this.guitarbutton.TabStop = true;
            this.guitarbutton.Text = "Гитара";
            this.guitarbutton.UseVisualStyleBackColor = true;
            this.guitarbutton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // basicuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1896, 1051);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Instrument);
            this.Controls.Add(this.Инструмент);
            this.Controls.Add(this.Contry);
            this.Controls.Add(this.Страна);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.ФИО);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.DataTabel);
            this.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(1920, 1222);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "basicuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.DataTabel)).EndInit();
            this.Sort.ResumeLayout(false);
            this.Sort.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox Instrument;
        private System.Windows.Forms.Label Инструмент;
        private System.Windows.Forms.TextBox Contry;
        private System.Windows.Forms.Label Страна;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label ФИО;
        private System.Windows.Forms.GroupBox Sort;
        private System.Windows.Forms.RadioButton Plase;
        private System.Windows.Forms.RadioButton FIOsort;
        private System.Windows.Forms.RadioButton Age;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Task1;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pianobutton;
        private System.Windows.Forms.RadioButton skripkabutton;
        private System.Windows.Forms.RadioButton guitarbutton;
    }
}