//using System.Linq;
using System;
using System.Windows.Forms;
using RobotKit;
using System.Drawing;


namespace RobotPolish
{
    public partial class Frm_Axis : Std_Form
    {
        private bool[] Buff;
        private int Speed;
        public Frm_Axis()
        {
            InitializeComponent();
            Buff = TxtData.SoapData.BIOValue;
            if (TxtData.SoapData.BIOValue != null && TxtData.SoapData.BIOValue.Length == 32)
            {
                RB_EnablePower.Checked = TxtData.SoapData.BIOValue[22];
                RB_DisablePower.Checked = !RB_EnablePower.Checked;


                int T = 0;
                for (int i = 0; i < 6; i++)
                {
                    T = T + (int)((TxtData.SoapData.BIOValue[16 + i] ? 1 : 0) * Math.Pow(2, i));
                }

                NUD_Speed.Value = T;

                RB_ATIOPEN.Checked = TxtData.SoapData.bZero;
               RB_ATICLOSE.Checked = !RB_ATIOPEN.Checked;

                R_M_Enable.Checked = TxtData.SoapData.BIOValue[23];
                R_M_DisEnable.Checked = !R_M_Enable.Checked;

                R_T_Enable.Checked = TxtData.SoapData.BIOValue[25];
                R_T_DisEnable.Checked = !R_M_Enable.Checked;

            }
        }

        private void BT_T1_Click(object sender, EventArgs e)
        {
            if (TxtData.SoapData.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            //if (TxtData.SoapData.ToolMode != 1)
            //{
            //    MessageBox.Show("请切换到手动模式!");
            //    return;
            //}

            if (NUD_Speed.Value != Speed)
            {
                int Buff = (int)NUD_Speed.Value;
                for (int i = 5; i >= 0; i--)
                {
                    if (!SoapInstance.SoapRead.SetAppDIO(TxtData.PolishData.AppName, TxtData.PolishData.BDOName[i], Buff >= Math.Pow(2, i)))
                    {
                        MessageBox.Show(TxtData.PolishData.BDOName[i] + "设置数据失败！");
                        return;
                    }
                    if (Buff >= Math.Pow(2, i))
                    {
                        Buff = Buff - (int)(Math.Pow(2, i));
                    }
                }

            }

            if (RB_EnablePower.Checked != TxtData.SoapData.BIOValue[22])
            {

                if (!SoapInstance.SoapRead.SetAppDIO(TxtData.PolishData.AppName, TxtData.PolishData.BDIOName[22], RB_EnablePower.Checked))
                {
                    MessageBox.Show(TxtData.PolishData.BDIOName[22] + "设置数据失败！");
                    return;
                }

            }
            if (RB_EnablePower.Checked != TxtData.SoapData.BIOValue[22])
            {

                if (!SoapInstance.SoapRead.SetAppDIO(TxtData.PolishData.AppName, TxtData.PolishData.BDIOName[22], RB_EnablePower.Checked))
                {
                    MessageBox.Show(TxtData.PolishData.BDIOName[22] + "设置数据失败！");
                    return;
                }

            }
            if (R_M_Enable.Checked != TxtData.SoapData.BIOValue[23])
            {

                if (!SoapInstance.SoapRead.SetAppDIO(TxtData.PolishData.AppName, TxtData.PolishData.BDIOName[23], RB_EnablePower.Checked)
                    || !SoapInstance.SoapRead.SetAppDIO(TxtData.PolishData.AppName, TxtData.PolishData.BDIOName[24], !RB_EnablePower.Checked))
                {
                    MessageBox.Show(TxtData.PolishData.BDIOName[22] + "设置数据失败！");
                    return;
                }

            }
            if (RB_ATIOPEN.Checked != TxtData.SoapData.bZero)
            {

                if (!SoapInstance.SoapRead.SetAppDIO("ati:bZero", RB_ATIOPEN.Checked))
                {
                    MessageBox.Show("ati:bZero" + "设置数据失败！");
                    return;
                }

            }if (((double)ND_ATI.Value)!= TxtData.SoapData.ATIPress)
            {

                if (!SoapInstance.SoapRead.SetAppdata("nATIPress", (double)ND_ATI.Value))
                {
                    MessageBox.Show("nATIPress" + "设置数据失败！");
                    return;
                }

            }
                        
            MessageBox.Show("设置数据成功");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TxtData.SoapData.BIOValue != null && TxtData.SoapData.BIOValue.Length == 32)
            {
                LL_MainPower.Text = TxtData.SoapData.BIOValue[22] ? "主轴[上]电" : "主轴[下]电";
                LL_MainEnable.Text = TxtData.SoapData.BIOValue[23] ? "主轴[启动]" : "主轴[停止]";
               LL_ATI.Text = TxtData.SoapData.bZero? "置零ATI数据[开]" : "置零ATI数据[关]";

                LL_TEnable.Text = TxtData.SoapData.BIOValue[25] ? "转台[启动]" : "转台[停止]";


                LL_MainPower.ForeColor = TxtData.SoapData.BIOValue[22] ? System.Drawing.Color.Red : System.Drawing.Color.Black;
                LL_MainEnable.ForeColor = TxtData.SoapData.BIOValue[23] ? System.Drawing.Color.Red : System.Drawing.Color.Black;
                LL_TEnable.ForeColor = TxtData.SoapData.BIOValue[25] ? System.Drawing.Color.Red : System.Drawing.Color.Black;

                LL_ATI.ForeColor = TxtData.SoapData.bZero ? System.Drawing.Color.Red : System.Drawing.Color.Black;
                int T = 0;
                for (int i = 0; i < 6; i++)
                {
                    T = T + (int)((TxtData.SoapData.BIOValue[16 + i] ? 1 : 0) * Math.Pow(2, i));
                }

                Speed = T;
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

        }




    }
}
