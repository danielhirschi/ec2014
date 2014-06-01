using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeetManagerConnection
{
    public class AthleteFromData
    {
        public string ClubCode { get; set; }
        public string AthleteFirstname { get; set; }
        public string AthleteLastname { get; set; }
        public string SwimresultSwimresultId { get; set; }
        public int SwimresultLane { get; set; }
        public string SwimeventDaytime { get; set; }
        public string SwimeventDuration { get; set; }
        public int SwimeventEventnumber { get; set; }
        public int HeatHeatnumber { get; set; }

        public override string ToString()
        {
            return String.Join(" ; ", new string[]
                                          {
                                              ClubCode,
                                              AthleteFirstname,
                                              AthleteLastname,
                                              SwimresultSwimresultId,
                                              SwimresultLane.ToString(),
                                              SwimeventDaytime,
                                              SwimeventDuration,
                                              SwimeventEventnumber.ToString(),
                                              HeatHeatnumber.ToString()
                                          });
        }
    }
}
