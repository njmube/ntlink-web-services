//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAT.CFDI.Cliente.Procesamiento.AutenticaRetencion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AutenticaRetencion.IAutenticacion")]
    public interface IAutenticacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutenticacion/GetServerDate", ReplyAction="http://tempuri.org/IAutenticacion/GetServerDateResponse")]
        string GetServerDate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAutenticacion/Autentica", ReplyAction="http://tempuri.org/IAutenticacion/AutenticaResponse")]
        string Autentica();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAutenticacionChannel : SAT.CFDI.Cliente.Procesamiento.AutenticaRetencion.IAutenticacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AutenticacionClient : System.ServiceModel.ClientBase<SAT.CFDI.Cliente.Procesamiento.AutenticaRetencion.IAutenticacion>, SAT.CFDI.Cliente.Procesamiento.AutenticaRetencion.IAutenticacion {
        
        public AutenticacionClient() {
        }
        
        public AutenticacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AutenticacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutenticacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AutenticacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetServerDate() {
            return base.Channel.GetServerDate();
        }
        
        public string Autentica() {
            return base.Channel.Autentica();
        }
    }
}
