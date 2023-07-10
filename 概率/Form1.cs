using Tools.Formoperate;

namespace 概率
{
    public partial class Form1 : Form
    {
        // 定义一些东西
        // 1 - 10 的二维数组
        int[] data = new int[10];
        int[] 采集的数据 = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                data[i] = 10;
            }


            int currentnum = int.Parse(label_curr_key.Text);
            int val = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i != currentnum)
                {
                    val += data[i];
                }
            }
            trackBar0.Maximum = 100 - val;
            trackBar0.Value = data[int.Parse(label_curr_key.Text)];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 移动窗口
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            WinForms.MoveFrom(this.Handle);
        }


        private void Panel_图表_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int w = ((Panel)sender).Width;
            int h = ((Panel)sender).Height;

            //   | 
            //   |
            //   |
            //   |        /\
            //   |       /  \  /\      /
            //   |  /\  /    \/  \    /
            //   | /  \/          \/\/
            // ——+————————————————————————
            //   |

            int 框架交叉点延伸 = 20;
            int 框架_距顶端偏移 = 10;
            int 框架_距底端偏移 = 30;
            int 框架_距左边偏移 = 框架交叉点延伸 + 10;
            int 框架_距右边偏移 = 10;

            int 框架_高 = h - 框架_距顶端偏移 - 框架_距底端偏移;
            int 框架_宽 = w - 框架_距左边偏移 - 框架_距右边偏移;

            Point 框架_交叉点 = new Point(框架_距左边偏移, 框架_高 + 框架_距顶端偏移); // 0刻度线

            int 折线显示文本偏移x = -10;
            int 折线显示文本偏移y = -20;

            int 采集数据折线显示文本偏移x = -10;
            int 采集数据折线显示文本偏移y = 10;

            int X轴框架显示文本偏移x = -5;
            int X轴框架显示文本偏移y = 10;

            Graphics g = e.Graphics;
            Pen pen = new(Color.Blue, 2);
            Pen bluePen = new(Color.Red, 1);                                // 用来画折线图折线的
            Pen greenPen = new(Color.Green, 1);                                // 用来画折线图折线的
            Brush 框架_文字画刷 = new SolidBrush(Color.Yellow);
            Brush 折线_文字画刷 = new SolidBrush(Color.Yellow);
            Brush 采集数据折线_文字画刷 = new SolidBrush(Color.Green);


            // 第一条水平线W = w - 20, h = 110;
            g.DrawLine(pen, new Point(框架_距左边偏移 - 框架交叉点延伸, 框架_高 + 框架_距顶端偏移), new Point(w - 框架_距右边偏移, 框架_高 + 框架_距顶端偏移));
            // 第二条 20,10  - 20,110
            g.DrawLine(pen, new Point(框架_距左边偏移, 框架_距顶端偏移), new Point(框架_距左边偏移, 框架_高 + 框架_距顶端偏移 + 框架交叉点延伸));

            // 画垂直轴最大值
            g.DrawString("100", new Font("宋体", 10), 框架_文字画刷, 框架_距左边偏移 - 20, 框架_距顶端偏移 - 10);

            Point[] 折线点 = new Point[10];
            Point[] 采集数据折线点 = new Point[10];
            for (int i = 0; i < 10; i++)
            {
                int x = (框架_宽 / 10) * i + 框架_距左边偏移;
                折线点[i] = new Point(x, 框架_高 + 框架_距顶端偏移 - (框架_高 / 100 * data[i]));
                // 绘制折线文字
                g.DrawString(data[i].ToString(), new Font("宋体", 10), 折线_文字画刷, x + 折线显示文本偏移x, 框架_高 + 框架_距顶端偏移 - (框架_高 / 100 * data[i]) + 折线显示文本偏移y);

                // 设置采集数据后的折线点
                采集数据折线点[i] = new Point(x, 框架_高 + 框架_距顶端偏移 - (框架_高 / 100 * 采集的数据[i]));
                // 绘制采集数据折线文字
                g.DrawString(采集的数据[i].ToString(), new Font("宋体", 10), 采集数据折线_文字画刷, x + 采集数据折线显示文本偏移x, 框架_高 + 框架_距顶端偏移 - (框架_高 / 100 * 采集的数据[i]) + 采集数据折线显示文本偏移y);

                // 绘制x轴文字
                g.DrawString(i.ToString(), new Font("宋体", 10), 折线_文字画刷, x + X轴框架显示文本偏移x, 框架_高 + 框架_距顶端偏移 + X轴框架显示文本偏移y);
            }

            // 画折线图折线
            g.DrawLines(bluePen, 折线点);
            // 绘制采集数据后的折线
            g.DrawLines(greenPen, 采集数据折线点);

            // 相关销毁
            pen.Dispose();
            bluePen.Dispose();
            框架_文字画刷.Dispose();
            折线_文字画刷.Dispose();
            g.Dispose();
            GC.Collect();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int currentnum = int.Parse(label_curr_key.Text);

            int val = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i != currentnum)
                {
                    val += data[i];
                }
            }
            if (100 - val > ((TrackBar)sender).Value)
            {
                data[currentnum] = ((TrackBar)sender).Value;
            }
            else
            {
                data[currentnum] = 100 - val;
                ((TrackBar)sender).Value = 100 - val;
            }

            btn_run.Enabled = 100 - val == data[currentnum];

            Panel_图表.Invalidate();
        }

        private void pictureBox_Btn_Left_Click(object sender, EventArgs e)
        {
            if (label_curr_key.Text != "0")
            {
                label_curr_key.Text = (int.Parse(label_curr_key.Text) - 1).ToString();
                // 算一下 滑动条的最大值

                int currentnum = int.Parse(label_curr_key.Text);

                int val = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i != currentnum)
                    {
                        val += data[i];
                    }
                }
                trackBar0.Maximum = 100 - val;
                trackBar0.Value = data[int.Parse(label_curr_key.Text)];
            }
        }

        private void pictureBox_Btn_Right_Click(object sender, EventArgs e)
        {
            if (label_curr_key.Text != "9")
            {
                label_curr_key.Text = (int.Parse(label_curr_key.Text) + 1).ToString();

                // 算一下 滑动条的最大值

                int currentnum = int.Parse(label_curr_key.Text);

                int val = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i != currentnum)
                    {
                        val += data[i];
                    }
                }
                trackBar0.Maximum = 100 - val;
                trackBar0.Value = data[int.Parse(label_curr_key.Text)];
            }
        }

        // reset btn
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                data[i] = 10;
            }
            trackBar0.Maximum = 10;
            trackBar0.Value = 10;

            btn_run.Enabled = true;
            Panel_图表.Invalidate();
        }

        // 进行1000 次数据采集按照给定的概率 看看0-9这几个数字出现的概率是否和给定的概率一样
        void 数据采集()
        {
            for(int i = 0;i < 10; i++)
            {
                采集的数据[i] = 0;
            }

            int[] 概率转化的数据 = new int[10];

            int 已经占用的概率数值 = 0;
            for (int i = 0; i < 10; i++)
            {
                概率转化的数据[i] = 已经占用的概率数值 + data[i];
                已经占用的概率数值 = 概率转化的数据[i];
                label_show.Text = "已经占用的概率数值" + 已经占用的概率数值.ToString();
            }

            for (int i = 0; i < 1000; i++)
            {
                Random random = new Random((int)DateTime.Now.Ticks + i);
                int v1 = random.Next(0, 100);
                for(int j = 0; j < 10; j++)
                {
                    if (v1 < 概率转化的数据[j])
                    {
                        if(j == 0 || v1 >= 概率转化的数据[j - 1])
                        {
                            采集的数据[j]++;
                        }
                    }
                }
            }

            int 概率总和 = 0;
            for(int i = 0; i< 10; i++)
            {
                采集的数据[i] = (int)Math.Round(采集的数据[i] * 1.0f / (1000f / 100f), 0, MidpointRounding.AwayFromZero);
                概率总和 += 采集的数据[i];
            }
            label_show.Text = "数据采集完毕 概率总和:" + 概率总和;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            数据采集();
            Panel_图表.Invalidate();
        }
    }
}