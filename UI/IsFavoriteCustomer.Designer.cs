namespace UI
{
    partial class IsFavoriteCustomer
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
            textBoxIdCus = new TextBox();
            label1 = new Label();
            buttonFindCus = new Button();
            SuspendLayout();
            // 
            // textBoxIdCus
            // 
            textBoxIdCus.Location = new Point(289, 215);
            textBoxIdCus.Name = "textBoxIdCus";
            textBoxIdCus.Size = new Size(240, 23);
            textBoxIdCus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 188);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "הכנס קוד לקוח";
            label1.Click += label1_Click;
            // 
            // buttonFindCus
            // 
            buttonFindCus.Location = new Point(365, 260);
            buttonFindCus.Name = "buttonFindCus";
            buttonFindCus.Size = new Size(75, 23);
            buttonFindCus.TabIndex = 2;
            buttonFindCus.Text = "הכנס";
            buttonFindCus.UseVisualStyleBackColor = true;
            buttonFindCus.Click += buttonFindCus_Click;
            // 
            // IsFavoriteCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFindCus);
            Controls.Add(label1);
            Controls.Add(textBoxIdCus);
            Name = "IsFavoriteCustomer";
            Text = "IsFavoriteCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIdCus;
        private Label label1;
        private Button buttonFindCus;
    }
}