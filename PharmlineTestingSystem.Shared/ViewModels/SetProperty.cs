namespace PharmlineTestingSystem.Shared.ViewModels
{
    public sealed class SetProperty<T1, T2>
    {
        public T1 Id { get; set; }
        public T2 Value { get; set; }

        public SetProperty() { }

        public SetProperty(T1 id, T2 value)
        {
            Id = id;
            Value = value;
        }
    }
}
