using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CustomValidationDate.Models.Validation
{
    public class CheckNameAttribute : ValidationAttribute
    {
        #region Count word in string
        public static bool CountWordInName(string name)
        {
            string[] words = name.Split(' ');
            if (words.Count() > 1)
            {
                foreach (var word in words)
                {
                    if (word.Length ==0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                string name = (string)value;
                if (String.IsNullOrEmpty(name))
                {
                    string errorMessage = "Vui lòng nhập tên";
                    return new ValidationResult(errorMessage);
                }
                if (CountWordInName(name))
                {
                    var regexItem = new Regex("^(?:[^`!@#$%^&*()_+])+$");
                    if (regexItem.IsMatch(name))
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
            catch (Exception ex)
            {
                string errorMessage = "Xảy ra lỗi";
                return new ValidationResult(errorMessage);
            }


        }
    }
}