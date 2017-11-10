using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Level
{
    low,
    medium,
    high
}

namespace Morgengry
{
    public class Amulet : Merchandise
    {

        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;

        public string Design;
        public Level Quality;
     

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
        public Amulet (string inItemId, Level inQuality, string inDesign) : base (inItemId)
        {
            //ItemId = inItemId;
            Design = inDesign;
            Quality = inQuality;
        }
        public Amulet (string inItemId, Level inQuality) :
            this (inItemId, inQuality, "")
        {
            //itemid = inItemid;
            //design = "";
            //quality = inQuality;
        }
        public Amulet (string inItemId) :
            this (inItemId, Level.medium, "") 
        {
            //itemid = inItemid;
            //design = "";
            //quality = Level.Medium;
        }
        public override double GetValue()
        {
            double result = 0;
            if (Quality == Level.medium)
            {
                return result = MediumQualityValue;
            }
            if (Quality == Level.low)
            {
                return result = LowQualityValue;
            }
            if (Quality == Level.high)
            {
                return result = HighQualityValue;
            }
            else
                return 0;

        }


}

}
