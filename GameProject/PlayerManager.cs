using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayer
    {
        IPlayerValidation _player;

        public PlayerManager(IPlayerValidation player)
        {
            _player = player;
        }

        public void Add(Player player)
        {
            if (_player.Validate(player)==true)
            {
                Console.WriteLine("Oyuncu eklendi");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
    }
}
