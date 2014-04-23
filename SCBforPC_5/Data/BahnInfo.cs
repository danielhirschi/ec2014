using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCEG.ScoreboardPc.Business;

namespace SCEG.ScoreboardPc.Data
{
    class BahnInfo : AresCommand
    {
        private const byte BahnInfoErkennungsByte = 0x53;
        private const int TotalAnzahlBahnen = 8;

        public int BahnNr { get; set; }
        public bool Loeschen { get; set; }
        public TimeSpan Time { get; set; }
        public int Rang { get; set; }
        

     

        public BahnInfo(List<byte> command)
            : base(command)
        {
            int fullLength = command.Count;
            int latIndexOf82 = command.LastIndexOf(0x82);
            Rang = latIndexOf82 - 8;
            var subRange = command.GetRange(latIndexOf82 + 1, command.Count - latIndexOf82 - 2);

            Loeschen = subRange.All(b => b == 0xA0);
            if (!Loeschen)
            {
                int sublength = subRange.Count;
                string subRangeAsHex = HelperMethods.ByteArrayToFormatedString(subRange);
                BahnNr = (subRange[1] & 0x0F);
                if (Rang > 0)
                {
                    int mm = ((subRange[3] & 0x0F) * 10) + (subRange[4] & 0x0F);         // mm
                    int ss = ((subRange[6] & 0x0F) * 10) + (subRange[7] & 0x0F);         // ss
                    int dd = (((subRange[9] & 0x0F) * 10) + (subRange[10] & 0x0F)) * 10;         // d   
                    Time = new TimeSpan(0, 0, mm, ss, dd);
                }

            }
           



            //if (command[10] == 0xA0 &&
            //    command[11] == 0xA0 &&
            //    command[12] == 0xA0 &&
            //    command[13] == 0xA0 &&
            //    command[14] == 0xA0 &&
            //    command[15] == 0xA0 &&
            //    command[16] == 0xA0)
            //{
            //    BahnNr = 0;
            //    Loeschen = true;
            //}
            //else
            //{
            //    Rang = 0;
            //    while (command[Rang + 7] == 0x0A &&
            //            Rang < TotalAnzahlBahnen) // Welche Bahn ist es?
            //    {
            //        Rang++;
            //    }
            //    Rang++;
            //    if (command[13 + Rang] == 0xA0 &&
            //        command[14 + Rang] == 0xA0 &&
            //        command[15 + Rang] == 0xA0 &&
            //        command[16 + Rang] == 0xA0 &&
            //        command[17 + Rang] == 0xA0 &&
            //        command[18 + Rang] == 0xA0 &&
            //        command[19 + Rang] == 0xA0 &&
            //        command[20 + Rang] == 0xA0 &&
            //        command[21 + Rang] == 0xA0)
            //    {
            //        Loeschen = true;
            //    }
            //    else
            //    {
            //        Loeschen = false;
            //        BahnNr = (command[10 + Rang] & 0x0F);
            //        int mm = ((command[13 + Rang - 1] & 0x0F) * 10) + (command[14 + Rang - 1] & 0x0F);         // mm
            //        int ss = ((command[16 + Rang - 1] & 0x0F) * 10) + (command[17 + Rang - 1] & 0x0F);         // ss
            //        int dd = (((command[19 + Rang - 1] & 0x0F) * 10) + (command[20 + Rang - 1] & 0x0F)) * 10;         // d   
            //        Time = new TimeSpan(0, 0, mm, ss, dd);
            //    }
            //}
            Console.WriteLine(this.ToString());
            Console.WriteLine(base.FullResCommandInHex);
        }

        public override string ToString()
        {
            return String.Format("ARES BahnInfo, BahnNr:{0} Loeschen:{1} Time:{2} Rang:{3}", BahnNr, Loeschen, Time, Rang);
        }

        public static bool IsValid(List<byte> command)
        {
            return command.Count > 10 &&
                   command[2] == BahnInfoErkennungsByte;
        }



