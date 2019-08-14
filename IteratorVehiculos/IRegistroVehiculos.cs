namespace IteratorVehiculos
{
  public interface IRegistroVehiculos
  {

    void InsertarVehiculo(string marca, string modelo, double precio);
    Vehiculo MostrarInformacionVehiculo(int indice);

    IIteratorVehiculo ObtenerIterator();

  }
}
