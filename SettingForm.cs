using SimpleCrossHair.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCrossHair
{
    public partial class Setting : Form
    {
        private Screen TargetScreen { get; }

        public Setting()
        {
            InitializeComponent();

            TargetScreen = Screen.PrimaryScreen;

            PosXTrack.SetRange(0, TargetScreen.Bounds.Width);
            PosYTrack.SetRange(0, TargetScreen.Bounds.Height);

            Settings.Default.PosX = GetValueInRange(PosXTrack, Settings.Default.PosX);
            Settings.Default.PosY = GetValueInRange(PosYTrack, Settings.Default.PosY);

            BindTrackAndText(PosXTrack, PosXText, nameof(Settings.PosX));
            BindTrackAndText(PosYTrack, PosYText, nameof(Settings.PosY));

            CircleCheck.AddBinding("Checked", Settings.Default, nameof(Settings.CircleVisible));
            CirclePanel.AddBinding("Enabled", CircleCheck, "Checked");

            CrossCheck.AddBinding("Checked", Settings.Default, nameof(Settings.CrossVisible));
            CrossPanel.AddBinding("Enabled", CrossCheck, "Checked");

            BindTrackAndText(CrossOpacityTrack, CrossOpacityText, nameof(Settings.CrossOpacity));
            BindTrackAndText(CrossThicknessTrack, CrossThicknessText, nameof(Settings.CrossThickness));
            BindTrackAndText(CrossGapTrack, CrossGapText, nameof(Settings.CrossGap));
            BindTrackAndText(CrossLengthTrack, CrossLengthText, nameof(Settings.CrossLength));

            BindTrackAndText(CircleOpacityTrack, CircleOpacityText, nameof(Settings.CircleOpacity));
            BindTrackAndText(CircleDiameterTrack, CircleDiameterText, nameof(Settings.CircleDiameter));
            BindTrackAndText(CircleThicknessTrack, CircleThicknessText, nameof(Settings.CircleThickness));

            CrossColorBox.BackColor = Color.FromArgb(Settings.Default.CrossColor);
            CrossColorBox.Tag = nameof(Settings.CrossColor);

            CircleColorBox.BackColor = Color.FromArgb(Settings.Default.CircleColor);
            CircleColorBox.Tag = nameof(Settings.CircleColor);

            BindTrackAndText(GrooveCountTrack, GrooveCountText, nameof(Settings.CircleGrooveCount));
            BindTrackAndText(CircleGrooveAngleTrack, CircleGrooveAngleText,
                nameof(Settings.CircleGrooveAngle));

            CircleGrooveAngleText.AddBinding("Enabled", CircleGrooveAngleTrack, "Enabled");
            UpdateCircleGrooveAngleControls();

            BindTrackAndText(CircleRotateTrack, CircleRotateText, nameof(Settings.CircleRotation));

            Settings.Default.PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Settings.CircleGrooveCount):
                    UpdateCircleGrooveAngleControls();
                    break;
            }
        }

        private void UpdateCircleGrooveAngleControls()
        {
            CircleGrooveAngleTrack.Enabled = Settings.Default.CircleGrooveCount != 0;

            if (Settings.Default.CircleGrooveCount == 0) return;

            var maxAngle = (360 - Settings.Default.CircleGrooveCount) / Settings.Default.CircleGrooveCount;

            CircleGrooveAngleTrack.SetRange(1, maxAngle);

            Settings.Default.CircleGrooveAngle = Math.Min(Settings.Default.CircleGrooveAngle, maxAngle);
        }

        private void BindTrackAndText(TrackBar trackBar, TextBox textBox, string settingName)
        {
            trackBar.AddBinding("Value", Settings.Default, settingName);
            textBox.AddBinding("Text", Settings.Default, settingName);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Settings.Default.PropertyChanged -= OnPropertyChanged;
            Settings.Default.Save();
        }

        private void OnNumberTextKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private int GetValueInRange(TrackBar trackBar, int value)
            => Math.Min(Math.Max(value, trackBar.Minimum), trackBar.Maximum);

        private void OnColorBoxClick(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                dialog.ShowDialog();

                var colorBox = sender as PictureBox;

                SettingsUtil.SetValue(colorBox.Tag.ToString(), dialog.Color.ToArgb());

                colorBox.BackColor = dialog.Color;
            }
        }

        private void OnNumberTextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length == 0) return;

            var trackBar = textBox.Tag as TrackBar;

            var value = Int32.Parse(textBox.Text);

            if (value > trackBar.Maximum) textBox.Text = trackBar.Maximum.ToString();
            else if (value < trackBar.Minimum) textBox.Text = trackBar.Minimum.ToString();
        }
    }
}
