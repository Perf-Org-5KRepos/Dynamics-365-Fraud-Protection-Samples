﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Contoso.FraudProtection.ApplicationCore.Entities.FraudProtectionApiModels.AccountProtection
{
    public class ResultDetail
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DecisionName Decision { get; set; }

        public string ChallengeType { get; set; }

        public string[] Reasons { get; set; }

        public string Rule { get; set; }

        public string[] SupportMessages { get; set; }

        public Dictionary<string, object> Other { get; set; }

        public List<Score> Scores { get; set; }
    }

    public enum DecisionName
    {
        Approve,
        Reject,
        Challenge,
        Review
    }
}
