using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidationDate.Models.Validation
{

    public class CheckNumberPhoneAttribute : ValidationAttribute
    {
        string oldMobile = "09";
        string newMobile = "01";
        string homephone = "08";
        string errorMessageInvalidNumberphone = "Số điện thoại không chính xác.";
        #region Vietel

        public static bool CheckNewNumberphoneViettel(string numberphone)
        {
            string[] listNewFirstNumberphoneViettel = new string[] { "0163", "0164", "0165", "0166", "0167", "0168", "0169" };
            String firstNumberphone = numberphone.Substring(0, 4);
            foreach (var item in listNewFirstNumberphoneViettel)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckOldNumberphoneViettel(string numberphone)
        {
            string[] listOldFirstNumberphoneViettel = new string[] { "096", "097", "098" };
            String firstNumberphone = numberphone.Substring(0, 3);
            foreach (var item in listOldFirstNumberphoneViettel)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Mobilephone
        public static bool CheckNewNumberphoneMobi(string numberphone)
        {
            string[] listNewFirstNumberphoneMobi = new string[] { "0120", "0121", "0122", "0126", "0128" };
            String firstNumberphone = numberphone.Substring(0, 4);
            foreach (var item in listNewFirstNumberphoneMobi)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckOldNumberphoneMobi(string numberphone)
        {
            string[] listOldFirstNumberphoneViettel = new string[] { "090", "093" };
            String firstNumberphone = numberphone.Substring(0, 3);
            foreach (var item in listOldFirstNumberphoneViettel)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region  Vinaphone
        public static bool CheckNewNumberphoneVina(string numberphone)
        {
            string[] listNewFirstNumberphoneVina = new string[] { "0123", "0124", "0122", "0125", "0127", "0129" };
            String firstNumberphone = numberphone.Substring(0, 4);
            foreach (var item in listNewFirstNumberphoneVina)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckOldNumberphoneVina(string numberphone)
        {
            string[] listOldFirstNumberphoneVina = new string[] { "091", "094" };
            String firstNumberphone = numberphone.Substring(0, 3);
            foreach (var item in listOldFirstNumberphoneVina)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Vietnammobile
        public static bool CheckNewNumberphoneVNMobile(string numberphone)
        {
            string[] listNewFirstNumberphoneVNMobile = new string[] { "0188" };
            String firstNumberphone = numberphone.Substring(0, 4);
            foreach (var item in listNewFirstNumberphoneVNMobile)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckOldNumberphoneVNMobile(string numberphone)
        {
            string[] listOldFirstNumberphoneVNMobile = new string[] { "092" };
            String firstNumberphone = numberphone.Substring(0, 3);
            foreach (var item in listOldFirstNumberphoneVNMobile)
            {
                if (item.Equals(firstNumberphone))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                String numberphone = (String)value;
                if (String.IsNullOrEmpty(numberphone))
                {
                    string errorMessageInvalidNumberphone = "Vui lòng nhập số điện thoại.";
                    return new ValidationResult(errorMessageInvalidNumberphone);
                }
                string firstNumberphone = numberphone.Substring(0, 2);
                //Kiem tra tren dau so moi
                if (firstNumberphone.Equals(newMobile))
                {
                    if (numberphone.Length != 11)
                    {
                        return new ValidationResult(errorMessageInvalidNumberphone);
                    }
                    else
                    {
                        if (CheckNewNumberphoneMobi(numberphone) || CheckNewNumberphoneViettel(numberphone) || CheckNewNumberphoneVina(numberphone) || CheckNewNumberphoneVNMobile(numberphone))
                        {
                            return ValidationResult.Success;
                        }
                        else
                        {
                            return new ValidationResult(errorMessageInvalidNumberphone);
                        }
                    }
                }
                //Kiem tra tren dau so cu
                if (firstNumberphone.Equals(oldMobile))
                {
                    if (numberphone.Length != 10)
                    {
                        return new ValidationResult(errorMessageInvalidNumberphone);
                    }
                    else
                    {
                        if (CheckOldNumberphoneMobi(numberphone) || CheckOldNumberphoneViettel(numberphone) || CheckOldNumberphoneVina(numberphone) || CheckOldNumberphoneVNMobile(numberphone))
                        {
                            return ValidationResult.Success;
                        }
                        else
                        {
                            return new ValidationResult(errorMessageInvalidNumberphone);
                        }
                    }
                }
                //Kiem tra tren dien thoai ban
                if (firstNumberphone.Equals(homephone))
                {
                    if (numberphone.Length != 10)
                    {
                        return new ValidationResult(errorMessageInvalidNumberphone);
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                return new ValidationResult(errorMessageInvalidNumberphone);
            }
            catch (Exception ex)
            {
                string errorMessage = "Xảy ra lỗi";
                return new ValidationResult(errorMessage);
            }
        }
    }

}