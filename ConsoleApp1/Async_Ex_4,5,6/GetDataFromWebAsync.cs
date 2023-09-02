using System;
using System.Net.Http;

public static class GetDataFromWebAsync
{
    public static void GetURL(string url)
    {

        HttpClient httpClient = new HttpClient();

        try
        {
            HttpResponseMessage response = httpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Response content length: " + content.Length);
                Console.WriteLine("Content: " + content);
            }
            else
            {
                Console.WriteLine("Request failed with status code: " + response.StatusCode);
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("Request error: " + ex.Message);
        }
        finally
        {
            httpClient.Dispose();
        }
    }
}