using DependencyInjectionDemoProject2.Interface;

namespace DependencyInjectionDemoProject2.BusinessDomain
{
    public class Duck : IMakeSound
    {
        public string makeSound()
        {
            return "quack";
        }
    }
}
