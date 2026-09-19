namespace Курсовая
{
    partial class basicadm
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
            this.DataLog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Close = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLog)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTabel
            // 
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
            this.DataTabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataTabel.Location = new System.Drawing.Point(0, 0);
            this.DataTabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataTabel.Name = "DataTabel";
            this.DataTabel.RowHeadersWidth = 51;
            this.DataTabel.RowTemplate.Height = 28;
            this.DataTabel.Size = new System.Drawing.Size(1127, 1000);
            this.DataTabel.TabIndex = 3;
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
            // DataLog
            // 
            this.DataLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DataLog.Location = new System.Drawing.Point(1123, 324);
            this.DataLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataLog.Name = "DataLog";
            this.DataLog.RowHeadersWidth = 51;
            this.DataLog.RowTemplate.Height = 28;
            this.DataLog.Size = new System.Drawing.Size(481, 676);
            this.DataLog.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 61.35588F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Admin or User";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 80.50692F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 84.87518F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(1133, 222);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(209, 62);
            this.Close.TabIndex = 44;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Black;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(1133, 57);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(209, 62);
            this.Save.TabIndex = 45;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(1348, 222);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(209, 62);
            this.Back.TabIndex = 46;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserButton.BackColor = System.Drawing.Color.Black;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserButton.ForeColor = System.Drawing.Color.White;
            this.AddUserButton.Location = new System.Drawing.Point(1348, 57);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(209, 62);
            this.AddUserButton.TabIndex = 47;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // basicadm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DataLog);
            this.Controls.Add(this.DataTabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "basicadm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DataTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLog)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView DataLog;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button AddUserButton;
    }
}