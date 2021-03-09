using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToHModels;

namespace ToHMVC.Models
{
    public class Mapper : IMapper
    {
        public HeroIndexVM cast2HeroIndexVM(Hero hero2bCasted)
        {
            return new HeroIndexVM
            {
                HeroName = hero2bCasted.HeroName,
                HP = hero2bCasted.HP,
                ElementType = hero2bCasted.ElementType
            };
        }
        public Hero cast2Hero(HeroCRVM hero2bCasted)
        {
            return new Hero
            {
                HeroName = hero2bCasted.HeroName,
                HP = hero2bCasted.HP,
                ElementType = hero2bCasted.ElementType,
                SuperPower = new SuperPower
                {
                    Name = hero2bCasted.SuperPowerName,
                    Description = hero2bCasted.Description,
                    Damage = hero2bCasted.Damage
                }
            };
        }
        public HeroCRVM cast2HeroCRVM(Hero hero)
        {
            return new HeroCRVM
            {
                HeroName = hero.HeroName,
                HP = hero.HP,
                ElementType = hero.ElementType,
                SuperPowerName = hero.SuperPower.Name,
                Description = hero.SuperPower.Description,
                Damage = hero.SuperPower.Damage
            };
        }
    }
}
