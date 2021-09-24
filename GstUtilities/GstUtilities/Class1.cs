using System;

namespace GstUtilities
{
    public class GST
    {
        public double ProAmt { get; set; }

        public double GstPer { get; set; }


        public GST(double proAmt,double gstPer)
        {
            this.ProAmt = proAmt;
            this.GstPer = gstPer;
        }

        public double CalculateGstAmt()
        {
            double GstAmt = this.ProAmt / 100 * this.GstPer;
            return GstAmt;
        }

        public double CalculateTotalProAmt()
        {
            double totalAmt = CalculateGstAmt() + this.ProAmt;
            return totalAmt;
        }
    }
}
