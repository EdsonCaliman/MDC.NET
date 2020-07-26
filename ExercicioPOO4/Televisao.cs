using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO4
{
    class Televisao
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
    }
}
