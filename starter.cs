﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using pokemonApp;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace pokemonApp
{
    internal class Starter : Pokemon
    {
        public Starter(string nom)
        {
            Random random = new();
            Name = nom;
            Pv = random.Next(80, 100);
            Def = random.Next(1, 5);
            Atk = random.Next(15, 30);
            Vit = random.Next(10, 20);
        }
 

        public int TakingDamage(int damages)
        {
            return Pv -= damages - Def;
        }
        public int Attack(int Damage)
        {
            return Damage;
        }
    }
}