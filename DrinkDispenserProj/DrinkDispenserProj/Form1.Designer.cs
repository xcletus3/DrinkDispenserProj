
namespace DrinkDispenserProj
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
        public void InitializeComponent()
        {
            this.checkBoxApp = new System.Windows.Forms.CheckBox();
            this.checkBoxOrng = new System.Windows.Forms.CheckBox();
            this.checkBoxGuav = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGuav = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOrng = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownApp = new System.Windows.Forms.NumericUpDown();
            this.orderlbl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderTotallbl = new System.Windows.Forms.Label();
            this.orderlbl3 = new System.Windows.Forms.Label();
            this.orderlbl2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.amountlbl = new System.Windows.Forms.Label();
            this.paybutton = new System.Windows.Forms.Button();
            this.butnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownApp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxApp
            // 
            this.checkBoxApp.AutoSize = true;
            this.checkBoxApp.Location = new System.Drawing.Point(24, 23);
            this.checkBoxApp.Name = "checkBoxApp";
            this.checkBoxApp.Size = new System.Drawing.Size(142, 17);
            this.checkBoxApp.TabIndex = 0;
            this.checkBoxApp.Text = "Apple Juice         Rs.150";
            this.checkBoxApp.UseVisualStyleBackColor = true;
            this.checkBoxApp.CheckedChanged += new System.EventHandler(this.checkBoxApp_CheckedChanged);
            // 
            // checkBoxOrng
            // 
            this.checkBoxOrng.AutoSize = true;
            this.checkBoxOrng.Location = new System.Drawing.Point(24, 46);
            this.checkBoxOrng.Name = "checkBoxOrng";
            this.checkBoxOrng.Size = new System.Drawing.Size(141, 17);
            this.checkBoxOrng.TabIndex = 0;
            this.checkBoxOrng.Text = "Orange Juice      Rs.120";
            this.checkBoxOrng.UseVisualStyleBackColor = true;
            this.checkBoxOrng.CheckedChanged += new System.EventHandler(this.checkBoxOrng_CheckedChanged);
            // 
            // checkBoxGuav
            // 
            this.checkBoxGuav.AutoSize = true;
            this.checkBoxGuav.Location = new System.Drawing.Point(24, 69);
            this.checkBoxGuav.Name = "checkBoxGuav";
            this.checkBoxGuav.Size = new System.Drawing.Size(141, 17);
            this.checkBoxGuav.TabIndex = 0;
            this.checkBoxGuav.Text = "Guava Juice       Rs.100";
            this.checkBoxGuav.UseVisualStyleBackColor = true;
            this.checkBoxGuav.CheckedChanged += new System.EventHandler(this.checkBoxGuav_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownGuav);
            this.groupBox1.Controls.Add(this.numericUpDownOrng);
            this.groupBox1.Controls.Add(this.numericUpDownApp);
            this.groupBox1.Controls.Add(this.checkBoxApp);
            this.groupBox1.Controls.Add(this.checkBoxGuav);
            this.groupBox1.Controls.Add(this.checkBoxOrng);
            this.groupBox1.Location = new System.Drawing.Point(31, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Juices";
            // 
            // numericUpDownGuav
            // 
            this.numericUpDownGuav.Enabled = false;
            this.numericUpDownGuav.Location = new System.Drawing.Point(172, 66);
            this.numericUpDownGuav.Name = "numericUpDownGuav";
            this.numericUpDownGuav.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownGuav.TabIndex = 1;
            // 
            // numericUpDownOrng
            // 
            this.numericUpDownOrng.Enabled = false;
            this.numericUpDownOrng.Location = new System.Drawing.Point(172, 43);
            this.numericUpDownOrng.Name = "numericUpDownOrng";
            this.numericUpDownOrng.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownOrng.TabIndex = 1;
            // 
            // numericUpDownApp
            // 
            this.numericUpDownApp.Enabled = false;
            this.numericUpDownApp.Location = new System.Drawing.Point(172, 20);
            this.numericUpDownApp.Name = "numericUpDownApp";
            this.numericUpDownApp.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownApp.TabIndex = 1;
            // 
            // orderlbl1
            // 
            this.orderlbl1.AutoSize = true;
            this.orderlbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlbl1.Location = new System.Drawing.Point(38, 23);
            this.orderlbl1.Name = "orderlbl1";
            this.orderlbl1.Size = new System.Drawing.Size(0, 17);
            this.orderlbl1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.orderTotallbl);
            this.groupBox2.Controls.Add(this.orderlbl3);
            this.groupBox2.Controls.Add(this.orderlbl2);
            this.groupBox2.Controls.Add(this.orderlbl1);
            this.groupBox2.Location = new System.Drawing.Point(343, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Order";
            // 
            // orderTotallbl
            // 
            this.orderTotallbl.AutoSize = true;
            this.orderTotallbl.Location = new System.Drawing.Point(38, 102);
            this.orderTotallbl.Name = "orderTotallbl";
            this.orderTotallbl.Size = new System.Drawing.Size(0, 13);
            this.orderTotallbl.TabIndex = 3;
            // 
            // orderlbl3
            // 
            this.orderlbl3.AutoSize = true;
            this.orderlbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlbl3.Location = new System.Drawing.Point(38, 68);
            this.orderlbl3.Name = "orderlbl3";
            this.orderlbl3.Size = new System.Drawing.Size(0, 17);
            this.orderlbl3.TabIndex = 2;
            // 
            // orderlbl2
            // 
            this.orderlbl2.AutoSize = true;
            this.orderlbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlbl2.Location = new System.Drawing.Point(38, 45);
            this.orderlbl2.Name = "orderlbl2";
            this.orderlbl2.Size = new System.Drawing.Size(0, 17);
            this.orderlbl2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pay:";
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(102, 170);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(94, 20);
            this.txtbxAmount.TabIndex = 4;
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Location = new System.Drawing.Point(105, 142);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(0, 13);
            this.amountlbl.TabIndex = 5;
            // 
            // paybutton
            // 
            this.paybutton.Location = new System.Drawing.Point(219, 168);
            this.paybutton.Name = "paybutton";
            this.paybutton.Size = new System.Drawing.Size(75, 23);
            this.paybutton.TabIndex = 6;
            this.paybutton.Text = "Pay";
            this.paybutton.UseVisualStyleBackColor = true;
            this.paybutton.Click += new System.EventHandler(this.paybutton_Click);
            // 
            // butnReset
            // 
            this.butnReset.Location = new System.Drawing.Point(467, 167);
            this.butnReset.Name = "butnReset";
            this.butnReset.Size = new System.Drawing.Size(75, 23);
            this.butnReset.TabIndex = 7;
            this.butnReset.Text = "Reset";
            this.butnReset.UseVisualStyleBackColor = true;
            this.butnReset.Click += new System.EventHandler(this.butnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 230);
            this.Controls.Add(this.butnReset);
            this.Controls.Add(this.paybutton);
            this.Controls.Add(this.amountlbl);
            this.Controls.Add(this.txtbxAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Drink Dispenser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownApp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxApp;
        private System.Windows.Forms.CheckBox checkBoxOrng;
        private System.Windows.Forms.CheckBox checkBoxGuav;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label orderlbl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.Label orderlbl3;
        private System.Windows.Forms.Label orderlbl2;
        private System.Windows.Forms.Label orderTotallbl;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Button paybutton;
        private System.Windows.Forms.Button butnReset;
        private System.Windows.Forms.NumericUpDown numericUpDownGuav;
        private System.Windows.Forms.NumericUpDown numericUpDownOrng;
        private System.Windows.Forms.NumericUpDown numericUpDownApp;
    }
}

