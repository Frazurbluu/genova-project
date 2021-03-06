/***************************************************************************
 *   copyright            : (C) GeNova Project
 *   webSite              : http://code.google.com/p/genovaproject/
 *
 ***************************************************************************/

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using Server.Mobiles;

namespace GeNova.Server.Engines.CustomRace
{
    public class HumanCustomRace : ModelCustomRace
    {
        public HumanCustomRace(PlayerMobile player)
            : base(player, "Humanos", string.Empty)
        {
        }
    }
}
