using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GamerManager : IGamerService
    {
        public GamerManager()
        {

        }
        private IVerificationService verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }
        public void Register(Gamer gamer)
        {
            if (verificationService.CheckİfRealPerson(gamer)    )
            {
                Console.WriteLine("Oyuncu kayıt edildi: " + gamer.FirstName +" " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Bilgilerinizi kontrol ediniz.");
            }
            
        }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi: " + gamer.FirstName +" "+ gamer.LastName);
        }

       
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi: " + gamer.FirstName +" "+ gamer.LastName);
        }
    }
}
