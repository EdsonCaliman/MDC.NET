using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO4
{
    class ControleRemoto
    {
        private Televisao Televisao;

        public ControleRemoto()
        {
            Televisao = new Televisao();
        }

        public void AumentarVolume()
        {
            ++Televisao.Volume;
        }

        public void DiminuirVolume()
        {
            --Televisao.Volume;
        }

        public void AumentarCanal()
        {
            ++Televisao.Canal;
        }

        public void DiminuirCanal()
        {
            --Televisao.Canal;
        }

        public void DefinirCanal(int canal)
        {
            Televisao.Canal = canal;
        }

        public string ConsultarCanal()
        {
            return Televisao.Canal.ToString();
        }

        public string ConsultarVolume()
        {
            return Televisao.Volume.ToString();
        }
    }
}
