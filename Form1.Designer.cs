namespace GuiWalutowe
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(169, 12);
            label1.Name = "label1";
            label1.Size = new Size(483, 35);
            label1.TabIndex = 0;
            label1.Text = "Wyliczarka kursów dolara amerykańskiego";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 65);
            label2.Name = "label2";
            label2.Size = new Size(325, 20);
            label2.TabIndex = 1;
            label2.Text = "Wybierz dzień z którego chcesz wyświetlić kursy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 100);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 5;
            label4.Text = "Kursy walut:";
            // 
            // button1
            // 
            button1.Location = new Point(99, 218);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 6;
            button1.Text = "Uruchom";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(99, 124);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(298, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 100);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "Data: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 126);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(426, 428);
            textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 567);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox1;
    }
}
