﻿namespace UploadFhirJson.Model
{
    public class ServiceConfiguration : BlobConfiguration
    {
        public string AppInsightConnectionstring { get; set; }

        public string FhirURL { get; set; }

    }
}
