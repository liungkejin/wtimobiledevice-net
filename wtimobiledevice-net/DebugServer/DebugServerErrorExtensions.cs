﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="DebugServerErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.DebugServer
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class DebugServerErrorExtensions
    {
        
        public static void ThrowOnError(this DebugServerError value)
        {
            if ((value != DebugServerError.Success))
            {
                throw new DebugServerException(value);
            }
        }
        
        public static void ThrowOnError(this DebugServerError value, string message)
        {
            if ((value != DebugServerError.Success))
            {
                throw new DebugServerException(value, message);
            }
        }
        
        public static bool IsError(this DebugServerError value)
        {
            return (value != DebugServerError.Success);
        }
    }
}
