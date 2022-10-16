using Newtonsoft.Json;

namespace DummyDB_Task1.WorkWithSchema
{
    class Schema
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "columns")]
        public List<SchemaElement> Elements = new List<SchemaElement>();
    }
}
