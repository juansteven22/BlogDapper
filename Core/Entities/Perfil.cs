﻿namespace Core.Entities
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }= new HashSet<Usuario>();


    }
}

