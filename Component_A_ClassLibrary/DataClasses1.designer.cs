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

namespace Component_A_ClassLibrary
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ea3996r")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertrole(role instance);
    partial void Updaterole(role instance);
    partial void Deleterole(role instance);
    partial void Insertdepartment(department instance);
    partial void Updatedepartment(department instance);
    partial void Deletedepartment(department instance);
    partial void Insertemployee(employee instance);
    partial void Updateemployee(employee instance);
    partial void Deleteemployee(employee instance);
    partial void Insertholiday(holiday instance);
    partial void Updateholiday(holiday instance);
    partial void Deleteholiday(holiday instance);
    partial void Insertconstraint(constraint instance);
    partial void Updateconstraint(constraint instance);
    partial void Deleteconstraint(constraint instance);
    partial void Insertpeaktime(peaktime instance);
    partial void Updatepeaktime(peaktime instance);
    partial void Deletepeaktime(peaktime instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Component_A_ClassLibrary.Properties.Settings.Default.ea3996rConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<role> roles
		{
			get
			{
				return this.GetTable<role>();
			}
		}
		
		public System.Data.Linq.Table<department> departments
		{
			get
			{
				return this.GetTable<department>();
			}
		}
		
		public System.Data.Linq.Table<employee> employees
		{
			get
			{
				return this.GetTable<employee>();
			}
		}
		
		public System.Data.Linq.Table<holiday> holidays
		{
			get
			{
				return this.GetTable<holiday>();
			}
		}
		
		public System.Data.Linq.Table<constraint> constraints
		{
			get
			{
				return this.GetTable<constraint>();
			}
		}
		
		public System.Data.Linq.Table<peaktime> peaktimes
		{
			get
			{
				return this.GetTable<peaktime>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.role")]
	public partial class role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _RoleID;
		
		private System.Nullable<long> _EmployeeID;
		
		private System.Nullable<long> _DepartmentID;
		
		private string _RoleType;
		
		private EntityRef<department> _department;
		
		private EntityRef<employee> _employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleIDChanging(long value);
    partial void OnRoleIDChanged();
    partial void OnEmployeeIDChanging(System.Nullable<long> value);
    partial void OnEmployeeIDChanged();
    partial void OnDepartmentIDChanging(System.Nullable<long> value);
    partial void OnDepartmentIDChanged();
    partial void OnRoleTypeChanging(string value);
    partial void OnRoleTypeChanged();
    #endregion
		
		public role()
		{
			this._department = default(EntityRef<department>);
			this._employee = default(EntityRef<employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="BigInt")]
		public System.Nullable<long> EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					if (this._employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", DbType="BigInt")]
		public System.Nullable<long> DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					if (this._department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartmentIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmentID = value;
					this.SendPropertyChanged("DepartmentID");
					this.OnDepartmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleType", DbType="VarChar(50)")]
		public string RoleType
		{
			get
			{
				return this._RoleType;
			}
			set
			{
				if ((this._RoleType != value))
				{
					this.OnRoleTypeChanging(value);
					this.SendPropertyChanging();
					this._RoleType = value;
					this.SendPropertyChanged("RoleType");
					this.OnRoleTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="department_role", Storage="_department", ThisKey="DepartmentID", OtherKey="DepartmentID", IsForeignKey=true, DeleteRule="CASCADE")]
		public department department
		{
			get
			{
				return this._department.Entity;
			}
			set
			{
				department previousValue = this._department.Entity;
				if (((previousValue != value) 
							|| (this._department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._department.Entity = null;
						previousValue.roles.Remove(this);
					}
					this._department.Entity = value;
					if ((value != null))
					{
						value.roles.Add(this);
						this._DepartmentID = value.DepartmentID;
					}
					else
					{
						this._DepartmentID = default(Nullable<long>);
					}
					this.SendPropertyChanged("department");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employee_role", Storage="_employee", ThisKey="EmployeeID", OtherKey="EmployeeID", IsForeignKey=true, DeleteRule="CASCADE")]
		public employee employee
		{
			get
			{
				return this._employee.Entity;
			}
			set
			{
				employee previousValue = this._employee.Entity;
				if (((previousValue != value) 
							|| (this._employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._employee.Entity = null;
						previousValue.roles.Remove(this);
					}
					this._employee.Entity = value;
					if ((value != null))
					{
						value.roles.Add(this);
						this._EmployeeID = value.EmployeeID;
					}
					else
					{
						this._EmployeeID = default(Nullable<long>);
					}
					this.SendPropertyChanged("employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.department")]
	public partial class department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _DepartmentID;
		
		private string _DeptName;
		
		private EntitySet<role> _roles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepartmentIDChanging(long value);
    partial void OnDepartmentIDChanged();
    partial void OnDeptNameChanging(string value);
    partial void OnDeptNameChanged();
    #endregion
		
		public department()
		{
			this._roles = new EntitySet<role>(new Action<role>(this.attach_roles), new Action<role>(this.detach_roles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this.OnDepartmentIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmentID = value;
					this.SendPropertyChanged("DepartmentID");
					this.OnDepartmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DeptName
		{
			get
			{
				return this._DeptName;
			}
			set
			{
				if ((this._DeptName != value))
				{
					this.OnDeptNameChanging(value);
					this.SendPropertyChanging();
					this._DeptName = value;
					this.SendPropertyChanged("DeptName");
					this.OnDeptNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="department_role", Storage="_roles", ThisKey="DepartmentID", OtherKey="DepartmentID")]
		public EntitySet<role> roles
		{
			get
			{
				return this._roles;
			}
			set
			{
				this._roles.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_roles(role entity)
		{
			this.SendPropertyChanging();
			entity.department = this;
		}
		
		private void detach_roles(role entity)
		{
			this.SendPropertyChanging();
			entity.department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employee")]
	public partial class employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _EmployeeID;
		
		private long _StaffID;
		
		private string _Password;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Address;
		
		private string _Telephone;
		
		private string _EmailAddress;
		
		private System.DateTime _DateJoined;
		
		private EntitySet<role> _roles;
		
		private EntitySet<holiday> _holidays;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(long value);
    partial void OnEmployeeIDChanged();
    partial void OnStaffIDChanging(long value);
    partial void OnStaffIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnTelephoneChanging(string value);
    partial void OnTelephoneChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnDateJoinedChanging(System.DateTime value);
    partial void OnDateJoinedChanged();
    #endregion
		
		public employee()
		{
			this._roles = new EntitySet<role>(new Action<role>(this.attach_roles), new Action<role>(this.detach_roles));
			this._holidays = new EntitySet<holiday>(new Action<holiday>(this.attach_holidays), new Action<holiday>(this.detach_holidays));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffID", DbType="BigInt NOT NULL")]
		public long StaffID
		{
			get
			{
				return this._StaffID;
			}
			set
			{
				if ((this._StaffID != value))
				{
					this.OnStaffIDChanging(value);
					this.SendPropertyChanging();
					this._StaffID = value;
					this.SendPropertyChanged("StaffID");
					this.OnStaffIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="Char(11) NOT NULL", CanBeNull=false)]
		public string Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this.OnTelephoneChanging(value);
					this.SendPropertyChanging();
					this._Telephone = value;
					this.SendPropertyChanged("Telephone");
					this.OnTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateJoined", DbType="Date NOT NULL")]
		public System.DateTime DateJoined
		{
			get
			{
				return this._DateJoined;
			}
			set
			{
				if ((this._DateJoined != value))
				{
					this.OnDateJoinedChanging(value);
					this.SendPropertyChanging();
					this._DateJoined = value;
					this.SendPropertyChanged("DateJoined");
					this.OnDateJoinedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employee_role", Storage="_roles", ThisKey="EmployeeID", OtherKey="EmployeeID")]
		public EntitySet<role> roles
		{
			get
			{
				return this._roles;
			}
			set
			{
				this._roles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employee_holiday", Storage="_holidays", ThisKey="EmployeeID", OtherKey="EmployeeID")]
		public EntitySet<holiday> holidays
		{
			get
			{
				return this._holidays;
			}
			set
			{
				this._holidays.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_roles(role entity)
		{
			this.SendPropertyChanging();
			entity.employee = this;
		}
		
		private void detach_roles(role entity)
		{
			this.SendPropertyChanging();
			entity.employee = null;
		}
		
		private void attach_holidays(holiday entity)
		{
			this.SendPropertyChanging();
			entity.employee = this;
		}
		
		private void detach_holidays(holiday entity)
		{
			this.SendPropertyChanging();
			entity.employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.holidays")]
	public partial class holiday : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _HolidayID;
		
		private long _EmployeeID;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
		private string _Status;
		
		private EntityRef<employee> _employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHolidayIDChanging(long value);
    partial void OnHolidayIDChanged();
    partial void OnEmployeeIDChanging(long value);
    partial void OnEmployeeIDChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
		
		public holiday()
		{
			this._employee = default(EntityRef<employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HolidayID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long HolidayID
		{
			get
			{
				return this._HolidayID;
			}
			set
			{
				if ((this._HolidayID != value))
				{
					this.OnHolidayIDChanging(value);
					this.SendPropertyChanging();
					this._HolidayID = value;
					this.SendPropertyChanged("HolidayID");
					this.OnHolidayIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="BigInt NOT NULL")]
		public long EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					if (this._employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="Date NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="Date NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="employee_holiday", Storage="_employee", ThisKey="EmployeeID", OtherKey="EmployeeID", IsForeignKey=true)]
		public employee employee
		{
			get
			{
				return this._employee.Entity;
			}
			set
			{
				employee previousValue = this._employee.Entity;
				if (((previousValue != value) 
							|| (this._employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._employee.Entity = null;
						previousValue.holidays.Remove(this);
					}
					this._employee.Entity = value;
					if ((value != null))
					{
						value.holidays.Add(this);
						this._EmployeeID = value.EmployeeID;
					}
					else
					{
						this._EmployeeID = default(long);
					}
					this.SendPropertyChanged("employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.constraints")]
	public partial class constraint : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ConstraintID;
		
		private System.Nullable<bool> _HeadOrDeputy;
		
		private System.Nullable<bool> _ManagerOrSenior;
		
		private System.Nullable<int> _HolidayEntitlement;
		
		private System.Nullable<int> _MustBeOnDuty;
		
		private System.Nullable<int> _MustBeOnDutyRelaxed;
		
		private string _RelaxedMonth;
		
		private System.Nullable<System.DateTime> _ExceptionStartDate;
		
		private System.Nullable<System.DateTime> _ExceptionEndDate;
		
		private string _AvailableDepartments;
		
		private string _AvailableRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnConstraintIDChanging(long value);
    partial void OnConstraintIDChanged();
    partial void OnHeadOrDeputyChanging(System.Nullable<bool> value);
    partial void OnHeadOrDeputyChanged();
    partial void OnManagerOrSeniorChanging(System.Nullable<bool> value);
    partial void OnManagerOrSeniorChanged();
    partial void OnHolidayEntitlementChanging(System.Nullable<int> value);
    partial void OnHolidayEntitlementChanged();
    partial void OnMustBeOnDutyChanging(System.Nullable<int> value);
    partial void OnMustBeOnDutyChanged();
    partial void OnMustBeOnDutyRelaxedChanging(System.Nullable<int> value);
    partial void OnMustBeOnDutyRelaxedChanged();
    partial void OnRelaxedMonthChanging(string value);
    partial void OnRelaxedMonthChanged();
    partial void OnExceptionStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnExceptionStartDateChanged();
    partial void OnExceptionEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnExceptionEndDateChanged();
    partial void OnAvailableDepartmentsChanging(string value);
    partial void OnAvailableDepartmentsChanged();
    partial void OnAvailableRolesChanging(string value);
    partial void OnAvailableRolesChanged();
    #endregion
		
		public constraint()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConstraintID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ConstraintID
		{
			get
			{
				return this._ConstraintID;
			}
			set
			{
				if ((this._ConstraintID != value))
				{
					this.OnConstraintIDChanging(value);
					this.SendPropertyChanging();
					this._ConstraintID = value;
					this.SendPropertyChanged("ConstraintID");
					this.OnConstraintIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeadOrDeputy", DbType="Bit")]
		public System.Nullable<bool> HeadOrDeputy
		{
			get
			{
				return this._HeadOrDeputy;
			}
			set
			{
				if ((this._HeadOrDeputy != value))
				{
					this.OnHeadOrDeputyChanging(value);
					this.SendPropertyChanging();
					this._HeadOrDeputy = value;
					this.SendPropertyChanged("HeadOrDeputy");
					this.OnHeadOrDeputyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ManagerOrSenior", DbType="Bit")]
		public System.Nullable<bool> ManagerOrSenior
		{
			get
			{
				return this._ManagerOrSenior;
			}
			set
			{
				if ((this._ManagerOrSenior != value))
				{
					this.OnManagerOrSeniorChanging(value);
					this.SendPropertyChanging();
					this._ManagerOrSenior = value;
					this.SendPropertyChanged("ManagerOrSenior");
					this.OnManagerOrSeniorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HolidayEntitlement", DbType="Int")]
		public System.Nullable<int> HolidayEntitlement
		{
			get
			{
				return this._HolidayEntitlement;
			}
			set
			{
				if ((this._HolidayEntitlement != value))
				{
					this.OnHolidayEntitlementChanging(value);
					this.SendPropertyChanging();
					this._HolidayEntitlement = value;
					this.SendPropertyChanged("HolidayEntitlement");
					this.OnHolidayEntitlementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MustBeOnDuty", DbType="Int")]
		public System.Nullable<int> MustBeOnDuty
		{
			get
			{
				return this._MustBeOnDuty;
			}
			set
			{
				if ((this._MustBeOnDuty != value))
				{
					this.OnMustBeOnDutyChanging(value);
					this.SendPropertyChanging();
					this._MustBeOnDuty = value;
					this.SendPropertyChanged("MustBeOnDuty");
					this.OnMustBeOnDutyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MustBeOnDutyRelaxed", DbType="Int")]
		public System.Nullable<int> MustBeOnDutyRelaxed
		{
			get
			{
				return this._MustBeOnDutyRelaxed;
			}
			set
			{
				if ((this._MustBeOnDutyRelaxed != value))
				{
					this.OnMustBeOnDutyRelaxedChanging(value);
					this.SendPropertyChanging();
					this._MustBeOnDutyRelaxed = value;
					this.SendPropertyChanged("MustBeOnDutyRelaxed");
					this.OnMustBeOnDutyRelaxedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelaxedMonth", DbType="VarChar(50)")]
		public string RelaxedMonth
		{
			get
			{
				return this._RelaxedMonth;
			}
			set
			{
				if ((this._RelaxedMonth != value))
				{
					this.OnRelaxedMonthChanging(value);
					this.SendPropertyChanging();
					this._RelaxedMonth = value;
					this.SendPropertyChanged("RelaxedMonth");
					this.OnRelaxedMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExceptionStartDate", DbType="Date")]
		public System.Nullable<System.DateTime> ExceptionStartDate
		{
			get
			{
				return this._ExceptionStartDate;
			}
			set
			{
				if ((this._ExceptionStartDate != value))
				{
					this.OnExceptionStartDateChanging(value);
					this.SendPropertyChanging();
					this._ExceptionStartDate = value;
					this.SendPropertyChanged("ExceptionStartDate");
					this.OnExceptionStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExceptionEndDate", DbType="Date")]
		public System.Nullable<System.DateTime> ExceptionEndDate
		{
			get
			{
				return this._ExceptionEndDate;
			}
			set
			{
				if ((this._ExceptionEndDate != value))
				{
					this.OnExceptionEndDateChanging(value);
					this.SendPropertyChanging();
					this._ExceptionEndDate = value;
					this.SendPropertyChanged("ExceptionEndDate");
					this.OnExceptionEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AvailableDepartments", DbType="VarChar(MAX)")]
		public string AvailableDepartments
		{
			get
			{
				return this._AvailableDepartments;
			}
			set
			{
				if ((this._AvailableDepartments != value))
				{
					this.OnAvailableDepartmentsChanging(value);
					this.SendPropertyChanging();
					this._AvailableDepartments = value;
					this.SendPropertyChanged("AvailableDepartments");
					this.OnAvailableDepartmentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AvailableRoles", DbType="VarChar(MAX)")]
		public string AvailableRoles
		{
			get
			{
				return this._AvailableRoles;
			}
			set
			{
				if ((this._AvailableRoles != value))
				{
					this.OnAvailableRolesChanging(value);
					this.SendPropertyChanging();
					this._AvailableRoles = value;
					this.SendPropertyChanged("AvailableRoles");
					this.OnAvailableRolesChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.peaktimes")]
	public partial class peaktime : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _PeaktimesID;
		
		private string _PeaktimesName;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPeaktimesIDChanging(long value);
    partial void OnPeaktimesIDChanged();
    partial void OnPeaktimesNameChanging(string value);
    partial void OnPeaktimesNameChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    #endregion
		
		public peaktime()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PeaktimesID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long PeaktimesID
		{
			get
			{
				return this._PeaktimesID;
			}
			set
			{
				if ((this._PeaktimesID != value))
				{
					this.OnPeaktimesIDChanging(value);
					this.SendPropertyChanging();
					this._PeaktimesID = value;
					this.SendPropertyChanged("PeaktimesID");
					this.OnPeaktimesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PeaktimesName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PeaktimesName
		{
			get
			{
				return this._PeaktimesName;
			}
			set
			{
				if ((this._PeaktimesName != value))
				{
					this.OnPeaktimesNameChanging(value);
					this.SendPropertyChanging();
					this._PeaktimesName = value;
					this.SendPropertyChanged("PeaktimesName");
					this.OnPeaktimesNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="Date NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="Date NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
