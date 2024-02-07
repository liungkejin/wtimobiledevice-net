﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="PinvokeException.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Pinvoke
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    /// Represents an exception that occurred when interacting with the Pinvoke API.
#if !NETSTANDARD1_5
    [System.SerializableAttribute()]
#endif
    public class PinvokeException : System.Exception
    {
        
        /// <summary>
        /// Backing field for the <see cref="ErrorCode"/> property.
        /// </summary>
        private PinvokeError errorCode;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PinvokeException"/> class.
        /// </summary>
        public PinvokeException()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PinvokeException"/> class with a specified error code.
        /// </summary>
        /// <param name="error">
        /// The error code of the error that occurred.
        /// </param>
        public PinvokeException(PinvokeError error) : 
                base(string.Format("An Pinvoke error occurred. The error code was {0}", error))
        {
            this.errorCode = error;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PinvokeException"/> class with a specified error code and error message.
        /// </summary>
        /// <param name="error">
        /// The error code of the error that occurred.
        /// </param>
        /// <param name="message">
        /// A message which describes the error.
        /// </param>
        public PinvokeException(PinvokeError error, string message) : 
                base(string.Format("An Pinvoke error occurred. {1}. The error code was {0}", error, message))
        {
            this.errorCode = error;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PinvokeException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public PinvokeException(string message) : 
                base(message)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PinvokeException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="inner">
        /// The exception that is the cause of the current exception, or <see langword="null"/> if no inner exception is specified.
        /// </param>
        public PinvokeException(string message, System.Exception inner) : 
                base(message, inner)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PinvokeException"/> class with serialized data.
        /// </summary>
        /// <param name="info">
        /// The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.
        /// </param>
#if !NETSTANDARD1_5
        protected PinvokeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
#endif
        
        /// <summary>
        /// Gets the error code that represents the error.
        /// </summary>
        public virtual PinvokeError ErrorCode
        {
            get
            {
                return this.errorCode;
            }
        }
    }
}
