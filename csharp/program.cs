using System;
using System.Configuration;
using Console;

public class program
{
    static void Main(string[] args)
    {
        #if DEBUG 
        {
            // do something in dev
            var devUser = "devuser1";
            var devPassword = "devPassword123.";
        }
        else 
        {
            // do something in prod
            var releaseSettings = ConfigurationManager.GetSection("configuration/appsetting") as NameValueCollection;
            var username = releaseSettings[0];
            var password = releaseSettings[1];
            var connString = releaseSettings[2];
            var secret = releaseSettings[3];
        }
        #endif
    }
}