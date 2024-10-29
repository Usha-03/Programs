using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.IO;

namespace Console_App_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Server=USHA\\USHA;Database=EmployeDB;User id=sa;Password=user123;Trusted_Connection=True;TrustServerCertificate=True;";               
                //Console.WriteLine("Connection successful");

                //Calling GetAllEmployees

                GetallEmployees(connectionString);

                //Calling GetEmployeeByID

                //Calling GetAllEmployees GetAllEmployees(connectionString);

                //Calling GetEmployeeByID
                int EmployeeId = 1;

                GetallEmployeeId(connectionString, EmployeeId);

                //Calling CreateEmployee WithAddress
                Console.WriteLine("Enter firstName: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter lastName: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter street: ");
                string street = Console.ReadLine();
                Console.WriteLine("Enter city: ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter states: ");
                string states = Console.ReadLine();
                Console.WriteLine("Enter postalCode: ");
                string postalCode = Console.ReadLine();

                //string firstName = "Usha";
                //string lastName = "sri";
                //string email = "ushasri@Example.com";
                //string street = "123 Usha";
                //string city = "BBSR";
                //string states = "Hunsur";
                //string postalCode = "755019";

                CreateEmployeeWithAddress(connectionString, firstName, lastName, email, street, city, states, postalCode);

                //Calling UpdateEmployeeWithAddress

                EmployeeId = 3;
                firstName = "Rakesh";
                lastName = "Sharma";
                email = "Rakesh@Example.com";
                street = "3456 Patia";
                city = "CTC";
                states = "Bengaluru";
                postalCode = "755024";

                int AddressId = 3;

                UpdateEmployeeWithAddress(connectionString, EmployeeId, firstName, lastName, email, street, city, states, postalCode, AddressId);

                //Calling

                EmployeeId = 12;

                DeleteEmployee(connectionString, EmployeeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
        }
        static void GetallEmployees(string connectionString)
        {
            Console.WriteLine("GetallEmployees Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("GetallEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Console.WriteLine($"EmployeeID: {reader["EmployeeId"]}, FirstName: {reader["firstName"]},LastName: {reader["lastName"]}, Email: {reader["email"]}");

                    Console.WriteLine($"Address: {reader["street"]},{reader["city"]},{reader["states"]}, PostalCode: {reader["postalCode"]}\n");

                }
                reader.Close();
                connection.Close();
            }
        }

        static void GetallEmployeeId(string connectionString, int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeeByID Stored Procedure Called");
                SqlCommand command = new SqlCommand(cmdText: "GetallEmployeeId", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter for EmployeelD
                command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeID: {reader["EmployeeId"]}, FirstName: {reader["firstName"]},LastName: {reader["lastName"]}, Email: {reader["email"]}");

                    Console.WriteLine($"Address: {reader["street"]},{reader["city"]},{reader["states"]}, PostalCode: {reader["postalCode"]}\n");
                }
                reader.Close();
                connection.Close();
            }
        }

        static void CreateEmployeeWithAddress(string connectionString, string firstName, string lastName, string email, string street, string city, string states, string postalCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Create EmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("CreateEmployeeWithAddresses", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters for Employee and Address
                command.Parameters.AddWithValue("@firstName", firstName);

                command.Parameters.AddWithValue("@lastName", lastName);

                command.Parameters.AddWithValue("@email", email);

                command.Parameters.AddWithValue("@street", street);

                command.Parameters.AddWithValue("@city", city);

                command.Parameters.AddWithValue("@states", states);

                command.Parameters.AddWithValue("@postalCode", postalCode);

                connection.Open();

                command.ExecuteNonQuery();

                Console.WriteLine("Employee and Address created successfully.");
                Console.WriteLine();
                connection.Close();
            }
        }

        static void UpdateEmployeeWithAddress(string connectionString, int EmployeeId, string firstName, string lastName, string email, string street, string city, string states, string postalCode, int AddressId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                Console.WriteLine("Update EmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters for Employee and Address

                command.Parameters.AddWithValue("@EmployeeID", EmployeeId);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@states", states);
                command.Parameters.AddWithValue("@postalCode", postalCode);
                command.Parameters.AddWithValue("@AddressId", AddressId);
                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Employee and Addresses updated successfully.");
                Console.WriteLine();

                connection.Close();
            }
        }
        static void DeleteEmployee(string connectionString, int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine(value: "Delete Employee Stored Procedure Called");
                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for EmployeeID
                command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine(value: "Employee and their Address deleted successfully.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(value: "Employee not found.");
                }
                connection.Close();

            }
        }

    }
}