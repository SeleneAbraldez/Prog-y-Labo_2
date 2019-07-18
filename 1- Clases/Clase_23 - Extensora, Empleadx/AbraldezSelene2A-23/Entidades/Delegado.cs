public delegate void DelegadoSueldo(Entidades.Empleado e, float s);

public delegate void DelSueldo(Entidades.EmpleadoMejorado eM, Entidades.EmpleadoSueldoArgs eSA);

public enum TipoManejador
{
    LimiteSueldo,
    Load,
    Ambos
}
