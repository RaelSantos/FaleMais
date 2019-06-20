namespace FaleMais.Dominio.User.Entities
{
    public class SpeakMore
    {     
        public decimal Value { get; set; }
        public decimal ValueWith { get; set; }

        public static SpeakMore CalculateRate(AreaCodeValueMinute areaCodeValueMinute, Plan plan, int minutesUsed)
        {
            var _speakMore = new SpeakMore();

            if (minutesUsed > plan.Minute)
            {
                var _rest = minutesUsed - plan.Minute;
                var _pay = areaCodeValueMinute.ValueMin * _rest;
                _speakMore.Value = areaCodeValueMinute.ValueMin * minutesUsed;
                _speakMore.ValueWith = _pay * 0.1m + _pay;
            }
            else
            {
                _speakMore.Value = areaCodeValueMinute.ValueMin * minutesUsed;
                _speakMore.ValueWith = 0.0m;
            }

            return _speakMore;
        }
    }
}
