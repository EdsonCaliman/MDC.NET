namespace ExercicioPOO4
{
    interface ITelevisao
    {
        public void AumentarVolume();

        public void DiminuirVolume();

        public void AumentarCanal();

        public void DiminuirCanal();

        public void DefinirCanal(int canal);

        public string ConsultarCanal();

        public string ConsultarVolume();
    }
}
