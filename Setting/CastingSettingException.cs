using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedSettingsAbstraction.Setting
{
    class CastingSettingException : Exception
    {
        public CastingSettingException()
            : base("Error Casting Settings") { }
    }

}
