using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaizenAlgoritmos.Class.Office
{
    class claseOutlook
    {
        public claseOutlook() { }

        public void generarMsg() {
            Microsoft.Office.Interop.Outlook.Application objOutlook = new Microsoft.Office.Interop.Outlook.Application();

            // Creating a new Outlook message from the Outlook Application instance
            Microsoft.Office.Interop.Outlook.MailItem msgInterop = (Microsoft.Office.Interop.Outlook.MailItem)(objOutlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));

            // Set recipient information
            msgInterop.To = "neha1@gmail.com";
            msgInterop.CC = "neha@gmail.com";

            // Set the message subject
            msgInterop.Subject = "Subject";

            // Set some HTML text in the HTML body
            // msgInterop.HTMLBody = "<h3>HTML Heading 3</h3> <u>This is underlined text</u>";

            // Save the MSG file in local disk
            string strMsg = @"D:\\ejempl.msg";
            try
            {
                msgInterop.SaveAs(strMsg, Microsoft.Office.Interop.Outlook.OlSaveAsType.olMSG);

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"The file was not found: '{ex}'");

            }
        }
    }
}
