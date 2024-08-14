namespace TacosAPI.Models.Dto
{
    public class UpdateTacoDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Cost { get; set; }

        public bool SoftShell { get; set; }

        public bool Chips { get; set; }
    }
}
