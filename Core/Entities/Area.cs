﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Departamento> Departamentos { get; set; } = new HashSet<Departamento>();
    }
}

