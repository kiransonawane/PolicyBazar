namespace Quote.Application.Dto.Quote
{
    public class VehicleDetailDto
    {
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string DlIssueDate { get; set; }
        public int ClaimsFreeDriveYrs { get; set; }
        public string ModelYear { get; set; }
        public string CityOfRegistration { get; set; }
        public string RegistrationDate { get; set; }
        public string VehicleType { get; set; }
        public string BodyType { get; set; }
        public int PassengerSeats { get; set; }
        public int Tonnage { get; set; }
        public int Cc { get; set; }
        public int Cylinder { get; set; }
        public bool IsRepairCondition { get; set; }
        public string UseOfVehicle { get; set; }
        public ComprehensiveDto Comprehensive { get; set; }
        public ThirdPartyDto ThirdParty { get; set; }
    }
}
