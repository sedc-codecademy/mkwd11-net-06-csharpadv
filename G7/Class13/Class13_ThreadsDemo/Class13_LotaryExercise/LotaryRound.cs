using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class13_LotaryExercise
{
    public class LotteryRound
    {
        public int RoundNo { get; set; }
        public DateTime DrawTime { get; set; }
        public List<string> Codes { get; set; } = new List<string>();

        //public LotteryRound()
        //{
        //    Codes = new List<string>();
        //}
    }
}
