using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor
{
    abstract class motor
    {
        protected string merk;

        public abstract void kondisi();
    }

    interface iDesc
    {
        void desc()
        {

        }
    }
}
