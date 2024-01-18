using Model;
using System.Net;

namespace appDemostracion.Services
{
    public class PersonService
    {
        public PersonService() {}
        private readonly HttpClient httpClient;

        public PersonService(HttpClient client)
        {
            this.httpClient = client;
        }

        public async Task<List<Person>> GetPersons()
        {
            var response = await httpClient.GetAsync("demoController/Person");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var data = await response.Content.ReadFromJsonAsync<List<Person>>();
                return data;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
