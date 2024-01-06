using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote.Application.Response.Quote
{
    public class QuoteResponse
    {
        public int AggregatorId { get; set; }
        public int PolicyTypeId { get; set; }
        public string InsuredName { get; set; }
        public string CustomerEmail { get; set; }
        public string QuotationDate { get; set; }
        public string PhoneNo { get; set; }
        public int Nationality { get; set; }
        public string InsuredDob { get; set; }
        public string BusinessCode { get; set; }
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
        public decimal SumInsured { get; set; }
        public bool IsExcesssDeductible { get; set; }
        public bool IsNewDrivingLicense { get; set; }
        public bool IsUnderageDriver { get; set; }
        public bool IsReventDLHolder { get; set; }
        public decimal Premium { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
        public bool IsPabDriver { get; set; }
        public bool IsPabPassenger { get; set; }
        public string RtaEvg { get; set; }
        public string Grasp { get; set; }
        public bool IsHireCar { get; set; }
        public int QuotevalidityDays { get; set; }
        public int QuoteNumber { get; set; }
    }
}
