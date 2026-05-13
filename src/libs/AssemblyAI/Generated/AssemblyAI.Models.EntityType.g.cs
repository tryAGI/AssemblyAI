
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The type of entity for the detected entity
    /// </summary>
    public enum EntityType
    {
        /// <summary>
        /// 
        /// </summary>
        AccountNumber,
        /// <summary>
        /// 
        /// </summary>
        BankingInformation,
        /// <summary>
        /// 
        /// </summary>
        BloodType,
        /// <summary>
        /// 
        /// </summary>
        CreditCardCvv,
        /// <summary>
        /// 
        /// </summary>
        CreditCardExpiration,
        /// <summary>
        /// 
        /// </summary>
        CreditCardNumber,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        DateInterval,
        /// <summary>
        /// 
        /// </summary>
        DateOfBirth,
        /// <summary>
        /// 
        /// </summary>
        DriversLicense,
        /// <summary>
        /// 
        /// </summary>
        Drug,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Filename,
        /// <summary>
        /// 
        /// </summary>
        Gender,
        /// <summary>
        /// 
        /// </summary>
        GenderSexuality,
        /// <summary>
        /// 
        /// </summary>
        HealthcareNumber,
        /// <summary>
        /// 
        /// </summary>
        Injury,
        /// <summary>
        /// 
        /// </summary>
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        LocationAddress,
        /// <summary>
        /// 
        /// </summary>
        LocationAddressStreet,
        /// <summary>
        /// 
        /// </summary>
        LocationCity,
        /// <summary>
        /// 
        /// </summary>
        LocationCoordinate,
        /// <summary>
        /// 
        /// </summary>
        LocationCountry,
        /// <summary>
        /// 
        /// </summary>
        LocationState,
        /// <summary>
        /// 
        /// </summary>
        LocationZip,
        /// <summary>
        /// 
        /// </summary>
        MaritalStatus,
        /// <summary>
        /// 
        /// </summary>
        MedicalCondition,
        /// <summary>
        /// 
        /// </summary>
        MedicalProcess,
        /// <summary>
        /// 
        /// </summary>
        MoneyAmount,
        /// <summary>
        /// 
        /// </summary>
        Nationality,
        /// <summary>
        /// 
        /// </summary>
        NumberSequence,
        /// <summary>
        /// 
        /// </summary>
        Occupation,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        OrganizationMedicalFacility,
        /// <summary>
        /// 
        /// </summary>
        PassportNumber,
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        PersonAge,
        /// <summary>
        /// 
        /// </summary>
        PersonName,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        PhysicalAttribute,
        /// <summary>
        /// 
        /// </summary>
        PoliticalAffiliation,
        /// <summary>
        /// 
        /// </summary>
        Religion,
        /// <summary>
        /// 
        /// </summary>
        Sexuality,
        /// <summary>
        /// 
        /// </summary>
        Statistics,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        UsSocialSecurityNumber,
        /// <summary>
        /// 
        /// </summary>
        Username,
        /// <summary>
        /// 
        /// </summary>
        VehicleId,
        /// <summary>
        /// 
        /// </summary>
        ZodiacSign,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityType value)
        {
            return value switch
            {
                EntityType.AccountNumber => "account_number",
                EntityType.BankingInformation => "banking_information",
                EntityType.BloodType => "blood_type",
                EntityType.CreditCardCvv => "credit_card_cvv",
                EntityType.CreditCardExpiration => "credit_card_expiration",
                EntityType.CreditCardNumber => "credit_card_number",
                EntityType.Date => "date",
                EntityType.DateInterval => "date_interval",
                EntityType.DateOfBirth => "date_of_birth",
                EntityType.DriversLicense => "drivers_license",
                EntityType.Drug => "drug",
                EntityType.Duration => "duration",
                EntityType.EmailAddress => "email_address",
                EntityType.Event => "event",
                EntityType.Filename => "filename",
                EntityType.Gender => "gender",
                EntityType.GenderSexuality => "gender_sexuality",
                EntityType.HealthcareNumber => "healthcare_number",
                EntityType.Injury => "injury",
                EntityType.IpAddress => "ip_address",
                EntityType.Language => "language",
                EntityType.Location => "location",
                EntityType.LocationAddress => "location_address",
                EntityType.LocationAddressStreet => "location_address_street",
                EntityType.LocationCity => "location_city",
                EntityType.LocationCoordinate => "location_coordinate",
                EntityType.LocationCountry => "location_country",
                EntityType.LocationState => "location_state",
                EntityType.LocationZip => "location_zip",
                EntityType.MaritalStatus => "marital_status",
                EntityType.MedicalCondition => "medical_condition",
                EntityType.MedicalProcess => "medical_process",
                EntityType.MoneyAmount => "money_amount",
                EntityType.Nationality => "nationality",
                EntityType.NumberSequence => "number_sequence",
                EntityType.Occupation => "occupation",
                EntityType.Organization => "organization",
                EntityType.OrganizationMedicalFacility => "organization_medical_facility",
                EntityType.PassportNumber => "passport_number",
                EntityType.Password => "password",
                EntityType.PersonAge => "person_age",
                EntityType.PersonName => "person_name",
                EntityType.PhoneNumber => "phone_number",
                EntityType.PhysicalAttribute => "physical_attribute",
                EntityType.PoliticalAffiliation => "political_affiliation",
                EntityType.Religion => "religion",
                EntityType.Sexuality => "sexuality",
                EntityType.Statistics => "statistics",
                EntityType.Time => "time",
                EntityType.Url => "url",
                EntityType.UsSocialSecurityNumber => "us_social_security_number",
                EntityType.Username => "username",
                EntityType.VehicleId => "vehicle_id",
                EntityType.ZodiacSign => "zodiac_sign",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityType? ToEnum(string value)
        {
            return value switch
            {
                "account_number" => EntityType.AccountNumber,
                "banking_information" => EntityType.BankingInformation,
                "blood_type" => EntityType.BloodType,
                "credit_card_cvv" => EntityType.CreditCardCvv,
                "credit_card_expiration" => EntityType.CreditCardExpiration,
                "credit_card_number" => EntityType.CreditCardNumber,
                "date" => EntityType.Date,
                "date_interval" => EntityType.DateInterval,
                "date_of_birth" => EntityType.DateOfBirth,
                "drivers_license" => EntityType.DriversLicense,
                "drug" => EntityType.Drug,
                "duration" => EntityType.Duration,
                "email_address" => EntityType.EmailAddress,
                "event" => EntityType.Event,
                "filename" => EntityType.Filename,
                "gender" => EntityType.Gender,
                "gender_sexuality" => EntityType.GenderSexuality,
                "healthcare_number" => EntityType.HealthcareNumber,
                "injury" => EntityType.Injury,
                "ip_address" => EntityType.IpAddress,
                "language" => EntityType.Language,
                "location" => EntityType.Location,
                "location_address" => EntityType.LocationAddress,
                "location_address_street" => EntityType.LocationAddressStreet,
                "location_city" => EntityType.LocationCity,
                "location_coordinate" => EntityType.LocationCoordinate,
                "location_country" => EntityType.LocationCountry,
                "location_state" => EntityType.LocationState,
                "location_zip" => EntityType.LocationZip,
                "marital_status" => EntityType.MaritalStatus,
                "medical_condition" => EntityType.MedicalCondition,
                "medical_process" => EntityType.MedicalProcess,
                "money_amount" => EntityType.MoneyAmount,
                "nationality" => EntityType.Nationality,
                "number_sequence" => EntityType.NumberSequence,
                "occupation" => EntityType.Occupation,
                "organization" => EntityType.Organization,
                "organization_medical_facility" => EntityType.OrganizationMedicalFacility,
                "passport_number" => EntityType.PassportNumber,
                "password" => EntityType.Password,
                "person_age" => EntityType.PersonAge,
                "person_name" => EntityType.PersonName,
                "phone_number" => EntityType.PhoneNumber,
                "physical_attribute" => EntityType.PhysicalAttribute,
                "political_affiliation" => EntityType.PoliticalAffiliation,
                "religion" => EntityType.Religion,
                "sexuality" => EntityType.Sexuality,
                "statistics" => EntityType.Statistics,
                "time" => EntityType.Time,
                "url" => EntityType.Url,
                "us_social_security_number" => EntityType.UsSocialSecurityNumber,
                "username" => EntityType.Username,
                "vehicle_id" => EntityType.VehicleId,
                "zodiac_sign" => EntityType.ZodiacSign,
                _ => null,
            };
        }
    }
}