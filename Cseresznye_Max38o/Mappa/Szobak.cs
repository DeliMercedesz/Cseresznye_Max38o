using System;
using System.Collections.Generic;

namespace Cseresznye_Max38o.Mappa;

public partial class Szobak
{
    public int SzobaId { get; set; }

    public string Nev { get; set; } = null!;

    public string Tema { get; set; } = null!;

    public byte Nehezseg { get; set; }

    public byte MaximalisJatekosSzam { get; set; }

    public string? KepForras { get; set; }
}
