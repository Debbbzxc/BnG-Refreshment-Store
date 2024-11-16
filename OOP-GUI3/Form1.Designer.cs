namespace OOP_GUI3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbIcedCapuccino = new System.Windows.Forms.RadioButton();
            this.rbIcedLatte = new System.Windows.Forms.RadioButton();
            this.rbLatte = new System.Windows.Forms.RadioButton();
            this.rbEspresso = new System.Windows.Forms.RadioButton();
            this.rbCapuccino = new System.Windows.Forms.RadioButton();
            this.txtItemAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearForNextItem = new System.Windows.Forms.Button();
            this.btnCalculateSelection = new System.Windows.Forms.Button();
            this.cbTakeout = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtItemAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClearForNextItem);
            this.groupBox1.Controls.Add(this.btnCalculateSelection);
            this.groupBox1.Controls.Add(this.cbTakeout);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbIcedCapuccino);
            this.groupBox2.Controls.Add(this.rbIcedLatte);
            this.groupBox2.Controls.Add(this.rbLatte);
            this.groupBox2.Controls.Add(this.rbEspresso);
            this.groupBox2.Controls.Add(this.rbCapuccino);
            this.groupBox2.Location = new System.Drawing.Point(318, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 139);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coffee Selections";
            // 
            // rbIcedCapuccino
            // 
            this.rbIcedCapuccino.AutoSize = true;
            this.rbIcedCapuccino.Location = new System.Drawing.Point(22, 112);
            this.rbIcedCapuccino.Name = "rbIcedCapuccino";
            this.rbIcedCapuccino.Size = new System.Drawing.Size(100, 17);
            this.rbIcedCapuccino.TabIndex = 4;
            this.rbIcedCapuccino.TabStop = true;
            this.rbIcedCapuccino.Text = "Iced Capuccino";
            this.rbIcedCapuccino.UseVisualStyleBackColor = true;
            // 
            // rbIcedLatte
            // 
            this.rbIcedLatte.AutoSize = true;
            this.rbIcedLatte.Location = new System.Drawing.Point(22, 89);
            this.rbIcedLatte.Name = "rbIcedLatte";
            this.rbIcedLatte.Size = new System.Drawing.Size(73, 17);
            this.rbIcedLatte.TabIndex = 3;
            this.rbIcedLatte.TabStop = true;
            this.rbIcedLatte.Text = "Iced Latte";
            this.rbIcedLatte.UseVisualStyleBackColor = true;
            // 
            // rbLatte
            // 
            this.rbLatte.AutoSize = true;
            this.rbLatte.Location = new System.Drawing.Point(22, 66);
            this.rbLatte.Name = "rbLatte";
            this.rbLatte.Size = new System.Drawing.Size(49, 17);
            this.rbLatte.TabIndex = 2;
            this.rbLatte.TabStop = true;
            this.rbLatte.Text = "Latte";
            this.rbLatte.UseVisualStyleBackColor = true;
            // 
            // rbEspresso
            // 
            this.rbEspresso.AutoSize = true;
            this.rbEspresso.Location = new System.Drawing.Point(22, 43);
            this.rbEspresso.Name = "rbEspresso";
            this.rbEspresso.Size = new System.Drawing.Size(68, 17);
            this.rbEspresso.TabIndex = 1;
            this.rbEspresso.TabStop = true;
            this.rbEspresso.Text = "Espresso";
            this.rbEspresso.UseVisualStyleBackColor = true;
            // 
            // rbCapuccino
            // 
            this.rbCapuccino.AutoSize = true;
            this.rbCapuccino.Location = new System.Drawing.Point(22, 20);
            this.rbCapuccino.Name = "rbCapuccino";
            this.rbCapuccino.Size = new System.Drawing.Size(76, 17);
            this.rbCapuccino.TabIndex = 0;
            this.rbCapuccino.TabStop = true;
            this.rbCapuccino.Text = "Capuccino";
            this.rbCapuccino.UseVisualStyleBackColor = true;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Location = new System.Drawing.Point(123, 152);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.ReadOnly = true;
            this.txtItemAmount.Size = new System.Drawing.Size(87, 20);
            this.txtItemAmount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Amount";
            // 
            // btnClearForNextItem
            // 
            this.btnClearForNextItem.Location = new System.Drawing.Point(123, 98);
            this.btnClearForNextItem.Name = "btnClearForNextItem";
            this.btnClearForNextItem.Size = new System.Drawing.Size(87, 44);
            this.btnClearForNextItem.TabIndex = 4;
            this.btnClearForNextItem.Text = "Clear for Next Item";
            this.btnClearForNextItem.UseVisualStyleBackColor = true;
            this.btnClearForNextItem.Click += new System.EventHandler(this.btnClearForNextItem_Click);
            // 
            // btnCalculateSelection
            // 
            this.btnCalculateSelection.Location = new System.Drawing.Point(30, 98);
            this.btnCalculateSelection.Name = "btnCalculateSelection";
            this.btnCalculateSelection.Size = new System.Drawing.Size(87, 44);
            this.btnCalculateSelection.TabIndex = 3;
            this.btnCalculateSelection.Text = "Calculate Selection";
            this.btnCalculateSelection.UseVisualStyleBackColor = true;
            this.btnCalculateSelection.Click += new System.EventHandler(this.btnCalculateSelection_Click);
            // 
            // cbTakeout
            // 
            this.cbTakeout.AutoSize = true;
            this.cbTakeout.Location = new System.Drawing.Point(33, 65);
            this.cbTakeout.Name = "cbTakeout";
            this.cbTakeout.Size = new System.Drawing.Size(72, 17);
            this.cbTakeout.TabIndex = 2;
            this.cbTakeout.Text = "Takeout?";
            this.cbTakeout.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(82, 30);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(35, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalDue);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 124);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Location = new System.Drawing.Point(123, 82);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.ReadOnly = true;
            this.txtTotalDue.Size = new System.Drawing.Size(126, 20);
            this.txtTotalDue.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Due";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(123, 53);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(126, 20);
            this.txtTax.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tax (if Takeout)";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(123, 25);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(126, 20);
            this.txtSubtotal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subtotal";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(188, 350);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(116, 40);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(310, 350);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(116, 40);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(432, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 398);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BnG Refreshment Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbIcedCapuccino;
        private System.Windows.Forms.RadioButton rbIcedLatte;
        private System.Windows.Forms.RadioButton rbLatte;
        private System.Windows.Forms.RadioButton rbEspresso;
        private System.Windows.Forms.RadioButton rbCapuccino;
        private System.Windows.Forms.TextBox txtItemAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearForNextItem;
        private System.Windows.Forms.Button btnCalculateSelection;
        private System.Windows.Forms.CheckBox cbTakeout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnExit;
    }
}

