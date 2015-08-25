using System;
using System.IO;
using System.Management;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using RobotKit;

namespace RobotPolish
{
    class PublicFunc
    {


        public static bool MatalData()
        {

            try
            {
                if (PolishTxt.PointData == null || PolishTxt.SpeedData == null || PolishTxt.PointData.GetLength(0) != PolishTxt.SpeedData.Length || PolishTxt.PointData.GetLength(1) != 6)
                {

                    return false;
                }


                for (int k = 0; k < PolishTxt.PointData.GetLength(0); k++)
                {
                    double[] tt = new double[6];

                    for (int i = 3; i < 6; i++)
                    {
                        tt[i] = PolishTxt.PointData[k, i];
                    }
                    tt[3] = -tt[3];
                    double[] buffver = Val3.TrsfTrsf(new double[] { 0, 0, 0, 180, 0, 180 }, tt);



                    if (buffver == null)
                    {
                        return false;
                    }

                    for (int i = 3; i < 6; i++)
                    {
                        PolishTxt.PointData[k, i] = buffver[i];
                    }


                }


                for (int k = 0; k < PolishTxt.BeforePointData.GetLength(0); k++)
                {
                    double[] tt = new double[6];

                    for (int i = 3; i < 6; i++)
                    {
                        tt[i] = PolishTxt.BeforePointData[k, i];
                    }
                    tt[3] = -tt[3];
                    
                    
                    double[] buffver = Val3.TrsfTrsf(new double[] { 0, 0, 0, 180, 0, 180 }, tt);



                    if (buffver == null)
                    {
                        return false;
                    }

                    for (int i = 3; i < 6; i++)
                    {
                        PolishTxt.BeforePointData[k, i] = buffver[i];
                    }


                }






                double[] buff = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    buff[i] = PolishTxt.PointData[PolishTxt.PointData.GetLength(0) - 1, i];
                }
                buff = Val3.TrsfTrsf(buff, new double[] { 0, 0, -50, 0, 0, 0 });
                if (buff == null)
                {
                    return false;
                } PolishTxt.AfterPointData = new double[1, 6];

                for (int i = 0; i < 6; i++)
                {
                    PolishTxt.AfterPointData[0, i] = buff[i];
                }






                return true;

            }
            catch
            {

                return false;
            }










        }

        public static double[][] DiffTool(double[] data)
        {

            if (data == null || data.Length < 6)
            {
                return null;
            }

            double[][] res = new double[10][];
            for (int i = 0; i < 5; i++)
            {
                res[i] = RobotKit.Val3.InverserToolZ(data, (i + 1) * 10);
            }

            for (int i = 0; i < 5; i++)
            {
                res[i + 5] = RobotKit.Val3.InverserToolZ(data, -(i + 1) * 10);
            }

            return res;
        }
        public static bool SaveTxt(string FileName, string[] txt)
        {
            FileStream fs = null;
            try
            {
                if (FileName == null || txt == null || txt.Length < 1)
                {
                    return false;
                }
                fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    for (int i = 0; i < txt.Length; i++)
                    {

                        sw.WriteLine(txt[i]);
                    }

                }
                return true;
            }

