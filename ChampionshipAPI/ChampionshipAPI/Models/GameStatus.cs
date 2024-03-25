﻿using System;
using System.Collections.Generic;

namespace ChampionshipAPI.Models;

public partial class GameStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
