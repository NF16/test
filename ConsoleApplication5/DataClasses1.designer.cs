﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication5
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SPTradeDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertadmin(admin instance);
    partial void Updateadmin(admin instance);
    partial void Deleteadmin(admin instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ConsoleApplication5.Properties.Settings.Default.SPTradeDBConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<admin> admin
		{
			get
			{
				return this.GetTable<admin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin")]
	public partial class admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<System.DateTime> _date_prefix;
		
		private System.Nullable<int> _time_diff;
		
		private string _price_chart_url;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Ondate_prefixChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_prefixChanged();
    partial void Ontime_diffChanging(System.Nullable<int> value);
    partial void Ontime_diffChanged();
    partial void Onprice_chart_urlChanging(string value);
    partial void Onprice_chart_urlChanged();
    #endregion
		
		public admin()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_prefix", DbType="Date")]
		public System.Nullable<System.DateTime> date_prefix
		{
			get
			{
				return this._date_prefix;
			}
			set
			{
				if ((this._date_prefix != value))
				{
					this.Ondate_prefixChanging(value);
					this.SendPropertyChanging();
					this._date_prefix = value;
					this.SendPropertyChanged("date_prefix");
					this.Ondate_prefixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time_diff", DbType="Int")]
		public System.Nullable<int> time_diff
		{
			get
			{
				return this._time_diff;
			}
			set
			{
				if ((this._time_diff != value))
				{
					this.Ontime_diffChanging(value);
					this.SendPropertyChanging();
					this._time_diff = value;
					this.SendPropertyChanged("time_diff");
					this.Ontime_diffChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price_chart_url", DbType="VarChar(50)")]
		public string price_chart_url
		{
			get
			{
				return this._price_chart_url;
			}
			set
			{
				if ((this._price_chart_url != value))
				{
					this.Onprice_chart_urlChanging(value);
					this.SendPropertyChanging();
					this._price_chart_url = value;
					this.SendPropertyChanged("price_chart_url");
					this.Onprice_chart_urlChanged();
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
