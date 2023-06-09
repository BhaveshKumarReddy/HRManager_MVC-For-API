﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HRM_MVC.Models
{
    public partial class EmployeesList
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Name")]
        [StringLength(29, MinimumLength = 2, ErrorMessage = "Name must be at least 2 and maximum of 29 characters ")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Date Of Joining")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [Remote("IsDOJValid", "HrList", HttpMethod = "POST", ErrorMessage = "Date cannot be in the future!")]
        public DateTime? EmployeeDoj { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Role")]
        public string EmployeeRole { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Salary (CTC)")]
        [Range(0, 10000000, ErrorMessage = "Choose CTC below 1cr")]
        public decimal? EmployeeSalary { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Bonus Points")]
        [Range(0, 10000000, ErrorMessage = "Can't be negative")]
        public int? EmployeePoints { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Appraisal date")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [Remote("IsAppraisalDateValid", "HrList", HttpMethod = "POST", ErrorMessage = "Date cannot be in the past!")]
        public DateTime? EmployeeAppraisalDate { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Location")]
        public string LocationId { get; set; }

        public virtual LocationList Location { get; set; }
    }
}
