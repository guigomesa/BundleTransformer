﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BundleTransformer.UglifyJs.Resources {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BundleTransformer.UglifyJs.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Cannot convert the value &apos;{0}&apos; of symbol &apos;{1}&apos; to type {2}..
        /// </summary>
        public static string DefinesParsing_CannotConvertValue {
            get {
                return ResourceManager.GetString("DefinesParsing_CannotConvertValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse the value &apos;{0}&apos; of symbol &apos;{1}&apos;..
        /// </summary>
        public static string DefinesParsing_CannotParseValue {
            get {
                return ResourceManager.GetString("DefinesParsing_CannotParseValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; does not correspond to the format of SYMBOL[=value]..
        /// </summary>
        public static string DefinesParsing_InvalidSymbolValueFormat {
            get {
                return ResourceManager.GetString("DefinesParsing_InvalidSymbolValueFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forbidden to specify the name of symbol, which coincides with the name of built-in constant of JavaScript language: &apos;{0}&apos;..
        /// </summary>
        public static string DefinesParsing_SymbolNameIsForbidden {
            get {
                return ResourceManager.GetString("DefinesParsing_SymbolNameIsForbidden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of JS-code, readed from the file {0}, by Uglify JS-minifier error has occurred.	
        ///See more details:
        ///
        ///{1}.
        /// </summary>
        public static string Minifiers_UglifyJsMinificationFailed {
            get {
                return ResourceManager.GetString("Minifiers_UglifyJsMinificationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During minification of JS-code, readed from the file {0}, by Uglify JS-minifier syntax error has occurred. 
        ///See more details:
        ///
        ///{1}.
        /// </summary>
        public static string Minifiers_UglifyJsMinificationSyntaxError {
            get {
                return ResourceManager.GetString("Minifiers_UglifyJsMinificationSyntaxError", resourceCulture);
            }
        }
    }
}
