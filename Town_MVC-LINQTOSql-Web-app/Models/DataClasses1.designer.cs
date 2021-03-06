#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Town_MVC_LINQTOSql_Web_app.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CityDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertResident(Resident instance);
    partial void UpdateResident(Resident instance);
    partial void DeleteResident(Resident instance);
    partial void InsertSchool(School instance);
    partial void UpdateSchool(School instance);
    partial void DeleteSchool(School instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CityDBConnectionString"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Resident> Residents
		{
			get
			{
				return this.GetTable<Resident>();
			}
		}
		
		public System.Data.Linq.Table<School> Schools
		{
			get
			{
				return this.GetTable<School>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Residents")]
	public partial class Resident : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _First_name;
		
		private string _Last_name;
		
		private System.Nullable<System.DateTime> _Born;
		
		private string _Address;
		
		private System.Nullable<int> _Seniority;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirst_nameChanging(string value);
    partial void OnFirst_nameChanged();
    partial void OnLast_nameChanging(string value);
    partial void OnLast_nameChanged();
    partial void OnBornChanging(System.Nullable<System.DateTime> value);
    partial void OnBornChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnSeniorityChanging(System.Nullable<int> value);
    partial void OnSeniorityChanged();
    #endregion
		
		public Resident()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First-name]", Storage="_First_name", DbType="VarChar(50)")]
		public string First_name
		{
			get
			{
				return this._First_name;
			}
			set
			{
				if ((this._First_name != value))
				{
					this.OnFirst_nameChanging(value);
					this.SendPropertyChanging();
					this._First_name = value;
					this.SendPropertyChanged("First_name");
					this.OnFirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last-name]", Storage="_Last_name", DbType="VarChar(50)")]
		public string Last_name
		{
			get
			{
				return this._Last_name;
			}
			set
			{
				if ((this._Last_name != value))
				{
					this.OnLast_nameChanging(value);
					this.SendPropertyChanging();
					this._Last_name = value;
					this.SendPropertyChanged("Last_name");
					this.OnLast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Born", DbType="DateTime")]
		public System.Nullable<System.DateTime> Born
		{
			get
			{
				return this._Born;
			}
			set
			{
				if ((this._Born != value))
				{
					this.OnBornChanging(value);
					this.SendPropertyChanging();
					this._Born = value;
					this.SendPropertyChanged("Born");
					this.OnBornChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seniority", DbType="Int")]
		public System.Nullable<int> Seniority
		{
			get
			{
				return this._Seniority;
			}
			set
			{
				if ((this._Seniority != value))
				{
					this.OnSeniorityChanging(value);
					this.SendPropertyChanging();
					this._Seniority = value;
					this.SendPropertyChanged("Seniority");
					this.OnSeniorityChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.School")]
	public partial class School : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Street;
		
		private System.Nullable<bool> _Public;
		
		private System.Nullable<int> _Number_Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnPublicChanging(System.Nullable<bool> value);
    partial void OnPublicChanged();
    partial void OnNumber_StudentChanging(System.Nullable<int> value);
    partial void OnNumber_StudentChanged();
    #endregion
		
		public School()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="VarChar(50)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Public]", Storage="_Public", DbType="Bit")]
		public System.Nullable<bool> Public
		{
			get
			{
				return this._Public;
			}
			set
			{
				if ((this._Public != value))
				{
					this.OnPublicChanging(value);
					this.SendPropertyChanging();
					this._Public = value;
					this.SendPropertyChanged("Public");
					this.OnPublicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number_Student", DbType="Int")]
		public System.Nullable<int> Number_Student
		{
			get
			{
				return this._Number_Student;
			}
			set
			{
				if ((this._Number_Student != value))
				{
					this.OnNumber_StudentChanging(value);
					this.SendPropertyChanging();
					this._Number_Student = value;
					this.SendPropertyChanged("Number_Student");
					this.OnNumber_StudentChanged();
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
