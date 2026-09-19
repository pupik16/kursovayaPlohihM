namespace Курсовая
{
    partial class log
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Авторизация = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Пароль = new System.Windows.Forms.Label();
            this.names = new System.Windows.Forms.TextBox();
            this.Имя = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Авторизация
            // 
            this.Авторизация.AutoSize = true;
            this.Авторизация.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Авторизация.ForeColor = System.Drawing.Color.Black;
            this.Авторизация.Location = new System.Drawing.Point(32, 28);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(312, 61);
            this.Авторизация.TabIndex = 23;
            this.Авторизация.Text = "Authorization";
            // 
            // Pass
            // 
            this.Pass.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.Pass.BackColor = System.Drawing.Color.Black;
            this.Pass.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.White;
            this.Pass.Location = new System.Drawing.Point(68, 268);
            this.Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = 'x';
            this.Pass.Size = new System.Drawing.Size(232, 47);
            this.Pass.TabIndex = 29;
            // 
            // Пароль
            // 
            this.Пароль.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.Пароль.AutoSize = true;
            this.Пароль.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Пароль.ForeColor = System.Drawing.Color.Black;
            this.Пароль.Location = new System.Drawing.Point(112, 216);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(150, 41);
            this.Пароль.TabIndex = 28;
            this.Пароль.Text = "Password";
            // 
            // names
            // 
            this.names.BackColor = System.Drawing.Color.Black;
            this.names.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.names.ForeColor = System.Drawing.Color.White;
            this.names.Location = new System.Drawing.Point(68, 158);
            this.names.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(232, 47);
            this.names.TabIndex = 27;
            // 
            // Имя
            // 
            this.Имя.AutoSize = true;
            this.Имя.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Имя.ForeColor = System.Drawing.Color.Black;
            this.Имя.Location = new System.Drawing.Point(141, 115);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(99, 41);
            this.Имя.TabIndex = 26;
            this.Имя.Text = "Name";
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Black;
            this.LogIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn.ForeColor = System.Drawing.Color.White;
            this.LogIn.Location = new System.Drawing.Point(0, 410);
            this.LogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(373, 78);
            this.LogIn.TabIndex = 30;
            this.LogIn.Text = "LogIn";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Black;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(293, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(80, 35);
            this.Close.TabIndex = 44;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 488);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.names);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.Авторизация);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(373, 488);
            this.MinimumSize = new System.Drawing.Size(373, 488);
            this.Name = "log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Авторизация;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label Пароль;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.Label Имя;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button Close;
    }
}

