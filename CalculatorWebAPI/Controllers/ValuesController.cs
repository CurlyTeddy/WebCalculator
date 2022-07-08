using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Controllers.Models;

namespace CalculatorWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly Dictionary<string, IButton> Map = new Dictionary<string, IButton>()
        { { Addition.Content, new Addition() }, { Substraction.Content, new Substraction() }, { Multiplication.Content, new Multiplication()},
          { Division.Content, new Division() }, { Sqrt.Content, new Sqrt() }, { LParenthesis.Content, new LParenthesis() },
          { RParenthesis.Content, new RParenthesis() }, { DoublePoint.Content, new DoublePoint()}, { CalculateResult.Content, new CalculateResult() },
          { AllWipe.Content, new AllWipe() }, { Backward.Content, new Backward()}, { EquationWipe.Content, new EquationWipe() } };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string id)
        {
            return id;
        }

        // POST api/values
        public string[] Post([FromBody]string value)
        {
            string[] result = new string[2];
            if (double.TryParse(value, out double dummy))
            {
                new Number(value).Execute();
            }
            else
            {
                Map[value].Execute();
            }

            result[0] = GlobalVariables.CurrentEquation;
            result[1] = GlobalVariables.Result;
            /*if (value == CalculateResult.Content)
            {
                return $"{GlobalVariables.CurrentEquation}@{GlobalVariables.Result}";
            }
            return GlobalVariables.CurrentEquation;*/
            return result;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
