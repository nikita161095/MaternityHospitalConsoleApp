using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MaternityHospitalConsoleApp
{
    internal class Features
    {
        private const string Url = "https://localhost:44350/Patients";
        private static Random random = new Random();

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
            return client;
        }

        public async Task<string?> CreatePatients()
        {
            HttpClient client = GetClient();
            var response = await client.PostAsync(Url,
                new StringContent(
                    JsonSerializer.Serialize(GeneratePatients()),
                    Encoding.UTF8, "application/json"));

            if (response.StatusCode != HttpStatusCode.OK)
                return null;
            return "Ok";
        }

        private PatientCommand GeneratePatients()
        {
            return new PatientCommand
            {
                Name = new Name
                {
                    Use = RandomString(6),
                    Family = RandomString(6),
                    Given = RandomString(6)
                },
                Gender = random.Next(1, 5),
                BirthDate = DateTime.Now,
                Active = random.NextDouble() >= 0.5
            };
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
