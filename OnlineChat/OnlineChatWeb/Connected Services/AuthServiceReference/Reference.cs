﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineChatWeb.AuthServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthServiceReference.IAuthService")]
    public interface IAuthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetLogin", ReplyAction="http://tempuri.org/IAuthService/GetLoginResponse")]
        string GetLogin(int cookieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetLogin", ReplyAction="http://tempuri.org/IAuthService/GetLoginResponse")]
        System.Threading.Tasks.Task<string> GetLoginAsync(int cookieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/SaveLogin", ReplyAction="http://tempuri.org/IAuthService/SaveLoginResponse")]
        int SaveLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/SaveLogin", ReplyAction="http://tempuri.org/IAuthService/SaveLoginResponse")]
        System.Threading.Tasks.Task<int> SaveLoginAsync(string login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServiceChannel : OnlineChatWeb.AuthServiceReference.IAuthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceClient : System.ServiceModel.ClientBase<OnlineChatWeb.AuthServiceReference.IAuthService>, OnlineChatWeb.AuthServiceReference.IAuthService {
        
        public AuthServiceClient() {
        }
        
        public AuthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetLogin(int cookieId) {
            return base.Channel.GetLogin(cookieId);
        }
        
        public System.Threading.Tasks.Task<string> GetLoginAsync(int cookieId) {
            return base.Channel.GetLoginAsync(cookieId);
        }
        
        public int SaveLogin(string login) {
            return base.Channel.SaveLogin(login);
        }
        
        public System.Threading.Tasks.Task<int> SaveLoginAsync(string login) {
            return base.Channel.SaveLoginAsync(login);
        }
    }
}
