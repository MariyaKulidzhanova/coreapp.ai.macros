namespace CoreApp.Ai.Macros.Models
{
    public class UObject
    {
        public string Id { get; set; }
        public string Action { get; set; }
        public Dictionary<string, int> Parameters { get; set; } = new Dictionary<string, int>();

        public void SetVelocity(int velocity)
        {
            Parameters["velocity"] = velocity;
        }

        public void RemoveVelocity()
        {
            Parameters.Remove("velocity");
        }
    }
}