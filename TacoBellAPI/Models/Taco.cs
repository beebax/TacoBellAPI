using System;
using System.Collections.Generic;

namespace TacoBellAPI;

public partial class Taco
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public float? Cost { get; set; }

    public bool? SoftShell { get; set; }

    public bool? Dorito { get; set; }

    //public Taco(string _name, float _cost, bool _softshell, bool _dorito)
    //{
    //    //Id = _id;
    //    Name = _name;
    //    Cost = _cost;
    //    SoftShell = _softshell;
    //    Dorito = _dorito;
    //}
}
