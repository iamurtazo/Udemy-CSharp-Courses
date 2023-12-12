public class Nullable<T> where T : struct
{
    //In C# value types can not be null
    //In this class we give value type the ability of being nullable
    private object _value;

    public Nullable()
    {   
    }
    public Nullable(T value)
    {
        this._value = value;
    }

    public bool HasValue
    {
        get { return _value != null; }
    }
    public T GetValueOrDefault()
    {
        if (HasValue)
            return (T)_value;
        return default(T);
    }
}