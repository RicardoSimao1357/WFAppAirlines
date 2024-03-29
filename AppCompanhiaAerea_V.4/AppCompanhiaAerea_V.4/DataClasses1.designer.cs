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

namespace AppCompanhiaAerea_V._4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CompanhiaAerea")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertVoos(Voos instance);
    partial void UpdateVoos(Voos instance);
    partial void DeleteVoos(Voos instance);
    partial void InsertBilhetes(Bilhetes instance);
    partial void UpdateBilhetes(Bilhetes instance);
    partial void DeleteBilhetes(Bilhetes instance);
    partial void InsertAvioes(Avioes instance);
    partial void UpdateAvioes(Avioes instance);
    partial void DeleteAvioes(Avioes instance);
    partial void InsertAeroportos(Aeroportos instance);
    partial void UpdateAeroportos(Aeroportos instance);
    partial void DeleteAeroportos(Aeroportos instance);
    partial void InsertVendas(Vendas instance);
    partial void UpdateVendas(Vendas instance);
    partial void DeleteVendas(Vendas instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::AppCompanhiaAerea_V._4.Properties.Settings.Default.CompanhiaAereaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Voos> Voos
		{
			get
			{
				return this.GetTable<Voos>();
			}
		}
		
		public System.Data.Linq.Table<Bilhetes> Bilhetes
		{
			get
			{
				return this.GetTable<Bilhetes>();
			}
		}
		
		public System.Data.Linq.Table<Avioes> Avioes
		{
			get
			{
				return this.GetTable<Avioes>();
			}
		}
		
		public System.Data.Linq.Table<Aeroportos> Aeroportos
		{
			get
			{
				return this.GetTable<Aeroportos>();
			}
		}
		
		public System.Data.Linq.Table<Vendas> Vendas
		{
			get
			{
				return this.GetTable<Vendas>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Voos")]
	public partial class Voos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idVoo;
		
		private System.Nullable<int> _idAeroporto;
		
		private int _idAviao;
		
		private int _destino;
		
		private string _dataVoo;
		
		private string _horaVoo;
		
		private EntitySet<Bilhetes> _Bilhetes;
		
		private EntityRef<Avioes> _Avioes;
		
		private EntityRef<Aeroportos> _Aeroporto;
		
		private EntityRef<Aeroportos> _Aeroportos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidVooChanging(int value);
    partial void OnidVooChanged();
    partial void OnidAeroportoChanging(System.Nullable<int> value);
    partial void OnidAeroportoChanged();
    partial void OnidAviaoChanging(int value);
    partial void OnidAviaoChanged();
    partial void OndestinoChanging(int value);
    partial void OndestinoChanged();
    partial void OndataVooChanging(string value);
    partial void OndataVooChanged();
    partial void OnhoraVooChanging(string value);
    partial void OnhoraVooChanged();
    #endregion
		
		public Voos()
		{
			this._Bilhetes = new EntitySet<Bilhetes>(new Action<Bilhetes>(this.attach_Bilhetes), new Action<Bilhetes>(this.detach_Bilhetes));
			this._Avioes = default(EntityRef<Avioes>);
			this._Aeroporto = default(EntityRef<Aeroportos>);
			this._Aeroportos = default(EntityRef<Aeroportos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVoo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idVoo
		{
			get
			{
				return this._idVoo;
			}
			set
			{
				if ((this._idVoo != value))
				{
					this.OnidVooChanging(value);
					this.SendPropertyChanging();
					this._idVoo = value;
					this.SendPropertyChanged("idVoo");
					this.OnidVooChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAeroporto", DbType="Int")]
		public System.Nullable<int> idAeroporto
		{
			get
			{
				return this._idAeroporto;
			}
			set
			{
				if ((this._idAeroporto != value))
				{
					if (this._Aeroporto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAeroportoChanging(value);
					this.SendPropertyChanging();
					this._idAeroporto = value;
					this.SendPropertyChanged("idAeroporto");
					this.OnidAeroportoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAviao", DbType="Int NOT NULL")]
		public int idAviao
		{
			get
			{
				return this._idAviao;
			}
			set
			{
				if ((this._idAviao != value))
				{
					if (this._Avioes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAviaoChanging(value);
					this.SendPropertyChanging();
					this._idAviao = value;
					this.SendPropertyChanged("idAviao");
					this.OnidAviaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destino", DbType="Int NOT NULL")]
		public int destino
		{
			get
			{
				return this._destino;
			}
			set
			{
				if ((this._destino != value))
				{
					if (this._Aeroportos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndestinoChanging(value);
					this.SendPropertyChanging();
					this._destino = value;
					this.SendPropertyChanged("destino");
					this.OndestinoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dataVoo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string dataVoo
		{
			get
			{
				return this._dataVoo;
			}
			set
			{
				if ((this._dataVoo != value))
				{
					this.OndataVooChanging(value);
					this.SendPropertyChanging();
					this._dataVoo = value;
					this.SendPropertyChanged("dataVoo");
					this.OndataVooChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_horaVoo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string horaVoo
		{
			get
			{
				return this._horaVoo;
			}
			set
			{
				if ((this._horaVoo != value))
				{
					this.OnhoraVooChanging(value);
					this.SendPropertyChanging();
					this._horaVoo = value;
					this.SendPropertyChanged("horaVoo");
					this.OnhoraVooChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Voos_Bilhetes", Storage="_Bilhetes", ThisKey="idVoo", OtherKey="idVoo")]
		public EntitySet<Bilhetes> Bilhetes
		{
			get
			{
				return this._Bilhetes;
			}
			set
			{
				this._Bilhetes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Avioes_Voos", Storage="_Avioes", ThisKey="idAviao", OtherKey="idAviao", IsForeignKey=true)]
		public Avioes Avioes
		{
			get
			{
				return this._Avioes.Entity;
			}
			set
			{
				Avioes previousValue = this._Avioes.Entity;
				if (((previousValue != value) 
							|| (this._Avioes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Avioes.Entity = null;
						previousValue.Voos.Remove(this);
					}
					this._Avioes.Entity = value;
					if ((value != null))
					{
						value.Voos.Add(this);
						this._idAviao = value.idAviao;
					}
					else
					{
						this._idAviao = default(int);
					}
					this.SendPropertyChanged("Avioes");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Aeroportos_Voos", Storage="_Aeroporto", ThisKey="idAeroporto", OtherKey="idAeroporto", IsForeignKey=true)]
		public Aeroportos Aeroporto
		{
			get
			{
				return this._Aeroporto.Entity;
			}
			set
			{
				Aeroportos previousValue = this._Aeroporto.Entity;
				if (((previousValue != value) 
							|| (this._Aeroporto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Aeroporto.Entity = null;
						previousValue.Voos.Remove(this);
					}
					this._Aeroporto.Entity = value;
					if ((value != null))
					{
						value.Voos.Add(this);
						this._idAeroporto = value.idAeroporto;
					}
					else
					{
						this._idAeroporto = default(Nullable<int>);
					}
					this.SendPropertyChanged("Aeroporto");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Aeroportos_Voos1", Storage="_Aeroportos", ThisKey="destino", OtherKey="idAeroporto", IsForeignKey=true)]
		public Aeroportos Aeroportos
		{
			get
			{
				return this._Aeroportos.Entity;
			}
			set
			{
				Aeroportos previousValue = this._Aeroportos.Entity;
				if (((previousValue != value) 
							|| (this._Aeroportos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Aeroportos.Entity = null;
						previousValue.Voos1.Remove(this);
					}
					this._Aeroportos.Entity = value;
					if ((value != null))
					{
						value.Voos1.Add(this);
						this._destino = value.idAeroporto;
					}
					else
					{
						this._destino = default(int);
					}
					this.SendPropertyChanged("Aeroportos");
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
		
		private void attach_Bilhetes(Bilhetes entity)
		{
			this.SendPropertyChanging();
			entity.Voos = this;
		}
		
		private void detach_Bilhetes(Bilhetes entity)
		{
			this.SendPropertyChanging();
			entity.Voos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bilhetes")]
	public partial class Bilhetes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idBilhete;
		
		private int _idVoo;
		
		private int _lugaresEconomicosOcupados;
		
		private int _lugaresExecutivosOcupados;
		
		private int _lugaresPrimeiraClasseOcupados;
		
		private EntitySet<Vendas> _Vendas;
		
		private EntityRef<Voos> _Voos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidBilheteChanging(int value);
    partial void OnidBilheteChanged();
    partial void OnidVooChanging(int value);
    partial void OnidVooChanged();
    partial void OnlugaresEconomicosOcupadosChanging(int value);
    partial void OnlugaresEconomicosOcupadosChanged();
    partial void OnlugaresExecutivosOcupadosChanging(int value);
    partial void OnlugaresExecutivosOcupadosChanged();
    partial void OnlugaresPrimeiraClasseOcupadosChanging(int value);
    partial void OnlugaresPrimeiraClasseOcupadosChanged();
    #endregion
		
		public Bilhetes()
		{
			this._Vendas = new EntitySet<Vendas>(new Action<Vendas>(this.attach_Vendas), new Action<Vendas>(this.detach_Vendas));
			this._Voos = default(EntityRef<Voos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idBilhete", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idBilhete
		{
			get
			{
				return this._idBilhete;
			}
			set
			{
				if ((this._idBilhete != value))
				{
					this.OnidBilheteChanging(value);
					this.SendPropertyChanging();
					this._idBilhete = value;
					this.SendPropertyChanged("idBilhete");
					this.OnidBilheteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVoo", DbType="Int NOT NULL")]
		public int idVoo
		{
			get
			{
				return this._idVoo;
			}
			set
			{
				if ((this._idVoo != value))
				{
					if (this._Voos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidVooChanging(value);
					this.SendPropertyChanging();
					this._idVoo = value;
					this.SendPropertyChanged("idVoo");
					this.OnidVooChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugaresEconomicosOcupados", DbType="Int NOT NULL")]
		public int lugaresEconomicosOcupados
		{
			get
			{
				return this._lugaresEconomicosOcupados;
			}
			set
			{
				if ((this._lugaresEconomicosOcupados != value))
				{
					this.OnlugaresEconomicosOcupadosChanging(value);
					this.SendPropertyChanging();
					this._lugaresEconomicosOcupados = value;
					this.SendPropertyChanged("lugaresEconomicosOcupados");
					this.OnlugaresEconomicosOcupadosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugaresExecutivosOcupados", DbType="Int NOT NULL")]
		public int lugaresExecutivosOcupados
		{
			get
			{
				return this._lugaresExecutivosOcupados;
			}
			set
			{
				if ((this._lugaresExecutivosOcupados != value))
				{
					this.OnlugaresExecutivosOcupadosChanging(value);
					this.SendPropertyChanging();
					this._lugaresExecutivosOcupados = value;
					this.SendPropertyChanged("lugaresExecutivosOcupados");
					this.OnlugaresExecutivosOcupadosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugaresPrimeiraClasseOcupados", DbType="Int NOT NULL")]
		public int lugaresPrimeiraClasseOcupados
		{
			get
			{
				return this._lugaresPrimeiraClasseOcupados;
			}
			set
			{
				if ((this._lugaresPrimeiraClasseOcupados != value))
				{
					this.OnlugaresPrimeiraClasseOcupadosChanging(value);
					this.SendPropertyChanging();
					this._lugaresPrimeiraClasseOcupados = value;
					this.SendPropertyChanged("lugaresPrimeiraClasseOcupados");
					this.OnlugaresPrimeiraClasseOcupadosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bilhetes_Venda", Storage="_Vendas", ThisKey="idBilhete", OtherKey="idBilhete")]
		public EntitySet<Vendas> Vendas
		{
			get
			{
				return this._Vendas;
			}
			set
			{
				this._Vendas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Voos_Bilhetes", Storage="_Voos", ThisKey="idVoo", OtherKey="idVoo", IsForeignKey=true)]
		public Voos Voos
		{
			get
			{
				return this._Voos.Entity;
			}
			set
			{
				Voos previousValue = this._Voos.Entity;
				if (((previousValue != value) 
							|| (this._Voos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Voos.Entity = null;
						previousValue.Bilhetes.Remove(this);
					}
					this._Voos.Entity = value;
					if ((value != null))
					{
						value.Bilhetes.Add(this);
						this._idVoo = value.idVoo;
					}
					else
					{
						this._idVoo = default(int);
					}
					this.SendPropertyChanged("Voos");
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
		
		private void attach_Vendas(Vendas entity)
		{
			this.SendPropertyChanging();
			entity.Bilhetes = this;
		}
		
		private void detach_Vendas(Vendas entity)
		{
			this.SendPropertyChanging();
			entity.Bilhetes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Avioes")]
	public partial class Avioes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAviao;
		
		private string _nome;
		
		private string _matricula;
		
		private int _lugaresEconomicos;
		
		private int _lugaresExecutivos;
		
		private int _lugaresPrimeiraClasse;
		
		private EntitySet<Voos> _Voos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAviaoChanging(int value);
    partial void OnidAviaoChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnmatriculaChanging(string value);
    partial void OnmatriculaChanged();
    partial void OnlugaresEconomicosChanging(int value);
    partial void OnlugaresEconomicosChanged();
    partial void OnlugaresExecutivosChanging(int value);
    partial void OnlugaresExecutivosChanged();
    partial void OnlugaresPrimeiraClasseChanging(int value);
    partial void OnlugaresPrimeiraClasseChanged();
    #endregion
		
		public Avioes()
		{
			this._Voos = new EntitySet<Voos>(new Action<Voos>(this.attach_Voos), new Action<Voos>(this.detach_Voos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAviao", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAviao
		{
			get
			{
				return this._idAviao;
			}
			set
			{
				if ((this._idAviao != value))
				{
					this.OnidAviaoChanging(value);
					this.SendPropertyChanging();
					this._idAviao = value;
					this.SendPropertyChanged("idAviao");
					this.OnidAviaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matricula", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string matricula
		{
			get
			{
				return this._matricula;
			}
			set
			{
				if ((this._matricula != value))
				{
					this.OnmatriculaChanging(value);
					this.SendPropertyChanging();
					this._matricula = value;
					this.SendPropertyChanged("matricula");
					this.OnmatriculaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugaresEconomicos", DbType="Int NOT NULL")]
		public int lugaresEconomicos
		{
			get
			{
				return this._lugaresEconomicos;
			}
			set
			{
				if ((this._lugaresEconomicos != value))
				{
					this.OnlugaresEconomicosChanging(value);
					this.SendPropertyChanging();
					this._lugaresEconomicos = value;
					this.SendPropertyChanged("lugaresEconomicos");
					this.OnlugaresEconomicosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugaresExecutivos", DbType="Int NOT NULL")]
		public int lugaresExecutivos
		{
			get
			{
				return this._lugaresExecutivos;
			}
			set
			{
				if ((this._lugaresExecutivos != value))
				{
					this.OnlugaresExecutivosChanging(value);
					this.SendPropertyChanging();
					this._lugaresExecutivos = value;
					this.SendPropertyChanged("lugaresExecutivos");
					this.OnlugaresExecutivosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugaresPrimeiraClasse", DbType="Int NOT NULL")]
		public int lugaresPrimeiraClasse
		{
			get
			{
				return this._lugaresPrimeiraClasse;
			}
			set
			{
				if ((this._lugaresPrimeiraClasse != value))
				{
					this.OnlugaresPrimeiraClasseChanging(value);
					this.SendPropertyChanging();
					this._lugaresPrimeiraClasse = value;
					this.SendPropertyChanged("lugaresPrimeiraClasse");
					this.OnlugaresPrimeiraClasseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Avioes_Voos", Storage="_Voos", ThisKey="idAviao", OtherKey="idAviao")]
		public EntitySet<Voos> Voos
		{
			get
			{
				return this._Voos;
			}
			set
			{
				this._Voos.Assign(value);
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
		
		private void attach_Voos(Voos entity)
		{
			this.SendPropertyChanging();
			entity.Avioes = this;
		}
		
		private void detach_Voos(Voos entity)
		{
			this.SendPropertyChanging();
			entity.Avioes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Aeroportos")]
	public partial class Aeroportos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAeroporto;
		
		private string _nome;
		
		private string _localidade;
		
		private EntitySet<Voos> _Voos;
		
		private EntitySet<Voos> _Voos1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAeroportoChanging(int value);
    partial void OnidAeroportoChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnlocalidadeChanging(string value);
    partial void OnlocalidadeChanged();
    #endregion
		
		public Aeroportos()
		{
			this._Voos = new EntitySet<Voos>(new Action<Voos>(this.attach_Voos), new Action<Voos>(this.detach_Voos));
			this._Voos1 = new EntitySet<Voos>(new Action<Voos>(this.attach_Voos1), new Action<Voos>(this.detach_Voos1));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAeroporto", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAeroporto
		{
			get
			{
				return this._idAeroporto;
			}
			set
			{
				if ((this._idAeroporto != value))
				{
					this.OnidAeroportoChanging(value);
					this.SendPropertyChanging();
					this._idAeroporto = value;
					this.SendPropertyChanged("idAeroporto");
					this.OnidAeroportoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_localidade", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string localidade
		{
			get
			{
				return this._localidade;
			}
			set
			{
				if ((this._localidade != value))
				{
					this.OnlocalidadeChanging(value);
					this.SendPropertyChanging();
					this._localidade = value;
					this.SendPropertyChanged("localidade");
					this.OnlocalidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Aeroportos_Voos", Storage="_Voos", ThisKey="idAeroporto", OtherKey="idAeroporto")]
		public EntitySet<Voos> Voos
		{
			get
			{
				return this._Voos;
			}
			set
			{
				this._Voos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Aeroportos_Voos1", Storage="_Voos1", ThisKey="idAeroporto", OtherKey="destino")]
		public EntitySet<Voos> Voos1
		{
			get
			{
				return this._Voos1;
			}
			set
			{
				this._Voos1.Assign(value);
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
		
		private void attach_Voos(Voos entity)
		{
			this.SendPropertyChanging();
			entity.Aeroporto = this;
		}
		
		private void detach_Voos(Voos entity)
		{
			this.SendPropertyChanging();
			entity.Aeroporto = null;
		}
		
		private void attach_Voos1(Voos entity)
		{
			this.SendPropertyChanging();
			entity.Aeroportos = this;
		}
		
		private void detach_Voos1(Voos entity)
		{
			this.SendPropertyChanging();
			entity.Aeroportos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Vendas")]
	public partial class Vendas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idVenda;
		
		private string _Nome;
		
		private System.Nullable<int> _Nif;
		
		private int _idBilhete;
		
		private string _lugar;
		
		private string _Categoria;
		
		private string _Email;
		
		private EntityRef<Bilhetes> _Bilhetes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidVendaChanging(int value);
    partial void OnidVendaChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnNifChanging(System.Nullable<int> value);
    partial void OnNifChanged();
    partial void OnidBilheteChanging(int value);
    partial void OnidBilheteChanged();
    partial void OnlugarChanging(string value);
    partial void OnlugarChanged();
    partial void OnCategoriaChanging(string value);
    partial void OnCategoriaChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Vendas()
		{
			this._Bilhetes = default(EntityRef<Bilhetes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idVenda", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idVenda
		{
			get
			{
				return this._idVenda;
			}
			set
			{
				if ((this._idVenda != value))
				{
					this.OnidVendaChanging(value);
					this.SendPropertyChanging();
					this._idVenda = value;
					this.SendPropertyChanged("idVenda");
					this.OnidVendaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50)")]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nif", DbType="Int")]
		public System.Nullable<int> Nif
		{
			get
			{
				return this._Nif;
			}
			set
			{
				if ((this._Nif != value))
				{
					this.OnNifChanging(value);
					this.SendPropertyChanging();
					this._Nif = value;
					this.SendPropertyChanged("Nif");
					this.OnNifChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idBilhete", DbType="Int NOT NULL")]
		public int idBilhete
		{
			get
			{
				return this._idBilhete;
			}
			set
			{
				if ((this._idBilhete != value))
				{
					if (this._Bilhetes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidBilheteChanging(value);
					this.SendPropertyChanging();
					this._idBilhete = value;
					this.SendPropertyChanged("idBilhete");
					this.OnidBilheteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugar", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lugar
		{
			get
			{
				return this._lugar;
			}
			set
			{
				if ((this._lugar != value))
				{
					this.OnlugarChanging(value);
					this.SendPropertyChanging();
					this._lugar = value;
					this.SendPropertyChanged("lugar");
					this.OnlugarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categoria", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Categoria
		{
			get
			{
				return this._Categoria;
			}
			set
			{
				if ((this._Categoria != value))
				{
					this.OnCategoriaChanging(value);
					this.SendPropertyChanging();
					this._Categoria = value;
					this.SendPropertyChanged("Categoria");
					this.OnCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bilhetes_Venda", Storage="_Bilhetes", ThisKey="idBilhete", OtherKey="idBilhete", IsForeignKey=true)]
		public Bilhetes Bilhetes
		{
			get
			{
				return this._Bilhetes.Entity;
			}
			set
			{
				Bilhetes previousValue = this._Bilhetes.Entity;
				if (((previousValue != value) 
							|| (this._Bilhetes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bilhetes.Entity = null;
						previousValue.Vendas.Remove(this);
					}
					this._Bilhetes.Entity = value;
					if ((value != null))
					{
						value.Vendas.Add(this);
						this._idBilhete = value.idBilhete;
					}
					else
					{
						this._idBilhete = default(int);
					}
					this.SendPropertyChanged("Bilhetes");
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
