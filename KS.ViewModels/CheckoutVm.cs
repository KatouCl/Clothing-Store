﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KS.Entities.Enums;
using KS.ViewModels.Cart;

namespace KS.ViewModels
{
    public class CheckoutVm
    {
        [Required(ErrorMessage = "Введите имя")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Введите фамилию")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Введите страну")]
        public string Country { get; set; }
        
        [Required(ErrorMessage = "Введите город")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Введите регион")]
        public string Region { get; set; }
        
        [Required(ErrorMessage = "Введите адрес")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Введите почту")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Введите номер телефона")]
        public string Phone { get; set; }
        public string Comment { get; set; }
        // public DeliveryType DeliveryType { get; set; } 
    }
}