using SimpleCrossHair.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimpleCrossHair
{
    class CrossDrawer : FormBasedDrawer
    {
        private float BarThickness => Settings.Default.CrossThickness;
        private float BarLength => Settings.Default.CrossLength;
        private float BarGap => Settings.Default.CrossGap;

        public CrossDrawer()
        {
            Settings.Default.PropertyChanged += OnPropertyChanged;
        }

        protected override void OnInitialized()
        {
            AddPropertyHandler(nameof(Settings.CrossLength), RefreshRegion);
            AddPropertyHandler(nameof(Settings.CrossThickness), RefreshRegion);
            AddPropertyHandler(nameof(Settings.CrossGap), RefreshRegion);
        }

        protected override string OpacityPropertyName => nameof(Settings.CrossOpacity);

        protected override string ColorPropertyName => nameof(Settings.CrossColor);

        protected override void BuildRegion(Region region)
        {
            using (var path = new GraphicsPath())
            {
                path.FillMode = FillMode.Winding;

                path.AddRectangles(
                    new[] {
                        new RectangleF(new PointF(-BarLength - BarGap, -BarThickness / 2), new SizeF(BarLength, BarThickness)),
                        new RectangleF(new PointF(BarGap, -BarThickness / 2), new SizeF(BarLength, BarThickness)),
                        new RectangleF(new PointF(-BarThickness / 2, -BarLength - BarGap), new SizeF(BarThickness, BarLength)),
                        new RectangleF(new PointF(-BarThickness / 2, BarGap), new SizeF(BarThickness, BarLength))
                    });

                region.Union(path);
            }
        }
    }
}
