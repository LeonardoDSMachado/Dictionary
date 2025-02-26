using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Dictionary;

internal class Aluno
{
    public string? Name { get; set; }
    public int Nota { get; set; }

    public override string ToString()
    {
        return $"Nome: {Name}, Nota: {Nota}";
    }
}
