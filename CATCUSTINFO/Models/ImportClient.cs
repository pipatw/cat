using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CATCUSTINFO.Models
{
    public static class ImportClient
    {
        public static string month = "พฤษภาคม";
        public static int allClient = 110000;
        public static int hinet = 30;
        public static int hotnet = 20;
        public static int onnet = 50;

        public static int[] northClient = { 10000,15000,16000,17000,18000 };
        public static int[] southClient = { 13000, 14000, 17000, 13000, 14000 };
        public static int[] eastClient = { 17000, 18000, 14000, 16000, 13000 };
        public static int[] westClient = { 19000, 17000, 15000, 13000, 14000 };
        public static int[] northEastClient = { 11000, 12000, 14000, 17000, 18000 };
        public static int[] centerClient = { 12000, 15000, 17000, 16000, 13000 };

        public static int northKpi = 10000;
        public static int southKpi = 10000;
        public static int eastKpi = 10000;
        public static int westKpi = 10000;
        public static int northEastKpi = 10000;
        public static int centerKpi = 10000;

        public static int northPer = northClient.LastOrDefault() / northKpi;
    }
}