using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFT
{
    public enum Estatus
    {
        OK, ERROR
    }

    public partial class Response
    {
        public Estatus status { get; set; }
        public string resultado { get; set; }
        public string error { get; set; }
    }
}
