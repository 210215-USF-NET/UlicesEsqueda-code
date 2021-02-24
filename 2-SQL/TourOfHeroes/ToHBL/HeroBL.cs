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

        public Hero GetHeroByName(string name)
        {
            return _repo.GetHeroByName(name);
        }

        public List<Hero> GetHeroes(){
            //TODO: add BL
            return _repo.GetHeroes();
        }

        
    }
}
