﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.1
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UkrHistoryClient.UkrHistoryReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UkrHistoryReference1.IUkrHistoryService")]
    public interface IUkrHistoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUkrHistoryService/FindEvents", ReplyAction="http://tempuri.org/IUkrHistoryService/FindEventsResponse")]
        string FindEvents(string a);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUkrHistoryServiceChannel : UkrHistoryClient.UkrHistoryReference1.IUkrHistoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UkrHistoryServiceClient : System.ServiceModel.ClientBase<UkrHistoryClient.UkrHistoryReference1.IUkrHistoryService>, UkrHistoryClient.UkrHistoryReference1.IUkrHistoryService {
        
        public UkrHistoryServiceClient() {
        }
        
        public UkrHistoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UkrHistoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UkrHistoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UkrHistoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string FindEvents(string a) {
            return base.Channel.FindEvents(a);
        }
    }
}