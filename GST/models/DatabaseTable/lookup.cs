﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.DatabaseTable
{
    public class lookup:BaseEntity
    {


        public string Class { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
