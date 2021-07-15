using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface IGamerService
    {
        public void Register(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);
    }
}
