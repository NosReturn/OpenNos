﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.Login.Resource {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenNos.Login.Resource.LocalizedResources", typeof(LocalizedResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account is already connected..
        /// </summary>
        internal static string ALREADY_CONNECTED {
            get {
                return ResourceManager.GetString("ALREADY_CONNECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection closed by Client..
        /// </summary>
        internal static string CLIENT_CLOSE {
            get {
                return ResourceManager.GetString("CLIENT_CLOSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection closed..
        /// </summary>
        internal static string CLIENT_CLOSED {
            get {
                return ResourceManager.GetString("CLIENT_CLOSED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Config loaded !.
        /// </summary>
        internal static string CONFIG_LOADED {
            get {
                return ResourceManager.GetString("CONFIG_LOADED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONNECT {0} Connected -- session:{1}.
        /// </summary>
        internal static string CONNECTION {
            get {
                return ResourceManager.GetString("CONNECTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database has been initialized!.
        /// </summary>
        internal static string DATABASE_HAS_BEEN_INITIALISE {
            get {
                return ResourceManager.GetString("DATABASE_HAS_BEEN_INITIALISE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A client is has been disconnected! ClientId =.
        /// </summary>
        internal static string DISCONNECT {
            get {
                return ResourceManager.GetString("DISCONNECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forced Disconnecting of client {0}, too much connections..
        /// </summary>
        internal static string FORCED_DISCONNECT {
            get {
                return ResourceManager.GetString("FORCED_DISCONNECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong Id or Password!.
        /// </summary>
        internal static string IDERROR {
            get {
                return ResourceManager.GetString("IDERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message received {0} on client {1}.
        /// </summary>
        internal static string MESSAGE_RECEIVED {
            get {
                return ResourceManager.GetString("MESSAGE_RECEIVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message sent to client .
        /// </summary>
        internal static string MSG_SENT {
            get {
                return ResourceManager.GetString("MSG_SENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new client is connected. ClientId =.
        /// </summary>
        internal static string NEW_CONNECT {
            get {
                return ResourceManager.GetString("NEW_CONNECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server is started successfully..
        /// </summary>
        internal static string STARTED {
            get {
                return ResourceManager.GetString("STARTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message is too big ({0} bytes). Max allowed length is {1} bytes..
        /// </summary>
        internal static string TOO_BIG {
            get {
                return ResourceManager.GetString("TOO_BIG", resourceCulture);
            }
        }
    }
}
