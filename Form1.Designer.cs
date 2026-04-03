namespace FormPizza
{
    partial class Form
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
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioButtonL = new System.Windows.Forms.RadioButton();
            this.radioButtonMe = new System.Windows.Forms.RadioButton();
            this.radioButtonSm = new System.Windows.Forms.RadioButton();
            this.groupBoxCrustType = new System.Windows.Forms.GroupBox();
            this.radioButtonThink = new System.Windows.Forms.RadioButton();
            this.radioButtonThin = new System.Windows.Forms.RadioButton();
            this.groupBoxOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelResultTotal = new System.Windows.Forms.Label();
            this.labelResultWhere = new System.Windows.Forms.Label();
            this.labelResultCrust = new System.Windows.Forms.Label();
            this.labelResultToppings = new System.Windows.Forms.Label();
            this.labelResultSize = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelWhere = new System.Windows.Forms.Label();
            this.labelCrust = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.groupBoxWhereToEat = new System.Windows.Forms.GroupBox();
            this.radioButtonOut = new System.Windows.Forms.RadioButton();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxPeppers = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxOnion = new System.Windows.Forms.CheckBox();
            this.checkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxChees = new System.Windows.Forms.CheckBox();
            this.buttonOP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxCrustType.SuspendLayout();
            this.groupBoxOrderSummary.SuspendLayout();
            this.groupBoxWhereToEat.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioButtonL);
            this.groupBoxSize.Controls.Add(this.radioButtonMe);
            this.groupBoxSize.Controls.Add(this.radioButtonSm);
            this.groupBoxSize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSize.Location = new System.Drawing.Point(12, 156);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(287, 278);
            this.groupBoxSize.TabIndex = 0;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // radioButtonL
            // 
            this.radioButtonL.AutoSize = true;
            this.radioButtonL.Location = new System.Drawing.Point(115, 184);
            this.radioButtonL.Name = "radioButtonL";
            this.radioButtonL.Size = new System.Drawing.Size(63, 25);
            this.radioButtonL.TabIndex = 2;
            this.radioButtonL.Text = "Larg";
            this.radioButtonL.UseVisualStyleBackColor = true;
            this.radioButtonL.CheckedChanged += new System.EventHandler(this.radioButtonL_CheckedChanged);
            // 
            // radioButtonMe
            // 
            this.radioButtonMe.AutoSize = true;
            this.radioButtonMe.Checked = true;
            this.radioButtonMe.Location = new System.Drawing.Point(115, 113);
            this.radioButtonMe.Name = "radioButtonMe";
            this.radioButtonMe.Size = new System.Drawing.Size(89, 25);
            this.radioButtonMe.TabIndex = 1;
            this.radioButtonMe.TabStop = true;
            this.radioButtonMe.Text = "Meduim";
            this.radioButtonMe.UseVisualStyleBackColor = true;
            this.radioButtonMe.CheckedChanged += new System.EventHandler(this.radioButtonMe_CheckedChanged);
            // 
            // radioButtonSm
            // 
            this.radioButtonSm.AutoSize = true;
            this.radioButtonSm.Location = new System.Drawing.Point(115, 42);
            this.radioButtonSm.Name = "radioButtonSm";
            this.radioButtonSm.Size = new System.Drawing.Size(71, 25);
            this.radioButtonSm.TabIndex = 0;
            this.radioButtonSm.Text = "Small";
            this.radioButtonSm.UseVisualStyleBackColor = true;
            this.radioButtonSm.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxCrustType
            // 
            this.groupBoxCrustType.Controls.Add(this.radioButtonThink);
            this.groupBoxCrustType.Controls.Add(this.radioButtonThin);
            this.groupBoxCrustType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCrustType.Location = new System.Drawing.Point(12, 453);
            this.groupBoxCrustType.Name = "groupBoxCrustType";
            this.groupBoxCrustType.Size = new System.Drawing.Size(287, 260);
            this.groupBoxCrustType.TabIndex = 1;
            this.groupBoxCrustType.TabStop = false;
            this.groupBoxCrustType.Text = "Crust Type";
            // 
            // radioButtonThink
            // 
            this.radioButtonThink.AutoSize = true;
            this.radioButtonThink.Location = new System.Drawing.Point(58, 160);
            this.radioButtonThink.Name = "radioButtonThink";
            this.radioButtonThink.Size = new System.Drawing.Size(115, 25);
            this.radioButtonThink.TabIndex = 6;
            this.radioButtonThink.Text = "Think Crust";
            this.radioButtonThink.UseVisualStyleBackColor = true;
            this.radioButtonThink.CheckedChanged += new System.EventHandler(this.radioButtonThink_CheckedChanged);
            // 
            // radioButtonThin
            // 
            this.radioButtonThin.AutoSize = true;
            this.radioButtonThin.Checked = true;
            this.radioButtonThin.Location = new System.Drawing.Point(62, 83);
            this.radioButtonThin.Name = "radioButtonThin";
            this.radioButtonThin.Size = new System.Drawing.Size(107, 25);
            this.radioButtonThin.TabIndex = 5;
            this.radioButtonThin.TabStop = true;
            this.radioButtonThin.Text = "Thin Crust";
            this.radioButtonThin.UseVisualStyleBackColor = true;
            this.radioButtonThin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // groupBoxOrderSummary
            // 
            this.groupBoxOrderSummary.Controls.Add(this.labelResultTotal);
            this.groupBoxOrderSummary.Controls.Add(this.labelResultWhere);
            this.groupBoxOrderSummary.Controls.Add(this.labelResultCrust);
            this.groupBoxOrderSummary.Controls.Add(this.labelResultToppings);
            this.groupBoxOrderSummary.Controls.Add(this.labelResultSize);
            this.groupBoxOrderSummary.Controls.Add(this.labelTotal);
            this.groupBoxOrderSummary.Controls.Add(this.labelWhere);
            this.groupBoxOrderSummary.Controls.Add(this.labelCrust);
            this.groupBoxOrderSummary.Controls.Add(this.labelToppings);
            this.groupBoxOrderSummary.Controls.Add(this.labelSize);
            this.groupBoxOrderSummary.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderSummary.Location = new System.Drawing.Point(784, 156);
            this.groupBoxOrderSummary.Name = "groupBoxOrderSummary";
            this.groupBoxOrderSummary.Size = new System.Drawing.Size(554, 549);
            this.groupBoxOrderSummary.TabIndex = 1;
            this.groupBoxOrderSummary.TabStop = false;
            this.groupBoxOrderSummary.Text = "Order Summary";
            // 
            // labelResultTotal
            // 
            this.labelResultTotal.AutoSize = true;
            this.labelResultTotal.Font = new System.Drawing.Font("Magneto", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultTotal.ForeColor = System.Drawing.Color.Green;
            this.labelResultTotal.Location = new System.Drawing.Point(178, 457);
            this.labelResultTotal.Name = "labelResultTotal";
            this.labelResultTotal.Size = new System.Drawing.Size(88, 52);
            this.labelResultTotal.TabIndex = 9;
            this.labelResultTotal.Text = "$0";
            // 
            // labelResultWhere
            // 
            this.labelResultWhere.AutoSize = true;
            this.labelResultWhere.Location = new System.Drawing.Point(178, 360);
            this.labelResultWhere.Name = "labelResultWhere";
            this.labelResultWhere.Size = new System.Drawing.Size(55, 21);
            this.labelResultWhere.TabIndex = 8;
            this.labelResultWhere.Text = "Eat In";
            // 
            // labelResultCrust
            // 
            this.labelResultCrust.AutoSize = true;
            this.labelResultCrust.Location = new System.Drawing.Point(169, 241);
            this.labelResultCrust.Name = "labelResultCrust";
            this.labelResultCrust.Size = new System.Drawing.Size(86, 21);
            this.labelResultCrust.TabIndex = 7;
            this.labelResultCrust.Text = "Thin Crust";
            // 
            // labelResultToppings
            // 
            this.labelResultToppings.Location = new System.Drawing.Point(80, 144);
            this.labelResultToppings.Name = "labelResultToppings";
            this.labelResultToppings.Size = new System.Drawing.Size(312, 94);
            this.labelResultToppings.TabIndex = 6;
            this.labelResultToppings.Text = "No Toppings";
            // 
            // labelResultSize
            // 
            this.labelResultSize.AutoSize = true;
            this.labelResultSize.Location = new System.Drawing.Point(103, 46);
            this.labelResultSize.Name = "labelResultSize";
            this.labelResultSize.Size = new System.Drawing.Size(68, 21);
            this.labelResultSize.TabIndex = 5;
            this.labelResultSize.Text = "Meduim";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(38, 399);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(124, 24);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total Price:";
            // 
            // labelWhere
            // 
            this.labelWhere.AutoSize = true;
            this.labelWhere.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelWhere.Location = new System.Drawing.Point(38, 321);
            this.labelWhere.Name = "labelWhere";
            this.labelWhere.Size = new System.Drawing.Size(152, 24);
            this.labelWhere.TabIndex = 3;
            this.labelWhere.Text = "Where To Eat:";
            // 
            // labelCrust
            // 
            this.labelCrust.AutoSize = true;
            this.labelCrust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelCrust.Location = new System.Drawing.Point(38, 238);
            this.labelCrust.Name = "labelCrust";
            this.labelCrust.Size = new System.Drawing.Size(125, 24);
            this.labelCrust.TabIndex = 2;
            this.labelCrust.Text = "Crust Type:";
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelToppings.Location = new System.Drawing.Point(38, 107);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(109, 24);
            this.labelToppings.TabIndex = 1;
            this.labelToppings.Text = "Toppings:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(38, 43);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(59, 24);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Size:";
            // 
            // groupBoxWhereToEat
            // 
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonOut);
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonIn);
            this.groupBoxWhereToEat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWhereToEat.Location = new System.Drawing.Point(305, 453);
            this.groupBoxWhereToEat.Name = "groupBoxWhereToEat";
            this.groupBoxWhereToEat.Size = new System.Drawing.Size(441, 167);
            this.groupBoxWhereToEat.TabIndex = 1;
            this.groupBoxWhereToEat.TabStop = false;
            this.groupBoxWhereToEat.Text = "Where To Eat";
            // 
            // radioButtonOut
            // 
            this.radioButtonOut.AutoSize = true;
            this.radioButtonOut.Location = new System.Drawing.Point(255, 73);
            this.radioButtonOut.Name = "radioButtonOut";
            this.radioButtonOut.Size = new System.Drawing.Size(99, 25);
            this.radioButtonOut.TabIndex = 1;
            this.radioButtonOut.Text = "Take Out";
            this.radioButtonOut.UseVisualStyleBackColor = true;
            this.radioButtonOut.CheckedChanged += new System.EventHandler(this.radioButtonOut_CheckedChanged);
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Checked = true;
            this.radioButtonIn.Location = new System.Drawing.Point(25, 73);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(76, 25);
            this.radioButtonIn.TabIndex = 0;
            this.radioButtonIn.TabStop = true;
            this.radioButtonIn.Text = "Eat In";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            this.radioButtonIn.CheckedChanged += new System.EventHandler(this.radioButtonIn_CheckedChanged);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxPeppers);
            this.groupBoxToppings.Controls.Add(this.checkBoxOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxOnion);
            this.groupBoxToppings.Controls.Add(this.checkBoxTomatoes);
            this.groupBoxToppings.Controls.Add(this.checkBoxMushrooms);
            this.groupBoxToppings.Controls.Add(this.checkBoxChees);
            this.groupBoxToppings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxToppings.Location = new System.Drawing.Point(344, 156);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(408, 278);
            this.groupBoxToppings.TabIndex = 1;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxPeppers
            // 
            this.checkBoxPeppers.AutoSize = true;
            this.checkBoxPeppers.Location = new System.Drawing.Point(232, 198);
            this.checkBoxPeppers.Name = "checkBoxPeppers";
            this.checkBoxPeppers.Size = new System.Drawing.Size(140, 25);
            this.checkBoxPeppers.TabIndex = 5;
            this.checkBoxPeppers.Text = "Green Peppers";
            this.checkBoxPeppers.UseVisualStyleBackColor = true;
            this.checkBoxPeppers.CheckedChanged += new System.EventHandler(this.checkBoxPeppers_CheckedChanged);
            // 
            // checkBoxOlives
            // 
            this.checkBoxOlives.AutoSize = true;
            this.checkBoxOlives.Location = new System.Drawing.Point(232, 120);
            this.checkBoxOlives.Name = "checkBoxOlives";
            this.checkBoxOlives.Size = new System.Drawing.Size(77, 25);
            this.checkBoxOlives.TabIndex = 4;
            this.checkBoxOlives.Text = "Olives";
            this.checkBoxOlives.UseVisualStyleBackColor = true;
            this.checkBoxOlives.CheckedChanged += new System.EventHandler(this.checkBoxOlives_CheckedChanged);
            // 
            // checkBoxOnion
            // 
            this.checkBoxOnion.AutoSize = true;
            this.checkBoxOnion.Location = new System.Drawing.Point(232, 42);
            this.checkBoxOnion.Name = "checkBoxOnion";
            this.checkBoxOnion.Size = new System.Drawing.Size(75, 25);
            this.checkBoxOnion.TabIndex = 3;
            this.checkBoxOnion.Text = "Onion";
            this.checkBoxOnion.UseVisualStyleBackColor = true;
            this.checkBoxOnion.CheckedChanged += new System.EventHandler(this.checkBoxOnion_CheckedChanged);
            // 
            // checkBoxTomatoes
            // 
            this.checkBoxTomatoes.AutoSize = true;
            this.checkBoxTomatoes.Location = new System.Drawing.Point(27, 198);
            this.checkBoxTomatoes.Name = "checkBoxTomatoes";
            this.checkBoxTomatoes.Size = new System.Drawing.Size(106, 25);
            this.checkBoxTomatoes.TabIndex = 2;
            this.checkBoxTomatoes.Text = "Tomatoes";
            this.checkBoxTomatoes.UseVisualStyleBackColor = true;
            this.checkBoxTomatoes.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(27, 122);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(117, 25);
            this.checkBoxMushrooms.TabIndex = 1;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            this.checkBoxMushrooms.CheckedChanged += new System.EventHandler(this.checkBoxMushrooms_CheckedChanged);
            // 
            // checkBoxChees
            // 
            this.checkBoxChees.AutoSize = true;
            this.checkBoxChees.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChees.Location = new System.Drawing.Point(23, 46);
            this.checkBoxChees.Name = "checkBoxChees";
            this.checkBoxChees.Size = new System.Drawing.Size(121, 25);
            this.checkBoxChees.TabIndex = 0;
            this.checkBoxChees.Text = "Extra Chees";
            this.checkBoxChees.UseVisualStyleBackColor = true;
            this.checkBoxChees.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonOP
            // 
            this.buttonOP.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOP.Location = new System.Drawing.Point(321, 642);
            this.buttonOP.Name = "buttonOP";
            this.buttonOP.Size = new System.Drawing.Size(179, 53);
            this.buttonOP.TabIndex = 2;
            this.buttonOP.Text = "Order Pizza";
            this.buttonOP.UseVisualStyleBackColor = true;
            this.buttonOP.Click += new System.EventHandler(this.buttonOP_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(535, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(238, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 99);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 754);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOP);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxWhereToEat);
            this.Controls.Add(this.groupBoxOrderSummary);
            this.Controls.Add(this.groupBoxCrustType);
            this.Controls.Add(this.groupBoxSize);
            this.Name = "Form";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxCrustType.ResumeLayout(false);
            this.groupBoxCrustType.PerformLayout();
            this.groupBoxOrderSummary.ResumeLayout(false);
            this.groupBoxOrderSummary.PerformLayout();
            this.groupBoxWhereToEat.ResumeLayout(false);
            this.groupBoxWhereToEat.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.GroupBox groupBoxCrustType;
        private System.Windows.Forms.GroupBox groupBoxOrderSummary;
        private System.Windows.Forms.GroupBox groupBoxWhereToEat;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.Button buttonOP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSm;
        private System.Windows.Forms.RadioButton radioButtonL;
        private System.Windows.Forms.RadioButton radioButtonMe;
        private System.Windows.Forms.RadioButton radioButtonThink;
        private System.Windows.Forms.RadioButton radioButtonThin;
        private System.Windows.Forms.CheckBox checkBoxChees;
        private System.Windows.Forms.CheckBox checkBoxPeppers;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.CheckBox checkBoxOnion;
        private System.Windows.Forms.CheckBox checkBoxTomatoes;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.RadioButton radioButtonOut;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelWhere;
        private System.Windows.Forms.Label labelCrust;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label labelResultTotal;
        private System.Windows.Forms.Label labelResultWhere;
        private System.Windows.Forms.Label labelResultCrust;
        private System.Windows.Forms.Label labelResultToppings;
        private System.Windows.Forms.Label labelResultSize;
    }
}

