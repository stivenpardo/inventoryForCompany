using System.Net;
namespace InventoryFull.Aplication.Dto.Base
{
    public class DataTransferObject
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
    }
}
