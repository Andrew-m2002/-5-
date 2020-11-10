namespace Практическая_работа_5_Андрюша
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.second1 = new System.Windows.Forms.TextBox();
            this.first1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задать1ПаруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задать2ПаруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.second2 = new System.Windows.Forms.TextBox();
            this.first2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cur1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cur2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Задать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.задать1ПаруToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.second1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.first1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задать значения первой пары";
            // 
            // second1
            // 
            this.second1.Location = new System.Drawing.Point(38, 79);
            this.second1.Name = "second1";
            this.second1.Size = new System.Drawing.Size(116, 26);
            this.second1.TabIndex = 1;
            // 
            // first1
            // 
            this.first1.Location = new System.Drawing.Point(38, 47);
            this.first1.Name = "first1";
            this.first1.Size = new System.Drawing.Size(116, 26);
            this.first1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задать1ПаруToolStripMenuItem,
            this.задать2ПаруToolStripMenuItem,
            this.сравнитьToolStripMenuItem,
            this.сброситьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // задать1ПаруToolStripMenuItem
            // 
            this.задать1ПаруToolStripMenuItem.Name = "задать1ПаруToolStripMenuItem";
            this.задать1ПаруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.задать1ПаруToolStripMenuItem.Text = "Задать 1 пару";
            this.задать1ПаруToolStripMenuItem.Click += new System.EventHandler(this.задать1ПаруToolStripMenuItem_Click);
            // 
            // задать2ПаруToolStripMenuItem
            // 
            this.задать2ПаруToolStripMenuItem.Name = "задать2ПаруToolStripMenuItem";
            this.задать2ПаруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.задать2ПаруToolStripMenuItem.Text = "Задать 2 пару";
            this.задать2ПаруToolStripMenuItem.Click += new System.EventHandler(this.задать2ПаруToolStripMenuItem_Click);
            // 
            // сравнитьToolStripMenuItem
            // 
            this.сравнитьToolStripMenuItem.Name = "сравнитьToolStripMenuItem";
            this.сравнитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сравнитьToolStripMenuItem.Text = "Сравнить";
            this.сравнитьToolStripMenuItem.Click += new System.EventHandler(this.сравнитьToolStripMenuItem_Click);
            // 
            // сброситьToolStripMenuItem
            // 
            this.сброситьToolStripMenuItem.Name = "сброситьToolStripMenuItem";
            this.сброситьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сброситьToolStripMenuItem.Text = "Сбросить";
            this.сброситьToolStripMenuItem.Click += new System.EventHandler(this.сброситьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.second2);
            this.groupBox2.Controls.Add(this.first2);
            this.groupBox2.Location = new System.Drawing.Point(207, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задать значения второй пары";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Задать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.задать2ПаруToolStripMenuItem_Click);
            // 
            // second2
            // 
            this.second2.Location = new System.Drawing.Point(33, 79);
            this.second2.Name = "second2";
            this.second2.Size = new System.Drawing.Size(116, 26);
            this.second2.TabIndex = 3;
            // 
            // first2
            // 
            this.first2.Location = new System.Drawing.Point(33, 46);
            this.first2.Name = "first2";
            this.first2.Size = new System.Drawing.Size(116, 26);
            this.first2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сравнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.сравнитьToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сбросить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.сброситьToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cur1);
            this.groupBox3.Location = new System.Drawing.Point(13, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Текущ. значения первой пары";
            // 
            // Cur1
            // 
            this.Cur1.Location = new System.Drawing.Point(37, 45);
            this.Cur1.Name = "Cur1";
            this.Cur1.ReadOnly = true;
            this.Cur1.Size = new System.Drawing.Size(116, 26);
            this.Cur1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Cur2);
            this.groupBox4.Location = new System.Drawing.Point(207, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 79);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Текущ. значения второй пары";
            // 
            // Cur2
            // 
            this.Cur2.Location = new System.Drawing.Point(33, 45);
            this.Cur2.Name = "Cur2";
            this.Cur2.ReadOnly = true;
            this.Cur2.Size = new System.Drawing.Size(116, 26);
            this.Cur2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 332);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Практическая работа №5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.сброситьToolStripMenuItem_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox second1;
        private System.Windows.Forms.TextBox first1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задать1ПаруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задать2ПаруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox second2;
        private System.Windows.Forms.TextBox first2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Cur1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Cur2;
    }
}

