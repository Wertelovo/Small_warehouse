﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraidApp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB1")]
	public partial class AllClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertOrderProducts(OrderProducts instance);
    partial void UpdateOrderProducts(OrderProducts instance);
    partial void DeleteOrderProducts(OrderProducts instance);
    partial void InsertOrders(Orders instance);
    partial void UpdateOrders(Orders instance);
    partial void DeleteOrders(Orders instance);
    partial void InsertProducts(Products instance);
    partial void UpdateProducts(Products instance);
    partial void DeleteProducts(Products instance);
    partial void InsertRoles(Roles instance);
    partial void UpdateRoles(Roles instance);
    partial void DeleteRoles(Roles instance);
    partial void InsertUserRoles(UserRoles instance);
    partial void UpdateUserRoles(UserRoles instance);
    partial void DeleteUserRoles(UserRoles instance);
    partial void InsertUsers(Users instance);
    partial void UpdateUsers(Users instance);
    partial void DeleteUsers(Users instance);
    #endregion
		
		public AllClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AllClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AllClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AllClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<OrderProducts> OrderProducts
		{
			get
			{
				return this.GetTable<OrderProducts>();
			}
		}
		
		public System.Data.Linq.Table<Orders> Orders
		{
			get
			{
				return this.GetTable<Orders>();
			}
		}
		
		public System.Data.Linq.Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
		
		public System.Data.Linq.Table<Roles> Roles
		{
			get
			{
				return this.GetTable<Roles>();
			}
		}
		
		public System.Data.Linq.Table<UserRoles> UserRoles
		{
			get
			{
				return this.GetTable<UserRoles>();
			}
		}
		
		public System.Data.Linq.Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderProducts")]
	public partial class OrderProducts : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _OrderId;
		
		private int _ProductId;
		
		private int _Quantity;
		
		private EntityRef<Orders> _Orders;
		
		private EntityRef<Products> _Products;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
		
		public OrderProducts()
		{
			this._Orders = default(EntityRef<Orders>);
			this._Products = default(EntityRef<Products>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int NOT NULL")]
		public int OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Orders.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Products.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orders_OrderProducts", Storage="_Orders", ThisKey="OrderId", OtherKey="Id", IsForeignKey=true)]
		public Orders Orders
		{
			get
			{
				return this._Orders.Entity;
			}
			set
			{
				Orders previousValue = this._Orders.Entity;
				if (((previousValue != value) 
							|| (this._Orders.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Orders.Entity = null;
						previousValue.OrderProducts.Remove(this);
					}
					this._Orders.Entity = value;
					if ((value != null))
					{
						value.OrderProducts.Add(this);
						this._OrderId = value.Id;
					}
					else
					{
						this._OrderId = default(int);
					}
					this.SendPropertyChanged("Orders");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_OrderProducts", Storage="_Products", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public Products Products
		{
			get
			{
				return this._Products.Entity;
			}
			set
			{
				Products previousValue = this._Products.Entity;
				if (((previousValue != value) 
							|| (this._Products.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Products.Entity = null;
						previousValue.OrderProducts.Remove(this);
					}
					this._Products.Entity = value;
					if ((value != null))
					{
						value.OrderProducts.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("Products");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Orders : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CustomerName;
		
		private string _CustomerEmail;
		
		private string _ShopName;
		
		private string _Address;
		
		private System.DateTime _OrderDate;
		
		private decimal _TotalPrice;
		
		private System.DateTime _CreatedAt;
		
		private EntitySet<OrderProducts> _OrderProducts;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnCustomerEmailChanging(string value);
    partial void OnCustomerEmailChanged();
    partial void OnShopNameChanging(string value);
    partial void OnShopNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnOrderDateChanging(System.DateTime value);
    partial void OnOrderDateChanged();
    partial void OnTotalPriceChanging(decimal value);
    partial void OnTotalPriceChanged();
    partial void OnCreatedAtChanging(System.DateTime value);
    partial void OnCreatedAtChanged();
    #endregion
		
		public Orders()
		{
			this._OrderProducts = new EntitySet<OrderProducts>(new Action<OrderProducts>(this.attach_OrderProducts), new Action<OrderProducts>(this.detach_OrderProducts));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerEmail", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CustomerEmail
		{
			get
			{
				return this._CustomerEmail;
			}
			set
			{
				if ((this._CustomerEmail != value))
				{
					this.OnCustomerEmailChanging(value);
					this.SendPropertyChanging();
					this._CustomerEmail = value;
					this.SendPropertyChanged("CustomerEmail");
					this.OnCustomerEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShopName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ShopName
		{
			get
			{
				return this._ShopName;
			}
			set
			{
				if ((this._ShopName != value))
				{
					this.OnShopNameChanging(value);
					this.SendPropertyChanging();
					this._ShopName = value;
					this.SendPropertyChanged("ShopName");
					this.OnShopNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime NOT NULL")]
		public System.DateTime OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalPrice", DbType="Decimal(18,2) NOT NULL")]
		public decimal TotalPrice
		{
			get
			{
				return this._TotalPrice;
			}
			set
			{
				if ((this._TotalPrice != value))
				{
					this.OnTotalPriceChanging(value);
					this.SendPropertyChanging();
					this._TotalPrice = value;
					this.SendPropertyChanged("TotalPrice");
					this.OnTotalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedAt", DbType="DateTime2 NOT NULL")]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._CreatedAt;
			}
			set
			{
				if ((this._CreatedAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._CreatedAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orders_OrderProducts", Storage="_OrderProducts", ThisKey="Id", OtherKey="OrderId")]
		public EntitySet<OrderProducts> OrderProducts
		{
			get
			{
				return this._OrderProducts;
			}
			set
			{
				this._OrderProducts.Assign(value);
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
		
		private void attach_OrderProducts(OrderProducts entity)
		{
			this.SendPropertyChanging();
			entity.Orders = this;
		}
		
		private void detach_OrderProducts(OrderProducts entity)
		{
			this.SendPropertyChanging();
			entity.Orders = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private decimal _Price;
		
		private int _Quantity;
		
		private string _Description;
		
		private EntitySet<OrderProducts> _OrderProducts;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Products()
		{
			this._OrderProducts = new EntitySet<OrderProducts>(new Action<OrderProducts>(this.attach_OrderProducts), new Action<OrderProducts>(this.detach_OrderProducts));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,2) NOT NULL")]
		public decimal Price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(255)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_OrderProducts", Storage="_OrderProducts", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<OrderProducts> OrderProducts
		{
			get
			{
				return this._OrderProducts;
			}
			set
			{
				this._OrderProducts.Assign(value);
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
		
		private void attach_OrderProducts(OrderProducts entity)
		{
			this.SendPropertyChanging();
			entity.Products = this;
		}
		
		private void detach_OrderProducts(OrderProducts entity)
		{
			this.SendPropertyChanging();
			entity.Products = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Roles : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoleId;
		
		private string _RoleName;
		
		private EntitySet<UserRoles> _UserRoles;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    #endregion
		
		public Roles()
		{
			this._UserRoles = new EntitySet<UserRoles>(new Action<UserRoles>(this.attach_UserRoles), new Action<UserRoles>(this.detach_UserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Roles_UserRoles", Storage="_UserRoles", ThisKey="RoleId", OtherKey="RoleId")]
		public EntitySet<UserRoles> UserRoles
		{
			get
			{
				return this._UserRoles;
			}
			set
			{
				this._UserRoles.Assign(value);
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
		
		private void attach_UserRoles(UserRoles entity)
		{
			this.SendPropertyChanging();
			entity.Roles = this;
		}
		
		private void detach_UserRoles(UserRoles entity)
		{
			this.SendPropertyChanging();
			entity.Roles = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserRoles")]
	public partial class UserRoles : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserRoleId;
		
		private int _UserId;
		
		private int _RoleId;
		
		private EntityRef<Roles> _Roles;
		
		private EntityRef<Users> _Users;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserRoleIdChanging(int value);
    partial void OnUserRoleIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    #endregion
		
		public UserRoles()
		{
			this._Roles = default(EntityRef<Roles>);
			this._Users = default(EntityRef<Users>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserRoleId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserRoleId
		{
			get
			{
				return this._UserRoleId;
			}
			set
			{
				if ((this._UserRoleId != value))
				{
					this.OnUserRoleIdChanging(value);
					this.SendPropertyChanging();
					this._UserRoleId = value;
					this.SendPropertyChanged("UserRoleId");
					this.OnUserRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._Users.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int NOT NULL")]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Roles.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Roles_UserRoles", Storage="_Roles", ThisKey="RoleId", OtherKey="RoleId", IsForeignKey=true)]
		public Roles Roles
		{
			get
			{
				return this._Roles.Entity;
			}
			set
			{
				Roles previousValue = this._Roles.Entity;
				if (((previousValue != value) 
							|| (this._Roles.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Roles.Entity = null;
						previousValue.UserRoles.Remove(this);
					}
					this._Roles.Entity = value;
					if ((value != null))
					{
						value.UserRoles.Add(this);
						this._RoleId = value.RoleId;
					}
					else
					{
						this._RoleId = default(int);
					}
					this.SendPropertyChanged("Roles");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_UserRoles", Storage="_Users", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public Users Users
		{
			get
			{
				return this._Users.Entity;
			}
			set
			{
				Users previousValue = this._Users.Entity;
				if (((previousValue != value) 
							|| (this._Users.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Users.Entity = null;
						previousValue.UserRoles.Remove(this);
					}
					this._Users.Entity = value;
					if ((value != null))
					{
						value.UserRoles.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("Users");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserLogin;
		
		private string _UserPassword;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _ShopName;
		
		private string _Adress;
		
		private EntitySet<UserRoles> _UserRoles;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserLoginChanging(string value);
    partial void OnUserLoginChanged();
    partial void OnUserPasswordChanging(string value);
    partial void OnUserPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnShopNameChanging(string value);
    partial void OnShopNameChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    #endregion
		
		public Users()
		{
			this._UserRoles = new EntitySet<UserRoles>(new Action<UserRoles>(this.attach_UserRoles), new Action<UserRoles>(this.detach_UserRoles));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLogin", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserLogin
		{
			get
			{
				return this._UserLogin;
			}
			set
			{
				if ((this._UserLogin != value))
				{
					this.OnUserLoginChanging(value);
					this.SendPropertyChanging();
					this._UserLogin = value;
					this.SendPropertyChanged("UserLogin");
					this.OnUserLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserPassword
		{
			get
			{
				return this._UserPassword;
			}
			set
			{
				if ((this._UserPassword != value))
				{
					this.OnUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._UserPassword = value;
					this.SendPropertyChanged("UserPassword");
					this.OnUserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShopName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ShopName
		{
			get
			{
				return this._ShopName;
			}
			set
			{
				if ((this._ShopName != value))
				{
					this.OnShopNameChanging(value);
					this.SendPropertyChanging();
					this._ShopName = value;
					this.SendPropertyChanged("ShopName");
					this.OnShopNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_UserRoles", Storage="_UserRoles", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<UserRoles> UserRoles
		{
			get
			{
				return this._UserRoles;
			}
			set
			{
				this._UserRoles.Assign(value);
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
		
		private void attach_UserRoles(UserRoles entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void detach_UserRoles(UserRoles entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
	}
}
#pragma warning restore 1591
