using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LinkedInUICloneXF
{
    class MainPageViewModel 
    {
        public Command SwipeBottomCommand { get; set; }
        public Command SwipeTopCommand { get; set; }
        public MainPageViewModel()
        {
            SwipeBottomCommand=new  Command(ShowOrHideBar);
            SwipeTopCommand = new  Command(ShowOrHideBar);
            
        }

        private void ShowOrHideBar()
        {
          Console.WriteLine("sqdqsd");
        }
    }
}
