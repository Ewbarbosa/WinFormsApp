namespace WinFormsApp.View {
    partial class FrmCRUDProduct {
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
            labelTitle = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textStock = new TextBox();
            textPrice = new TextBox();
            textBrand = new TextBox();
            textDescription = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(226, 48);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(141, 25);
            labelTitle.TabIndex = 19;
            labelTitle.Text = "Novo Produto";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(209, 347);
            button1.Name = "button1";
            button1.Size = new Size(219, 32);
            button1.TabIndex = 18;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(151, 238);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 17;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(135, 292);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 16;
            label3.Text = "Estoque:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(150, 191);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 15;
            label2.Text = "Marca:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(126, 128);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 14;
            label1.Text = "Descrição:";
            // 
            // textStock
            // 
            textStock.Anchor = AnchorStyles.None;
            textStock.Font = new Font("Segoe UI", 11.25F);
            textStock.Location = new Point(209, 289);
            textStock.Name = "textStock";
            textStock.Size = new Size(219, 27);
            textStock.TabIndex = 13;
            textStock.KeyPress += textStock_KeyPress;
            // 
            // textPrice
            // 
            textPrice.Anchor = AnchorStyles.None;
            textPrice.Font = new Font("Segoe UI", 11.25F);
            textPrice.Location = new Point(209, 235);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(219, 27);
            textPrice.TabIndex = 12;
            textPrice.KeyPress += textPrice_KeyPress;
            // 
            // textBrand
            // 
            textBrand.Anchor = AnchorStyles.None;
            textBrand.Font = new Font("Segoe UI", 11.25F);
            textBrand.Location = new Point(209, 184);
            textBrand.Name = "textBrand";
            textBrand.Size = new Size(219, 27);
            textBrand.TabIndex = 11;
            // 
            // textDescription
            // 
            textDescription.Anchor = AnchorStyles.None;
            textDescription.Font = new Font("Segoe UI", 11.25F);
            textDescription.Location = new Point(209, 125);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(219, 27);
            textDescription.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(209, 396);
            button2.Name = "button2";
            button2.Size = new Size(219, 36);
            button2.TabIndex = 20;
            button2.Text = "Apagar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmCRUDProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(button2);
            Controls.Add(labelTitle);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textStock);
            Controls.Add(textPrice);
            Controls.Add(textBrand);
            Controls.Add(textDescription);
            Name = "FrmCRUDProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "System - Novo Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textStock;
        private TextBox textPrice;
        private TextBox textBrand;
        private TextBox textDescription;
        private Button button2;
    }
}