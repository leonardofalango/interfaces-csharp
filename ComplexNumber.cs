
public class ComplexNumber
{
    private float complexPart;
    private float floatPart;

    public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
    {
        ComplexNumber result = new ComplexNumber();
        result.floatPart = (num1.floatPart + num2.floatPart);
        result.complexPart = (num1.complexPart + num2.complexPart);
        return result;
    }

    public override string ToString()
    {
        return $"{this.floatPart} + {this.complexPart}i";
    }

    public static ComplexNumber Parse(string str)
    {
        ComplexNumber result = new ComplexNumber();
        result.floatPart = float.Parse(str.Substring(0, str.IndexOf("+")));
        result.complexPart = float.Parse(str.Substring(str.IndexOf("+")+1, str.LastIndexOf("i") - str.IndexOf("+") - 1));
        return result;
    }
}