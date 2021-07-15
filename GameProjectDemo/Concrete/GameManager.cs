using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GameManager : IGameService
    {
     
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi: "+game.GameName);
        }

        
        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi: "+game.GameName);
        }
    }
}
