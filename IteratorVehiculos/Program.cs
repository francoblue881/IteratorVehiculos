using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorVehiculos
{
  class Program
  {
    static void Main(string[] args)
    {

      IRegistroVehiculos reg = new RegistroVehiculos();

      reg.InsertarVehiculo("Mazda","3",12000);
      reg.InsertarVehiculo("Ferrary", "Mux", 55000);
      reg.InsertarVehiculo("BMW", "SkyNight", 24000);


      IIteratorVehiculo iterator = reg.ObtenerIterator();
      while (iterator.QuedanElementos() )
      {
        Vehiculo v = iterator.Siguiente();
        Console.WriteLine(v.Marca + " "
          + v.Modelo + " fabricado el " + 
          v.FechaFabricacion.ToShortDateString() + 
          " (" + v.Precio + " euros)");
      }
      
      Console.ReadLine();

    }
  }
}
