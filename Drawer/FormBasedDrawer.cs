using SimpleCrossHair.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCrossHair
{
    abstract class FormBasedDrawer : ICrossHairDrawer
    {
        private readonly Dictionary<string, Action> _propertyHandlers =
            new Dictionary<string, Action>();

        protected Form Form { get; } = new CrossHairForm();

        public void Initialize()
        {
            Settings.Default.PropertyChanged += OnPropertyChanged;

            AddPropertyHandler(OpacityPropertyName, RefreshOpacity);
            AddPropertyHandler(ColorPropertyName, RefreshColor);

            RefreshRegion();
            RefreshColor();
            RefreshOpacity();

            OnInitialized();
        }

        private void RefreshColor()
        {
            Form.BackColor = Color.FromArgb(SettingsUtil.GetValue<int>(ColorPropertyName));
        }

        private void RefreshOpacity()
        {
            Form.Opacity = SettingsUtil.GetValue<int>(OpacityPropertyName) / 100.0;
        }

        protected virtual void OnInitialized()
        {
        }

        public void Show()
        {
            Form.Show();
        }

        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_propertyHandlers.TryGetValue(e.PropertyName, out var action))
            {
                action();
            }
        }

        public void AddPropertyHandler(string propertyName, Action action)
        {
            _propertyHandlers.Add(propertyName, action);
        }

        protected void RefreshRegion()
        {
            var rgn = new Region(Rectangle.Empty);

            BuildRegion(rgn);

            rgn.Translate(Form.Width / 2.0F, Form.Height / 2.0F);

            Form.Region = rgn;
        }

        protected abstract void BuildRegion(Region region);

        public void Close()
        {
            Settings.Default.PropertyChanged -= OnPropertyChanged;

            Form.Close();
        }

        protected abstract string OpacityPropertyName { get; }

        protected abstract string ColorPropertyName { get; }
    }
}
