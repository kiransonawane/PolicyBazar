using AutoMapper;
using Quote.Application.Dto.Quote;
using Quote.Application.Interfaces;
using Quote.Application.Request.Quote;
using Quote.Application.Response.Quote;
using Quote.Core.Entities;
using QuoteRequest = Quote.Application.Request.Quote.QuoteRequest;
using QuoteRequestEntity = Quote.Core.Entities.QuoteRequest;

namespace Quote.Application.Services
{
    public class QuotationService : IQuotationService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public QuotationService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<QuoteDto>> GetQuotation(QuoteRequest quotationRequest, CancellationToken cancellationToken)
        {
            var quotes = new List<QuoteDto>();
            await AddQuoteRequest(quotationRequest, cancellationToken);
            quotes = _mapper.Map<List<QuoteDto>>(await getQuoteResponse());
            return await Task.FromResult(quotes);
        }

        public async Task<int> SaveQuotation(SaveQuoteRequest saveQuotationRequest, CancellationToken cancellationToken)
        {
            return await Task.FromResult(111);
        }

        private async Task<bool> AddQuoteRequest(QuoteRequest quoteRequest, CancellationToken cancellationToken)
        {
            var quoteRequestEntity = _mapper.Map<QuoteRequestEntity>(quoteRequest);
            quoteRequestEntity.CreatedDate = DateTime.Now;
            await _unitOfWork.quoteRequests.AddAsync(quoteRequestEntity, cancellationToken);
            return true;
        }

        private Task<List<QuoteResponse>> getQuoteResponse()
        {
            var quoteResponse = new List<QuoteResponse>
            {
                new QuoteResponse
                {
                    AggregatorId = 101,
                    BodyType = "SUV",
                    BusinessCode = "B0001",
                    Cc = 1200,
                    CityOfRegistration = "Dubai",
                    ClaimsFreeDriveYrs = 3,
                    CustomerEmail = "B0001@pb.com",
                    Cylinder = 3,
                    DlIssueDate = $"{DateTime.Now:dd\\/MM\\/yyyy}",
                    Grasp = "Grasp01",
                    InsuredDob = $"{DateTime.Now:dd\\/MM\\/yyyy}",
                    InsuredName = "John Walker",
                    IsExcesssDeductible = true,
                    IsHireCar = true,
                    IsNewDrivingLicense = false,
                    IsPabDriver = false,
                    IsPabPassenger = false,
                    IsRepairCondition = true,
                    IsReventDLHolder = true,
                    IsUnderageDriver = false,
                    ModelYear = "2019",
                    Nationality = 1,
                    PassengerSeats = 4,
                    PhoneNo = "92822 09282",
                    PolicyTypeId = 4,
                    Premium = 23022.22m,
                    QuotationDate = $"{DateTime.Now:dd\\/MM\\/yyyy}",
                    QuotevalidityDays = 100,
                    RegistrationDate = $"{DateTime.Now:dd\\/MM\\/yyyy}",
                    RtaEvg = "Rta EVg 001",
                    SumInsured = 12010003m,
                    Tonnage = 10,
                    Total = 202920m,
                    UseOfVehicle = "Use Of Vehicle 001",
                    VAT = 1029m,
                    VehicleMake = "Vehicle Make 2012",
                    VehicleModel = "SUV",
                    VehicleType = "Vehicle Type",
                    QuoteNumber = 100110
                }
            };

            return Task.FromResult(quoteResponse);
        }
    }
}
