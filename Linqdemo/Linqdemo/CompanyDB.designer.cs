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

namespace Linqdemo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CompanyDB")]
	public partial class CompanyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    #endregion
		
		public CompanyDBDataContext() : 
				base(global::Linqdemo.Properties.Settings.Default.CompanyDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Employee_Select")]
		public ISingleResult<Employee_SelectResult> Employee_Select([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Dname", DbType="VarChar(50)")] string dname)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dname);
			return ((ISingleResult<Employee_SelectResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Employee_Insert")]
		public int Employee_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ename", DbType="VarChar(50)")] string ename, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Job", DbType="VarChar(50)")] string job, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Money")] System.Nullable<decimal> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Dname", DbType="VarChar(50)")] string dname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Eno", DbType="Int")] ref System.Nullable<int> eno)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ename, job, salary, dname, eno);
			eno = ((System.Nullable<int>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Eno;
		
		private string _Ename;
		
		private string _Job;
		
		private System.Nullable<decimal> _Salary;
		
		private string _Dname;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEnoChanging(int value);
    partial void OnEnoChanged();
    partial void OnEnameChanging(string value);
    partial void OnEnameChanged();
    partial void OnJobChanging(string value);
    partial void OnJobChanged();
    partial void OnSalaryChanging(System.Nullable<decimal> value);
    partial void OnSalaryChanged();
    partial void OnDnameChanging(string value);
    partial void OnDnameChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Eno
		{
			get
			{
				return this._Eno;
			}
			set
			{
				if ((this._Eno != value))
				{
					this.OnEnoChanging(value);
					this.SendPropertyChanging();
					this._Eno = value;
					this.SendPropertyChanged("Eno");
					this.OnEnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(50)")]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this.OnEnameChanging(value);
					this.SendPropertyChanging();
					this._Ename = value;
					this.SendPropertyChanged("Ename");
					this.OnEnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job", DbType="VarChar(50)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this.OnJobChanging(value);
					this.SendPropertyChanging();
					this._Job = value;
					this.SendPropertyChanged("Job");
					this.OnJobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money")]
		public System.Nullable<decimal> Salary
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(50)")]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this.OnDnameChanging(value);
					this.SendPropertyChanging();
					this._Dname = value;
					this.SendPropertyChanged("Dname");
					this.OnDnameChanged();
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
	
	public partial class Employee_SelectResult
	{
		
		private int _Eno;
		
		private string _Ename;
		
		private string _Job;
		
		private System.Nullable<decimal> _Salary;
		
		private string _Dname;
		
		public Employee_SelectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eno", DbType="Int NOT NULL")]
		public int Eno
		{
			get
			{
				return this._Eno;
			}
			set
			{
				if ((this._Eno != value))
				{
					this._Eno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(50)")]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this._Ename = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job", DbType="VarChar(50)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this._Job = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(50)")]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this._Dname = value;
				}
			}
		}
	}
}
#pragma warning restore 1591