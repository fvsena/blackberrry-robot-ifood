using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web;

namespace Blackberry.Robots.IFood.Request
{
    internal class BaseRequest
    {
        public CookieContainer cookieContainer = new CookieContainer();
        public HttpWebRequest requestBase;
        public HttpWebResponse responseBase;

        public string GetTimeStamp()
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int milisecondsSinceEpoch = (int)t.TotalMilliseconds;
            return milisecondsSinceEpoch.ToString();
        }

        public string GetSecondsTimeStamp()
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;
            return secondsSinceEpoch.ToString();
        }

        internal string GetResponseBody(HttpWebResponse response)
        {
            string ret = null;
            using (Stream responseStream = response.GetResponseStream())
            {
                Stream streamToRead = responseStream;
                if (response.ContentEncoding.ToLower().Contains("gzip"))
                {
                    if (streamToRead != null) streamToRead = new GZipStream(streamToRead, CompressionMode.Decompress);
                }
                else if (response.ContentEncoding.ToLower().Contains("deflate"))
                {
                    if (streamToRead != null) streamToRead = new DeflateStream(streamToRead, CompressionMode.Decompress);
                }

                if (streamToRead != null)
                    using (StreamReader streamReader = new StreamReader(streamToRead, Encoding.UTF8))
                    {
                        ret = streamReader.ReadToEnd();
                        ret = HttpUtility.HtmlDecode(ret);
                        return ret;
                    }
            }
            response.Close();
            return null;
        }

        public string GetCookieValue(string key)
        {
            string value = null;
            var cookies = GetCookies();
            foreach (var cookie in cookies)
            {
                if (cookie.Name.ToUpper().Trim().Equals(key.ToUpper().Trim()))
                {
                    value = cookie.Value;
                    break;
                }
            }
            return value;
        }

        public List<Cookie> GetCookies()
        {
            var cookies = new List<Cookie>();

            var table = (Hashtable)cookieContainer.GetType().InvokeMember("m_domainTable",
                BindingFlags.NonPublic |
                BindingFlags.GetField |
                BindingFlags.Instance,
                null,
                cookieContainer,
                null);

            foreach (string key in table.Keys)
            {
                var item = table[key];
                var items = (ICollection)item.GetType().GetProperty("Values").GetGetMethod().Invoke(item, null);
                foreach (CookieCollection cc in items)
                {
                    foreach (Cookie cookie in cc)
                    {
                        cookies.Add(cookie);
                    }
                }
            }

            return cookies;
        }
    }
}
