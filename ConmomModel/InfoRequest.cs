﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModel
{
    public class InfoRequest
    {
        public TokenClaims Claims { get; set; } = new TokenClaims();
        public ApiRequetsContext RequestHttp { get; set; } = new ApiRequetsContext();
    }
}
