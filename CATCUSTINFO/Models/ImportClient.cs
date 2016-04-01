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

        public static int[] northClient = CountRegionsMonth(1).ToArray();
        public static int[] southClient = CountRegionsMonth(6).ToArray();
        public static int[] eastClient = CountRegionsMonth(4).ToArray();
        public static int[] westClient = CountRegionsMonth(5).ToArray();
        public static int[] northEastClient = CountRegionsMonth(2).ToArray();
        public static int[] centerClient = CountRegionsMonth(3).ToArray();
        public static int[] subClient = CountRegionsMonth(7).ToArray();


        static Entities db = new Entities();

        static int LastMonth = db.TB_Info_Cus.Max(m => m.Month);

        public static double countReg(int regid)
        {
            double count = db.TB_Info_Cus.Where(r => r.Month == LastMonth && r.RegCAT_ID==regid).Count();
            double kpi = 0;
            if (regid == 1) { kpi = northKpi; count = count - northLast; }
                
            else if (regid == 2) { kpi = northEastKpi; count = count - northEastLast; }
            
            else if (regid == 3) { kpi = centerKpi; count = count - centerLast; }
            
            else if (regid == 4) { kpi = eastKpi; count = count - eastLast; }
            
            else if (regid == 5) { kpi = westKpi; count = count - westLast; }
            
            else if (regid == 6) { kpi = southKpi; count = count - southLast; }
            
            else if (regid == 7) { kpi = subClientKpi; count = count - subClientLast; }
            

            double per = Math.Round((count / (kpi)) * 100);
            return per > 100 ? 100 : per;
        }

        public static int CountAll()
        {
            int totalThisYear = db.TB_Info_Cus.Where(r => r.Month == LastMonth).Count();
            return totalThisYear + ImportClient.totalLast;
        }

        public static double CountService(int type)
        {
            int all = db.TB_Info_Cus.Where(r => r.Month == LastMonth).Count();
            double filter = db.TB_Info_Cus.Where(r => r.Month == LastMonth && r.SerNet_ID == type).Count();
            double total =  Math.Round((filter/all) * 100);
            return total;
        }

        public static List<int> CountRegionsMonth(int reg)
        {
            List<int> charts = new List<int>();

            Entities db = new Entities();

            var q = from r in db.TB_Info_Cus
                    orderby r.Month
                    where r.RegCAT_ID == reg
                    group r by r.Month into g
                    select new { month = g.Key, count = g.Count() };

            charts = q.OrderBy(r => r.month).Select(r => r.count).ToList();

            return charts;
        }


        // kpi
        public static int northKpi = 4200;
        public static int southKpi = 6900;
        public static int eastKpi = 2100;
        public static int westKpi = 5100;
        public static int northEastKpi = 7500;
        public static int centerKpi = 3000;
        public static int subClientKpi = 1200;

        // last year customer count
        public static int northLast = 16519;
        public static int southLast = 16788;
        public static int eastLast = 7446;
        public static int westLast = 13440;
        public static int northEastLast = 25002;
        //public static int centerLast = 12462;
        public static int centerLast = 10000;
        public static int subClientLast = 2543;
        public static int totalLast = 94200;
        public static int northPer = 0;
    }
}