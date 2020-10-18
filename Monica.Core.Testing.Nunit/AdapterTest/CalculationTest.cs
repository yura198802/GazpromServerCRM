using Module.Testing.Nunit;
using Monica.Core.Abstraction.CriteriaCalculate;
using Monica.Core.Abstraction.Crm;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Monica.Core.Testing.Nunit.AdapterTest
{
    public class CalculationTest :  BaseServiceTest<ICriteriaCalculate>
    {
        [Test]
        public async Task WriteCriteriaries()
        {
            try
            {
                Service.CreateDataSetCalculate();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
