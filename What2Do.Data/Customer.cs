﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What2Do.Data
{

    public class Customer : Account
    {
        /// <summary>
        /// Attributes
        /// </summary>

        [Key]
        public int CustomerID { get; set; }

        

       

    }
}
