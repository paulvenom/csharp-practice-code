using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleWeb.Models
{
    public class ContactFormModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }
    }
}