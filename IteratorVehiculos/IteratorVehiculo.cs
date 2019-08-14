
namespace IteratorVehiculos
{
  using System;
  using System.Collections;

  public class IteratorVehiculo : IIteratorVehiculo
  {
    //ref al listado completo
    private ArrayList vehiculos;

    //almacenar el indice  en el que se encuentra el iterador
    private int posicionActual = -1;

    //ctor que inyectara el arreglo en el objeto
    public IteratorVehiculo(ArrayList listado)
    {
      this.vehiculos = listado;
    }

    public Vehiculo Actual()
    {
      if ((this.vehiculos == null) || (this.vehiculos.Count == 0) || (posicionActual > this.vehiculos.Count - 1) || (this.posicionActual < 0))
      {
        return null;
        //return "VACIO";

      }
      else { return (Vehiculo)this.vehiculos[posicionActual]; }

    }

    public void Primero()
    {
      this.posicionActual = -1;
    }

    public bool QuedanElementos()
    {
      return (posicionActual + 1 <= this.vehiculos.Count - 1);
    }

    public Vehiculo Siguiente()
    {
      if ((this.vehiculos == null) || (this.vehiculos.Count == 0) || (posicionActual + 1 > this.vehiculos.Count - 1))
      {
        return null;
      }
      else { return (Vehiculo)this.vehiculos[++posicionActual]; }
    }
  }
}
