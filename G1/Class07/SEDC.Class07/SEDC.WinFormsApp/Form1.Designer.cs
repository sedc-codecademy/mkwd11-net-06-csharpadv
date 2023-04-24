namespace SEDC.WinFormsApp
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
            label1 = new Label();
            txtSomething = new TextBox();
            btnSave = new Button();
            lblResult = new Label();
            label2 = new Label();
            lblTimesClicked = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter something";
            // 
            // txtSomething
            // 
            txtSomething.Location = new Point(12, 52);
            txtSomething.Name = "txtSomething";
            txtSomething.Size = new Size(159, 23);
            txtSomething.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(177, 51);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.ForeColor = Color.Tomato;
            lblResult.Location = new Point(12, 113);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 4;
            label2.Text = "Times clicked: ";
            // 
            // lblTimesClicked
            // 
            lblTimesClicked.AutoSize = true;
            lblTimesClicked.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimesClicked.Location = new Point(145, 155);
            lblTimesClicked.Name = "lblTimesClicked";
            lblTimesClicked.Size = new Size(0, 21);
            lblTimesClicked.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 571);
            Controls.Add(lblTimesClicked);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(btnSave);
            Controls.Add(txtSomething);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSomething;
        private Button btnSave;
        private Label lblResult;
        private Label label2;
        private Label lblTimesClicked;
    }
}