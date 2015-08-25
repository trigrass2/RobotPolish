using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using RobotKit;

namespace RobotPolish
{
    public partial class Frm_Product : Std_Form
    {
        DataBaseManage db = new DataBaseManage();
        public Frm_Product()
        {
            InitializeComponent();

            if (System.IO.File.Exists(Application.StartupPath + "\\ProductShow.jpg"))
            {
                this.Pic_Main.Image = Image.FromFile(Application.StartupPath + "\\ProductShow.jpg");
            }
        }


        /// <summary>
        /// 获取四个产品信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Product_Load(object sender, EventArgs e)
        {
            TxtData.PublicData.Customs = db.GetCustom();
            db.SaveCs8cConfigure();
           // PublicFunc.ReadCs8CConfigure();

            CBE_Triggle.Properties.Items.AddRange((object[])(TxtData.PublicData.TriggleModeText));
            if (TxtData.PublicData.Customs!=null)
            {
                CBE_Custom.Properties.Items.AddRange((object[])(TxtData.PublicData.Customs));
            }
            if (TxtData.SoapData.Custom!=null)
            {
                CBE_Custom.Text = TxtData.SoapData.Custom;
            }
        
          
            CBE_Triggle.SelectedIndex = TxtData.PublicData.TriggleMode;
            
            SE_Cycle.Value = TxtData.PublicData.CycleCount;
            SE_Home.Value =(decimal) TxtData.MdbData.HomeSpeed;
            SE_Wait.Value = (decimal)TxtData.MdbData.IODelay[3];
            SE_Pan.Value = (decimal)TxtData.MdbData.PresetData[4];

            SE_WorkPlaceCount_ValueChanged(this, null);
            if (TxtData.MdbData.EnableItem[4])
            {
                SE_WorkPlaceCount.Properties.MaxValue = 2;
                
            }
            else
            {
                if (TxtData.PublicData.ProductCount!=null)
                {
                    for (int j = 0; j < TxtData.PublicData.ProductCount.Length - 1; j++)
                    {

                        TxtData.PublicData.ProductCount[j] = 1;

                    }
                }

                    SE_WorkPlaceCount.Properties.MaxValue = 4;
            }
            SE_WorkPlaceCount.Value = Math.Min(TxtData.PublicData.WorkPlaceCount, SE_WorkPlaceCount.Properties.MaxValue);
            for (int i = 0; i < 4; i++)
            {
                if (TxtData.PublicData.ProductName.Length > i && TxtData.PublicData.ProductName[i] != null)
                {
                    switch (i)
                    {
                        case 0:
                            LL_WP1.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;
                        case 1:
                            LL_WP2.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;
                        case 2:
                            LL_WP3.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;
                        case 3:
                            LL_WP4.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;

                    }
                }
            }
        //Pic_Main.Left=this.Size.Width - GC_WorkPlace.Size.Width - 10;

            GC_ProductCfg.Enabled = TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 14];
            CBE_Triggle.Enabled=!TxtData.MdbData.EnableItem[4];
            GC_ProductCfg.Text="生产配置:"+(TxtData.MdbData.EnableItem[4]?"同工位多产品":"");
 
        }

        private void BT_SEL1_Click(object sender, EventArgs e)
        {
            if (!(sender is DevExpress.XtraEditors.SimpleButton))
            {
                return;
            }
            DevExpress.XtraEditors.SimpleButton Btntest = (DevExpress.XtraEditors.SimpleButton)(sender);

            int Index = Btntest.TabIndex;
            Sel_Recipe frm = new Sel_Recipe(Index);
            frm.ShowDialog();

            for (int i = 0; i < 4; i++)
            {
                if (TxtData.PublicData.ProductName.Length>i&&TxtData.PublicData.ProductName[i]!=null)
                {

                    switch (i)
                    {
                        case 0:
                            LL_WP1.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;
                        case 1:
                            LL_WP2.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;
                        case 2:
                            LL_WP3.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;
                        case 3:
                            LL_WP4.Text = "产品名称:" + TxtData.PublicData.ProductName[i][0];
                            break;

                    }



                }

            }
        }

