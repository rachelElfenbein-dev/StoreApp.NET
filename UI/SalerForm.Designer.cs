namespace UI
{
    partial class SalerForm
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
            AddProductBtn = new Button();
            label1 = new Label();
            textBoxChooseItem = new TextBox();
            listProducts = new ListBox();
            dataGridViewShowAllProduct = new DataGridView();
            listSales = new ListBox();
            DoOrderBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowAllProduct).BeginInit();
            SuspendLayout();
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(464, 123);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(100, 22);
            AddProductBtn.TabIndex = 0;
            AddProductBtn.Text = "להוספת המוצר";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(588, 79);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 1;
            label1.Text = "הקלד קוד או בחר מהרשימה";
            // 
            // textBoxChooseItem
            // 
            textBoxChooseItem.Location = new Point(464, 79);
            textBoxChooseItem.Name = "textBoxChooseItem";
            textBoxChooseItem.Size = new Size(100, 23);
            textBoxChooseItem.TabIndex = 2;
            // 
            // listProducts
            // 
            listProducts.FormattingEnabled = true;
            listProducts.ItemHeight = 15;
            listProducts.Location = new Point(91, 12);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(228, 184);
            listProducts.TabIndex = 4;
            // 
            // dataGridViewShowAllProduct
            // 
            dataGridViewShowAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShowAllProduct.Location = new Point(353, 151);
            dataGridViewShowAllProduct.Name = "dataGridViewShowAllProduct";
            dataGridViewShowAllProduct.RowTemplate.Height = 25;
            dataGridViewShowAllProduct.Size = new Size(435, 268);
            dataGridViewShowAllProduct.TabIndex = 5;
            // 
            // listSales
            // 
            listSales.FormattingEnabled = true;
            listSales.ItemHeight = 15;
            listSales.Location = new Point(91, 202);
            listSales.Name = "listSales";
            listSales.Size = new Size(228, 184);
            listSales.TabIndex = 6;
            // 
            // DoOrderBtn
            // 
            DoOrderBtn.Location = new Point(134, 392);
            DoOrderBtn.Name = "DoOrderBtn";
            DoOrderBtn.Size = new Size(128, 41);
            DoOrderBtn.TabIndex = 7;
            DoOrderBtn.Text = "לביצוע ההזמנה";
            DoOrderBtn.UseVisualStyleBackColor = true;
            DoOrderBtn.Click += DoOrderBtn_Click;
            // 
            // SalerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DoOrderBtn);
            Controls.Add(listSales);
            Controls.Add(dataGridViewShowAllProduct);
            Controls.Add(listProducts);
            Controls.Add(textBoxChooseItem);
            Controls.Add(label1);
            Controls.Add(AddProductBtn);
            Name = "SalerForm";
            Text = "SalerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowAllProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProductBtn;
        private Label label1;
        private TextBox textBoxChooseItem;
        private ListBox listProducts;
        private DataGridView dataGridViewShowAllProduct;
        private ListBox listSales;
        private Button DoOrderBtn;
    }
}