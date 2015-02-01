﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DatabaseModel", "FK_Department_Director", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Lecture02.Employee), "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Lecture02.Department), true)]
[assembly: EdmRelationshipAttribute("DatabaseModel", "FK_Employee_Department", "Department", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Lecture02.Department), "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Lecture02.Employee), true)]
[assembly: EdmRelationshipAttribute("DatabaseModel", "EmployeeProject", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Lecture02.Employee), "Project", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Lecture02.Project))]

#endregion

namespace Lecture02
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseEntities object using the connection string found in the 'DatabaseEntities' section of the application configuration file.
        /// </summary>
        public DatabaseEntities() : base("name=DatabaseEntities", "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(string connectionString) : base(connectionString, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(EntityConnection connection) : base(connection, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Department> Department
        {
            get
            {
                if ((_Department == null))
                {
                    _Department = base.CreateObjectSet<Department>("Department");
                }
                return _Department;
            }
        }
        private ObjectSet<Department> _Department;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employee
        {
            get
            {
                if ((_Employee == null))
                {
                    _Employee = base.CreateObjectSet<Employee>("Employee");
                }
                return _Employee;
            }
        }
        private ObjectSet<Employee> _Employee;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Project> Project
        {
            get
            {
                if ((_Project == null))
                {
                    _Project = base.CreateObjectSet<Project>("Project");
                }
                return _Project;
            }
        }
        private ObjectSet<Project> _Project;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Department EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartment(Department department)
        {
            base.AddObject("Department", department);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employee EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployee(Employee employee)
        {
            base.AddObject("Employee", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Project EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProject(Project project)
        {
            base.AddObject("Project", project);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="directorId">Initial value of the DirectorId property.</param>
        public static Department CreateDepartment(global::System.Int32 id, global::System.Int32 directorId)
        {
            Department department = new Department();
            department.Id = id;
            department.DirectorId = directorId;
            return department;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DirectorId
        {
            get
            {
                return _DirectorId;
            }
            set
            {
                OnDirectorIdChanging(value);
                ReportPropertyChanging("DirectorId");
                _DirectorId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DirectorId");
                OnDirectorIdChanged();
            }
        }
        private global::System.Int32 _DirectorId;
        partial void OnDirectorIdChanging(global::System.Int32 value);
        partial void OnDirectorIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_Department_Director", "Employee")]
        public Employee Director
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("DatabaseModel.FK_Department_Director", "Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("DatabaseModel.FK_Department_Director", "Employee").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> DirectorReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("DatabaseModel.FK_Department_Director", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("DatabaseModel.FK_Department_Director", "Employee", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_Employee_Department", "Employee")]
        public EntityCollection<Employee> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("DatabaseModel.FK_Employee_Department", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("DatabaseModel.FK_Employee_Department", "Employee", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="salary">Initial value of the Salary property.</param>
        public static Employee CreateEmployee(global::System.Int32 id, global::System.Decimal salary)
        {
            Employee employee = new Employee();
            employee.Id = id;
            employee.Salary = salary;
            return employee;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private global::System.Decimal _Salary;
        partial void OnSalaryChanging(global::System.Decimal value);
        partial void OnSalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> DepartmentId
        {
            get
            {
                return _DepartmentId;
            }
            set
            {
                OnDepartmentIdChanging(value);
                ReportPropertyChanging("DepartmentId");
                _DepartmentId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DepartmentId");
                OnDepartmentIdChanged();
            }
        }
        private Nullable<global::System.Int32> _DepartmentId;
        partial void OnDepartmentIdChanging(Nullable<global::System.Int32> value);
        partial void OnDepartmentIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_Employee_Department", "Department")]
        public Department Department
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("DatabaseModel.FK_Employee_Department", "Department").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("DatabaseModel.FK_Employee_Department", "Department").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> DepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("DatabaseModel.FK_Employee_Department", "Department");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("DatabaseModel.FK_Employee_Department", "Department", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "EmployeeProject", "Project")]
        public EntityCollection<Project> Projects
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Project>("DatabaseModel.EmployeeProject", "Project");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Project>("DatabaseModel.EmployeeProject", "Project", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Project")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Project : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Project object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="dueDate">Initial value of the DueDate property.</param>
        public static Project CreateProject(global::System.Int32 id, global::System.DateTime dueDate)
        {
            Project project = new Project();
            project.Id = id;
            project.DueDate = dueDate;
            return project;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DueDate
        {
            get
            {
                return _DueDate;
            }
            set
            {
                OnDueDateChanging(value);
                ReportPropertyChanging("DueDate");
                _DueDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DueDate");
                OnDueDateChanged();
            }
        }
        private global::System.DateTime _DueDate;
        partial void OnDueDateChanging(global::System.DateTime value);
        partial void OnDueDateChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "EmployeeProject", "Employee")]
        public EntityCollection<Employee> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Employee>("DatabaseModel.EmployeeProject", "Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Employee>("DatabaseModel.EmployeeProject", "Employee", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
