﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace srvFarmaWeb
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="clBase", [Namespace]:="http://schemas.datacontract.org/2004/07/dllFarmaWeb.Comun"),  _
     System.SerializableAttribute(),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(srvFarmaWeb.clMedMedicamento)),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(srvFarmaWeb.clMedInfoParamMedica))>  _
    Partial Public Class clBase
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="clMedMedicamento", [Namespace]:="http://schemas.datacontract.org/2004/07/dllFarmaWeb.Medicamentos"),  _
     System.SerializableAttribute()>  _
    Partial Public Class clMedMedicamento
        Inherits srvFarmaWeb.clBase
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmFFarmIdInfoPMedField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmIdEstadoField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmRegistroSaniField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmTConcIdInfoPMedField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmTMedIdInfoPMedField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmViaAdIdInfoPMedField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmVidaUtilField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mmedCodigoCUMField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mmedDrogIdUsuarioField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mmedIdMedicamentoField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mmedLaborIdInfoPMedField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mmedNombreField As String
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmFFarmIdInfoPMed() As Integer
            Get
                Return Me.mipmFFarmIdInfoPMedField
            End Get
            Set
                If (Me.mipmFFarmIdInfoPMedField.Equals(value) <> true) Then
                    Me.mipmFFarmIdInfoPMedField = value
                    Me.RaisePropertyChanged("mipmFFarmIdInfoPMed")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmIdEstado() As Integer
            Get
                Return Me.mipmIdEstadoField
            End Get
            Set
                If (Me.mipmIdEstadoField.Equals(value) <> true) Then
                    Me.mipmIdEstadoField = value
                    Me.RaisePropertyChanged("mipmIdEstado")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmRegistroSani() As String
            Get
                Return Me.mipmRegistroSaniField
            End Get
            Set
                If (Object.ReferenceEquals(Me.mipmRegistroSaniField, value) <> true) Then
                    Me.mipmRegistroSaniField = value
                    Me.RaisePropertyChanged("mipmRegistroSani")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmTConcIdInfoPMed() As Integer
            Get
                Return Me.mipmTConcIdInfoPMedField
            End Get
            Set
                If (Me.mipmTConcIdInfoPMedField.Equals(value) <> true) Then
                    Me.mipmTConcIdInfoPMedField = value
                    Me.RaisePropertyChanged("mipmTConcIdInfoPMed")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmTMedIdInfoPMed() As Integer
            Get
                Return Me.mipmTMedIdInfoPMedField
            End Get
            Set
                If (Me.mipmTMedIdInfoPMedField.Equals(value) <> true) Then
                    Me.mipmTMedIdInfoPMedField = value
                    Me.RaisePropertyChanged("mipmTMedIdInfoPMed")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmViaAdIdInfoPMed() As Integer
            Get
                Return Me.mipmViaAdIdInfoPMedField
            End Get
            Set
                If (Me.mipmViaAdIdInfoPMedField.Equals(value) <> true) Then
                    Me.mipmViaAdIdInfoPMedField = value
                    Me.RaisePropertyChanged("mipmViaAdIdInfoPMed")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmVidaUtil() As Integer
            Get
                Return Me.mipmVidaUtilField
            End Get
            Set
                If (Me.mipmVidaUtilField.Equals(value) <> true) Then
                    Me.mipmVidaUtilField = value
                    Me.RaisePropertyChanged("mipmVidaUtil")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mmedCodigoCUM() As String
            Get
                Return Me.mmedCodigoCUMField
            End Get
            Set
                If (Object.ReferenceEquals(Me.mmedCodigoCUMField, value) <> true) Then
                    Me.mmedCodigoCUMField = value
                    Me.RaisePropertyChanged("mmedCodigoCUM")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mmedDrogIdUsuario() As Integer
            Get
                Return Me.mmedDrogIdUsuarioField
            End Get
            Set
                If (Me.mmedDrogIdUsuarioField.Equals(value) <> true) Then
                    Me.mmedDrogIdUsuarioField = value
                    Me.RaisePropertyChanged("mmedDrogIdUsuario")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mmedIdMedicamento() As Integer
            Get
                Return Me.mmedIdMedicamentoField
            End Get
            Set
                If (Me.mmedIdMedicamentoField.Equals(value) <> true) Then
                    Me.mmedIdMedicamentoField = value
                    Me.RaisePropertyChanged("mmedIdMedicamento")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mmedLaborIdInfoPMed() As Integer
            Get
                Return Me.mmedLaborIdInfoPMedField
            End Get
            Set
                If (Me.mmedLaborIdInfoPMedField.Equals(value) <> true) Then
                    Me.mmedLaborIdInfoPMedField = value
                    Me.RaisePropertyChanged("mmedLaborIdInfoPMed")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mmedNombre() As String
            Get
                Return Me.mmedNombreField
            End Get
            Set
                If (Object.ReferenceEquals(Me.mmedNombreField, value) <> true) Then
                    Me.mmedNombreField = value
                    Me.RaisePropertyChanged("mmedNombre")
                End If
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="clMedInfoParamMedica", [Namespace]:="http://schemas.datacontract.org/2004/07/dllFarmaWeb.Medicamentos"),  _
     System.SerializableAttribute()>  _
    Partial Public Class clMedInfoParamMedica
        Inherits srvFarmaWeb.clBase
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmIdEstadoField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmIdInfoPMedField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmIdTipoInfoField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mipmValorField As String
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmIdEstado() As Integer
            Get
                Return Me.mipmIdEstadoField
            End Get
            Set
                If (Me.mipmIdEstadoField.Equals(value) <> true) Then
                    Me.mipmIdEstadoField = value
                    Me.RaisePropertyChanged("mipmIdEstado")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmIdInfoPMed() As Integer
            Get
                Return Me.mipmIdInfoPMedField
            End Get
            Set
                If (Me.mipmIdInfoPMedField.Equals(value) <> true) Then
                    Me.mipmIdInfoPMedField = value
                    Me.RaisePropertyChanged("mipmIdInfoPMed")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmIdTipoInfo() As Integer
            Get
                Return Me.mipmIdTipoInfoField
            End Get
            Set
                If (Me.mipmIdTipoInfoField.Equals(value) <> true) Then
                    Me.mipmIdTipoInfoField = value
                    Me.RaisePropertyChanged("mipmIdTipoInfo")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mipmValor() As String
            Get
                Return Me.mipmValorField
            End Get
            Set
                If (Object.ReferenceEquals(Me.mipmValorField, value) <> true) Then
                    Me.mipmValorField = value
                    Me.RaisePropertyChanged("mipmValor")
                End If
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="clObjMsjRS", [Namespace]:="http://schemas.datacontract.org/2004/07/wcfFarmaWeb.Message"),  _
     System.SerializableAttribute()>  _
    Partial Public Class clObjMsjRS
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private pIdRelField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private pStrMessageField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property pIdRel() As Integer
            Get
                Return Me.pIdRelField
            End Get
            Set
                If (Me.pIdRelField.Equals(value) <> true) Then
                    Me.pIdRelField = value
                    Me.RaisePropertyChanged("pIdRel")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property pStrMessage() As String
            Get
                Return Me.pStrMessageField
            End Get
            Set
                If (Object.ReferenceEquals(Me.pStrMessageField, value) <> true) Then
                    Me.pStrMessageField = value
                    Me.RaisePropertyChanged("pStrMessage")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="srvFarmaWeb.IsrvFarmaWeb")>  _
    Public Interface IsrvFarmaWeb
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/GetTblTipoInfoXIdEstado", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/GetTblTipoInfoXIdEstadoResponse")>  _
        Function GetTblTipoInfoXIdEstado(ByVal parIdEstado As Integer) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/GuardarInfoParamMedica", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/GuardarInfoParamMedicaResponse")>  _
        Function GuardarInfoParamMedica(ByVal parObjInfoParamMedica As srvFarmaWeb.clMedInfoParamMedica) As srvFarmaWeb.clObjMsjRS
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/CargarInfoParamMedicaXId", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/CargarInfoParamMedicaXIdResponse")>  _
        Function CargarInfoParamMedicaXId(ByVal parIdInfoPMed As Integer) As srvFarmaWeb.clMedInfoParamMedica
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/GetTblEstado", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/GetTblEstadoResponse")>  _
        Function GetTblEstado() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/GetTblInfoParamMedXIdTipoInfo", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/GetTblInfoParamMedXIdTipoInfoResponse")>  _
        Function GetTblInfoParamMedXIdTipoInfo(ByVal parIdTipoInfo As Integer, ByVal parIdEstado As Integer) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/GuardarInfoMedicamentoXId", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/GuardarInfoMedicamentoXIdResponse")>  _
        Function GuardarInfoMedicamentoXId(ByVal parObjMedicamento As srvFarmaWeb.clMedMedicamento) As srvFarmaWeb.clObjMsjRS
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/GetTblMedicamentoXStrNom", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/GetTblMedicamentoXStrNomResponse")>  _
        Function GetTblMedicamentoXStrNom(ByVal parStrNombre As String, ByVal parIdUsuario As Integer) As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IsrvFarmaWeb/CargarInfoMedciamentoXIdMed", ReplyAction:="http://tempuri.org/IsrvFarmaWeb/CargarInfoMedciamentoXIdMedResponse")>  _
        Function CargarInfoMedciamentoXIdMed(ByVal parIdMedicamento As Integer) As srvFarmaWeb.clMedMedicamento
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IsrvFarmaWebChannel
        Inherits srvFarmaWeb.IsrvFarmaWeb, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class IsrvFarmaWebClient
        Inherits System.ServiceModel.ClientBase(Of srvFarmaWeb.IsrvFarmaWeb)
        Implements srvFarmaWeb.IsrvFarmaWeb
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetTblTipoInfoXIdEstado(ByVal parIdEstado As Integer) As System.Data.DataTable Implements srvFarmaWeb.IsrvFarmaWeb.GetTblTipoInfoXIdEstado
            Return MyBase.Channel.GetTblTipoInfoXIdEstado(parIdEstado)
        End Function
        
        Public Function GuardarInfoParamMedica(ByVal parObjInfoParamMedica As srvFarmaWeb.clMedInfoParamMedica) As srvFarmaWeb.clObjMsjRS Implements srvFarmaWeb.IsrvFarmaWeb.GuardarInfoParamMedica
            Return MyBase.Channel.GuardarInfoParamMedica(parObjInfoParamMedica)
        End Function
        
        Public Function CargarInfoParamMedicaXId(ByVal parIdInfoPMed As Integer) As srvFarmaWeb.clMedInfoParamMedica Implements srvFarmaWeb.IsrvFarmaWeb.CargarInfoParamMedicaXId
            Return MyBase.Channel.CargarInfoParamMedicaXId(parIdInfoPMed)
        End Function
        
        Public Function GetTblEstado() As System.Data.DataTable Implements srvFarmaWeb.IsrvFarmaWeb.GetTblEstado
            Return MyBase.Channel.GetTblEstado
        End Function
        
        Public Function GetTblInfoParamMedXIdTipoInfo(ByVal parIdTipoInfo As Integer, ByVal parIdEstado As Integer) As System.Data.DataTable Implements srvFarmaWeb.IsrvFarmaWeb.GetTblInfoParamMedXIdTipoInfo
            Return MyBase.Channel.GetTblInfoParamMedXIdTipoInfo(parIdTipoInfo, parIdEstado)
        End Function
        
        Public Function GuardarInfoMedicamentoXId(ByVal parObjMedicamento As srvFarmaWeb.clMedMedicamento) As srvFarmaWeb.clObjMsjRS Implements srvFarmaWeb.IsrvFarmaWeb.GuardarInfoMedicamentoXId
            Return MyBase.Channel.GuardarInfoMedicamentoXId(parObjMedicamento)
        End Function
        
        Public Function GetTblMedicamentoXStrNom(ByVal parStrNombre As String, ByVal parIdUsuario As Integer) As System.Data.DataTable Implements srvFarmaWeb.IsrvFarmaWeb.GetTblMedicamentoXStrNom
            Return MyBase.Channel.GetTblMedicamentoXStrNom(parStrNombre, parIdUsuario)
        End Function
        
        Public Function CargarInfoMedciamentoXIdMed(ByVal parIdMedicamento As Integer) As srvFarmaWeb.clMedMedicamento Implements srvFarmaWeb.IsrvFarmaWeb.CargarInfoMedciamentoXIdMed
            Return MyBase.Channel.CargarInfoMedciamentoXIdMed(parIdMedicamento)
        End Function
    End Class
End Namespace