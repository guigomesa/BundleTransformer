﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BundleTransformer.Closure.Resources {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BundleTransformer.Closure.Resources.Strings", typeof(Strings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The JAR-file of Google Closure Compiler Application not found at the specified path - {0}!.
        /// </summary>
        public static string Minifiers_ClosureCompilerApplicationNotFound {
            get {
                return ResourceManager.GetString("Minifiers_ClosureCompilerApplicationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not specified path to the JAR-file of Google Closure Compiler Application (compiler.jar)..
        /// </summary>
        public static string Minifiers_ClosureCompilerApplicationPathNotSpecified {
            get {
                return ResourceManager.GetString("Minifiers_ClosureCompilerApplicationPathNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not specified URL of the Google Closure Compiler Service API..
        /// </summary>
        public static string Minifiers_ClosureCompilerServiceApiUrlNotSpecified {
            get {
                return ResourceManager.GetString("Minifiers_ClosureCompilerServiceApiUrlNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of JS-code, readed from the file {0}, by Closure Local Minifier error has occurred..
        /// </summary>
        public static string Minifiers_ClosureLocalMinificationFailed {
            get {
                return ResourceManager.GetString("Minifiers_ClosureLocalMinificationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of JS-code, readed from the file {0}, by Closure Local Minifier syntax error has occurred. 
        ///See more details:
        ///
        ///{1}.
        /// </summary>
        public static string Minifiers_ClosureLocalMinificationSyntaxError {
            get {
                return ResourceManager.GetString("Minifiers_ClosureLocalMinificationSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of JS-code by Closure Remote Minifier error has occurred.
        ///See more details:
        ///
        ///{0}.
        /// </summary>
        public static string Minifiers_ClosureRemoteMinificationFailed {
            get {
                return ResourceManager.GetString("Minifiers_ClosureRemoteMinificationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot connect to {0}! Check the specified URL and Internet connectivity..
        /// </summary>
        public static string Minifiers_ClosureRemoteMinificationHttpRequestError {
            get {
                return ResourceManager.GetString("Minifiers_ClosureRemoteMinificationHttpRequestError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When accessing to the Google Closure Compiler Service API occurred error with HTTP-status code &apos;{0}&apos;..
        /// </summary>
        public static string Minifiers_ClosureRemoteMinificationInvalidHttpStatus {
            get {
                return ResourceManager.GetString("Minifiers_ClosureRemoteMinificationInvalidHttpStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of JS-code by Closure Remote Minifier syntax error has occurred. 
        ///See more details:
        ///
        ///{0}.
        /// </summary>
        public static string Minifiers_ClosureRemoteMinificationSyntaxError {
            get {
                return ResourceManager.GetString("Minifiers_ClosureRemoteMinificationSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The executable file of Java Virtual Machine not found at the specified path - {0}!.
        /// </summary>
        public static string Minifiers_JavaVirtualMachineNotFound {
            get {
                return ResourceManager.GetString("Minifiers_JavaVirtualMachineNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not specified path to the executable file of Java Virtual Machine (java.exe)..
        /// </summary>
        public static string Minifiers_JavaVirtualMachinePathNotSpecified {
            get {
                return ResourceManager.GetString("Minifiers_JavaVirtualMachinePathNotSpecified", resourceCulture);
            }
        }
    }
}
