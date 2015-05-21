using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Calculator.BDDTests
{
    public static class Utils
    {
        public static void SetOnTestContext<TType>(string key, TType obj)
        {
            ScenarioContext.Current.Add(key, obj);
        }

        public static TType GetOnTestContext<TType>(string key)
        {
            if (!ScenarioContext.Current.ContainsKey(key))
                return default(TType);

            return ScenarioContext.Current.Get<TType>(key);
        }
    }
}
