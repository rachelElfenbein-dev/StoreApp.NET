namespace UI
{
    partial class ManagerForm
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
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            ShowAllBtn = new Button();
            AddPanel = new Panel();
            dataGridViewShowToDelete = new DataGridView();
            UpdateItemBtn = new Button();
            ChooseItemBtn = new Button();
            dataGridViewProduct = new DataGridView();
            IdTxt = new TextBox();
            CodeLbl = new Label();
            ConfirmAddBtn = new Button();
            quantityNumericUpDown = new NumericUpDown();
            PriceNumericUpDown = new NumericUpDown();
            quantityLbl = new Label();
            priceLbl = new Label();
            categoryLbl = new Label();
            categoryCOmboBox = new ComboBox();
            nameLbl = new Label();
            nameTxt = new TextBox();
            DeleteItemPanel = new Panel();
            DeleteItemBtn = new Button();
            panelShowOneProduct = new Panel();
            dataGridView1ShowProduct = new DataGridView();
            buttonSearchProduct = new Button();
            textBoxProductId = new TextBox();
            label1 = new Label();
            ShowAllPanel = new Panel();
            buttonFilter = new Button();
            label2 = new Label();
            textBoxChoose = new TextBox();
            ShowAllDataGridView = new DataGridView();
            ShowOneItemBtn = new Button();
            AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowToDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            DeleteItemPanel.SuspendLayout();
            panelShowOneProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1ShowProduct).BeginInit();
            ShowAllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowAllDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(633, 49);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(202, 81);
            addBtn.TabIndex = 0;
            addBtn.Text = "הוספת מוצר";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(633, 151);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(202, 85);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "עדכון מוצר";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(633, 260);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(202, 84);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "מחיקת מוצר";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // ShowAllBtn
            // 
            ShowAllBtn.Location = new Point(633, 364);
            ShowAllBtn.Margin = new Padding(3, 4, 3, 4);
            ShowAllBtn.Name = "ShowAllBtn";
            ShowAllBtn.Size = new Size(202, 80);
            ShowAllBtn.TabIndex = 3;
            ShowAllBtn.Text = "הצג הכל";
            ShowAllBtn.UseVisualStyleBackColor = true;
            ShowAllBtn.Click += ShowAllBtn_Click;
            // 
            // AddPanel
            // 
            AddPanel.Controls.Add(dataGridViewShowToDelete);
            AddPanel.Controls.Add(UpdateItemBtn);
            AddPanel.Controls.Add(ChooseItemBtn);
            AddPanel.Controls.Add(dataGridViewProduct);
            AddPanel.Controls.Add(IdTxt);
            AddPanel.Controls.Add(CodeLbl);
            AddPanel.Controls.Add(ConfirmAddBtn);
            AddPanel.Controls.Add(quantityNumericUpDown);
            AddPanel.Controls.Add(PriceNumericUpDown);
            AddPanel.Controls.Add(quantityLbl);
            AddPanel.Controls.Add(priceLbl);
            AddPanel.Controls.Add(categoryLbl);
            AddPanel.Controls.Add(categoryCOmboBox);
            AddPanel.Controls.Add(nameLbl);
            AddPanel.Controls.Add(nameTxt);
            AddPanel.Location = new Point(32, 16);
            AddPanel.Margin = new Padding(3, 4, 3, 4);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(472, 563);
            AddPanel.TabIndex = 4;
            // 
            // dataGridViewShowToDelete
            // 
            dataGridViewShowToDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShowToDelete.Location = new Point(137, 167);
            dataGridViewShowToDelete.Margin = new Padding(3, 4, 3, 4);
            dataGridViewShowToDelete.Name = "dataGridViewShowToDelete";
            dataGridViewShowToDelete.RowHeadersWidth = 51;
            dataGridViewShowToDelete.RowTemplate.Height = 25;
            dataGridViewShowToDelete.Size = new Size(274, 200);
            dataGridViewShowToDelete.TabIndex = 1;
            dataGridViewShowToDelete.CellContentClick += dataGridViewShowToDelete_CellContentClick;
            // 
            // UpdateItemBtn
            // 
            UpdateItemBtn.Location = new Point(38, 455);
            UpdateItemBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateItemBtn.Name = "UpdateItemBtn";
            UpdateItemBtn.Size = new Size(86, 31);
            UpdateItemBtn.TabIndex = 14;
            UpdateItemBtn.Text = "לעדכון";
            UpdateItemBtn.UseVisualStyleBackColor = true;
            UpdateItemBtn.Click += UpdateItemBtn_Click;
            // 
            // ChooseItemBtn
            // 
            ChooseItemBtn.Location = new Point(126, 183);
            ChooseItemBtn.Margin = new Padding(3, 4, 3, 4);
            ChooseItemBtn.Name = "ChooseItemBtn";
            ChooseItemBtn.Size = new Size(86, 31);
            ChooseItemBtn.TabIndex = 13;
            ChooseItemBtn.Text = "בחר";
            ChooseItemBtn.UseVisualStyleBackColor = true;
            ChooseItemBtn.Click += ChooseItemBtn_Click;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(231, 39);
            dataGridViewProduct.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.Size = new Size(213, 183);
            dataGridViewProduct.TabIndex = 12;
            // 
            // IdTxt
            // 
            IdTxt.Location = new Point(231, 4);
            IdTxt.Margin = new Padding(3, 4, 3, 4);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(114, 27);
            IdTxt.TabIndex = 11;
            IdTxt.TextChanged += IdTxt_TextChanged;
            // 
            // CodeLbl
            // 
            CodeLbl.AutoSize = true;
            CodeLbl.Location = new Point(384, 15);
            CodeLbl.Name = "CodeLbl";
            CodeLbl.Size = new Size(30, 20);
            CodeLbl.TabIndex = 10;
            CodeLbl.Text = "קוד";
            // 
            // ConfirmAddBtn
            // 
            ConfirmAddBtn.Location = new Point(130, 455);
            ConfirmAddBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmAddBtn.Name = "ConfirmAddBtn";
            ConfirmAddBtn.Size = new Size(86, 31);
            ConfirmAddBtn.TabIndex = 9;
            ConfirmAddBtn.Text = "להוספה";
            ConfirmAddBtn.UseVisualStyleBackColor = true;
            ConfirmAddBtn.Click += ConfirmAddBtn_Click;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(209, 408);
            quantityNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(137, 27);
            quantityNumericUpDown.TabIndex = 7;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Location = new Point(210, 344);
            PriceNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            PriceNumericUpDown.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(137, 27);
            PriceNumericUpDown.TabIndex = 6;
            // 
            // quantityLbl
            // 
            quantityLbl.AutoSize = true;
            quantityLbl.Location = new Point(395, 413);
            quantityLbl.Name = "quantityLbl";
            quantityLbl.Size = new Size(42, 20);
            quantityLbl.TabIndex = 5;
            quantityLbl.Text = "כמות";
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(406, 347);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(41, 20);
            priceLbl.TabIndex = 4;
            priceLbl.Text = "מחיר";
            // 
            // categoryLbl
            // 
            categoryLbl.AutoSize = true;
            categoryLbl.Location = new Point(384, 284);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Size = new Size(62, 20);
            categoryLbl.TabIndex = 3;
            categoryLbl.Text = "קטגוריה";
            // 
            // categoryCOmboBox
            // 
            categoryCOmboBox.FormattingEnabled = true;
            categoryCOmboBox.Location = new Point(209, 280);
            categoryCOmboBox.Margin = new Padding(3, 4, 3, 4);
            categoryCOmboBox.Name = "categoryCOmboBox";
            categoryCOmboBox.Size = new Size(138, 28);
            categoryCOmboBox.TabIndex = 2;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(381, 233);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(66, 20);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "שם מוצר";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(232, 229);
            nameTxt.Margin = new Padding(3, 4, 3, 4);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(114, 27);
            nameTxt.TabIndex = 0;
            // 
            // DeleteItemPanel
            // 
            DeleteItemPanel.Controls.Add(DeleteItemBtn);
            DeleteItemPanel.Controls.Add(panelShowOneProduct);
            DeleteItemPanel.Location = new Point(35, 13);
            DeleteItemPanel.Margin = new Padding(3, 4, 3, 4);
            DeleteItemPanel.Name = "DeleteItemPanel";
            DeleteItemPanel.Size = new Size(469, 563);
            DeleteItemPanel.TabIndex = 15;
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
            // panelShowOneProduct
            // 
            panelShowOneProduct.Controls.Add(dataGridView1ShowProduct);
            panelShowOneProduct.Controls.Add(buttonSearchProduct);
            panelShowOneProduct.Controls.Add(textBoxProductId);
            panelShowOneProduct.Controls.Add(label1);
            panelShowOneProduct.Location = new Point(3, 7);
            panelShowOneProduct.Margin = new Padding(3, 4, 3, 4);
            panelShowOneProduct.Name = "panelShowOneProduct";
            panelShowOneProduct.Size = new Size(490, 563);
            panelShowOneProduct.TabIndex = 1;
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
            buttonSearchProduct.Text = "חפש מוצר";
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
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס קוד מוצר";
            // 
            // ShowAllPanel
            // 
            ShowAllPanel.Controls.Add(buttonFilter);
            ShowAllPanel.Controls.Add(label2);
            ShowAllPanel.Controls.Add(textBoxChoose);
            ShowAllPanel.Controls.Add(ShowAllDataGridView);
            ShowAllPanel.Location = new Point(32, 16);
            ShowAllPanel.Margin = new Padding(3, 4, 3, 4);
            ShowAllPanel.Name = "ShowAllPanel";
            ShowAllPanel.Size = new Size(386, 544);
            ShowAllPanel.TabIndex = 8;
            ShowAllPanel.Paint += ProductPanel_Paint;
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
            ShowAllDataGridView.Location = new Point(13, 24);
            ShowAllDataGridView.Margin = new Padding(3, 4, 3, 4);
            ShowAllDataGridView.Name = "ShowAllDataGridView";
            ShowAllDataGridView.RowHeadersWidth = 51;
            ShowAllDataGridView.RowTemplate.Height = 25;
            ShowAllDataGridView.Size = new Size(339, 277);
            ShowAllDataGridView.TabIndex = 0;
            ShowAllDataGridView.CellContentClick += ShowAllDataGridView_CellContentClick;
            // 
            // ShowOneItemBtn
            // 
            ShowOneItemBtn.Location = new Point(633, 461);
            ShowOneItemBtn.Margin = new Padding(3, 4, 3, 4);
            ShowOneItemBtn.Name = "ShowOneItemBtn";
            ShowOneItemBtn.Size = new Size(202, 80);
            ShowOneItemBtn.TabIndex = 9;
            ShowOneItemBtn.Text = "הצג מוצר בודד";
            ShowOneItemBtn.UseVisualStyleBackColor = true;
            ShowOneItemBtn.Click += ShowOneItemBtn_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(AddPanel);
            Controls.Add(DeleteItemPanel);
            Controls.Add(ShowOneItemBtn);
            Controls.Add(ShowAllPanel);
            Controls.Add(ShowAllBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerForm";
            Text = "ManagerForm";
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowToDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            DeleteItemPanel.ResumeLayout(false);
            panelShowOneProduct.ResumeLayout(false);
            panelShowOneProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1ShowProduct).EndInit();
            ShowAllPanel.ResumeLayout(false);
            ShowAllPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowAllDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button ShowAllBtn;
        private Panel AddPanel;
        private Label nameLbl;
        private TextBox nameTxt;
        private Label categoryLbl;
        private ComboBox categoryCOmboBox;
        private Label quantityLbl;
        private Label priceLbl;
        private Panel ShowAllPanel;
        private NumericUpDown quantityNumericUpDown;
        private NumericUpDown PriceNumericUpDown;
        private DataGridView ShowAllDataGridView;
        private Button ConfirmAddBtn;
        private Label CodeLbl;
        private TextBox IdTxt;
        private DataGridView dataGridViewProduct;
        private Button ChooseItemBtn;
        private Button UpdateItemBtn;
        private Panel DeleteItemPanel;
        private Button DeleteItemBtn;
        private Button ShowOneItemBtn;
        private Panel panelShowOneProduct;
        private TextBox textBoxProductId;
        private Label label1;
        private Button buttonSearchProduct;
        private DataGridView dataGridView1ShowProduct;
        private DataGridView dataGridViewShowToDelete;
        private Label label2;
        private TextBox textBoxChoose;
        private Button buttonFilter;
    }
}