﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoMapper.XpressionMapper {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resource() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AutoMapper.XpressionMapper.Resource", typeof(Resource).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Cannot create a binary expression for the following pair.  Node: {0}, Type: {1} and Node: {2}, Type: {3}..
        /// </summary>
        public static string cannotCreateBinaryExpressionFormat {
            get {
                return ResourceManager.GetString("cannotCreateBinaryExpressionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Can&apos;t rempa expression.
        /// </summary>
        public static string cantRemapExpression {
            get {
                return ResourceManager.GetString("cantRemapExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Custom resolvers are not supported for expression mapping..
        /// </summary>
        public static string customResolversNotSupported {
            get {
                return ResourceManager.GetString("customResolversNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The source and destination types must be the same for expression mapping between value types. Source Type: {0}, Source Description: {1}, Destination Type: {2}, Destination Property: {3}..
        /// </summary>
        public static string expressionMapValueTypeMustMatchFormat {
            get {
                return ResourceManager.GetString("expressionMapValueTypeMustMatchFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The Include value-type expression uses multiple sibling navigation objects &quot;{0}&quot;, &quot;{1}&quot; and is too complex to translate..
        /// </summary>
        public static string includeExpressionTooComplex {
            get {
                return ResourceManager.GetString("includeExpressionTooComplex", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Source and destination must have the same number of arguments..
        /// </summary>
        public static string invalidArgumentCount {
            get {
                return ResourceManager.GetString("invalidArgumentCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid expression type for this operation..
        /// </summary>
        public static string invalidExpErr {
            get {
                return ResourceManager.GetString("invalidExpErr", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Mapper Info dictionary cannot be null..
        /// </summary>
        public static string mapperInfoDictionaryIsNull {
            get {
                return ResourceManager.GetString("mapperInfoDictionaryIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Arguments must be expressions..
        /// </summary>
        public static string mustBeExpressions {
            get {
                return ResourceManager.GetString("mustBeExpressions", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to SourceMember cannot be null. Source Type: {0}, Destination Type: {1}, Property: {2}..
        /// </summary>
        public static string srcMemberCannotBeNullFormat {
            get {
                return ResourceManager.GetString("srcMemberCannotBeNullFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Type Mappings dictionary cannot be null..
        /// </summary>
        public static string typeMappingsDictionaryIsNull {
            get {
                return ResourceManager.GetString("typeMappingsDictionaryIsNull", resourceCulture);
            }
        }
    }
}
