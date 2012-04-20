// Type: BoletoNet.Boleto
// Assembly: Boleto.Net, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Projetos\Boleto.Net\Boleto.Net.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BoletoNet
{
    [Browsable(false)]
    [Serializable]
    public class Boleto
    {
        public Boleto();
        public Boleto(DateTime dataVencimento, double valorBoleto, string carteira, string nossoNumero, Cedente cedente, EspecieDocumento especieDocumento);
        public Boleto(double valorBoleto, string carteira, string nossoNumero, Cedente cedente);
        public Boleto(DateTime dataVencimento, double valorBoleto, string carteira, string nossoNumero, Cedente cedente);
        public Boleto(DateTime dataVencimento, double valorBoleto, string carteira, string nossoNumero, string agencia, string conta);
        public void Valida();
        public void FormataCampos();
        public int Categoria { get; set; }
        public string Carteira { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorBoleto { get; set; }
        public List<IInstrucao> Instrucoes { get; set; }
        public string LocalPagamento { get; set; }
        public int QuantidadeMoeda { get; set; }
        public string ValorMoeda { get; set; }
        public string Aceite { get; set; }
        public string Especie { get; set; }
        public IEspecieDocumento EspecieDocumento { get; set; }
        public DateTime DataDocumento { get; set; }
        public DateTime DataProcessamento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NossoNumero { get; set; }
        public int Moeda { get; set; }
        public Cedente Cedente { get; set; }
        public CodigoBarra CodigoBarra { get; }
        public IBanco Banco { get; set; }
        public ContaBancaria ContaBancaria { get; set; }
        public double ValorDesconto { get; set; }
        public Sacado Sacado { get; set; }
        public string UsoBanco { get; set; }
        public double JurosMora { get; set; }
        public double IOF { get; set; }
        public double Abatimento { get; set; }
        public double ValorMulta { get; set; }
        public double OutrosAcrescimos { get; set; }
        public double OutrosDescontos { get; set; }
        public DateTime DataJurosMora { get; set; }
        public DateTime DataMulta { get; set; }
        public DateTime DataDesconto { get; set; }
        public DateTime DataOutrosAcrescimos { get; set; }
        public DateTime DataOutrosDescontos { get; set; }
        public string TipoModalidade { get; set; }
    }
}
