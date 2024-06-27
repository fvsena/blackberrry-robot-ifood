using Blackberry.Robots.IFood.Helpers;
using Blackberry.Robots.IFood.Response;
using Blackberry.Robots.IFood.Result;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Blackberry.Robots.IFood.Request
{
    internal class ConsultaProdutosRequest : BaseRequest
    {
        internal ConsultaProdutosResult ConsultaProdutos(string url)
        {
            var result = new ConsultaProdutosResult();
            try
            {
                var html = HtmlConsultaProdutos(url);
                if (html != null)
                {
                    var scripts = html.GetElementsByTagName("script");
                    if (scripts != null)
                    {
                        var scriptData = html.GetElementByProperty(scripts, "id", "__NEXT_DATA__");
                        if (scriptData != null)
                        {
                            var json = scriptData.InnerHtml;
                            var response = JsonConvert.DeserializeObject<ConsultaProdutosResponse>(json);
                            if (response != null)
                            {
                                var id = response.Props.InitialState.Restaurant.Cache.CacheProperty.Uuid.ToString();
                                if (!string.IsNullOrEmpty(id))
                                {
                                    var lista = ConsultaListaProdutos(url, id);
                                    if (lista != null)
                                    {
                                        foreach (var categoria in lista.Data.Menu)
                                        {
                                            foreach (var item in categoria.Itens)
                                            {
                                                result.Produtos.Add(item);
                                            }
                                        }
                                        result.ProccessOk = true;
                                    }
                                    else
                                    {
                                        result.ProccessOk = false;
                                        result.Msg = "A lista de produtos veio vazia";
                                    }
                                }
                                else
                                {
                                    result.ProccessOk = false;
                                    result.Msg = "Não foi possível localizar o ID da loja";
                                }
                            }
                            else
                            {
                                result.ProccessOk = false;
                                result.Msg = "Não foi possível realizar a deserialização do objeto NEXT_DATA";
                            }
                        }
                        else
                        {
                            result.ProccessOk = false;
                            result.Msg = "Não foi possível localizar o elemento NEXT_DATA na lista de scripts";
                        }
                    }
                    else
                    {
                        result.ProccessOk = false;
                        result.Msg = "Não foi possível localizar os elementos scripts da página";
                    }
                }
                else
                {
                    result.ProccessOk = false;
                    result.Msg = "Não foi possível carregar a tela da loja";
                }
            }
            catch (Exception ex)
            {
                result.ProccessOk = false;
                result.MsgCatch = ex.Message;
            }
            return result;
        }

        private HtmlHelper HtmlConsultaProdutos(string url)
        {
            HttpWebResponse response;
            HtmlHelper html = null;

            if (Request_Loja(url, out response))
            {
                var responseText = GetResponseBody(response);
                html = new HtmlHelper(responseText);
                response.Close();
            }
            return html;
        }

        private ListaProdutos ConsultaListaProdutos(string url, string id)
        {
            HttpWebResponse response;
            ListaProdutos lista = null;

            if (Request_ListaProdutos(url, id, out response))
            {
                var responseText = GetResponseBody(response);
                lista = JsonConvert.DeserializeObject<ListaProdutos>(responseText);
                response.Close();
            }
            return lista;
        }

        private bool Request_Loja(string url, out HttpWebResponse response)
        {
            response = null;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.KeepAlive = true;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.Headers.Set(HttpRequestHeader.CacheControl, "max-age=0");
                request.Headers.Add("Upgrade-Insecure-Requests", @"1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.Headers.Add("Service-Worker-Navigation-Preload", @"true");
                request.Headers.Add("Sec-Fetch-Site", @"same-origin");
                request.Headers.Add("Sec-Fetch-Mode", @"navigate");
                request.Headers.Add("Sec-Fetch-User", @"?1");
                request.Headers.Add("Sec-Fetch-Dest", @"document");
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
                request.CookieContainer = cookieContainer;

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private bool Request_ListaProdutos(string url, string id, out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://wsloja.ifood.com.br/ifood-ws-v3/restaurants/{id}/menu");

                request.KeepAlive = true;
                request.Headers.Add("access_key", @"69f181d5-0046-4221-b7b2-deef62bd60d5");
                request.Headers.Add("browser", @"Windows");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=1");
                request.Headers.Set(HttpRequestHeader.Authorization, $"Bearer {GetCookieValue("aAccessToken")}");
                request.Headers.Add("gps-latitude", @"-23.5391522");
                request.Accept = "application/json, text/plain, */*";
                request.Headers.Add("secret_key", @"9ef4fb4f-7a1d-4e0d-a9b1-9b82873297d8");
                request.Headers.Set(HttpRequestHeader.CacheControl, "no-cache, no-store");
                request.Headers.Add("X-Ifood-Session-Id", $"{GetCookieValue("aSessionId")}");
                request.Headers.Add("gps-longitude", @"-46.5258993");
                request.Headers.Add("platform", @"Desktop");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Headers.Add("app_version", @"8.18.0");
                request.Headers.Add("Origin", @"https://www.ifood.com.br");
                request.Headers.Add("Sec-Fetch-Site", @"same-site");
                request.Headers.Add("Sec-Fetch-Mode", @"cors");
                request.Headers.Add("Sec-Fetch-Dest", @"empty");
                request.Referer = url;
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        #region INICIO

        private bool Inicio_1(out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.ifood.com.br/");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.CookieContainer = cookieContainer;

                request.KeepAlive = true;
                request.Headers.Add("Upgrade-Insecure-Requests", @"1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.Headers.Add("Purpose", @"prefetch");
                request.Headers.Add("Sec-Fetch-Site", @"none");
                request.Headers.Add("Sec-Fetch-Mode", @"navigate");
                request.Headers.Add("Sec-Fetch-User", @"?1");
                request.Headers.Add("Sec-Fetch-Dest", @"document");
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private bool Inicio_2(string url, out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.CookieContainer = cookieContainer;
                request.KeepAlive = true;
                request.Headers.Add("Upgrade-Insecure-Requests", @"1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.Headers.Add("Sec-Fetch-Site", @"none");
                request.Headers.Add("Sec-Fetch-Mode", @"navigate");
                request.Headers.Add("Sec-Fetch-User", @"?1");
                request.Headers.Add("Sec-Fetch-Dest", @"document");
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private bool Inicio_3(string url, string id, string accessKey, string secretKey, string xIfoodSessionId, out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://wsloja.ifood.com.br/ifood-ws-v3/restaurants/{id}/menu");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.CookieContainer = cookieContainer;
                request.KeepAlive = true;
                request.Headers.Add("access_key", accessKey);
                request.Headers.Add("browser", @"Windows");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Headers.Add("gps-latitude", @"");
                request.Accept = "application/json, text/plain, */*";
                request.Headers.Add("secret_key", secretKey);
                request.Headers.Set(HttpRequestHeader.CacheControl, "no-cache, no-store");
                request.Headers.Add("X-Ifood-Session-Id", xIfoodSessionId);
                request.Headers.Add("gps-longitude", @"");
                request.Headers.Add("platform", @"Desktop");
                request.Headers.Add("app_version", @"8.18.0");
                request.Headers.Add("Origin", @"https://www.ifood.com.br");
                request.Headers.Add("Sec-Fetch-Site", @"same-site");
                request.Headers.Add("Sec-Fetch-Mode", @"cors");
                request.Headers.Add("Sec-Fetch-Dest", @"empty");
                request.Referer = url;
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private bool Inicio_4(string url, string id, string xIfoodSessionId, out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://marketplace.ifood.com.br/v1/merchants/{id}/extra");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.CookieContainer = cookieContainer;
                request.KeepAlive = true;
                request.Headers.Add("browser", @"Windows");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Headers.Add("gps-latitude", @"");
                request.Accept = "application/json, text/plain, */*";
                request.Headers.Set(HttpRequestHeader.CacheControl, "no-cache, no-store");
                request.Headers.Add("X-Ifood-Session-Id", xIfoodSessionId);
                request.Headers.Add("gps-longitude", @"");
                request.Headers.Add("platform", @"Desktop");
                request.Headers.Add("app_version", @"8.18.0");
                request.Headers.Add("Origin", @"https://www.ifood.com.br");
                request.Headers.Add("Sec-Fetch-Site", @"same-site");
                request.Headers.Add("Sec-Fetch-Mode", @"cors");
                request.Headers.Add("Sec-Fetch-Dest", @"empty");
                request.Referer = url;
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private bool Inicio_5(string url, string id, string accessKey, string secretKey, string xIfoodSessionId, out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://wsloja.ifood.com.br/ifood-ws-v3/restaurant/evaluations/list?filterJson=%7B%22restaurantUuid%22:%22{id}%22,%22page%22:1,%22pageSize%22:30,%22visible%22:true%7D");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.CookieContainer = cookieContainer;
                request.KeepAlive = true;
                request.Headers.Add("access_key", accessKey);
                request.Headers.Add("browser", @"Windows");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Headers.Add("gps-latitude", @"");
                request.Accept = "application/json, text/plain, */*";
                request.Headers.Add("secret_key", secretKey);
                request.Headers.Set(HttpRequestHeader.CacheControl, "no-cache, no-store");
                request.Headers.Add("X-Ifood-Session-Id", xIfoodSessionId);
                request.Headers.Add("gps-longitude", @"");
                request.Headers.Add("platform", @"Desktop");
                request.Headers.Add("app_version", @"8.18.0");
                request.Headers.Add("Origin", @"https://www.ifood.com.br");
                request.Headers.Add("Sec-Fetch-Site", @"same-site");
                request.Headers.Add("Sec-Fetch-Mode", @"cors");
                request.Headers.Add("Sec-Fetch-Dest", @"empty");
                request.Referer = url;
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private bool Inicio_6(out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.ifood.com.br/offline");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.CookieContainer = cookieContainer;
                request.KeepAlive = true;
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36";
                request.Accept = "*/*";
                request.Headers.Add("Sec-Fetch-Site", @"same-origin");
                request.Headers.Add("Sec-Fetch-Mode", @"cors");
                request.Headers.Add("Sec-Fetch-Dest", @"empty");
                request.Referer = "https://www.ifood.com.br/service-worker.js";
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private bool Inicio_7(string authorization, out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://pos-api.ifood.com.br/v2.0/merchants");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.CookieContainer = cookieContainer;
                request.KeepAlive = true;
                request.Accept = "application/json";
                request.Headers.Add("Origin", @"https://gestordepedidos.ifood.com.br");
                request.Headers.Set(HttpRequestHeader.Authorization, $"bearer {authorization}");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) GestordePedidos/6.0.1 Chrome/76.0.3809.146 Electron/6.0.12 Safari/537.36";
                request.Headers.Add("Sec-Fetch-Mode", @"cors");
                request.Headers.Add("Sec-Fetch-Site", @"same-site");
                request.Referer = "https://gestordepedidos.ifood.com.br/";
                request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
                request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR");

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        #endregion
    }
}
