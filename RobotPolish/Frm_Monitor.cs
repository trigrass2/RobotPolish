using System;
using System.Data;
using System.Windows.Forms;
using RobotKit;

namespace RobotPolish
{
    public partial class Frm_Monitor : Std_Form
    {
        private bool RefreshScreen = true;
        private DataView dv1 = new DataView();
        private DataView dv2 = new DataView();
        private int MoveId = 0;
        private int PointType = 0;
        private int TrajIndex = 0;
        private string RecipeName;
        private string TrajName;

        private DataBaseManage db = new DataBaseManage();
        private bool ChartFill;

        ////
        //DataView dvtraj = new DataView();
        //DataView dvpoint = new DataView();



        public Frm_Monitor()
        {
            InitializeComponent();

        }

        private void Frm_Monitor_Load(object sender, EventArgs e)
        {
            //dv1.Table = new System.Data.DataTable("Traj");
            //dv2.Table = new System.Data.DataTable("Point");
            //dv1.Table.Columns.Add();
            //dv1.Table.Columns.Add();
            //dv1.Table.Columns.Add();
            //dv1.Table.Rows.Clear();
            //GC_Traj.DataSource = dv1;
            //gv.Columns[0].Caption = "序号";
            //gv.Columns[1].Caption = "路径名称";
            //gv.Columns[2].Caption = "路径类型";



            //dv2.Table.Columns.Add();
            //dv2.Table.Columns.Add();
            //dv2.Table.Columns.Add();
            //dv2.Table.Columns.Add();
            //dv2.Table.Columns.Add();
            //dv2.Table.Columns.Add();
            //dv2.Table.Columns.Add();
            //dv2.Table.Columns.Add();
            //dv2.Table.Rows.Clear();
            //GC_Cut.DataSource = dv2;
            //GV_Cut.Columns[0].Caption = "序号";
            //GV_Cut.Columns[1].Caption = "类型";
            //GV_Cut.Columns[2].Caption = "X/J1";
            //GV_Cut.Columns[3].Caption = "Y/J2";
            //GV_Cut.Columns[4].Caption = "Z/J3";
            //GV_Cut.Columns[5].Caption = "RX/J4";
            //GV_Cut.Columns[6].Caption = "RY/J5";
            //GV_Cut.Columns[7].Caption = "RZ/J6";

            //if (TxtData.SoapData.SoapStaus && TxtData.SoapData.InterfaceType == 13)
            //{

            //    if (TxtData.PublicData.ProductName == null || TxtData.SoapData.ProductName == null
            //       || TxtData.SoapData.ProductName.Length < TxtData.PublicData.WorkPlaceCount || TxtData.PublicData.ProductName[0] == null || TxtData.PublicData.ProductName[0][0] == null
            //        || TxtData.PublicData.ProductName[0][0] == ""

            //        )
            //    //|| TxtData.PublicData.ProductName[i-1] != TxtData.SoapData.ProductName[i-1])
            //    {
            //        FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);

            //        for (int i = 1; i <= TxtData.PublicData.WorkPlaceCount; i++)
            //        {
            //            ftp.DownLoadProductTxt(i);
            //            PublicFunc.IsRecipeOk(Application.StartupPath + "\\Txt\\Product" + TxtData.SoapData.WorkPlaceIndex.ToString() + ".txt");
            //        }
            //    }

            //}








        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {

            try
            {
                if (TxtData.SoapData.BIOValue != null && TxtData.SoapData.BIOValue.Length == 32)
                {
                    LL_MainPower.Text = TxtData.SoapData.BIOValue[22] ? "主轴[上]电" : "主轴[下]电";
                    LL_MainEnable.Text = TxtData.SoapData.BIOValue[23] ? "主轴[启动]" : "主轴[停止]";
                    LL_ATI.Text = TxtData.SoapData.bZero ? "置零ATI数据[开]" : "置零ATI数据[关]";

                    LL_TEnable.Text = TxtData.SoapData.BIOValue[25] ? "转台[启动]" : "转台[停止]";


                    LL_MainPower.ForeColor = TxtData.SoapData.BIOValue[22]
                        ? System.Drawing.Color.Red
                        : System.Drawing.Color.Black;
                    LL_MainEnable.ForeColor = TxtData.SoapData.BIOValue[23]
                        ? System.Drawing.Color.Red
                        : System.Drawing.Color.Black;
                    LL_TEnable.ForeColor = TxtData.SoapData.BIOValue[25]
                        ? System.Drawing.Color.Red
                        : System.Drawing.Color.Black;

                    LL_ATI.ForeColor = TxtData.SoapData.bZero ? System.Drawing.Color.Red : System.Drawing.Color.Black;
                    int T = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        T = T + (int) ((TxtData.SoapData.BIOValue[16 + i] ? 1 : 0)*Math.Pow(2, i));
                    }

                    // Speed = T;
                    LL_Table.Text = "转台速度:" + T.ToString();
                }
                else
                {

                    LL_TEnable.Text = "转台启动状态未知";
                    LL_Table.Text = "转台速度状态未知";
                    LL_MainPower.Text = "主轴上电状态未知";
                    LL_MainEnable.Text = "主轴启动状态未知";
                    LL_ATI.Text = "置零ATI数据状态未知";

                }
                if (TxtData.SoapData.SoapStaus && TxtData.SoapData.productStatus != null &&
                    TxtData.SoapData.productStatus.Length == 10)
                {
                    ll0.Text = TxtData.SoapData.productStatus[0];
                    ll1.Text = TxtData.SoapData.productStatus[1];
                    ll2.Text = TxtData.SoapData.productStatus[2];
                    ll3.Text = TxtData.SoapData.productStatus[3];
                    ll4.Text = TxtData.SoapData.productStatus[4];
                    ll5.Text = TxtData.SoapData.productStatus[5];
                    ll6.Text = TxtData.SoapData.productStatus[6];
                    ll7.Text = TxtData.SoapData.productStatus[7];
                    ll8.Text = TxtData.SoapData.productStatus[8];
                    ll9.Text = TxtData.SoapData.productStatus[9];


                }
                else
                {

                    ll0.Text =
                        ll1.Text =
                            ll2.Text =
                                ll3.Text = ll4.Text = ll5.Text = ll6.Text = ll7.Text = ll8.Text = ll9.Text = "状态未知";

                }




                GC_Infor.Text = "生产信息：" + RecipeName + ":" + TxtData.SoapData.Moveid.ToString();if (TxtData.SoapData.InterfaceType == 13 && TxtData.SoapData.productStatus[2].IndexOf("生产中") >= 0)
                {

                    if (!ChartFill)
                    {
                        ChartFill = true;
                        string[] buff = TxtData.SoapData.productStatus[1].Split(new char[] {'.'});
                        if (buff != null && buff[0] != null)
                        {
                            RecipeName = buff[0].Trim();

                            Char();
                            TrajInfor();
                        }


                        if (TrajName != null && TrajName != "")
                        {
                            ViewPoint(GC_Cut, GV_Cut, db.GetDV_Trajpos(TrajName));
                        }


                    }


                    if (TxtData.SoapData.Moveid > 2 && TxtData.SoapData.Moveid < GV_Cut.RowCount)
                    {
                       
                        int rowindex = (int) (TxtData.SoapData.Moveid - 1);
                        //GV_Cut.SelectRow(rowindex);
                        if (rowindex > GV_Cut.GetSelectedRows()[0])
                        {
                            GV_Cut.MoveBy(rowindex - GV_Cut.GetSelectedRows()[0]);

                        }
                        //  GV_Cut.se
                        //  GV_Cut.SelectRow();
                        // GV_Cut.SetFocusedRowModified();
                    }




                }

            }
            catch (Exception)
            {

                //  throw;
            }




        }


