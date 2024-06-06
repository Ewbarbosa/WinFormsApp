namespace WinFormsApp.View {
    partial class FrmCRUDClient {
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
            textName = new TextBox();
            textPhone = new TextBox();
            textAddress = new TextBox();
            textEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            labelTitle = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.None;
            textName.Font = new Font("Segoe UI", 11.25F);
            textName.Location = new Point(180, 109);
            textName.Margin = new Padding(3, 4, 3, 4);
            textName.Name = "textName";
            textName.Size = new Size(250, 27);
            textName.TabIndex = 0;
            // 
            // textPhone
            // 
            textPhone.Anchor = AnchorStyles.None;
            textPhone.Font = new Font("Segoe UI", 11.25F);
            textPhone.Location = new Point(180, 171);
            textPhone.Margin = new Padding(3, 4, 3, 4);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(250, 27);
            textPhone.TabIndex = 1;
            // 
            // textAddress
            // 
            textAddress.Anchor = AnchorStyles.None;
            textAddress.Font = new Font("Segoe UI", 11.25F);
            textAddress.Location = new Point(180, 235);
            textAddress.Margin = new Padding(3, 4, 3, 4);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(250, 27);
            textAddress.TabIndex = 2;
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.None;
            textEmail.Font = new Font("Segoe UI", 11.25F);
            textEmail.Location = new Point(180, 297);
            textEmail.Margin = new Padding(3, 4, 3, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(250, 27);
            textEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(116, 118);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(98, 181);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(114, 306);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(92, 241);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Endereço:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(180, 362);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(250, 43);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(233, 39);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(127, 25);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "Novo Cliente";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(180, 436);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(250, 43);
            button2.TabIndex = 10;
            button2.Text = "Apagar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmCRUDClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(button2);
            Controls.Add(labelTitle);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textEmail);
            Controls.Add(textAddress);
            Controls.Add(textPhone);
            Controls.Add(textName);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCRUDClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "System - Novo Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textPhone;
        private TextBox textAddress;
        private TextBox textEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label labelTitle;
        private Button button2;
    }
}