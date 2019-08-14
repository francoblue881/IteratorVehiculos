namespace IteratorVehiculos
{
  public interface IIteratorVehiculo
  {

    void Primero();
    Vehiculo Actual();
    Vehiculo Siguiente();
    bool QuedanElementos();

  }
}
