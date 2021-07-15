using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGameService
    {
        public void Add(Game game);
        public void Delete(Game game);

    }
}
