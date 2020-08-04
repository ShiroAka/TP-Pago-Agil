using PagoAgil.Model;

namespace PagoAgil.ViewModels
{
    public class AreasViewVM
    {
        public AreasViewVM()
        { }

        public void CreateNewArea(string areaName)
        {
            Rubro area = new Rubro();
            area.Nombre = areaName;

            DatabaseAccess.CreateNewArea(area);
        }
    }
}
