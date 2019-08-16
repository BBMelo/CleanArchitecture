using Newtonsoft.Json;

namespace vxTel.Adapter.Application.ViewModel
{
    public class FaleMaisViewModel
    {        
        [JsonProperty("ddd_origem")]
        public int CodigoOrigem { get; set; }
        [JsonProperty("ddd_destino")]
        public int CodigoDestino { get; set; }
        [JsonProperty("tempo_ligacao")]
        public int TempoLigacao { get; set; }
        [JsonProperty("codigo_plano_falemais")]
        public int PlanoFaleMais { get; set; }
        [JsonProperty("nome_plano_falemais")]
        public string PlanoFaleMaisLabel { get; set; }
        [JsonProperty("tarifa_com_plano")]
        public string CustoComPlano { get; set; }
        [JsonProperty("tarifa_sem_plano")]
        public string CustoSemPlano { get; set; }        
    }
}