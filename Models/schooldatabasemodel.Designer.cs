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
    public partial class SCHOOLDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SCHOOLDBEntities object using the connection string found in the 'SCHOOLDBEntities' section of the application configuration file.
        /// </summary>
        public SCHOOLDBEntities() : base("name=SCHOOLDBEntities", "SCHOOLDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SCHOOLDBEntities object.
        /// </summary>
        public SCHOOLDBEntities(string connectionString) : base(connectionString, "SCHOOLDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SCHOOLDBEntities object.
        /// </summary>
        public SCHOOLDBEntities(EntityConnection connection) : base(connection, "SCHOOLDBEntities")
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
    [EdmEntityTypeAttribute(NamespaceName="SCHOOLDBModel", Name="Class")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Class : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Class object.
        /// </summary>
        /// <param name="classID">Initial value of the ClassID property.</param>
        public static Class CreateClass(global::System.Int32 classID)
        {
            Class @class = new Class();
            @class.ClassID = classID;
            return @class;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassID
        {
            get
            {
                return _ClassID;
            }
            set
            {
                if (_ClassID != value)
                {
                    OnClassIDChanging(value);
                    ReportPropertyChanging("ClassID");
                    _ClassID = StructuralObject.SetValidValue(value, "ClassID");
                    ReportPropertyChanged("ClassID");
                    OnClassIDChanged();
                }
            }
        }
        private global::System.Int32 _ClassID;
        partial void OnClassIDChanging(global::System.Int32 value);
        partial void OnClassIDChanged();
    
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

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SCHOOLDBModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="studentID">Initial value of the StudentID property.</param>
        public static Student CreateStudent(global::System.Int32 studentID)
        {
            Student student = new Student();
            student.StudentID = studentID;
            return student;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                if (_StudentID != value)
                {
                    OnStudentIDChanging(value);
                    ReportPropertyChanging("StudentID");
                    _StudentID = StructuralObject.SetValidValue(value, "StudentID");
                    ReportPropertyChanged("StudentID");
                    OnStudentIDChanged();
                }
            }
        }
        private global::System.Int32 _StudentID;
        partial void OnStudentIDChanging(global::System.Int32 value);
        partial void OnStudentIDChanged();
    
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
                _FirstName = StructuralObject.SetValidValue(value, true, "FirstName");
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
                _LastName = StructuralObject.SetValidValue(value, true, "LastName");
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                OnDateOfBirthChanging(value);
                ReportPropertyChanging("DateOfBirth");
                _DateOfBirth = StructuralObject.SetValidValue(value, "DateOfBirth");
                ReportPropertyChanged("DateOfBirth");
                OnDateOfBirthChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateOfBirth;
        partial void OnDateOfBirthChanging(Nullable<global::System.DateTime> value);
        partial void OnDateOfBirthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ClassID
        {
            get
            {
                return _ClassID;
            }
            set
            {
                OnClassIDChanging(value);
                ReportPropertyChanging("ClassID");
                _ClassID = StructuralObject.SetValidValue(value, "ClassID");
                ReportPropertyChanged("ClassID");
                OnClassIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ClassID;
        partial void OnClassIDChanging(Nullable<global::System.Int32> value);
        partial void OnClassIDChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SCHOOLDBModel", Name="Subject")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Subject : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Subject object.
        /// </summary>
        /// <param name="subjectID">Initial value of the SubjectID property.</param>
        public static Subject CreateSubject(global::System.Int32 subjectID)
        {
            Subject subject = new Subject();
            subject.SubjectID = subjectID;
            return subject;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SubjectID
        {
            get
            {
                return _SubjectID;
            }
            set
            {
                if (_SubjectID != value)
                {
                    OnSubjectIDChanging(value);
                    ReportPropertyChanging("SubjectID");
                    _SubjectID = StructuralObject.SetValidValue(value, "SubjectID");
                    ReportPropertyChanged("SubjectID");
                    OnSubjectIDChanged();
                }
            }
        }
        private global::System.Int32 _SubjectID;
        partial void OnSubjectIDChanging(global::System.Int32 value);
        partial void OnSubjectIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SubjectName
        {
            get
            {
                return _SubjectName;
            }
            set
            {
                OnSubjectNameChanging(value);
                ReportPropertyChanging("SubjectName");
                _SubjectName = StructuralObject.SetValidValue(value, true, "SubjectName");
                ReportPropertyChanged("SubjectName");
                OnSubjectNameChanged();
            }
        }
        private global::System.String _SubjectName;
        partial void OnSubjectNameChanging(global::System.String value);
        partial void OnSubjectNameChanged();

        #endregion

    }

    #endregion

}
