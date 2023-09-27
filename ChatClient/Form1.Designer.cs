namespace ChatClient
{
    partial class FormChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.btConnDicon = new System.Windows.Forms.Button();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btConnDicon
            // 
            this.btConnDicon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btConnDicon.Location = new System.Drawing.Point(33, 24);
            this.btConnDicon.Name = "btConnDicon";
            this.btConnDicon.Size = new System.Drawing.Size(139, 35);
            this.btConnDicon.TabIndex = 0;
            this.btConnDicon.Text = "Connect";
            this.btConnDicon.UseVisualStyleBackColor = true;
            this.btConnDicon.Click += new System.EventHandler(this.btConnDicon_Click);
            // 
            // lbChat
            // 
            this.lbChat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 20;
            this.lbChat.Location = new System.Drawing.Point(33, 65);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(493, 184);
            this.lbChat.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserName.Location = new System.Drawing.Point(178, 24);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(348, 35);
            this.tbUserName.TabIndex = 2;
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.Location = new System.Drawing.Point(33, 255);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(493, 42);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(558, 324);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.btConnDicon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnDicon;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbMessage;
    }
}

