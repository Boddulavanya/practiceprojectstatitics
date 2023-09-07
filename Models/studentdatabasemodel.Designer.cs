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
namespace Display_Statistics_of_Marks_Obtained_by_Students.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SchoolEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SchoolEntities object using the connection string found in the 'SchoolEntities' section of the application configuration file.
        /// </summary>
        public SchoolEntities() : base("name=SchoolEntities", "SchoolEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SchoolEntities object.
        /// </summary>
        public SchoolEntities(string connectionString) : base(connectionString, "SchoolEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SchoolEntities object.
        /// </summary>
        public SchoolEntities(EntityConnection connection) : base(connection, "SchoolEntities")
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
        public ObjectSet<Class> Classes
        {
            get
            {
                if ((_Classes == null))
                {
                    _Classes = base.CreateObjectSet<Class>("Classes");
                }
                return _Classes;
            }
        }
        private ObjectSet<Class> _Classes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Class1> Classes1
        {
            get
            {
                if ((_Classes1 == null))
                {
                    _Classes1 = base.CreateObjectSet<Class1>("Classes1");
                }
                return _Classes1;
            }
        }
        private ObjectSet<Class1> _Classes1;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Subject> Subjects
        {
            get
            {
                if ((_Subjects == null))
                {
                    _Subjects = base.CreateObjectSet<Subject>("Subjects");
                }
                return _Subjects;
            }
        }
        private ObjectSet<Subject> _Subjects;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Classes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClasses(Class @class)
        {
            base.AddObject("Classes", @class);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Classes1 EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClasses1(Class1 class1)
        {
            base.AddObject("Classes1", class1);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Subjects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSubjects(Subject subject)
        {
            base.AddObject("Subjects", subject);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Class")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Class : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Class object.
        /// </summary>
        /// <param name="classId">Initial value of the ClassId property.</param>
        public static Class CreateClass(global::System.Int32 classId)
        {
            Class @class = new Class();
            @class.ClassId = classId;
            return @class;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassId
        {
            get
            {
                return _ClassId;
            }
            set
            {
                if (_ClassId != value)
                {
                    OnClassIdChanging(value);
                    ReportPropertyChanging("ClassId");
                    _ClassId = StructuralObject.SetValidValue(value, "ClassId");
                    ReportPropertyChanged("ClassId");
                    OnClassIdChanged();
                }
            }
        }
        private global::System.Int32 _ClassId;
        partial void OnClassIdChanging(global::System.Int32 value);
        partial void OnClassIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                OnClassNameChanging(value);
                ReportPropertyChanging("ClassName");
                _ClassName = StructuralObject.SetValidValue(value, true, "ClassName");
                ReportPropertyChanged("ClassName");
                OnClassNameChanged();
            }
        }
        private global::System.String _ClassName;
        partial void OnClassNameChanging(global::System.String value);
        partial void OnClassNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Cteacher
        {
            get
            {
                return _Cteacher;
            }
            set
            {
                OnCteacherChanging(value);
                ReportPropertyChanging("Cteacher");
                _Cteacher = StructuralObject.SetValidValue(value, true, "Cteacher");
                ReportPropertyChanged("Cteacher");
                OnCteacherChanged();
            }
        }
        private global::System.String _Cteacher;
        partial void OnCteacherChanging(global::System.String value);
        partial void OnCteacherChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Crank
        {
            get
            {
                return _Crank;
            }
            set
            {
                OnCrankChanging(value);
                ReportPropertyChanging("Crank");
                _Crank = StructuralObject.SetValidValue(value, "Crank");
                ReportPropertyChanged("Crank");
                OnCrankChanged();
            }
        }
        private Nullable<global::System.Int32> _Crank;
        partial void OnCrankChanging(Nullable<global::System.Int32> value);
        partial void OnCrankChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Class1")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Class1 : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Class1 object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Class1 CreateClass1(global::System.Int32 id, global::System.String name)
        {
            Class1 class1 = new Class1();
            class1.ID = id;
            class1.Name = name;
            return class1;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    OnNameChanging(value);
                    ReportPropertyChanging("Name");
                    _Name = StructuralObject.SetValidValue(value, false, "Name");
                    ReportPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        /// <param name="class">Initial value of the Class property.</param>
        public static Student CreateStudent(global::System.Int32 id, global::System.String name, global::System.String address, global::System.String email, global::System.String @class)
        {
            Student student = new Student();
            student.ID = id;
            student.Name = name;
            student.Address = address;
            student.Email = email;
            student.Class = @class;
            return student;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    OnNameChanging(value);
                    ReportPropertyChanging("Name");
                    _Name = StructuralObject.SetValidValue(value, false, "Name");
                    ReportPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                if (_Address != value)
                {
                    OnAddressChanging(value);
                    ReportPropertyChanging("Address");
                    _Address = StructuralObject.SetValidValue(value, false, "Address");
                    ReportPropertyChanged("Address");
                    OnAddressChanged();
                }
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (_Email != value)
                {
                    OnEmailChanging(value);
                    ReportPropertyChanging("Email");
                    _Email = StructuralObject.SetValidValue(value, false, "Email");
                    ReportPropertyChanged("Email");
                    OnEmailChanged();
                }
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Class
        {
            get
            {
                return _Class;
            }
            set
            {
                if (_Class != value)
                {
                    OnClassChanging(value);
                    ReportPropertyChanging("Class");
                    _Class = StructuralObject.SetValidValue(value, false, "Class");
                    ReportPropertyChanged("Class");
                    OnClassChanged();
                }
            }
        }
        private global::System.String _Class;
        partial void OnClassChanging(global::System.String value);
        partial void OnClassChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolModel", Name="Subject")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Subject : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Subject object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Subject CreateSubject(global::System.Int32 id, global::System.String name)
        {
            Subject subject = new Subject();
            subject.ID = id;
            subject.Name = name;
            return subject;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    OnNameChanging(value);
                    ReportPropertyChanging("Name");
                    _Name = StructuralObject.SetValidValue(value, false, "Name");
                    ReportPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    }

    #endregion

}
