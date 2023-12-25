﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectExam
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GestionEtudiantFiliere")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertetudiant(etudiant instance);
    partial void Updateetudiant(etudiant instance);
    partial void Deleteetudiant(etudiant instance);
    partial void Insertfiliere(filiere instance);
    partial void Updatefiliere(filiere instance);
    partial void Deletefiliere(filiere instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::projectExam.Properties.Settings.Default.GestionEtudiantFiliereConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<etudiant> etudiant
		{
			get
			{
				return this.GetTable<etudiant>();
			}
		}
		
		public System.Data.Linq.Table<filiere> filiere
		{
			get
			{
				return this.GetTable<filiere>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.etudiant")]
	public partial class etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CNE;
		
		private string _Nom;
		
		private string _Prénom;
		
		private string _Sexe;
		
		private System.Nullable<System.DateTime> _Date_Naissance;
		
		private string _Adresse;
		
		private System.Nullable<int> _Tele;
		
		private System.Nullable<int> _Id_filiere;
		
		private System.Nullable<int> _Id_Niveau;
		
		private string _email;
		
		private System.Data.Linq.Binary _image_profile;
		
		private EntityRef<filiere> _filiere;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCNEChanging(int value);
    partial void OnCNEChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrénomChanging(string value);
    partial void OnPrénomChanged();
    partial void OnSexeChanging(string value);
    partial void OnSexeChanged();
    partial void OnDate_NaissanceChanging(System.Nullable<System.DateTime> value);
    partial void OnDate_NaissanceChanged();
    partial void OnAdresseChanging(string value);
    partial void OnAdresseChanged();
    partial void OnTeleChanging(System.Nullable<int> value);
    partial void OnTeleChanged();
    partial void OnId_filiereChanging(System.Nullable<int> value);
    partial void OnId_filiereChanged();
    partial void OnId_NiveauChanging(System.Nullable<int> value);
    partial void OnId_NiveauChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onimage_profileChanging(System.Data.Linq.Binary value);
    partial void Onimage_profileChanged();
    #endregion
		
		public etudiant()
		{
			this._filiere = default(EntityRef<filiere>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CNE", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CNE
		{
			get
			{
				return this._CNE;
			}
			set
			{
				if ((this._CNE != value))
				{
					this.OnCNEChanging(value);
					this.SendPropertyChanging();
					this._CNE = value;
					this.SendPropertyChanged("CNE");
					this.OnCNEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="VarChar(20)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prénom", DbType="VarChar(20)")]
		public string Prénom
		{
			get
			{
				return this._Prénom;
			}
			set
			{
				if ((this._Prénom != value))
				{
					this.OnPrénomChanging(value);
					this.SendPropertyChanging();
					this._Prénom = value;
					this.SendPropertyChanged("Prénom");
					this.OnPrénomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexe", DbType="VarChar(20)")]
		public string Sexe
		{
			get
			{
				return this._Sexe;
			}
			set
			{
				if ((this._Sexe != value))
				{
					this.OnSexeChanging(value);
					this.SendPropertyChanging();
					this._Sexe = value;
					this.SendPropertyChanged("Sexe");
					this.OnSexeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Naissance", DbType="Date")]
		public System.Nullable<System.DateTime> Date_Naissance
		{
			get
			{
				return this._Date_Naissance;
			}
			set
			{
				if ((this._Date_Naissance != value))
				{
					this.OnDate_NaissanceChanging(value);
					this.SendPropertyChanging();
					this._Date_Naissance = value;
					this.SendPropertyChanged("Date_Naissance");
					this.OnDate_NaissanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adresse", DbType="VarChar(20)")]
		public string Adresse
		{
			get
			{
				return this._Adresse;
			}
			set
			{
				if ((this._Adresse != value))
				{
					this.OnAdresseChanging(value);
					this.SendPropertyChanging();
					this._Adresse = value;
					this.SendPropertyChanged("Adresse");
					this.OnAdresseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tele", DbType="Int")]
		public System.Nullable<int> Tele
		{
			get
			{
				return this._Tele;
			}
			set
			{
				if ((this._Tele != value))
				{
					this.OnTeleChanging(value);
					this.SendPropertyChanging();
					this._Tele = value;
					this.SendPropertyChanged("Tele");
					this.OnTeleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_filiere", DbType="Int")]
		public System.Nullable<int> Id_filiere
		{
			get
			{
				return this._Id_filiere;
			}
			set
			{
				if ((this._Id_filiere != value))
				{
					if (this._filiere.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_filiereChanging(value);
					this.SendPropertyChanging();
					this._Id_filiere = value;
					this.SendPropertyChanged("Id_filiere");
					this.OnId_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Niveau", DbType="Int")]
		public System.Nullable<int> Id_Niveau
		{
			get
			{
				return this._Id_Niveau;
			}
			set
			{
				if ((this._Id_Niveau != value))
				{
					this.OnId_NiveauChanging(value);
					this.SendPropertyChanging();
					this._Id_Niveau = value;
					this.SendPropertyChanged("Id_Niveau");
					this.OnId_NiveauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(100)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image_profile", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary image_profile
		{
			get
			{
				return this._image_profile;
			}
			set
			{
				if ((this._image_profile != value))
				{
					this.Onimage_profileChanging(value);
					this.SendPropertyChanging();
					this._image_profile = value;
					this.SendPropertyChanged("image_profile");
					this.Onimage_profileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="filiere_etudiant", Storage="_filiere", ThisKey="Id_filiere", OtherKey="Id_filiere", IsForeignKey=true)]
		public filiere filiere
		{
			get
			{
				return this._filiere.Entity;
			}
			set
			{
				filiere previousValue = this._filiere.Entity;
				if (((previousValue != value) 
							|| (this._filiere.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._filiere.Entity = null;
						previousValue.etudiant.Remove(this);
					}
					this._filiere.Entity = value;
					if ((value != null))
					{
						value.etudiant.Add(this);
						this._Id_filiere = value.Id_filiere;
					}
					else
					{
						this._Id_filiere = default(Nullable<int>);
					}
					this.SendPropertyChanged("filiere");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.filiere")]
	public partial class filiere : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_filiere;
		
		private string _Nom_filiere;
		
		private EntitySet<etudiant> _etudiant;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_filiereChanging(int value);
    partial void OnId_filiereChanged();
    partial void OnNom_filiereChanging(string value);
    partial void OnNom_filiereChanged();
    #endregion
		
		public filiere()
		{
			this._etudiant = new EntitySet<etudiant>(new Action<etudiant>(this.attach_etudiant), new Action<etudiant>(this.detach_etudiant));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_filiere", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_filiere
		{
			get
			{
				return this._Id_filiere;
			}
			set
			{
				if ((this._Id_filiere != value))
				{
					this.OnId_filiereChanging(value);
					this.SendPropertyChanging();
					this._Id_filiere = value;
					this.SendPropertyChanged("Id_filiere");
					this.OnId_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom_filiere", DbType="VarChar(50)")]
		public string Nom_filiere
		{
			get
			{
				return this._Nom_filiere;
			}
			set
			{
				if ((this._Nom_filiere != value))
				{
					this.OnNom_filiereChanging(value);
					this.SendPropertyChanging();
					this._Nom_filiere = value;
					this.SendPropertyChanged("Nom_filiere");
					this.OnNom_filiereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="filiere_etudiant", Storage="_etudiant", ThisKey="Id_filiere", OtherKey="Id_filiere")]
		public EntitySet<etudiant> etudiant
		{
			get
			{
				return this._etudiant;
			}
			set
			{
				this._etudiant.Assign(value);
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
		
		private void attach_etudiant(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.filiere = this;
		}
		
		private void detach_etudiant(etudiant entity)
		{
			this.SendPropertyChanging();
			entity.filiere = null;
		}
	}
}
#pragma warning restore 1591
