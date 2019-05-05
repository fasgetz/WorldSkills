using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WorldSkills_Client.View.Common;

namespace WorldSkills_Client.ProgramLogic
{
    public static class locator
    {
        public static AuthorizationPage AuthPage;
        public static MainPage MainPages;
        public static SponsoredPage SponsoredPages;

        public static MainPage GetMain()
        {
            if (MainPages == null)
                MainPages = new MainPage();

            //SponsoredPages = null;
            return MainPages;
        }

        public static SponsoredPage GetSponsoredPages()
        {
            if (SponsoredPages == null)
            {
                SponsoredPages = new SponsoredPage();
            }

            

            return SponsoredPages;
        }
    }
}
