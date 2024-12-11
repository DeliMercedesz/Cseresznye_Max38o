using System;
using System.Collections.Generic;

namespace Cseresznye_Max38o.Mappa;

public partial class Foglalasok
{
    public int FoglalasId { get; set; }

    public int SzobaId { get; set; }

    public int JatekosId { get; set; }

    public DateTime Idopont { get; set; }

    public string Allapot { get; set; } = null!;

    public virtual Jatekosok Jatekos { get; set; } = null!;

    public virtual Szobak Szoba { get; set; } = null!;
}
