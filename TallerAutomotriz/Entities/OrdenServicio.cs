namespace TallerAutomotriz.Entities;

class OrdenServicio
{

    public int Id { get; set; }
    public DateTime FechaOrden { get; set; }
    public string DiagnosticoCliente { get; set; }
    public string DiagnosticoExperto { get; set; }

    public Cliente cliente { get; set; }
    public Empleados empleado { get; set; }

     public OrdenServicio(int id, DateTime fechaOrden, string diagnosticoCliente, string diagnosticoExperto)
    {
        Id = id;
        FechaOrden = fechaOrden;
        DiagnosticoCliente = diagnosticoCliente;
        DiagnosticoExperto = diagnosticoExperto;    
    }

    
}
