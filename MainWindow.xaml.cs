using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Start_Scene;
using RankGame.Object;


namespace RankGame
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private Start_Scene.Start_Scene startScene = new Start_Scene.Start_Scene();
        private Start_Scene.Game_Play_Scene gameScene = new Start_Scene.Game_Play_Scene();

        public MainWindow()
        {
            InitializeComponent();

            write_msg_log("프로그램이 시작되었습니다.");


            AddDelegateEvent();

            ControlValueInit();

            AddCanvas();

            ButtonEvent();

        }

        public void AddDelegateEvent()
        {
            startScene.log_msg += new Start_Scene.Start_Scene.Log_Event(write_msg_log);
            startScene.sendUserName 
                += new Start_Scene.Start_Scene.SendUserName(AddObjectData);
            startScene.gameSceneShow += new Start_Scene.Start_Scene.GameSceneShow(gameScene.Show);
        }
        public void ControlValueInit()
        {
            TB_MessageBox.IsReadOnly = true;
        }
        public void AddCanvas()
        {
            CNV_MainCanvas.Children.Add(startScene);
            CNV_MainCanvas.Children.Add(gameScene);
            write_msg_log("Canvas Add Successed");
        }
        public void ButtonEvent()
        {
            Btn_Start.Click += (sender, e) => { StartEvent(); };
            Btn_Option.Click += (sender, e) => { OptionEvent(); };
            Btn_Exit.Click += (sender, e) => { ExitEvent(); };

            write_msg_log("Button Event Init Successed");

        }

        public void StartEvent()
        {
            write_msg_log("Start Click");
            startScene.Show();

        }

        public void OptionEvent()
        {
            write_msg_log("Option Click");

        }


        public void ExitEvent()
        {
            write_msg_log("Exit Click");
            Environment.Exit(0);
        }



        public void write_msg_log(String text)
        {
            DateTime cur_time;
            string cur_dt;
            string cur_tm;
            string cur_dtm;

            cur_time = DateTime.Now;
            cur_dt = cur_time.ToString("yyyy-") + cur_time.ToString("MM-") + cur_time.ToString("dd");
            cur_tm = cur_time.ToString("HH:mm:ss");
            cur_dtm = "[" + cur_dt + " " + cur_tm + "]";

            TB_MessageBox.AppendText(cur_dtm + " " + text + "\n");
        }

        public void AddObjectData( string name, bool endCheck = false )
        {
            ObjectMgr.GetInstance().Add(new Object.Object(name));
            write_msg_log( name + "이(가) 추가되었습니다." );

            if (true == endCheck)
            {
               gameScene.VisibleImageList( ObjectMgr.GetInstance().GetObjects().Count );

            }
        }























    }
}
