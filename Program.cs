using System;

namespace GestaoProcessosJuridicosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Gestão de Processos Jurídicos");
        }
    }
}
public enum FaseProcesso
{
    Inicial = 1,
    Instrucao,
    Decisao,
    Recurso,
    Arquivado
}

public class Processo
{
    public int Id { get; set; }
    public string NumeroProcesso { get; set; }
    public string ParteAutora { get; set; }
    public string ParteRē { get; set; }
    public string Area { get; set; }
    public FaseProcesso Fase { get; set; }
    public DateTime DataAbertura { get; set; }

    public Processo(int id, string numeroProcesso, string parteAutora, string parteRe, string area)
    {
        Id = id;
        NumeroProcesso = numeroProcesso;
        ParteAutora = parteAutora;
        ParteRē = parteRe;
        Area = area;
        Fase = FaseProcesso.Inicial;
        DataAbertura = DateTime.Now;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Nº: {NumeroProcesso} | Área: {Area} | Autor: {ParteAutora} vs Réu: {ParteRē} | Fase: {Fase} | Data: {DataAbertura:dd/MM/yyyy}";
    }
}