﻿using EscapeRoomWebAppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscapeRoomWebAppCore.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<EscapeRoom> EscapeRooms { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
    }
}
