namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ainput = new TextBox();
            cinput = new TextBox();
            binput = new TextBox();
            button1 = new Button();
            aresult = new TextBox();
            bresult = new TextBox();
            cresult = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 241);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(373, 98);
            label1.Name = "label1";
            label1.Size = new Size(56, 37);
            label1.TabIndex = 1;
            label1.Text = "a =";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(373, 153);
            label2.Name = "label2";
            label2.Size = new Size(58, 37);
            label2.TabIndex = 2;
            label2.Text = "b =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(377, 210);
            label3.Name = "label3";
            label3.Size = new Size(54, 37);
            label3.TabIndex = 3;
            label3.Text = "c =";
            // 
            // ainput
            // 
            ainput.Location = new Point(435, 112);
            ainput.Name = "ainput";
            ainput.Size = new Size(67, 23);
            ainput.TabIndex = 4;
            // 
            // cinput
            // 
            cinput.Location = new Point(435, 224);
            cinput.Name = "cinput";
            cinput.Size = new Size(67, 23);
            cinput.TabIndex = 5;
            // 
            // binput
            // 
            binput.Location = new Point(435, 167);
            binput.Name = "binput";
            binput.Size = new Size(67, 23);
            binput.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(585, 332);
            button1.Name = "button1";
            button1.Size = new Size(117, 26);
            button1.TabIndex = 7;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // aresult
            // 
            aresult.Location = new Point(585, 113);
            aresult.Name = "aresult";
            aresult.Size = new Size(87, 23);
            aresult.TabIndex = 8;
            // 
            // bresult
            // 
            bresult.Location = new Point(585, 168);
            bresult.Name = "bresult";
            bresult.Size = new Size(87, 23);
            bresult.TabIndex = 9;
            // 
            // cresult
            // 
            cresult.Location = new Point(585, 225);
            cresult.Name = "cresult";
            cresult.Size = new Size(87, 23);
            cresult.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(58, 388);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "about";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(175, 388);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(cresult);
            Controls.Add(bresult);
            Controls.Add(aresult);
            Controls.Add(button1);
            Controls.Add(binput);
            Controls.Add(cinput);
            Controls.Add(ainput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ainput;
        private TextBox cinput;
        private TextBox binput;
        private Button button1;
        private TextBox aresult;
        private TextBox bresult;
        private TextBox cresult;
        private Button button2;
        private Button button3;
    }
}
