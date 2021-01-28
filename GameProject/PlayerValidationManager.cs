using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerValidationManage : IPlayerValidation
    {
        public bool Validate(Player player)
        {
            if (player.BirthOfDate==1996 && player.LastName=="KOÇ"
                && player.TcNo=="12345678901"&& player.Name=="Bahri")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
