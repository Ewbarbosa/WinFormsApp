namespace WinFormsApp.View {
    partial class FrmSaleItem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelDescription = new Label();
            labelPrice = new Label();
            tabControl = new TabControl();
            tabClient = new TabPage();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelID = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            labelName = new Label();
            button4 = new Button();
            dataGridViewClient = new DataGridView();
            textBox2 = new TextBox();
            button3 = new Button();
            tabProduct = new TabPage();
            labelSaleId = new Label();
            label9 = new Label();
            dataGridViewSale = new DataGridView();
            label8 = new Label();
            dataGridViewProduct = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            tabControl.SuspendLayout();
            tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 11.25F);
            labelDescription.Location = new Point(22, 383);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(0, 20);
            labelDescription.TabIndex = 7;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 11.25F);
            labelPrice.Location = new Point(22, 418);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 20);
            labelPrice.TabIndex = 8;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabClient);
            tabControl.Controls.Add(tabProduct);
            tabControl.Dock = DockStyle.Top;
            tabControl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(704, 669);
            tabControl.TabIndex = 9;
            // 
            // tabClient
            // 
            tabClient.Controls.Add(label2);
            tabClient.Controls.Add(label3);
            tabClient.Controls.Add(label4);
            tabClient.Controls.Add(label5);
            tabClient.Controls.Add(label6);
            tabClient.Controls.Add(label7);
            tabClient.Controls.Add(labelID);
            tabClient.Controls.Add(labelEmail);
            tabClient.Controls.Add(labelPhone);
            tabClient.Controls.Add(labelAddress);
            tabClient.Controls.Add(labelName);
            tabClient.Controls.Add(button4);
            tabClient.Controls.Add(dataGridViewClient);
            tabClient.Controls.Add(textBox2);
            tabClient.Controls.Add(button3);
            tabClient.Location = new Point(4, 32);
            tabClient.Name = "tabClient";
            tabClient.Padding = new Padding(3);
            tabClient.Size = new Size(696, 633);
            tabClient.TabIndex = 0;
            tabClient.Text = "Cliente";
            tabClient.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 12);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 15;
            label2.Text = "Selecione o Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(48, 416);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 14;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(20, 543);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 13;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(10, 510);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 12;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(6, 478);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 11;
            label6.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.Location = new Point(22, 445);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 10;
            label7.Text = "Nome:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(81, 416);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 20);
            labelID.TabIndex = 9;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(81, 543);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 20);
            labelEmail.TabIndex = 8;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(78, 510);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(0, 20);
            labelPhone.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(78, 478);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(0, 20);
            labelAddress.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(78, 445);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 20);
            labelName.TabIndex = 5;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Location = new Point(259, 590);
            button4.Name = "button4";
            button4.Size = new Size(213, 37);
            button4.TabIndex = 4;
            button4.Text = "Avançar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Location = new Point(8, 74);
            dataGridViewClient.MultiSelect = false;
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.ReadOnly = true;
            dataGridViewClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClient.Size = new Size(680, 322);
            dataGridViewClient.TabIndex = 2;
            dataGridViewClient.CellDoubleClick += dataGridViewClient_CellDoubleClick;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(10, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(524, 27);
            textBox2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(540, 40);
            button3.Name = "button3";
            button3.Size = new Size(89, 28);
            button3.TabIndex = 0;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabProduct
            // 
            tabProduct.Controls.Add(button2);
            tabProduct.Controls.Add(label1);
            tabProduct.Controls.Add(labelSaleId);
            tabProduct.Controls.Add(label9);
            tabProduct.Controls.Add(dataGridViewSale);
            tabProduct.Controls.Add(label8);
            tabProduct.Controls.Add(dataGridViewProduct);
            tabProduct.Controls.Add(button1);
            tabProduct.Controls.Add(textBox1);
            tabProduct.Location = new Point(4, 32);
            tabProduct.Name = "tabProduct";
            tabProduct.Padding = new Padding(3);
            tabProduct.Size = new Size(696, 633);
            tabProduct.TabIndex = 1;
            tabProduct.Text = "Produto";
            tabProduct.UseVisualStyleBackColor = true;
            // 
            // labelSaleId
            // 
            labelSaleId.AutoSize = true;
            labelSaleId.Location = new Point(93, 7);
            labelSaleId.Name = "labelSaleId";
            labelSaleId.Size = new Size(121, 20);
            labelSaleId.TabIndex = 16;
            labelSaleId.Text = "                            ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 7);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 15;
            label9.Text = "ID Venda:";
            // 
            // dataGridViewSale
            // 
            dataGridViewSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSale.Location = new Point(3, 376);
            dataGridViewSale.MultiSelect = false;
            dataGridViewSale.Name = "dataGridViewSale";
            dataGridViewSale.ReadOnly = true;
            dataGridViewSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSale.Size = new Size(682, 185);
            dataGridViewSale.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 46);
            label8.Name = "label8";
            label8.Size = new Size(159, 20);
            label8.TabIndex = 13;
            label8.Text = "Selecione os Produtos";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(6, 107);
            dataGridViewProduct.MultiSelect = false;
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new Size(682, 180);
            dataGridViewProduct.TabIndex = 9;
            dataGridViewProduct.CellDoubleClick += dataGridViewProduct_CellDoubleClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(498, 69);
            button1.Name = "button1";
            button1.Size = new Size(83, 27);
            button1.TabIndex = 8;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 11.25F);
            textBox1.Location = new Point(6, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 27);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 351);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 17;
            label1.Text = "Produtos Selecionados";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.Location = new Point(284, 584);
            button2.Name = "button2";
            button2.Size = new Size(153, 30);
            button2.TabIndex = 18;
            button2.Text = "Ir para Pagemento";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmSaleItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 681);
            Controls.Add(tabControl);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Name = "FrmSaleItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSaleItem";
            Load += FrmSaleItem_Load;
            tabControl.ResumeLayout(false);
            tabClient.ResumeLayout(false);
            tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            tabProduct.ResumeLayout(false);
            tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelDescription;
        private Label labelPrice;
        private TabControl tabControl;
        private TabPage tabClient;
        private TabPage tabProduct;
        private TextBox textBox2;
        private Button button3;
        private DataGridView dataGridViewProduct;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridViewClient;
        private Button button4;
        private Label labelPhone;
        private Label labelAddress;
        private Label labelName;
        private Label labelEmail;
        private Label labelID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label8;
        private DataGridView dataGridViewSale;
        private Label labelSaleId;
        private Label label9;
        private Button button2;
        private Label label1;
    }
}