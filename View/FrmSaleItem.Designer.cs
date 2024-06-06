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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textQuantity = new TextBox();
            button2 = new Button();
            label1 = new Label();
            labelDescription = new Label();
            labelPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F);
            textBox1.Location = new Point(12, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(300, 58);
            button1.Name = "button1";
            button1.Size = new Size(83, 28);
            button1.TabIndex = 2;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 104);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(560, 253);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // textQuantity
            // 
            textQuantity.Anchor = AnchorStyles.Bottom;
            textQuantity.Font = new Font("Segoe UI", 11.25F);
            textQuantity.Location = new Point(264, 492);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(100, 27);
            textQuantity.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(370, 492);
            button2.Name = "button2";
            button2.Size = new Size(83, 27);
            button2.TabIndex = 5;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 495);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 6;
            label1.Text = "Digite a quantidade:";
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
            // FrmSaleItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textQuantity);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "FrmSaleItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSaleItem";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textQuantity;
        private Button button2;
        private Label label1;
        private Label labelDescription;
        private Label labelPrice;
    }
}