using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class program2
    {
        static void Main(string[] args)
        {
            // GetAllEmpDetails();
            // GetAllEmpDetailByID();
            //  UpdateEmployee();
            // AddEmployee();
            //  DeleteEmployee();
            // GetEmployeesStoredpr();
           // StoredProcedureWithPara();
            CallStoredProcwithSQLParamater_insert();
            Console.ReadLine();
         

        }
        //private static void UpdateEmployee()
        //{
        //    var ctx = new trainingContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "Supreet";
        //        employee.Sal = 15000;
        //        employee.Deptno = 20;
        //        employee.Job = "Trainer";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Employee details updated");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //    private static void GetAllEmpDetailByID()
        //{
        //    var ctx = new trainingContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emp.Ename + "  " + emp.Sal + " " + emp.Job);
        //}
        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new trainingContext();
        //    var emps = ctx.Emps;

        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + "  " + emp.sal);
        //    }
        //}

        //private static void AddEmployee()
        //{
        //    var ctx = new trainingContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7000;
        //        employee.Ename = "Raju";
        //        employee.Sal = 1500;
        //        employee.Deptno = 10;
        //        employee.Job = "Trainer";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Employee details Added");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void DeleteEmployee()
        //{
        //    var ctx = new trainingContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7000;
        //        employee.Ename = "Raju";
        //        employee.Sal = 1500;
        //        employee.Deptno = 10;
        //        employee.Job = "Trainer";
        //        ctx.Remove(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Employee details Removed");


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void GetEmployeesStoredpr()
        //{
        //    var ctx = new trainingContext();
        //    var employee = ctx.Emps.FromSqlRaw($"GetEmployeeDetails1").ToList();

        //    foreach (var e in employee)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}

        private static void StoredProcedureWithPara()
        {
            var ctx = new trainingContext();
           

            var employee = ctx.Emps.FromSqlRaw("GetAllEmpsDetailsByEmpno @p0",7900);

            foreach (var e in employee)
            {
                Console.WriteLine(e.Ename);
            }
            
                   }
        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new trainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7522
                        },

                         new SqlParameter() {
                            ParameterName = "@newname",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "WARNER"},

                         new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "WARNER"},

                          new SqlParameter() {
                           ParameterName = "@mgr",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7782 },

                           new SqlParameter() {
                            ParameterName = "@hiredate",
                            SqlDbType =  System.Data.
                            SqlDbType.Date,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "09/05/2022"},

                            new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 2500
                        },
                             new SqlParameter() {
                            ParameterName = "@comm",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 500
                        },

                             new SqlParameter() {
                            ParameterName = "@dept",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 20
                        },







            };

                        
                        
                           
            try
            {
                var result = ctx.Database.ExecuteSqlRaw("updatenames1 @empno, @newname, @job, @mgr, @hiredate, @sal, @comm, @dept", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }
    }
}

