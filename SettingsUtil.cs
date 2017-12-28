using SimpleCrossHair.Properties;

namespace SimpleCrossHair
{
    static class SettingsUtil
    {
        public static TResult GetValue<TResult>(string propertyName)
        {
            return (TResult)typeof(Settings).GetProperty(propertyName).GetValue(Settings.Default);
        }

        public static void SetValue<TValue>(string propertyName, TValue value)
        {
            typeof(Settings).GetProperty(propertyName).SetValue(Settings.Default, value);
        }
    }
}
