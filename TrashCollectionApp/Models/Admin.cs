using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionApp.Models
{
    public class Admin : User
    {
        [Key]
        private int id = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
