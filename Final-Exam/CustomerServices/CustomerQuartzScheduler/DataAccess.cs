using CustomerServicesEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQuartzScheduler
{
    class DataAccess
    {
      public  void DeleteCustomers()
        {

            var connStr = System.Configuration.ConfigurationManager.ConnectionStrings["J2EENorthwind"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand Command = new SqlCommand(@"  IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE 
				--TABLE_SCHEMA = 'dbo' 
                -- AND 
				 TABLE_CATALOG = 'CUSTOMERDATA' AND
				 TABLE_NAME = 'Customer_BACKUP1'))
	BEGIN
	 INSERT INTO Customer_BACKUP1
	 SELECT *
	  FROM dbo.Customer
	END
ELSE
	BEGIN
	 SELECT * INTO Customer_BACKUP1
	 FROM dbo.Customer
	END
 ", conn);
            SqlCommand Command1 = new SqlCommand(@"DELETE FROM CUSTOMER",conn);

            //Command.Parameters.AddWithValue("@word", word);
            Command.ExecuteNonQuery();
            Command1.ExecuteNonQuery();


            //using (CUSTOMERDATAEntities context = new CUSTOMERDATAEntities())
            //{

            //    var customerEntity = (from cust in context.CustomerEntities select cust).ToList();
            //    context.CustomerEntities.RemoveRange(customerEntity);
            //}
        

        }
    }
}
