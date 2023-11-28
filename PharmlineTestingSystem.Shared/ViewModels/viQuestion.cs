using System.Collections.Generic;

namespace PharmlineTestingSystem.Shared.ViewModels
{
    public sealed class viQuestion
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public bool IsOpen { get; set; }
        public List<viOption> Options { get; set; }
    }
}