        private void SE_WorkPlaceCount_ValueChanged(object sender, EventArgs e)
        {
            TxtData.PublicData.WorkPlaceCount = (int)SE_WorkPlaceCount.Value;
            GC_WP1.Enabled = SE_WorkPlaceCount.Value > 0;
            GC_WP2.Enabled = SE_WorkPlaceCount.Value > 1;
            GC_WP3.Enabled = SE_WorkPlaceCount.Value > 2;
            GC_WP4.Enabled = SE_WorkPlaceCount.Value > 3;

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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Download_Click(object sender, EventArgs e)
        {
            if (!TxtData.SoapData.IsHome)
            {
                MessageBox.Show("机械手臂请先回零!");
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





            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait();
            frm.ShowDialog();



 


         





        }



        void Poll(object target)
        {

            TxtData.MdbData.PresetData[4] =(double) SE_Pan.Value;
            TxtData.MdbData.IODelay[3] = (double)SE_Wait.Value;
            TxtData.MdbData.HomeSpeed = (double)SE_Home.Value;
            TxtData.PublicData.CycleCount = (int)SE_Cycle.Value;
            TxtData.PublicData.TriggleMode = CBE_Triggle.SelectedIndex;
            if (!db.EditProductPara(CBE_Triggle.SelectedIndex, (int)SE_Cycle.Value, TxtData.PublicData.WorkPlaceCount)||
                !db.EditConfigure(TxtData.MdbData.PresetData, "PRESETDATA")||
           ! db.EditConfigure(TxtData.MdbData.IODelay, "IODELAY")||
            !db.EditConfigure(TxtData.MdbData.StepLength,TxtData.MdbData.HomeSpeed))
            {

                TxtData.PublicData.ErrorCode = 37;
                return;
            }

            if (!db.SavePreset())
            {
                TxtData.PublicData.ErrorCode = 1;
                return;
            }

            if (!db.SaveAction())
            {
                TxtData.PublicData.ErrorCode = 2;
                return;
            }


            RobotKit.FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);



            double[] tool = db.GetTool();
            if (tool == null || tool.Length != 6 || TxtData.MdbData.Tool == null || TxtData.MdbData.Tool.Length != 6)
            {
                TxtData.PublicData.ErrorCode = 42;
                return;
            }
            for (int i = 0; i < 6; i++)
            {
                if (tool[i] != TxtData.MdbData.Tool[i])
                {
                    TxtData.PublicData.ErrorCode = 42;
                    return;
                }
            }
            double[] home = db.GetHome();
            if (home == null || home.Length != 6 || TxtData.MdbData.Home == null || TxtData.MdbData.Home.Length != 6)
            {
                TxtData.PublicData.ErrorCode = 44;
                return;
            }
            for (int i = 0; i < 6; i++)
            {
                if (home[i] != TxtData.MdbData.Home[i])
                {
                    TxtData.PublicData.ErrorCode = 44;
                    return;
                }
            }
            //**************************************

            if (!db.SaveCs8cConfigure())
            {
                TxtData.PublicData.ErrorCode = 3;
                return;
            }



            if (!ftp.UpLoadPreset())
            {
                TxtData.PublicData.ErrorCode = 21;
                return;
            }
            if (!ftp.UploadAction())
            {
                TxtData.PublicData.ErrorCode = 22;
                return;
            }
            if (!ftp.UploadConfigure())
            {
                TxtData.PublicData.ErrorCode = 23;
                return;
            }

            //****************************************************************************************************************
            //2013.10.31
            for (int i = 0; i < TxtData.PublicData.WorkPlaceCount; i++)
            {
                for (int j = 0; j < TxtData.PublicData.ProductCount[i]; j++)
                {

                    if (!db.SaveProduct(i+1, TxtData.PublicData.ProductName[i][j], TxtData.PublicData.MatchPresetName[i][j], TxtData.PublicData.TrajByPass[i][j]))
                    {
                        TxtData.PublicData.ErrorCode = 3 + i + 1;
                        return;
                    }
                    if (TxtData.PublicData.MatchPresetName[i][j] != "StaubliPreset" && !db.SavePreset(i+1, TxtData.PublicData.MatchPresetName[i][j]))
                    {
                        TxtData.PublicData.ErrorCode = 7 + i + 1;
                        return;
                    }
                    if (TxtData.MdbData.EnableItem[4])
                    {
                        string FileName = (i+1).ToString() + "Product" + (j + 1).ToString() + ".txt";
                        File.Copy(Application.StartupPath + "\\Txt\\" + "product" + (i+1).ToString() + ".txt", Application.StartupPath + "\\Txt\\" + FileName, true);
                        if (!ftp.UpLoadProduct(FileName))
                        {
                            TxtData.PublicData.ErrorCode = 23 + i;
                            return;
                        }
                    }
                    else
                    {


                        if (!ftp.UpLoadProduct(i+1))
                        {
                            TxtData.PublicData.ErrorCode = 23 + i;
                            return;
                        }
                    }

                    //设置需要生产的产品的名称
                    if (!SoapInstance.SoapRead.SetAppdata("sProductName[" + (i + 1).ToString() + "]", TxtData.PublicData.ProductName[i][j]))
                    {
                        TxtData.PublicData.ErrorCode = 12;
                        return;
                    }
                    //if (!SoapInstance.SoapRead.SetAppdata(@"sProductName[1]", TxtData.PublicData.ProductName[i][j]))
                    //{
                    //    TxtData.PublicData.ErrorCode = 12;
                    //    return;
                    //}
                    if (TxtData.PublicData.MatchPresetName[i][j] != "StaubliPreset" && !ftp.UpLoadPreset(i+1))
                    {
                        TxtData.PublicData.ErrorCode = 27 + i;
                        return;
                    }
                }
            }
            //****************************************************************************************************************
            //同工位多产品
            //2014.05.30
            if (TxtData.MdbData.EnableItem[4])
            {
                for (int i = 1; i <= TxtData.PublicData.WorkPlaceCount; i++)
                {
                    if (!SoapInstance.SoapRead.SetAppdata("nWpMutiCount["+i.ToString()+"]", TxtData.PublicData.ProductCount[i-1]))
                    {
                        TxtData.PublicData.ErrorCode = 12;
                        return;
                    }
                }

            }

            //if (!SoapInstance.SoapRead.SetAppdata("sCustom", (CBE_Custom.Text==null)?"  ":CBE_Custom.Text))
            if (!SoapInstance.SoapRead.SetAppdata("sCustom", CBE_Custom.Text ))
            {
                TxtData.PublicData.ErrorCode = 12;
                return;
            }

            if (!SoapInstance.SoapRead.SetAppdata("nCycleMode", CBE_Triggle.SelectedIndex))
            {
                TxtData.PublicData.ErrorCode = 12;
                return;
            }
            if (!SoapInstance.SoapRead.SetAppdata("nCycleCount", (int)SE_Cycle.Value))
            {
                TxtData.PublicData.ErrorCode = 12;
                return;
            }
            if (!SoapInstance.SoapRead.SetAppdata("nWorkPlaceCount", TxtData.PublicData.WorkPlaceCount))
            {
                TxtData.PublicData.ErrorCode = 12;
                return;
            }

            if (!SoapInstance.SoapRead.SetAppdata("nInterfaceType", 13))
            {
                TxtData.PublicData.ErrorCode = 12;
                return;
            }
            db.AddLog("下载生产信息");
            TxtData.PublicData.ErrorCode = 40;
        }
        private void BT_Simu_Click(object sender, EventArgs e)
        {

        }

        private void TB_View1_Click(object sender, EventArgs e)
        {
            if (TxtData.PublicData.WorkPlaceCount<1||TxtData.PublicData.ProductName==null||TxtData.PublicData.ProductName[0]==null)
            {
                MessageBox.Show("生产参数没有设置");
                return;
            }


            if (!(sender is DevExpress.XtraEditors.SimpleButton))
            {
                return;
            }
            DevExpress.XtraEditors.SimpleButton Btntest = (DevExpress.XtraEditors.SimpleButton)(sender);

            int Index = Btntest.TabIndex;
            Sel_Recipe frm = new Sel_Recipe(Index,true);
            frm.ShowDialog();

        }
    }
}
