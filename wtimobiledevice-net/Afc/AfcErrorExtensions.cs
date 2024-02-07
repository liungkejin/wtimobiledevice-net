﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="AfcErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Afc
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class AfcErrorExtensions
    {
        
        public static void ThrowOnError(this AfcError value)
        {
            if ((value != AfcError.Success))
            {
                throw new AfcException(value);
            }
        }
        
        public static void ThrowOnError(this AfcError value, string message)
        {
            if ((value != AfcError.Success))
            {
                throw new AfcException(value, message);
            }
        }
        
        public static bool IsError(this AfcError value)
        {
            return (value != AfcError.Success);
        }
    }
}
