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

namespace Online_Food_Ordering
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="onlinefood")]
	public partial class OrderTrackDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTrending_item(Trending_item instance);
    partial void UpdateTrending_item(Trending_item instance);
    partial void DeleteTrending_item(Trending_item instance);
    #endregion
		
		public OrderTrackDataClassesDataContext() : 
				base(global::Online_Food_Ordering.Properties.Settings.Default.onlinefoodConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OrderTrackDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrderTrackDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrderTrackDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OrderTrackDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Trending_item> Trending_items
		{
			get
			{
				return this.GetTable<Trending_item>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Trending_item")]
	public partial class Trending_item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Vendor_name;
		
		private System.Nullable<int> _Review;
		
		private string _interest;
		
		private System.Nullable<int> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVendor_nameChanging(string value);
    partial void OnVendor_nameChanged();
    partial void OnReviewChanging(System.Nullable<int> value);
    partial void OnReviewChanged();
    partial void OninterestChanging(string value);
    partial void OninterestChanged();
    partial void OnordersChanging(System.Nullable<int> value);
    partial void OnordersChanged();
    #endregion
		
		public Trending_item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vendor_name", DbType="VarChar(50)")]
		public string Vendor_name
		{
			get
			{
				return this._Vendor_name;
			}
			set
			{
				if ((this._Vendor_name != value))
				{
					this.OnVendor_nameChanging(value);
					this.SendPropertyChanging();
					this._Vendor_name = value;
					this.SendPropertyChanged("Vendor_name");
					this.OnVendor_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Review", DbType="Int")]
		public System.Nullable<int> Review
		{
			get
			{
				return this._Review;
			}
			set
			{
				if ((this._Review != value))
				{
					this.OnReviewChanging(value);
					this.SendPropertyChanging();
					this._Review = value;
					this.SendPropertyChanged("Review");
					this.OnReviewChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_interest", DbType="VarChar(50)")]
		public string interest
		{
			get
			{
				return this._interest;
			}
			set
			{
				if ((this._interest != value))
				{
					this.OninterestChanging(value);
					this.SendPropertyChanging();
					this._interest = value;
					this.SendPropertyChanged("interest");
					this.OninterestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orders", DbType="Int")]
		public System.Nullable<int> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				if ((this._orders != value))
				{
					this.OnordersChanging(value);
					this.SendPropertyChanging();
					this._orders = value;
					this.SendPropertyChanged("orders");
					this.OnordersChanged();
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
