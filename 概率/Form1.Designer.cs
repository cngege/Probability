namespace 概率
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Panel_FormBody = new Panel();
            label_show = new Label();
            btn_run = new Button();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox_Btn_Right = new PictureBox();
            pictureBox_Btn_Left = new PictureBox();
            label_curr_key = new Label();
            trackBar0 = new TrackBar();
            Panel_图表 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel_FormBody.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Btn_Right).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Btn_Left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar0).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 126, 176);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 36);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.概率;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.关闭;
            pictureBox1.Location = new Point(751, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Panel_FormBody
            // 
            Panel_FormBody.Controls.Add(label_show);
            Panel_FormBody.Controls.Add(btn_run);
            Panel_FormBody.Controls.Add(panel2);
            Panel_FormBody.Controls.Add(trackBar0);
            Panel_FormBody.Controls.Add(Panel_图表);
            Panel_FormBody.Dock = DockStyle.Fill;
            Panel_FormBody.Location = new Point(0, 36);
            Panel_FormBody.Name = "Panel_FormBody";
            Panel_FormBody.Size = new Size(780, 364);
            Panel_FormBody.TabIndex = 1;
            // 
            // label_show
            // 
            label_show.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_show.ForeColor = Color.White;
            label_show.Location = new Point(475, 122);
            label_show.Name = "label_show";
            label_show.Size = new Size(293, 28);
            label_show.TabIndex = 5;
            label_show.Text = "...";
            label_show.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_run
            // 
            btn_run.Location = new Point(475, 153);
            btn_run.Name = "btn_run";
            btn_run.Size = new Size(293, 23);
            btn_run.TabIndex = 4;
            btn_run.Text = "概率分析 跑数据 × 1000";
            btn_run.UseVisualStyleBackColor = true;
            btn_run.Click += btn_run_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox_Btn_Right);
            panel2.Controls.Add(pictureBox_Btn_Left);
            panel2.Controls.Add(label_curr_key);
            panel2.Location = new Point(472, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 44);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(180, 13);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 6;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox_Btn_Right
            // 
            pictureBox_Btn_Right.Image = Properties.Resources.向右;
            pictureBox_Btn_Right.Location = new Point(84, 8);
            pictureBox_Btn_Right.Name = "pictureBox_Btn_Right";
            pictureBox_Btn_Right.Size = new Size(28, 28);
            pictureBox_Btn_Right.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Btn_Right.TabIndex = 5;
            pictureBox_Btn_Right.TabStop = false;
            pictureBox_Btn_Right.Click += pictureBox_Btn_Right_Click;
            // 
            // pictureBox_Btn_Left
            // 
            pictureBox_Btn_Left.Image = Properties.Resources.向左;
            pictureBox_Btn_Left.Location = new Point(50, 8);
            pictureBox_Btn_Left.Name = "pictureBox_Btn_Left";
            pictureBox_Btn_Left.Size = new Size(28, 28);
            pictureBox_Btn_Left.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Btn_Left.TabIndex = 4;
            pictureBox_Btn_Left.TabStop = false;
            pictureBox_Btn_Left.Click += pictureBox_Btn_Left_Click;
            // 
            // label_curr_key
            // 
            label_curr_key.AutoSize = true;
            label_curr_key.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_curr_key.ForeColor = Color.White;
            label_curr_key.Location = new Point(3, 8);
            label_curr_key.Name = "label_curr_key";
            label_curr_key.Size = new Size(25, 28);
            label_curr_key.TabIndex = 3;
            label_curr_key.Text = "0";
            // 
            // trackBar0
            // 
            trackBar0.Location = new Point(472, 6);
            trackBar0.Maximum = 100;
            trackBar0.Name = "trackBar0";
            trackBar0.Size = new Size(296, 45);
            trackBar0.TabIndex = 1;
            trackBar0.TickStyle = TickStyle.None;
            trackBar0.Scroll += trackBar_Scroll;
            // 
            // Panel_图表
            // 
            Panel_图表.BackColor = Color.FromArgb(140, 122, 230);
            Panel_图表.Location = new Point(12, 6);
            Panel_图表.Name = "Panel_图表";
            Panel_图表.Size = new Size(454, 346);
            Panel_图表.TabIndex = 0;
            Panel_图表.Paint += Panel_图表_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 59, 72);
            ClientSize = new Size(780, 400);
            Controls.Add(Panel_FormBody);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel_FormBody.ResumeLayout(false);
            Panel_FormBody.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Btn_Right).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Btn_Left).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar0).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel Panel_FormBody;
        private Panel Panel_图表;
        private TrackBar trackBar0;
        private Panel panel2;
        private PictureBox pictureBox_Btn_Left;
        private Label label_curr_key;
        private PictureBox pictureBox_Btn_Right;
        private Button button1;
        private Button btn_run;
        private Label label_show;
    }
}