using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication7.ViewModels
{
    public class UserViewModel
    {
        [DisplayName("Имя пользовотеля")]

        public string UserName { get; set; }
        [DisplayName("Дата регистрации")]
        public DateTime CreationDate { get; set; }
    }
}