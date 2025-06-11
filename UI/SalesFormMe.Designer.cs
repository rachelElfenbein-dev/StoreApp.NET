namespace UI
{
    partial class SalesFormMe
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
            ShowOneItemBtn = new Button();
            ShowAllBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            panelShowOneProduct = new Panel();
            dataGridView1ShowProduct = new DataGridView();
            buttonSearchProduct = new Button();
            textBoxProductId = new TextBox();
            label1 = new Label();
            ShowAllPanel = new Panel();
            buttonFilter = new Button();
            label3 = new Label();
            textBoxChoose = new TextBox();
            ShowAllDataGridView = new DataGridView();
            panelAddSale = new Panel();
            textBoxTotalPrice = new TextBox();
            label5 = new Label();
            textBoxAmountForSale = new TextBox();
            label4 = new Label();
            textBoxIDProduct = new TextBox();
            label2 = new Label();
            panelShowOneProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1ShowProduct).BeginInit();
            ShowAllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowAllDataGridView).BeginInit();
            panelAddSale.SuspendLayout();
            SuspendLayout();
            // 
            // ShowOneItemBtn
            // 
            ShowOneItemBtn.Location = new Point(563, 340);
            ShowOneItemBtn.Name = "ShowOneItemBtn";
            ShowOneItemBtn.Size = new Size(177, 60);
            ShowOneItemBtn.TabIndex = 14;
            ShowOneItemBtn.Text = "הצג מבצע בודד";
            ShowOneItemBtn.UseVisualStyleBackColor = true;
            ShowOneItemBtn.Click += ShowOneItemBtn_Click;
            // 
            // ShowAllBtn
            // 
            ShowAllBtn.Location = new Point(563, 267);
            ShowAllBtn.Name = "ShowAllBtn";
            ShowAllBtn.Size = new Size(177, 60);
            ShowAllBtn.TabIndex = 13;
            ShowAllBtn.Text = "הצג הכל";
            ShowAllBtn.UseVisualStyleBackColor = true;
            ShowAllBtn.Click += ShowAllBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(563, 189);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(177, 63);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "מחיקת מבצע";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(563, 107);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(177, 64);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "עדכון מבצע";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(563, 31);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(177, 61);
            addBtn.TabIndex = 10;
            addBtn.Text = "הוספת מבצע";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // panelShowOneProduct
            // 
            panelShowOneProduct.Controls.Add(dataGridView1ShowProduct);
            panelShowOneProduct.Controls.Add(buttonSearchProduct);
            panelShowOneProduct.Controls.Add(textBoxProductId);
            panelShowOneProduct.Controls.Add(label1);
            panelShowOneProduct.Location = new Point(26, 12);
            panelShowOneProduct.Name = "panelShowOneProduct";
            panelShowOneProduct.Size = new Size(429, 422);
            panelShowOneProduct.TabIndex = 15;
            // 
            // dataGridView1ShowProduct
            // 
            dataGridView1ShowProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1ShowProduct.Location = new Point(15, 166);
            dataGridView1ShowProduct.Name = "dataGridView1ShowProduct";
            dataGridView1ShowProduct.RowTemplate.Height = 25;
            dataGridView1ShowProduct.Size = new Size(401, 198);
            dataGridView1ShowProduct.TabIndex = 3;
            // 
            // buttonSearchProduct
            // 
            buttonSearchProduct.Location = new Point(169, 83);
            buttonSearchProduct.Name = "buttonSearchProduct";
            buttonSearchProduct.Size = new Size(75, 23);
            buttonSearchProduct.TabIndex = 2;
            buttonSearchProduct.Text = "חפש מוצר";
            buttonSearchProduct.UseVisualStyleBackColor = true;
            buttonSearchProduct.Click += buttonSearchProduct_Click;
            // 
            // textBoxProductId
            // 
            textBoxProductId.Location = new Point(155, 48);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.Size = new Size(100, 23);
            textBoxProductId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "הכנס קוד מוצר";
            // 
            // ShowAllPanel
            // 
            ShowAllPanel.Controls.Add(buttonFilter);
            ShowAllPanel.Controls.Add(label3);
            ShowAllPanel.Controls.Add(textBoxChoose);
            ShowAllPanel.Controls.Add(ShowAllDataGridView);
            ShowAllPanel.Location = new Point(55, 12);
            ShowAllPanel.Name = "ShowAllPanel";
            ShowAllPanel.Size = new Size(338, 408);
            ShowAllPanel.TabIndex = 16;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(147, 301);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(75, 23);
            buttonFilter.TabIndex = 3;
            buttonFilter.Text = "סנן";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 244);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "סינון לפי שם";
            // 
            // textBoxChoose
            // 
            textBoxChoose.Location = new Point(134, 267);
            textBoxChoose.Name = "textBoxChoose";
            textBoxChoose.Size = new Size(100, 23);
            textBoxChoose.TabIndex = 1;
            // 
            // ShowAllDataGridView
            // 
            ShowAllDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowAllDataGridView.Location = new Point(11, 18);
            ShowAllDataGridView.Name = "ShowAllDataGridView";
            ShowAllDataGridView.RowTemplate.Height = 25;
            ShowAllDataGridView.Size = new Size(297, 208);
            ShowAllDataGridView.TabIndex = 0;
            // 
            // panelAddSale
            // 
            panelAddSale.Controls.Add(textBoxTotalPrice);
            panelAddSale.Controls.Add(label5);
            panelAddSale.Controls.Add(textBoxAmountForSale);
            panelAddSale.Controls.Add(label4);
            panelAddSale.Controls.Add(textBoxIDProduct);
            panelAddSale.Controls.Add(label2);
            panelAddSale.Location = new Point(16, 12);
            panelAddSale.Name = "panelAddSale";
            panelAddSale.Size = new Size(426, 422);
            panelAddSale.TabIndex = 17;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(173, 97);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(100, 23);
            textBoxTotalPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 101);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "מחיר למבצע";
            // 
            // textBoxAmountForSale
            // 
            textBoxAmountForSale.Location = new Point(173, 68);
            textBoxAmountForSale.Name = "textBoxAmountForSale";
            textBoxAmountForSale.Size = new Size(100, 23);
            textBoxAmountForSale.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 72);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 2;
            label4.Text = "הכנס כמות למבצע";
            // 
            // textBoxIDProduct
            // 
            textBoxIDProduct.Location = new Point(172, 39);
            textBoxIDProduct.Name = "textBoxIDProduct";
            textBoxIDProduct.Size = new Size(100, 23);
            textBoxIDProduct.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 42);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 0;
            label2.Text = "הכנס קוד מוצר למבצע";
            // 
            // SalesFormMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAddSale);
            Controls.Add(ShowAllPanel);
            Controls.Add(panelShowOneProduct);
            Controls.Add(ShowOneItemBtn);
            Controls.Add(ShowAllBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Name = "SalesFormMe";
            Text = "SalesFormMe";
            panelShowOneProduct.ResumeLayout(false);
            panelShowOneProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1ShowProduct).EndInit();
            ShowAllPanel.ResumeLayout(false);
            ShowAllPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowAllDataGridView).EndInit();
            panelAddSale.ResumeLayout(false);
            panelAddSale.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ShowOneItemBtn;
        private Button ShowAllBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private Panel panelShowOneProduct;
        private DataGridView dataGridView1ShowProduct;
        private Button buttonSearchProduct;
        private TextBox textBoxProductId;
        private Label label1;
        private Panel ShowAllPanel;
        private Button buttonFilter;
        private Label label3;
        private TextBox textBoxChoose;
        private DataGridView ShowAllDataGridView;
        private Panel panelAddSale;
        private TextBox textBoxIDProduct;
        private Label label2;
        private Label label4;
        private TextBox textBoxAmountForSale;
        private TextBox textBoxTotalPrice;
        private Label label5;
    }
}