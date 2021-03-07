using System;
using System.Collections.Generic;
using ToHDL;
using ToHModels;

namespace ToHBL
{
    public class HeroBL : IHeroBL
    {
        private IHeroRepository _repo;
        public HeroBL(IHeroRepository repo){
            _repo = repo;
        }
        public void AddHero(Hero newHero){
            //TODO: Add BL
            _repo.AddHero(newHero);
        }

        public void DeleteHero(Hero hero2BDeleted)
        {
            _repo.DeleteHero(hero2BDeleted);
        }

        public Hero GetHeroByName(string name)
        {
            return _repo.GetHeroByName(name);
        }

        public List<Hero> GetHeroes(){
            //TODO: add BL
            return _repo.GetHeroes();
        }

        public void UpdateHero(Hero hero2BUpdated, Hero updatedDetails)
        {
            hero2BUpdated.ElementType =  updatedDetails.ElementType;
            hero2BUpdated.HeroName = updatedDetails.HeroName;
            hero2BUpdated.HP = updatedDetails.HP;

            hero2BUpdated.SuperPower.Damage = updatedDetails.SuperPower.Damage;
            hero2BUpdated.SuperPower.Description = updatedDetails.SuperPower.Description;
            hero2BUpdated.SuperPower.Name = updatedDetails.SuperPower.Name;

            _repo.UpdateHero(hero2BUpdated);
        }
    }
}
