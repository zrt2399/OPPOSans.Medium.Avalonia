using System;
using Avalonia;
using Avalonia.Media;
using Avalonia.Media.Fonts;

namespace OPPOSans.Medium.Avalonia
{
    public static class AppBuilderExtension
    {
        /// <summary>
        /// Configures Avalonia to use the embedded OPPOSans Medium font as the default font family.
        /// </summary>
        public static AppBuilder WithOPPOSansMediumFont(this AppBuilder appBuilder)
        {
            return appBuilder.With(new FontManagerOptions()
            {
                DefaultFamilyName = "avares://OPPOSans.Medium.Avalonia/Assets/Fonts/OPPOSans-M.ttf#OPPOSans M"
            });

            //return appBuilder.With(new FontManagerOptions
            //{
            //    // 4. 将默认字体指向你刚刚注册的虚拟 URI
            //    // 格式： 虚拟前缀#字体族名称 (F12里的Family Name)
            //    DefaultFamilyName = "fonts:oppo#OPPOSans Medium"
            //}).ConfigureFonts(fontManager =>
            //  {
            //      // 1. 定义一个“虚拟”的自定义 URI，这是你在代码/XAML中引用它的别名
            //      var customFontKey = new Uri("fonts:oppo", UriKind.Absolute);

            //      // 2. 定义真实资源的来源 (非常关键！)
            //      // 格式：resm:程序集的默认命名空间.文件夹路径?assembly=程序集名称
            //      // 注意：不要写具体的文件名(ttf)，写到文件夹层级即可，它会自动扫描。
            //      var realResourceSource = new Uri("resm:OPPOSans.Medium.Assets.Fonts?assembly=OPPOSans.Medium", UriKind.Absolute);

            //      // 3. 实例化 Avalonia 提供的嵌入字体集合对象
            //      var embeddedCollection = new EmbeddedFontCollection(customFontKey, realResourceSource);

            //      // 👉 这里就是你问的那个方法！将集合注册到系统中
            //      fontManager.AddFontCollection(embeddedCollection);
            //  });
        }
    }
}