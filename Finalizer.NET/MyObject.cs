using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizer.NET
{
    class MyObject
    {
        private int _index;

        public MyObject(int index)
        {
            int instanceGen = GC.GetGeneration(this);
            _index = index;
            Console.WriteLine($"Processo inicializado {_index} alocado na geraçção {instanceGen}");
        }

        //Operador que finaliza a instancia, é o ao contrario de um construtor, um destruidor
        ~MyObject()
        {
            int instanceGen = GC.GetGeneration(this);
            Console.WriteLine($"Instancia finalizada {_index} na geração {instanceGen}");
        }

        //Falhas no Finalizer do .NET.
        //1 - Finalizers é chamado de forma aleatória.
        //2 - Objetos com finalizers sempre terminam na geração 1 e as vezes na geração 2.
        //3 - Quando o processo é terminado, algumas chamadas do mesmo não são efetuadas, devido o .NET dar 4s para a thread que contém a fila de chamadas do finalizers
        //  Terminar seu processo.
        //4 - É ruim utilizar o Finalizer em objetos pequenos que contém uma vida de pequena duração. Devido o GarbageCollector interpreta-lo como um objeto de longa duração

    }   
}
