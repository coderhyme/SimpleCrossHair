using SimpleCrossHair.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCrossHair
{
    class CrossHairForm : Form
    {
        public CrossHairForm()
        {
            Load += new System.EventHandler(OnLoad);
            FormClosing += OnFormClosing;

            SuspendLayout();

            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;

            TransparencyKey = Color.Black;

            ResumeLayout();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.PropertyChanged -= OnPropertyChanged;
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            Settings.Default.PropertyChanged += OnPropertyChanged;

            InteropUtil.MakeFormTopMost(this);

            RefreshLocation();
        }

        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Settings.PosX):
                case nameof(Settings.PosY):
                    RefreshLocation();
                    break;
            }
        }

        private void RefreshLocation()
        {
            Left = Screen.PrimaryScreen.Bounds.Left + Settings.Default.PosX - Bounds.Width / 2;
            Top = Screen.PrimaryScreen.Bounds.Top + Settings.Default.PosY - Bounds.Height / 2;
        }
    }
}
