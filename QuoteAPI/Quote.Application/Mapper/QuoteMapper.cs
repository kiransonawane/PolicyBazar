using AutoMapper;
using Quote.Application.Dto.Quote;
using Quote.Application.Response.Quote;

namespace Quote.Application.Mapper
{
    public class QuoteMapper : Profile
    {
        public QuoteMapper()
        {
            CreateMap<QuoteResponse, QuoteDto>()
                .ForMember(dest => dest.PersonDetail, src => src.MapFrom(s => new PersonDetailDto()
                {
                    BusinessCode = s.BusinessCode,
                    CustomerEmail = s.CustomerEmail,
                    InsuredDob = s.InsuredDob,
                    InsuredName = s.InsuredName,
                    Nationality = s.Nationality,
                    PhoneNo = s.PhoneNo,
                    QuotationDate = s.QuotationDate
                }))
                .ForMember(dest => dest.VehicleDetail, src => src.MapFrom(s => new VehicleDetailDto()
                {
                    ThirdParty = new ThirdPartyDto()
                    {
                        AddOn = new VehicleDetailAddOnDto
                        {
                            Grasp = s.Grasp,
                            IsHireCar = s.IsHireCar,
                            IsPabDriver = s.IsPabDriver,
                            IsPabPassenger = s.IsPabPassenger,
                            RtaEvg = s.RtaEvg
                        },
                        Quote = new VehicleDetailQuoteDto
                        {
                            IsNewDrivingLicense = s.IsNewDrivingLicense,
                            IsExcesssDeductible = s.IsExcesssDeductible,
                            IsReventDLHolder = s.IsReventDLHolder,
                            IsUnderageDriver = s.IsUnderageDriver,
                            Premium = s.Premium,
                            SumInsured = s.SumInsured,
                            Total = s.Total,
                            VAT = s.VAT
                        }
                    },
                    Comprehensive = new ComprehensiveDto()
                    {
                        AddOn = new VehicleDetailAddOnDto
                        {
                            Grasp = s.Grasp,
                            IsHireCar = s.IsHireCar,
                            IsPabDriver = s.IsPabDriver,
                            IsPabPassenger = s.IsPabPassenger,
                            RtaEvg = s.RtaEvg
                        },
                        Quote = new VehicleDetailQuoteDto
                        {
                            IsNewDrivingLicense = s.IsNewDrivingLicense,
                            IsExcesssDeductible = s.IsExcesssDeductible,
                            IsReventDLHolder = s.IsReventDLHolder,
                            IsUnderageDriver = s.IsUnderageDriver,
                            Premium = s.Premium,
                            SumInsured = s.SumInsured,
                            Total = s.Total,
                            VAT = s.VAT
                        }
                    }
                }));
        }
    }
}
