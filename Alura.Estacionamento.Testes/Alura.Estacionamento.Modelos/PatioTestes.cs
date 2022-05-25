using System;
using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Testes.Alura.Estacionamento.Modelos
{
    public class PatioTestes
    {
        public PatioTestes()
        {
        }

        [Fact]
        public void ValidaFaturamento()
        {
            var estacionamento = new Patio();
            var veiculo = new Veiculo
            {
                Proprietario = "Xoão",
                Tipo = TipoVeiculo.Automovel,
                Cor = "Azul",
                Modelo = "Fuscão",
                Placa = "AAA-9999"
            };

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            double faturamento = estacionamento.TotalFaturado();

            Assert.Equal(2, faturamento);
        }
    }
}
