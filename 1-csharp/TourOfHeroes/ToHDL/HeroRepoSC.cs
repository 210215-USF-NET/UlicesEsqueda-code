using System.Collections.Generic;
using ToHModels;

namespace ToHDL
{
    public class HeroRepoSC : IHeroRepository
    {
        public List<Hero> GetHeroes(){
            return Storage.AllHeroes;
        }

        public Hero AddHero(Hero newHero){
            Storage.AllHeroes.Add(newHero);
            return newHero;
        }
    }
}