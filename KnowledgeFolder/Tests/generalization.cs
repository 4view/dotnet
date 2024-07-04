class Person<T>
{
    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public T Id { get; set; }
    public string Name { get; set; }
}