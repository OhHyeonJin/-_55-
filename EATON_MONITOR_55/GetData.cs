using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using MS_SQL;
using System.Data.SqlClient;

namespace EATON_MONITOR_55
{
    public class GetData
    {
        private readonly MainForm Home;
        private readonly DataBase MES_DB;
        private readonly DataBase POP_DB;

        public GetData(MainForm home)
        {
            Home = home;
            #region DB세팅
            string db_ip = ConfigurationManager.AppSettings["DB_IP"].Trim();                        // DB 접속주소
            string db_mes_catalog = ConfigurationManager.AppSettings["DB_MES_Catalog"].Trim();      // MES 데이터베이스
            string db_pop_catalog = ConfigurationManager.AppSettings["DB_POP_Catalog"].Trim();      // POP 데이터베이스
            string db_id = ConfigurationManager.AppSettings["DB_ID"].Trim();                        // DB 접속 ID
            string db_pw = ConfigurationManager.AppSettings["DB_PW"].Trim();                        // DB 접속 PW
            MES_DB = new DataBase(db_ip, db_mes_catalog, db_id, db_pw, 0, false);
            POP_DB = new DataBase(db_ip, db_pop_catalog, db_id, db_pw, 0, false);
            #endregion
        }

        public void SetData()
        {
            object getobj;  // DB데이터를 받아올 객체

            getobj = MES_DB.Return_Query("EXEC [dbo].[GET_Monitor]", 0);
            #region MES 데이터 ( 계획수량, 실적수량, 불량수량 )
            try
            {
                if (getobj.GetType().Name == "DataTable")
                {
                    int totalbad = 0;
                    foreach (DataRow r in ((DataTable)getobj).Select())
                    {
                        #region DB데이터
                        string str = r["proccd"].ToString().Trim();                                                                                                                     // 공정명
                        string planqty = !(r["planqty"] is DBNull) ? (Convert.ToInt32(r["planqty"]) == 0 ? "0" : string.Format("{0:#,###}", Convert.ToInt32(r["planqty"]))) : "0";      // 계획수량
                        string cnt = !(r["cnt"] is DBNull) ? (Convert.ToInt32(r["cnt"]) == 0 ? "0" : string.Format("{0:#,###}", Convert.ToInt32(r["cnt"]))) : "0";                      // 실적수량
                        string badcnt = !(r["badcnt"] is DBNull) ? (Convert.ToInt32(r["badcnt"]) == 0 ? "0" : string.Format("{0:#,###}", Convert.ToInt32(r["badcnt"]))) : "0";          // 불량수량
                        string percent = $"{r["per"]}%";                                                                                                                                // 퍼센트
                        #endregion
                        #region 불량수량 총합 계산 ( 스플킷 제외 모두 합산 )
                        if (str != "Spool Kit 조립")
                            totalbad += Convert.ToInt32(r["badcnt"]);
                        #endregion
                        #region 데이터바인딩
                        switch (str)
                        {
                            case "Spool Kit 조립":
                                Home.Invoke(new MethodInvoker(delegate ()
                                {
                                    Home.LBL_Spl_Prod.Text = cnt;
                                }));
                                break;

                            case "플러그 조립":
                                Home.Invoke(new MethodInvoker(delegate ()
                                {
                                    Home.LBL_Plug_Plan.Text = planqty;
                                    Home.LBL_Plug_Prod.Text = cnt;
                                    Home.LBL_Plug_Bad.Text = badcnt;
                                }));
                                break;

                            case "리크 TEST":
                                Home.Invoke(new MethodInvoker(delegate ()
                                {
                                    Home.LBL_Link_Plan.Text = planqty;
                                    Home.LBL_Link_Prod.Text = cnt;
                                    Home.LBL_Link_Bad.Text = badcnt;
                                }));
                                break;

                            case "성능 TEST":
                                Home.Invoke(new MethodInvoker(delegate ()
                                {
                                    Home.LBL_Per_Plan.Text = planqty;
                                    Home.LBL_Per_Prod.Text = cnt;
                                    Home.LBL_Per_Bad.Text = badcnt;
                                }));
                                break;

                            case "실적 소계":
                                Home.Invoke(new MethodInvoker(delegate ()
                                {
                                    Home.LBL_Total_Plan.Text = planqty;
                                    Home.LBL_Total_Prod.Text = cnt;
                                    Home.LBL_Total_Percent.Text = percent;
                                    // UPH
                                    Home.LBL_Uph_Plan.Text = (r["uph_planqty"] is DBNull || Convert.ToInt32(r["uph_planqty"]) == 0) ? "0" : string.Format("{0:#,###}", Convert.ToInt32(r["uph_planqty"]));
                                    Home.LBL_Uph_Prod.Text = (r["uph_cnt"] is DBNull || Convert.ToInt32(r["uph_cnt"]) == 0) ? "0" : string.Format("{0:#,###}", Convert.ToInt32(r["uph_cnt"]));
                                    #region UPH 퍼센테이지 산출
                                    int uph_plan = Convert.ToInt32(Home.LBL_Uph_Plan.Text.Replace(",", ""));
                                    int uph_prod = Convert.ToInt32(Home.LBL_Uph_Prod.Text.Replace(",", ""));
                                    double per = Convert.ToDouble(uph_prod) / Convert.ToDouble(uph_plan) * 100;
                                    if (double.IsNaN(per) || double.IsInfinity(per))
                                        Home.LBL_Uph_Percent.Text = "0%";
                                    else
                                    {
                                        per = Percent_Calcurate(per);
                                        Home.LBL_Uph_Percent.Text = $"{per}%";
                                    }
                                    #endregion
                                }));
                                break;
                        }
                        #endregion
                    }
                    #region 총 불량수량 데이터 바인딩
                    string str_allng = totalbad > 0 ? string.Format("{0:#,###}", Convert.ToInt32(totalbad)) : "0";
                    Home.Invoke(new MethodInvoker(delegate ()
                    {
                        Home.LBL_Total_Bad.Text = str_allng;
                    }));
                    #endregion
                }
                #region 예외사항 기록
                else if (getobj.GetType().Name == "Exception")
                    Record.Error(((Exception)getobj).ToString());
                else if (getobj.GetType().Name == "SqlException")
                    Record.Error(((SqlException)getobj).ToString());
                else
                {
                    Home.Invoke(new MethodInvoker(delegate ()
                    {
                        // 스플킷
                        Home.LBL_Spl_Prod.Text = "0";
                        // 플러그
                        Home.LBL_Plug_Plan.Text = "0";
                        Home.LBL_Plug_Prod.Text = "0";
                        Home.LBL_Plug_Bad.Text = "0";
                        // 리크
                        Home.LBL_Link_Plan.Text = "0";
                        Home.LBL_Link_Prod.Text = "0";
                        Home.LBL_Link_Bad.Text = "0";
                        // 성능
                        Home.LBL_Per_Plan.Text = "0";
                        Home.LBL_Per_Prod.Text = "0";
                        Home.LBL_Per_Bad.Text = "0";
                        // 실적소계
                        Home.LBL_Total_Plan.Text = "0";
                        Home.LBL_Total_Prod.Text = "0";
                        Home.LBL_Total_Percent.Text = "0%";
                        Home.LBL_Uph_Plan.Text = "0";
                        Home.LBL_Uph_Prod.Text = "0";
                        Home.LBL_Uph_Percent.Text = "0%";
                    }));
                }
                #endregion
            }
            catch (Exception ex)
            {
                Record.Error(ex.ToString());
            }
            #endregion
            
            getobj = MES_DB.Return_Query($"SELECT * FROM PR210T WHERE (PRODMAC = 'F210003' OR PRODMAC = 'F210004') AND (PROCCD = 'B025' OR PROCCD = 'B045') AND PRODDT = '{DateTime.Now:yyyyMMdd}'", 0);
            #region MES 데이터 ( 스캔실패 수량 )
            try
            {
                if (getobj.GetType().Name == "DataTable")
                {
                    Home.Invoke(new MethodInvoker(delegate ()
                    {
                        string fail_cnt = string.Format("{0:#,###}", ((DataTable)getobj).Rows.Count);
                        Home.LBL_Scan_Fail.Text = fail_cnt;
                    }));
                }
                else
                {
                    Home.Invoke(new MethodInvoker(delegate ()
                    {
                        Home.LBL_Scan_Fail.Text = "0";
                    }));
                }
            }
            catch (Exception ex)
            {
                Record.Error(ex.ToString());
            }
            #endregion

            getobj = POP_DB.Return_Query("SELECT * FROM IOT_POP_STATE", 0);
            #region POP 데이터 ( 설비가동여부, 자동,수동모드 )
            try
            {
                if (getobj.GetType().Name == "DataTable")
                {
                    foreach (DataRow dataRow in ((DataTable)getobj).Select())
                    {
                        #region DB데이터
                        string str = dataRow["PROCCD"].ToString().Trim();               // 공정명
                        char mode = Convert.ToChar(dataRow["STATE"]);                   // 자동,수동모드
                        int state = Convert.ToInt32(dataRow["RUN"]);                    // 설비상태값
                        DateTime dbtime = Convert.ToDateTime(dataRow["REGDT"]);         // DB데이터 입력시간
                        #endregion
                        #region 데이터바인딩 ( 마지막 DB입력시간이 하루 이상 차이난다면 무조건 비가동 처리 )
                        Home.Invoke(new MethodInvoker(delegate ()
                        {
                            switch (str)
                            {
                                case "Spool Kit 조립":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                    {
                                        Home.LBL_Spl_Mode.Text = (mode == 'A') ? "자동" : "수동";
                                        Home.Cir_Spl.Circle_Color_Chagne(WhatColor(state));
                                    }
                                    else
                                    {
                                        Home.LBL_Spl_Mode.Text = "자동";
                                        Home.Cir_Spl.Circle_Color_Chagne(Color.Yellow);
                                    }
                                    break;

                                case "플러그 조립":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                    {
                                        Home.LBL_Plug_Mode.Text = (mode == 'A') ? "자동" : "수동";
                                        Home.Cir_Plug.Circle_Color_Chagne(WhatColor(state));
                                    }
                                    else
                                    {
                                        Home.LBL_Plug_Mode.Text = "자동";
                                        Home.Cir_Plug.Circle_Color_Chagne(Color.Yellow);
                                    }
                                    break;

                                case "레이저 마킹":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                        Home.Cir_Laser.Circle_Color_Chagne(WhatColor(state));
                                    else
                                        Home.Cir_Laser.Circle_Color_Chagne(Color.Yellow);
                                    break;

                                case "리크 TEST":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                    {
                                        Home.LBL_Link_Mode.Text = (mode == 'A') ? "자동" : "수동";
                                        Home.Cir_Link.Circle_Color_Chagne(WhatColor(state));
                                    }
                                    else
                                    {
                                        Home.LBL_Link_Mode.Text = "자동";
                                        Home.Cir_Link.Circle_Color_Chagne(Color.Yellow);
                                    }
                                    break;

                                case "성능 자동 TEST 1":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                    {
                                        Home.LBL_Per_Mode.Text = (mode == 'A') ? "자동" : "수동";
                                        Home.Cir_Per_1.Circle_Color_Chagne(WhatColor(state));
                                    }
                                    else
                                    {
                                        Home.LBL_Per_Mode.Text = "자동";
                                        Home.Cir_Per_1.Circle_Color_Chagne(Color.Yellow);
                                    }
                                    break;

                                case "성능 자동 TEST 2":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                        Home.Cir_Per_2.Circle_Color_Chagne(WhatColor(state));
                                    else
                                        Home.Cir_Per_2.Circle_Color_Chagne(Color.Yellow);
                                    break;

                                case "성능 수동 TEST 1":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                        Home.Cir_Per_3.Circle_Color_Chagne(WhatColor(state));
                                    else
                                        Home.Cir_Per_3.Circle_Color_Chagne(Color.Yellow);
                                    break;

                                case "성능 수동 TEST 2":
                                    if (DateTime.Now.Month == dbtime.Month && DateTime.Now.Day == dbtime.Day)
                                        Home.Cir_Per_4.Circle_Color_Chagne(WhatColor(state));
                                    else
                                        Home.Cir_Per_4.Circle_Color_Chagne(Color.Yellow);
                                    break;
                            }
                        }));
                        #endregion
                    }
                }
                #region 예외사항 기록
                else if (getobj.GetType().Name == "Exception")
                    Record.Error(((Exception)getobj).ToString());
                else if (getobj.GetType().Name == "SqlException")
                    Record.Error(((SqlException)getobj).ToString());
                #endregion
            }
            catch (Exception ex)
            {
                Record.Error(ex.ToString());
            }
            #endregion
        }

        #region 소수점 반올림
        private double Percent_Calcurate(double percent)
        {
            if (percent.ToString().Contains("."))
            {
                string[] pers = percent.ToString().Trim().Split('.');
                double nums = Convert.ToDouble(pers[1]);
                if (nums >= 5)
                {
                    double return_value = Convert.ToDouble(pers[0]) + 1;
                    return return_value;
                }
                else
                {
                    double return_value = Convert.ToDouble(pers[0]);
                    return return_value;
                }
            }
            else
                return percent;
        }
        #endregion

        #region 설비상태값에 따른 색변화
        private Color WhatColor(int value)
        {
            Color return_color = Color.Lime;

            switch(value)
            {
                case 1:
                    return_color = Color.Yellow;
                    break;

                case 2:
                    return_color = Color.Red;
                    break;

                case 3:
                    return_color = Color.White;
                    break;
            }

            return return_color;
        }
        #endregion
    }
}
