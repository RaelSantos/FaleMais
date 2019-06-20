namespace FaleMais.Dominio.User.Entities
{
    public class AreaCodeValueMinute
    {
        protected AreaCodeValueMinute()
        {

        }

        public int Id { get; set; }

        public int AreaCodeSourceId { get; set; }

        public int AreaCodeDestinyId { get; set; }

        public virtual AreaCodeSource AreaCodeSource { get; set; }
      
        public virtual AreaCodeDestiny AreaCodeDestiny { get; set; }

        public decimal ValueMin { get; set; }
    }
}
