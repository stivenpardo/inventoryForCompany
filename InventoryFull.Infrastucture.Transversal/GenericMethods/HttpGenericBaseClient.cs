using InventoryFull.Aplication.Dto.Base;
using System.Threading.Tasks;

namespace InventoryFull.Infrastucture.Transversal.GenericMethods
{
    public class HttpGenericBaseClient : IHttpGenericBaseClient
    {
        public Task<T> Get<T>(string path, string request) where T : class
        {
            throw new System.NotImplementedException();
        }

        public T Patch<T>(string path, T request) where T : DataTransferObject
        {
            throw new System.NotImplementedException();
        }

        public Task<TResponse> Post<TResponse, TRequest>(string path, TRequest request) where TResponse : DataTransferObject
        {
            throw new System.NotImplementedException();
        }

        public T Put<T>(string path, T request) where T : DataTransferObject
        {
            throw new System.NotImplementedException();
        }
    }
}
