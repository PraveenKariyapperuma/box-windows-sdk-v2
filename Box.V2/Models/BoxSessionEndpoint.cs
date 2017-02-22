﻿using Newtonsoft.Json;

namespace Box.V2.Models
{
    /// <summary>
    /// Represents box upload session
    /// </summary>
    public class BoxSessionEndpoint
    {
        public const string FieldListParts = "list_parts";
        public const string FieldCommit = "commit";
        public const string FieldLogEvent = "log_event";
        public const string FieldUploadPart = "upload_part";
        public const string FieldAbort = "abort";

        [JsonProperty(PropertyName = FieldListParts)]
        public string ListParts { get; private set; }

        [JsonProperty(PropertyName = FieldCommit)]
        public string Commit { get; private set; }

        [JsonProperty(PropertyName = FieldLogEvent)]
        public string LogEvent { get; private set; }

        [JsonProperty(PropertyName = FieldUploadPart)]
        public string UploadPart { get; private set; }

        [JsonProperty(PropertyName = FieldAbort)]
        public string Abort { get; private set; }
    }
}
