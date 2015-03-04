using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace EShopItServiceLibraryApplication
{
    public class Service : IService
    {
        public Product GetProduct(string id)
        {
            // lookup person with the requested id 
            return new Product()
            {
                Id = Convert.ToInt32(id),
                Name = "The Girl on the Train: A Novel-2",
                Price = 45.0
            };
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "The Girl on the Train: A Novel", Price = 30.0 });
            products.Add(new Product() { Id = 2, Name = "Lane's End (A Fitzjohn Mystery Book 4)", Price = 55.0 });
            products.Add(new Product() { Id = 3, Name = "Ruby (Oprah's Book Club 2.0)", Price = 45.0 });
            products.Add(new Product() { Id = 4, Name = "The Girl on the Train: A Novel", Price = 43.0 });
            products.Add(new Product() { Id = 5, Name = "The Girl on the Train: A Novel-2", Price = 78.0});
            products.Add(new Product() { Id = 6, Name = "The Girl on the Train: A Novel-3", Price = 53.0 });

            return products;
        }

        public Producer GetProducer(string id)
        {
            return new Producer()
            {
                Id = Convert.ToInt32(id),
                Name = "Deckle Edge"
            };
        }

        public List<Producer> GetAllProducers()
        {
            List<Producer> producers = new List<Producer>();
            producers.Add(new Producer() { Id = 1, Name = "Deckle Edge" });
            producers.Add(new Producer() { Id = 2, Name = "Prentice Hall" });
            producers.Add(new Producer() { Id = 3, Name = "Oakland Hills" });
            producers.Add(new Producer() { Id = 4, Name = "Fitzjohn Mystery" });

            return producers;
        }
    }

    [DataContract]
    public class Product
    {
        int id = 1;
        string name = "";
        double price = 0.0;

        [DataMember]
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [DataMember]
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }

    [DataContract]
    public class Producer
    {
        int id = 1;
        string name = "";

        [DataMember]
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }

    [DataContract]
    public class Customer
    {
        int id = 1;
        string name = "";

        [DataMember]
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
