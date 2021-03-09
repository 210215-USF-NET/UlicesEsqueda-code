using ToHModels;

namespace ToHMVC.Models
{
    public interface IMapper 
    {
        Hero cast2Hero(HeroCRVM hero2bCasted);
        HeroIndexVM cast2HeroIndexVM(Hero hero2bCasted);
        HeroCRVM cast2HeroCRVM(Hero hero);
    }
}