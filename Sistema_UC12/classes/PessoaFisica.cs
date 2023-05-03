using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Sistema_UC12.classes
{
    public class PessoaFisica : Pessoa
    {
       public string? cpf { get; set; }

       public string? rg { get; set; } 

       public DateTime dataNascimento { get; set; }

       public override void pagarImposto(float rendimento){

       }

       public bool validarDataNascimento(DateTime DataNasc){
            DateTime dataAtual = DateTime.Today;
        
            double anos = (dataAtual - dataNascimento).TotalDays / 365;


            if (anos >= 18){
                return true;   
            }else{
                return false;
            }
        }
    }
}