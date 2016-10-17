namespace Prodavnica
{
    partial class ShopForm
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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.pdvLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.NameWarning = new System.Windows.Forms.Label();
            this.QuantityWarning = new System.Windows.Forms.Label();
            this.PriceWarning = new System.Windows.Forms.Label();
            this.kmLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kmLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(12, 12);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(283, 342);
            this.itemsListBox.TabIndex = 0;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.shopListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PDV";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(478, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "label1";
            this.NameLabel.Visible = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(478, 41);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "label2";
            this.PriceLabel.Visible = false;
            // 
            // pdvLabel
            // 
            this.pdvLabel.AutoSize = true;
            this.pdvLabel.Location = new System.Drawing.Point(481, 72);
            this.pdvLabel.Name = "pdvLabel";
            this.pdvLabel.Size = new System.Drawing.Size(35, 13);
            this.pdvLabel.TabIndex = 6;
            this.pdvLabel.Text = "label3";
            this.pdvLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Novi artikal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naziv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kolicina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cijena";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(449, 169);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(449, 207);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 12;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(449, 246);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 13;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(441, 316);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "Unesi";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // NameWarning
            // 
            this.NameWarning.AutoSize = true;
            this.NameWarning.ForeColor = System.Drawing.Color.Red;
            this.NameWarning.Location = new System.Drawing.Point(453, 192);
            this.NameWarning.Name = "NameWarning";
            this.NameWarning.Size = new System.Drawing.Size(100, 13);
            this.NameWarning.TabIndex = 15;
            this.NameWarning.Text = "Ne moze biti prazno";
            this.NameWarning.Visible = false;
            // 
            // QuantityWarning
            // 
            this.QuantityWarning.AutoSize = true;
            this.QuantityWarning.ForeColor = System.Drawing.Color.Red;
            this.QuantityWarning.Location = new System.Drawing.Point(453, 230);
            this.QuantityWarning.Name = "QuantityWarning";
            this.QuantityWarning.Size = new System.Drawing.Size(100, 13);
            this.QuantityWarning.TabIndex = 16;
            this.QuantityWarning.Text = "Ne moze biti prazno";
            this.QuantityWarning.Visible = false;
            // 
            // PriceWarning
            // 
            this.PriceWarning.AutoSize = true;
            this.PriceWarning.ForeColor = System.Drawing.Color.Red;
            this.PriceWarning.Location = new System.Drawing.Point(453, 269);
            this.PriceWarning.Name = "PriceWarning";
            this.PriceWarning.Size = new System.Drawing.Size(100, 13);
            this.PriceWarning.TabIndex = 17;
            this.PriceWarning.Text = "Ne moze biti prazno";
            this.PriceWarning.Visible = false;
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(526, 41);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(23, 13);
            this.kmLabel.TabIndex = 18;
            this.kmLabel.Text = "KM";
            this.kmLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "KM";
            // 
            // kmLabel1
            // 
            this.kmLabel1.AutoSize = true;
            this.kmLabel1.Location = new System.Drawing.Point(526, 72);
            this.kmLabel1.Name = "kmLabel1";
            this.kmLabel1.Size = new System.Drawing.Size(23, 13);
            this.kmLabel1.TabIndex = 20;
            this.kmLabel1.Text = "KM";
            this.kmLabel1.Visible = false;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 379);
            this.Controls.Add(this.kmLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.PriceWarning);
            this.Controls.Add(this.QuantityWarning);
            this.Controls.Add(this.NameWarning);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pdvLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsListBox);
            this.Name = "ShopForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopForm_FormClosing);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label pdvLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label NameWarning;
        private System.Windows.Forms.Label QuantityWarning;
        private System.Windows.Forms.Label PriceWarning;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label kmLabel1;
    }
}

