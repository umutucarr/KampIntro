using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class VerificationManager : IVerificationService

    {
        public bool CheckİfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName=="Umut" || gamer.FirstName=="Engin")
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
