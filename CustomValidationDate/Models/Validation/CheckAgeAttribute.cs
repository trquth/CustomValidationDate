using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationDate.Models.Validation
{
    public class CheckAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                DateTime dtV = (DateTime)value;
                long lTicks = DateTime.Now.Ticks - dtV.Ticks;
                DateTime dtAge = new DateTime(lTicks);
                string errorMessage = "Độ tuổi không chính xác";
                if (!(dtAge.Year >= 18))
                {
                    return new ValidationResult(errorMessage);
                }
                return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                string errorMessage = "Xảy ra lỗi";
                return new ValidationResult(errorMessage);
            }

        }
    }
}