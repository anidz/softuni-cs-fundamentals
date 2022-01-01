using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            const double waterBill = 20;
            const double internetBill = 15;
            double otherBills = 0;

            double waterBillCnt = 0;
            double internetBillCnt = 0;
            double electricityBillCnt = 0;
            double otherBillsCnt = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                electricityBillCnt += electricityBill;
                waterBillCnt += waterBill;
                internetBillCnt += internetBill;
                otherBills = (electricityBill + waterBill + internetBill) * 1.2;
                otherBillsCnt += otherBills;
            }
            double avg = (electricityBillCnt + waterBillCnt + internetBillCnt + otherBillsCnt) / months;
            Console.WriteLine($"Electricity: {electricityBillCnt:f2} lv");
            Console.WriteLine($"Water: {waterBillCnt:f2} lv");
            Console.WriteLine($"Internet: {internetBillCnt:f2} lv");
            Console.WriteLine($"Other: {otherBillsCnt:f2} lv");
            Console.WriteLine($"Average: {avg:f2} lv");
        }
    }
    }

