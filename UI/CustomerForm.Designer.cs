namespace UI
{
    partial class CustomerForm
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
            DeleteItemPanel = new Panel();
            ShowAllPanel = new Panel();
            buttonFilter = new Button();
            label2 = new Label();
            textBoxChoose = new TextBox();
            ShowAllDataGridView = new DataGridView();
            AddCustomerPanel = new Panel();
            UpdateCustomerBtn = new Button();
            addCustomerBtn = new Button();
            AdressTxt = new TextBox();
            label6 = new Label();
            PhoneTxt = new TextBox();
            label5 = new Label();
            NameTxt = new TextBox();
            label4 = new Label();
            CustomerIdNum = new NumericUpDown();
            label3 = new Label();
            dataGridViewShowToDelete = new DataGridView();
            DeleteItemBtn = new Button();
            panelShowOneProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1ShowProduct).BeginInit();
            DeleteItemPanel.SuspendLayout();
            ShowAllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowAllDataGridView).BeginInit();
            AddCustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerIdNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowToDelete).BeginInit();
            SuspendLayout();
            // 
            // ShowOneItemBtn
            // 
            ShowOneItemBtn.Location = new Point(614, 467);
            ShowOneItemBtn.Margin = new Padding(3, 4, 3, 4);
            ShowOneItemBtn.Name = "ShowOneItemBtn";
            ShowOneItemBtn.Size = new Size(202, 80);
            ShowOneItemBtn.TabIndex = 14;
            ShowOneItemBtn.Text = "הצג לקוח בודד";
            ShowOneItemBtn.UseVisualStyleBackColor = true;
            ShowOneItemBtn.Click += ShowOneItemBtn_Click;
            // 
            // ShowAllBtn
            // 
            ShowAllBtn.Location = new Point(614, 369);
            ShowAllBtn.Margin = new Padding(3, 4, 3, 4);
            ShowAllBtn.Name = "ShowAllBtn";
            ShowAllBtn.Size = new Size(202, 80);
            ShowAllBtn.TabIndex = 13;
            ShowAllBtn.Text = "הצג הכל";
            ShowAllBtn.UseVisualStyleBackColor = true;
            ShowAllBtn.Click += ShowAllBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(614, 265);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(202, 84);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "מחיקת לקוח";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(614, 156);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(202, 85);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "עדכון לקוח";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(614, 55);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(202, 81);
            addBtn.TabIndex = 10;
            addBtn.Text = "הוספת לקוח";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // panelShowOneProduct
            // 
            panelShowOneProduct.Controls.Add(dataGridView1ShowProduct);
            panelShowOneProduct.Controls.Add(buttonSearchProduct);
            panelShowOneProduct.Controls.Add(textBoxProductId);
            panelShowOneProduct.Controls.Add(label1);
            panelShowOneProduct.Location = new Point(39, 21);
            panelShowOneProduct.Margin = new Padding(3, 4, 3, 4);
            panelShowOneProduct.Name = "panelShowOneProduct";
            panelShowOneProduct.Size = new Size(490, 563);
            panelShowOneProduct.TabIndex = 15;
            // 
            // dataGridView1ShowProduct
            // 
            dataGridView1ShowProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1ShowProduct.Location = new Point(17, 221);
            dataGridView1ShowProduct.Margin = new Padding(3, 4, 3, 4);
            dataGridView1ShowProduct.Name = "dataGridView1ShowProduct";
            dataGridView1ShowProduct.RowHeadersWidth = 51;
            dataGridView1ShowProduct.RowTemplate.Height = 25;
            dataGridView1ShowProduct.Size = new Size(458, 264);
            dataGridView1ShowProduct.TabIndex = 3;
            // 
            // buttonSearchProduct
            // 
            buttonSearchProduct.Location = new Point(193, 111);
            buttonSearchProduct.Margin = new Padding(3, 4, 3, 4);
            buttonSearchProduct.Name = "buttonSearchProduct";
            buttonSearchProduct.Size = new Size(86, 31);
            buttonSearchProduct.TabIndex = 2;
            buttonSearchProduct.Text = "חפש לקוח";
            buttonSearchProduct.UseVisualStyleBackColor = true;
            buttonSearchProduct.Click += buttonSearchProduct_Click;
            // 
            // textBoxProductId
            // 
            textBoxProductId.Location = new Point(177, 64);
            textBoxProductId.Margin = new Padding(3, 4, 3, 4);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.Size = new Size(114, 27);
            textBoxProductId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס קוד לקוח";
            // 
            // DeleteItemPanel
            // 
            DeleteItemPanel.Controls.Add(AddCustomerPanel);
            DeleteItemPanel.Controls.Add(dataGridViewShowToDelete);
            DeleteItemPanel.Controls.Add(DeleteItemBtn);
            DeleteItemPanel.Location = new Point(39, 0);
            DeleteItemPanel.Margin = new Padding(3, 4, 3, 4);
            DeleteItemPanel.Name = "DeleteItemPanel";
            DeleteItemPanel.Size = new Size(522, 608);
            DeleteItemPanel.TabIndex = 16;
            // 
            // ShowAllPanel
            // 
            ShowAllPanel.Controls.Add(buttonFilter);
            ShowAllPanel.Controls.Add(label2);
            ShowAllPanel.Controls.Add(textBoxChoose);
            ShowAllPanel.Controls.Add(ShowAllDataGridView);
            ShowAllPanel.Location = new Point(0, 13);
            ShowAllPanel.Margin = new Padding(3, 4, 3, 4);
            ShowAllPanel.Name = "ShowAllPanel";
            ShowAllPanel.Size = new Size(507, 544);
            ShowAllPanel.TabIndex = 18;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(168, 401);
            buttonFilter.Margin = new Padding(3, 4, 3, 4);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(86, 31);
            buttonFilter.TabIndex = 3;
            buttonFilter.Text = "סנן";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 325);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "סינון לפי שם";
            // 
            // textBoxChoose
            // 
            textBoxChoose.Location = new Point(153, 356);
            textBoxChoose.Margin = new Padding(3, 4, 3, 4);
            textBoxChoose.Name = "textBoxChoose";
            textBoxChoose.Size = new Size(114, 27);
            textBoxChoose.TabIndex = 1;
            // 
            // ShowAllDataGridView
            // 
            ShowAllDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowAllDataGridView.Location = new Point(55, 29);
            ShowAllDataGridView.Margin = new Padding(3, 4, 3, 4);
            ShowAllDataGridView.Name = "ShowAllDataGridView";
            ShowAllDataGridView.RowHeadersWidth = 51;
            ShowAllDataGridView.RowTemplate.Height = 25;
            ShowAllDataGridView.Size = new Size(339, 277);
            ShowAllDataGridView.TabIndex = 0;
            // 
            // AddCustomerPanel
            // 
            AddCustomerPanel.Controls.Add(ShowAllPanel);
            AddCustomerPanel.Controls.Add(UpdateCustomerBtn);
            AddCustomerPanel.Controls.Add(addCustomerBtn);
            AddCustomerPanel.Controls.Add(AdressTxt);
            AddCustomerPanel.Controls.Add(label6);
            AddCustomerPanel.Controls.Add(PhoneTxt);
            AddCustomerPanel.Controls.Add(label5);
            AddCustomerPanel.Controls.Add(NameTxt);
            AddCustomerPanel.Controls.Add(label4);
            AddCustomerPanel.Controls.Add(CustomerIdNum);
            AddCustomerPanel.Controls.Add(label3);
            AddCustomerPanel.Location = new Point(32, 12);
            AddCustomerPanel.Margin = new Padding(3, 4, 3, 4);
            AddCustomerPanel.Name = "AddCustomerPanel";
            AddCustomerPanel.Size = new Size(516, 596);
            AddCustomerPanel.TabIndex = 17;
            // 
            // UpdateCustomerBtn
            // 
            UpdateCustomerBtn.Location = new Point(16, 459);
            UpdateCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            UpdateCustomerBtn.Size = new Size(86, 31);
            UpdateCustomerBtn.TabIndex = 9;
            UpdateCustomerBtn.Text = "עדכון";
            UpdateCustomerBtn.UseVisualStyleBackColor = true;
            UpdateCustomerBtn.Click += UpdateItemBtn_Click;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(109, 459);
            addCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(86, 31);
            addCustomerBtn.TabIndex = 8;
            addCustomerBtn.Text = "להוספה";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += ConfirmAddBtn_Click;
            // 
            // AdressTxt
            // 
            AdressTxt.Location = new Point(171, 397);
            AdressTxt.Margin = new Padding(3, 4, 3, 4);
            AdressTxt.Name = "AdressTxt";
            AdressTxt.Size = new Size(114, 27);
            AdressTxt.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 409);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 6;
            label6.Text = "הכנס כתובת";
            // 
            // PhoneTxt
            // 
            PhoneTxt.Location = new Point(163, 328);
            PhoneTxt.Margin = new Padding(3, 4, 3, 4);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(114, 27);
            PhoneTxt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 336);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "הכנס טלפון";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(163, 263);
            NameTxt.Margin = new Padding(3, 4, 3, 4);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(114, 27);
            NameTxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 263);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "הכנס שם";
            // 
            // CustomerIdNum
            // 
            CustomerIdNum.Location = new Point(155, 188);
            CustomerIdNum.Margin = new Padding(3, 4, 3, 4);
            CustomerIdNum.Name = "CustomerIdNum";
            CustomerIdNum.Size = new Size(137, 27);
            CustomerIdNum.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 188);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 0;
            label3.Text = "הכנס ID";
            // 
            // dataGridViewShowToDelete
            // 
            dataGridViewShowToDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShowToDelete.Location = new Point(123, 93);
            dataGridViewShowToDelete.Margin = new Padding(3, 4, 3, 4);
            dataGridViewShowToDelete.Name = "dataGridViewShowToDelete";
            dataGridViewShowToDelete.RowHeadersWidth = 51;
            dataGridViewShowToDelete.RowTemplate.Height = 25;
            dataGridViewShowToDelete.Size = new Size(274, 200);
            dataGridViewShowToDelete.TabIndex = 1;
            // 
            // DeleteItemBtn
            // 
            DeleteItemBtn.Location = new Point(123, 413);
            DeleteItemBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteItemBtn.Name = "DeleteItemBtn";
            DeleteItemBtn.Size = new Size(86, 31);
            DeleteItemBtn.TabIndex = 0;
            DeleteItemBtn.Text = "למחיקה";
            DeleteItemBtn.UseVisualStyleBackColor = true;
            DeleteItemBtn.Click += DeleteItemBtn_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(DeleteItemPanel);
            Controls.Add(panelShowOneProduct);
            Controls.Add(ShowOneItemBtn);
            Controls.Add(ShowAllBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            Text = "Form2";
            panelShowOneProduct.ResumeLayout(false);
            panelShowOneProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1ShowProduct).EndInit();
            DeleteItemPanel.ResumeLayout(false);
            ShowAllPanel.ResumeLayout(false);
            ShowAllPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowAllDataGridView).EndInit();
            AddCustomerPanel.ResumeLayout(false);
            AddCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerIdNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowToDelete).EndInit();
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
        private DataGridView dataGridViewShowToDelete;
        private Button DeleteItemBtn;
        private Panel DeleteItemPanel;
        private Panel ShowAllPanel;
        private Button buttonFilter;
        private Label label2;
        private TextBox textBoxChoose;
        private DataGridView ShowAllDataGridView;
        private Button UpdateCustomerBtn;
        private Button addCustomerBtn;
        private TextBox AdressTxt;
        private Label label6;
        private TextBox PhoneTxt;
        private Label label5;
        private TextBox NameTxt;
        private Label label4;
        private NumericUpDown CustomerIdNum;
        private Label label3;
        private Panel AddCustomerPanel;
    }
}