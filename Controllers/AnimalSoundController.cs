using DependencyInjectionDemoProject2.BusinessDomain;
using DependencyInjectionDemoProject2.Interface;
using DependencyInjectionDemoProject2.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemoProject.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AnimalSoundController : ControllerBase
    {
        private readonly IMakeSound _catSound;
        private readonly IMakeSound _dogSound;
        private readonly IMakeSound _duckSound;

        public AnimalSoundController(Func<MakeSoundEnum,IMakeSound> serviceResolver)
        {
            _catSound = serviceResolver(MakeSoundEnum.Cat);
            _dogSound = serviceResolver(MakeSoundEnum.Dog);
            _duckSound = serviceResolver(MakeSoundEnum.Duck);
        }


        [HttpGet]
        public string CatMakeNoise()
        {
            
            return _catSound.makeSound();

        }
        [HttpGet]
        public string DogMakeNoise()
        {

            return _dogSound.makeSound();

        }
        [HttpGet]
        public string DuckMakeNoise()
        {

            return _duckSound.makeSound();

        }

    }
}