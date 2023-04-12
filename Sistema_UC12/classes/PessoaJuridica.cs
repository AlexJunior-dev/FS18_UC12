using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_UC12.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }
    
    }
}