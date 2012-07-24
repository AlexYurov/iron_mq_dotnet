using System;
using Newtonsoft.Json;

namespace io.iron.ironmq.Data
{
    [Serializable]
    [JsonObject]
    internal class QueueDetails
    {
        public string Id { get; set; }

        public string Project_Id { get; set; }

        public string Name { get; set; }
    }
}