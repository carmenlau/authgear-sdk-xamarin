﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Authgear.Xamarin
{
    public class AuthenticateResult
    {
        public UserInfo UserInfo { get; }
        public string State { get; }
        internal AuthenticateResult(UserInfo userInfo, string state)
        {
            UserInfo = userInfo;
            State = state;
        }
    }
}
