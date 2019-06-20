using FaleMais.Infra.Persistence.Contexts;
using FaleMais.Infra.Repositories.User;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FaleMais.Dominio.Tests.User.Specs
{
    [TestClass]
    public class PlanSpecsTests
    {
        PlanRepository _rep = new PlanRepository(new FaleMaisDataContext());

        [TestMethod]
        [TestCategory("Plan - Specs")]
        public void GetByIdShouldReturnValue()
        {
            var plan = _rep.GetById(1);
            Assert.AreNotEqual(null, plan);
        }

        [TestMethod]
        [TestCategory("Plan - Specs")]
        public void GetByIdShouldNotReturnValue()
        {
            var plan = _rep.GetById(10);
            Assert.AreEqual(null, plan);
        }       
    }
}
