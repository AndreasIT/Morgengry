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
};

namespace Morgengry
{
    public class Amulet : Merchandise
    {
     
        public string Design;
        public Level Quality;
     

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
        public Amulet (string inItemId, Level inQuality, string inDesign)
        {
            ItemId = inItemId;
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

     
    }
    
}
