public class Fracao
{
    private int _numerador;
    private int _denominador;
    private int _mdc;

    public override string ToString()
    {
        return $"{_numerador}/{_denominador}";
    }

    public Fracao(string fracao) : this(
      int.Parse(fracao.Split("/")[0]), //Numerador
      int.Parse(fracao.Split("/")[1])) { } //Denominador

    public Fracao(double fracao) : this(
        (int)(fracao * Math.Pow(10, fracao.ToString().Split(',')[1].Length)), //Numerador
        (int)Math.Pow(10, fracao.ToString().Split(",")[1].Length)) { } //Denominador
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
    public Fracao Somar(Fracao outra)
    {
        return new Fracao(outra._denominador * _denominador / _denominador * _numerador + outra._denominador * _denominador / outra._denominador * outra._numerador,
        outra._denominador * _denominador);
    }

    public Fracao Somar(int inteiro)
    {
        return new Fracao(_numerador + inteiro * _denominador, _denominador);
    }

    public static Fracao operator +(Fracao b, double fracao)
    {
        var numerador = (int)(fracao * Math.Pow(10, fracao.ToString().Split(',')[1].Length));
        var denominador = (int)Math.Pow(10, fracao.ToString().Split(",")[1].Length);
        return new Fracao(denominador * b._denominador / denominador * numerador + denominador * b._denominador / b._denominador * b._numerador,
        denominador * b._denominador);
        // return new Fracao(numerador, denominador);
        
    }

    public static Fracao operator +(Fracao b, string fracao)
    {
        var numerador = int.Parse(fracao.Split("/")[0]); //Numerador
        var denominador = int.Parse(fracao.Split("/")[1]); //Denominador
        return new Fracao(denominador * b._denominador / denominador * numerador + denominador * b._denominador / b._denominador * b._numerador,
        denominador * b._denominador);
    }

    public static Fracao operator +(Fracao b, int inteiro)
    {
        return new Fracao(b._numerador + inteiro * b._denominador, b._denominador);
    }

    public static Fracao operator +(Fracao a, Fracao b)
    {
        return new Fracao(a._denominador * b._denominador / a._denominador * a._numerador + a._denominador * b._denominador / b._denominador * b._numerador,
        a._denominador * b._denominador);
    }

    public bool Equals(Fracao fracao)
    {
        if (fracao._numerador == _numerador && fracao._denominador == _denominador)
        {
            return true;
        } else {
            return false;
        }
    }

    public static bool operator ==(Fracao a, Fracao b) => a.Equals(b);
    public static bool operator !=(Fracao a, Fracao b) => !a.Equals(b);

    public static bool operator <(Fracao a, Fracao b) => a._numerador * b._denominador < b._numerador * a._denominador;
    public static bool operator >(Fracao a, Fracao b) => a._numerador * b._denominador > b._numerador * a._denominador;
    public static bool operator <=(Fracao a, Fracao b) => a._numerador * b._denominador <= b._numerador * a._denominador;
    public static bool operator >=(Fracao a, Fracao b) => a._numerador * b._denominador >= b._numerador * a._denominador;

    
    public bool IsImpropria => _numerador > _denominador;

    public bool IsPropria => _numerador < _denominador;

     public bool IsAparente => _numerador % _denominador == 0;

    public bool IsUnitaria => _numerador == 1;


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