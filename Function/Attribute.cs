namespace Function
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class GenericController : Attribute
    {
        public string NameController;
        public string NameDbSet;

        public GenericController() { }

        public GenericController(string nameController)
        {
            NameController = nameController;
        }

        public GenericController(string nameController, string nameDbSet)
        {
            NameController = nameController;
            NameDbSet = nameDbSet;
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IncludeAttribute : Attribute
    {
        public IncludeAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ColocaNaViewBagAttribute : Attribute
    {
        public ColocaNaViewBagAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IgnoreOnUpdateAttribute : Attribute
    {
        public IgnoreOnUpdateAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IgnoreOnInsertAttribute : Attribute
    {
        public IgnoreOnInsertAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IncludeOnUpdateAttribute : Attribute
    {
        public IncludeOnUpdateAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IncludeOnDeleteAttribute : Attribute
    {
        public IncludeOnDeleteAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class IgnoreLog : Attribute
    {
        public IgnoreLog() { }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class LogChanges : Attribute
    {
        public LogChanges() { }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class FiltroAttribute : Attribute
    {
        public FiltroAttribute() { }
        public string Display { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class MaskAttribute : Attribute
    {
        private const string _Name = "data-val-mask";

        public string Name { get { return _Name; } }

        public object Value { get; private set; }

        public MaskAttribute() { }
        public MaskAttribute(object value)
        {
            Value = value;
        }
    }
}