using CustomValidationDate.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidationDate.Models
{
    public class RegisterValidationViewModel
    {

        [Required(ErrorMessage = "Vui lòng nhập họ tên.")]
        [MaxLength(150, ErrorMessage = "Tên không lớn hơn 150 ký tự!")]
        [MinLength(3, ErrorMessage = "Độ dài tên không hợp lệ!")]
        [CheckName]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [CheckAge]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số CMTND.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Số CMTND không hợp lệ!")]
        [MaxLength(12, ErrorMessage = "Số CMTND không hợp lệ!")]
        [MinLength(9, ErrorMessage = "Số CMTND không hợp lệ!")]
        public string IndentifyCard { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ!")]
        [CheckNumberPhone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ thường trú.")]
        [MaxLength(250, ErrorMessage = "Địa chỉ thường trú không được lớn hơn 250 ký tự!")]
        [MinLength(10, ErrorMessage = "Độ dài địa chỉ thường trú không hợp lệ!")]
        //[Range(50, 250, ErrorMessage = "Địa chỉ không được ít hơn 50 ký tự và lớn hơn 250 ký tự!")]
        public string ResidentAddress { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ đang sinh sống.")]
        [MaxLength(250, ErrorMessage = "Địa chỉ thường trú không được lớn hơn 250 ký tự!")]
        [MinLength(10, ErrorMessage = "Độ dài địa chỉ thường trú không hợp lệ!")]
        //[Range(50, 250, ErrorMessage = "Địa chỉ không được ít hơn 50 ký tự và lớn hơn 250 ký tự!")]
        public string CurrentAddress { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateStartInsurrence { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên đơn vị công tác.")]
        [MaxLength(ErrorMessage = "Tên đơn vị công tác không được lớn hơn 200 ký tự!")]
        public string CompanyName { get; set; }

        public Decimal Income { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại liên hệ")]
        [Phone(ErrorMessage = "Số điện thoại liên hệ không hợp lệ!")]
        public string ContactPhone { get; set; }

        public int Acreage { get; set; } // Diện tích

        public string Location { get; set; } // Địa điểm

        public int FirstPayment { get; set; }

        public int MonthlyPayment { get; set; }

        public int HtlsType { get; set; }

        public int Htls { get; set; } //Vay trong 15 năm( trong gói HTLS 30.000 tỷ):

        public int HtlsAndLsBidv { get; set; } //Vay trong 15 năm( trong gói HTLS 30.000 tỷ) + 5 năm của BIDV

        public int ExpectMonthReceive { get; set; }

        public string Note { get; set; }

        public string DifferentLocation { get; set; }

        public string DifferentFirstPayment { get; set; }

        public string DifferentHtls { get; set; }

        public string DifferentHtlsBidv { get; set; }

        public string DifferentMonthlyPayment { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ID.")]
        [CheckIdentification]
        public string Identify { get; set; }
    }
}