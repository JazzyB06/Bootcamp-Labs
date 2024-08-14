namespace TacosAPI.Models.Dto
{
    public class UpdateDrinkDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Cost { get; set; }

        public bool Slushie { get; set; }
    }
}
