namespace UI
{
    partial class MianForm
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
            ProductBtn = new Button();
            CustomerBtn = new Button();
            SaleBtn = new Button();
            SuspendLayout();
            // 
            // ProductBtn
            // 
            ProductBtn.Location = new Point(135, 175);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(144, 90);
            ProductBtn.TabIndex = 0;
            ProductBtn.Text = "מוצר";
            ProductBtn.UseVisualStyleBackColor = true;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // CustomerBtn
            // 
            CustomerBtn.Location = new Point(329, 175);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.Size = new Size(144, 90);
            CustomerBtn.TabIndex = 1;
            CustomerBtn.Text = "לקוח";
            CustomerBtn.UseVisualStyleBackColor = true;
            CustomerBtn.Click += CustomerBtn_Click;
            // 
            // SaleBtn
            // 
            SaleBtn.Location = new Point(533, 175);
            SaleBtn.Name = "SaleBtn";
            SaleBtn.Size = new Size(144, 90);
            SaleBtn.TabIndex = 2;
            SaleBtn.Text = "מבצע";
            SaleBtn.UseVisualStyleBackColor = true;
            SaleBtn.Click += SaleBtn_Click;
            // 
            // MianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaleBtn);
            Controls.Add(CustomerBtn);
            Controls.Add(ProductBtn);
            Name = "MianForm";
            Text = "MianForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ProductBtn;
        private Button CustomerBtn;
        private Button SaleBtn;
    }
}