using System;
using System.Diagnostics;
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
        #region UPH관련 변수
        public int UPH_PlanQty = 0;                                         // UPH 계획수량
        public int UPH_ProdQty = 0;                                         // UPH 실적수량
        private TimeSpan WorkStartTime = TimeSpan.Parse("08:30:00");        // 작업시작시간 ( 추후 변경될 수 있음 )
        private TimeSpan WorkEndTime_8 = TimeSpan.Parse("17:30:00");        // 작업종료시간 ( 8시간, 점심시간 1시간 )
        private TimeSpan WorkEndTime_9 = TimeSpan.Parse("18:30:00");        // 작업종료시간 ( 9시간, 점심시간 1시간 )
        private TimeSpan WorkEndTime_10 = TimeSpan.Parse("19:30:00");       // 작업종료시간 ( 10시간, 점심시간 1시간 )
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
                Get_UPH();
                GC.Collect();
                Thread.Sleep(2000);
            }
        }

        #region UPH 로직관련
        private delegate void _Text_Changed(Control ctrl, string text);

        private void Text_Changed(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke(new _Text_Changed(Text_Changed), ctrl, text);
            else
                ctrl.Text = text;
        }

        public void Get_UPH()
        {
            if (UPH_PlanQty > 0)
            {
                #region 현재시간대비 계획수량 구함
                TimeSpan nowtime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                double percent;                                         // 퍼센트
                double planqty;                                         // 계획수량

                if (0 <= UPH_PlanQty && UPH_PlanQty <= 500)             // 계획수량이 500개 이하일 경우 '8시간' 기준
                {
                    #region 계획수량
                    planqty = UPH_PlanQty / 8;
                    planqty = Math.Truncate(planqty);
                    #endregion
                    if (WorkStartTime <= nowtime && nowtime <= WorkEndTime_8)
                    {
                        #region 작업시작시간보다 현재시간이 빨라야하고, 작업종료시간보다는 늦어야함
                        if (WorkStartTime <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("01:00:00")))                                         // 작업시작시간 ( 8시 30분 ~ 9시 30분 )
                            planqty *= 1;
                        else if (WorkStartTime.Add(TimeSpan.Parse("01:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("02:00:00")))    // 2시간 ( 9시 30분 ~ 10시 30분 )
                            planqty *= 2;
                        else if (WorkStartTime.Add(TimeSpan.Parse("02:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("03:00:00")))    // 3시간 ( 10시 30분 ~ 11시 30분 )
                            planqty *= 3;
                        else if (WorkStartTime.Add(TimeSpan.Parse("03:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("05:00:00")))    // 4시간 ( 점심시간 포함, 11시 30분 ~ 13시 30분 )
                            planqty *= 4;
                        else if (WorkStartTime.Add(TimeSpan.Parse("05:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("06:00:00")))    // 5시간 ( 13시 30분 ~ 14시 30분 )
                            planqty *= 5;
                        else if (WorkStartTime.Add(TimeSpan.Parse("06:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("07:00:00")))    // 6시간 ( 14시 30분 ~ 15시 30분 )
                            planqty *= 6;
                        else if (WorkStartTime.Add(TimeSpan.Parse("07:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("08:00:00")))    // 7시간 ( 15시 30분 ~ 16시 30분 )
                            planqty *= 7;
                        else                                                                                                                             // 작업종료시간 ( 16시 30분 ~ )
                            planqty = UPH_PlanQty;

                        Text_Changed(LBL_Uph_Plan, string.Format("{0:#,###}", planqty));
                        #endregion
                    }
                    else
                        Text_Changed(LBL_Uph_Plan, string.Format("{0:#,###}", UPH_PlanQty));
                }
                else if (500 < UPH_PlanQty && UPH_PlanQty <= 600)      // 계획수량이 501개 이상, 600개 이하일 경우 '9시간' 기준
                {
                    #region 계획수량
                    planqty = UPH_PlanQty / 9;
                    planqty = Math.Truncate(planqty);
                    #endregion
                    if (WorkStartTime <= nowtime && nowtime <= WorkEndTime_9)
                    {
                        #region 작업시작시간보다 현재시간이 빨라야하고, 작업종료시간보다는 늦어야함
                        if (WorkStartTime <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("01:00:00")))                                         // 작업시작시간 ( 8시 30분 ~ 9시 30분 )
                            planqty *= 1;
                        else if (WorkStartTime.Add(TimeSpan.Parse("01:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("02:00:00")))    // 2시간 ( 9시 30분 ~ 10시 30분 )
                            planqty *= 2;
                        else if (WorkStartTime.Add(TimeSpan.Parse("02:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("03:00:00")))    // 3시간 ( 10시 30분 ~ 11시 30분 )
                            planqty *= 3;
                        else if (WorkStartTime.Add(TimeSpan.Parse("03:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("05:00:00")))    // 4시간 ( 점심시간 포함, 11시 30분 ~ 13시 30분 )
                            planqty *= 4;
                        else if (WorkStartTime.Add(TimeSpan.Parse("05:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("06:00:00")))    // 5시간 ( 13시 30분 ~ 14시 30분 )
                            planqty *= 5;
                        else if (WorkStartTime.Add(TimeSpan.Parse("06:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("07:00:00")))    // 6시간 ( 14시 30분 ~ 15시 30분 )
                            planqty *= 6;
                        else if (WorkStartTime.Add(TimeSpan.Parse("07:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("08:00:00")))    // 7시간 ( 15시 30분 ~ 16시 30분 )
                            planqty *= 7;
                        else if (WorkStartTime.Add(TimeSpan.Parse("08:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("09:00:00")))    // 8시간 ( 16시 30분 ~ 17시 30분 )
                            planqty *= 8;
                        else                                                                                                                             // 작업종료시간 ( 17시 30분 ~ )
                            planqty = UPH_PlanQty;

                        Text_Changed(LBL_Uph_Plan, string.Format("{0:#,###}", planqty));
                        #endregion
                    }
                    else
                        Text_Changed(LBL_Uph_Plan, string.Format("{0:#,###}", UPH_PlanQty));
                }
                else                                                   // 계획수량이 601개 이상일 경우 '10시간' 기준
                {
                    #region 계획수량
                    planqty = UPH_PlanQty / 10;
                    planqty = Math.Truncate(planqty);
                    #endregion
                    if (WorkStartTime <= nowtime && nowtime <= WorkEndTime_10)
                    {
                        #region 작업시작시간보다 현재시간이 빨라야하고, 작업종료시간보다는 늦어야함
                        if (WorkStartTime <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("01:00:00")))                                         // 작업시작시간 ( 8시 30분 ~ 9시 30분 )
                            planqty *= 1;
                        else if (WorkStartTime.Add(TimeSpan.Parse("01:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("02:00:00")))    // 2시간 ( 9시 30분 ~ 10시 30분 )
                            planqty *= 2;
                        else if (WorkStartTime.Add(TimeSpan.Parse("02:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("03:00:00")))    // 3시간 ( 10시 30분 ~ 11시 30분 )
                            planqty *= 3;
                        else if (WorkStartTime.Add(TimeSpan.Parse("03:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("05:00:00")))    // 4시간 ( 점심시간 포함, 11시 30분 ~ 13시 30분 )
                            planqty *= 4;
                        else if (WorkStartTime.Add(TimeSpan.Parse("05:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("06:00:00")))    // 5시간 ( 13시 30분 ~ 14시 30분 )
                            planqty *= 5;
                        else if (WorkStartTime.Add(TimeSpan.Parse("06:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("07:00:00")))    // 6시간 ( 14시 30분 ~ 15시 30분 )
                            planqty *= 6;
                        else if (WorkStartTime.Add(TimeSpan.Parse("07:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("08:00:00")))    // 7시간 ( 15시 30분 ~ 16시 30분 )
                            planqty *= 7;
                        else if (WorkStartTime.Add(TimeSpan.Parse("08:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("09:00:00")))    // 8시간 ( 16시 30분 ~ 17시 30분 )
                            planqty *= 8;
                        else if (WorkStartTime.Add(TimeSpan.Parse("09:00:00")) <= nowtime && nowtime < WorkStartTime.Add(TimeSpan.Parse("10:00:00")))    // 9시간 ( 17시 30분 ~ 18시 30분 )
                            planqty *= 9;
                        else                                                                                                                             // 작업종료시간 ( 18시 30분 ~ )
                            planqty = UPH_PlanQty;

                        Text_Changed(LBL_Uph_Plan, string.Format("{0:#,###}", planqty));
                        #endregion
                    }
                    else
                        Text_Changed(LBL_Uph_Plan, string.Format("{0:#,###}", UPH_PlanQty));
                }

                if (UPH_ProdQty == 0)
                    Text_Changed(LBL_Uph_Prod, "0");
                else
                    Text_Changed(LBL_Uph_Prod, string.Format("{0:#,###}", UPH_ProdQty));

                #region 퍼센테이지를 구해서 색상변경
                percent = UPH_ProdQty / planqty * 100;
                if (double.IsNaN(percent) || double.IsInfinity(percent))
                    percent = 0;

                Text_Changed(LBL_Uph_Percent, $"{percent}%");
                Invoke(new MethodInvoker(delegate ()
                {
                    if (percent <= 90)
                        LBL_Uph_Percent.BackColor = Color.Red;
                    else if (percent < 95)
                        LBL_Uph_Percent.BackColor = Color.Yellow;
                    else
                        LBL_Uph_Percent.BackColor = Color.Green;
                }));
                #endregion
                #endregion
            }
            else
            {
                LBL_Uph_Plan.Text = "0";
                LBL_Uph_Prod.Text = (UPH_ProdQty == 0) ? "0" : string.Format("{0:#,###}", UPH_ProdQty);
            }
        }
        #endregion
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
