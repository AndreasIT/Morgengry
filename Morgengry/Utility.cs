//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Morgengry
//{
//    public class Utility
//    {
//        public static double LowQualityValue { get; set; } = 12.5;
//        public static double MediumQualityValue { get; set; } = 20.0;
//        public static double HighQualityValue { get; set; } = 27.5;

//        public static double GetValueOfMerchandise(Merchandise merchandise)
//        {

//            if (merchandise is Book book)
//            {
//                return book.Price;
//            }
//            if (merchandise is Amulet amulet)
//            {
//                if (amulet.Quality == Level.low)
//                {
//                    return LowQualityValue;
//                }
//                if (amulet.Quality == Level.medium)
//                {
//                    return MediumQualityValue;
//                }

//                if (amulet.Quality == Level.high)
//                {
//                    return HighQualityValue;
//                }
//            }
//            return 0;
//        }

//        //public static double GetValueOfBook(Book book)
//        //{
//        //    return book.Price;
//        //}

//        //public static double GetValueOfAmulet(Amulet amulet)
//        //{
//        //    if (amulet.Quality == Level.medium)
//        //    {
//        //        return 20.0;
//        //    }
//        //    if(amulet.Quality == Level.low)
//        //    {
//        //        return 12.5;
//        //    }
//        //    if (amulet.Quality == Level.high)
//        //    {
//        //        return 27.5;
//        //    }
//        //    else
//        //        return 0;

//        //}
//        public static double GetValueOfCourse(Course course)
//        {
//            int noOfHours = course.DurationInMinutes / 60;

//            if (course.DurationInMinutes % 60 > 0)
//            {
//                noOfHours++;
//            }
//            return 875 * noOfHours;
//        }
//    }

//}
