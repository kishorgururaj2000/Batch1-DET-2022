namespace Batch1_DET_2022
{
    internal class CSFeaturesBase
    {

        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hai{name}"); };
            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai{s1}," + $"you said{s2}"); };
            action.Invoke("Kishor");
            action1.Invoke("Kishor", "Iam in Bengaluru");


        }
    }
}