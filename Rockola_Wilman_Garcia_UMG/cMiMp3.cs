using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
namespace WindowsFormsApplication1
{
    class cMiMp3
    {
        Boolean bEnproduccion;

        public void SetEnproduccion(Boolean mensage) {
            bEnproduccion = mensage;

        }

        public Boolean GetEnproduccion() {
            return bEnproduccion;
        }

    }
}
