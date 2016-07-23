using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace HomeGenie.UI.ServiceClient
{
    public abstract class WebApiClient : IWebApiClient
    {




        public HttpWebRequest _request { get; set; }

        public HttpWebResponse _reponse { get; set; }



        public virtual string UrlString
        {
            get
            {
                return null;
            }
        }

        public virtual void Init(string contentType, string requestMethod)
        {
            _request = HttpWebRequest.Create(UrlString) as HttpWebRequest;
            _request.ContentType = contentType;
            _request.Method = requestMethod;
        }

        



        public string Request()
        {


            using (HttpWebResponse response = _request.GetResponse() as HttpWebResponse)
            {

                var statuscode = response.StatusCode;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    StreamReader readStream = new StreamReader(response.GetResponseStream(), encode);

                    string _result = readStream.ReadToEnd();
                    return _result;


                }
            }
            return string.Empty;



        }

    }
}
