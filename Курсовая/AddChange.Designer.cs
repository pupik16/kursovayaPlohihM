namespace Курсовая
{
    partial class AddChange
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
            this.CountryList = new System.Windows.Forms.ComboBox();
            this.InstrumentList = new System.Windows.Forms.ComboBox();
            this.FIOadd = new System.Windows.Forms.TextBox();
            this.ФИО = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yearadd = new System.Windows.Forms.TextBox();
            this.placelist = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.placelist)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryList
            // 
            this.CountryList.FormattingEnabled = true;
            this.CountryList.Items.AddRange(new object[] {
            "Беларусь",
            "Россия",
            "Узбекистан",
            "Азербайджан",
            "Кыргызстан",
            "Казахстан",
            "Таджикистан",
            "Армения",
            "Грузия"});
            this.CountryList.Location = new System.Drawing.Point(36, 62);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(121, 24);
            this.CountryList.TabIndex = 0;
            // 
            // InstrumentList
            // 
            this.InstrumentList.FormattingEnabled = true;
            this.InstrumentList.Items.AddRange(new object[] {
            "фортепиано",
            "гитара",
            "скрипка"});
            this.InstrumentList.Location = new System.Drawing.Point(36, 164);
            this.InstrumentList.Name = "InstrumentList";
            this.InstrumentList.Size = new System.Drawing.Size(121, 24);
            this.InstrumentList.TabIndex = 1;
            // 
            // FIOadd
            // 
            this.FIOadd.BackColor = System.Drawing.Color.Black;
            this.FIOadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOadd.ForeColor = System.Drawing.Color.White;
            this.FIOadd.Location = new System.Drawing.Point(241, 62);
            this.FIOadd.Margin = new System.Windows.Forms.Padding(4);
            this.FIOadd.Name = "FIOadd";
            this.FIOadd.Size = new System.Drawing.Size(233, 38);
            this.FIOadd.TabIndex = 38;
            // 
            // ФИО
            // 
            this.ФИО.AutoSize = true;
            this.ФИО.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ФИО.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ФИО.Location = new System.Drawing.Point(234, 9);
            this.ФИО.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ФИО.Name = "ФИО";
            this.ФИО.Size = new System.Drawing.Size(76, 38);
            this.ФИО.TabIndex = 39;
            this.ФИО.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(245, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "Год рождения";
            // 
            // yearadd
            // 
            this.yearadd.BackColor = System.Drawing.Color.Black;
            this.yearadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearadd.ForeColor = System.Drawing.Color.White;
            this.yearadd.Location = new System.Drawing.Point(252, 154);
            this.yearadd.Margin = new System.Windows.Forms.Padding(4);
            this.yearadd.Name = "yearadd";
            this.yearadd.Size = new System.Drawing.Size(233, 38);
            this.yearadd.TabIndex = 40;
            // 
            // placelist
            // 
            this.placelist.Location = new System.Drawing.Point(554, 87);
            this.placelist.Name = "placelist";
            this.placelist.Size = new System.Drawing.Size(120, 22);
            this.placelist.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 38);
            this.label2.TabIndex = 43;
            this.label2.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 38);
            this.label3.TabIndex = 44;
            this.label3.Text = "Инструмент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(547, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 38);
            this.label4.TabIndex = 45;
            this.label4.Text = "Место";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.Black;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(59, 332);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(209, 62);
            this.AddButton.TabIndex = 48;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(523, 332);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(209, 62);
            this.Back.TabIndex = 49;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placelist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearadd);
            this.Controls.Add(this.ФИО);
            this.Controls.Add(this.FIOadd);
            this.Controls.Add(this.InstrumentList);
            this.Controls.Add(this.CountryList);
            this.Name = "AddChange";
            this.Text = "AddChange";
            ((System.ComponentModel.ISupportInitialize)(this.placelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryList;
        private System.Windows.Forms.ComboBox InstrumentList;
        private System.Windows.Forms.TextBox FIOadd;
        private System.Windows.Forms.Label ФИО;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearadd;
        private System.Windows.Forms.NumericUpDown placelist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Back;
    }
}