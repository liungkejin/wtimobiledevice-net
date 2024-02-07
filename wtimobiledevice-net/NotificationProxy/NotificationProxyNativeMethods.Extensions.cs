//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="NotificationProxyNativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.NotificationProxy
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class NotificationProxyNativeMethods
    {
        
        public static NotificationProxyError np_observe_notifications(NotificationProxyClientHandle client, out string notificationSpec)
        {
            System.Runtime.InteropServices.ICustomMarshaler notificationSpecMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr notificationSpecNative = System.IntPtr.Zero;
            NotificationProxyError returnValue = NotificationProxyNativeMethods.np_observe_notifications(client, out notificationSpecNative);
            notificationSpec = ((string)notificationSpecMarshaler.MarshalNativeToManaged(notificationSpecNative));
            notificationSpecMarshaler.CleanUpNativeData(notificationSpecNative);
            return returnValue;
        }
    }
}