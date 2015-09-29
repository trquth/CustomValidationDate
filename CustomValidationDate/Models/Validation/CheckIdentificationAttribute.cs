using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CustomValidationDate.Models.Validation
{
    public class CheckIdentificationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                string identification = (string)value;
                if (String.IsNullOrEmpty(identification))
                {
                    string errorMessage = "Vui lòng nhập đầy đủ thông tin";
                    return new ValidationResult(errorMessage);
                }
                var regexItem = new Regex("^[a-zA-Z0-9]*$");
                if (regexItem.IsMatch(identification))
                {
                    if (identification.Length == 8)
                    {
                        var regexItemForID = new Regex("^[bB]{1}[0-9]{7}$");
                        if (regexItemForID.IsMatch(identification))
                        {
                            return ValidationResult.Success;
                        }
                        else
                        {
                            string errorMessage = "Thông tin không chính xác";
                            return new ValidationResult(errorMessage);
                        }
                        //string firstCharID = identification.Substring(0, 1).ToUpper();
                        //if (firstCharID.Equals("B"))
                        //{
                        //    return ValidationResult.Success;
                        //}
                        //else
                        //{
                        //    string errorMessage = "Thông tin không chính xác";
                        //    return new ValidationResult(errorMessage);
                        //}

                    }
                    if (identification.Length == 9 || identification.Length == 12)
                    {
                        var regexItemForID = new Regex("^[0-9]*$");
                        if (regexItemForID.IsMatch(identification))
                        {
                            return ValidationResult.Success;
                        }
                        else
                        {
                            string errorMessage = "Thông tin không chính xác";
                            return new ValidationResult(errorMessage);
                        }
                    }
                    else
                    {
                        string errorMessage = "Thông tin không chính xác";
                        return new ValidationResult(errorMessage);
                    }
                }
                else
                {
                    string errorMessage = "Thông tin không chính xác";
                    return new ValidationResult(errorMessage);
                }         
            }
            catch (Exception ex)
            {

                string errorMessage = "Thông tin không chính xác";
                return new ValidationResult(errorMessage);
            }
            
        }
    }
}