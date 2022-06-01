using DependencyInjectionDemoProject2.Interface;

namespace DependencyInjectionDemoProject2.BusinessDomain
{
    public class Dog : IMakeSound
    {
        public string makeSound()
        {
            return "woof";
        }
    }
}
