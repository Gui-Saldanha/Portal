namespace Configuration
{
    public class URL
    {
        public static string GSSCoreUrl
        {
            get
            {
                return Configuration.ReadConfigurationAppConfig()["GSSCoreUrl"];
            }
        }

        public static string PageLoggedOut
        {
            get { return GSSCoreUrl + "User/LoggedOut"; }
        }

        public static string PageLogin
        {
            get { return GSSCoreUrl + "/User/Login"; }
        }

        public static string PagePortfolio
        {
            get { return GSSCoreUrl + "Home/Index"; }
        }

        public static string APIUrl
        {
            get
            {
                return Configuration.ReadConfigurationAppConfig()["APIUrl"];
            }
        }
    }
}
