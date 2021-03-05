using System.Drawing;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;

namespace EATON_MONITOR_55
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_Timer = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel34 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel38 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panel42 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.Cir_Per_4 = new EATON_MONITOR_55.Circle();
            this.label19 = new System.Windows.Forms.Label();
            this.Cir_Per_3 = new EATON_MONITOR_55.Circle();
            this.label18 = new System.Windows.Forms.Label();
            this.Cir_Spl = new EATON_MONITOR_55.Circle();
            this.label17 = new System.Windows.Forms.Label();
            this.Cir_Per_2 = new EATON_MONITOR_55.Circle();
            this.Cir_Per_1 = new EATON_MONITOR_55.Circle();
            this.label16 = new System.Windows.Forms.Label();
            this.Cir_Link = new EATON_MONITOR_55.Circle();
            this.label15 = new System.Windows.Forms.Label();
            this.Cir_Laser = new EATON_MONITOR_55.Circle();
            this.label14 = new System.Windows.Forms.Label();
            this.Cir_Plug = new EATON_MONITOR_55.Circle();
            this.label13 = new System.Windows.Forms.Label();
            this.PB_Img = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panel50 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel51 = new System.Windows.Forms.Panel();
            this.LBL_Uph_Plan = new System.Windows.Forms.Label();
            this.panel52 = new System.Windows.Forms.Panel();
            this.LBL_Uph_Prod = new System.Windows.Forms.Label();
            this.panel53 = new System.Windows.Forms.Panel();
            this.LBL_Uph_Percent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.LBL_Spl_Plan = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.LBL_Spl_Prod = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.LBL_Spl_Mode = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2424 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label2322 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label2525 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.LBL_Link_Plan = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.LBL_Link_Prod = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.LBL_Link_Mode = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.LBL_Per_Plan = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.LBL_Per_Prod = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.LBL_Per_Mode = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.LBL_Total_Plan = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.LBL_Total_Prod = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.LBL_Total_Percent = new System.Windows.Forms.Label();
            this.panel43 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel44 = new System.Windows.Forms.Panel();
            this.LBL_Spl_Bad = new System.Windows.Forms.Label();
            this.panel45 = new System.Windows.Forms.Panel();
            this.LBL_Scan_Fail = new System.Windows.Forms.Label();
            this.panel46 = new System.Windows.Forms.Panel();
            this.LBL_Link_Bad = new System.Windows.Forms.Label();
            this.panel47 = new System.Windows.Forms.Panel();
            this.LBL_Per_Bad = new System.Windows.Forms.Label();
            this.panel48 = new System.Windows.Forms.Panel();
            this.LBL_Total_Bad = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.LBL_Plug_Plan = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.LBL_Plug_Prod = new System.Windows.Forms.Label();
            this.panel49 = new System.Windows.Forms.Panel();
            this.LBL_Plug_Bad = new System.Windows.Forms.Label();
            this.panel54 = new System.Windows.Forms.Panel();
            this.LBL_Plug_Mode = new System.Windows.Forms.Label();
            this.Timer_Change_Timer = new System.Windows.Forms.Timer(this.components);
            this.Img_Change_Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel32.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel33.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel35.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel37.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel39.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel42.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Img)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel53.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel44.SuspendLayout();
            this.panel45.SuspendLayout();
            this.panel46.SuspendLayout();
            this.panel47.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel54.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1916, 1076);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel1.Size = new System.Drawing.Size(1341, 193);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(98)))), ((int)(((byte)(114)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("HY견고딕", 52F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1341, 192);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joystick Line 설비 가동현황 모니터링";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LBL_Timer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1341, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel2.Size = new System.Drawing.Size(575, 193);
            this.panel2.TabIndex = 1;
            // 
            // LBL_Timer
            // 
            this.LBL_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(98)))), ((int)(((byte)(114)))));
            this.LBL_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Timer.Font = new System.Drawing.Font("HY견고딕", 30F);
            this.LBL_Timer.ForeColor = System.Drawing.Color.White;
            this.LBL_Timer.Location = new System.Drawing.Point(0, 0);
            this.LBL_Timer.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Timer.Name = "LBL_Timer";
            this.LBL_Timer.Size = new System.Drawing.Size(575, 192);
            this.LBL_Timer.TabIndex = 1;
            this.LBL_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Timer.Click += new System.EventHandler(this.LBL_Timer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.Cir_Per_4);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.Cir_Per_3);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.Cir_Spl);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.Cir_Per_2);
            this.panel4.Controls.Add(this.Cir_Per_1);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.Cir_Link);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.Cir_Laser);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.Cir_Plug);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.PB_Img);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 193);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.panel4.Size = new System.Drawing.Size(1341, 883);
            this.panel4.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel32, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1100, 21);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(221, 322);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // panel32
            // 
            this.panel32.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel32.Controls.Add(this.label20);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel32.Location = new System.Drawing.Point(4, 4);
            this.panel32.Margin = new System.Windows.Forms.Padding(0);
            this.panel32.Name = "panel32";
            this.panel32.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel32.Size = new System.Drawing.Size(213, 52);
            this.panel32.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(213, 50);
            this.label20.TabIndex = 0;
            this.label20.Text = "설비 가동상태";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel33, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel34, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 56);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(213, 52);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel33
            // 
            this.panel33.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel33.Controls.Add(this.label21);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(0, 0);
            this.panel33.Margin = new System.Windows.Forms.Padding(0);
            this.panel33.Name = "panel33";
            this.panel33.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.panel33.Size = new System.Drawing.Size(106, 52);
            this.panel33.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(0, 2);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 48);
            this.label21.TabIndex = 1;
            this.label21.Text = "가동중";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel34
            // 
            this.panel34.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel34.BackColor = System.Drawing.Color.Black;
            this.panel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(106, 0);
            this.panel34.Margin = new System.Windows.Forms.Padding(0);
            this.panel34.Name = "panel34";
            this.panel34.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panel34.Size = new System.Drawing.Size(107, 52);
            this.panel34.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel35, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel36, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 108);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(213, 52);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // panel35
            // 
            this.panel35.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel35.Controls.Add(this.label22);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel35.Location = new System.Drawing.Point(0, 0);
            this.panel35.Margin = new System.Windows.Forms.Padding(0);
            this.panel35.Name = "panel35";
            this.panel35.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.panel35.Size = new System.Drawing.Size(106, 52);
            this.panel35.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(0, 2);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 48);
            this.label22.TabIndex = 2;
            this.label22.Text = "대기중";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel36
            // 
            this.panel36.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel36.Location = new System.Drawing.Point(106, 0);
            this.panel36.Margin = new System.Windows.Forms.Padding(0);
            this.panel36.Name = "panel36";
            this.panel36.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panel36.Size = new System.Drawing.Size(107, 52);
            this.panel36.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel37, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel38, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 160);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(213, 52);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // panel37
            // 
            this.panel37.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel37.Controls.Add(this.label23);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel37.Location = new System.Drawing.Point(0, 0);
            this.panel37.Margin = new System.Windows.Forms.Padding(0);
            this.panel37.Name = "panel37";
            this.panel37.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.panel37.Size = new System.Drawing.Size(106, 52);
            this.panel37.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(0, 2);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 48);
            this.label23.TabIndex = 2;
            this.label23.Text = "설비이상";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel38
            // 
            this.panel38.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel38.Location = new System.Drawing.Point(106, 0);
            this.panel38.Margin = new System.Windows.Forms.Padding(0);
            this.panel38.Name = "panel38";
            this.panel38.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panel38.Size = new System.Drawing.Size(107, 52);
            this.panel38.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.panel39, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel40, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 212);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(213, 52);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // panel39
            // 
            this.panel39.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel39.Controls.Add(this.label24);
            this.panel39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel39.Location = new System.Drawing.Point(0, 0);
            this.panel39.Margin = new System.Windows.Forms.Padding(0);
            this.panel39.Name = "panel39";
            this.panel39.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.panel39.Size = new System.Drawing.Size(106, 52);
            this.panel39.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(0, 2);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 48);
            this.label24.TabIndex = 2;
            this.label24.Text = "품질이상";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel40
            // 
            this.panel40.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel40.Location = new System.Drawing.Point(106, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(0);
            this.panel40.Name = "panel40";
            this.panel40.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panel40.Size = new System.Drawing.Size(107, 52);
            this.panel40.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.panel41, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel42, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 264);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(213, 54);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // panel41
            // 
            this.panel41.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel41.Controls.Add(this.label25);
            this.panel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel41.Location = new System.Drawing.Point(0, 0);
            this.panel41.Margin = new System.Windows.Forms.Padding(0);
            this.panel41.Name = "panel41";
            this.panel41.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.panel41.Size = new System.Drawing.Size(106, 54);
            this.panel41.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(0, 2);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 52);
            this.label25.TabIndex = 2;
            this.label25.Text = "운전모드";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel42
            // 
            this.panel42.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel42.Controls.Add(this.label26);
            this.panel42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel42.Location = new System.Drawing.Point(106, 0);
            this.panel42.Margin = new System.Windows.Forms.Padding(0);
            this.panel42.Name = "panel42";
            this.panel42.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.panel42.Size = new System.Drawing.Size(107, 54);
            this.panel42.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(119)))), ((int)(((byte)(175)))));
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("HY견고딕", 14F);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(2, 2);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 52);
            this.label26.TabIndex = 3;
            this.label26.Text = "자동/수동";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cir_Per_4
            // 
            this.Cir_Per_4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Per_4.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Per_4.Location = new System.Drawing.Point(777, 571);
            this.Cir_Per_4.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Per_4.Name = "Cir_Per_4";
            this.Cir_Per_4.Size = new System.Drawing.Size(80, 50);
            this.Cir_Per_4.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(722, 621);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(191, 53);
            this.label19.TabIndex = 15;
            this.label19.Text = "수동 성능 TEST\r\n(#4)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cir_Per_3
            // 
            this.Cir_Per_3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Per_3.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Per_3.Location = new System.Drawing.Point(691, 459);
            this.Cir_Per_3.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Per_3.Name = "Cir_Per_3";
            this.Cir_Per_3.Size = new System.Drawing.Size(80, 50);
            this.Cir_Per_3.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(636, 509);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(191, 53);
            this.label18.TabIndex = 13;
            this.label18.Text = "수동 성능 TEST\r\n(#3)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cir_Spl
            // 
            this.Cir_Spl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Spl.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Spl.Location = new System.Drawing.Point(348, 786);
            this.Cir_Spl.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Spl.Name = "Cir_Spl";
            this.Cir_Spl.Size = new System.Drawing.Size(80, 50);
            this.Cir_Spl.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(323, 836);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 42);
            this.label17.TabIndex = 11;
            this.label17.Text = "스플킷 조립";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cir_Per_2
            // 
            this.Cir_Per_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Per_2.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Per_2.Location = new System.Drawing.Point(864, 21);
            this.Cir_Per_2.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Per_2.Name = "Cir_Per_2";
            this.Cir_Per_2.Size = new System.Drawing.Size(80, 50);
            this.Cir_Per_2.TabIndex = 9;
            // 
            // Cir_Per_1
            // 
            this.Cir_Per_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Per_1.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Per_1.Location = new System.Drawing.Point(737, 21);
            this.Cir_Per_1.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Per_1.Name = "Cir_Per_1";
            this.Cir_Per_1.Size = new System.Drawing.Size(80, 50);
            this.Cir_Per_1.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("HY견고딕", 18F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(711, 71);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 58);
            this.label16.TabIndex = 8;
            this.label16.Text = "자동 성능 TEST\r\n(#1, #2)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cir_Link
            // 
            this.Cir_Link.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Link.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Link.Location = new System.Drawing.Point(473, 79);
            this.Cir_Link.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Link.Name = "Cir_Link";
            this.Cir_Link.Size = new System.Drawing.Size(80, 50);
            this.Cir_Link.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(448, 129);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 42);
            this.label15.TabIndex = 6;
            this.label15.Text = "리크 TEST";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cir_Laser
            // 
            this.Cir_Laser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Laser.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Laser.Location = new System.Drawing.Point(282, 79);
            this.Cir_Laser.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Laser.Name = "Cir_Laser";
            this.Cir_Laser.Size = new System.Drawing.Size(80, 50);
            this.Cir_Laser.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(257, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 42);
            this.label14.TabIndex = 4;
            this.label14.Text = "레이저 마킹";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cir_Plug
            // 
            this.Cir_Plug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cir_Plug.BackColor = System.Drawing.Color.DimGray;
            this.Cir_Plug.Location = new System.Drawing.Point(82, 79);
            this.Cir_Plug.Margin = new System.Windows.Forms.Padding(0);
            this.Cir_Plug.Name = "Cir_Plug";
            this.Cir_Plug.Size = new System.Drawing.Size(80, 50);
            this.Cir_Plug.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(57, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 42);
            this.label13.TabIndex = 2;
            this.label13.Text = "플러그 조립";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Img
            // 
            this.PB_Img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Img.Image = global::EATON_MONITOR_55.Properties.Resources.STOP;
            this.PB_Img.Location = new System.Drawing.Point(0, 1);
            this.PB_Img.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Img.Name = "PB_Img";
            this.PB_Img.Size = new System.Drawing.Size(1340, 882);
            this.PB_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Img.TabIndex = 0;
            this.PB_Img.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1341, 193);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(575, 883);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel9.Controls.Add(this.panel50, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel51, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel52, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel53, 3, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 759);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(575, 124);
            this.tableLayoutPanel9.TabIndex = 17;
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.label12);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel50.Location = new System.Drawing.Point(0, 0);
            this.panel50.Margin = new System.Windows.Forms.Padding(0);
            this.panel50.Name = "panel50";
            this.panel50.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panel50.Size = new System.Drawing.Size(172, 124);
            this.panel50.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("HY견고딕", 18F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 1);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 123);
            this.label12.TabIndex = 2;
            this.label12.Text = "시간당생산성\r\n(UPH, %)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.LBL_Uph_Plan);
            this.panel51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel51.Location = new System.Drawing.Point(172, 0);
            this.panel51.Margin = new System.Windows.Forms.Padding(0);
            this.panel51.Name = "panel51";
            this.panel51.Padding = new System.Windows.Forms.Padding(2, 1, 0, 0);
            this.panel51.Size = new System.Drawing.Size(100, 124);
            this.panel51.TabIndex = 1;
            // 
            // LBL_Uph_Plan
            // 
            this.LBL_Uph_Plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.LBL_Uph_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Uph_Plan.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Uph_Plan.ForeColor = System.Drawing.Color.White;
            this.LBL_Uph_Plan.Location = new System.Drawing.Point(2, 1);
            this.LBL_Uph_Plan.Name = "LBL_Uph_Plan";
            this.LBL_Uph_Plan.Size = new System.Drawing.Size(98, 123);
            this.LBL_Uph_Plan.TabIndex = 3;
            this.LBL_Uph_Plan.Text = "0";
            this.LBL_Uph_Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Uph_Plan.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.LBL_Uph_Prod);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel52.Location = new System.Drawing.Point(272, 0);
            this.panel52.Margin = new System.Windows.Forms.Padding(0);
            this.panel52.Name = "panel52";
            this.panel52.Padding = new System.Windows.Forms.Padding(2, 1, 0, 0);
            this.panel52.Size = new System.Drawing.Size(100, 124);
            this.panel52.TabIndex = 2;
            // 
            // LBL_Uph_Prod
            // 
            this.LBL_Uph_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.LBL_Uph_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Uph_Prod.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Uph_Prod.ForeColor = System.Drawing.Color.White;
            this.LBL_Uph_Prod.Location = new System.Drawing.Point(2, 1);
            this.LBL_Uph_Prod.Name = "LBL_Uph_Prod";
            this.LBL_Uph_Prod.Size = new System.Drawing.Size(98, 123);
            this.LBL_Uph_Prod.TabIndex = 4;
            this.LBL_Uph_Prod.Text = "0";
            this.LBL_Uph_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Uph_Prod.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.LBL_Uph_Percent);
            this.panel53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel53.Location = new System.Drawing.Point(372, 0);
            this.panel53.Margin = new System.Windows.Forms.Padding(0);
            this.panel53.Name = "panel53";
            this.panel53.Padding = new System.Windows.Forms.Padding(2, 1, 0, 0);
            this.panel53.Size = new System.Drawing.Size(203, 124);
            this.panel53.TabIndex = 3;
            // 
            // LBL_Uph_Percent
            // 
            this.LBL_Uph_Percent.BackColor = System.Drawing.Color.Red;
            this.LBL_Uph_Percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Uph_Percent.Font = new System.Drawing.Font("HY견고딕", 36F);
            this.LBL_Uph_Percent.ForeColor = System.Drawing.Color.White;
            this.LBL_Uph_Percent.Location = new System.Drawing.Point(2, 1);
            this.LBL_Uph_Percent.Name = "LBL_Uph_Percent";
            this.LBL_Uph_Percent.Size = new System.Drawing.Size(201, 123);
            this.LBL_Uph_Percent.TabIndex = 5;
            this.LBL_Uph_Percent.Text = "0%";
            this.LBL_Uph_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Uph_Percent.TextChanged += new System.EventHandler(this.LBL_Uph_Percent_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.panel3.Size = new System.Drawing.Size(575, 759);
            this.panel3.TabIndex = 3;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 5;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.00209F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49948F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49948F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49948F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.49948F));
            this.tableLayoutPanel10.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.panel11, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.panel12, 4, 1);
            this.tableLayoutPanel10.Controls.Add(this.panel13, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.panel14, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.panel15, 2, 3);
            this.tableLayoutPanel10.Controls.Add(this.panel16, 4, 3);
            this.tableLayoutPanel10.Controls.Add(this.panel17, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.panel18, 1, 4);
            this.tableLayoutPanel10.Controls.Add(this.panel19, 2, 4);
            this.tableLayoutPanel10.Controls.Add(this.panel20, 4, 4);
            this.tableLayoutPanel10.Controls.Add(this.panel21, 0, 5);
            this.tableLayoutPanel10.Controls.Add(this.panel22, 1, 5);
            this.tableLayoutPanel10.Controls.Add(this.panel23, 2, 5);
            this.tableLayoutPanel10.Controls.Add(this.panel24, 4, 5);
            this.tableLayoutPanel10.Controls.Add(this.panel25, 0, 6);
            this.tableLayoutPanel10.Controls.Add(this.panel26, 1, 6);
            this.tableLayoutPanel10.Controls.Add(this.panel27, 2, 6);
            this.tableLayoutPanel10.Controls.Add(this.panel28, 4, 6);
            this.tableLayoutPanel10.Controls.Add(this.panel43, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel44, 3, 1);
            this.tableLayoutPanel10.Controls.Add(this.panel45, 3, 3);
            this.tableLayoutPanel10.Controls.Add(this.panel46, 3, 4);
            this.tableLayoutPanel10.Controls.Add(this.panel47, 3, 5);
            this.tableLayoutPanel10.Controls.Add(this.panel48, 3, 6);
            this.tableLayoutPanel10.Controls.Add(this.panel29, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.panel30, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.panel31, 2, 2);
            this.tableLayoutPanel10.Controls.Add(this.panel49, 3, 2);
            this.tableLayoutPanel10.Controls.Add(this.panel54, 4, 2);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 7;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(574, 758);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.panel5.Size = new System.Drawing.Size(172, 75);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("HY견고딕", 26F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 74);
            this.label3.TabIndex = 0;
            this.label3.Text = "공정명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(172, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panel6.Size = new System.Drawing.Size(100, 75);
            this.panel6.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("HY견고딕", 26F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 74);
            this.label4.TabIndex = 1;
            this.label4.Text = "계획";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(272, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panel7.Size = new System.Drawing.Size(100, 75);
            this.panel7.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("HY견고딕", 26F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 74);
            this.label5.TabIndex = 1;
            this.label5.Text = "실적";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(472, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.panel8.Size = new System.Drawing.Size(102, 75);
            this.panel8.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("HY견고딕", 16F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 74);
            this.label6.TabIndex = 1;
            this.label6.Text = "운전모드";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 75);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel9.Size = new System.Drawing.Size(172, 113);
            this.panel9.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 111);
            this.label7.TabIndex = 1;
            this.label7.Text = "스플킷 조립";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.LBL_Spl_Plan);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(172, 75);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(1);
            this.panel10.Size = new System.Drawing.Size(100, 113);
            this.panel10.TabIndex = 5;
            // 
            // LBL_Spl_Plan
            // 
            this.LBL_Spl_Plan.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Spl_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Spl_Plan.Font = new System.Drawing.Font("HY견고딕", 50F);
            this.LBL_Spl_Plan.ForeColor = System.Drawing.Color.White;
            this.LBL_Spl_Plan.Location = new System.Drawing.Point(1, 1);
            this.LBL_Spl_Plan.Name = "LBL_Spl_Plan";
            this.LBL_Spl_Plan.Size = new System.Drawing.Size(98, 111);
            this.LBL_Spl_Plan.TabIndex = 2;
            this.LBL_Spl_Plan.Text = "-";
            this.LBL_Spl_Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.LBL_Spl_Prod);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(272, 75);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(1);
            this.panel11.Size = new System.Drawing.Size(100, 113);
            this.panel11.TabIndex = 6;
            // 
            // LBL_Spl_Prod
            // 
            this.LBL_Spl_Prod.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Spl_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Spl_Prod.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Spl_Prod.ForeColor = System.Drawing.Color.White;
            this.LBL_Spl_Prod.Location = new System.Drawing.Point(1, 1);
            this.LBL_Spl_Prod.Name = "LBL_Spl_Prod";
            this.LBL_Spl_Prod.Size = new System.Drawing.Size(98, 111);
            this.LBL_Spl_Prod.TabIndex = 3;
            this.LBL_Spl_Prod.Text = "0";
            this.LBL_Spl_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Spl_Prod.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.LBL_Spl_Mode);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(472, 75);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panel12.Size = new System.Drawing.Size(102, 113);
            this.panel12.TabIndex = 7;
            // 
            // LBL_Spl_Mode
            // 
            this.LBL_Spl_Mode.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Spl_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Spl_Mode.Font = new System.Drawing.Font("HY견고딕", 28F);
            this.LBL_Spl_Mode.ForeColor = System.Drawing.Color.White;
            this.LBL_Spl_Mode.Location = new System.Drawing.Point(1, 1);
            this.LBL_Spl_Mode.Name = "LBL_Spl_Mode";
            this.LBL_Spl_Mode.Size = new System.Drawing.Size(101, 111);
            this.LBL_Spl_Mode.TabIndex = 4;
            this.LBL_Spl_Mode.Text = "자동";
            this.LBL_Spl_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label8);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 301);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel13.Size = new System.Drawing.Size(172, 113);
            this.panel13.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 111);
            this.label8.TabIndex = 1;
            this.label8.Text = "스캔실패";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label2424);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(172, 301);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(1);
            this.panel14.Size = new System.Drawing.Size(100, 113);
            this.panel14.TabIndex = 9;
            // 
            // label2424
            // 
            this.label2424.BackColor = System.Drawing.Color.SteelBlue;
            this.label2424.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2424.Font = new System.Drawing.Font("HY견고딕", 50F);
            this.label2424.ForeColor = System.Drawing.Color.White;
            this.label2424.Location = new System.Drawing.Point(1, 1);
            this.label2424.Name = "label2424";
            this.label2424.Size = new System.Drawing.Size(98, 111);
            this.label2424.TabIndex = 2;
            this.label2424.Text = "-";
            this.label2424.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label2322);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(272, 301);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(1);
            this.panel15.Size = new System.Drawing.Size(100, 113);
            this.panel15.TabIndex = 10;
            // 
            // label2322
            // 
            this.label2322.BackColor = System.Drawing.Color.SteelBlue;
            this.label2322.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2322.Font = new System.Drawing.Font("HY견고딕", 50F);
            this.label2322.ForeColor = System.Drawing.Color.White;
            this.label2322.Location = new System.Drawing.Point(1, 1);
            this.label2322.Name = "label2322";
            this.label2322.Size = new System.Drawing.Size(98, 111);
            this.label2322.TabIndex = 3;
            this.label2322.Text = "-";
            this.label2322.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label2525);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(472, 301);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panel16.Size = new System.Drawing.Size(102, 113);
            this.panel16.TabIndex = 11;
            // 
            // label2525
            // 
            this.label2525.BackColor = System.Drawing.Color.SteelBlue;
            this.label2525.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2525.Font = new System.Drawing.Font("HY견고딕", 50F);
            this.label2525.ForeColor = System.Drawing.Color.White;
            this.label2525.Location = new System.Drawing.Point(1, 1);
            this.label2525.Name = "label2525";
            this.label2525.Size = new System.Drawing.Size(101, 111);
            this.label2525.TabIndex = 4;
            this.label2525.Text = "-";
            this.label2525.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label9);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 414);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel17.Size = new System.Drawing.Size(172, 113);
            this.panel17.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 111);
            this.label9.TabIndex = 1;
            this.label9.Text = "리크 TEST";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.LBL_Link_Plan);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(172, 414);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(1);
            this.panel18.Size = new System.Drawing.Size(100, 113);
            this.panel18.TabIndex = 13;
            // 
            // LBL_Link_Plan
            // 
            this.LBL_Link_Plan.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Link_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Link_Plan.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Link_Plan.ForeColor = System.Drawing.Color.White;
            this.LBL_Link_Plan.Location = new System.Drawing.Point(1, 1);
            this.LBL_Link_Plan.Name = "LBL_Link_Plan";
            this.LBL_Link_Plan.Size = new System.Drawing.Size(98, 111);
            this.LBL_Link_Plan.TabIndex = 2;
            this.LBL_Link_Plan.Text = "0";
            this.LBL_Link_Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Link_Plan.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.LBL_Link_Prod);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(272, 414);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(1);
            this.panel19.Size = new System.Drawing.Size(100, 113);
            this.panel19.TabIndex = 14;
            // 
            // LBL_Link_Prod
            // 
            this.LBL_Link_Prod.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Link_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Link_Prod.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Link_Prod.ForeColor = System.Drawing.Color.White;
            this.LBL_Link_Prod.Location = new System.Drawing.Point(1, 1);
            this.LBL_Link_Prod.Name = "LBL_Link_Prod";
            this.LBL_Link_Prod.Size = new System.Drawing.Size(98, 111);
            this.LBL_Link_Prod.TabIndex = 3;
            this.LBL_Link_Prod.Text = "0";
            this.LBL_Link_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Link_Prod.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.LBL_Link_Mode);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(472, 414);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panel20.Size = new System.Drawing.Size(102, 113);
            this.panel20.TabIndex = 15;
            // 
            // LBL_Link_Mode
            // 
            this.LBL_Link_Mode.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Link_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Link_Mode.Font = new System.Drawing.Font("HY견고딕", 28F);
            this.LBL_Link_Mode.ForeColor = System.Drawing.Color.White;
            this.LBL_Link_Mode.Location = new System.Drawing.Point(1, 1);
            this.LBL_Link_Mode.Name = "LBL_Link_Mode";
            this.LBL_Link_Mode.Size = new System.Drawing.Size(101, 111);
            this.LBL_Link_Mode.TabIndex = 4;
            this.LBL_Link_Mode.Text = "자동";
            this.LBL_Link_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label10);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(0, 527);
            this.panel21.Margin = new System.Windows.Forms.Padding(0);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel21.Size = new System.Drawing.Size(172, 113);
            this.panel21.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 111);
            this.label10.TabIndex = 1;
            this.label10.Text = "성능 TEST";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.LBL_Per_Plan);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(172, 527);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Padding = new System.Windows.Forms.Padding(1);
            this.panel22.Size = new System.Drawing.Size(100, 113);
            this.panel22.TabIndex = 17;
            // 
            // LBL_Per_Plan
            // 
            this.LBL_Per_Plan.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Per_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Per_Plan.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Per_Plan.ForeColor = System.Drawing.Color.White;
            this.LBL_Per_Plan.Location = new System.Drawing.Point(1, 1);
            this.LBL_Per_Plan.Name = "LBL_Per_Plan";
            this.LBL_Per_Plan.Size = new System.Drawing.Size(98, 111);
            this.LBL_Per_Plan.TabIndex = 2;
            this.LBL_Per_Plan.Text = "0";
            this.LBL_Per_Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Per_Plan.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.LBL_Per_Prod);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(272, 527);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Padding = new System.Windows.Forms.Padding(1);
            this.panel23.Size = new System.Drawing.Size(100, 113);
            this.panel23.TabIndex = 18;
            // 
            // LBL_Per_Prod
            // 
            this.LBL_Per_Prod.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Per_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Per_Prod.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Per_Prod.ForeColor = System.Drawing.Color.White;
            this.LBL_Per_Prod.Location = new System.Drawing.Point(1, 1);
            this.LBL_Per_Prod.Name = "LBL_Per_Prod";
            this.LBL_Per_Prod.Size = new System.Drawing.Size(98, 111);
            this.LBL_Per_Prod.TabIndex = 3;
            this.LBL_Per_Prod.Text = "0";
            this.LBL_Per_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Per_Prod.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.LBL_Per_Mode);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(472, 527);
            this.panel24.Margin = new System.Windows.Forms.Padding(0);
            this.panel24.Name = "panel24";
            this.panel24.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panel24.Size = new System.Drawing.Size(102, 113);
            this.panel24.TabIndex = 19;
            // 
            // LBL_Per_Mode
            // 
            this.LBL_Per_Mode.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Per_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Per_Mode.Font = new System.Drawing.Font("HY견고딕", 28F);
            this.LBL_Per_Mode.ForeColor = System.Drawing.Color.White;
            this.LBL_Per_Mode.Location = new System.Drawing.Point(1, 1);
            this.LBL_Per_Mode.Name = "LBL_Per_Mode";
            this.LBL_Per_Mode.Size = new System.Drawing.Size(101, 111);
            this.LBL_Per_Mode.TabIndex = 4;
            this.LBL_Per_Mode.Text = "자동";
            this.LBL_Per_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.label11);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(0, 640);
            this.panel25.Margin = new System.Windows.Forms.Padding(0);
            this.panel25.Name = "panel25";
            this.panel25.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel25.Size = new System.Drawing.Size(172, 118);
            this.panel25.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 116);
            this.label11.TabIndex = 1;
            this.label11.Text = "당일실적 계";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.LBL_Total_Plan);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(172, 640);
            this.panel26.Margin = new System.Windows.Forms.Padding(0);
            this.panel26.Name = "panel26";
            this.panel26.Padding = new System.Windows.Forms.Padding(1);
            this.panel26.Size = new System.Drawing.Size(100, 118);
            this.panel26.TabIndex = 21;
            // 
            // LBL_Total_Plan
            // 
            this.LBL_Total_Plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.LBL_Total_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Total_Plan.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Total_Plan.ForeColor = System.Drawing.Color.White;
            this.LBL_Total_Plan.Location = new System.Drawing.Point(1, 1);
            this.LBL_Total_Plan.Name = "LBL_Total_Plan";
            this.LBL_Total_Plan.Size = new System.Drawing.Size(98, 116);
            this.LBL_Total_Plan.TabIndex = 2;
            this.LBL_Total_Plan.Text = "0";
            this.LBL_Total_Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Total_Plan.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.LBL_Total_Prod);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(272, 640);
            this.panel27.Margin = new System.Windows.Forms.Padding(0);
            this.panel27.Name = "panel27";
            this.panel27.Padding = new System.Windows.Forms.Padding(1);
            this.panel27.Size = new System.Drawing.Size(100, 118);
            this.panel27.TabIndex = 22;
            // 
            // LBL_Total_Prod
            // 
            this.LBL_Total_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.LBL_Total_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Total_Prod.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Total_Prod.ForeColor = System.Drawing.Color.White;
            this.LBL_Total_Prod.Location = new System.Drawing.Point(1, 1);
            this.LBL_Total_Prod.Name = "LBL_Total_Prod";
            this.LBL_Total_Prod.Size = new System.Drawing.Size(98, 116);
            this.LBL_Total_Prod.TabIndex = 3;
            this.LBL_Total_Prod.Text = "0";
            this.LBL_Total_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Total_Prod.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.LBL_Total_Percent);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(472, 640);
            this.panel28.Margin = new System.Windows.Forms.Padding(0);
            this.panel28.Name = "panel28";
            this.panel28.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panel28.Size = new System.Drawing.Size(102, 118);
            this.panel28.TabIndex = 23;
            // 
            // LBL_Total_Percent
            // 
            this.LBL_Total_Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.LBL_Total_Percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Total_Percent.Font = new System.Drawing.Font("HY견고딕", 36F);
            this.LBL_Total_Percent.ForeColor = System.Drawing.Color.White;
            this.LBL_Total_Percent.Location = new System.Drawing.Point(1, 1);
            this.LBL_Total_Percent.Name = "LBL_Total_Percent";
            this.LBL_Total_Percent.Size = new System.Drawing.Size(101, 116);
            this.LBL_Total_Percent.TabIndex = 4;
            this.LBL_Total_Percent.Text = "0%";
            this.LBL_Total_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Total_Percent.TextChanged += new System.EventHandler(this.LBL_Percent_TextChanged);
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.label2);
            this.panel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel43.Location = new System.Drawing.Point(372, 0);
            this.panel43.Margin = new System.Windows.Forms.Padding(0);
            this.panel43.Name = "panel43";
            this.panel43.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panel43.Size = new System.Drawing.Size(100, 75);
            this.panel43.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("HY견고딕", 26F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 74);
            this.label2.TabIndex = 2;
            this.label2.Text = "불량";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.LBL_Spl_Bad);
            this.panel44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel44.Location = new System.Drawing.Point(372, 75);
            this.panel44.Margin = new System.Windows.Forms.Padding(0);
            this.panel44.Name = "panel44";
            this.panel44.Padding = new System.Windows.Forms.Padding(1);
            this.panel44.Size = new System.Drawing.Size(100, 113);
            this.panel44.TabIndex = 29;
            // 
            // LBL_Spl_Bad
            // 
            this.LBL_Spl_Bad.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Spl_Bad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Spl_Bad.Font = new System.Drawing.Font("HY견고딕", 50F);
            this.LBL_Spl_Bad.ForeColor = System.Drawing.Color.White;
            this.LBL_Spl_Bad.Location = new System.Drawing.Point(1, 1);
            this.LBL_Spl_Bad.Name = "LBL_Spl_Bad";
            this.LBL_Spl_Bad.Size = new System.Drawing.Size(98, 111);
            this.LBL_Spl_Bad.TabIndex = 4;
            this.LBL_Spl_Bad.Text = "-";
            this.LBL_Spl_Bad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel45
            // 
            this.panel45.Controls.Add(this.LBL_Scan_Fail);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel45.Location = new System.Drawing.Point(372, 301);
            this.panel45.Margin = new System.Windows.Forms.Padding(0);
            this.panel45.Name = "panel45";
            this.panel45.Padding = new System.Windows.Forms.Padding(1);
            this.panel45.Size = new System.Drawing.Size(100, 113);
            this.panel45.TabIndex = 30;
            // 
            // LBL_Scan_Fail
            // 
            this.LBL_Scan_Fail.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Scan_Fail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Scan_Fail.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Scan_Fail.ForeColor = System.Drawing.Color.White;
            this.LBL_Scan_Fail.Location = new System.Drawing.Point(1, 1);
            this.LBL_Scan_Fail.Name = "LBL_Scan_Fail";
            this.LBL_Scan_Fail.Size = new System.Drawing.Size(98, 111);
            this.LBL_Scan_Fail.TabIndex = 4;
            this.LBL_Scan_Fail.Text = "0";
            this.LBL_Scan_Fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Scan_Fail.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel46
            // 
            this.panel46.Controls.Add(this.LBL_Link_Bad);
            this.panel46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel46.Location = new System.Drawing.Point(372, 414);
            this.panel46.Margin = new System.Windows.Forms.Padding(0);
            this.panel46.Name = "panel46";
            this.panel46.Padding = new System.Windows.Forms.Padding(1);
            this.panel46.Size = new System.Drawing.Size(100, 113);
            this.panel46.TabIndex = 31;
            // 
            // LBL_Link_Bad
            // 
            this.LBL_Link_Bad.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Link_Bad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Link_Bad.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Link_Bad.ForeColor = System.Drawing.Color.White;
            this.LBL_Link_Bad.Location = new System.Drawing.Point(1, 1);
            this.LBL_Link_Bad.Name = "LBL_Link_Bad";
            this.LBL_Link_Bad.Size = new System.Drawing.Size(98, 111);
            this.LBL_Link_Bad.TabIndex = 4;
            this.LBL_Link_Bad.Text = "0";
            this.LBL_Link_Bad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Link_Bad.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.LBL_Per_Bad);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel47.Location = new System.Drawing.Point(372, 527);
            this.panel47.Margin = new System.Windows.Forms.Padding(0);
            this.panel47.Name = "panel47";
            this.panel47.Padding = new System.Windows.Forms.Padding(1);
            this.panel47.Size = new System.Drawing.Size(100, 113);
            this.panel47.TabIndex = 32;
            // 
            // LBL_Per_Bad
            // 
            this.LBL_Per_Bad.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Per_Bad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Per_Bad.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Per_Bad.ForeColor = System.Drawing.Color.White;
            this.LBL_Per_Bad.Location = new System.Drawing.Point(1, 1);
            this.LBL_Per_Bad.Name = "LBL_Per_Bad";
            this.LBL_Per_Bad.Size = new System.Drawing.Size(98, 111);
            this.LBL_Per_Bad.TabIndex = 4;
            this.LBL_Per_Bad.Text = "0";
            this.LBL_Per_Bad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Per_Bad.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel48
            // 
            this.panel48.Controls.Add(this.LBL_Total_Bad);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel48.Location = new System.Drawing.Point(372, 640);
            this.panel48.Margin = new System.Windows.Forms.Padding(0);
            this.panel48.Name = "panel48";
            this.panel48.Padding = new System.Windows.Forms.Padding(1);
            this.panel48.Size = new System.Drawing.Size(100, 118);
            this.panel48.TabIndex = 33;
            // 
            // LBL_Total_Bad
            // 
            this.LBL_Total_Bad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(115)))));
            this.LBL_Total_Bad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Total_Bad.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Total_Bad.ForeColor = System.Drawing.Color.White;
            this.LBL_Total_Bad.Location = new System.Drawing.Point(1, 1);
            this.LBL_Total_Bad.Name = "LBL_Total_Bad";
            this.LBL_Total_Bad.Size = new System.Drawing.Size(98, 116);
            this.LBL_Total_Bad.TabIndex = 4;
            this.LBL_Total_Bad.Text = "0";
            this.LBL_Total_Bad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Total_Bad.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.label27);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel29.Location = new System.Drawing.Point(0, 188);
            this.panel29.Margin = new System.Windows.Forms.Padding(0);
            this.panel29.Name = "panel29";
            this.panel29.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel29.Size = new System.Drawing.Size(172, 113);
            this.panel29.TabIndex = 34;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.SteelBlue;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("HY견고딕", 20F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(0, 1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(171, 111);
            this.label27.TabIndex = 2;
            this.label27.Text = "플러그조립";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.LBL_Plug_Plan);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(172, 188);
            this.panel30.Margin = new System.Windows.Forms.Padding(0);
            this.panel30.Name = "panel30";
            this.panel30.Padding = new System.Windows.Forms.Padding(1);
            this.panel30.Size = new System.Drawing.Size(100, 113);
            this.panel30.TabIndex = 35;
            // 
            // LBL_Plug_Plan
            // 
            this.LBL_Plug_Plan.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Plug_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Plug_Plan.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Plug_Plan.ForeColor = System.Drawing.Color.White;
            this.LBL_Plug_Plan.Location = new System.Drawing.Point(1, 1);
            this.LBL_Plug_Plan.Name = "LBL_Plug_Plan";
            this.LBL_Plug_Plan.Size = new System.Drawing.Size(98, 111);
            this.LBL_Plug_Plan.TabIndex = 3;
            this.LBL_Plug_Plan.Text = "0";
            this.LBL_Plug_Plan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Plug_Plan.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.LBL_Plug_Prod);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(272, 188);
            this.panel31.Margin = new System.Windows.Forms.Padding(0);
            this.panel31.Name = "panel31";
            this.panel31.Padding = new System.Windows.Forms.Padding(1);
            this.panel31.Size = new System.Drawing.Size(100, 113);
            this.panel31.TabIndex = 36;
            // 
            // LBL_Plug_Prod
            // 
            this.LBL_Plug_Prod.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Plug_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Plug_Prod.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Plug_Prod.ForeColor = System.Drawing.Color.White;
            this.LBL_Plug_Prod.Location = new System.Drawing.Point(1, 1);
            this.LBL_Plug_Prod.Name = "LBL_Plug_Prod";
            this.LBL_Plug_Prod.Size = new System.Drawing.Size(98, 111);
            this.LBL_Plug_Prod.TabIndex = 4;
            this.LBL_Plug_Prod.Text = "0";
            this.LBL_Plug_Prod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Plug_Prod.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.LBL_Plug_Bad);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel49.Location = new System.Drawing.Point(372, 188);
            this.panel49.Margin = new System.Windows.Forms.Padding(0);
            this.panel49.Name = "panel49";
            this.panel49.Padding = new System.Windows.Forms.Padding(1);
            this.panel49.Size = new System.Drawing.Size(100, 113);
            this.panel49.TabIndex = 37;
            // 
            // LBL_Plug_Bad
            // 
            this.LBL_Plug_Bad.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Plug_Bad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Plug_Bad.Font = new System.Drawing.Font("HY견고딕", 38F);
            this.LBL_Plug_Bad.ForeColor = System.Drawing.Color.White;
            this.LBL_Plug_Bad.Location = new System.Drawing.Point(1, 1);
            this.LBL_Plug_Bad.Name = "LBL_Plug_Bad";
            this.LBL_Plug_Bad.Size = new System.Drawing.Size(98, 111);
            this.LBL_Plug_Bad.TabIndex = 5;
            this.LBL_Plug_Bad.Text = "0";
            this.LBL_Plug_Bad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Plug_Bad.TextChanged += new System.EventHandler(this.LBL_Count_TextChanged);
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.LBL_Plug_Mode);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel54.Location = new System.Drawing.Point(472, 188);
            this.panel54.Margin = new System.Windows.Forms.Padding(0);
            this.panel54.Name = "panel54";
            this.panel54.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.panel54.Size = new System.Drawing.Size(102, 113);
            this.panel54.TabIndex = 38;
            // 
            // LBL_Plug_Mode
            // 
            this.LBL_Plug_Mode.BackColor = System.Drawing.Color.SteelBlue;
            this.LBL_Plug_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Plug_Mode.Font = new System.Drawing.Font("HY견고딕", 28F);
            this.LBL_Plug_Mode.ForeColor = System.Drawing.Color.White;
            this.LBL_Plug_Mode.Location = new System.Drawing.Point(1, 1);
            this.LBL_Plug_Mode.Name = "LBL_Plug_Mode";
            this.LBL_Plug_Mode.Size = new System.Drawing.Size(101, 111);
            this.LBL_Plug_Mode.TabIndex = 5;
            this.LBL_Plug_Mode.Text = "자동";
            this.LBL_Plug_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Change_Timer
            // 
            this.Timer_Change_Timer.Enabled = true;
            this.Timer_Change_Timer.Interval = 1000;
            this.Timer_Change_Timer.Tick += new System.EventHandler(this.Timer_Change_Timer_Tick);
            // 
            // Img_Change_Timer
            // 
            this.Img_Change_Timer.Enabled = true;
            this.Img_Change_Timer.Interval = 500;
            this.Img_Change_Timer.Tick += new System.EventHandler(this.Img_Change_Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "MONITOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel42.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Img)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.panel50.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.panel52.ResumeLayout(false);
            this.panel53.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.panel44.ResumeLayout(false);
            this.panel45.ResumeLayout(false);
            this.panel46.ResumeLayout(false);
            this.panel47.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel54.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_Timer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PB_Img;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public Circle Cir_Plug;
        public Circle Cir_Laser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Label label26;
        public Circle Cir_Per_4;
        private System.Windows.Forms.Label label19;
        public Circle Cir_Per_3;
        private System.Windows.Forms.Label label18;
        public Circle Cir_Spl;
        private System.Windows.Forms.Label label17;
        public Circle Cir_Per_2;
        public Circle Cir_Per_1;
        private System.Windows.Forms.Label label16;
        public Circle Cir_Link;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer Timer_Change_Timer;
        private System.Windows.Forms.Timer Img_Change_Timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Panel panel50;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel51;
        public System.Windows.Forms.Label LBL_Uph_Plan;
        private System.Windows.Forms.Panel panel52;
        public System.Windows.Forms.Label LBL_Uph_Prod;
        private System.Windows.Forms.Panel panel53;
        public System.Windows.Forms.Label LBL_Uph_Percent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label LBL_Spl_Plan;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.Label LBL_Spl_Prod;
        private System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.Label LBL_Spl_Mode;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.Label label2424;
        private System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.Label label2322;
        private System.Windows.Forms.Panel panel16;
        public System.Windows.Forms.Label label2525;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel18;
        public System.Windows.Forms.Label LBL_Link_Plan;
        private System.Windows.Forms.Panel panel19;
        public System.Windows.Forms.Label LBL_Link_Prod;
        private System.Windows.Forms.Panel panel20;
        public System.Windows.Forms.Label LBL_Link_Mode;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel22;
        public System.Windows.Forms.Label LBL_Per_Plan;
        private System.Windows.Forms.Panel panel23;
        public System.Windows.Forms.Label LBL_Per_Prod;
        private System.Windows.Forms.Panel panel24;
        public System.Windows.Forms.Label LBL_Per_Mode;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel26;
        public System.Windows.Forms.Label LBL_Total_Plan;
        private System.Windows.Forms.Panel panel27;
        public System.Windows.Forms.Label LBL_Total_Prod;
        private System.Windows.Forms.Panel panel28;
        public System.Windows.Forms.Label LBL_Total_Percent;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel44;
        public System.Windows.Forms.Label LBL_Spl_Bad;
        private System.Windows.Forms.Panel panel45;
        public System.Windows.Forms.Label LBL_Scan_Fail;
        private System.Windows.Forms.Panel panel46;
        public System.Windows.Forms.Label LBL_Link_Bad;
        private System.Windows.Forms.Panel panel47;
        public System.Windows.Forms.Label LBL_Per_Bad;
        private System.Windows.Forms.Panel panel48;
        public System.Windows.Forms.Label LBL_Total_Bad;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel31;
        public System.Windows.Forms.Label LBL_Plug_Prod;
        private System.Windows.Forms.Panel panel49;
        public System.Windows.Forms.Label LBL_Plug_Bad;
        private System.Windows.Forms.Panel panel54;
        public System.Windows.Forms.Label LBL_Plug_Mode;
        public System.Windows.Forms.Label LBL_Plug_Plan;
    }
}

