using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.MediaCenter.Hosting;
using Microsoft.MediaCenter;

namespace PipTube
{
    public class MyAddIn : IAddInModule, IAddInEntryPoint
    {
        private static HistoryOrientedPageSession s_session;

        public void Initialize(Dictionary<string, object> appInfo, Dictionary<string, object> entryPointInfo)
        {
        }

        public void Uninitialize()
        {
        }

        public void Launch(AddInHost host)
        {
            if (host != null && host.ApplicationContext != null)
            {
                host.ApplicationContext.SingleInstance = true;
            }
            s_session = new HistoryOrientedPageSession();
            Application app = new Application(s_session, host);

            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string[] fileList = Directory.GetFiles(appdata + @"\Microsoft\Windows\Temporary Internet Files", "watch_as3*.swf", SearchOption.AllDirectories);

            foreach (string f in fileList)
            {
                File.Delete(f);
            }
            //app.GoToMenu();
            host.MediaCenterEnvironment.NavigateToPage(PageId.ExtensibilityUrl, "http://www.youtube.com/leanback");
            host.MediaCenterEnvironment.MediaExperience.Transport.PlayRate = 0;


        }
    }
}