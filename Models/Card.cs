using System.Collections.Generic;

namespace lord_of_death
{
    public class Card : BattleAct
    {
        private string id = "";
        private string imgName = "staff_back.png";
        private string imgBack = "staff_back_png";

        public string Id { get => id; set => id = value; }
        public string ImgName { get => imgName; set => imgName = value; }
        public string ImgBack { get => imgBack; set => imgBack = value; }

        public Card Copy()
        {
            return this.MemberwiseClone() as Card;
        }
    }
}