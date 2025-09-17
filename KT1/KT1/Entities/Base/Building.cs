using KT1.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KT1.Entities.Base;

public class Building
{
    public string Address => _address;
    private string _address;

    public Building(string address)
    {
        _address = address.CheckNotNullOrEmptyOrWhiteSpace();
    }
}
