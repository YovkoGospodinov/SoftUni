namespace _06.BirthdayCelebrations
{
    public class Robot : IIdentifable
    {
        private string id;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Id { get; private set; }

        public string Model { get; private set; }
    }
}