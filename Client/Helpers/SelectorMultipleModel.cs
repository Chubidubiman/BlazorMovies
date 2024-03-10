namespace BlazorMovies.Client.Helpers
{
    public class SelectorMultipleModel
    {
        public SelectorMultipleModel(string key, string valor)
        {
            Key = key;
            Valor = valor;
        }
        public string Key { get; set; }
        public string Valor { get; set; }
    }
}