using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loan
{
    using loan;
    using System.Data.SqlClient;
    using System.Net;
    using System.Reflection;

    internal class DB
    {
        SqlConnection conn;

        public void opening()
        {
            conn = new SqlConnection("Data Source=" + "LAPTOP-N3GG0U8P\\SQLEXPRESS;" + "database=loan;" + "integrated security=SSPI");
            conn.Open();
        }
        //customer 

        //insert customer details
        public void insert1()
        {
            Console.WriteLine("Enter your account number");
            var accno = Console.ReadLine();
            Console.WriteLine("Enter your first name");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            var lname = Console.ReadLine();
            Console.WriteLine("Enter your mobile number");
            int mobile  = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your address");
            var address = Console.ReadLine();
            Console.WriteLine("Enter your job");
            var job = Console.ReadLine();
            Console.WriteLine("Enter your salary");
            int salary = (int)Convert.ToInt64(Console.ReadLine());
            
            SqlCommand cmd = new SqlCommand("insert into customer values(@accno, @fname, @lname, @mobile , @address , @job ,@salary) ", conn);
            cmd.Parameters.AddWithValue("@accno", accno);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@job", job);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.ExecuteNonQuery();

        }

        // insert loan details
        public void insert2()
        {
            Console.WriteLine("Enter your account number");
            var accno = Console.ReadLine();
            Console.WriteLine("Enter your loan type");
            var type = Console.ReadLine();
            Console.WriteLine("Enter your loan amount");
            int amount = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your loan tenure");
            int tenure = (int)Convert.ToInt64(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("insert into loans(account_no, loan_type, loan_amount, loan_year, status) values(@accno, @type, @amount, @tenure ,'pending') ", conn);
            cmd.Parameters.AddWithValue("@accno", accno); 
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@tenure", tenure);
            cmd.ExecuteNonQuery();

        }

        public void update1()
        {

            Console.WriteLine("Enter loan id");
            var id = Console.ReadLine();

            Console.WriteLine("1.Update loan type\n 2.Update loan amount\n 3.Update loan term");
            int loanupdate =Convert.ToInt32(Console.ReadLine());

            switch (loanupdate)
            {
                case 1: Console.WriteLine("Enter new loan type");
                    var type = Console.ReadLine();
                    SqlCommand cmd = new SqlCommand("update loans set loan_type=@type where loan_id=@id ", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("loan type is updated");
                    break;

                case 2:
                    Console.WriteLine("Enter new loan amount");
                    var amount = Console.ReadLine();
                    SqlCommand cma = new SqlCommand("update loans set loan_amount=@amount where loan_id=@id ", conn);
                    cma.Parameters.AddWithValue("@id", id);
                    cma.Parameters.AddWithValue("@amount", amount);
                    cma.ExecuteNonQuery();
                    Console.WriteLine("loan amount is updated");
                    break;

                case 3:
                    Console.WriteLine("Enter new loan term");
                    var term = Console.ReadLine();
                    SqlCommand cmb = new SqlCommand("update loans set loan_year=@term where loan_id=@id ", conn);
                    cmb.Parameters.AddWithValue("@id", id);
                    cmb.Parameters.AddWithValue("@term", term);
                    cmb.ExecuteNonQuery();
                    Console.WriteLine(" loan term is updated");
                    break;
            }
            

        }
      

        public void delete()
        {

            Console.WriteLine("Enter your loan id");
            var id = Console.ReadLine();
            SqlCommand cmd = new SqlCommand(" delete from loans where loan_id =@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Console.WriteLine("The loan application is deleted");
        }
        // see my applied loan details
        public void select1()
        {
            Console.WriteLine("Enter your account number");
            var accno = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("select * from loans where account_no=@accno", conn);
            cmd.Parameters.AddWithValue("@accno", accno);
            SqlDataReader item = cmd.ExecuteReader();
            while (item.Read())
            {
                Console.WriteLine(item["loan_id"] + " " + item["loan_type"] + " " + item["loan_amount"] + " " + item["loan_year"] + " " + item["status"]);
            }
            item.Close();
        }
            //admin

        //see all the applied loans

        public void select2()
        {
            SqlCommand cmd = new SqlCommand("select * from loans ", conn);
            SqlDataReader item = cmd.ExecuteReader();
            while (item.Read())
            {
                Console.WriteLine(item["account_no"] + " " + item["loan_id"] + " " + item["loan_type"] + " " + item["loan_amount"] + " " + item["loan_year"] + " " + item["status"]);
            }
            item.Close();
        }

        //see the loans to be accepted or rejected
        public void select3()
        {
            SqlCommand cmd = new SqlCommand("Select * from loans where status='pending'", conn);
            SqlDataReader item = cmd.ExecuteReader();
            while (item.Read())
            {
                Console.WriteLine(item["account_no"] + " " + item["loan_id"] + " " + item["loan_type"] + " " + item["loan_amount"] + " " + item["loan_year"] + " " + item["status"]);
            }
            item.Close();
        }
        //accept or reject the loan
        public void update2()
        {
            Console.WriteLine("Enter the loan id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the status ");
            var status = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("update loans set status=@status where loan_id=@id ", conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void closing()
        {
            conn.Close();
        }
    }
}
