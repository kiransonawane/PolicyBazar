namespace Quote.Application.Dto.Quote
{
    public class QuoteDto
    {
        public PersonDetailDto PersonDetail { get; set; }
        public VehicleDetailDto VehicleDetail { get; set; }
        public int QuoteValidityDays { get; set; }
    }
}
