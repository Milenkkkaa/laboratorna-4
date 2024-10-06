using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna4
{
   public class House
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public int Room { get; set; }
        public int Floor { get; set; }
        public double Value { get; set; }
        public double Price { get; set; }
        public bool HasForniture { get; set; }
        public double GetCost()
        {
            return (Width * Length) * Price;
        }
        public double Heating()
        {
            return Value * (Width * Length);
        }
        public double getCost
        {
            get
            {
                return GetCost();
            }
        }
        public double heating
        {
            get
            {
                return Heating();
            }
        }
        public House(double width, double length, double height, int room, int floor,
            double value, double price, bool hasForniture, 
            double getCost, double heating)
        {
            Width = width;
            Length = length;
            Height = height;
            Room = room;
            Floor = floor;
            Value = value;
            Price = price;
            HasForniture = hasForniture;
        }
        public House()
        {
        }
    }
}
