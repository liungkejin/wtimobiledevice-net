//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="RecoveryError.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Recovery
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public enum RecoveryError : int
    {
        
        Success = 0,
        
        NoDevice = -1,
        
        OutOfMemory = -2,
        
        UnableToConnect = -3,
        
        InvalidInput = -4,
        
        FileNotFound = -5,
        
        UsbUpload = -6,
        
        UsbStatus = -7,
        
        UsbInterface = -8,
        
        UsbConfiguration = -9,
        
        Pipe = -10,
        
        Timeout = -11,
        
        Unsupported = -254,
        
        UnknownError = -255,
    }
}