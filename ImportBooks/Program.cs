
using Newtonsoft.Json;

StreamReader reader = new(@"C:\Users\joelb\Downloads\books.json");

var json = JsonConvert.DeserializeObject(reader.ReadToEnd());
