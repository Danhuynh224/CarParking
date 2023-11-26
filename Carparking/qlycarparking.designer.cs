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
	public partial class qlycarparkingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertParkingSpaceDb(ParkingSpaceDb instance);
    partial void UpdateParkingSpaceDb(ParkingSpaceDb instance);
    partial void DeleteParkingSpaceDb(ParkingSpaceDb instance);
    #endregion
		
		public qlycarparkingDataContext() : 
				base(global::Carparking.Properties.Settings.Default.UserDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public qlycarparkingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlycarparkingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlycarparkingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlycarparkingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ParkingSpaceDb> ParkingSpaceDbs
		{
			get
			{
				return this.GetTable<ParkingSpaceDb>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ParkingSpaceDb")]
	public partial class ParkingSpaceDb : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Status;
		
		private System.Nullable<double> _Price;
		
		private string _IDCar;
		
		private string _Area;
		
		private System.Nullable<int> _ParkedDays;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    partial void OnIDCarChanging(string value);
    partial void OnIDCarChanged();
    partial void OnAreaChanging(string value);
    partial void OnAreaChanged();
    partial void OnParkedDaysChanging(System.Nullable<int> value);
    partial void OnParkedDaysChanged();
    #endregion
		
		public ParkingSpaceDb()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NChar(10)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCar", DbType="NChar(10)")]
		public string IDCar
		{
			get
			{
				return this._IDCar;
			}
			set
			{
				if ((this._IDCar != value))
				{
					this.OnIDCarChanging(value);
					this.SendPropertyChanging();
					this._IDCar = value;
					this.SendPropertyChanged("IDCar");
					this.OnIDCarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="NChar(10)")]
		public string Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this.OnAreaChanging(value);
					this.SendPropertyChanging();
					this._Area = value;
					this.SendPropertyChanged("Area");
					this.OnAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParkedDays", DbType="Int")]
		public System.Nullable<int> ParkedDays
		{
			get
			{
				return this._ParkedDays;
			}
			set
			{
				if ((this._ParkedDays != value))
				{
					this.OnParkedDaysChanging(value);
					this.SendPropertyChanging();
					this._ParkedDays = value;
					this.SendPropertyChanged("ParkedDays");
					this.OnParkedDaysChanged();
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
