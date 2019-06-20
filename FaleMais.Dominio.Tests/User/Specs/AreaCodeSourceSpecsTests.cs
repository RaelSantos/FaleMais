using FaleMais.Infra.Persistence.Contexts;
using FaleMais.Infra.Repositories.User;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FaleMais.Dominio.Tests.User.Specs
{
    [TestClass]
    public class AreaCodeSourceSpecsTests
    {
        AreaCodeSourceRepository _rep = new AreaCodeSourceRepository(new FaleMaisDataContext());

        [TestMethod]
        [TestCategory("AreaCodeSource - Specs")]
        public void GetByIdShouldReturnValue()
        {
            var areaCodeSource = _rep.GetById(1);
            Assert.AreNotEqual(null, areaCodeSource);
        }

        [TestMethod]
        [TestCategory("AreaCodeSource - Specs")]
        public void GetByIdShouldNotReturnValue()
        {
            var areaCodeSource = _rep.GetById(10);
            Assert.AreEqual(null, areaCodeSource);
        }

        [TestMethod]
        [TestCategory("AreaCodeSource - Specs")]
        public void GetByCodeShouldReturnValue()
        {
            var areaCodeSource = _rep.GetByCode("011");
            Assert.AreNotEqual(null, areaCodeSource);
        }

        [TestMethod]
        [TestCategory("AreaCodeSource - Specs")]
        public void GetByCodeShouldNotReturnValue()
        {
            var areaCodeSource = _rep.GetByCode("015");
            Assert.AreEqual(null, areaCodeSource);
        }
    }
}