        //                    if (DatenarrayTemp[10] == 0xA0 && DatenarrayTemp[11] == 0xA0 && DatenarrayTemp[12] == 0xA0 && DatenarrayTemp[13] == 0xA0 && DatenarrayTemp[14] == 0xA0 && DatenarrayTemp[15] == 0xA0 && DatenarrayTemp[16] == 0xA0)
        //                    {
        //                        ClearScoreboard();
        //                        txtTime1.Text = "0.0";
        //                    }
        //                    else // Zwischen-Endzeit
        //                    {
        //                        int Bahn_zaehler = 0;
        //                        int Bahn_Anzahl = 8;
        //                        if (DatenarrayTemp[Bahn_zaehler + 7] == 0x0A)
        //                        {
        //                            Bahn_zaehler++;
        //                            while (DatenarrayTemp[Bahn_zaehler + 7] == 0x0A && Bahn_zaehler < Bahn_Anzahl) // Welche Bahn ist es?
        //                            {
        //                                Bahn_zaehler++;
        //                            }
        //                        }
        //                        if (DatenarrayTemp[13 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[14 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[15 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[16 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[17 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[18 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[19 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[20 + Bahn_zaehler] == 0xA0 && DatenarrayTemp[21 + Bahn_zaehler] == 0xA0)
        //                        {
        //                            switch (Bahn_zaehler)
        //                            {
        //                                case 0:
        //                                    txtBahn1.Text = "";
        //                                    txtRang1.Text = "";
        //                                    txtTime1.Text = "";
        //                                    break;
        //                                case 1:
        //                                    txtBahn2.Text = "";
        //                                    txtRang2.Text = "";
        //                                    txtTime2.Text = "";
        //                                    break;
        //                                case 2:
        //                                    txtBahn3.Text = "";
        //                                    txtRang3.Text = "";
        //                                    txtTime3.Text = "";
        //                                    break;
        //                                case 3:
        //                                    txtBahn4.Text = "";
        //                                    txtRang4.Text = "";
        //                                    txtTime4.Text = "";
        //                                    break;
        //                                case 4:
        //                                    txtBahn5.Text = "";
        //                                    txtRang5.Text = "";
        //                                    txtTime5.Text = "";
        //                                    break;
        //                                case 5:
        //                                    txtBahn6.Text = "";
        //                                    txtRang6.Text = "";
        //                                    txtTime6.Text = "";
        //                                    break;
        //                                case 6:
        //                                    txtBahn7.Text = "";
        //                                    txtRang7.Text = "";
        //                                    txtTime7.Text = "";
        //                                    break;
        //                                case 7:
        //                                    txtBahn8.Text = "";
        //                                    txtRang8.Text = "";
        //                                    txtTime8.Text = "";
        //                                    break;
        //                            }                    
        //                        }
        //                        else
        //                        {
        //                            switch (Bahn_zaehler)
        //                            {
        //                                case 0:
        //                                    txtBahn1.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang1.Text = GetRank(Bahn_zaehler);
        //                                    txtTime1.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                                case 1:
        //                                    txtBahn2.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang2.Text = GetRank(Bahn_zaehler);
        //                                    txtTime2.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                                case 2:
        //                                    txtBahn3.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang3.Text = GetRank(Bahn_zaehler);
        //                                    txtTime3.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                                case 3:
        //                                    txtBahn4.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang4.Text = GetRank(Bahn_zaehler);
        //                                    txtTime4.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                                case 4:
        //                                    txtBahn5.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang5.Text = GetRank(Bahn_zaehler);
        //                                    txtTime5.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                                case 5:
        //                                    txtBahn6.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang6.Text = GetRank(Bahn_zaehler);
        //                                    txtTime6.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                                case 6:
        //                                    txtBahn7.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang7.Text = GetRank(Bahn_zaehler);
        //                                    txtTime7.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                                case 7:
        //                                    txtBahn8.Text = (Bahn_zaehler + 1).ToString();
        //                                    txtRang8.Text = GetRank(Bahn_zaehler);
        //                                    txtTime8.Text = GetLaneTime(Bahn_zaehler);
        //                                    break;
        //                            }
        //                        }

    }
}
