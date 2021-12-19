namespace Client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbx_message = new System.Windows.Forms.ListBox();
            this.btnCreateConnection = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zdnButton = new System.Windows.Forms.Button();
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_message
            // 
            this.lbx_message.FormattingEnabled = true;
            this.lbx_message.ItemHeight = 20;
            this.lbx_message.Location = new System.Drawing.Point(13, 235);
            this.lbx_message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_message.Name = "lbx_message";
            this.lbx_message.Size = new System.Drawing.Size(888, 144);
            this.lbx_message.TabIndex = 1;
            // 
            // btnCreateConnection
            // 
            this.btnCreateConnection.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateConnection.Location = new System.Drawing.Point(13, 434);
            this.btnCreateConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateConnection.Name = "btnCreateConnection";
            this.btnCreateConnection.Size = new System.Drawing.Size(315, 73);
            this.btnCreateConnection.TabIndex = 2;
            this.btnCreateConnection.Text = "Получить данные с сервера 1";
            this.btnCreateConnection.UseVisualStyleBackColor = true;
            this.btnCreateConnection.Click += new System.EventHandler(this.btnCreateConnection_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendMessage.Location = new System.Drawing.Point(345, 433);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(315, 74);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "Получить данные с сервера 2";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(677, 433);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(224, 74);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(932, 434);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(330, 73);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(513, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Курсовая работа по дисциплине ОС\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Данные с серверов:";
            // 
            // zdnButton
            // 
            this.zdnButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zdnButton.Location = new System.Drawing.Point(932, 337);
            this.zdnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zdnButton.Name = "zdnButton";
            this.zdnButton.Size = new System.Drawing.Size(330, 72);
            this.zdnButton.TabIndex = 8;
            this.zdnButton.Text = "Задание";
            this.zdnButton.UseVisualStyleBackColor = true;
            this.zdnButton.Click += new System.EventHandler(this.zdnButton_Click);
            // 
            // ServerIP
            // 
            this.ServerIP.Location = new System.Drawing.Point(631, 169);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(166, 26);
            this.ServerIP.TabIndex = 9;
            this.ServerIP.Text = "192.168.1.65";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(378, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "IP адрес устройства:";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1130, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выполнила: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(979, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = " студентка группы БФИ1901";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1121, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Мухина М.М.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1143, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Проверила:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1106, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Алексанян Д.А";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 521);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.zdnButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnCreateConnection);
            this.Controls.Add(this.lbx_message);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateConnection;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zdnButton;
        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox lbx_message;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

