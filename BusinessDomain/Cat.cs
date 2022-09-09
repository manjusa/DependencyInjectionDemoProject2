
using DependencyInjectionDemoProject2.Interface;

namespace DependencyInjectionDemoProject2.BusinessDomain
{
    public class Cat:IMakeSound
    {      

        public string makeSound()
        {
            return "meow";
        }
    }
}
