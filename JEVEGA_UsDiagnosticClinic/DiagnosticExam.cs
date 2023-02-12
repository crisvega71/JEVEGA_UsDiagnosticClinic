//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JEVEGA_UsDiagnosticClinic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DiagnosticExam
    {
        private JEVEGA_USEntities dbUSClinic = new JEVEGA_USEntities();
        public int Id { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "*")]
        public Nullable<short> ExamCategory { get; set; }

        [Display(Name = "Exam Name")]
        [Required(ErrorMessage = "*")]
        public string ExamName { get; set; }

        public string GetCategoryName
        {
            get
            {
                string category_desc = dbUSClinic.DiagnosticExamCategories.Find(ExamCategory).CategoryName;
                return category_desc;
            }
        }

        public string GetfullExamName
        {
            get { return GetCategoryName + " - " + ExamName; }
        }
    }
}
