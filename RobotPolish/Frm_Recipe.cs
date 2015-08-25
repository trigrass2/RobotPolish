//using System.Linq;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using RobotKit;


namespace RobotPolish
{
    public partial class Frm_Recipe : Std_Form
    {
        DataBaseManage db = new DataBaseManage();
        string[] RecipeName;
        string TrajName;
        int OperIndex = 0;
        string FileName;
        double[] Frame = new double[6];
        int WorkPlace = 1;
        public Frm_Recipe()
        {
            InitializeComponent();
        }

        private void Frm_Recipe_Load(object sender, EventArgs e)
        {
            CBE_RecipeName.Properties.Items.Clear();
            TxtData.PublicData.RecipeName = db.GetRecipeName();
            if (TxtData.PublicData.RecipeName!=null&&TxtData.PublicData.RecipeName.Rank>=1)
            {
           RecipeName = new string[
               (TxtData.PublicData.RecipeName[0] == null ? 0 : TxtData.PublicData.RecipeName[0].Length)
             + (TxtData.PublicData.RecipeName[1] == null ? 0 : TxtData.PublicData.RecipeName[1].Length)
             + (TxtData.PublicData.RecipeName[2] == null ? 0 : TxtData.PublicData.RecipeName[2].Length) 
             + (TxtData.PublicData.RecipeName[3] == null ? 0 : TxtData.PublicData.RecipeName[3].Length)
               ];
            int j = 0;

            for (int i = 0; i < 4; i++)
            {
                if (TxtData.PublicData.RecipeName[i] != null)
                {
                    for (int k = 0; k < TxtData.PublicData.RecipeName[i].Length; k++)
                    {
                        RecipeName[j] = TxtData.PublicData.RecipeName[i][k];
                        j++;
                    }


                }

            }


            CBE_RecipeName.Properties.Items.AddRange((object[])RecipeName);

            

            }
            if (CBE_RecipeName.Properties.Items.Count > 0)
            {
                //2014.10.23
                //删除文件后更新
                if (TxtData.Recipe.AdjustRecipe!=null&&RecipeName!=null&& Array.IndexOf(RecipeName,TxtData.Recipe.AdjustRecipe)>=0)
                {
                    CBE_RecipeName.EditValue = TxtData.Recipe.AdjustRecipe;
                }
                else
                {
                    CBE_RecipeName.EditValue = CBE_RecipeName.Properties.Items[0].ToString();
                    TxtData.Recipe.AdjustRecipe = CBE_RecipeName.Properties.Items[0].ToString();
                }
               
            }
            else
            {
                CBE_RecipeName.EditValue = "";
            }




        }

        private void CBE_RecipeName_TextChanged(object sender, EventArgs e)
        {
            GC_Traj.DataSource = db.GetDV_Traj(CBE_RecipeName.Text);
            if (gv.RowCount > 0)
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
                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;



            }
            else
            {
                TrajName = null;
            }
            RecipeInfor();
        }

        void RecipeInfor()
        {
            LL_TrajCount.Text = "路径总个数:" + gv.RowCount.ToString();
            string Remark = null;
            double[] Offset = new double[6];
            TxtData.Recipe.AdjustRecipe = CBE_RecipeName.EditValue.ToString();
            double[] Frame = db.GetRecipe(CBE_RecipeName.EditValue.ToString(), ref Offset, ref Remark, ref WorkPlace);
            if (Frame != null)
            {

                LL_RecipeFrame.Text = "产品坐标系:" + Frame[0].ToString() + "->" + Frame[1].ToString() + "->" + Frame[2].ToString() + "->" + Frame[3].ToString() + "->" + Frame[4].ToString() + "->" + Frame[5].ToString();
                LL_RecipeOffset.Text = "工具值  :" + Offset[0].ToString() + "->" + Offset[1].ToString() + "->" + Offset[2].ToString() + "->" + Offset[3].ToString() + "->" + Offset[4].ToString() + "->" + Offset[5].ToString();



               
                LL_RecipeRemark.Text = "说明:" + Remark;

                //2015.01.28
                //
                decimal [] Devpara = db.GetPresetList(Offset);
                if (Devpara!=null&&Devpara.Length>=5)
                {
                    ND_Z.Value = Devpara[0];
                    NUD_Press.Value = Devpara[1];

                    NUD_Rot.Value = Devpara[3];

                    NUD_Rel.Value = Devpara[2];
          
                    NUD_Speed.Value = Devpara[4];
                }




            }
            else
            {
                LL_RecipeFrame.Text = "产品坐标系:";
                LL_RecipeOffset.Text = "工具值:";
                LL_RecipeRemark.Text = "说明:" + Remark;
            }
        }
        private void ViewPoint(DevExpress.XtraGrid.GridControl gc, DevExpress.XtraGrid.Views.Grid.GridView gv, DataView dv)
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

              
                gv.Columns.Remove(gv.Columns["ACTION"]);
                gv.Columns.Remove(gv.Columns["PRESET"]);

