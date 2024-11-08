namespace Temperatura.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private double _temperaturaFahrenheit;
    private double _temperaturaCelsius;
    private double _temperaturaKelvin;

    // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

    [Given("que o valor da temperatura e de {double} graus Fahrenheit")]
    public void PreencherTemperaturaFahrenheit(double valorFahrenheit)
    {
        _temperaturaFahrenheit = valorFahrenheit;
    }


    [When("eu solicitar a conversao desta teperatura")]
    public void ProcessarConversao()
    {
        _temperaturaCelsius =
            ConversorTemperatura.FahrenheitParaCelsius(
                _temperaturaFahrenheit);
        _temperaturaKelvin =
            ConversorTemperatura.FahrenheitParaKelvin(
                _temperaturaFahrenheit);
    }

    [Then("o resultado da conversao para Celsius sera de {double} graus")]
    public void ValidarResultadoCelsius(double valorCelsius)
    {
        _temperaturaCelsius.Should().Be(valorCelsius);
    }

    [Then("o resultado da conversao para Kelvin sera de {double} graus")]
    public void ValidarResultadoKelvin(double valorKelvin)
    {
        _temperaturaKelvin.Should().Be(valorKelvin);
    }
}