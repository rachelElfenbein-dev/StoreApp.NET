namespace UI
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
            SalerBtn = new Button();
            ManagerBtn = new Button();
            SuspendLayout();
            // 
            // SalerBtn
            // 
            SalerBtn.Location = new Point(261, 167);
            SalerBtn.Name = "SalerBtn";
            SalerBtn.Size = new Size(104, 72);
            SalerBtn.TabIndex = 0;
            SalerBtn.Text = "קופאי";
            SalerBtn.UseVisualStyleBackColor = true;
            SalerBtn.Click += SalerBtn_Click;
            // 
            // ManagerBtn
            // 
            ManagerBtn.Location = new Point(433, 167);
            ManagerBtn.Name = "ManagerBtn";
            ManagerBtn.Size = new Size(110, 72);
            ManagerBtn.TabIndex = 1;
            ManagerBtn.Text = "מנהל";
            ManagerBtn.UseVisualStyleBackColor = true;
            ManagerBtn.Click += ManagerBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ManagerBtn);
            Controls.Add(SalerBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button SalerBtn;
        private Button ManagerBtn;
    }
}