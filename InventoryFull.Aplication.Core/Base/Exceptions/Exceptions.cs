using System;

namespace InventoryFull.Aplication.Core.Base.Exceptions
{
    public class Exceptions : Exception
    {
        public Exceptions() { }
        public Exceptions(string? message): base(message) { }
    }
}
