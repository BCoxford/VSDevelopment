namespace ui
{
    partial class Form1
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
            this.label = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.orderList = new System.Windows.Forms.ListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startDateInput = new System.Windows.Forms.DateTimePicker();
            this.endDateInput = new System.Windows.Forms.DateTimePicker();
            this.searchByDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.depositLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.customerTelephoneLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.branchNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(198, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Customer Order Search";
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(11, 201);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(125, 20);
            this.userInput.TabIndex = 2;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(164, 59);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(95, 134);
            this.orderList.TabIndex = 3;
            this.orderList.Click += new System.EventHandler(this.orderList_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(11, 228);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(32, 13);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "Error:";
            this.errorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search By Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filter By Date";
            // 
            // startDateInput
            // 
            this.startDateInput.Location = new System.Drawing.Point(12, 77);
            this.startDateInput.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.startDateInput.Name = "startDateInput";
            this.startDateInput.Size = new System.Drawing.Size(124, 20);
            this.startDateInput.TabIndex = 13;
            this.startDateInput.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // endDateInput
            // 
            this.endDateInput.Location = new System.Drawing.Point(12, 127);
            this.endDateInput.Name = "endDateInput";
            this.endDateInput.Size = new System.Drawing.Size(124, 20);
            this.endDateInput.TabIndex = 14;
            // 
            // searchByDate
            // 
            this.searchByDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchByDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchByDate.FlatAppearance.BorderSize = 0;
            this.searchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchByDate.Location = new System.Drawing.Point(12, 153);
            this.searchByDate.Name = "searchByDate";
            this.searchByDate.Size = new System.Drawing.Size(124, 20);
            this.searchByDate.TabIndex = 17;
            this.searchByDate.Text = "Search by Date";
            this.searchByDate.UseVisualStyleBackColor = false;
            this.searchByDate.Click += new System.EventHandler(this.searchByDate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.depositLabel);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.customerTelephoneLabel);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.postcodeLabel);
            this.panel1.Controls.Add(this.branchNameLabel);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.customerNameLabel);
            this.panel1.Controls.Add(this.customerNumberLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.salePriceLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.orderDateLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.orderNumberLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(284, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 237);
            this.panel1.TabIndex = 18;
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(184, 168);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.depositLabel.Size = new System.Drawing.Size(0, 20);
            this.depositLabel.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(184, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 16);
            this.label22.TabIndex = 38;
            this.label22.Text = "Deposit";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 112);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(131, 16);
            this.label21.TabIndex = 37;
            this.label21.Text = "Customer Number";
            // 
            // customerTelephoneLabel
            // 
            this.customerTelephoneLabel.AutoSize = true;
            this.customerTelephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTelephoneLabel.Location = new System.Drawing.Point(8, 208);
            this.customerTelephoneLabel.Name = "customerTelephoneLabel";
            this.customerTelephoneLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customerTelephoneLabel.Size = new System.Drawing.Size(0, 20);
            this.customerTelephoneLabel.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 152);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "Name";
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postcodeLabel.Location = new System.Drawing.Point(184, 48);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.postcodeLabel.Size = new System.Drawing.Size(0, 20);
            this.postcodeLabel.TabIndex = 34;
            this.postcodeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // branchNameLabel
            // 
            this.branchNameLabel.AutoSize = true;
            this.branchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameLabel.Location = new System.Drawing.Point(184, 24);
            this.branchNameLabel.Name = "branchNameLabel";
            this.branchNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.branchNameLabel.Size = new System.Drawing.Size(0, 20);
            this.branchNameLabel.TabIndex = 33;
            this.branchNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(184, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Branch";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(8, 168);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customerNameLabel.Size = new System.Drawing.Size(0, 20);
            this.customerNameLabel.TabIndex = 31;
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumberLabel.Location = new System.Drawing.Point(8, 128);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.customerNumberLabel.Size = new System.Drawing.Size(0, 20);
            this.customerNumberLabel.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 192);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(141, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Telephone Number";
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.AutoSize = true;
            this.salePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePriceLabel.Location = new System.Drawing.Point(184, 128);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.salePriceLabel.Size = new System.Drawing.Size(0, 20);
            this.salePriceLabel.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Sale Price";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLabel.Location = new System.Drawing.Point(8, 64);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.orderDateLabel.Size = new System.Drawing.Size(0, 20);
            this.orderDateLabel.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Order Date";
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberLabel.Location = new System.Drawing.Point(8, 24);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.orderNumberLabel.Size = new System.Drawing.Size(0, 20);
            this.orderNumberLabel.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Order Number";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Location = new System.Drawing.Point(164, 200);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 20);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Search All";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(563, 254);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchByDate);
            this.Controls.Add(this.endDateInput);
            this.Controls.Add(this.startDateInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDateInput;
        private System.Windows.Forms.DateTimePicker endDateInput;
        private System.Windows.Forms.Button searchByDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label customerTelephoneLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label postcodeLabel;
        private System.Windows.Forms.Label branchNameLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

