//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebasUnitarias.NtLink {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmpresaNtLink", Namespace="http://schemas.datacontract.org/2004/07/CertificadorWs.Business")]
    [System.SerializableAttribute()]
    public partial class EmpresaNtLink : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiudadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColoniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaContratoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FoliosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RazonSocialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegimenFiscalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RfcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SucursalesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TimbresContratadosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UsuariosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ciudad {
            get {
                return this.CiudadField;
            }
            set {
                if ((object.ReferenceEquals(this.CiudadField, value) != true)) {
                    this.CiudadField = value;
                    this.RaisePropertyChanged("Ciudad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Colonia {
            get {
                return this.ColoniaField;
            }
            set {
                if ((object.ReferenceEquals(this.ColoniaField, value) != true)) {
                    this.ColoniaField = value;
                    this.RaisePropertyChanged("Colonia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contacto {
            get {
                return this.ContactoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactoField, value) != true)) {
                    this.ContactoField = value;
                    this.RaisePropertyChanged("Contacto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cp {
            get {
                return this.CpField;
            }
            set {
                if ((object.ReferenceEquals(this.CpField, value) != true)) {
                    this.CpField = value;
                    this.RaisePropertyChanged("Cp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Curp {
            get {
                return this.CurpField;
            }
            set {
                if ((object.ReferenceEquals(this.CurpField, value) != true)) {
                    this.CurpField = value;
                    this.RaisePropertyChanged("Curp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaContrato {
            get {
                return this.FechaContratoField;
            }
            set {
                if ((this.FechaContratoField.Equals(value) != true)) {
                    this.FechaContratoField = value;
                    this.RaisePropertyChanged("FechaContrato");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Folios {
            get {
                return this.FoliosField;
            }
            set {
                if ((this.FoliosField.Equals(value) != true)) {
                    this.FoliosField = value;
                    this.RaisePropertyChanged("Folios");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RazonSocial {
            get {
                return this.RazonSocialField;
            }
            set {
                if ((object.ReferenceEquals(this.RazonSocialField, value) != true)) {
                    this.RazonSocialField = value;
                    this.RaisePropertyChanged("RazonSocial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegimenFiscal {
            get {
                return this.RegimenFiscalField;
            }
            set {
                if ((object.ReferenceEquals(this.RegimenFiscalField, value) != true)) {
                    this.RegimenFiscalField = value;
                    this.RaisePropertyChanged("RegimenFiscal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rfc {
            get {
                return this.RfcField;
            }
            set {
                if ((object.ReferenceEquals(this.RfcField, value) != true)) {
                    this.RfcField = value;
                    this.RaisePropertyChanged("Rfc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sucursales {
            get {
                return this.SucursalesField;
            }
            set {
                if ((this.SucursalesField.Equals(value) != true)) {
                    this.SucursalesField = value;
                    this.RaisePropertyChanged("Sucursales");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TimbresContratados {
            get {
                return this.TimbresContratadosField;
            }
            set {
                if ((this.TimbresContratadosField.Equals(value) != true)) {
                    this.TimbresContratadosField = value;
                    this.RaisePropertyChanged("TimbresContratados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Usuarios {
            get {
                return this.UsuariosField;
            }
            set {
                if ((this.UsuariosField.Equals(value) != true)) {
                    this.UsuariosField = value;
                    this.RaisePropertyChanged("Usuarios");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteNtLink", Namespace="http://schemas.datacontract.org/2004/07/CertificadorWs.Business")]
    [System.SerializableAttribute()]
    public partial class ClienteNtLink : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiudadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColoniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmpresasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaContratoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RazonSocialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegimenFiscalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RfcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SucursalesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TimbresConsumidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TimbresContratadosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UsuariosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ciudad {
            get {
                return this.CiudadField;
            }
            set {
                if ((object.ReferenceEquals(this.CiudadField, value) != true)) {
                    this.CiudadField = value;
                    this.RaisePropertyChanged("Ciudad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Colonia {
            get {
                return this.ColoniaField;
            }
            set {
                if ((object.ReferenceEquals(this.ColoniaField, value) != true)) {
                    this.ColoniaField = value;
                    this.RaisePropertyChanged("Colonia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contacto {
            get {
                return this.ContactoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactoField, value) != true)) {
                    this.ContactoField = value;
                    this.RaisePropertyChanged("Contacto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cp {
            get {
                return this.CpField;
            }
            set {
                if ((object.ReferenceEquals(this.CpField, value) != true)) {
                    this.CpField = value;
                    this.RaisePropertyChanged("Cp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Empresas {
            get {
                return this.EmpresasField;
            }
            set {
                if ((this.EmpresasField.Equals(value) != true)) {
                    this.EmpresasField = value;
                    this.RaisePropertyChanged("Empresas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaContrato {
            get {
                return this.FechaContratoField;
            }
            set {
                if ((this.FechaContratoField.Equals(value) != true)) {
                    this.FechaContratoField = value;
                    this.RaisePropertyChanged("FechaContrato");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RazonSocial {
            get {
                return this.RazonSocialField;
            }
            set {
                if ((object.ReferenceEquals(this.RazonSocialField, value) != true)) {
                    this.RazonSocialField = value;
                    this.RaisePropertyChanged("RazonSocial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegimenFiscal {
            get {
                return this.RegimenFiscalField;
            }
            set {
                if ((object.ReferenceEquals(this.RegimenFiscalField, value) != true)) {
                    this.RegimenFiscalField = value;
                    this.RaisePropertyChanged("RegimenFiscal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rfc {
            get {
                return this.RfcField;
            }
            set {
                if ((object.ReferenceEquals(this.RfcField, value) != true)) {
                    this.RfcField = value;
                    this.RaisePropertyChanged("Rfc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sucursales {
            get {
                return this.SucursalesField;
            }
            set {
                if ((this.SucursalesField.Equals(value) != true)) {
                    this.SucursalesField = value;
                    this.RaisePropertyChanged("Sucursales");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TimbresConsumidos {
            get {
                return this.TimbresConsumidosField;
            }
            set {
                if ((this.TimbresConsumidosField.Equals(value) != true)) {
                    this.TimbresConsumidosField = value;
                    this.RaisePropertyChanged("TimbresConsumidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TimbresContratados {
            get {
                return this.TimbresContratadosField;
            }
            set {
                if ((this.TimbresContratadosField.Equals(value) != true)) {
                    this.TimbresContratadosField = value;
                    this.RaisePropertyChanged("TimbresContratados");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Usuarios {
            get {
                return this.UsuariosField;
            }
            set {
                if ((this.UsuariosField.Equals(value) != true)) {
                    this.UsuariosField = value;
                    this.RaisePropertyChanged("Usuarios");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaCancelacion", Namespace="http://schemas.datacontract.org/2004/07/CertificadorWs.Business")]
    [System.SerializableAttribute()]
    public partial class RespuestaCancelacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AcuseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PruebasUnitarias.NtLink.StatusUuid[] StatusUuidsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Acuse {
            get {
                return this.AcuseField;
            }
            set {
                if ((object.ReferenceEquals(this.AcuseField, value) != true)) {
                    this.AcuseField = value;
                    this.RaisePropertyChanged("Acuse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeError {
            get {
                return this.MensajeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeErrorField, value) != true)) {
                    this.MensajeErrorField = value;
                    this.RaisePropertyChanged("MensajeError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PruebasUnitarias.NtLink.StatusUuid[] StatusUuids {
            get {
                return this.StatusUuidsField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusUuidsField, value) != true)) {
                    this.StatusUuidsField = value;
                    this.RaisePropertyChanged("StatusUuids");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusUuid", Namespace="http://schemas.datacontract.org/2004/07/CertificadorWs.Business")]
    [System.SerializableAttribute()]
    public partial class StatusUuid : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UuidField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uuid {
            get {
                return this.UuidField;
            }
            set {
                if ((object.ReferenceEquals(this.UuidField, value) != true)) {
                    this.UuidField = value;
                    this.RaisePropertyChanged("Uuid");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://ntlink.com.mx/IServicioTimbrado", ConfigurationName="NtLink.IServicioTimbrado")]
    public interface IServicioTimbrado {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/RegistraEmpresa", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/RegistraEmpresaResponse" +
            "")]
        void RegistraEmpresa(string userName, string password, PruebasUnitarias.NtLink.EmpresaNtLink empresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/BajaEmpresa", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/BajaEmpresaResponse")]
        void BajaEmpresa(string userName, string password, string rfcEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/ObtenerDatosCliente", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/ObtenerDatosClienteResp" +
            "onse")]
        PruebasUnitarias.NtLink.ClienteNtLink ObtenerDatosCliente(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/ObtenerEmpresas", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/ObtenerEmpresasResponse" +
            "")]
        PruebasUnitarias.NtLink.EmpresaNtLink[] ObtenerEmpresas(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/TimbraCfdiQr", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/TimbraCfdiQrResponse")]
        CertificadorWs.TimbradoResponse TimbraCfdiQr(string userName, string password, string comprobante);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/TimbraCfdi", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/TimbraCfdiResponse")]
        string TimbraCfdi(string userName, string password, string comprobante);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/CancelaCfdi", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/CancelaCfdiResponse")]
        string CancelaCfdi(string userName, string password, string uuid, string rfc);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/CancelaCfdiRequest", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/CancelaCfdiRequestRespo" +
            "nse")]
        PruebasUnitarias.NtLink.RespuestaCancelacion CancelaCfdiRequest(string userName, string password, string requestCancelacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/ObtenerStatusUuid", ReplyAction="https://ntlink.com.mx/IServicioTimbrado/IServicioTimbrado/ObtenerStatusUuidRespon" +
            "se")]
        CertificadorWs.ResultadoConsulta ObtenerStatusUuid(string userName, string password, string uuid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioTimbradoChannel : PruebasUnitarias.NtLink.IServicioTimbrado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioTimbradoClient : System.ServiceModel.ClientBase<PruebasUnitarias.NtLink.IServicioTimbrado>, PruebasUnitarias.NtLink.IServicioTimbrado {
        
        public ServicioTimbradoClient() {
        }
        
        public ServicioTimbradoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioTimbradoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioTimbradoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioTimbradoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegistraEmpresa(string userName, string password, PruebasUnitarias.NtLink.EmpresaNtLink empresa) {
            base.Channel.RegistraEmpresa(userName, password, empresa);
        }
        
        public void BajaEmpresa(string userName, string password, string rfcEmpresa) {
            base.Channel.BajaEmpresa(userName, password, rfcEmpresa);
        }
        
        public PruebasUnitarias.NtLink.ClienteNtLink ObtenerDatosCliente(string userName, string password) {
            return base.Channel.ObtenerDatosCliente(userName, password);
        }
        
        public PruebasUnitarias.NtLink.EmpresaNtLink[] ObtenerEmpresas(string userName, string password) {
            return base.Channel.ObtenerEmpresas(userName, password);
        }
        
        public CertificadorWs.TimbradoResponse TimbraCfdiQr(string userName, string password, string comprobante) {
            return base.Channel.TimbraCfdiQr(userName, password, comprobante);
        }
        
        public string TimbraCfdi(string userName, string password, string comprobante) {
            return base.Channel.TimbraCfdi(userName, password, comprobante);
        }
        
        public string CancelaCfdi(string userName, string password, string uuid, string rfc) {
            return base.Channel.CancelaCfdi(userName, password, uuid, rfc);
        }
        
        public PruebasUnitarias.NtLink.RespuestaCancelacion CancelaCfdiRequest(string userName, string password, string requestCancelacion) {
            return base.Channel.CancelaCfdiRequest(userName, password, requestCancelacion);
        }
        
        public CertificadorWs.ResultadoConsulta ObtenerStatusUuid(string userName, string password, string uuid) {
            return base.Channel.ObtenerStatusUuid(userName, password, uuid);
        }
    }
}
