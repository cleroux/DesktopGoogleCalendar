﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopGoogleCalendar.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Right")]
        public string WindowPosition {
            get {
                return ((string)(this["WindowPosition"]));
            }
            set {
                this["WindowPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RunAtStartup {
            get {
                return ((bool)(this["RunAtStartup"]));
            }
            set {
                this["RunAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ApiClientSecretsFile {
            get {
                return ((string)(this["ApiClientSecretsFile"]));
            }
            set {
                this["ApiClientSecretsFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tahoma, 26pt")]
        public global::System.Drawing.Font ClockFont {
            get {
                return ((global::System.Drawing.Font)(this["ClockFont"]));
            }
            set {
                this["ClockFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ClockFontColor {
            get {
                return ((global::System.Drawing.Color)(this["ClockFontColor"]));
            }
            set {
                this["ClockFontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tahoma, 11pt")]
        public global::System.Drawing.Font EventFont {
            get {
                return ((global::System.Drawing.Font)(this["EventFont"]));
            }
            set {
                this["EventFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tahoma, 12pt")]
        public global::System.Drawing.Font DateFont {
            get {
                return ((global::System.Drawing.Font)(this["DateFont"]));
            }
            set {
                this["DateFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tahoma, 16pt")]
        public global::System.Drawing.Font TodayFont {
            get {
                return ((global::System.Drawing.Font)(this["TodayFont"]));
            }
            set {
                this["TodayFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color TodayFontColor {
            get {
                return ((global::System.Drawing.Color)(this["TodayFontColor"]));
            }
            set {
                this["TodayFontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color DateFontColor {
            get {
                return ((global::System.Drawing.Color)(this["DateFontColor"]));
            }
            set {
                this["DateFontColor"] = value;
            }
        }
    }
}
