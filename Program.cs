using System;
using System.Windows.Forms;

namespace SimpleCrossHair
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var manager = new Manager();

            NotifyIcon notifyIcon = new NotifyIcon();
            ContextMenu contextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Settings", OnSettingsClick),
                new MenuItem("Exit", OnExitClick),
            });

            notifyIcon.Icon = Properties.Resources.Icon;
            notifyIcon.Text = "SimpleCrosshair";
            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Visible = true;
            Application.Run();
            notifyIcon.Visible = false;
        }

        private static void OnExitClick(object Sender, EventArgs e)
        {
            Application.Exit();
        }

        private static Setting SettingForm { get; set; }

        private static void OnSettingsClick(object Sender, EventArgs e)
        {
            if (SettingForm == null)
            {
                SettingForm = new Setting();

                SettingForm.ShowDialog();
                SettingForm = null;
            }
            else
            {
                SettingForm.Activate();
            }

        }
    }
}