                if (gv == GV_Appro)
                {
                    gv.Columns.Remove(gv.Columns["BLEND"]);
                    gv.Columns["INDEX"].Caption = "趋近";
                }
                if (gv == GV_Cut)
                {
                  //  gv.Columns.Remove(gv.Columns["BLEND"]);
                    gv.Columns["INDEX"].Caption = "打磨";
                    gv.Columns["BLEND"].Caption = "延时";

                }

                if (gv == GV_Leave)
                {
                    gv.Columns.Remove(gv.Columns["BLEND"]);
                    gv.Columns["INDEX"].Caption = "离开";
                }


                                

                gv.Columns["TYPENAME"].Caption = "类型";
                gv.Columns["SPEED"].Caption = "速度";
                gv.Columns["ACC"].Caption = "加速度";


                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;


            }



        }



        private void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TrajInfor();
            //   MessageBox.Show(TrajName);
            ViewPoint(GC_Appro, GV_Appro, db.GetDV_BeforeTrajpos(TrajName));
            ViewPoint(GC_Cut, GV_Cut, db.GetDV_Trajpos(TrajName));
            ViewPoint(GC_Leave, GV_Leave, db.GetDV_AfterTrajpos(TrajName));
            LL_PointCount.Text = "点个数:趋近点->" + GV_Appro.RowCount.ToString() + "   打磨点-> " + GV_Cut.RowCount.ToString() + "   离开点->" + GV_Leave.RowCount.ToString();
       
        }

        private void BT_New_Click(object sender, EventArgs e)
        {
            Edit_Recipe frm = new Edit_Recipe(true);
            frm.ShowDialog();
            Frm_Recipe_Load(this, null);
            if (frm.RecipeName != "")
            {
                CBE_RecipeName.EditValue = frm.RecipeName;
            }


        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if (MessageBox.Show("确定需要删除产品？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;
            OperIndex = 2;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frm.ShowDialog();
            Frm_Recipe_Load(this, null);

        }

        private void BT_OutPut_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if ((FileName = PublicFunc.SfD_Show(CBE_RecipeName.EditValue.ToString() + ".txt")) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;
            OperIndex = 1;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frm.ShowDialog();
        }

        private void BT_Import_Click(object sender, EventArgs e)
        {
            if (gv.RowCount != 0)
            {
                MessageBox.Show("产品已存在路径");
                return;
            }
            if (CBE_RecipeName.EditValue.ToString()==""||Frame==null)
            {
                MessageBox.Show("请先建立产品");
                return;
            }
            if ((FileName = PublicFunc.OpenDir_Show()) == null)
            {
                return;
            }
            string[] frm = new string[6];

            if (!PublicFunc.IsFrame(FileName, Frame,ref frm))
            {
                if (MessageBox.Show(
                    "导入文本中的产品坐标系不一致，是否继续导入?"+"\n新建产品坐标系是:"
                    + Frame[0].ToString() + ","  +Frame[1].ToString() + "," + Frame[2].ToString() + "," + Frame[3].ToString() + ","
                      + Frame[4].ToString() + "," +Frame[5].ToString() +"\n文本坐标系是:"
                    + frm[0].ToString() + ","  +frm[1].ToString() + "," + frm[2].ToString() + "," + frm[3].ToString() + ","
                      + frm[4].ToString() + "," +frm[5].ToString(),"产品坐标系不一致",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }


            }

            TxtData.PublicData.ErrorCode = 0;
            TxtData.PublicData.ErrorLine = 0;
            OperIndex = 3;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frM = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frM.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);
        }


        void PollImport(object target)
        {
            DataBaseManage db = new DataBaseManage();
            switch (OperIndex)
            {
                //导出
                case 1:
                    {
                        //2015.02.05
                        if (db.IsMatlabFile(CBE_RecipeName.EditValue.ToString()) == 0)
                        {

                            TxtData.PublicData.ErrorCode = 34;
                            return;
                        }
                        PolishTxt.MatlabFile = (db.IsMatlabFile(CBE_RecipeName.EditValue.ToString()) == 2);
                        //



                        TxtData.PublicData.ErrorCode = (db.SaveProduct(Application.StartupPath+"\\buff.txt", CBE_RecipeName.EditValue.ToString())) ? 0 : 34;
                        if (TxtData.PublicData.ErrorCode != 0)
                        {
                            return;
                        }PolishTxt.Home = db.GetHome();
                      



                        TxtData.PublicData.ErrorCode = (PolishTxt.Standard2Polish(Application.StartupPath + "\\buff.txt", FileName)) ? 40 : 49;
                        break;
                    }
                //删除产品
                
                case 2:
                    {
                        TxtData.PublicData.ErrorCode = (db.DeleteRecipe(CBE_RecipeName.EditValue.ToString())) ? 40 : 32;
                        break;
                    }
                //导入
                
                case 3:
                    {


                        //TxtData.PublicData.ErrorCode = PublicFunc.IsTool(FileName)? 0 : 41;
                        //if (TxtData.PublicData.ErrorCode != 0)
                        //{
                        //    return;
                        //}

                        //PolishTxt t = new PolishTxt();
                      //  PolishTxt.Home = db.GetHome();

                        PolishTxt.Home = db.GetHome();
                        string BuffFileName="";
                        if (PolishTxt.IsMatlabFile(FileName))
                        {
                            //把matlab文件转换为一般的文件
                            //2015.02.05

                            BuffFileName = Application.StartupPath + "\\Txt\\buffRecipe.txt";
                           // PolishTxt.MatlabFile = true;

                            TxtData.PublicData.ErrorCode = PolishTxt.ReadMatlabFile(FileName,true) ? 0 : 71;
                            if (TxtData.PublicData.ErrorCode != 0)
                            {
                                return;
                            }


                            TxtData.PublicData.ErrorCode = db.GetRecipe(CBE_RecipeName.EditValue.ToString(),ref PolishTxt.MatlabTool,ref PolishTxt.MatlabFrame) ? 0 : 72;
                            if (TxtData.PublicData.ErrorCode != 0)
                            {
                                return;
                            }
                            

                            //2015.02.05
                            //重点函数在这里
                            TxtData.PublicData.ErrorCode = PublicFunc.MatalData() ? 0 : 73;
                            if (TxtData.PublicData.ErrorCode != 0)
                            {
                                return;
                            }



                            TxtData.PublicData.ErrorCode = PolishTxt.Matlab2Recipe(BuffFileName) ? 0 : 74;
                            if (TxtData.PublicData.ErrorCode != 0)
                            {
                                return;
                            }


                                                        
                        }
                        else
                        {

                                                        
                            BuffFileName = FileName;

                        }



                        TxtData.PublicData.ErrorCode = PolishTxt.Polish2Standard(BuffFileName, Application.StartupPath + "\\Txt\\buff.txt") ? 0 : 49;
                        if (TxtData.PublicData.ErrorCode != 0)
                        {
                            return;
                        }
                        TxtData.PublicData.ErrorLine = db.ImportProduct(Application.StartupPath + "\\Txt\\buff.txt", CBE_RecipeName.EditValue.ToString());
                        TxtData.PublicData.ErrorCode = (TxtData.PublicData.ErrorLine == 0) ? 0 : 20;
                        if (TxtData.PublicData.ErrorCode != 0)
                        {
                            return;
                        }
                        TxtData.PublicData.ErrorCode = (db.EditRecipeOffline( CBE_RecipeName.EditValue.ToString(),PolishTxt.MatlabFile)) ? 40 : 20;






                       // return;
                        break;
                    }
                //删除路径
                case 4:
                    {
                        //2013.11.19
                        //TxtData.PublicData.ErrorCode = (db.DeleteTraj(TrajName,true)) ? 40 : 32;
                        TxtData.PublicData.ErrorCode = (db.DeleteTraj(CBE_RecipeName.EditValue.ToString(),TxtData.PublicData.DeleteTrajIndex)) ? 40 : 32;
                        break;
                    }
                //导入速度
                case 5:
                    {

                      

                        TxtData.PublicData.ErrorCode = (PolishTxt.ReadMatlabFileCount(FileName)==GV_Cut.RowCount)? 0 : 46;
                        if (TxtData.PublicData.ErrorCode != 0)
                        {
                            return;
                        }

                        double[,] da = PolishTxt.ReadMatlabFile(FileName);
                        TxtData.PublicData.ErrorCode = (da!=null) ? 0 : 47;
                        if (TxtData.PublicData.ErrorCode != 0)
                        {
                            return;
                        }
                        //TxtData.PublicData.ErrorLine = db.ImportProduct(FileName, CBE_RecipeName.EditValue.ToString());
                        //TxtData.PublicData.ErrorCode = (TxtData.PublicData.ErrorLine == 0) ? 40 : 20;
                        // return;

                        TxtData.PublicData.ErrorCode = db.BatchPointSpeed(TrajName, da) ? 40 : 48;

                        break;
                    }


                case 6:
                {
                    TxtData.PublicData.ErrorCode = (db.SaveProduct(Application.StartupPath + "\\buff.txt", CBE_RecipeName.EditValue.ToString())) ? 0 : 34;
                    if (TxtData.PublicData.ErrorCode != 0)
                    {
                        return;
                    }

                    TxtData.PublicData.ErrorCode = (PolishTxt.Part2Standard(TxtData.PolishData.PartMatlabFile, Application.StartupPath + "\\buff.txt", Application.StartupPath + "\\partbuff.txt")) ? 0 : 62;

                    if (TxtData.PublicData.ErrorCode != 0)
                    {
                        return;
                    }

                    TxtData.PublicData.ErrorCode = (db.AddRecipe(TxtData.PolishData.PartRecipeName, 1, new double[] { 0, 0, 0, 0, 0, 0 }, new double[] { 0, 0, 0, 0, 0, 0 },TxtData.PolishData.PartRecipeRemark)) ? 0 : 63;
                    if (TxtData.PublicData.ErrorCode != 0)
                    {
                        return;
                    }

                    TxtData.PublicData.ErrorCode = (db.ImportProduct(Application.StartupPath + "\\partbuff.txt", TxtData.PolishData.PartRecipeName)==0) ? 40 : 64;
   
                    break;

                }

            }




        }                                              


        private void BT_RecipeEdit_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            Edit_Recipe frm = new Edit_Recipe(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            RecipeInfor();
        }

        private void BT_Cs8c_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            } 

            
            
            
            if (TxtData.SoapData.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.SoapData.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }


            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);

        }

        private void BT_ReicpeFrame_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if (TxtData.SoapData.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.SoapData.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }

            if (TxtData.SoapData.Frame == null || TxtData.SoapData.Frame == new double[] { 0, 0, 0, 0, 0, 0 })
            {

                MessageBox.Show("下位机CS8C坐标系错误!");
                return;

            }
            
            if (MessageBox.Show(
           "下位机CS8C示教产品坐标系:\n" + "X:" + TxtData.SoapData.Frame[0].ToString() + "     Y:" + TxtData.SoapData.Frame[1].ToString() + "   Z:" + TxtData.SoapData.Frame[2].ToString() + "\n" +
               "  RX:"+TxtData.SoapData.Frame[3].ToString()+"     RY:"+TxtData.SoapData.Frame[4].ToString()+"  RZ:"+TxtData.SoapData.Frame[5].ToString()+
           "\n是否继续?", "产品坐标系", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            //if (!SoapInstance.SoapRead.SetAppdata("sProductName", CBE_RecipeName.EditValue.ToString()))
            //{
            //    MessageBox.Show("设置下位机数据出错!");
            //    return;
            //}
            //if (!SoapInstance.SoapRead.SetAppdata("nVirtualKey", 274))
            //{
            //    MessageBox.Show("设置下位机数据出错!");
            //    return;
            //}
            //while (TxtData.SoapData.InterfaceType == 9)
            //{
            //    System.Threading.Thread.Sleep(10);
            //}
            //TxtData.PublicData.ErrorCode = 0;
            //Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(),true);
            //frm.ShowDialog();


            if (db.EditRecipeFrame(CBE_RecipeName.Text, TxtData.SoapData.Frame))
            {
                RecipeInfor();
                MessageBox.Show("OK");
            }
            else
            {

                MessageBox.Show("Error");
            }
           


        }

        private void BT_RecipeOffset_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if (TxtData.SoapData.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.SoapData.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }

            if (!SoapInstance.SoapRead.SetAppdata("sProductName", CBE_RecipeName.EditValue.ToString()))
            {
                MessageBox.Show("设置下位机数据出错!");
                return;
            }

            if (!SoapInstance.SoapRead.SetAppdata("nInterfaceType", 11))
            {
                MessageBox.Show("设置下位机数据出错!");
                return;
            }
            //while (TxtData.SoapData.InterfaceType == 9)
            //{
            //    System.Threading.Thread.Sleep(10);
            //}
            TxtData.PublicData.ErrorCode = 0;
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(),true);
            frm.ShowDialog();
            RecipeInfor();


        }
        void TrajInfor()
        {

            if (gv.RowCount==0||gv.GetSelectedRows().Length<1)
            {
                return;
            }

       
            double[] Offset = new double[6];
            double[] Array = new double[6];
            double[] Downlead = new double[6];
            double[] Axis = new double[6];
            double[] Para = new double[6];


            string Remark = "";
         //   string TrajName = "";
            string TypeName = "";
            string[] DownleadType = new string[] { "无","直线","圆弧"};
            DataBaseManage db = new DataBaseManage();

            if (db.GetTraj(CBE_RecipeName.EditValue.ToString(), gv.GetSelectedRows()[0] + 1, ref TrajName, ref TypeName, ref Frame, ref Offset,
                ref Array, ref Downlead,ref Axis, ref Para, ref Remark))
            {


                LL_TrajRemark.Text = "路径说明:" + Remark;
            }
            else
            {
                LL_TrajRemark.Text = "路径说明:";
                TrajName = null;

            }









        }
        void Poll(object target)
        {
            DataBaseManage db = new DataBaseManage();
            double[] tool = db.GetTool();
            if (tool == null || tool.Length != 6 || TxtData.SoapData.Tool == null || TxtData.SoapData.Tool.Length != 6)
            {
                TxtData.PublicData.ErrorCode = 42;
                return;
            }

            TxtData.MdbData.Tool = tool;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (tool[i] != TxtData.MdbData.Tool[i])
            //    {
            //        TxtData.PublicData.ErrorCode = 42;
            //        return;
            //    }
            //}

            //home
            double[] home = db.GetHome();
            if (home == null || home.Length != 6 || TxtData.SoapData.Home == null || TxtData.SoapData.Home.Length != 6)
            {
                TxtData.PublicData.ErrorCode = 44;
                return;
            }
            for (int i = 0; i < 6; i++)
            {
                if (home[i] != TxtData.SoapData.Home[i])
                {
                    TxtData.PublicData.ErrorCode = 44;
                    return;
                }
            }
            TxtData.MdbData.Home = home;





            //**************************************

            if (db.IsMatlabFile(CBE_RecipeName.EditValue.ToString()) == 0)
            {

                TxtData.PublicData.ErrorCode = 34;
                return;
            }
            PolishTxt.MatlabFile = (db.IsMatlabFile(CBE_RecipeName.EditValue.ToString()) == 2);

            //

            PolishTxt.Home = home;
            if (!db.SaveProduct(CBE_RecipeName.EditValue.ToString()))
            {
                TxtData.PublicData.ErrorCode = 34;
                return;
            }
           
            if (!System.IO.Directory.Exists(Application.StartupPath + "\\txt\\"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\txt\\");
            }


            if (!PolishTxt.Standard2Polish(Application.StartupPath + "\\txt\\Recipe.txt", Application.StartupPath + "\\txt\\" + CBE_RecipeName.EditValue.ToString() + ".txt"))
            {
                TxtData.PublicData.ErrorCode = 49;
                return;
            }




            FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);
          //*******************************************


           

            if (!ftp.UpLoad(Application.StartupPath + "\\txt\\" + CBE_RecipeName.EditValue.ToString().Trim() + @".txt",@"/usr/usrapp/txt"))
           // if (!ftp.UpLoadPolishTxt(CBE_RecipeName.EditValue.ToString().Trim()))
           
            {TxtData.PublicData.ErrorCode = 24;
                return;
            }

            SoapInstance.SoapRead.SoapSetAppname = @"Disk://RobotPolish/RobotPolish.pjx";
            if (!SoapInstance.SoapRead.SetAppdata("sTxtSelected", CBE_RecipeName.EditValue.ToString() + ".txt"))
            {
                TxtData.PublicData.ErrorCode = 70;
                return;
            }


            //
            if (!SoapInstance.SoapRead.SetLibdata("read", "nZshift", -(int)ND_Z.Value))
            {
                TxtData.PublicData.ErrorCode = 70;
                return;
            }



            //2015.01.20
            if (!SoapInstance.SoapRead.SetAppAIO("io:aPressSet", (double)NUD_Press.Value))
            {
                TxtData.PublicData.ErrorCode = 70;
                return;
            }

            if (!SoapInstance.SoapRead.SetAppAIO("io:aRevolu", (double)NUD_Speed.Value))
            {
                TxtData.PublicData.ErrorCode = 70;
                return;
            }
            if (!SoapInstance.SoapRead.SetAppAIO("io:aRotation", (double)NUD_Rot.Value))
            {
                TxtData.PublicData.ErrorCode = 70;
                return;
            }
            if (!SoapInstance.SoapRead.SetAppAIO("io:aTableSpeed", (double)NUD_Speed.Value))
            {
                TxtData.PublicData.ErrorCode = 70;
                return;
            }
            
            if (!SoapInstance.SoapRead.SetAppdata("nVirtualKey", 272))
            {
                TxtData.PublicData.ErrorCode = 70;
                return;
            }
            db.AddLog("下载产品" + CBE_RecipeName.Text);
            db.AddProductCount(CBE_Custom.Text, CBE_RecipeName.Text, 1);//while (TxtData.SoapData.InterfaceType == 9)
            //{//    System.Threading.Thread.Sleep(10);
            //}
            TxtData.PublicData.ErrorCode = 40;
        }
                


        private void BT_Speed_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            Batch_Speed frm = new Batch_Speed(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);

        }

        private void BT_TrajPart_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            //2013.11.19
            //添加批处理删除路径

            //Batch_DeleteTraj frmChoose = new Batch_DeleteTraj(CBE_RecipeName.EditValue.ToString(), gv.GetSelectedRows()[0]);
            //frmChoose.ShowDialog();
            //if (TxtData.PublicData.DeleteTrajIndex==null)
            //{
            //    return;
            //}



            //if (MessageBox.Show("确定需要删除路径吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //{
            //    return;
            //}

                        
            Edit_Part frmE = new Edit_Part();
            frmE.ShowDialog();

            if (TxtData.PolishData.PartMatlabFile == null || TxtData.PolishData.PartRecipeName == null)
            {
                return;
            }

            TxtData.PublicData.ErrorCode = 0;
            OperIndex = 6;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frm.ShowDialog();
            if (TxtData.PublicData.ErrorCode == 0 || TxtData.PublicData.ErrorCode == 40)
            {

                CBE_RecipeName.Text = TxtData.PolishData.PartRecipeName;
                 CBE_RecipeName_TextChanged(this, null);
            }
           
        }

        private void BT_EditSequ_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            Edit_Sequen frm = new Edit_Sequen(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);
        }

        private void BT_PowerOn_Click(object sender, EventArgs e)
        {
            if (TxtData.SoapData.ToolMode != 4)
            {
                MessageBox.Show("请切换到远程模式!");
                return;
            }

            if (SoapInstance.SoapRead.Poweron())
            {
                MessageBox.Show("上电成功!");
            }
            else
            {
                MessageBox.Show("请检查急停按钮!");
            }

        }

        private void BT_Download_Click(object sender, EventArgs e)
        {
            if (!TxtData.SoapData.IsHome)
            {MessageBox.Show("机械手臂请先回零!");
                return;
            }

            if (TxtData.SoapData.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.SoapData.ToolMode != 4)
            {
                MessageBox.Show("请切换到远程模式!");
                return;
            }


            if (!TxtData.SoapData.PowerOn)
            {
                MessageBox.Show("请先上电!");
                return;
            }
            if (NUD_Press.Value<0||NUD_Rel.Value<0||NUD_Rot.Value<0||NUD_Speed.Value<0||ND_Z.Value<0)
            {
                MessageBox.Show("生成设置的参数不能为0!");
                return;

            }

            if (Frame==null||Frame==new  double[]{0,0,0,0,0,0})
            {
                if (MessageBox.Show(
                    "产品坐标系都是零，是否继续下载?" , "产品坐标系为零", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }


            }

            //if (offse== null || Frame == new double[] { 0, 0, 0, 0, 0, 0 })
            //{
            //    if (MessageBox.Show(
            //        "产品坐标系都是零，是否继续下载?", "产品坐标系为零", MessageBoxButtons.YesNo) == DialogResult.No)
            //    {
            //        return;
            //    }


            //}

            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait();
            frm.ShowDialog();
        }

        private void BT_MatLab_Click(object sender, EventArgs e)
        {
            if (gv.RowCount == 0)
            {
                MessageBox.Show("没有路径");
                return;
            }
            if (CBE_RecipeName.EditValue.ToString() == "" || Frame == null)
            {
                MessageBox.Show("请先建立产品");
                return;
            }
            if ((FileName = PublicFunc.OpenDir_Show()) == null)
            {
                return;
            }



            TxtData.PublicData.ErrorCode = 0;
            TxtData.PublicData.ErrorLine = 0;
            OperIndex = 5;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frM = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frM.ShowDialog();
            ViewPoint(GC_Cut, GV_Cut, db.GetDV_Trajpos(TrajName));
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            if (GV_Cut.GetFocusedDataSourceRowIndex() < 0 || GV_Cut.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
              Batch_Cut frm = new Batch_Cut(TrajName);
           // Batch_TrajPos frm = new Batch_TrajPos(TrajName);
            frm.ShowDialog();
            ViewPoint(GC_Cut, GV_Cut, db.GetDV_Trajpos(TrajName));
        }

        private void BT_DeleteTraj_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            //2013.11.19
            //添加批处理删除路径

            //Batch_DeleteTraj frmChoose = new Batch_DeleteTraj(CBE_RecipeName.EditValue.ToString(), gv.GetSelectedRows()[0]);
            //frmChoose.ShowDialog();
            //if (TxtData.PublicData.DeleteTrajIndex==null)
            //{
            //    return;
            //}



            if (MessageBox.Show("确定需要删除路径吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }


            //Edit_Part frmE = new Edit_Part();
            //frmE.ShowDialog();

            //if (TxtData.PolishData.PartMatlabFile == null || TxtData.PolishData.PartRecipeName == null)
            //{
            //    return;
            //}
            TxtData.PublicData.DeleteTrajIndex = new int[] { gv.GetFocusedDataSourceRowIndex()+1};

            TxtData.PublicData.ErrorCode = 0;
            OperIndex = 4;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frm.ShowDialog();
            if (TxtData.PublicData.ErrorCode == 0 || TxtData.PublicData.ErrorCode == 40)
            {

                //CBE_RecipeName.Text = TxtData.PolishData.PartRecipeName;
                //CBE_RecipeName_TextChanged(this, null);
                CBE_RecipeName_TextChanged(this, null);
            }
           
        }

        private void BT_RZ_Click(object sender, EventArgs e)
        {

        }

        //private void timer_Refresh_Tick(object sender, EventArgs e)
        //{


        //    if (TxtData.SoapData.BIOValue != null && TxtData.SoapData.BIOValue.Length == 32)
        //    {
        //        LL_MainPower.Text = TxtData.SoapData.BIOValue[22] ? "主轴[上]电" : "主轴[下]电";
        //        LL_MainEnable.Text = TxtData.SoapData.BIOValue[23] ? "主轴[启动]" : "主轴[停止]";
        //        LL_ATI.Text = TxtData.SoapData.bZero ? "置零ATI数据[开]" : "置零ATI数据[关]";

        //        LL_TEnable.Text = TxtData.SoapData.BIOValue[25] ? "转台[启动]" : "转台[停止]";


        //        LL_MainPower.ForeColor = TxtData.SoapData.BIOValue[22] ? System.Drawing.Color.Red : System.Drawing.Color.Black;
        //        LL_MainEnable.ForeColor = TxtData.SoapData.BIOValue[23] ? System.Drawing.Color.Red : System.Drawing.Color.Black;
        //        LL_TEnable.ForeColor = TxtData.SoapData.BIOValue[25] ? System.Drawing.Color.Red : System.Drawing.Color.Black;

        //        LL_ATI.ForeColor = TxtData.SoapData.bZero ? System.Drawing.Color.Red : System.Drawing.Color.Black;
        //        int T = 0;
        //        for (int i = 0; i < 6; i++)
        //        {
        //            T = T + (int)((TxtData.SoapData.BIOValue[16 + i] ? 1 : 0) * Math.Pow(2, i));
        //        }

        //        // Speed = T;
        //        LL_Table.Text = "转台速度:" + T.ToString();
        //    }
        //    else
        //    {

        //        LL_TEnable.Text = "转台启动状态未知";
        //        LL_Table.Text = "转台速度状态未知";
        //        LL_MainPower.Text = "主轴上电状态未知";
        //        LL_MainEnable.Text = "主轴启动状态未知";
        //        LL_ATI.Text = "置零ATI数据状态未知";

        //    }
        //    if (TxtData.SoapData.SoapStaus && TxtData.SoapData.productStatus != null && TxtData.SoapData.productStatus.Length == 10)
        //    {
        //        ll0.Text = TxtData.SoapData.productStatus[0];
        //        ll1.Text = TxtData.SoapData.productStatus[1];
        //        ll2.Text = TxtData.SoapData.productStatus[2];
        //        ll3.Text = TxtData.SoapData.productStatus[3];
        //        ll4.Text = TxtData.SoapData.productStatus[4];
        //        ll5.Text = TxtData.SoapData.productStatus[5];
        //        ll6.Text = TxtData.SoapData.productStatus[6];
        //        ll7.Text = TxtData.SoapData.productStatus[7];
        //        ll8.Text = TxtData.SoapData.productStatus[8];
        //        ll9.Text = TxtData.SoapData.productStatus[9];


        //    }
        //    else
        //    {

        //        ll0.Text = ll1.Text = ll2.Text = ll3.Text = ll4.Text = ll5.Text = ll6.Text = ll7.Text = ll8.Text = ll9.Text = "状态未知";

        //    }



        //}//private void BT_Batch_Click(object sender, EventArgs e)
        ////{
        ////    if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
        ////    {
        ////        MessageBox.Show("没有路径");
        //        return;
        //    }
        //    Batch_Traj frm = new Batch_Traj(CBE_RecipeName.EditValue.ToString());
        //    frm.ShowDialog();
        //    CBE_RecipeName_TextChanged(this, null);

        //}

        //private void BT_Cut_Click(object sender, EventArgs e)
        //{
        //    if (GV_Cut.GetFocusedDataSourceRowIndex() < 0 || GV_Cut.RowCount < 1)
        //    {
        //        MessageBox.Show("没有路径");
        //        return;
        //    }
        // //   Edit_Cut frm = new Edit_Cut(TrajName, GV_Cut.GetSelectedRows()[0] + 1);
        //    Batch_TrajPos frm = new Batch_TrajPos(TrajName);
        //    frm.ShowDialog();
        //    ViewPoint(GC_Cut, GV_Cut, db.GetDV_Trajpos(TrajName));
        //}

    }
}
