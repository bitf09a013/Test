using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetBooksList", ResponseFormat = WebMessageFormat.Json, BodyStyle= WebMessageBodyStyle.Wrapped)]
        List<Book> GetBooksList();

        //URI template can be different from function name, and from URITemplate services calls your function
        [OperationContract]
        [WebGet(UriTemplate = "GetBookById/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Book GetBookById(string id);

       /* [OperationContract]
        [WebInvoke(UriTemplate = "AddBook/{name}")]
        void AddBook(string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateBook/{id}/{name}")]
        void UpdateBook(string id, string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteBook/{id}")]
        void DeleteBook(string id);
        */

       /* [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        */
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Book
    {
        bool isbook = true;
        string bookname = "Hello ";

        [DataMember]
        public bool ISBOOK
        {
            get { return isbook; }
            set { isbook = value; }
        }

        [DataMember]
        public string BOOKNAME
        {
            get { return bookname; }
            set { bookname = value; }
        }
    }
}
