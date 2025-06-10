namespace CoffeeMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox2 = new TextBox();
            toolTip1 = new ToolTip(components);
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Sitka Heading", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 43);
            label1.TabIndex = 0;
            label1.Text = "Поръчка на напитка";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tea", "Beer", "Coffee", "Juice" });
            comboBox1.Location = new Point(32, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 23);
            comboBox1.TabIndex = 1;
            toolTip1.SetToolTip(comboBox1, "Choose beverage!");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(43, 92);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Small";
            toolTip1.SetToolTip(radioButton1, "Choose small drink.");
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(103, 92);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Medium";
            toolTip1.SetToolTip(radioButton2, "Choose medium drink.");
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(179, 92);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(54, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Large";
            toolTip1.SetToolTip(radioButton3, "Choose Large drink.");
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(43, 117);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Milk";
            toolTip1.SetToolTip(checkBox1, "Add Milk");
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(98, 117);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Sugar";
            toolTip1.SetToolTip(checkBox2, "Add Sugar");
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(160, 117);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(41, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Ice";
            toolTip1.SetToolTip(checkBox3, "Add Ice");
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(103, 481);
            button1.Name = "button1";
            button1.Size = new Size(161, 108);
            button1.TabIndex = 8;
            button1.Text = "Потвърди поръчката!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 144);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 10;
            toolTip1.SetToolTip(textBox1, "Enter your name:");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_2025_06_09_225336641;
            pictureBox1.Location = new Point(91, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 144);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "This is your drink!");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 434);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 12;
            label3.Text = "Брой поръчки:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 452);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 13;
            textBox2.Text = "0";
            toolTip1.SetToolTip(textBox2, "How many dinks you have ordered.");
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 0;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 100;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(103, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(161, 16);
            progressBar1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image_2025_06_09_215511049;
            ClientSize = new Size(367, 665);
            Controls.Add(progressBar1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "CoffeeMachine";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox2;
        private ToolTip toolTip1;
        private ProgressBar progressBar1;
    }
}
