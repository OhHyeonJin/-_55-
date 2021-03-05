using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using EATON_MONITOR_55.Properties;

namespace EATON_MONITOR_55
{
    public partial class MainForm : Form
    {
        #region DB관련 변수
        private GetData GD;                                                 // DB데이터 바인딩 객체
        private Thread DB_Thread;                                           // DB데이터 받아올 스레드 ( 무한 루프 )
        #endregion

        public MainForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
            MaximizeBox = false;
            #region 원디자인
            Manu_Circle m1 = new Manu_Circle(Color.Lime)
            {
                Padding = new Padding(0, 0, 0, 0),
                Margin = new Padding(0, 0, 0, 0),
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(59, 119, 175)
            };
            panel34.Controls.Add(m1);
            Manu_Circle m2 = new Manu_Circle(Color.Yellow)
            {
                Padding = new Padding(0, 0, 0, 0),
                Margin = new Padding(0, 0, 0, 0),
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(59, 119, 175)
            };
            panel36.Controls.Add(m2);
            Manu_Circle m3 = new Manu_Circle(Color.Red)
            {
                Padding = new Padding(0, 0, 0, 0),
                Margin = new Padding(0, 0, 0, 0),
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(59, 119, 175)
            };
            panel38.Controls.Add(m3);
            Manu_Circle m4 = new Manu_Circle(Color.White)
            {
                Padding = new Padding(0, 0, 0, 0),
                Margin = new Padding(0, 0, 0, 0),
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(59, 119, 175)
            };
            panel40.Controls.Add(m4);
            #endregion
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("MONITOR").Length > 1)
            {
                MessageBox.Show("프로그램이 이미 실행되고 있습니다.");
                Application.Exit();
            }
            else
            {
                #region 레이블 깜빡임 방지
                SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                #endregion
                #region 에러파일을 남길 폴더 생성
                DirectoryInfo di = new DirectoryInfo($"{Application.StartupPath}\\Error");
                if (!di.Exists)
                    di.Create();
                #endregion
                #region DB관련 객체 초기화
                GD = new GetData(this);
                DB_Thread = new Thread(new ThreadStart(GetDB))
                {
                    IsBackground = true
                };
                #endregion
                DB_Thread.Start();
            }
        }

        private void GetDB()
        {
            while (true)
            {
                GD.SetData();
                GC.Collect();
                Thread.Sleep(2000);
            }
        }

        #region 텍스트길이가 변경될 때 폰트사이즈 변경
        // 퍼센테이지
        private void LBL_Percent_TextChanged(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            int lbl_length = l.Text.Length;
            switch(lbl_length)
            {
                case 2:
                    l.Font = new Font("HY견고딕", 36, FontStyle.Regular);
                    break;

                case 3:
                    l.Font = new Font("HY견고딕", 28, FontStyle.Regular);
                    break;

                case 4:
                    l.Font = new Font("HY견고딕", 22, FontStyle.Regular);
                    break;

                case 5:
                    l.Font = new Font("HY견고딕", 18, FontStyle.Regular);
                    break;
            }
        }

        // 계획, 실적, 불량 수량
        private void LBL_Count_TextChanged(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            int lbl_length = l.Text.Length;
            if (lbl_length < 3)
                l.Font = new Font("HY견고딕", 38, FontStyle.Regular);
            else if (lbl_length < 4)
                l.Font = new Font("HY견고딕", 30, FontStyle.Regular);
            else if (lbl_length < 6)
                l.Font = new Font("HY견고딕", 20, FontStyle.Regular);
            else if (lbl_length < 7)
                l.Font = new Font("HY견고딕", 16, FontStyle.Regular);
            else
                l.Font = new Font("HY견고딕", 14, FontStyle.Regular);
        }
        #endregion
        #region 전체화면
        private void LBL_Timer_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                Size = new Size(1920, 1080);
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }
        #endregion
        #region 시간표시
        private void Timer_Change_Timer_Tick(object sender, EventArgs e)
        {
            LBL_Timer.Text = DateTime.Now.ToString();
        }
        #endregion
        #region 이미지 변경
        bool RUN_Img = false;

        private void Img_Change_Timer_Tick(object sender, EventArgs e)
        {
            if (!RUN_Img)
            {
                PB_Img.Image = Resources.RUN;
                RUN_Img = true;
            }
            else
            {
                PB_Img.Image = Resources.STOP;
                RUN_Img = false;
            }
        }
        #endregion
        #region UPH 퍼센테이지가 변경될 때마다 값 범위에 따른 색변경
        private void LBL_Uph_Percent_TextChanged(object sender, EventArgs e)
        {
            int now_per = Convert.ToInt32(LBL_Uph_Percent.Text.Replace("%", ""));
            if (now_per < 90)
            {
                LBL_Uph_Percent.BackColor = Color.Red;
                LBL_Uph_Percent.ForeColor = Color.White;
            }
            else if (90 <= now_per && now_per <= 95)
            {
                LBL_Uph_Percent.BackColor = Color.Yellow;
                LBL_Uph_Percent.ForeColor = Color.Black;
            }
            else
            {
                LBL_Uph_Percent.BackColor = Color.Green;
                LBL_Uph_Percent.ForeColor = Color.White;
            }
        }
        #endregion
    }

    #region 예외사항 기록
    public static class Record
    {
        public static void Error(string ex)
        {
            try
            {
                StreamWriter swriter = new StreamWriter($"{Application.StartupPath}\\Error\\{DateTime.Now:yyyyMMdd}.txt", true);
                swriter.WriteLine(ex);
                swriter.Flush();
                swriter.Close();
            }
            catch
            {
                return;
            }
        }
    }
    #endregion
}
