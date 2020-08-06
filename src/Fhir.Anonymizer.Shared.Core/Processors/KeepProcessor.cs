﻿using System.Collections.Generic;
using Microsoft.Health.Fhir.Anonymizer.Core.Models;
using Hl7.Fhir.ElementModel;

namespace Microsoft.Health.Fhir.Anonymizer.Core.Processors
{
    public class KeepProcessor: IAnonymizerProcessor
    {
        public ProcessResult Process(ElementNode node, ProcessContext context = null, Dictionary<string, object> settings = null)
        {
            return new ProcessResult();
        }
    }
}