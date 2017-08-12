using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpInfoService" in both code and config file together.
    [ServiceContract]
    public interface IEmpInfoService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/json",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.Wrapped)]
        string date();

        [WebInvoke(Method = "GET", UriTemplate = "/get/{getid}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        Employee getemp(string getid);
    }
}
