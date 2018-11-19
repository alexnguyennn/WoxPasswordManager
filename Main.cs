using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wox.Plugin;

namespace PasswordManager
{
    class Main : IPlugin
    {
        public List<Result> Query(Query query)
        {
            // not going into query in debug mode.. check why
            var result = new Result
            {
                Title = "PasswordManager",
                SubTitle = $"Query: {query.ToString()}",
                IcoPath = "app.png",
                Action = e =>
                {
                    Console.WriteLine(e.ToString());
                    return true;
                }
            };
            // return new List<Result> {result};
            //var test = "test";
            //return new List<Result> {result};
            List<Result> results =  new List<Result> {result};
            results.Add(result);
            return results;
}

        public void Init(PluginInitContext context)
        {
            
        }
    }
}
