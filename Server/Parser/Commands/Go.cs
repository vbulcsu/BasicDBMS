﻿using Server.Parser.Actions;
using Server.Server.Responses;

namespace Server.Parser.Commands
{
    internal class Go : IDbAction
    {
        public ActionResponse Perform()
        {
            return ActionResponse.Default();
        }
    }
}