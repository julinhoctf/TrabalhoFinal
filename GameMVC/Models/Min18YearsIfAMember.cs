using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMVC.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.SignatureCustomerId == SignatureCustomer.Unknown || customer.SignatureCustomerId == SignatureCustomer.PayAsYouGo) return ValidationResult.Success;
            if (customer.Birthdate == null) return new ValidationResult("O campo Data de Nascimento é obrigatório!");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("O cliente deve possuir 18 anos ou mais para associar-se!");
        }
    }
}