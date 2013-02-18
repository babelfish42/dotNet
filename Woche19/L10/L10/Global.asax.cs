using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace L10
{
  public class Global : System.Web.HttpApplication
  {

    void Application_Start(object sender, EventArgs e)
    {
      // Code that runs on application startup

    }

    void Application_End(object sender, EventArgs e)
    {
      //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
      // if an exception is thrown, log it.

      StreamWriter log;
      string logfilename = "c:\\temp\\logfile.txt";

      if (!File.Exists(logfilename))
      {
        log = new StreamWriter(logfilename);
      }
      else
      {
        log = File.AppendText(logfilename);
      }

      // Write to the file:
      log.WriteLine(DateTime.Now);
      log.WriteLine(Server.GetLastError().Message);
      log.WriteLine(Server.GetLastError().StackTrace);

      // Close the stream:
      log.Close();

    }

    void Session_Start(object sender, EventArgs e)
    {
      // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
      // Code that runs when a session ends. 
      // Note: The Session_End event is raised only when the sessionstate mode
      // is set to InProc in the Web.config file. If session mode is set to StateServer 
      // or SQLServer, the event is not raised.

    }

  }
}
