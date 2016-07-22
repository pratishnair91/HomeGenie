using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace HomeGenie.UI.ServiceClient
{
    public class WebApiClient
    {
        private string _wepApiUrl= "http://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=Mango";

        private HttpWebRequest _request;


        public void Init(string contentType, string requestMethod)
        {
            _request = HttpWebRequest.Create(_wepApiUrl) as HttpWebRequest;
            _request.ContentType = contentType;
            _request.Method = requestMethod;
        }


     
        public string Request()
        {


            using (HttpWebResponse response = _request.GetResponse() as HttpWebResponse)
            {

                var statuscode=response.StatusCode;

                if (response.StatusCode== HttpStatusCode.OK)
                {
                    Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    StreamReader readStream = new StreamReader(response.GetResponseStream(), encode);

                    string _result=readStream.ReadToEnd();
                    return _result;
                    
                    
                }
            }
            return string.Empty;



        }

    }
}
