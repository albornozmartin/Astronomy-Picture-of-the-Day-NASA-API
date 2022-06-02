using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiNasa
{
    public class FotoDia
    {
        public string copyright { get; set; }
        public DateTime date { get; set; }
        public string explanation { get; set; }
        public string hdurl { get; set; }
        public string media_type { get; set; }
        public string service_version { get; set; }
        public string title { get; set; }
        public string url { get; set; }


        public FotoDia() { }



        const string rutaUri = "https://api.nasa.gov/planetary/apod?";
        const string key = "YfIpKfStznojqyRRfGwnzDCMGDsQUzt078CVdTA2";


        public async Task<FotoDia> getFotoDiaAsync()
        {
            string ruta2 = String.Format("{0}api_key={1}", rutaUri, key);  //la uri para la consulta 
            HttpClient httpClient2 = new HttpClient();// creo un nuevo HttpClient para realizar la consulta
            FotoDia elementoNuevo = JsonSerializer.Deserialize<FotoDia>(await httpClient2.GetStringAsync(ruta2)); //deserealizo el json que viene y lo transformo en un objeto FotoDia
            return elementoNuevo;
        }

        public async Task<FotoDia> getDiaEspecificoAsync(string unaFecha)
        {
            string ruta2 = String.Format("{0}api_key={1}&date={2}", rutaUri, key, unaFecha); // ruta 
            HttpClient httpClient = new HttpClient();
            FotoDia elementoNuevo = JsonSerializer.Deserialize<FotoDia>(await httpClient.GetStringAsync(ruta2));
            return elementoNuevo;
        }


    }
}
