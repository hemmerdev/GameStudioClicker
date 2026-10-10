namespace GameStudioClicker.Core.Models
{
    public class StudioLocation
    {
        public string Id { get; }
        public string DisplayName { get; }
        public int RequiredLevel { get; }
        public long RelocationCost { get; }
        public IReadOnlyList<string> AvailableWorkerIds { get; }

        public StudioLocation(
            string id, string displayName, int requiredLevel,
            long relocationCost, IReadOnlyList<string> availableWorkerIds)
        {
            Id = id;
            DisplayName = displayName;
            RequiredLevel = requiredLevel;
            RelocationCost = relocationCost;
            AvailableWorkerIds = availableWorkerIds;
        }
    }
}
