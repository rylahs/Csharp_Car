using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform0311.DTO;

namespace winform0311.DAO
{
    internal class DaoOracle
    {
        static DaoOracle inst;
        static string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "USER ID=test;Password=1234";

        OracleConnection conn;
        OracleCommand cmd;

        public static DaoOracle Instance()
        {
            if (inst == null)
                inst = new DaoOracle();
            return inst;
        }

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnection();
        }
        ~DaoOracle()
        {
            this.dbClose();
        }

        public void dbConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Oracle DB Connection Success!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Connection Error!");
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }
        public void dbClose()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("Oracle DB Disconnection Success!");
                }


            }
            catch (OracleException ex)
            {
                Console.WriteLine("Disconnection Error!");
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }
        public void createTable()
        {
            string tbName = "testTB1";
            try
            {
                string sql = "create table " + tbName + " (" +
                    "ID NUMBER NOT NULL," +
                    "NAME VARCHAR2(20) NOT NULL," +
                    "AGE NUMBER NOT NULL," +
                    "ADDRESS VARCHAR2(80) NOT NULL," +
                    "CONSTRAINT PK_TESTTB1_ID PRIMARY KEY(ID))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Create Table Success! : " + tbName);

                string sql2 = "create sequence seq_id increment " +
                    "by 1 start with 1";
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Create Sequence Success!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Create Table, Sequence Error!");
                Console.WriteLine(ex.StackTrace);
            }

        }

        public void dropTable()
        {
            string tbName = "testTB1";
            try
            {
                string sql = "drop table " + tbName;
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Drop Table Success! : " + tbName);

                string sql2 = "drop sequence seq_id";
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Drop Sequence Success!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Drop Table, Sequence Error!");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void insertData()
        {
            string tbName = "testTB1";
            try
            {
                string name = "홍길동";
                int age = 300;
                string address = "조선 한양 홍대감댁 11번지";
                string sql = string.Format($"insert into " + tbName + " values " +
                    $"(seq_id.nextval, '{name}', {age}, '{address}')");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Insert Data Success!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Insert Data Error!");
                Console.WriteLine(ex.StackTrace);
            }
        }


        public void insertData(Receipt receipt)
        {
            try
            {
                string sql = string.Format(
                    "insert all " +
                    "into car_t values (car_t_seq.nextval, '{0}', '{1}', '{2}', '{3}')",
                    receipt.Car.Model, receipt.Car.Number,
                    receipt.Car.Cc, receipt.Car.Year);
                sql += string.Format(
                    "into customer_t values (customer_t_seq.nextval, '{0}', '{1}', '{2}', CAR_T_SEQ.currval)",
                    receipt.Customer.Name, receipt.Customer.Tel,
                    receipt.Customer.Birth);
                sql += "select * from dual";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Insert Data Success!");

                List<RepairItem> itemList = receipt.ItemList;
                for (int j = 0; j < itemList.Count; j++)
                {
                    string sqlItem = string.Format(
                        "insert into repair_item_t values (REPAIR_ITEM_T_SEQ.nextval, " +
                        "'{0}', '{1}', car_t_seq.currval)",
                        itemList[j].Repair, itemList[j].Price);
                    cmd.CommandText = sqlItem;
                    cmd.ExecuteNonQuery();
                }

                string sqlRec = string.Format(
                    "insert into receipt_t values (RECEIPT_T_SEQ.nextval, '{0}', '{1}'," +
                    "'{2}', customer_t_seq.currval, " +
                    "(select staff_id from staff_t where staff_t.staff_name = '{3}'))",
                    receipt.InDate, receipt.TotalPrice, receipt.RepairCheck, receipt.StaffName);
                cmd.CommandText = sqlRec;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Insert Data Error!");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void updateData()
        {
            string tbName = "testTB1";
            try
            {
                string name = "김길동";
                int age = 200;
                string address = "조선 개성 박대감댁 11번지";
                string sql = string.Format($"update " + tbName + " set " +
                    $"name = '{name}', age = {age}, address = '{address}'" +
                    $"where id = 1");

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Update Data Success!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Update Data Error!");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void DeleteData()
        {
            string tbName = "testTB1";
            try
            {
                string sql = string.Format($"delete from " + tbName +
                    $" where id = 5");
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Delete Data Success!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Delete Data Error!");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void SelectData()
        {
            try
            {
                string sql = "select * from TESTTB1 order by id desc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("ID : " + reader["id"]);
                        Console.WriteLine("이름 : " + reader["name"]);
                        Console.WriteLine("나이 : " + reader["age"]);
                        Console.WriteLine("주소 : " + reader["address"]);
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 조회 에러 : " + ex.StackTrace);
            }
        }


        public void SelectData2()
        {
            try
            {
                string sql = "select receipt_date as 접수날짜, receipt_price as 총결제금액, " +
                    "(select staff_t.staff_name from staff_t " +
                    "where staff_t.staff_id = receipt_t.staff_id) as 담당자, " +
                    "(select customer_t.cust_name from customer_t " +
                    "where customer_t.cust_id = receipt_t.cust_id) as 고객명, " +
                    "(select customer_t.cust_tel from customer_t " +
                    "where customer_t.cust_id = receipt_t.cust_id) as 고객전화, " +
                    "(select car_t.car_num from car_t " +
                    "where car_t.car_id = receipt_t.cust_id) as 차량번호, " +
                    "receipt_check as 수리상태 " +
                    "from receipt_t";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("접수날짜 : " + reader["접수날짜"]);
                        Console.WriteLine("총결제금액 : " + reader["총결제금액"]);
                        Console.WriteLine("담당자 : " + reader["담당자"]);
                        Console.WriteLine("고객명 : " + reader["고객명"]);
                        Console.WriteLine("고객 전화 : " + reader["고객전화"]);
                        Console.WriteLine("차량번호 : " + reader["차량번호"]);
                        Console.WriteLine("수리상태 : " + reader["수리상태"]);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 조회 에러 : " + ex.StackTrace);
            }

            try
            {
                string queryItem = "select repair_item_t.repair_item_name as 수리항목, " +
                               "repair_item_t.repair_item_price as 수리단가 " +
                               "from repair_item_t " +
                               "where repair_item_t.car_id = " +
                               "(select customer_t.car_id from customer_t " +
                               "where customer_t.cust_name = '박박박')";
                cmd.CommandText = queryItem;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("수리항목 : " + reader["수리항목"]);
                        Console.WriteLine("수리금액 : " + reader["수리단가"]);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 조회 에러 : " + ex.StackTrace);
            }

        }


        public List<ReceiptItem> getReceiptVO()
        {
            List<ReceiptItem> listRec = null;
            try
            {
                string sql = "create or REPLACE view receipt_view2 " +
                    "as select receipt_date as 접수날짜, receipt_price as 총결제금액, " +
                    "(select staff_t.staff_name from staff_t " +
                    "where staff_t.staff_id = receipt_t.staff_id) as 담당자, " +
                    "(select customer_t.cust_name from customer_t " +
                    "where customer_t.cust_id = receipt_t.cust_id) as 고객명, " +
                    "(select customer_t.cust_tel from customer_t " +
                    "where customer_t.cust_id = receipt_t.cust_id) as 고객전화, " +
                    "(select car_t.car_num from car_t " +
                    "where car_t.car_id = receipt_t.cust_id) as 차량번호, " +
                    "receipt_check as 수리상태 " +
                    "from receipt_t order by receipt_id desc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string sql2 = "select * from receipt_view2";
                cmd.CommandText = sql2;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                listRec = new List<ReceiptItem>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listRec.Add(new ReceiptItem(
                            reader["접수날짜"].ToString(),
                            reader["총결제금액"].ToString(),
                            reader["담당자"].ToString(),
                            reader["고객명"].ToString(),
                            reader["고객전화"].ToString(),
                            reader["차량번호"].ToString(),
                            reader["수리상태"].ToString()));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("데이터 조회 에러 : " + ex.StackTrace);
            }
            return listRec;
        }

        public List<RepairItem> getRepairVo()
        {
            List<RepairItem> list = null;
            try
            {
                string queryItem = "select repair_item_t.repair_item_name as 수리항목, " +
                               "repair_item_t.repair_item_price as 수리단가 " +
                               "from repair_item_t " +
                               "where repair_item_t.car_id = " +
                               "(select customer_t.car_id from customer_t " +
                               "where customer_t.cust_name = '두두두')";
                cmd.CommandText = queryItem;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                list = new List<RepairItem>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new RepairItem(
                            reader["수리항목"].ToString(),
                            int.Parse(reader["수리단가"].ToString())));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("수리항목 보기 에러 : " + ex.StackTrace);
            }
            return list;
        }

        public List<RepairItem> getRepairVo(string name, string tel)
        {
            List<RepairItem> list = null;
            
            try
            {
                string queryItem =
                    string.Format("select repair_item_t.repair_item_name as 수리항목, " +
                                "repair_item_t.repair_item_price as 수리단가 " +
                                "from repair_item_t " +
                                "where repair_item_t.car_id = (select customer_t.car_id from customer_t " +
                                $"where customer_t.cust_name = '{name}' and customer_t.cust_tel = '{tel}')");
                cmd.CommandText = queryItem;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                list = new List<RepairItem>();
                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new RepairItem(
                            reader["수리항목"].ToString(),
                            int.Parse(reader["수리단가"].ToString())));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("수리항목 보기 에러 : " + ex.StackTrace);
            }
            return list;
        }
    }
}
