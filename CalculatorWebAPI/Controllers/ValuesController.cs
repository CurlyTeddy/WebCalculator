using System.Collections.Generic;
using System.Web.Http;
using CalculatorWebAPI.Models;
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
            int? token = (int?)value["ID"];
            if (value["ID"].ToString() == "")
            {
                token = GlobalVariables.Token[GlobalVariables.UserNumber++];
                GlobalVariables.IdentifierMap.Add(token, new Answer());
            }

            Answer target = GlobalVariables.IdentifierMap[token];
            if (int.TryParse(symbol, out int dummy))
            {
                new Number(symbol).Execute(target);
            }
            else
            {
                GlobalVariables.ButtonMap[symbol].Execute(target);
            }

            // Double quotes are required to represent strings in Json
            return JObject.Parse($"{{ \"Token\": {token}, \"CurrentEquation\": \"{target.CurrentEquation}\", \"Result\": \"{target.Result}\" }}");
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
