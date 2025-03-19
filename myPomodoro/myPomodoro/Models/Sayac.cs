using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace myPomodoro.Models
{
    public class Sayac
    {
        [Key]
        public int PomodoroID { get; set; }  // Birincil anahtar

        public bool BaslaBitir { get; set; }  // Sayaç başladı mı, bitti mi?

        public TimeSpan Sure { get; set; }  // Süreyi tutan sütun

        public int Toplam { get; set; }  // Toplam kaç Pomodoro tamamlandı?
    }
}
