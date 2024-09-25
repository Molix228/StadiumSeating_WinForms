namespace WinFormsApp1
{
    partial class StadiumSeating
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
            tickets = new GroupBox();
            classC_tickets = new Label();
            classA_tickets = new Label();
            classB_tickets = new Label();
            textBoxC_tickets = new TextBox();
            textBoxB_tickets = new TextBox();
            textBoxA_tickets = new TextBox();
            tickets_description = new Label();
            generated = new GroupBox();
            TotalValue = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            totalLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tickets.SuspendLayout();
            generated.SuspendLayout();
            SuspendLayout();
            // 
            // tickets
            // 
            tickets.Controls.Add(classC_tickets);
            tickets.Controls.Add(classA_tickets);
            tickets.Controls.Add(classB_tickets);
            tickets.Controls.Add(textBoxC_tickets);
            tickets.Controls.Add(textBoxB_tickets);
            tickets.Controls.Add(textBoxA_tickets);
            tickets.Controls.Add(tickets_description);
            tickets.FlatStyle = FlatStyle.Flat;
            tickets.Font = new Font("Segoe UI", 12F);
            tickets.Location = new Point(65, 88);
            tickets.Name = "tickets";
            tickets.Size = new Size(544, 533);
            tickets.TabIndex = 0;
            tickets.TabStop = false;
            tickets.Text = "Tickets Sold";
            // 
            // classC_tickets
            // 
            classC_tickets.AutoSize = true;
            classC_tickets.Location = new Point(101, 355);
            classC_tickets.Name = "classC_tickets";
            classC_tickets.Size = new Size(128, 45);
            classC_tickets.TabIndex = 7;
            classC_tickets.Text = "Class C:";
            // 
            // classA_tickets
            // 
            classA_tickets.AutoSize = true;
            classA_tickets.Location = new Point(101, 186);
            classA_tickets.Name = "classA_tickets";
            classA_tickets.Size = new Size(129, 45);
            classA_tickets.TabIndex = 6;
            classA_tickets.Text = "Class A:";
            // 
            // classB_tickets
            // 
            classB_tickets.AutoSize = true;
            classB_tickets.Location = new Point(101, 269);
            classB_tickets.Name = "classB_tickets";
            classB_tickets.Size = new Size(126, 45);
            classB_tickets.TabIndex = 5;
            classB_tickets.Text = "Class B:";
            // 
            // textBoxC_tickets
            // 
            textBoxC_tickets.Location = new Point(270, 355);
            textBoxC_tickets.Name = "textBoxC_tickets";
            textBoxC_tickets.Size = new Size(230, 50);
            textBoxC_tickets.TabIndex = 2;
            // 
            // textBoxB_tickets
            // 
            textBoxB_tickets.Location = new Point(270, 269);
            textBoxB_tickets.Name = "textBoxB_tickets";
            textBoxB_tickets.Size = new Size(230, 50);
            textBoxB_tickets.TabIndex = 1;
            // 
            // textBoxA_tickets
            // 
            textBoxA_tickets.Location = new Point(270, 186);
            textBoxA_tickets.Name = "textBoxA_tickets";
            textBoxA_tickets.Size = new Size(230, 50);
            textBoxA_tickets.TabIndex = 0;
            // 
            // tickets_description
            // 
            tickets_description.Location = new Point(74, 66);
            tickets_description.Name = "tickets_description";
            tickets_description.Size = new Size(408, 117);
            tickets_description.TabIndex = 5;
            tickets_description.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // generated
            // 
            generated.Controls.Add(TotalValue);
            generated.Controls.Add(textBox3);
            generated.Controls.Add(textBox2);
            generated.Controls.Add(textBox1);
            generated.Controls.Add(totalLabel);
            generated.Controls.Add(label3);
            generated.Controls.Add(label2);
            generated.Controls.Add(label1);
            generated.Font = new Font("Segoe UI", 12F);
            generated.Location = new Point(872, 88);
            generated.Name = "generated";
            generated.Size = new Size(544, 533);
            generated.TabIndex = 1;
            generated.TabStop = false;
            generated.Text = "Revenue Generated";
            // 
            // TotalValue
            // 
            TotalValue.Enabled = false;
            TotalValue.Location = new Point(254, 376);
            TotalValue.Name = "TotalValue";
            TotalValue.Size = new Size(230, 50);
            TotalValue.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(233, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 50);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(233, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 50);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(233, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 50);
            textBox1.TabIndex = 8;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(153, 376);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(95, 45);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 284);
            label3.Name = "label3";
            label3.Size = new Size(128, 45);
            label3.TabIndex = 8;
            label3.Text = "Class C:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 198);
            label2.Name = "label2";
            label2.Size = new Size(126, 45);
            label2.TabIndex = 8;
            label2.Text = "Class B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 120);
            label1.Name = "label1";
            label1.Size = new Size(129, 45);
            label1.TabIndex = 8;
            label1.Text = "Class A:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(335, 762);
            button1.Name = "button1";
            button1.Size = new Size(230, 110);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(631, 762);
            button2.Name = "button2";
            button2.Size = new Size(230, 110);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(944, 762);
            button3.Name = "button3";
            button3.Size = new Size(230, 110);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StadiumSeating
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1492, 967);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(generated);
            Controls.Add(tickets);
            Name = "StadiumSeating";
            Text = "Stadium Seating";
            tickets.ResumeLayout(false);
            tickets.PerformLayout();
            generated.ResumeLayout(false);
            generated.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox tickets;
        private GroupBox generated;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label tickets_description;
        private TextBox textBoxC_tickets;
        private TextBox textBoxB_tickets;
        private TextBox textBoxA_tickets;
        private Label classB_tickets;
        private Label classC_tickets;
        private Label classA_tickets;
        private Label totalLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox TotalValue;
    }
}
