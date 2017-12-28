using SimpleCrossHair.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleCrossHair
{
    class Manager
    {
        private readonly Dictionary<string, Func<ICrossHairDrawer>> _drawerFactory = new Dictionary<string, Func<ICrossHairDrawer>>()
        {
            { nameof(Settings.CircleVisible), () => new CircleDrawer() },
            { nameof(Settings.CrossVisible), () => new CrossDrawer() },
        };

        private readonly Dictionary<string, ICrossHairDrawer> _drawers = new Dictionary<string, ICrossHairDrawer>();

        public Manager()
        {
            if (Settings.Default.FirstRun)
            {
                Settings.Default.FirstRun = false;

                Settings.Default.PosX = Screen.PrimaryScreen.Bounds.X + Screen.PrimaryScreen.Bounds.Width / 2;
                Settings.Default.PosY = Screen.PrimaryScreen.Bounds.Y + Screen.PrimaryScreen.Bounds.Height / 2;

                Settings.Default.Save();
            }

            foreach (var item in _drawerFactory)
            {
                if (SettingsUtil.GetValue<bool>(item.Key))
                {
                    EnableDrawer(item.Key, item.Value);
                }
            }

            Settings.Default.PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_drawerFactory.TryGetValue(e.PropertyName, out var factory))
            {
                var newVisible = SettingsUtil.GetValue<bool>(e.PropertyName);

                if (newVisible)
                {
                    if (_drawers.ContainsKey(e.PropertyName) == false)
                    {
                        EnableDrawer(e.PropertyName, factory);
                    }
                }
                else if (_drawers.TryGetValue(e.PropertyName, out var drawer))
                {
                    drawer.Close();
                    _drawers.Remove(e.PropertyName);
                }
            }
        }

        private void EnableDrawer(string visiblePropertyName, Func<ICrossHairDrawer> factory)
        {
            var newDrawer = factory();
            newDrawer.Initialize();
            newDrawer.Show();

            _drawers.Add(visiblePropertyName, newDrawer);
        }

        public void Show()
        {
            foreach (var drawer in _drawers.Values)
            {
                drawer.Show();
            }
        }
    }
}
