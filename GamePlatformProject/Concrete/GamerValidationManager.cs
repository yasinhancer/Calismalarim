using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "YASİN" && gamer.LastName == "HANÇER" && gamer.BirthYear == 2002 && gamer.Id == 1 && gamer.NationalityId == 123456) //if bloğunda &&: ve
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
