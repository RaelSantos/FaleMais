using FaleMais.Infra.Persistence.Contexts;
using FaleMais.Infra.Repositories.User;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FaleMais.Dominio.Tests.User.Specs
{
    [TestClass]
    public class AreaCodeValueMinuteSpecsTests
    {
        AreaCodeValueMinuteRepository _rep = new AreaCodeValueMinuteRepository(new FaleMaisDataContext());

        [TestMethod]
        [TestCategory("AreaCodeValueMinute - Specs")]
        public void GetBySourceIdAndDestinyIdShouldReturnValue()
        {
            var areaCodeValueMinute = _rep.ValueMin(1, 2);
            Assert.AreNotEqual(null, areaCodeValueMinute);
        }

        [TestMethod]
        [TestCategory("AreaCodeValueMinute - Specs")]
        public void GetBySourceIdAndDestinyIdShouldNotReturnValue()
        {
            var areaCodeValueMinute = _rep.ValueMin(11, 24);
            Assert.AreEqual(null, areaCodeValueMinute);
        }
    }
}
