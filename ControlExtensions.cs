using System.Windows.Forms;

namespace SimpleCrossHair
{
    static class ControlExtensions
    {
        internal static Binding AddBinding(this Control control, string propertyName,
            object dataSource, string dataMember)
        {
            var binding = new Binding(propertyName, dataSource, dataMember,
                true, DataSourceUpdateMode.OnPropertyChanged);

            control.DataBindings.Add(binding);

            return binding;
        }
    }
}
