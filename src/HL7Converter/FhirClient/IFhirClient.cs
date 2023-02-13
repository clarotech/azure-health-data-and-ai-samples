﻿namespace HL7Converter.FhirClient
{
    public interface IFhirClient
    {
        Task<HttpResponseMessage> Send(string reqBody, string hl7FileName);
    }
}
