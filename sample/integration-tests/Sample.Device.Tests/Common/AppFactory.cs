using System;
using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace Sample.Device.Tests.Common
{
    public static class AppFactory
    {
        public static IApp Start(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    return StartAndroid();
                case Platform.iOS:
                    return StartIOS();
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }

        private static iOSApp StartIOS()
        {
            return ConfigureApp
                .iOS
                // Replace sample.app with the correct name for your application
                .AppBundle ("../../../../ios/build/Build/Products/Release (Calabash)-iphonesimulator/sample.app")
                .StartApp();
        }

        private static IApp StartAndroid()
        {
            return ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                //.ApkFile ("../../../Droid/bin/Debug/xamarinforms.apk")
                .StartApp();
        }
    }
}