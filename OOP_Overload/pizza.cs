using System;

namespace OOP_Overload
{
    class Pizza {
        string cheese;
        string topping;
        string sauce;
        string bread;

        #region constructors
        public Pizza(string bread) {
            this.bread = bread;
        }


        public Pizza(string bread , string sauce) {
            this.bread = bread;
            this.sauce = sauce;
        }

        public Pizza(string bread , string sauce , String cheese) {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;

        }

        public Pizza(string bread , string sauce , String cheese , string topping) {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        #endregion
    }
}