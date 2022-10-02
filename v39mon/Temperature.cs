namespace v39mon;

internal class Temperature
{
    private float _tempInCelcius;

    public float Celcius
    {
        get => _tempInCelcius;
        set => _tempInCelcius = value;
    }

    public float Farenheit
    {
        get => (_tempInCelcius * 9 / 5) + 32;
        set => _tempInCelcius = (value - 32) * 5/9;
    }

    public float Kelvin
    {
        get => _tempInCelcius + 237.15f;
        set => _tempInCelcius = value - 273.15f;
    }
    
    public Temperature(float celcius = 0)
    {
        _tempInCelcius = celcius;
    }
}
