using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses.Domain.Enums
{
    public enum OrderStatus
    {
        Created = 1,
        Processing,
        DeliveryInProcess,
        Delivered,
        Problem
    }
}