        private void Char()
        {
            try
            {
                GC_Traj.DataSource = db.GetDV_Traj(RecipeName);
                if (gv.RowCount > 0 && GC_Traj.DataSource != null)
                {
                    //   gv.Columns.
                    gv.Columns.Remove(gv.Columns["ID"]);
                    gv.Columns.Remove(gv.Columns["RECIPENAME"]);
                    gv.Columns.Remove(gv.Columns["TYPENO"]);
                    gv.Columns.Remove(gv.Columns["DIAMETER"]);
                    gv.Columns.Remove(gv.Columns["DELAY"]);
                    gv.Columns.Remove(gv.Columns["SPEED"]);
                    gv.Columns.Remove(gv.Columns["BLEND"]);
                    gv.Columns.Remove(gv.Columns["FRAME_X"]);
                    gv.Columns.Remove(gv.Columns["FRAME_Y"]);
                    gv.Columns.Remove(gv.Columns["FRAME_Z"]);
                    gv.Columns.Remove(gv.Columns["FRAME_RX"]);
                    gv.Columns.Remove(gv.Columns["FRAME_RY"]);
                    gv.Columns.Remove(gv.Columns["FRAME_RZ"]);
                    gv.Columns.Remove(gv.Columns["OFFSET_X"]);
                    gv.Columns.Remove(gv.Columns["OFFSET_Y"]);
                    gv.Columns.Remove(gv.Columns["OFFSET_Z"]);
                    gv.Columns.Remove(gv.Columns["OFFSET_RX"]);
                    gv.Columns.Remove(gv.Columns["OFFSET_RY"]);
                    gv.Columns.Remove(gv.Columns["OFFSET_RZ"]);

                    gv.Columns.Remove(gv.Columns["ACTION1"]);
                    gv.Columns.Remove(gv.Columns["ACTION2"]);
                    gv.Columns.Remove(gv.Columns["ACTION3"]);
                    gv.Columns.Remove(gv.Columns["ACTION4"]);

                    gv.Columns.Remove(gv.Columns["REMARK"]);
                    gv.Columns.Remove(gv.Columns["BP1"]);
                    gv.Columns.Remove(gv.Columns["BP2"]);
                    gv.Columns.Remove(gv.Columns["BP3"]);
                    gv.Columns.Remove(gv.Columns["BP4"]);

                    gv.Columns.Remove(gv.Columns["ARRAY_XCOUNT"]);
                    gv.Columns.Remove(gv.Columns["ARRAY_XOFFSET"]);
                    gv.Columns.Remove(gv.Columns["ARRAY_YCOUNT"]);
                    gv.Columns.Remove(gv.Columns["ARRAY_YOFFSET"]);
                    //gv.Columns.Remove(gv.Columns["OFFSET_X"]);//************************************************
                    gv.Columns["INDEX"].Caption = "序号";
                    gv.Columns["TRAJNAME"].Caption = "路径名称";
                    // gv.Columns["TYPENAME"].Caption = "路径类型";
                    gv.Columns.Remove(gv.Columns["TYPENAME"]);
                    // gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;



                }
                else
                {
                    TrajName = null;
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
                //  throw;
            }


            //RecipeInfor();
        }

        private void TrajInfor()
        {

            if (gv.RowCount == 0 || gv.GetSelectedRows().Length < 1)
            {
                return;
            }


            double[] Offset = new double[6];
            double[] Array = new double[6];
            double[] Downlead = new double[6];
            double[] Axis = new double[6];
            double[] Para = new double[6];

            double[] Frame = new double[6];
            string Remark = "";
            //   string TrajName = "";
            string TypeName = "";
            string[] DownleadType = new string[] {"无", "直线", "圆弧"};
            DataBaseManage db = new DataBaseManage();

            if (db.GetTraj(RecipeName, gv.GetSelectedRows()[0] + 1, ref TrajName, ref TypeName, ref Frame, ref Offset,
                ref Array, ref Downlead, ref Axis, ref Para, ref Remark))
            {


                // LL_TrajRemark.Text = "路径说明:" + Remark;
            }
            else
            {
                // LL_TrajRemark.Text = "路径说明:";
                TrajName = null;

            }









        }

        //刷新表1

        //void RefreshGV1()
        //{
        //    if (TxtData.SoapData.InterfaceType != 13 && TxtData.SoapData.InterfaceType != 5)
        //    {
        //        return;
        //    }
        //    if (TxtData.SoapData.ProductName == null || TxtData.SoapData.ProductName.Length < TxtData.SoapData.WorkPlaceIndex || TxtData.SoapData.TrajIndex < 1 || TxtData.SoapData.WorkPlaceIndex < 1)
        //    {
        //        TrajIndex = 0;
        //        dv1.Table.Rows.Clear();
        //        dv2.Table.Rows.Clear();
        //        return;
        //    }


        //    if (RecipeName != TxtData.SoapData.ProductName[TxtData.SoapData.WorkPlaceIndex])
        //    {
        //        RecipeName = TxtData.SoapData.ProductName[TxtData.SoapData.WorkPlaceIndex];
        //        PublicFunc.IsRecipeOk(Application.StartupPath + "\\Txt\\Product" + TxtData.SoapData.WorkPlaceIndex.ToString() + ".txt");
        //    }
        //    if (TrajIndex != TxtData.SoapData.TrajIndex)
        //    {
        //        TrajIndex = TxtData.SoapData.TrajIndex;

        //        if (TxtData.Recipe.TrajName.Length > TrajIndex)
        //        {
        //            dv1.Table.Rows.Add(new object[] { TrajIndex.ToString(), TxtData.Recipe.TrajName[TrajIndex], TxtData.Recipe.TrajTypeName[TxtData.Recipe.TrajType[TrajIndex]] });
        //        }

        //        dv2.Table.Rows.Clear();
        //        //gv.AddNewRow();
        //        if (gv.RowCount >= 1)
        //        {
        //            // gv.
        //        }

        //    }



        //}

        ////刷新表2


        //void RfreshGV2()
        //{
        //    if (TxtData.SoapData.InterfaceType != 13)
        //    {
        //        return;
        //    }
        //    if (TxtData.SoapData.ProductName == null || TxtData.SoapData.ProductName.Length < TxtData.SoapData.WorkPlaceIndex || TxtData.SoapData.TrajIndex < 1 || TxtData.SoapData.WorkPlaceIndex < 1)
        //    {
        //        return;
        //    }
        //    if (TxtData.Recipe.TrajType == null || TxtData.Recipe.TrajType.Length < TrajIndex || TxtData.Recipe.TrajPointCount.Length < TrajIndex || TxtData.SoapData.CurrentPoint == null)
        //    {
        //        return;
        //    }

        //    if (MoveId != int.Parse(TxtData.SoapData.ID.ToString()) || PointType != TxtData.SoapData.PointType)
        //    {
        //        MoveId = int.Parse(TxtData.SoapData.ID.ToString());
        //        PointType = TxtData.SoapData.PointType;
        //        if (MoveId == 0)
        //        {
        //            return;
        //        }
        //        dv2.Table.Rows.Add(new object[] { "", "", "", "", "", "", "1", "2" });
        //        switch (TxtData.SoapData.PointType)
        //        {
        //            case 1:
        //                {
        //                    if (MoveId < TxtData.Recipe.TrajPointCount[TrajIndex, 0] && TxtData.Recipe.pAppro.Length > TrajIndex && TxtData.Recipe.pAppro[TrajIndex] != null)
        //                    {

        //                        dv2.Table.Rows.Add(new object[] { MoveId.ToString(), "趋近点",
        //                             TxtData.Recipe.pAppro[TrajIndex][MoveId,0].ToString(), 
        //                             TxtData.Recipe.pAppro[TrajIndex][MoveId,1].ToString(), 
        //                             TxtData.Recipe.pAppro[TrajIndex][MoveId,2].ToString(),
        //                             TxtData.Recipe.pAppro[TrajIndex][MoveId,3].ToString(),
        //                             TxtData.Recipe.pAppro[TrajIndex][MoveId,4].ToString(),
        //                             TxtData.Recipe.pAppro[TrajIndex][MoveId,5].ToString()
        //                         });
        //                    }

        //                    break;

        //                }
        //            case 2:
        //                {
        //                    if (TxtData.Recipe.TrajType[TrajIndex] == 10)
        //                    {
        //                        if (MoveId < TxtData.Recipe.TrajPointCount[TrajIndex, 1] && TxtData.Recipe.pCut.Length > TrajIndex && TxtData.Recipe.pCut[TrajIndex] != null)
        //                        {

        //                            dv2.Table.Rows.Add(new object[] { MoveId.ToString(), "打磨点",
        //                             TxtData.Recipe.pCut[TrajIndex][MoveId,0].ToString(), 
        //                             TxtData.Recipe.pCut[TrajIndex][MoveId,1].ToString(),
        //                             TxtData.Recipe.pCut[TrajIndex][MoveId,2].ToString(),
        //                             TxtData.Recipe.pCut[TrajIndex][MoveId,3].ToString(),
        //                             TxtData.Recipe.pCut[TrajIndex][MoveId,4].ToString(),
        //                             TxtData.Recipe.pCut[TrajIndex][MoveId,5].ToString()
        //                         });
        //                        }
        //                    }
        //                    else
        //                    {
        //                        dv2.Table.Rows.Add(new object[] { MoveId.ToString(), "打磨点",
        //                             TxtData.SoapData.CurrentPoint[0].ToString(),
        //                             TxtData.SoapData.CurrentPoint[1].ToString(),
        //                             TxtData.SoapData.CurrentPoint[2].ToString(),
        //                             TxtData.SoapData.CurrentPoint[3].ToString(),
        //                             TxtData.SoapData.CurrentPoint[4].ToString(),
        //                             TxtData.SoapData.CurrentPoint[5].ToString(),
        //                         });



        //                    }
        //                    break;

        //                }
        //            case 3:
        //                {
        //                    if (MoveId < TxtData.Recipe.TrajPointCount[TrajIndex, 2] && TxtData.Recipe.pLeave.Length > TrajIndex && TxtData.Recipe.pLeave[TrajIndex] != null)
        //                    {
        //                        dv2.Table.Rows.Add(new object[] { MoveId.ToString(), "离开点",
        //                             TxtData.Recipe.pLeave[TrajIndex][MoveId,0].ToString(), 
        //                             TxtData.Recipe.pLeave[TrajIndex][MoveId,1].ToString(),
        //                             TxtData.Recipe.pLeave[TrajIndex][MoveId,2].ToString(),
        //                             TxtData.Recipe.pLeave[TrajIndex][MoveId,3].ToString(),
        //                             TxtData.Recipe.pLeave[TrajIndex][MoveId,4].ToString(),
        //                             TxtData.Recipe.pLeave[TrajIndex][MoveId,5].ToString()
        //                         });
        //                    }
        //                    break;

        //                }

        //        }

        //        if (GV_Cut.RowCount >= 1)
        //        {
        //            GV_Cut.SelectRow(GV_Cut.RowCount - 1);
        //        }

        //    }


        //}






        private void ViewPoint(DevExpress.XtraGrid.GridControl gc, DevExpress.XtraGrid.Views.Grid.GridView gv,
            DataView dv)
        {
            gc.DataSource = dv;
            if (gv.RowCount > 0)
            {

                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["TRAJNAME"]);
                gv.Columns.Remove(gv.Columns["TYPENO"]);
                //  gv.Columns.Remove(gv.Columns["TYPENAME"]);

                gv.Columns.Remove(gv.Columns["MOVCPOS"]);

                gv.Columns.Remove(gv.Columns["REMARK"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);

                gv.Columns.Remove(gv.Columns["BLEND"]);
                gv.Columns.Remove(gv.Columns["ACTION"]);
                gv.Columns.Remove(gv.Columns["PRESET"]);

                //if (gv == GV_Appro)
                //{
                //    gv.Columns["INDEX"].Caption = "趋近";
                //}
                //if (gv == GV_Cut)
                //{
                gv.Columns["INDEX"].Caption = "打磨";

                //}

                //if (gv == GV_Leave)
                //{
                //    gv.Columns["INDEX"].Caption = "离开";
                //}




                gv.Columns["TYPENAME"].Caption = "类型";
                gv.Columns["SPEED"].Caption = "速度";
                gv.Columns["ACC"].Caption = "加速度";


                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;


            }



        }

        private void BT_Pause_Click(object sender, EventArgs e)
        {
            if (!TxtData.SoapData.SoapStaus || TxtData.SoapData.ToolMode != 4 ||
                (!(TxtData.SoapData.InterfaceType == 13 || TxtData.SoapData.InterfaceType == 6)))
            {
                MessageBox.Show("通讯异常或者不在生产状态");
                return;
            }
            if (MessageBox.Show("确定需要暂停？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
        }

        private void BT_Stop_Click(object sender, EventArgs e)
        {
            if (!TxtData.SoapData.SoapStaus || TxtData.SoapData.ToolMode != 4 ||
                (!(TxtData.SoapData.InterfaceType == 13 || TxtData.SoapData.InterfaceType == 6)))
            {
                MessageBox.Show("通讯异常或者不在生产状态");
                return;
            }
            if (MessageBox.Show("确定需要停止？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            if (SoapInstance.SoapRead.SetAppdata("nInterfaceType", 9))
            {
                MessageBox.Show("设置成功!");
            }
            else
            {
                MessageBox.Show("设置下位机数据异常");
            }
        }

        private void GV_Cut_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == GV_Cut.FocusedRowHandle)
            {
                e.Appearance.ForeColor = System.Drawing.Color.Red;
                e.Appearance.BackColor =System.Drawing.Color.RoyalBlue;
                
            }
        }

    }


}

