namespace RobotPolish
{
    class TxtData
    {

        /// <summary>
        /// 下位机配置文件
        /// </summary>
        public struct MdbData
        {

            //public static bool BigFileMode = false;
            //public static bool TeachToolCaiEnable = false;
            //public static bool MoveBackEnable = false;
            //public static bool BoxCarEnable = false;
            //public static bool Axis7Enable = false;
            //public static bool StepMoveEnable = false;
            //public static bool WeldEnable = false;

            public static bool [] EnableItem=new bool [8];
            public static double HomeSpeed = 0;

            public static double StepLength=0;




       
            public static double[] Home=new double[6];
            public static double[] Tool=new double[6];
            public static double[] Cornerdata=new double[6];
            public static double[] ExtAxisData=new double[6];
            public static double[] Ext8AxisData = new double[6];
            public static double[] Sync7Axis = new double[6];
            public static double[] Sync8Axis = new double[6];
            public static double[] PresetData=new double[6];
            public static double[] IODelay=new double[6];
            public static double[] BoxCar=new double[6];


   

        }

        /// <summary>
        /// 产品文件
        /// </summary>
        public struct Recipe
        {
            public static string[] TrajTypeName;

            public static string RecipeName;

            public static int TotalTraj;

            public static string[] TrajName;
            public static int[] TrajType;

            public static bool[] TrajByPass;
            public static int[,] TrajPointCount;
            public static bool[][] bAppro;
            public static bool[][] bMoveC;
            public static bool[][] bLeave;

            public static double[][,] pAppro;
            public static double[][,] pCut;
            public static double[][,] pMoveC;
            public static double[][,] pLeave;

            public static double[][,] mAppro;
            public static double[][,] mLeave;

            public static double[][,] mCut;


            public static double[] RecipeFrame;

            public static double[] RecipeOffset;

            public static double[,] TrajFrame;

            public static double[,] TrajOffset;

            public static double[,] Array;
            public static double[,] DownLead;
            public static double[,] WorkPlace;

            public static double[,] Delay;
            public static string AdjustRecipe;


        }

        /// <summary>
        /// 上下位机相互交换
        /// </summary>
        public struct SoapData
        {

            public static double ATIPress;
            public static double Moveid;
            public static bool bZero;
            public static bool[] BIOValue;
            public static string ControllerTemp;
            public static bool SoapStaus;
            public static bool SoapAbort;
            public static int InterfaceType=-1;

            public static double RobotSpeed;

            public static int ToolMode=-1;
            public static bool IsHome = false;
            public static bool Upload;

            public static string[] productStatus;

            //public static bool AirOn;

            //public static bool FollowOn;
            //public static bool LaserOn;
            public static bool PowerOn;

            public static int ProductCount;

            public static int WorkPlaceCount;

            public static int WorkPlaceIndex;

            public static int[] WorkPlaceProductCount;

            public static int CycleIndex;

            public static int CycleCount;

            public static double CycleTime;

            public static string[] ProductName;

            public static double ID;
            public static int TrajIndex;
            public static int PointType;

            public static double Version;

            public static double[] CurrentJoint;
            public static double[] CurrentPoint;

            public static double[] Home;
            public static double[] Tool;

            public static double[] Frame;

            public static string ValVersion = "";
            public static string RobotType = "";

            public static int[] PresetData=new int[5];
            public static string Custom;


        }
        /// <summary>
        /// 配置文件
        /// </summary>
        public struct XMLConfigure
        {
            public static string IpAddress="127.0.0.1";
           // public static string Port;
            public static string ToolCode;

            public static string RegCode;

            public static bool AutoLogin=false;

            public static string RestrictCode;
            public static int SoftWareUsedDay;
            public static int CanUsedDay;
            public static bool Reged = false;
            public static bool OverTime = false;
            public static int LeftUsedDay;
            public static int PopeDom = 0;
            public static bool Login = false;
            public static string User = "";
            public static string Password = "";

        }
        



        public struct PublicData
        {
            //不同的工位对应不同的产品
            public static string[][]RecipeName;
            public static string[] TriggleModeText = new string[] { "按钮触发单工位", "按钮触发单周期", "按钮触发多周期", "无需按钮触发","按钮触发排队","用户自定义" };
            public static int TriggleMode = 0;
            public static int CycleCount = 1;
            public static int WorkPlaceCount = 1;
            //数据库中保存的工艺名称
            public static string[] PresetName;
            public static bool FtpLog = false;


