public class Fracao
{
    private int _numerador;
    private int _denominador;
    private int _mdc;
    
    public override string ToString()
    {
        return $"{_numerador}/{_denominador}";
    }

    public Fracao(string fracao) :
        this(int.Parse(fracao.Split("/")[0]),
        int.Parse(fracao.Split("/")[1])) { }
    public Fracao(int Numerador, int Denominador)
    {
        _numerador = Numerador;
        _denominador = Denominador;
        for (var c = _numerador; c > 1; c--)
        {
            if (_denominador % c == 0 && _numerador % c == 0)
            {
                _mdc = c;
                _numerador = _numerador / _mdc;
                _denominador = _denominador / _mdc;
            }
        }
    }
    
    public Fracao(int Numerador)
    {
        _numerador = Numerador;
        _denominador = 1;
    }

    public int Numerador
    {
        get
        {
            return _numerador;
        }
    }
    public int Denominador
    {
        get
        {
            return _denominador;
        }
    }
}