using System;
using System.Linq;

namespace Utilitario
{
    public class Matematica
    {
        public long Somatorio(params int[] list)
        {
            if (list == null || list.Length == 0)
                throw new ArgumentNullException("Nenhum valor informado para soma.");

            return list.Sum();
        }
    }
}
