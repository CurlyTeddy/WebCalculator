using System.Collections.Generic;
using System.Web.Http;
using Controllers.Models;
using Newtonsoft.Json.Linq;

namespace CalculatorWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public int Get(int id)
        {
            return id;
        }

        // POST api/values
        public JObject Post([FromBody] JObject value)
        {
            string symbol = value["button"].ToString();
            int identifier = (int)value["ID"];
            if (!GlobalVariables.IdentifierMap.TryGetValue(identifier, out Answer target))
            {
                target = new Answer();
                GlobalVariables.IdentifierMap.Add(identifier, target);
            }

            if (double.TryParse(symbol, out double dummy))
            {
                new Number(symbol).Execute(target);
            }
            else
            {
                GlobalVariables.ButtonMap[symbol].Execute(target);
            }

            return JObject.Parse($"{{ \"CurrentEquation\": \"{target.CurrentEquation}\", \"Result\": \"{target.Result}\" }}");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            GlobalVariables.IdentifierMap.Remove(id);
        }
    }
}
