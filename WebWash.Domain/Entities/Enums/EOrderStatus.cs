using System;
using System.ComponentModel;

namespace WebWash.Domain;

public enum EOrderStatus
{
    [Description("Pendente")]
    Pending = 1,
    [Description("Lavando")]
    Washing = 2,
    [Description("Pronto")]
    Ready = 3,      
    [Description("Entregue")]
    Delivered = 4,
    [Description("Cancelado")]
    Canceled = 5
}
