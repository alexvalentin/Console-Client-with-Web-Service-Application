﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ConsoleClientForWSA.WebServici2 {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback aFromCelsiustoFahrenheitOperationCompleted;
        
        private System.Threading.SendOrPostCallback aFromFahrenheittoCelsiusOperationCompleted;
        
        private System.Threading.SendOrPostCallback bDateTimeDisplayOperationCompleted;
        
        private System.Threading.SendOrPostCallback dEuroToLeiOperationCompleted;
        
        private System.Threading.SendOrPostCallback dLeiToEuroOperationCompleted;
        
        private System.Threading.SendOrPostCallback cfiveElementsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::ConsoleClientForWSA.Properties.Settings.Default.MyFirstClient1_WebServici2_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event aFromCelsiustoFahrenheitCompletedEventHandler aFromCelsiustoFahrenheitCompleted;
        
        /// <remarks/>
        public event aFromFahrenheittoCelsiusCompletedEventHandler aFromFahrenheittoCelsiusCompleted;
        
        /// <remarks/>
        public event bDateTimeDisplayCompletedEventHandler bDateTimeDisplayCompleted;
        
        /// <remarks/>
        public event dEuroToLeiCompletedEventHandler dEuroToLeiCompleted;
        
        /// <remarks/>
        public event dLeiToEuroCompletedEventHandler dLeiToEuroCompleted;
        
        /// <remarks/>
        public event cfiveElementsCompletedEventHandler cfiveElementsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/aFromCelsiustoFahrenheit", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int aFromCelsiustoFahrenheit(int Celsius) {
            object[] results = this.Invoke("aFromCelsiustoFahrenheit", new object[] {
                        Celsius});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void aFromCelsiustoFahrenheitAsync(int Celsius) {
            this.aFromCelsiustoFahrenheitAsync(Celsius, null);
        }
        
        /// <remarks/>
        public void aFromCelsiustoFahrenheitAsync(int Celsius, object userState) {
            if ((this.aFromCelsiustoFahrenheitOperationCompleted == null)) {
                this.aFromCelsiustoFahrenheitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaFromCelsiustoFahrenheitOperationCompleted);
            }
            this.InvokeAsync("aFromCelsiustoFahrenheit", new object[] {
                        Celsius}, this.aFromCelsiustoFahrenheitOperationCompleted, userState);
        }
        
        private void OnaFromCelsiustoFahrenheitOperationCompleted(object arg) {
            if ((this.aFromCelsiustoFahrenheitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.aFromCelsiustoFahrenheitCompleted(this, new aFromCelsiustoFahrenheitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/aFromFahrenheittoCelsius", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int aFromFahrenheittoCelsius(int Fahrenheit) {
            object[] results = this.Invoke("aFromFahrenheittoCelsius", new object[] {
                        Fahrenheit});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void aFromFahrenheittoCelsiusAsync(int Fahrenheit) {
            this.aFromFahrenheittoCelsiusAsync(Fahrenheit, null);
        }
        
        /// <remarks/>
        public void aFromFahrenheittoCelsiusAsync(int Fahrenheit, object userState) {
            if ((this.aFromFahrenheittoCelsiusOperationCompleted == null)) {
                this.aFromFahrenheittoCelsiusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaFromFahrenheittoCelsiusOperationCompleted);
            }
            this.InvokeAsync("aFromFahrenheittoCelsius", new object[] {
                        Fahrenheit}, this.aFromFahrenheittoCelsiusOperationCompleted, userState);
        }
        
        private void OnaFromFahrenheittoCelsiusOperationCompleted(object arg) {
            if ((this.aFromFahrenheittoCelsiusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.aFromFahrenheittoCelsiusCompleted(this, new aFromFahrenheittoCelsiusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/bDateTimeDisplay", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string bDateTimeDisplay() {
            object[] results = this.Invoke("bDateTimeDisplay", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void bDateTimeDisplayAsync() {
            this.bDateTimeDisplayAsync(null);
        }
        
        /// <remarks/>
        public void bDateTimeDisplayAsync(object userState) {
            if ((this.bDateTimeDisplayOperationCompleted == null)) {
                this.bDateTimeDisplayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbDateTimeDisplayOperationCompleted);
            }
            this.InvokeAsync("bDateTimeDisplay", new object[0], this.bDateTimeDisplayOperationCompleted, userState);
        }
        
        private void OnbDateTimeDisplayOperationCompleted(object arg) {
            if ((this.bDateTimeDisplayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.bDateTimeDisplayCompleted(this, new bDateTimeDisplayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/dEuroToLei", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double dEuroToLei(double Lei) {
            object[] results = this.Invoke("dEuroToLei", new object[] {
                        Lei});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void dEuroToLeiAsync(double Lei) {
            this.dEuroToLeiAsync(Lei, null);
        }
        
        /// <remarks/>
        public void dEuroToLeiAsync(double Lei, object userState) {
            if ((this.dEuroToLeiOperationCompleted == null)) {
                this.dEuroToLeiOperationCompleted = new System.Threading.SendOrPostCallback(this.OndEuroToLeiOperationCompleted);
            }
            this.InvokeAsync("dEuroToLei", new object[] {
                        Lei}, this.dEuroToLeiOperationCompleted, userState);
        }
        
        private void OndEuroToLeiOperationCompleted(object arg) {
            if ((this.dEuroToLeiCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dEuroToLeiCompleted(this, new dEuroToLeiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/dLeiToEuro", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double dLeiToEuro(double Euro) {
            object[] results = this.Invoke("dLeiToEuro", new object[] {
                        Euro});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void dLeiToEuroAsync(double Euro) {
            this.dLeiToEuroAsync(Euro, null);
        }
        
        /// <remarks/>
        public void dLeiToEuroAsync(double Euro, object userState) {
            if ((this.dLeiToEuroOperationCompleted == null)) {
                this.dLeiToEuroOperationCompleted = new System.Threading.SendOrPostCallback(this.OndLeiToEuroOperationCompleted);
            }
            this.InvokeAsync("dLeiToEuro", new object[] {
                        Euro}, this.dLeiToEuroOperationCompleted, userState);
        }
        
        private void OndLeiToEuroOperationCompleted(object arg) {
            if ((this.dLeiToEuroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dLeiToEuroCompleted(this, new dLeiToEuroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/cfiveElements", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] cfiveElements() {
            object[] results = this.Invoke("cfiveElements", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void cfiveElementsAsync() {
            this.cfiveElementsAsync(null);
        }
        
        /// <remarks/>
        public void cfiveElementsAsync(object userState) {
            if ((this.cfiveElementsOperationCompleted == null)) {
                this.cfiveElementsOperationCompleted = new System.Threading.SendOrPostCallback(this.OncfiveElementsOperationCompleted);
            }
            this.InvokeAsync("cfiveElements", new object[0], this.cfiveElementsOperationCompleted, userState);
        }
        
        private void OncfiveElementsOperationCompleted(object arg) {
            if ((this.cfiveElementsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cfiveElementsCompleted(this, new cfiveElementsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void aFromCelsiustoFahrenheitCompletedEventHandler(object sender, aFromCelsiustoFahrenheitCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class aFromCelsiustoFahrenheitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal aFromCelsiustoFahrenheitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void aFromFahrenheittoCelsiusCompletedEventHandler(object sender, aFromFahrenheittoCelsiusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class aFromFahrenheittoCelsiusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal aFromFahrenheittoCelsiusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void bDateTimeDisplayCompletedEventHandler(object sender, bDateTimeDisplayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class bDateTimeDisplayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal bDateTimeDisplayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void dEuroToLeiCompletedEventHandler(object sender, dEuroToLeiCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dEuroToLeiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dEuroToLeiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void dLeiToEuroCompletedEventHandler(object sender, dLeiToEuroCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dLeiToEuroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dLeiToEuroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void cfiveElementsCompletedEventHandler(object sender, cfiveElementsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cfiveElementsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal cfiveElementsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591