            //2013.10.30  需要对这个进行修改
            //public static string[] ProductName=new string[4];
            //public static bool[][] TrajByPass=new bool[4][];
            //public static string[] MatchPresetName = new string[4] { "StaubliPreset", "StaubliPreset", "StaubliPreset", "StaubliPreset"};

            public static string[][] ProductName = new string[10][];
            public static bool[][][] TrajByPass = new bool[10][][];
            public static string[][] MatchPresetName = new string[10][];
            //每个工位的个数
            public static int[] ProductCount=new int[]{1,1,1,1,1,1,1,1,1,1};



            //
            public static int ErrorCode = 0;
            public static int ErrorLine = 0;
            public static bool[,] ScreenEnable=new bool[6,20];
            public static string[] Customs;
            public static string[] Cs8cScreen = new string[] { "", "手动回零", "手动对齐", "编辑工艺", "编辑动作", "编辑产品", "远程生产", "选项配置", "退出程序", "空闲等待", 
                "示教坐标系", "示教偏差", "外部轴", "生产界面", "示教工具", "示教安全点", "", "", "", "", "", "", "", "", "", "", "" };

            public static int[] DeleteTrajIndex;


        }





        public struct RobotGroup
        {


            public static string[] IpAddress = new string[] { "192.168.0.254", "192.168.0.254", "192.168.0.254", "192.168.0.254", "192.168.0.254", 
            "192.168.0.254","192.168.0.254","192.168.0.254","192.168.0.254","192.168.0.254"};
            public static string[] Remark = new string[] { "激光打磨机器人", "激光打磨机器人", "激光打磨机器人", "激光打磨机器人", "激光打磨机器人", 
            "激光打磨机器人","激光打磨机器人","激光打磨机器人","激光打磨机器人","激光打磨机器人"};
          
            public static string[] Status = new string[] { "请小心，运行中", "请小心，运行中", "请小心，运行中", "请小心，运行中", "请小心，运行中",
            "请小心，运行中","请小心，运行中","请小心，运行中","请小心，运行中","请小心，运行中",};
            public static string[] Type = new string[] { "倒挂RX160L", "倒挂RX160L", "倒挂RX160L", "倒挂RX160L", "倒挂RX160L", 
            "倒挂RX160L","倒挂RX160L","倒挂RX160L","倒挂RX160L","倒挂RX160L"};



        }


        /// <summary>
        /// 2015.1.6 
        /// </summary>
        public struct PolishData
        {
            /// <summary>
            /// 
            /// 
            /// 
            /// </summary>
            /// 
            public static string ExistAppName = "Disk://RobotPolish/RobotPolish.pjx";
            public static string TaskName = "readAtiForce";
            public static string AppName = "Disk://IO/IO.pjx";
            public static string[] BDIName = new string[]
            {
                "diB_0_UPS", "diB_1_tableAlm", "diB_2_tableOn", "diB_3_toolAlm", "diB_4_tSpeedOk",
            "diB_5","diB_6","diB_7","diB_8","diB_9","diB_10","diB_11","diB_12","diB_13","diB_14","diB_15"
            };
            public static string[] BDOName = new string[] { "doB_0_speed", "doB_1_speed", "doB_2_speed", "doB_3_speed", "doB_4_speed", "doB_5_speed", 
                "doB_6_toolPower","doB_7_toolOn","doB_8_toolOff","doB_9_tableOn","doB_10_systeAlm", "doB_11", "doB_12", "doB_13", "doB_14", "doB_15" };


            public static string[] BDIOName = new string[] {  "diB_0_UPS", "diB_1_tableAlm", "diB_2_tableOn", "diB_3_toolAlm", "diB_4_tSpeedOk",
            "diB_5","diB_6","diB_7","diB_8","diB_9","diB_10","diB_11","diB_12","diB_13","diB_14","diB_15","doB_0_speed", "doB_1_speed", "doB_2_speed", "doB_3_speed", "doB_4_speed", "doB_5_speed", 
                "doB_6_toolPower","doB_7_toolOn","doB_8_toolOff","doB_9_tableOn","doB_10_systeAlm", "doB_11", "doB_12", "doB_13", "doB_14", "doB_15" };

            public static bool[] Values;


            public static bool OverTime;

            public static bool IsEditTool;

            public static int UploadType;

            public static int UploadIndex;


            public static string PartMatlabFile;
            public static string PartRecipeName;
            public static string PartRecipeRemark;


        }
    }
}
