

namespace ParcialDotnet.Models
{

    public class ApoyoInputModel
    {
        public string idApoyo { get; set; }
        public string modalidad { get; set; }
        public string fecha { get; set; }
        public string aporte { get; set; }

    }

    public class ApoyoViewModel : ApoyoInputModel
    {
        public ApoyoViewModel()
        {

        }
        public ApoyoViewModel(Apoyo apoyo)
        {
            idApoyo = apoyo.IdApoyo;
            modalidad = apoyo.modalidad;
            aporte = apoyo.Aporte;
            fecha = apoyo.fecha;
        }
    }

}