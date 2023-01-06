using System.ComponentModel.DataAnnotations;
using Katalog.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Katalog.Entity
{
    public class Kullanici : IdentityUser
    {
        
       
        public string AdSoyad { get; set; }
        public bool Pasif { get; set; }
    }
}
