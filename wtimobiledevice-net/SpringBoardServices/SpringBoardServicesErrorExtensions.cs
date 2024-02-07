﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="SpringBoardServicesErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.SpringBoardServices
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class SpringBoardServicesErrorExtensions
    {
        
        public static void ThrowOnError(this SpringBoardServicesError value)
        {
            if ((value != SpringBoardServicesError.Success))
            {
                throw new SpringBoardServicesException(value);
            }
        }
        
        public static void ThrowOnError(this SpringBoardServicesError value, string message)
        {
            if ((value != SpringBoardServicesError.Success))
            {
                throw new SpringBoardServicesException(value, message);
            }
        }
        
        public static bool IsError(this SpringBoardServicesError value)
        {
            return (value != SpringBoardServicesError.Success);
        }
    }
}
