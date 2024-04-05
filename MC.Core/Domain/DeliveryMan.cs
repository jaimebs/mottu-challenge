namespace MC.Core.Domain
{
    public class DeliveryMan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public DateTime BirthDate { get; set; }
        public string CnhNumber { get; set; }
        public string TypeCnh { get; set; }
        public string? ImagemCnh { get; set; }
    }
}
