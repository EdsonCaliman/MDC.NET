namespace ExercicioPOO4
{
    class Televisao : ITelevisao
    {
        private int _canal;
        public int Canal 
        { get => _canal;
          set
            {
                if (value > 0)
                {
                    _canal = value;
                }
            }
        }
        private int _volume;
        public int Volume 
        { get => _volume;
            set
            {
                if (value >= 0)
                {
                    _volume = value;
                }
            }

        }

        public Televisao()
        {
            this._canal = 1;
            this._volume = 0;
        }

        public void AumentarVolume()
        {
            ++Volume;
        }

        public void DiminuirVolume()
        {
            --Volume;
        }

        public void AumentarCanal()
        {
            ++Canal;
        }

        public void DiminuirCanal()
        {
            --Canal;
        }

        public void DefinirCanal(int canal)
        {
            Canal = canal;
        }

        public string ConsultarCanal()
        {
            return Canal.ToString();
        }

        public string ConsultarVolume()
        {
            return Volume.ToString();
        }
    }
}
