namespace TacosAPI.Models.Dto
{
    public class CreateDrinkDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Cost { get; set; }

        public bool Slushie { get; set; }
    }
}
