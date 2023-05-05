namespace SEDC.AsyncAwaitWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetSync = new Button();
            btnGetAsync = new Button();
            btnCheckMessage = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnGetSync
            // 
            btnGetSync.Location = new Point(12, 54);
            btnGetSync.Name = "btnGetSync";
            btnGetSync.Size = new Size(169, 39);
            btnGetSync.TabIndex = 0;
            btnGetSync.Text = "Get message sync";
            btnGetSync.UseVisualStyleBackColor = true;
            btnGetSync.Click += btnGetSync_Click;
            // 
            // btnGetAsync
            // 
            btnGetAsync.Location = new Point(312, 54);
            btnGetAsync.Name = "btnGetAsync";
            btnGetAsync.Size = new Size(169, 39);
            btnGetAsync.TabIndex = 1;
            btnGetAsync.Text = "Get message async";
            btnGetAsync.UseVisualStyleBackColor = true;
            btnGetAsync.Click += btnGetAsync_Click;
            // 
            // btnCheckMessage
            // 
            btnCheckMessage.Location = new Point(581, 54);
            btnCheckMessage.Name = "btnCheckMessage";
            btnCheckMessage.Size = new Size(169, 39);
            btnCheckMessage.TabIndex = 2;
            btnCheckMessage.Text = "Check for message";
            btnCheckMessage.UseVisualStyleBackColor = true;
            btnCheckMessage.Click += btnCheckMessage_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Location = new Point(354, 186);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 25);
            lblMessage.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(btnCheckMessage);
            Controls.Add(btnGetAsync);
            Controls.Add(btnGetSync);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetSync;
        private Button btnGetAsync;
        private Button btnCheckMessage;
        private Label lblMessage;
    }
}