using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnayzer
{
    public class AnalyzeMood
    {
        string mood;
        public AnalyzeMood(string mood)
        {
            this.mood = mood;
        }
        public string getMood()
        {
            try
            {
                if (this.mood.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}
