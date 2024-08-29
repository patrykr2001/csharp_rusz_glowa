using System.Reflection;

namespace HasASecretApp;

class Program
{
    static void Main(string[] args)
    {
        HasASecret keeper = new HasASecret();
        
        FieldInfo[] fields = keeper.GetType().GetFields(
            BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            Console.WriteLine(field.GetValue(keeper));
        }
    }
}