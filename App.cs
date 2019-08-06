using System;
using System.Collections.Generic;

namespace AdvancedTypes
{
    public class App
    {
        public void Greeting()
        {
            Console.WriteLine("Hello Class.");
        }

        public void Run()
        {
            // NOTE don't forget to instantiate your lists and dictionaries.
            List<string> staff = new List<string>();
            staff.Add("Porter");
            staff.Add("Zach");
            staff.Add("Brittany");
            staff.Add("Brooklyn");
            staff.Add("Jake");
            for (int i = 0; i < staff.Count; i++)
            {
                string name = staff[i]; //alias
                Console.WriteLine($"{i+1}. {name}");
            }
            // lets learn how to utilize a list method that takes a callback function
            // NOTE with query functions the syntax is: `variableName` => condition utilizing the `variableName`
            staff.Exists(staffMember => staffMember == "Brittany");
            staff.FindAll(staffMember => staffMember[0] == 'B');
        }

        bool ExistsLongHandExample(string target)
        {
            #region
            List<string> staff = new List<string>();
            staff.Add("Porter");
            staff.Add("Zach");
            staff.Add("Brittany");
            staff.Add("Jake");
            #endregion
            for (int i = 0; i < staff.Count; i++)
            {
                string staffMember = staff[i]; //alias
                if (staffMember == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}