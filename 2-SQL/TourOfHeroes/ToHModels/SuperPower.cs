using System;

namespace ToHModels
{
    public class SuperPower
    {
        public int Damage { get; set; }
        public String Description { get; set; }
        public String Name { get; set; }

        public override string ToString() => $"\n\t name: {this.Name} \n\t damage: {this.Damage} \n\t description: {this.Description}";
    }
}