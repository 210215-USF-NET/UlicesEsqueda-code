using System.Collections.Generic;
using ToHModels;
using System.IO;
using System.Text.Json;
using System;

namespace ToHDL
{
    public class HeroRepoFile : IHeroRepository
    {
        private string jsonString;
        private string filePath = "./ToHDL/HeroFiles.json";
        public Hero AddHero(Hero newHero)
        {
            List<Hero> heroesFromFile = GetHeroes(); //This is going to get me an exception.
            heroesFromFile.Add(newHero);
            jsonString = JsonSerializer.Serialize(heroesFromFile);
            File.WriteAllText(filePath, jsonString);

            return newHero;
        }

        public List<Hero> GetHeroes()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return new List<Hero>();
            }
            return JsonSerializer.Deserialize<List<Hero>>(jsonString);
        }
    }
}