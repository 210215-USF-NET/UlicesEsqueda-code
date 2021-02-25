using System;

/*
Class members:
in java:
    fields, constructors, methods
in c#:
    fields, properites, methods, constructors
        fields - characteristics of your object
        methods - behavior of your object
        constructors - special method, that gets called when you create an instance of an object
        - if there exists no constructor, there's a default one that gets created for you.
        properties - "smart fields"
                   - in jae you need to have a field for a getter and setter to exist.
                   - wrapper for a field, works as a getter and setter for a private backing field,

POCO - plain old c# object
     - class that holds data
*/

namespace ToHModels
{
    /// <summary>
    /// Data structure used for modeling a Hero.
    /// </summary>

    public class Hero
    {
        private string heroName;
        public string HeroName { 
            get { 
                return heroName;
            } 
            set {
                if (value.Equals(null)) { /*TODO: throw exception*/ }
                    heroName = value;
            } 
        }

        public int HP { get; set; }

        public Element ElementType { get; set; }

        public SuperPower SuperPower { get; set; }
        public int? Id { get; set; }

        public override string ToString() => $"\n\t name: {this.heroName} \n\t hp: {this.HP} \n\t element: {this.ElementType} \n\t superpower: {this.SuperPower.ToString()}";

    }
}
