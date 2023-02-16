using System;
using System.Collections.Generic;

namespace TacoBellAPI;

public partial class Burrito
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public float? Cost { get; set; }

    public bool? Bean { get; set; }

    //public Burrito(string _name, float _cost, bool _bean)
    //{
    //    Id = null;
    //    Name = _name;
    //    Cost = _cost;
    //    Bean = _bean;
    //}

    //public Burrito(int? _id, string _name, float _cost, bool _bean)
    //{
    //    Id = _id;
    //    Name = _name;
    //    Cost = _cost;
    //    Bean = _bean;
    //}
}
