namespace ExercicioPOO4
{
    class ControleRemoto
    {
        private ITelevisao Televisao;

        public ControleRemoto(ITelevisao televisao)
        {
            Televisao = televisao;
        }

        public void AumentarVolume()
        {
            Televisao.AumentarVolume();
        }

        public void DiminuirVolume()
        {
            Televisao.DiminuirVolume();
        }

        public void AumentarCanal()
        {
            Televisao.AumentarCanal();
        }

        public void DiminuirCanal()
        {
            Televisao.DiminuirCanal();
        }

        public void DefinirCanal(int canal)
        {
            Televisao.DefinirCanal(canal);
        }

        public string ConsultarCanal()
        {
            return Televisao.ConsultarCanal();
        }

        public string ConsultarVolume()
        {
            return Televisao.ConsultarVolume();
        }

    }
}
