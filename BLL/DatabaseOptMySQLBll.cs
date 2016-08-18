using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Utility;
using System.Data;
using System.Net;
using System.Net.Sockets;

namespace BLL
{
    #region GeoNetServerMySQLOpt
    /// <summary>
    /// �������͡��������ݿ������
    /// </summary>
    public class NetServerMySQLOpt : MySQLHelper
    {
       

        /// <summary>
        /// ����������
        /// </summary>
        /// <param name="soc"></param>
        /// <param name="devID"></param>
        /// <param name="detectorID"></param>
        /// <param name="devtime"></param>
        /// <returns></returns>
        public bool SaveHeartBeat(Socket soc, int devID, int detectorID, DateTime devtime)
        {
            bool bRet = true;
            string sqlstr = String.Format("insert into devonline (socketID,clientIP,clientPort,devID,detectorID,time) values ({0},'{1}',{2},{3},{4}, now())  ON DUPLICATE KEY UPDATE socketID={0},clientIP='{1}',clientPort={2},devID={3},detectorID={4},time=now()",
                           soc.Handle, ((IPEndPoint)soc.RemoteEndPoint).Address.ToString(), ((IPEndPoint)soc.RemoteEndPoint).Port,
                           devID, detectorID
                             );
            if (ExecuteNonQuery(sqlstr) == false)//
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sqlstr + "\r\n");//������ļ�
            }
            return bRet;
        }

        /// <summary>
        /// ����������
        /// </summary>
        /// <param name="PortName"></param>
        /// <param name="devID"></param>
        /// <param name="detectorID"></param>
        /// <param name="devtime"></param>
        /// <returns></returns>
        public bool SaveHeartBeat(string PortName, int devID, int detectorID, DateTime devtime)
        {
            bool bRet = true;
            string sqlstr = String.Format("insert into devonline (socketID,clientIP,clientPort,devID,detectorID,time) values ({0},'{1}',{2},{3},{4}, now())  ON DUPLICATE KEY UPDATE socketID={0},clientIP='{1}',clientPort={2},devID={3},detectorID={4},time=now()",
                           0, PortName, 0,
                           devID, detectorID
                             );
            if (ExecuteNonQuery(sqlstr) == false)//
            {
                bRet = false;
                DebugOutput.ProcessMessage("DBError: " + sqlstr + "\r\n");//������ļ�
            }
            return bRet;
        }

        /// <summary>
        /// ����Сʱ����ʷ��¼�����ݿ�
        /// </summary>
        /// <param name="dtHourResult"></param>
        /// <returns></returns>
        public bool SaveHourGeoInfo(DataTable dtHourResult)
        {
            bool bRet = true;
            Queue<string> sqlstrall = new Queue<string>();//����������ݵĶ���
            string sqlhourstr;
            for (int i = 0; i < dtHourResult.Rows.Count; i++)
            {
                DataRow row = dtHourResult.Rows[i];
                sqlhourstr = String.Format("insert into trafficinforecord_hour (hour,devID,laneID,carspeed,carlength,carOccupancyTime,cartype,detecttime,recordtime,packID,devstatus,carcount,speedcount,ip,lanepackID,singlePoint,roadcode,occupancycount,hourtime,devprotocoltype,devtype,carHeight,carWeight,ChannelID,sensorTypeID,sensorStatus,carStatus,cardID) values ({0},{1},{2},{3},{4},{5},'{6}','{7}',{8},{8},{10},{11},{12},'{13}',{25},{26},'{27}',{28},'{29}','{30}',{31},{32},{33},{34},{35},{36},{37},{38})  ON DUPLICATE KEY UPDATE carspeed={14},carlength={15},carOccupancyTime={16},cartype='{17}',detecttime='{18}',recordtime={19},packID={20},devstatus={21},carcount=carcount+{22},speedcount=speedcount+{23},ip='{24}',lanepackID={25},singlePoint={26},roadcode='{27}',occupancycount=occupancycount+{28},devprotocoltype='{30}',devtype={31},carHeight={32},carWeight={33},ChannelID={34},sensorTypeID={35},sensorStatus={36},carStatus={37},cardID={38}",
                      Convert.ToDateTime(row[7]).ToString("yyMMddHH"), row[1], row[2], row[3], row[4], row[5], row[6], row[7], "now()", row[8], row[9], row[10], row[11], row[12],
                     row[3], row[4], row[5], row[6], row[7], "now()", row[8], 1, row[10], row[11], row[12],
                     row[13], row[14], String.Format("{0}-{1}", row[1], row[2]), row[15], Convert.ToDateTime(row[7]).ToString("yyyy-MM-dd HH:00:00"), row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24]
                     );
                sqlstrall.Enqueue(sqlhourstr);
                int singlePoint = Convert.ToInt32(row[14]);//�����־λ
                if (singlePoint == 1)//��������
                {
                    sqlhourstr = String.Format("insert into devonline (clientIP,devID,detectorID,time) values ('{0}',{1},{2},now())  ON DUPLICATE KEY UPDATE clientIP='{0}',devID={1},detectorID={2},time=now()", row[12], row[1], Convert.ToInt32(row[2]));
                    sqlstrall.Enqueue(sqlhourstr);
                }
                else //if (singlePoint == 2)//˫������
                {
                    sqlhourstr = String.Format("insert into devonline (clientIP,devID,detectorID,time) values ('{0}',{1},{2},now())  ON DUPLICATE KEY UPDATE clientIP='{0}',devID={1},detectorID={2},time=now()", row[12], row[1], Convert.ToInt32(row[2]) * 2 - 1);
                    sqlstrall.Enqueue(sqlhourstr);
                    sqlhourstr = String.Format("insert into devonline (clientIP,devID,detectorID,time) values ('{0}',{1},{2},now())  ON DUPLICATE KEY UPDATE clientIP='{0}',devID={1},detectorID={2},time=now()", row[12], row[1], Convert.ToInt32(row[2]) * 2);
                    sqlstrall.Enqueue(sqlhourstr);
                }
            }

            //����һʱ�̵�ļ�������
            //sqlhourstr = String.Format("update trafficinforecord_hour set carcount=0,speedcount=0 where hour={0}", (lasthour.Hour + 1) % 24);
            //sqlstrall.Enqueue(sqlhourstr);

            //��ʼ�洢
            while (sqlstrall.Count > 0)//����Ҫִ�е�
            {
                string execsql = sqlstrall.Dequeue();//ȡ��һ��
                if (ExecuteNonQuery(execsql) == false)//servergeodb.GetDataBaseStatus() == false || 
                {
                    bRet = false;
                    DebugOutput.ProcessMessage(execsql);//������ļ�
                }
            }
            return bRet;
        }

        /// <summary>
        /// д��5����ͳ������
        /// </summary>
        /// <param name="dtMinuteResult"></param>
        /// <returns></returns>
        public bool SaveMinuteGeoInfo(DataTable dtMinuteResult)
        {
            bool bRet = true;
            Queue<string> sqlstrall = new Queue<string>();//����������ݵĶ���
            string sqlminutestr;
            for (int i = 0; i < dtMinuteResult.Rows.Count; i++)
            {
                DataRow row = dtMinuteResult.Rows[i];
                sqlminutestr = String.Format("insert into trafficinforecord_minute (minute,devID,laneID,carspeed,carlength,carOccupancyTime,cartype,detecttime,recordtime,packID,devstatus,carcount,speedcount,ip,lanepackID,singlePoint,roadcode,occupancycount,minutetime,devprotocoltype,devtype,carHeight,carWeight,ChannelID,sensorTypeID,sensorStatus,carStatus,cardID) values ({0},{1},{2},{3},{4},{5},'{6}','{7}',{8},{8},{10},{11},{12},'{13}',{25},{26},'{27}',{28},'{29}','{30}',{31},{32},{33},{34},{35},{36},{37},{38})  ON DUPLICATE KEY UPDATE carspeed={14},carlength={15},carOccupancyTime={16},cartype='{17}',detecttime='{18}',recordtime={19},packID={20},devstatus={21},carcount=carcount+{22},speedcount=speedcount+{23},ip='{24}',lanepackID={25},singlePoint={26},roadcode='{27}',occupancycount=occupancycount+{28},devprotocoltype='{30}',devtype={31},carHeight={32},carWeight={33},ChannelID={34},sensorTypeID={35},sensorStatus={36},carStatus={37},cardID={38}",
                      String.Format("{0}{1:00}", Convert.ToDateTime(row[7]).ToString("yyMMddHH"), row[0]), row[1], row[2], row[3], row[4], row[5], row[6], row[7], "now()", row[8], row[9], row[10], row[11], row[12],
                     row[3], row[4], row[5], row[6], row[7], "now()", row[8], 1, row[10], row[11], row[12],
                     row[13], row[14], String.Format("{0}-{1}", row[1], row[2]), row[15], String.Format("{0}:{1:00}:00", Convert.ToDateTime(row[7]).ToString("yyyy-MM-dd HH"), row[0]), row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24]
                     );
                sqlstrall.Enqueue(sqlminutestr);
            }

            //����һʱ�̵�ļ�������
            //sqlhourstr = String.Format("update trafficinforecord_minute set carcount=0,speedcount=0 where minute={0}", (lasthour.Hour + 1) % 24);
            //sqlstrall.Enqueue(sqlhourstr);

            //��ʼ�洢
            while (sqlstrall.Count > 0)//����Ҫִ�е�
            {
                string execsql = sqlstrall.Dequeue();//ȡ��һ��
                if (ExecuteNonQuery(execsql) == false)//servergeodb.GetDataBaseStatus() == false || 
                {
                    bRet = false;
                    DebugOutput.ProcessMessage(execsql);//������ļ�
                }
            }
            return bRet;
        }

        /// <summary>
        /// �����¼���˳�����Ϣ�����ݿ�
        /// </summary>
        /// <param name="soc"></param>
        /// <param name="Islogin"></param>
        /// <returns></returns>
        public bool SaveLogInOutInfo(Socket soc, bool Islogin)
        {
            bool bRet = true;
            //string msg;
            string[] sqlstr = new string[2];
            if (Islogin == true)
            {
                //ά������
                sqlstr[0] = String.Format("insert into loginrecord (socketID,clientIP,clientport,time,flag,type) values ({0},'{1}',{2},now(),'in','client')", soc.Handle,
                    ((IPEndPoint)soc.RemoteEndPoint).Address.ToString(),
                    ((IPEndPoint)soc.RemoteEndPoint).Port
                    );
                //�������߼�¼
                sqlstr[1] = String.Format("insert into devonline (socketID,clientIP,clientPort,devID,detectorID,time) values ({0},'{1}',{2},{3},{4},now())  ON DUPLICATE KEY UPDATE socketID={0},clientIP='{1}',clientPort={2},devID={3},detectorID={4},time=now()",
                           soc.Handle, ((IPEndPoint)soc.RemoteEndPoint).Address.ToString(), ((IPEndPoint)soc.RemoteEndPoint).Port,
                           0, 0
                             );
            }
            else
            {
                //�Ƴ�����
                sqlstr[0] = String.Format("insert into loginrecord (socketID,clientIP,clientport,time,flag,type) values ({0},'{1}',{2},now(),'out','client')", soc.Handle,
                    ((IPEndPoint)soc.RemoteEndPoint).Address.ToString(),
                    ((IPEndPoint)soc.RemoteEndPoint).Port
                    );
                sqlstr[1] = String.Format("delete from devonline  where clientIP = '{0}'", ((IPEndPoint)soc.RemoteEndPoint).Address.ToString());
            }
            for (int i = 0; i < sqlstr.Length; i++)
            {
                if (ExecuteNonQuery(sqlstr[i]) == false)
                {
                    bRet = false;
                    DebugOutput.ProcessMessage("DBError: " + sqlstr[i] + "\r\n");//������ļ�
                }
            }
            return bRet;
        }


        /// <summary>
        /// �����˳���������
        /// </summary>
        /// <returns></returns>
        public bool SaveDisconnectAll(Dictionary<int, Socket> ClientSocketList)
        {
            Socket soc;
            bool bRet = true;
            string sqlstr;
            try
            {
                //��ȡ�б�
                if (ClientSocketList.Count > 0)
                {
                    foreach (int key in ClientSocketList.Keys)//��ֵ��������RemoveDictionaryKeyValue��
                    {//i��IP��inet��
                        ClientSocketList.TryGetValue(key, out soc);
                        //д���˳���Ϣ
                        sqlstr = String.Format("insert into loginrecord (socketID,clientIP,clientport,time,flag,type) values ({0},'{1}',{2},now(),'out','server')", soc.Handle,
                            ((IPEndPoint)soc.RemoteEndPoint).Address.ToString(),
                            ((IPEndPoint)soc.RemoteEndPoint).Port
                            );
                        if (ExecuteNonQuery(sqlstr) == false)
                        {
                            bRet = false;
                            DebugOutput.ProcessMessage("DBError: " + sqlstr + "\r\n");//������ļ�
                        }
                    }
                }
                //�Ƴ��������ߵ��豸��¼
                sqlstr = "delete from devonline ";
                if (ExecuteNonQuery(sqlstr) == false)
                {
                    bRet = false;
                    DebugOutput.ProcessMessage("DBError: " + sqlstr + "\r\n");//������ļ�
                }
            }
            catch { };
            return bRet;
        }

    }
    #endregion

    #region DataBaseMngrMySQLOpt
    /// <summary>
    /// �������͡��������ݿ������
    /// </summary>
    public class DataBaseMngrMySQLOpt : MySQLHelper
    {
        /// <summary>
        /// ��ȡ���͵�PACKIDֵ
        /// </summary>
        /// <returns>���ķ���ID</returns>
        public int GetLastSendPackID()
        {
            int nSendpackID = 1;
            DataSet ds = null;
            string[] sqlString = new string[1];
            sqlString[0] = String.Format("SELECT valueinfo from syssetting where keyinfo = '{0}' ", "sendpackid");
            try
            {
                ds = GetDataSet(sqlString[0]);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        nSendpackID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }

            return nSendpackID;
        }

        //��ȡ���շ��͵�5min��ʱ��ֵ
        public DateTime GetLastSend5MinTime()
        {
            DateTime lasttime = System.DateTime.Now;
            DateTime dbSysTime = System.DateTime.Now, dbLastUpladTime = DateTime.MaxValue;
            DataSet ds1 = null, ds2 = null, ds3 = null;
            string[] sqlString = new string[3];
            sqlString[0] = String.Format("SELECT concat(DATE_FORMAT(valueinfo,'%Y-%m-%d %H:'),floor(DATE_FORMAT(valueinfo, '%i')/5)*5,':00') as lasttime from syssetting where keyinfo = 'send5mintime'");
            sqlString[1] = String.Format("SELECT concat(DATE_FORMAT(detecttime,'%Y-%m-%d %H:'),floor(DATE_FORMAT(detecttime, '%i')/5)*5,':00') as detecttime from trafficinforecord where uploadflag = 0 limit 1 ");
            sqlString[2] = String.Format("SELECT concat(DATE_FORMAT(now(),'%Y-%m-%d %H:'),floor(DATE_FORMAT(now(), '%i')/5)*5,':00') as nowtime ");
            try
            {
                //����ϴ���ѯ
                ds1 = GetDataSet(sqlString[0]);
                if (ds1 != null)
                {
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        if (Convert.ToString(ds1.Tables[0].Rows[0][0]) != "")
                            dbLastUpladTime = Convert.ToDateTime(ds1.Tables[0].Rows[0][0]);
                    }
                }
                //δ�ϴ���¼��ѯ
                if (dbLastUpladTime == DateTime.MaxValue)
                {
                    ds2 = GetDataSet(sqlString[1]);
                    if (ds2 != null)
                    {
                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            if (Convert.ToString(ds2.Tables[0].Rows[0][0]) != "")
                                dbLastUpladTime = Convert.ToDateTime(ds2.Tables[0].Rows[0][0]);
                        }
                    }
                }
                //���ݿ��ʱ��
                ds3 = GetDataSet(sqlString[2]);
                if (ds3 != null)
                {
                    if (ds3.Tables[0].Rows.Count > 0)
                    {
                        if (Convert.ToString(ds3.Tables[0].Rows[0][0]) != "")
                            dbSysTime = Convert.ToDateTime(ds3.Tables[0].Rows[0][0]);
                    }
                }
                //�Ƚ�ʱ��
                lasttime = dbLastUpladTime;
                if (DateTime.Compare(dbLastUpladTime, dbSysTime) > 0)
                    lasttime = dbSysTime;
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }

            return lasttime;
        }
        //�������
        public bool ClearHistoryRecord(DateTime timestart, DateTime timeend)
        {
            bool bRet = false;
            string[] sqlString = new string[3];
            if (timestart == DateTime.MinValue && timeend == DateTime.MaxValue)
            {//������е�
                sqlString[0] = String.Format("TRUNCATE `trafficinforecord`");
                sqlString[1] = String.Format("TRUNCATE `trafficinforecord_hour`");//TRUNCATE `syssetting`;TRUNCATE `systemmsg`;
                sqlString[2] = String.Format("TRUNCATE `trafficinforecord_minute`");
            }
            else
            {
                //ָ��ʱ��ε�
                sqlString[0] = String.Format("delete  from trafficinforecord where vehicle_time >= '{0}' and vehicle_time <= '{1}'", timestart.ToString("yyyy-MM-dd HH:mm:ss"), timeend.ToString("yyyy-MM-dd HH:mm:ss"));
                sqlString[1] = String.Format("delete  from trafficinforecord_hour where timehour >= '{0}' and timehour <= '{1}'", timestart.ToString("yyyy-MM-dd HH:mm:ss"), timeend.ToString("yyyy-MM-dd HH:mm:ss"));
                sqlString[2] = String.Format("delete  from trafficinforecord_minute where minutehour >= '{0}' and minutehour <= '{1}'", timestart.ToString("yyyy-MM-dd HH:mm:ss"), timeend.ToString("yyyy-MM-dd HH:mm:ss"));
                 
            }
            //�Ż�ɾ�����ݺ�����ݿ�
            sqlString[2] = String.Format("OPTIMIZE TABLE trafficinforecord, trafficinforecord_hour, trafficinforecord_minute,syssetting, systemmsg");
            try
            {
                bRet = ExecuteNonQuery(sqlString);
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }
            return bRet;
        }

        //���������Ч����
        //public bool ClearInvaliData()
        //{
        //    bool bRet = false;
        //    string[] sqlString = new string[2];
        //    //���Сʱ��������
        //    sqlString[0] = String.Format("delete from trafficinforecord_hour where detecttime < (select DATE_FORMAT(NOW(), '%Y-%m-%d %H:00:00'))");
        //    //�Ż�ɾ�����ݺ�����ݿ�,���Ż���ص����ݿ⣬����Ż���¼������ĺܶ�ʱ��
        //    sqlString[1] = String.Format("OPTIMIZE TABLE  `trafficinforecord_hour`");
        //    try
        //    {
        //        bRet = ExecuteNonQuery(sqlString);
        //    }
        //    catch (Exception ex)
        //    {
        //       DebugOutput.ProcessMessage(ex.ToString());//������ļ�
        //    }
        //    return bRet;
        //}
        //����packid
        public bool ResetSendRecord(int packid)
        {
            bool ret = false;

            string[] sqlString = new string[1];
            sqlString[0] = String.Format("INSERT INTO syssetting (keyinfo, valueinfo,modifiedtime) VALUES ('sendpackid', {0},now()) ON DUPLICATE KEY UPDATE valueinfo = {0},modifiedtime=now()", packid);
            try
            {
                ret = ExecuteNonQuery(sqlString);
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }
            return ret;
        }

        //��������5min�ϴ���¼
        public bool UpdateSend5MinRecord(DateTime preTime)
        {
            bool ret = false;

            string[] sqlString = new string[2];
            sqlString[0] = "";// String.Format("update trafficinforecord set upload5minflag = 1  where vehicle_time >= '{0}' and vehicle_time < '{1}'", preTime, preTime.AddMinutes(5));
            sqlString[1] = String.Format("INSERT INTO syssetting (keyinfo, valueinfo,modifiedtime) VALUES ('send5mintime', '{0}',now()) ON DUPLICATE KEY UPDATE valueinfo = '{0}',modifiedtime = now()", preTime);
            try
            {
                ret = ExecuteNonQuery(sqlString);
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }
            return ret;
        }
        //�Ż����ݿ�ı�
        public bool OptimizeDatabase()
        {
            bool status = false;
            DataSet ds = null;
            string msg;
            int rows;
            string[] sqlString = new string[1];
            sqlString[0] = String.Format("OPTIMIZE TABLE trafficinforecord, trafficinforecord_hour,trafficinforecord_minute, syssetting, systemmsg");
            try
            {
                ds = GetDataSet(sqlString[0]);
                if (ds != null)
                {
                    status = true;
                    rows = ds.Tables[0].Rows.Count;//����
                    while (rows-- >= 0)
                    {
                        msg = Convert.ToString(ds.Tables[0].Rows[0][2]);
                        if (msg.Contains("error") == true)
                        {
                            status = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }
            return status;
        }
    }
    #endregion

    #region GeoNetPushMySQLOpt
    public class GeoNetPushMySQLOpt : MySQLHelper
    {
        const int MAX_SENDPACK_ID = 0xffffff;

        /// <summary>
        /// /��ȡ���շ��͵�5min��ʱ��ֵ
        /// </summary>
        /// <returns></returns>
        public DateTime GetLastSend5MinTime()
        {
            DateTime lasttime = System.DateTime.Now;
            DateTime dbSysTime = System.DateTime.Now, dbLastUpladTime = DateTime.MaxValue;
            DataSet ds1 = null, ds2 = null, ds3 = null;
            string[] sqlString = new string[3];
            sqlString[0] = String.Format("SELECT concat(DATE_FORMAT(valueinfo,'%Y-%m-%d %H:'),floor(DATE_FORMAT(valueinfo, '%i')/5)*5,':00') as lasttime from syssetting where keyinfo = 'send5mintime'");
            sqlString[1] = String.Format("SELECT concat(DATE_FORMAT(detecttime,'%Y-%m-%d %H:'),floor(DATE_FORMAT(detecttime, '%i')/5)*5,':00') as detecttime from trafficinforecord where uploadflag = 0 limit 1 ");
            sqlString[2] = String.Format("SELECT concat(DATE_FORMAT(now(),'%Y-%m-%d %H:'),floor(DATE_FORMAT(now(), '%i')/5)*5,':00') as nowtime ");
            try
            {
                //����ϴ���ѯ
                ds1 = GetDataSet(sqlString[0]);
                if (ds1 != null)
                {
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        if (Convert.ToString(ds1.Tables[0].Rows[0][0]) != "")
                            dbLastUpladTime = Convert.ToDateTime(ds1.Tables[0].Rows[0][0]);
                    }
                }
                //δ�ϴ���¼��ѯ
                if (dbLastUpladTime == DateTime.MaxValue)
                {
                    ds2 = GetDataSet(sqlString[1]);
                    if (ds2 != null)
                    {
                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            if (Convert.ToString(ds2.Tables[0].Rows[0][0]) != "")
                                dbLastUpladTime = Convert.ToDateTime(ds2.Tables[0].Rows[0][0]);
                        }
                    }
                }
                //���ݿ��ʱ��
                ds3 = GetDataSet(sqlString[2]);
                if (ds3 != null)
                {
                    if (ds3.Tables[0].Rows.Count > 0)
                    {
                        if (Convert.ToString(ds3.Tables[0].Rows[0][0]) != "")
                            dbSysTime = Convert.ToDateTime(ds3.Tables[0].Rows[0][0]);
                    }
                }
                //�Ƚ�ʱ��
                lasttime = dbLastUpladTime;
                if (DateTime.Compare(dbLastUpladTime, dbSysTime) > 0)
                    lasttime = dbSysTime;
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }

            return lasttime;
        }

        //
        /// <summary>
        /// ��ȡ���͵�PACKIDֵ
        /// </summary>
        /// <returns></returns>
        public int GetLastSendPackID()
        {
            int nSendpackID = 1;
            DataSet ds = null;
            string[] sqlString = new string[1];
            sqlString[0] = String.Format("SELECT valueinfo from syssetting where keyinfo = '{0}' ", "sendpackid");
            try
            {
                ds = GetDataSet(sqlString[0]);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        nSendpackID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }

            return nSendpackID;
        }

        //
        /// <summary>
        /// ���������ϴ���¼
        /// </summary>
        /// <param name="dbrecordid"></param>
        /// <param name="PackID"></param>
        /// <returns></returns>
        public bool UpdateSendRecord(Int64 dbrecordid, int PackID)
        {
            bool ret = false;

            string[] sqlString = new string[2];
            sqlString[0] = String.Format("update trafficinforecord set uploadflag = 1,upload_time= now(),upload_packid = {1} where id = {0}", dbrecordid, PackID);//order by  vehicle_time ASC 
            sqlString[1] = String.Format("INSERT INTO syssetting (keyinfo, valueinfo,modifiedtime) VALUES ('sendpackid', {0},now()) ON DUPLICATE KEY UPDATE valueinfo = {0},modifiedtime=now()", PackID);
            try
            {
                ret = ExecuteNonQuery(sqlString);
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }
            return ret;
        }

        //
        /// <summary>
        /// ��������5min�ϴ���¼
        /// </summary>
        /// <param name="preTime"></param>
        /// <returns></returns>
        public bool UpdateSend5MinRecord(DateTime preTime)
        {
            bool ret = false;

            string[] sqlString = new string[2];
            sqlString[0] = "";// String.Format("update trafficinforecord set upload5minflag = 1  where vehicle_time >= '{0}' and vehicle_time < '{1}'", preTime, preTime.AddMinutes(5));
            sqlString[1] = String.Format("INSERT INTO syssetting (keyinfo, valueinfo,modifiedtime) VALUES ('send5mintime', '{0}',now()) ON DUPLICATE KEY UPDATE valueinfo = '{0}',modifiedtime = now()", preTime);
            try
            {
                ret = ExecuteNonQuery(sqlString);
            }
            catch (Exception ex)
            {
                DebugOutput.ProcessMessage(ex.ToString());//������ļ�
            }
            return ret;
        }
    }
    #endregion

    #region DetectorSimulateMySQLOpt
    public class DetectorSimulateMySQLOpt : MySQLHelper
    {
        const int MAX_SENDPACK_ID = 0xffffff;
    }
    #endregion

}
