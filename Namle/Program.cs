using System;

using System.Net;
using System.IO;

using Newtonsoft.Json;

namespace Namle
{
    class Program

    {

        static String BASE_URL = "https://namle.tranty9597.now.sh/api/casps";

        static void Main(string[] args)
        {
            AbcModel abc = new AbcModel("1212", "fsdafsadf", "fasdfsad");

            Console.WriteLine(CreateAbc(abc));

            Console.WriteLine(GetAbc("1212").toString());
        }


        static String CreateAbc(AbcModel model)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(BASE_URL + "/addValue");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

              

                string json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }


        }

        static AbcModel GetAbc(string path)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(BASE_URL + "/getValue?a=" + path);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();

                try
                {
                    ResultModel res = JsonConvert.DeserializeObject<ResultModel>(result);

                    return res.value ?? new AbcModel();
                }catch(Exception ex)
                {
                    return new AbcModel("error", "error", ex.ToString());
                }
              
            }
        }
    }
}
