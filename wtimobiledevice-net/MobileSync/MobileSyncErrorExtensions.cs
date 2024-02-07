﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="MobileSyncErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.MobileSync
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class MobileSyncErrorExtensions
    {
        
        public static void ThrowOnError(this MobileSyncError value)
        {
            if ((value != MobileSyncError.Success))
            {
                throw new MobileSyncException(value);
            }
        }
        
        public static void ThrowOnError(this MobileSyncError value, string message)
        {
            if ((value != MobileSyncError.Success))
            {
                throw new MobileSyncException(value, message);
            }
        }
        
        public static bool IsError(this MobileSyncError value)
        {
            return (value != MobileSyncError.Success);
        }
    }
}