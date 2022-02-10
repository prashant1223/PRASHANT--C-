//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeDetails.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int Employeeid { get; set; }
        public string EmpCode { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DOB { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public string PreviousExperience { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Adresss { get; set; }
        public Nullable<int> Departmentid { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
