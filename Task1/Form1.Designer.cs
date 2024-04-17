namespace Task1
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            button_add = new Button();
            textBox_add = new TextBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            textBox_delete = new TextBox();
            button_delete = new Button();
            groupBox4 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox5 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_difference = new TextBox();
            textBox_count = new TextBox();
            textBox_sum = new TextBox();
            groupBox6 = new GroupBox();
            listBox2 = new ListBox();
            button_listgen = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 361);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 335);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_add);
            groupBox2.Controls.Add(textBox_add);
            groupBox2.Location = new Point(429, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 128);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавление элемента";
            // 
            // button_add
            // 
            button_add.Location = new Point(45, 76);
            button_add.Name = "button_add";
            button_add.Size = new Size(151, 29);
            button_add.TabIndex = 2;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // textBox_add
            // 
            textBox_add.Location = new Point(6, 26);
            textBox_add.Name = "textBox_add";
            textBox_add.Size = new Size(232, 27);
            textBox_add.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox_delete);
            groupBox3.Controls.Add(button_delete);
            groupBox3.Location = new Point(429, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 126);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Удаление элемента";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(126, 72);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 8;
            button1.Text = "Удалить первый элемент списка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_delete
            // 
            textBox_delete.Location = new Point(6, 26);
            textBox_delete.Name = "textBox_delete";
            textBox_delete.Size = new Size(232, 27);
            textBox_delete.TabIndex = 1;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI Black", 6F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_delete.Location = new Point(6, 72);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(114, 48);
            button_delete.TabIndex = 0;
            button_delete.Text = "Удалить элемент с данным индексом\r\n";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button2);
            groupBox4.Location = new Point(429, 295);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 230);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(6, 160);
            button4.Name = "button4";
            button4.Size = new Size(238, 51);
            button4.TabIndex = 2;
            button4.Text = "Проверка, одинаковы ли списки";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 92);
            button3.Name = "button3";
            button3.Size = new Size(238, 50);
            button3.TabIndex = 1;
            button3.Text = "Добавить второй список к первому";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 26);
            button2.Name = "button2";
            button2.Size = new Size(238, 39);
            button2.TabIndex = 0;
            button2.Text = "Проверка, пуст ли список";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(textBox_difference);
            groupBox5.Controls.Add(textBox_count);
            groupBox5.Controls.Add(textBox_sum);
            groupBox5.Location = new Point(12, 379);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(411, 146);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            // 
            // label3
            // 
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(263, 45);
            label3.TabIndex = 5;
            label3.Text = "Разница между минимальным и максимальным элементами списка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 4;
            label2.Text = "Количесвто элементов списка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 3;
            label1.Text = "Сумма элементов списка";
            // 
            // textBox_difference
            // 
            textBox_difference.Location = new Point(275, 109);
            textBox_difference.Name = "textBox_difference";
            textBox_difference.Size = new Size(125, 27);
            textBox_difference.TabIndex = 2;
            // 
            // textBox_count
            // 
            textBox_count.Location = new Point(275, 59);
            textBox_count.Name = "textBox_count";
            textBox_count.Size = new Size(125, 27);
            textBox_count.TabIndex = 1;
            // 
            // textBox_sum
            // 
            textBox_sum.Location = new Point(275, 20);
            textBox_sum.Name = "textBox_sum";
            textBox_sum.Size = new Size(125, 27);
            textBox_sum.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(listBox2);
            groupBox6.Location = new Point(702, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(334, 277);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Второй список";
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(3, 23);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(328, 251);
            listBox2.TabIndex = 7;
            // 
            // button_listgen
            // 
            button_listgen.Location = new Point(784, 310);
            button_listgen.Name = "button_listgen";
            button_listgen.Size = new Size(200, 50);
            button_listgen.TabIndex = 7;
            button_listgen.Text = "Сгенерировать список";
            button_listgen.UseVisualStyleBackColor = true;
            button_listgen.Click += button_listgen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 543);
            Controls.Add(button_listgen);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_difference;
        private TextBox textBox_count;
        private TextBox textBox_sum;
        private Button button_add;
        private TextBox textBox_add;
        private ListBox listBox1;
        private TextBox textBox_delete;
        private Button button_delete;
        private Button button4;
        private Button button3;
        private Button button2;
        private GroupBox groupBox6;
        private ListBox listBox2;
        private Button button_listgen;
        private Button button1;
    }
}
