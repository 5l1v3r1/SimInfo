﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindAuth {
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
    internal class PushTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PushTemplates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WindAuth.PushTemplates", typeof(PushTemplates).Assembly);
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
        ///   Looks up a localized string similar to &lt;wp:Notification xmlns:wp=&quot;WPNotification&quot; Version=&quot;2.0&quot;&gt;
        ///  &lt;wp:Tile Id=&quot;{0}&quot; Template=&quot;FlipTile&quot;&gt;
        ///    &lt;wp:SmallBackgroundImage&gt;{1}&lt;/wp:SmallBackgroundImage&gt;
        ///    &lt;wp:WideBackgroundImage&gt;{3}&lt;/wp:WideBackgroundImage&gt;
        ///    &lt;wp:WideBackBackgroundImage&gt;{3}&lt;/wp:WideBackBackgroundImage&gt;
        ///    &lt;wp:WideBackContent Action=&quot;Clear&quot;&gt;&lt;/wp:WideBackContent&gt;
        ///    &lt;wp:BackgroundImage&gt;{2}&lt;/wp:BackgroundImage&gt;
        ///    &lt;wp:Count Action=&quot;Clear&quot;&gt;&lt;/wp:Count&gt;
        ///    &lt;wp:Title Action=&quot;Clear&quot;&gt;&lt;/wp:Title&gt;
        ///    &lt;wp:BackBackgroundImage&gt;{2} [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NotificationTemplate {
            get {
                return ResourceManager.GetString("NotificationTemplate", resourceCulture);
            }
        }
    }
}