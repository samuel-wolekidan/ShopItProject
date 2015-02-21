using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EShopItServiceLibraryApplication
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/products/{id}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Product GetProduct(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/products", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Product> GetAllProducts();

        [OperationContract]
        [WebGet(UriTemplate = "/producer/{id}", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        Producer GetProducer(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/producers", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Producer> GetAllProducers();
    }
}

