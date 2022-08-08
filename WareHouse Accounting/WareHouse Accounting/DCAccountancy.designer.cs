﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WareHouse_Accounting
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WareHouseAccounting")]
	public partial class DCAccountancyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSetting(Setting instance);
    partial void UpdateSetting(Setting instance);
    partial void DeleteSetting(Setting instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    #endregion
		
		public DCAccountancyDataContext() : 
				base(global::WareHouse_Accounting.Properties.Settings.Default.WareHouseAccountingConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCAccountancyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCAccountancyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCAccountancyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCAccountancyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Setting> Settings
		{
			get
			{
				return this.GetTable<Setting>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FiLLSettings")]
		public ISingleResult<Setting> FiLLSettings()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Setting>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertSettings")]
		public int InsertSettings([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CompanyName", DbType="NVarChar(100)")] string companyName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AddressOfInvoices", DbType="NVarChar(MAX)")] string addressOfInvoices, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarehouseRemittanceAddress", DbType="NVarChar(MAX)")] string warehouseRemittanceAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ContactNumberOfInvoices", DbType="NVarChar(20)")] string contactNumberOfInvoices, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarehouseRemittanceContactNumber", DbType="NVarChar(20)")] string warehouseRemittanceContactNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSPanelUserName", DbType="NVarChar(20)")] string sMSPanelUserName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSPanelPassword", DbType="NVarChar(20)")] string sMSPanelPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSRecipientNumber", DbType="NVarChar(11)")] string sMSRecipientNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSSender", DbType="NVarChar(20)")] string sMSSender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarningCameFrom", DbType="Int")] System.Nullable<int> warningCameFrom, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarningCameTo", DbType="Int")] System.Nullable<int> warningCameTo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SendSMSForTransactions", DbType="Bit")] System.Nullable<bool> sendSMSForTransactions, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SendSMSForInvoices", DbType="Bit")] System.Nullable<bool> sendSMSForInvoices, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastEditDateTime", DbType="DateTime")] System.Nullable<System.DateTime> lastEditDateTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), companyName, addressOfInvoices, warehouseRemittanceAddress, contactNumberOfInvoices, warehouseRemittanceContactNumber, sMSPanelUserName, sMSPanelPassword, sMSRecipientNumber, sMSSender, warningCameFrom, warningCameTo, sendSMSForTransactions, sendSMSForInvoices, lastEditDateTime);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateSettings")]
		public int UpdateSettings([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CompanyName", DbType="NVarChar(100)")] string companyName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AddressOfInvoices", DbType="NVarChar(MAX)")] string addressOfInvoices, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarehouseRemittanceAddress", DbType="NVarChar(MAX)")] string warehouseRemittanceAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ContactNumberOfInvoices", DbType="NVarChar(20)")] string contactNumberOfInvoices, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarehouseRemittanceContactNumber", DbType="NVarChar(20)")] string warehouseRemittanceContactNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSPanelUserName", DbType="NVarChar(20)")] string sMSPanelUserName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSPanelPassword", DbType="NVarChar(20)")] string sMSPanelPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSRecipientNumber", DbType="NVarChar(11)")] string sMSRecipientNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMSSender", DbType="NVarChar(20)")] string sMSSender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarningCameFrom", DbType="Int")] System.Nullable<int> warningCameFrom, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WarningCameTo", DbType="Int")] System.Nullable<int> warningCameTo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SendSMSForTransactions", DbType="Bit")] System.Nullable<bool> sendSMSForTransactions, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SendSMSForInvoices", DbType="Bit")] System.Nullable<bool> sendSMSForInvoices, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastEditDateTime", DbType="DateTime")] System.Nullable<System.DateTime> lastEditDateTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), companyName, addressOfInvoices, warehouseRemittanceAddress, contactNumberOfInvoices, warehouseRemittanceContactNumber, sMSPanelUserName, sMSPanelPassword, sMSRecipientNumber, sMSSender, warningCameFrom, warningCameTo, sendSMSForTransactions, sendSMSForInvoices, lastEditDateTime);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ExistSettings")]
		public int ExistSettings([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Exist", DbType="Bit")] ref System.Nullable<bool> exist)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), exist);
			exist = ((System.Nullable<bool>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteRoles")]
		public int DeleteRoles([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Role_Id", DbType="Int")] System.Nullable<int> role_Id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), role_Id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ExistRoles")]
		public int ExistRoles([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Exist", DbType="Bit")] ref System.Nullable<bool> exist)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), exist);
			exist = ((System.Nullable<bool>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FillRolesByRoleID")]
		public ISingleResult<Role> FillRolesByRoleID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Role_Id", DbType="Int")] System.Nullable<int> role_Id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), role_Id);
			return ((ISingleResult<Role>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertRoles")]
		public int InsertRoles([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleName", DbType="NVarChar(100)")] string roleName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepotPermission", DbType="Bit")] System.Nullable<bool> depotPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BankPermission", DbType="Bit")] System.Nullable<bool> bankPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PersonPermission", DbType="Bit")] System.Nullable<bool> personPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FactorPermission", DbType="Bit")] System.Nullable<bool> factorPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SettingPermission", DbType="Bit")] System.Nullable<bool> settingPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserPermission", DbType="Bit")] System.Nullable<bool> userPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastEditDateTime", DbType="DateTime")] System.Nullable<System.DateTime> lastEditDateTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), roleName, depotPermission, bankPermission, personPermission, factorPermission, settingPermission, userPermission, lastEditDateTime);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FillRoles")]
		public ISingleResult<Role> FillRoles()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Role>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateRoles")]
		public int UpdateRoles([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RolesId", DbType="Int")] System.Nullable<int> rolesId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleName", DbType="NVarChar(100)")] string roleName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepotPermission", DbType="Bit")] System.Nullable<bool> depotPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BankPermission", DbType="Bit")] System.Nullable<bool> bankPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PersonPermission", DbType="Bit")] System.Nullable<bool> personPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FactorPermission", DbType="Bit")] System.Nullable<bool> factorPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SettingPermission", DbType="Bit")] System.Nullable<bool> settingPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserPermission", DbType="Bit")] System.Nullable<bool> userPermission, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastEditDateTime", DbType="DateTime")] System.Nullable<System.DateTime> lastEditDateTime)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), rolesId, roleName, depotPermission, bankPermission, personPermission, factorPermission, settingPermission, userPermission, lastEditDateTime);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Settings")]
	public sealed partial class Setting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Setiing_Id;
		
		private string _CompanyName;
		
		private string _AddressOfInvoices;
		
		private string _WarehouseRemittanceAddress;
		
		private string _ContactNumberOfInvoices;
		
		private string _WarehouseRemittanceContactNumber;
		
		private string _SMSPanelUserName;
		
		private string _SMSPanelPassword;
		
		private string _SMSRecipientNumber;
		
		private string _SMSSender;
		
		private System.Nullable<int> _WarningCameFrom;
		
		private System.Nullable<int> _WarningCameTo;
		
		private System.Nullable<bool> _SendSMSForTransactions;
		
		private System.Nullable<bool> _SendSMSForInvoices;
		
		private System.DateTime _LastEditDateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSetiing_IdChanging(int value);
    partial void OnSetiing_IdChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnAddressOfInvoicesChanging(string value);
    partial void OnAddressOfInvoicesChanged();
    partial void OnWarehouseRemittanceAddressChanging(string value);
    partial void OnWarehouseRemittanceAddressChanged();
    partial void OnContactNumberOfInvoicesChanging(string value);
    partial void OnContactNumberOfInvoicesChanged();
    partial void OnWarehouseRemittanceContactNumberChanging(string value);
    partial void OnWarehouseRemittanceContactNumberChanged();
    partial void OnSMSPanelUserNameChanging(string value);
    partial void OnSMSPanelUserNameChanged();
    partial void OnSMSPanelPasswordChanging(string value);
    partial void OnSMSPanelPasswordChanged();
    partial void OnSMSRecipientNumberChanging(string value);
    partial void OnSMSRecipientNumberChanged();
    partial void OnSMSSenderChanging(string value);
    partial void OnSMSSenderChanged();
    partial void OnWarningCameFromChanging(System.Nullable<int> value);
    partial void OnWarningCameFromChanged();
    partial void OnWarningCameToChanging(System.Nullable<int> value);
    partial void OnWarningCameToChanged();
    partial void OnSendSMSForTransactionsChanging(System.Nullable<bool> value);
    partial void OnSendSMSForTransactionsChanged();
    partial void OnSendSMSForInvoicesChanging(System.Nullable<bool> value);
    partial void OnSendSMSForInvoicesChanged();
    partial void OnLastEditDateTimeChanging(System.DateTime value);
    partial void OnLastEditDateTimeChanged();
    #endregion
		
		public Setting()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Setiing_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Setiing_Id
		{
			get
			{
				return this._Setiing_Id;
			}
			set
			{
				if ((this._Setiing_Id != value))
				{
					this.OnSetiing_IdChanging(value);
					this.SendPropertyChanging();
					this._Setiing_Id = value;
					this.SendPropertyChanged("Setiing_Id");
					this.OnSetiing_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(100)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressOfInvoices", DbType="NVarChar(MAX)")]
		public string AddressOfInvoices
		{
			get
			{
				return this._AddressOfInvoices;
			}
			set
			{
				if ((this._AddressOfInvoices != value))
				{
					this.OnAddressOfInvoicesChanging(value);
					this.SendPropertyChanging();
					this._AddressOfInvoices = value;
					this.SendPropertyChanged("AddressOfInvoices");
					this.OnAddressOfInvoicesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WarehouseRemittanceAddress", DbType="NVarChar(MAX)")]
		public string WarehouseRemittanceAddress
		{
			get
			{
				return this._WarehouseRemittanceAddress;
			}
			set
			{
				if ((this._WarehouseRemittanceAddress != value))
				{
					this.OnWarehouseRemittanceAddressChanging(value);
					this.SendPropertyChanging();
					this._WarehouseRemittanceAddress = value;
					this.SendPropertyChanged("WarehouseRemittanceAddress");
					this.OnWarehouseRemittanceAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNumberOfInvoices", DbType="NVarChar(20)")]
		public string ContactNumberOfInvoices
		{
			get
			{
				return this._ContactNumberOfInvoices;
			}
			set
			{
				if ((this._ContactNumberOfInvoices != value))
				{
					this.OnContactNumberOfInvoicesChanging(value);
					this.SendPropertyChanging();
					this._ContactNumberOfInvoices = value;
					this.SendPropertyChanged("ContactNumberOfInvoices");
					this.OnContactNumberOfInvoicesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WarehouseRemittanceContactNumber", DbType="NVarChar(20)")]
		public string WarehouseRemittanceContactNumber
		{
			get
			{
				return this._WarehouseRemittanceContactNumber;
			}
			set
			{
				if ((this._WarehouseRemittanceContactNumber != value))
				{
					this.OnWarehouseRemittanceContactNumberChanging(value);
					this.SendPropertyChanging();
					this._WarehouseRemittanceContactNumber = value;
					this.SendPropertyChanged("WarehouseRemittanceContactNumber");
					this.OnWarehouseRemittanceContactNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMSPanelUserName", DbType="NVarChar(20)")]
		public string SMSPanelUserName
		{
			get
			{
				return this._SMSPanelUserName;
			}
			set
			{
				if ((this._SMSPanelUserName != value))
				{
					this.OnSMSPanelUserNameChanging(value);
					this.SendPropertyChanging();
					this._SMSPanelUserName = value;
					this.SendPropertyChanged("SMSPanelUserName");
					this.OnSMSPanelUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMSPanelPassword", DbType="NVarChar(20)")]
		public string SMSPanelPassword
		{
			get
			{
				return this._SMSPanelPassword;
			}
			set
			{
				if ((this._SMSPanelPassword != value))
				{
					this.OnSMSPanelPasswordChanging(value);
					this.SendPropertyChanging();
					this._SMSPanelPassword = value;
					this.SendPropertyChanged("SMSPanelPassword");
					this.OnSMSPanelPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMSRecipientNumber", DbType="NVarChar(11)")]
		public string SMSRecipientNumber
		{
			get
			{
				return this._SMSRecipientNumber;
			}
			set
			{
				if ((this._SMSRecipientNumber != value))
				{
					this.OnSMSRecipientNumberChanging(value);
					this.SendPropertyChanging();
					this._SMSRecipientNumber = value;
					this.SendPropertyChanged("SMSRecipientNumber");
					this.OnSMSRecipientNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMSSender", DbType="NVarChar(20)")]
		public string SMSSender
		{
			get
			{
				return this._SMSSender;
			}
			set
			{
				if ((this._SMSSender != value))
				{
					this.OnSMSSenderChanging(value);
					this.SendPropertyChanging();
					this._SMSSender = value;
					this.SendPropertyChanged("SMSSender");
					this.OnSMSSenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WarningCameFrom", DbType="Int")]
		public System.Nullable<int> WarningCameFrom
		{
			get
			{
				return this._WarningCameFrom;
			}
			set
			{
				if ((this._WarningCameFrom != value))
				{
					this.OnWarningCameFromChanging(value);
					this.SendPropertyChanging();
					this._WarningCameFrom = value;
					this.SendPropertyChanged("WarningCameFrom");
					this.OnWarningCameFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WarningCameTo", DbType="Int")]
		public System.Nullable<int> WarningCameTo
		{
			get
			{
				return this._WarningCameTo;
			}
			set
			{
				if ((this._WarningCameTo != value))
				{
					this.OnWarningCameToChanging(value);
					this.SendPropertyChanging();
					this._WarningCameTo = value;
					this.SendPropertyChanged("WarningCameTo");
					this.OnWarningCameToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SendSMSForTransactions", DbType="Bit")]
		public System.Nullable<bool> SendSMSForTransactions
		{
			get
			{
				return this._SendSMSForTransactions;
			}
			set
			{
				if ((this._SendSMSForTransactions != value))
				{
					this.OnSendSMSForTransactionsChanging(value);
					this.SendPropertyChanging();
					this._SendSMSForTransactions = value;
					this.SendPropertyChanged("SendSMSForTransactions");
					this.OnSendSMSForTransactionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SendSMSForInvoices", DbType="Bit")]
		public System.Nullable<bool> SendSMSForInvoices
		{
			get
			{
				return this._SendSMSForInvoices;
			}
			set
			{
				if ((this._SendSMSForInvoices != value))
				{
					this.OnSendSMSForInvoicesChanging(value);
					this.SendPropertyChanging();
					this._SendSMSForInvoices = value;
					this.SendPropertyChanged("SendSMSForInvoices");
					this.OnSendSMSForInvoicesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastEditDateTime", DbType="DateTime NOT NULL")]
		public System.DateTime LastEditDateTime
		{
			get
			{
				return this._LastEditDateTime;
			}
			set
			{
				if ((this._LastEditDateTime != value))
				{
					this.OnLastEditDateTimeChanging(value);
					this.SendPropertyChanging();
					this._LastEditDateTime = value;
					this.SendPropertyChanged("LastEditDateTime");
					this.OnLastEditDateTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		private void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		private void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public sealed partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Role_Id;
		
		private string _RoleName;
		
		private System.Nullable<bool> _DepotPermission;
		
		private System.Nullable<bool> _BankPermission;
		
		private System.Nullable<bool> _PersonPermission;
		
		private System.Nullable<bool> _FactorPermission;
		
		private System.Nullable<bool> _SettingPermission;
		
		private System.Nullable<bool> _UserPermission;
		
		private System.DateTime _LastEditDateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRole_IdChanging(int value);
    partial void OnRole_IdChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    partial void OnDepotPermissionChanging(System.Nullable<bool> value);
    partial void OnDepotPermissionChanged();
    partial void OnBankPermissionChanging(System.Nullable<bool> value);
    partial void OnBankPermissionChanged();
    partial void OnPersonPermissionChanging(System.Nullable<bool> value);
    partial void OnPersonPermissionChanged();
    partial void OnFactorPermissionChanging(System.Nullable<bool> value);
    partial void OnFactorPermissionChanged();
    partial void OnSettingPermissionChanging(System.Nullable<bool> value);
    partial void OnSettingPermissionChanged();
    partial void OnUserPermissionChanging(System.Nullable<bool> value);
    partial void OnUserPermissionChanged();
    partial void OnLastEditDateTimeChanging(System.DateTime value);
    partial void OnLastEditDateTimeChanged();
    #endregion
		
		public Role()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Role_Id
		{
			get
			{
				return this._Role_Id;
			}
			set
			{
				if ((this._Role_Id != value))
				{
					this.OnRole_IdChanging(value);
					this.SendPropertyChanging();
					this._Role_Id = value;
					this.SendPropertyChanged("Role_Id");
					this.OnRole_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NVarChar(50)")]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this.OnRoleNameChanging(value);
					this.SendPropertyChanging();
					this._RoleName = value;
					this.SendPropertyChanged("RoleName");
					this.OnRoleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepotPermission", DbType="Bit")]
		public System.Nullable<bool> DepotPermission
		{
			get
			{
				return this._DepotPermission;
			}
			set
			{
				if ((this._DepotPermission != value))
				{
					this.OnDepotPermissionChanging(value);
					this.SendPropertyChanging();
					this._DepotPermission = value;
					this.SendPropertyChanged("DepotPermission");
					this.OnDepotPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankPermission", DbType="Bit")]
		public System.Nullable<bool> BankPermission
		{
			get
			{
				return this._BankPermission;
			}
			set
			{
				if ((this._BankPermission != value))
				{
					this.OnBankPermissionChanging(value);
					this.SendPropertyChanging();
					this._BankPermission = value;
					this.SendPropertyChanged("BankPermission");
					this.OnBankPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonPermission", DbType="Bit")]
		public System.Nullable<bool> PersonPermission
		{
			get
			{
				return this._PersonPermission;
			}
			set
			{
				if ((this._PersonPermission != value))
				{
					this.OnPersonPermissionChanging(value);
					this.SendPropertyChanging();
					this._PersonPermission = value;
					this.SendPropertyChanged("PersonPermission");
					this.OnPersonPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactorPermission", DbType="Bit")]
		public System.Nullable<bool> FactorPermission
		{
			get
			{
				return this._FactorPermission;
			}
			set
			{
				if ((this._FactorPermission != value))
				{
					this.OnFactorPermissionChanging(value);
					this.SendPropertyChanging();
					this._FactorPermission = value;
					this.SendPropertyChanged("FactorPermission");
					this.OnFactorPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SettingPermission", DbType="Bit")]
		public System.Nullable<bool> SettingPermission
		{
			get
			{
				return this._SettingPermission;
			}
			set
			{
				if ((this._SettingPermission != value))
				{
					this.OnSettingPermissionChanging(value);
					this.SendPropertyChanging();
					this._SettingPermission = value;
					this.SendPropertyChanged("SettingPermission");
					this.OnSettingPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPermission", DbType="Bit")]
		public System.Nullable<bool> UserPermission
		{
			get
			{
				return this._UserPermission;
			}
			set
			{
				if ((this._UserPermission != value))
				{
					this.OnUserPermissionChanging(value);
					this.SendPropertyChanging();
					this._UserPermission = value;
					this.SendPropertyChanged("UserPermission");
					this.OnUserPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastEditDateTime", DbType="DateTime NOT NULL")]
		public System.DateTime LastEditDateTime
		{
			get
			{
				return this._LastEditDateTime;
			}
			set
			{
				if ((this._LastEditDateTime != value))
				{
					this.OnLastEditDateTimeChanging(value);
					this.SendPropertyChanging();
					this._LastEditDateTime = value;
					this.SendPropertyChanged("LastEditDateTime");
					this.OnLastEditDateTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		private void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		private void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
