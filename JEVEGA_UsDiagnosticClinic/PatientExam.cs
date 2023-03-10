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

    public partial class PatientExam
    {
        private JEVEGA_USEntities dbUSClinic = new JEVEGA_USEntities();
        public int Id { get; set; }

        [Display(Name = "Patient")]
        [Required(ErrorMessage = "*")]
        public string PatientID { get; set; }

        [Display(Name = "Exam Type")]
        [Required(ErrorMessage = "*")]
        public Nullable<short> ExamType { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> ExamDate { get; set; }

        [Display(Name = "Sonographer")]
        [Required(ErrorMessage = "*")]
        public Nullable<short> Sonographer { get; set; }

        [Display(Name = "Radiologist")]
        [Required(ErrorMessage = "*")]
        public Nullable<short> Radiologist { get; set; }

        [Display(Name = "Medical Report")]
        public string ExamReport { get; set; }

        [Display(Name = "Signed")]
        public string SignByDoctor { get; set; }

        [Display(Name = "Date Signed")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateSigned { get; set; }

        public Nullable<bool> Image1 { get; set; }
        public Nullable<bool> Image2 { get; set; }
        public Nullable<bool> Image3 { get; set; }
        public Nullable<bool> Image4 { get; set; }
        public Nullable<bool> Image5 { get; set; }
        public Nullable<bool> Image6 { get; set; }
        public Nullable<bool> Image7 { get; set; }
        public Nullable<bool> Image8 { get; set; }
        public Nullable<bool> Image9 { get; set; }
        public Nullable<bool> Image10 { get; set; }

        public Nullable<bool> Image11 { get; set; }
        public Nullable<bool> Image12 { get; set; }
        public Nullable<bool> Image13 { get; set; }
        public Nullable<bool> Image14 { get; set; }
        public Nullable<bool> Image15 { get; set; }
        public Nullable<bool> Image16 { get; set; }
        public Nullable<bool> Image17 { get; set; }
        public Nullable<bool> Image18 { get; set; }
        public Nullable<bool> Image19 { get; set; }
        public Nullable<bool> Image20 { get; set; }

        public Nullable<bool> Image21 { get; set; }
        public Nullable<bool> Image22 { get; set; }
        public Nullable<bool> Image23 { get; set; }
        public Nullable<bool> Image24 { get; set; }
        public Nullable<bool> Image25 { get; set; }
        public Nullable<bool> Image26 { get; set; }
        public Nullable<bool> Image27 { get; set; }
        public Nullable<bool> Image28 { get; set; }
        public Nullable<bool> Image29 { get; set; }
        public Nullable<bool> Image30 { get; set; }
        public Nullable<bool> Image31 { get; set; }
        public Nullable<bool> Image32 { get; set; }


        [Display(Name = "History")]
        public string History { get; set; }

        [Display(Name = "Exam ID")]
        [Required(ErrorMessage = "*")]
        public string ExamId { get; set; }

        public string getPatientIdName
        {
            get
            {
                string lastName = dbUSClinic.PatientDatas.Find(PatientID).Lastname.ToString();
                string firstName = dbUSClinic.PatientDatas.Find(PatientID).Firstname.ToString();
                string patiendIdName = PatientID + " - " + lastName + ", " + firstName;
                return patiendIdName;
            }
        } //**

        public string getPatientName
        {
            get
            {
                string lastName = dbUSClinic.PatientDatas.Find(PatientID).Lastname.ToString();
                string firstName = dbUSClinic.PatientDatas.Find(PatientID).Firstname.ToString();
                return lastName + ", " + firstName;
            }
        } //**

        public string getPatientEmail
        {
            get
            {
                string email = dbUSClinic.PatientDatas.Find(PatientID).Email.ToString();
                return email;
            }
        }


        public string getDoctorName
        {
            get
            {
                string lastName = dbUSClinic.RadiologistDoctors.Find(Radiologist).LastName.ToString();
                string firstName = dbUSClinic.RadiologistDoctors.Find(Radiologist).FirstName.ToString();
                return lastName + ", " + firstName;
            }
        }

        public string getRadDoctorEmail
        {
            get
            {
                string rad_doctor_email = dbUSClinic.RadiologistDoctors.Find(Radiologist).Email.ToString();
                return rad_doctor_email;
            }
        }

        public string getDoctorFistLastName
        {
            get
            {
                string lastName = dbUSClinic.RadiologistDoctors.Find(Radiologist).LastName.ToString();
                string firstName = dbUSClinic.RadiologistDoctors.Find(Radiologist).FirstName.ToString();
                return firstName + " " + lastName;
            }
        }

        public string getDoctorPostTitle
        {
            get
            {
                string postTitle = dbUSClinic.RadiologistDoctors.Find(Radiologist).PostTitle.ToString();
                return postTitle;
            }
        }

        public string getDoctorPRCLicenseNo
        {
            get
            {
                string prcLicenseNo = dbUSClinic.RadiologistDoctors.Find(Radiologist).PrcLicenseNo.ToString();
                return prcLicenseNo;
            }
        }

        public string getSonographerName
        {
            get
            {
                string lastName = dbUSClinic.Sonographers.Find(Radiologist).LastName.ToString();
                string firstName = dbUSClinic.Sonographers.Find(Radiologist).FirstName.ToString();
                return lastName + ", " + firstName;
            }
        }

        public string getExamName
        {
            get
            {
                string examtype_name = dbUSClinic.DiagnosticExams.Find(ExamType).GetfullExamName;
                return examtype_name;
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime? formattedExamDate
        {
            get { return ExamDate; }
        }

        public string getSignDefinition
        {
            get
            {
                return (SignByDoctor == "Y" ? "Yes" : "No");
            }
        }

        public bool ExamImagesExist()
        {
            bool exist = false;

            if (Image1 == true || Image2 == true || Image3 == true || Image4 == true || Image5 == true || Image6 == true || Image7 == true || Image8 == true || Image9 == true || Image10 == true
                || Image11 == true || Image12 == true || Image13 == true || Image14 == true || Image15 == true || Image16 == true || Image17 == true || Image18 == true || Image19 == true || Image20 == true
                || Image21 == true || Image22 == true || Image23 == true || Image24 == true || Image25 == true || Image26 == true || Image27 == true || Image28 == true || Image29 == true || Image30 == true || Image31 == true || Image32 == true)
            { exist = true; }

            return exist;
        }

        public string IsExamImagesExist()
        {
            if (ExamImagesExist())
            { return "YES"; }
            else
            { return "NONE"; }
        } //-- 

    }
}
