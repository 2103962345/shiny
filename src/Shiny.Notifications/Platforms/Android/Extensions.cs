﻿using System;
using Android.App;
using Android.Content;


namespace Shiny.Notifications
{
    static class AndroidExtensions
    {
        public static ActivityFlags ToNative(this AndroidActivityFlags flags)
        {
            var intValue = (int) flags;
            var native = (ActivityFlags) intValue;
            return native;
        }


        public static NotificationImportance ToNative(this AndroidNotificationImportance import)
        {
            var intValue = (int) import;
            var native = (NotificationImportance) intValue;
            return native;
        }


        public static int GetResourceIdByName(this AndroidContext context, string iconName) => context
            .AppContext
            .Resources
            .GetIdentifier(
                iconName,
                "drawable",
                Application.Context.PackageName
            );
    }
}