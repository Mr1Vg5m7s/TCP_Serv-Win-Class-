
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox4 = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 498);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "127.0.01";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 53);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Server ip";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 70);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(102, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "1000";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 52);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Port";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(571, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(658, 19);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 2;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("GothicG", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(253, 20);
            label3.Name = "label3";
            label3.Size = new Size(244, 28);
            label3.TabIndex = 5;
            label3.Text = "Welcom to Fyrestone";
            label3.Click += this.label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 424);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(638, 54);
            textBox3.TabIndex = 6;
            textBox3.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 399);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Message";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PeachPuff;
            button3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(656, 424);
            button3.Name = "button3";
            button3.Size = new Size(75, 54);
            button3.TabIndex = 8;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(9, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 267);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chat";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Bisque;
            groupBox3.Location = new Point(660, 114);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(73, 267);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "My chats";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(626, 239);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Snow;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(618, 211);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 70);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(102, 23);
            textBox4.TabIndex = 11;
            textBox4.Text = "Tyler Durden";
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 52);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 621);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox4;
        private Label label5;
    }
}
