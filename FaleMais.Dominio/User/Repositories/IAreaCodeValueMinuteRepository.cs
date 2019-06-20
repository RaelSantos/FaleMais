using FaleMais.Dominio.User.Entities;

namespace FaleMais.Dominio.User.Repositories
{
    public interface IAreaCodeValueMinuteRepository
    {
        AreaCodeValueMinute ValueMin(int source, int destiny);
    }
}
