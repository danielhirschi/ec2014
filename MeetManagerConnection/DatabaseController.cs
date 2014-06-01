using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.IO;

namespace MeetManagerConnection
{
    public class DatabaseController
    {
        public string AccessFilePath { get; set; }

        private OleDbConnection dbConnection;

        public DatabaseController()
        {
            
        }

        public List<AthleteFromData> GetAthleteFrom(int wettkampfNr, int laufNr)
        {
            List<AthleteFromData> retList = new List<AthleteFromData>();
            OleDbConnection con = GetAccessConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "";
                comm.CommandText += "SELECT CLUB.CODE, ATHLETE.FIRSTNAME, ATHLETE.LASTNAME, SWIMRESULT.SWIMRESULTID, SWIMRESULT.LANE, SWIMEVENT.DAYTIME, SWIMEVENT.DURATION, SWIMEVENT.EVENTNUMBER, HEAT.HEATNUMBER";
                comm.CommandText += " FROM (CLUB INNER JOIN ATHLETE ON CLUB.CLUBID = ATHLETE.CLUBID) INNER JOIN (SWIMEVENT INNER JOIN (SWIMRESULT INNER JOIN HEAT ON SWIMRESULT.HEATID = HEAT.HEATID) ON (SWIMEVENT.SWIMEVENTID = SWIMRESULT.SWIMEVENTID) AND (SWIMEVENT.SWIMEVENTID = HEAT.SWIMEVENTID)) ON ATHLETE.ATHLETEID = SWIMRESULT.ATHLETEID";
                comm.CommandText += string.Format(" WHERE (((SWIMEVENT.EVENTNUMBER)={0}) AND ((HEAT.HEATNUMBER)={1}))", wettkampfNr, laufNr);
                comm.CommandType = CommandType.Text;
                OleDbDataReader dbReader = comm.ExecuteReader();
                if (dbReader != null && dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        object[] datas =new object[dbReader.FieldCount];
                        int a = dbReader.GetValues(datas);
                        retList.Add(new AthleteFromData()
                                        {
                                            ClubCode = Convert.ToString(datas[0]),
                                            AthleteFirstname = Convert.ToString(datas[1]),
                                            AthleteLastname = Convert.ToString(datas[2]),
                                            SwimresultSwimresultId = Convert.ToString(datas[3]),
                                            SwimresultLane = Convert.ToInt32(datas[4]),
                                            SwimeventDaytime = Convert.ToString(datas[5]),
                                            SwimeventDuration = Convert.ToString(datas[6]),
                                            SwimeventEventnumber = Convert.ToInt32(datas[7]),
                                            HeatHeatnumber = Convert.ToInt32(datas[8]),
                                        });

                    }
                }
            }
            con.Close();
            con.Dispose();
            return retList;
        }

        private OleDbConnection GetAccessConnection()
        {
            if (String.IsNullOrWhiteSpace(AccessFilePath)) throw new ArgumentException("No File defined");
            if (!File.Exists(AccessFilePath)) throw new ArgumentException("Cant find access file");
            dbConnection = new OleDbConnection(String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", AccessFilePath));
            dbConnection.Open();
            return dbConnection;
        }
        
        
    }
}
