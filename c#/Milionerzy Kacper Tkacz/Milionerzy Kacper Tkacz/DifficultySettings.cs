using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    public abstract class DifficultySettings
    {
        public abstract int DifficultyLevel();
        public abstract int Time();
        public abstract int Lives();
    }
}
