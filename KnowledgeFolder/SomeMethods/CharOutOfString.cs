class CharOutOfString 
{
    public CharOutOfString(string value)
    {
        this.Value = value;
    }

    public void MyChar()
    {
        Console.WriteLine(Value[0]);
    }

    public string Value { get; set; }
}