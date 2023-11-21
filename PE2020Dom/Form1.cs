using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE2020Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // if you want to use example.html from a local folder (saved in c:\temp for example):
            this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;
            

          

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElementCollection[0].InnerText = "My UFO Page";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElementCollection[0].InnerText = "My UFO Info";

            htmlElement = htmlElementCollection[1];
            htmlElementCollection[1].InnerText = "My UFO Pictures";

            htmlElement = htmlElementCollection[2];
            htmlElementCollection[2].InnerText = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style = "font-family: sans serif; color: #ad2f1c";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "Report your UFO findings: <a href=\"http://www.nuforc.org\">www.nuforc.org</a>";

          
            htmlElement.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";

            htmlElement = htmlElementCollection[1];
            htmlElement.InnerHtml = "";

            htmlElement = webBrowser.Document.GetElementById("lastParagraph");

            HtmlElement htmlElement1 = webBrowser.Document.CreateElement("img");
            htmlElement1.SetAttribute("src", "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2018_01/2280531/180103-ufo-illustration-mn-1015.jpg");
            htmlElement1.SetAttribute("alt", "UFO Image");

           

            // possible options are:
            //  	BeforeBegin: insert new element before this element
            //	AfterBegin: insert new element within and at the start of this element
            //	BeforeEnd: insert new element within and at the end of this element
            //	AfterEnd: insert new element after this element
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, htmlElement1);

            htmlElement1 = webBrowser.Document.CreateElement("footer");

            htmlElement1.InnerHtml = "&copy;2023 Nana Sarpong</a>";

            webBrowser.Document.Body.AppendChild(htmlElement1);





        }

    }
}
