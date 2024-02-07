﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="FileRelayErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.FileRelay
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class FileRelayErrorExtensions
    {
        
        public static void ThrowOnError(this FileRelayError value)
        {
            if ((value != FileRelayError.Success))
            {
                throw new FileRelayException(value);
            }
        }
        
        public static void ThrowOnError(this FileRelayError value, string message)
        {
            if ((value != FileRelayError.Success))
            {
                throw new FileRelayException(value, message);
            }
        }
        
        public static bool IsError(this FileRelayError value)
        {
            return (value != FileRelayError.Success);
        }
    }
}