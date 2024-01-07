using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTrial_CodeFirst.Domain
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public DateTime DOB { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Complexion { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
    }
}
