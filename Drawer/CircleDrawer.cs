using SimpleCrossHair.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimpleCrossHair
{
    class CircleDrawer : FormBasedDrawer
    {
        public CircleDrawer()
        {
            Settings.Default.PropertyChanged += OnPropertyChanged;
        }

        protected override void OnInitialized()
        {
            AddPropertyHandler(nameof(Settings.CircleDiameter), RefreshRegion);
            AddPropertyHandler(nameof(Settings.CircleThickness), RefreshRegion);
            AddPropertyHandler(nameof(Settings.CircleGrooveCount), RefreshRegion);
            AddPropertyHandler(nameof(Settings.CircleGrooveAngle), RefreshRegion);
            AddPropertyHandler(nameof(Settings.CircleRotation), RefreshRegion);
        }

        protected override string OpacityPropertyName => nameof(Settings.CircleOpacity);

        protected override string ColorPropertyName => nameof(Settings.CircleColor);

        protected override void BuildRegion(Region region)
        {
            var radius = Settings.Default.CircleDiameter / 2F;

            using (var path = new GraphicsPath())
            {
                if (Settings.Default.CircleGrooveCount == 0 || Settings.Default.CircleGrooveAngle == 0)
                {
                    path.AddEllipse(new RectangleF(-radius, -radius,
                    Settings.Default.CircleDiameter, Settings.Default.CircleDiameter));
                }
                else
                {
                    var angle = Settings.Default.CircleGrooveAngle;
                    var count = Settings.Default.CircleGrooveCount;
                    var length = (360F - angle * count) / count;
                    var cur = angle / 2F - 90 + Settings.Default.CircleRotation;

                    for (int i = 0; i < count; ++i)
                    {
                        path.AddPie(-radius, -radius, Settings.Default.CircleDiameter, Settings.Default.CircleDiameter,
                            cur, length);
                        cur += length + angle;
                    }
                }
                region.Union(path);
            }

            if (radius > Settings.Default.CircleThickness)
            {
                var hollowRadius = radius - Settings.Default.CircleThickness;

                using (var path = new GraphicsPath())
                {
                    path.AddEllipse(new RectangleF(-hollowRadius, -hollowRadius,
                        hollowRadius * 2, hollowRadius * 2));

                    region.Exclude(path);
                }
            }


        }
    }
}
