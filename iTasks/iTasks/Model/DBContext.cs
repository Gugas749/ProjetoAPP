﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Model
{
    internal class DBContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TipoTarefas { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Programador> Programadores { get; set; }
        public DbSet<Gestor> Gestores { get; set; }
    }
}
