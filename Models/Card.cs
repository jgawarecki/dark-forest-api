using System.Collections.Generic;

namespace lord_of_death
{
    public class Card : BattleAct
    {
        private int id = -1;
        private string imgName = "staff_back.png";
        private string imgBack = "staff_back_png";

        public int Id { get => id; set => id = value; }
        public string ImgName { get => imgName; set => imgName = value; }
        public string ImgBack { get => imgBack; set => imgBack = value; }
    }
}