using FluentValidation;
using Quote.Api.Common;
using Quote.Application.Request.Quote;

namespace Quote.Api.Validators
{

    public class SaveQuoteValidator : AbstractValidator<QuoteRequest>
    {
        public SaveQuoteValidator()
        {
            RuleFor(c => c.AggregatorId)
                .NotNull()
                .NotEmpty()
                .WithMessage("AggregatorId is required.")
                .Must(Validator.BeAValidPositiveInteger).WithMessage("AggregatorId should be valid number.");

            RuleFor(c => c.PolicyTypeId)
                .NotNull()
                .NotEmpty()
                .WithMessage("PolicyTypeId is required.")
                .Must(Validator.BeAValidPolicyTypeId).WithMessage("PolicyTypeId should be valid number.");

            RuleFor(c => c.InsuredName)
                .NotNull()
                .NotEmpty()
                .WithMessage("InsuredName is required")
                .MaximumLength(100).WithMessage("InsuredName should not be greater than 100 characters.");

            RuleFor(c => c.InsuredName)
                .NotNull()
                .NotEmpty()
                .WithMessage("InsuredName is required")
                .MaximumLength(100).WithMessage("InsuredName should not be greater than 100 characters.");

            RuleFor(c => c.CustomerEmail)
               .NotNull()
               .NotEmpty()
               .WithMessage("CustomerEmail is required.")
               .EmailAddress().WithMessage("Invalid CustomerEmail");

            RuleFor(c => c.PhoneNo)
                .NotNull()
                .NotEmpty()
                .WithMessage("PhoneNo is required")
                .MaximumLength(100).WithMessage("PhoneNo should not be greater than 20 characters.");

            RuleFor(c => c.Nationality)
               .NotNull()
               .NotEmpty()
               .WithMessage("Nationality is required.")
               .Must(Validator.BeAValidPositiveInteger).WithMessage("Nationality should be valid number.");

            RuleFor(c => c.InsuredDob)
               .NotNull()
               .NotEmpty()
               .WithMessage("InsuredDob is required.")
               .Must(Validator.BeValidDateFormat).WithMessage("Invalid insured date of birth format. Please use dd/MM/yyyy.");

            RuleFor(c => c.BusinessCode)
               .NotNull()
               .NotEmpty()
               .WithMessage("BusinessCode is required.");

            RuleFor(c => c.VehicleMake)
               .NotNull()
               .NotEmpty()
               .WithMessage("VehicleMake is required.");

            RuleFor(c => c.VehicleModel)
               .NotNull()
               .NotEmpty()
               .WithMessage("VehicleModel is required.");

            RuleFor(c => c.DlIssueDate)
               .NotNull()
               .NotEmpty()
               .WithMessage("DlIssueDate is required.")
               .Must(Validator.BeValidDateFormat).WithMessage("Invalid Date of Birth format. Please use dd/MM/yyyy.");

            RuleFor(c => c.ClaimsFreeDriveYrs)
             .NotNull()
             .NotEmpty()
             .WithMessage("ClaimsFreeDriveYrs is required.")
             .Must(c => c > 0).WithMessage("Invalid ClaimsFreeDriveYrs.");

            RuleFor(c => c.ModelYear)
              .NotNull()
              .NotEmpty()
              .WithMessage("ModelYear is required.")
              .Must(Validator.BeValidModelYear).WithMessage("Invalid ModelYear. Please use YYYY format.");

            RuleFor(c => c.CityOfRegistration)
              .NotNull()
              .NotEmpty()
              .WithMessage("CityOfRegistration is required.");

            RuleFor(c => c.RegistrationDate)
               .NotNull()
               .NotEmpty()
               .WithMessage("RegistrationDate is required.")
               .Must(Validator.BeValidDateFormat).WithMessage("Invalid RegistrationDate format. Please use dd/MM/yyyy.");

            RuleFor(c => c.VehicleType)
              .NotNull()
              .NotEmpty()
              .WithMessage("VehicleType is required.")
              .MaximumLength(1)
              .Must(c => c.Equals("N", StringComparison.OrdinalIgnoreCase) || c.Equals("O", StringComparison.OrdinalIgnoreCase))
              .WithMessage("Invalid VehicleType. Please use either N or O.");

            RuleFor(c => c.BodyType)
              .NotNull()
              .NotEmpty()
              .WithMessage("BodyType is required.");

            RuleFor(c => c.PassengerSeats)
              .NotNull()
              .NotEmpty()
              .WithMessage("PassengerSeats is required.")
              .Must(Validator.BeAValidPositiveInteger).WithMessage("Invalid PassengerSeats.");

            RuleFor(c => c.Tonnage)
              .NotNull()
              .NotEmpty()
              .WithMessage("Tonnage is required.");

            RuleFor(c => c.Cc)
              .NotNull()
              .NotEmpty()
              .WithMessage("CC is required.");

            RuleFor(c => c.Cylinder)
              .NotNull()
              .NotEmpty()
              .WithMessage("Cylinder is required.");

            RuleFor(c => c.IsRepairCondition)
              .NotNull()
              .NotEmpty()
              .WithMessage("IsRepairCondition is required.")
              .Must(Validator.BeValidBooleanValue).WithMessage("Invalid IsRepairCondition.");

            RuleFor(c => c.UseOfVehicle)
              .NotNull()
              .NotEmpty()
              .WithMessage("UseOfVehicle is required.");

            RuleFor(c => c.SumInsured)
              .NotNull()
              .NotEmpty()
              .WithMessage("SumInsured is required.");

            RuleFor(c => c.IsExcesssDeductible)
              .NotNull()
              .NotEmpty()
              .WithMessage("IsExcesssDeductible is required.")
              .Must(Validator.BeValidBooleanValue).WithMessage("Invalid IsExcesssDeductible.");

            RuleFor(c => c.IsNewDrivingLicense)
             .NotNull()
             .NotEmpty()
             .WithMessage("IsNewDrivingLicense is required.")
             .Must(Validator.BeValidBooleanValue).WithMessage("IsNewDrivingLicense IsExcesssDeductible.");

            RuleFor(c => c.IsUnderageDriver)
              .NotNull()
              .NotEmpty()
              .WithMessage("IsUnderageDriver is required.")
              .Must(Validator.BeValidBooleanValue).WithMessage("Invalid IsUnderageDriver.");

            RuleFor(c => c.IsReventDLHolder)
             .NotNull()
             .NotEmpty()
             .WithMessage("IsReventDLHolder is required.")
             .Must(Validator.BeValidBooleanValue).WithMessage("Invalid IsReventDLHolder.");

            RuleFor(c => c.Premium)
             .NotNull()
             .NotEmpty()
             .WithMessage("Premium is required.");

            RuleFor(c => c.VAT)
             .NotNull()
             .NotEmpty()
             .WithMessage("VAT is required.");

            RuleFor(c => c.Total)
             .NotNull()
             .NotEmpty()
             .WithMessage("Total is required.");

            RuleFor(c => c.IsPabDriver)
             .NotNull()
             .NotEmpty()
             .WithMessage("IsPabDriver is required.")
             .Must(Validator.BeValidBooleanValue).WithMessage("Invalid IsPabDriver.");

            RuleFor(c => c.IsPabPassenger)
             .NotNull()
             .NotEmpty()
             .WithMessage("IsPabPassenger is required.")
             .Must(Validator.BeValidBooleanValue).WithMessage("Invalid IsPabPassenger");

            RuleFor(c => c.RtaEvg)
             .NotNull()
             .NotEmpty()
             .WithMessage("RtaEvg is required.");

            RuleFor(c => c.Grasp)
            .NotNull()
            .NotEmpty()
            .WithMessage("Grasp is required.");

            RuleFor(c => c.IsHireCar)
            .NotNull()
            .NotEmpty()
            .WithMessage("IsHireCar is required.")
            .Must(Validator.BeValidBooleanValue).WithMessage("Invalid IsHireCar.");

            RuleFor(c => c.QuotevalidityDays)
            .NotNull()
            .NotEmpty()
            .WithMessage("QuotevalidityDays is required.")
            .Must(Validator.BeAValidPositiveInteger).WithMessage("Invalid QuotevalidityDays.");
        }

    }

}
