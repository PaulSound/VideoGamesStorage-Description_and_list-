using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGamesStorage_Description_and_list_.Model
{
    public class Games
    {
        public int GameId { get; set; }
        public string Name { get; set; } = null!;
        public string AgeLimit { get; set; } = null!;
        public string Platform { get;set; } = null!;
        public string Genre { get; set; } = null!;

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Игра: {Name}, с возрастным ограничением {AgeLimit}.\n Игра жанра {Genre} доступна на игровой платформе {Platform} по цене {Price}" +
                $"\n Описание:\n{Description}\\n";
        }
    }
}
