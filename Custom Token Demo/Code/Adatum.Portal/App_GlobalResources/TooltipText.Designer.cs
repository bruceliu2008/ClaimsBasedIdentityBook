﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adatum.Portal {
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
    internal class TooltipText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TooltipText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Adatum.Portal.App_GlobalResources.TooltipText", typeof(TooltipText).Assembly);
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
        ///   Looks up a localized string similar to Hint: Authentication for the site is delegated to Adatum.SimulatedIssuer.Custom..
        /// </summary>
        internal static string aExpenseClaimsAwareDescription {
            get {
                return ResourceManager.GetString("aExpenseClaimsAwareDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hint: Authentication is done using Forms Authentication. The credentials are verified against an account repository..
        /// </summary>
        internal static string aExpenseNoClaimsDescription {
            get {
                return ResourceManager.GetString("aExpenseNoClaimsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hint: Authentication for the site is delegated to Adatum.SimulatedIssuer.Custom..
        /// </summary>
        internal static string aOrderClaimsAwareDescription {
            get {
                return ResourceManager.GetString("aOrderClaimsAwareDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hint: Authentication is done using Windows Authentication. The user is authenticated against the Active Directory or local machine user store..
        /// </summary>
        internal static string aOrderNoClaimsDescription {
            get {
                return ResourceManager.GetString("aOrderNoClaimsDescription", resourceCulture);
            }
        }
    }
}
