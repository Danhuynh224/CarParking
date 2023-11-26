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

namespace Carparking
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UserData")]
	public partial class qlyattendantDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAttendantDb(AttendantDb instance);
    partial void UpdateAttendantDb(AttendantDb instance);
    partial void DeleteAttendantDb(AttendantDb instance);
    #endregion
		
		public qlyattendantDataContext() : 
				base(global::Carparking.Properties.Settings.Default.UserDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public qlyattendantDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlyattendantDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlyattendantDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlyattendantDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AttendantDb> AttendantDbs
		{
			get
			{
				return this.GetTable<AttendantDb>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AttendantDb")]
	public partial class AttendantDb : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Fullname;
		
		private string _Phone;
		
		private System.Nullable<System.DateTime> _Birthday;
		
		private string _AreaPark;
		
		private System.Nullable<int> _WorkingDay;
		
		private System.Nullable<double> _Salary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnBirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthdayChanged();
    partial void OnAreaParkChanging(string value);
    partial void OnAreaParkChanged();
    partial void OnWorkingDayChanging(System.Nullable<int> value);
    partial void OnWorkingDayChanged();
    partial void OnSalaryChanging(System.Nullable<double> value);
    partial void OnSalaryChanged();
    #endregion
		
		public AttendantDb()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(50)")]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="DateTime")]
		public System.Nullable<System.DateTime> Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AreaPark", DbType="NVarChar(50)")]
		public string AreaPark
		{
			get
			{
				return this._AreaPark;
			}
			set
			{
				if ((this._AreaPark != value))
				{
					this.OnAreaParkChanging(value);
					this.SendPropertyChanging();
					this._AreaPark = value;
					this.SendPropertyChanged("AreaPark");
					this.OnAreaParkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkingDay", DbType="Int")]
		public System.Nullable<int> WorkingDay
		{
			get
			{
				return this._WorkingDay;
			}
			set
			{
				if ((this._WorkingDay != value))
				{
					this.OnWorkingDayChanging(value);
					this.SendPropertyChanging();
					this._WorkingDay = value;
					this.SendPropertyChanged("WorkingDay");
					this.OnWorkingDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Float")]
		public System.Nullable<double> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
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