            catch
            {
                return false;

            }
            finally
            {

                if (fs != null)
                {
                    fs.Close();

                }


            }
        }


        public static bool SaveTxt(string FileName, string txt)
        {
            return SaveTxt(FileName, new string[] { txt });
        }
        public static string SfD_Show(string Name)
        {


            return SfD_Show(Name, null);

        }

        public static string SfD_Show(string Name, string FileType)
        {
            System.Windows.Forms.SaveFileDialog sfd = null;
            try
            {
                sfd = new SaveFileDialog();
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                if (Name != null)
                {
                    sfd.FileName = Name;
                }
                if (FileType == null)
                {
                    sfd.Filter = "文本文件(*.txt)|*.txt";
                }
                else
                {
                    sfd.Filter = FileType;

                }
                if (DialogResult.OK != sfd.ShowDialog())
                {
                    return null;
                }
                return sfd.FileName;

            }
            catch
            {
                return null;
            }
            finally
            {

            }
        }
        public static string SfD_Show()
        {
            return SfD_Show(null);
        }




        public static string OpenDir_Show()
        {
            return OpenDir_Show(Application.StartupPath + "\\Txt");
        }
        public static string OpenDir_Show(string DirPath)
        {
            return OpenDir_Show(DirPath, "txt文件|*.txt");
        }



        public static string OpenDir_Show(string DirPath, string FileFilter)
        {
            System.Windows.Forms.OpenFileDialog ofg = null;
            try
            {
                //  string FileFilter = "txt文件|*.txt";
                ofg = new OpenFileDialog();
                if (Directory.Exists(DirPath))
                {
                    ofg.InitialDirectory = DirPath;
                }
                else
                {
                    ofg.InitialDirectory = Application.StartupPath;
                }
                ofg.Filter = FileFilter;

                //打开文件
                if (ofg.ShowDialog() != DialogResult.OK)
                {
                    return null;
                }
                else
                {
                    return ofg.FileName;
                }

            }
            catch
            {


                return null;
            }
            finally
            {


            }

        }
        public static bool IsRecipeOk(string FileName)
        {

            if (FileName == null || !File.Exists(FileName))
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;
            string[] data = null;
            int LineCount = 0;
            int TrajCount = 0;
            int TrajIndex = 0;
            int TrajType = 0;
            int PointCount = 0;

            TxtData.Recipe.TrajTypeName = new string[] 
        {
        
        "",   "圆-三点法-内切","圆-圆心&直径法-内切", "三角形-内切", "矩形-内切", //5
        "正五边形-内切", "正六边形-内切", "腰形孔-内切", "", "", "不规则图形",//10
          "圆-三点法-外切","圆-圆心&直径法-外切","三角形-外切", "矩形-外切",//15
         "正五边形-外切", "正六边形-外切", "腰形孔-外切","","同步不规则图形",//20
         "","五角星","切圆管","","C型 三点法",//25
         "","",""
        };

            int[,] TrajFlag = null;
            try
            {

                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {
                    LineCount++;
                    StrLine = StrLine.Trim();
                    if (StrLine == "")
                    {
                        continue;

                    }


                    if (StrLine.IndexOf("TOOL=") >= 0)
                    {
                        data = StrLine.Substring(5, StrLine.Length - 6).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }


                    }

                    if (StrLine.IndexOf("TOTALELEMENTS=") >= 0)
                    {
                        string Buff = StrLine.Substring("TOTALELEMENTS=".Length, StrLine.Length - "TOTALELEMENTS=".Length);

                        TrajCount = int.Parse(Buff);
                        TrajFlag = new int[TrajCount + 1, 20];
                        //对数据进行判断
                        TxtData.Recipe.TotalTraj = TrajCount;
                        TrajCount++; ;
                        TxtData.Recipe.TrajFrame = new double[TrajCount, 6];
                        TxtData.Recipe.TrajOffset = new double[TrajCount, 6];
                        TxtData.Recipe.TrajType = new int[TrajCount];
                        TxtData.Recipe.TrajName = new string[TrajCount + 1];
                        TxtData.Recipe.WorkPlace = new double[TrajCount, 6];
                        TxtData.Recipe.TrajByPass = new bool[TrajCount];
                        TxtData.Recipe.Array = new double[TrajCount, 6];
                        TxtData.Recipe.DownLead = new double[TrajCount, 6];
                        TxtData.Recipe.TrajPointCount = new int[TrajCount, 3];

                        TxtData.Recipe.bAppro = new bool[TrajCount][];
                        TxtData.Recipe.bMoveC = new bool[TrajCount][];
                        TxtData.Recipe.bLeave = new bool[TrajCount][];

                        TxtData.Recipe.pAppro = new double[TrajCount][,];
                        TxtData.Recipe.pCut = new double[TrajCount][,];
                        TxtData.Recipe.pMoveC = new double[TrajCount][,];
                        TxtData.Recipe.pLeave = new double[TrajCount][,];

                        TxtData.Recipe.mAppro = new double[TrajCount][,];
                        TxtData.Recipe.mCut = new double[TrajCount][,];
                        TxtData.Recipe.mLeave = new double[TrajCount][,];
                        TrajCount--;
                        TxtData.Recipe.RecipeFrame = new double[6];
                        TxtData.Recipe.RecipeOffset = new double[6];





                    }



                    if (StrLine.IndexOf("BEGIN=") >= 0)
                    {

                        TrajIndex++;
                        TrajFlag[TrajIndex, 0]++;
                        PointCount = 0;
                        TxtData.Recipe.TrajName[TrajIndex] = StrLine.Substring("BEGIN=".Length, StrLine.Length - "BEGIN=".Length);

                    }

                    if (StrLine.IndexOf("BYPASS=") >= 0)
                    {
                        TrajFlag[TrajIndex, 1]++;
                        TxtData.Recipe.TrajByPass[TrajIndex] = (StrLine.ToUpper().IndexOf("TRUE") >= 0);

                    }
                    if (StrLine.IndexOf("CUTTYPE=") >= 0)
                    {
                        TrajFlag[TrajIndex, 2]++;
                        string Buff = StrLine.Substring("CUTTYPE=".Length, StrLine.Length - "CUTTYPE=".Length);
                        TrajType = int.Parse(Buff);
                        TxtData.Recipe.TrajType[TrajIndex] = TrajType;

                    }
                    if (StrLine.IndexOf("ARRAY=") >= 0)
                    {
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 3]++;
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.Recipe.Array[TrajIndex, i] = double.Parse(data[i + 0]);
                        }
                    }

                    if (StrLine.IndexOf("POINTCOUNT=") >= 0)
                    {
                        string Buff = StrLine.Substring("POINTCOUNT=".Length, StrLine.Length - "POINTCOUNT=".Length);
                        data = Buff.Split(',');
                        if (data == null || data.Length != 3)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 4]++;
                        TrajFlag[TrajIndex, 15] = int.Parse(data[0]);
                        TrajFlag[TrajIndex, 16] = int.Parse(data[1]);
                        TrajFlag[TrajIndex, 17] = int.Parse(data[2]);

                        data[0] = (TrajFlag[TrajIndex, 15] + 1).ToString();
                        data[1] = (TrajFlag[TrajIndex, 16] + 1).ToString();
                        data[2] = (TrajFlag[TrajIndex, 17] + 1).ToString();


                        TxtData.Recipe.TrajPointCount[TrajIndex, 0] = TrajFlag[TrajIndex, 15];
                        TxtData.Recipe.TrajPointCount[TrajIndex, 1] = TrajFlag[TrajIndex, 16];
                        TxtData.Recipe.TrajPointCount[TrajIndex, 2] = TrajFlag[TrajIndex, 17];

                        TxtData.Recipe.bAppro[TrajIndex] = new bool[int.Parse(data[0])];
                        TxtData.Recipe.bMoveC[TrajIndex] = new bool[int.Parse(data[1])];
                        TxtData.Recipe.bLeave[TrajIndex] = new bool[int.Parse(data[2])];

                        TxtData.Recipe.pAppro[TrajIndex] = new double[int.Parse(data[0]), 6];
                        TxtData.Recipe.pCut[TrajIndex] = new double[int.Parse(data[1]), 6];
                        TxtData.Recipe.pMoveC[TrajIndex] = new double[int.Parse(data[1]), 6];
                        TxtData.Recipe.pLeave[TrajIndex] = new double[int.Parse(data[2]), 6];

                        TxtData.Recipe.mAppro[TrajIndex] = new double[int.Parse(data[0]), 6];
                        TxtData.Recipe.mCut[TrajIndex] = new double[int.Parse(data[1]), 6];
                        TxtData.Recipe.mLeave[TrajIndex] = new double[int.Parse(data[2]), 6];


                    }

                    if (StrLine.IndexOf("FRAME=") >= 0)
                    {
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 5]++;

                        for (int i = 0; i < 6; i++)
                        {
                            if (TrajIndex < 1)
                            {
                                TxtData.Recipe.RecipeFrame[i] = double.Parse(data[i]);
                            }
                            else
                            {
                                TxtData.Recipe.TrajFrame[TrajIndex, i] = double.Parse(data[i]);
                            }

                        }



                    }
                    if (StrLine.IndexOf("OFFSET=") >= 0)
                    {
                        data = StrLine.Substring(7, StrLine.Length - 7).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 6]++;
                        for (int i = 0; i < 6; i++)
                        {
                            if (TrajIndex < 1)
                            {
                                TxtData.Recipe.RecipeOffset[i] = double.Parse(data[i]);
                            }
                            else
                            {
                                TxtData.Recipe.TrajOffset[TrajIndex, i] = double.Parse(data[i]);
                            }

                        }
                    }


                    if (StrLine.IndexOf("DOWNLEAD=") >= 0)
                    {
                        data = StrLine.Substring(9, StrLine.Length - 9).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 7]++;
                        for (int i = 0; i < 6; i++)
                        {

                            TxtData.Recipe.DownLead[TrajIndex, i] = double.Parse(data[i]);


                        }

                    }
                    if (StrLine.IndexOf("WORKPLACE=") >= 0)
                    {
                        data = StrLine.Substring(10, StrLine.Length - 10).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 8]++;
                        for (int i = 0; i < 6; i++)
                        {

                            TxtData.Recipe.WorkPlace[TrajIndex, i] = double.Parse(data[i]);


                        }
                    }
                    if (StrLine.IndexOf("MOVEJ=") >= 0)
                    {
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(new char[] { ',', '/' });
                        if (data.Length != 8)
                        {
                            return false;
                        }
                        PointCount++;
                        if (TrajFlag[TrajIndex, 10] == 0)
                        {
                            TrajFlag[TrajIndex, 9]++;
                            TxtData.Recipe.bAppro[TrajIndex][PointCount] = false;
                            for (int i = 0; i < 6; i++)
                            {
                                TxtData.Recipe.pAppro[TrajIndex][PointCount, i] = double.Parse(data[i]);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                TxtData.Recipe.mAppro[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                            }

                        }
                        else
                        {
                            TrajFlag[TrajIndex, 13]++;
                            TxtData.Recipe.bLeave[TrajIndex][PointCount] = false;
                            for (int i = 0; i < 6; i++)
                            {
                                TxtData.Recipe.pLeave[TrajIndex][PointCount, i] = double.Parse(data[i]);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                TxtData.Recipe.mLeave[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                            }


                        }
                    }
                    if (StrLine.IndexOf("MOVEL=") >= 0)
                    {
                        PointCount++;
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(new char[] { ',', '/' });
                        if (data.Length < 8)
                        {
                            return false;
                        }
                        if (TrajFlag[TrajIndex, 10] == 0)
                        {
                            TrajFlag[TrajIndex, 9]++;
                            TxtData.Recipe.bAppro[TrajIndex][PointCount] = true;
                            for (int i = 0; i < 6; i++)
                            {
                                TxtData.Recipe.pAppro[TrajIndex][PointCount, i] = double.Parse(data[i]);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                TxtData.Recipe.mAppro[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                            }
                        }
                        else
                        {


                            if (TrajFlag[TrajIndex, 12] == 0)
                            {
                                TrajFlag[TrajIndex, 11]++;
                                TxtData.Recipe.bMoveC[TrajIndex][PointCount] = false;
                                for (int i = 0; i < 6; i++)
                                {
                                    TxtData.Recipe.pCut[TrajIndex][PointCount, i] = double.Parse(data[i]);
                                }
                                for (int i = 0; i < 5; i++)
                                {
                                    TxtData.Recipe.mCut[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                                }
                            }
                            else
                            {
                                TrajFlag[TrajIndex, 13]++;
                                TxtData.Recipe.bLeave[TrajIndex][PointCount] = true;
                                for (int i = 0; i < 6; i++)
                                {
                                    TxtData.Recipe.pLeave[TrajIndex][PointCount, i] = double.Parse(data[i]);
                                }
                                for (int i = 0; i < 2; i++)
                                {
                                    TxtData.Recipe.mLeave[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                                }
                            }
                        }
                    }
                    if (StrLine.IndexOf("MOVEC=") >= 0)
                    {
                        PointCount++;
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(new char[] { ',', '/' });
                        if (data.Length < 17)
                        {
                            return false;
                        }
                        if (TrajFlag[TrajIndex, 12] != 0)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 11]++;

                        TxtData.Recipe.bMoveC[TrajIndex][PointCount] = true;
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.Recipe.pCut[TrajIndex][PointCount, i] = double.Parse(data[i]);
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.Recipe.pMoveC[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            TxtData.Recipe.mCut[TrajIndex][PointCount, i] = double.Parse(data[i + 12]);
                        }

                    }
                    if (StrLine.IndexOf("DELAYON=") >= 0)
                    {
                        TrajFlag[TrajIndex, 10]++;
                        PointCount = 0;
                    }
                    if (StrLine.IndexOf("DELAYOFF=") >= 0)
                    {
                        TrajFlag[TrajIndex, 12]++;
                        PointCount = 0;

                    }


                    if (StrLine.IndexOf("END=") >= 0)
                    {
                        TrajFlag[TrajIndex, 14]++;
                        //if (TrajFlag[TrajIndex, 9] != TrajFlag[TrajIndex, 15] || TrajFlag[TrajIndex, 11] != TrajFlag[TrajIndex, 16] || TrajFlag[TrajIndex, 13] != TrajFlag[TrajIndex, 17])
                        //{
                        //    return false;
                        //}
                        //if (TrajType != 10 && TrajType != 2 && TrajType != 12 && TrajFlag[TrajIndex, 11] != 3)
                        //{
                        //    return false;
                        //}
                    }



                }
                if (TrajCount != 0)
                {

                    for (int j = 1; j <= TrajCount; j++)
                    {
                        for (int i = 0; i <= 14; i++)
                        {
                            if (TrajFlag[j, i] != 1 && i != 9 && i != 11 && i != 13)
                            {
                                return false;
                            }
                        }

                    }
                }

                return true;
            }
            catch
            {
                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }

        }

        public static bool IsTool(string FileName)
        {
            if (FileName == null || !File.Exists(FileName))
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;


            try
            {


                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {

                    StrLine = StrLine.Trim().ToUpper();
                    if (StrLine.IndexOf("BEGIN") >= 0)
                    {
                        return true;
                    }
                    if (StrLine.IndexOf("TOOL=") >= 0)
                    {
                        StrLine = StrLine.Substring("TOOL=".Length, StrLine.Length - "TOOL=".Length);
                        string[] data = StrLine.Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            if (double.Parse(data[i]) != TxtData.MdbData.Tool[i])
                            {
                                return false;
                            }
                        }
                        return true;
                        //    return StrLine == ("TOOL=" + TxtData.MdbData.Tool[0].ToString() + "," + TxtData.MdbData.Tool[1].ToString() + "," + TxtData.MdbData.Tool[2].ToString() + ","
                        //                    + TxtData.MdbData.Tool[3].ToString() + "," + TxtData.MdbData.Tool[4].ToString() + "," + TxtData.MdbData.Tool[5].ToString());
                        //}
                    }
                }
                return true;

            }
            catch
            {


                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }


        public static bool IsFrame(string FileName, double[] Frame, ref string[] frm)
        {
            if (FileName == null || !File.Exists(FileName) || Frame == null || Frame.Length < 6)
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;


            try
            {


                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {

                    StrLine = StrLine.Trim().ToUpper();
                    if (StrLine.IndexOf("BEGIN") >= 0)
                    {
                        return true;
                    }
                    if (StrLine.IndexOf("FRAME=") == 0)
                    {
                        StrLine = StrLine.Substring(6, StrLine.Length - 6);
                        string[] data = StrLine.Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        frm = data;
                        for (int i = 0; i < 6; i++)
                        {
                            if (double.Parse(data[i]) != Frame[i])
                            {
                                return false;
                            }
                        }
                        return true;
                        //    return StrLine == ("TOOL=" + TxtData.MdbData.Tool[0].ToString() + "," + TxtData.MdbData.Tool[1].ToString() + "," + TxtData.MdbData.Tool[2].ToString() + ","
                        //                    + TxtData.MdbData.Tool[3].ToString() + "," + TxtData.MdbData.Tool[4].ToString() + "," + TxtData.MdbData.Tool[5].ToString());
                        //}
                    }
                }
                return true;

            }
            catch
            {


                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }




        static public bool ReadCs8CLog(out string[] Date, out string[] Txt)
        {
            return ReadCs8CLog(out Date, out Txt, Application.StartupPath + "\\Txt\\errors.log");
        }

        static public bool ReadCs8CLog(out string[] Date, out string[] Txt, string FileName)
        {
            Date = null;
            Txt = null;
            if (FileName == null || !File.Exists(FileName))
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;
            string[] data = null;
            int LineCount = 0;
            Txt = new string[10000];
            Date = new string[10000];
            int j = 0;
            try
            {

                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {
                    LineCount++;
                    StrLine = StrLine.Trim();
                    if (StrLine == "")
                    {
                        continue;

                    }
                    data = StrLine.Split(new char[] { '[', ']' });
                    if (data != null && data.Length >= 3 && j < 10000)
                    {
                        Date[j] = data[1];
                        Txt[j] = data[2];
                        j++;

                    }

                }
                if (j > 0)
                {
                    Array.Resize(ref Txt, j);
                    Array.Resize(ref Date, j);
                }




                return true;
            }
            catch
            {


                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }



                


        /// <summary>
        /// 备份下数据库
        /// </summary>
        static public void Init()
        {
            TxtData.PolishData.OverTime = RobotSecurity.OverDays(90);

            //2015.05.13
            
            TxtData.PolishData.OverTime = false;
            FileStream fs = null;
            if (!Directory.Exists(Application.StartupPath + "\\Log"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Log");
            }

            if (!Directory.Exists(Application.StartupPath + "\\Txt"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Txt");
            }
            if (!Directory.Exists(Application.StartupPath + "\\BackUpDB"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\BackUpDB");
            }


            if (File.Exists(Application.StartupPath + "\\RobotPolish.mdb"))
            {

                File.Copy(Application.StartupPath + "\\RobotPolish.mdb", Application.StartupPath + "\\BackUpDB\\RobotPolish(" + DateTime.Now.Year.ToString() + "_" +
                    DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ").mdb", true);


            }

        }




        static public bool ReadXMLConfigure()
        {



            TxtData.XMLConfigure.CanUsedDay = int.MaxValue;
            TxtData.XMLConfigure.OverTime = false;
            TxtData.XMLConfigure.LeftUsedDay = int.MaxValue;
            return true;




        }




        /// <summary>
        /// 读取应用程序
        /// </summary>
        /// <param name="data"></param>
        static public void ReadApplication(byte[] data)
        {

            if (data == null || data.Length < 1)
            {
                TxtData.SoapData.InterfaceType = -1;


                return;
            }
            MemoryStream sm = null;
            StreamReader rd = null;
            XmlDocument xd = null;
            try
            {
                sm = new MemoryStream(data);
                sm.Position = 0;
                rd = new StreamReader(sm);
                xd = new XmlDocument();
                xd.LoadXml(rd.ReadToEnd());
                TxtData.SoapData.Upload = StaubliXML.GetXMLBool("bUpload", xd);




                //TxtData.SoapData.CycleIndex = (int)StaubliXML.GetXMLDouble("nCycleIndex", xd);
                //TxtData.SoapData.CycleCount = (int)StaubliXML.GetXMLDouble("nCycleCount", xd);
                //TxtData.SoapData.RobotSpeed = StaubliXML.GetXMLDouble("nRobotSpeed", xd);
                //TxtData.SoapData.WorkPlaceCount = StaubliXML.GetXMLInt("nWorkPlaceCount", xd);
                //TxtData.SoapData.WorkPlaceIndex = StaubliXML.GetXMLInt("nWorkPlaceIndex", xd);
                //TxtData.SoapData.PresetData = StaubliXML.GetXMLIntArray("nPresetData", xd);
                //TxtData.SoapData.CycleTime = StaubliXML.GetXMLDouble("nCycleTime", xd);
                //TxtData.SoapData.PointType = (int)StaubliXML.GetXMLDouble("nPointType", xd);
                //TxtData.SoapData.TrajIndex = (int)StaubliXML.GetXMLDouble("nTrajIndex", xd);
                //TxtData.SoapData.Custom = StaubliXML.GetXMLString("sCustom", xd);
                //TxtData.SoapData.WorkPlaceProductCount = StaubliXML.GetXMLIntArray("nWpProduct", xd);
                //TxtData.SoapData.ProductName = StaubliXML.GetXMLStringArray("sProductName", xd);



                TxtData.SoapData.InterfaceType = StaubliXML.GetXMLInt("nInterfaceType", xd);
                TxtData.SoapData.CurrentJoint = StaubliXML.GetXMLJoint("jCurrentJoint", xd);
                TxtData.SoapData.CurrentPoint = StaubliXML.GetXMLCarten("pCurrent", xd);
                TxtData.SoapData.ToolMode = StaubliXML.GetXMLInt("nWorkingMode", xd);
                TxtData.SoapData.IsHome = StaubliXML.GetXMLBool("bHome", xd);
                TxtData.SoapData.PowerOn = StaubliXML.GetXMLBool("bIsPower", xd);
                TxtData.SoapData.bZero = StaubliXML.GetXMLBool("bZero", xd);
                TxtData.SoapData.BIOValue = StaubliXML.GetXMLBoolArray("bBIO", xd);

                TxtData.SoapData.Home = StaubliXML.GetXMLJoint("jJHome", xd);
                TxtData.SoapData.Tool = StaubliXML.GetXMLCarten("tTTool", xd);
                TxtData.SoapData.Frame = StaubliXML.GetXMLCarten("trFrame", xd);
                TxtData.SoapData.productStatus = StaubliXML.GetXMLStringArray("sPrdStatus", xd);
                TxtData.SoapData.Moveid = StaubliXML.GetXMLDouble("nMoveID", xd);


                TxtData.SoapData.ATIPress = StaubliXML.GetXMLDouble("nATIPress", xd);

            }
            catch
            {
                return;
            }
            finally
            {
                if (sm != null)
                {
                    sm.Close();
                }
                if (rd != null)
                {
                    rd.Close();
                }

            }


        }

        /// <summary>
        /// Soap轮询
        /// </summary>
        /// <returns></returns>
        static public void Poll()
        {

            //对于变量的轮询
            RobotKit.SoapInstance.SoapRead = new RobotKit.SoapClient(TxtData.XMLConfigure.IpAddress);
            RobotKit.SoapInstance.SoapRead.SoapSetAppname = RobotKit.SoapInstance.SoapRead.SoapGetAppname = @"Disk://RobotPolish/RobotPolish.pjx";

            // TxtData.SoapData.SoapStaus =RobotKit.SoapInstance.SoapRead.Login();
            double PollIndex = 0;
            while (!TxtData.SoapData.SoapAbort)
            {
                PollIndex++;
                if (TxtData.SoapData.SoapStaus)
                {

                    if (RobotKit.SoapInstance.SoapRead.ExistAppname(TxtData.PolishData.ExistAppName))
                    {
                        System.Threading.Thread.Sleep(10);
                        ReadApplication(RobotKit.SoapInstance.SoapRead.GetAppdata());
                    }
                    else
                    {
                        TxtData.SoapData.SoapStaus = RobotKit.SoapInstance.SoapRead.PingNet();

                    }
                    //查看温度
                    if (PollIndex % 20 == 0 && TxtData.SoapData.SoapStaus)
                    {
                        System.Threading.Thread.Sleep(100);
                        TxtData.SoapData.ControllerTemp = SoapInstance.SoapRead.ReadIOValue("CBT_TEMP");
                    }

                }
                else
                {
                    PollIndex = 0;
                    //  if (StaubliRobot.SoapInstance.SoapRead.Ping())
                    if (RobotKit.SoapInstance.SoapRead.PingNet())
                    {
                        TxtData.SoapData.SoapStaus = RobotKit.SoapInstance.SoapRead.Login();

                    }
                    else
                    {
                        TxtData.SoapData.SoapStaus = false;
                    }

                }

                System.Threading.Thread.Sleep(100);
            }

        }



    }
}
