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
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            button2 = new Button();
            label1 = new Label();
            labelSaleId = new Label();
            label9 = new Label();
            dataGridViewSale = new DataGridView();
            label8 = new Label();
            dataGridViewProduct = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            tabPayment = new TabPage();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button5 = new Button();
            label10 = new Label();
            comboBox1 = new ComboBox();
            tabControl.SuspendLayout();
            tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            tabPayment.SuspendLayout();
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
            tabControl.Appearance = TabAppearance.Buttons;
            tabControl.Controls.Add(tabClient);
            tabControl.Controls.Add(tabProduct);
            tabControl.Controls.Add(tabPayment);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(704, 681);
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
            tabClient.Size = new Size(696, 645);
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
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(48, 442);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 14;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(20, 569);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 13;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(10, 536);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 12;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(6, 504);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 11;
            label6.Text = "Endereço:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.Location = new Point(22, 471);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 10;
            label7.Text = "Nome:";
            // 
            // labelID
            // 
            labelID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelID.AutoSize = true;
            labelID.Location = new Point(81, 442);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 20);
            labelID.TabIndex = 9;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(81, 569);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 20);
            labelEmail.TabIndex = 8;
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(78, 536);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(0, 20);
            labelPhone.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(78, 504);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(0, 20);
            labelAddress.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelName.AutoSize = true;
            labelName.Location = new Point(78, 471);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 20);
            labelName.TabIndex = 5;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Location = new Point(255, 591);
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
            dataGridViewClient.Size = new Size(682, 348);
            dataGridViewClient.TabIndex = 2;
            dataGridViewClient.CellDoubleClick += dataGridViewClient_CellDoubleClick;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(10, 40);
            textBox2.MaximumSize = new Size(298, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 27);
            textBox2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(319, 40);
            button3.Name = "button3";
            button3.Size = new Size(85, 28);
            button3.TabIndex = 0;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabProduct
            // 
            tabProduct.Controls.Add(label21);
            tabProduct.Controls.Add(label22);
            tabProduct.Controls.Add(label23);
            tabProduct.Controls.Add(label24);
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
            tabProduct.Size = new Size(696, 645);
            tabProduct.TabIndex = 1;
            tabProduct.Text = "Produto";
            tabProduct.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(345, 514);
            label21.Name = "label21";
            label21.Size = new Size(122, 21);
            label21.TabIndex = 24;
            label21.Text = "                            ";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Bottom;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(216, 514);
            label22.Name = "label22";
            label22.Size = new Size(129, 21);
            label22.TabIndex = 23;
            label22.Text = "Número de Itens:";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Bottom;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(345, 552);
            label23.Name = "label23";
            label23.Size = new Size(98, 21);
            label23.TabIndex = 22;
            label23.Text = "                      ";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Bottom;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(260, 552);
            label24.Name = "label24";
            label24.Size = new Size(85, 21);
            label24.TabIndex = 21;
            label24.Text = "Valor Total:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Location = new Point(272, 596);
            button2.Name = "button2";
            button2.Size = new Size(149, 41);
            button2.TabIndex = 18;
            button2.Text = "Ir para Pagamento";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 324);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 17;
            label1.Text = "Produtos Selecionados";
            // 
            // labelSaleId
            // 
            labelSaleId.AutoSize = true;
            labelSaleId.Location = new Point(156, 13);
            labelSaleId.Name = "labelSaleId";
            labelSaleId.Size = new Size(121, 20);
            labelSaleId.TabIndex = 16;
            labelSaleId.Text = "                            ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 12);
            label9.Name = "label9";
            label9.Size = new Size(142, 21);
            label9.TabIndex = 15;
            label9.Text = "ID Venda(Cupom):";
            // 
            // dataGridViewSale
            // 
            dataGridViewSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSale.Location = new Point(3, 356);
            dataGridViewSale.MultiSelect = false;
            dataGridViewSale.Name = "dataGridViewSale";
            dataGridViewSale.ReadOnly = true;
            dataGridViewSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSale.Size = new Size(682, 143);
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
            dataGridViewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(6, 107);
            dataGridViewProduct.MultiSelect = false;
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new Size(682, 200);
            dataGridViewProduct.TabIndex = 9;
            dataGridViewProduct.CellDoubleClick += dataGridViewProduct_CellDoubleClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(488, 69);
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
            textBox1.MaximumSize = new Size(476, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 27);
            textBox1.TabIndex = 7;
            // 
            // tabPayment
            // 
            tabPayment.Controls.Add(label20);
            tabPayment.Controls.Add(label19);
            tabPayment.Controls.Add(label17);
            tabPayment.Controls.Add(label18);
            tabPayment.Controls.Add(label16);
            tabPayment.Controls.Add(label15);
            tabPayment.Controls.Add(label14);
            tabPayment.Controls.Add(label13);
            tabPayment.Controls.Add(label12);
            tabPayment.Controls.Add(label11);
            tabPayment.Controls.Add(button5);
            tabPayment.Controls.Add(label10);
            tabPayment.Controls.Add(comboBox1);
            tabPayment.Location = new Point(4, 32);
            tabPayment.Name = "tabPayment";
            tabPayment.Padding = new Padding(3);
            tabPayment.Size = new Size(696, 645);
            tabPayment.TabIndex = 2;
            tabPayment.Text = "Pagamento";
            tabPayment.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.Location = new Point(318, 229);
            label20.Name = "label20";
            label20.Size = new Size(122, 21);
            label20.TabIndex = 20;
            label20.Text = "                            ";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label19.Location = new Point(178, 229);
            label19.Name = "label19";
            label19.Size = new Size(137, 21);
            label19.TabIndex = 19;
            label19.Text = "Número de Itens:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Location = new Point(318, 68);
            label17.Name = "label17";
            label17.Size = new Size(121, 20);
            label17.TabIndex = 18;
            label17.Text = "                            ";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(170, 67);
            label18.Name = "label18";
            label18.Size = new Size(142, 21);
            label18.TabIndex = 17;
            label18.Text = "ID Venda(Cupom):";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(318, 180);
            label16.Name = "label16";
            label16.Size = new Size(122, 21);
            label16.TabIndex = 8;
            label16.Text = "                            ";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(238, 180);
            label15.Name = "label15";
            label15.Size = new Size(77, 21);
            label15.TabIndex = 7;
            label15.Text = "Endereço:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(318, 126);
            label14.Name = "label14";
            label14.Size = new Size(126, 21);
            label14.TabIndex = 6;
            label14.Text = "                             ";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(254, 126);
            label13.Name = "label13";
            label13.Size = new Size(61, 21);
            label13.TabIndex = 5;
            label13.Text = "Cliente:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(318, 271);
            label12.Name = "label12";
            label12.Size = new Size(98, 21);
            label12.TabIndex = 4;
            label12.Text = "                      ";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(195, 271);
            label11.Name = "label11";
            label11.Size = new Size(117, 21);
            label11.TabIndex = 3;
            label11.Text = "Valor Total:  R$";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.ForeColor = Color.Green;
            button5.Location = new Point(254, 435);
            button5.Name = "button5";
            button5.Size = new Size(186, 50);
            button5.TabIndex = 2;
            button5.Text = "Confirmar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(230, 353);
            label10.Name = "label10";
            label10.Size = new Size(231, 20);
            label10.TabIndex = 1;
            label10.Text = "Selecione a forma de pagamento";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Selecione", "Dinheiro", "Débito", "Credito", "Pix" });
            comboBox1.Location = new Point(254, 384);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            Text = "System - Nova venda";
            Load += FrmSaleItem_Load;
            tabControl.ResumeLayout(false);
            tabClient.ResumeLayout(false);
            tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            tabProduct.ResumeLayout(false);
            tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            tabPayment.ResumeLayout(false);
            tabPayment.PerformLayout();
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
        private TabPage tabPayment;
        private Button button5;
        private Label label10;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Label label17;
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label20;
        private Label label19;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
    }
}