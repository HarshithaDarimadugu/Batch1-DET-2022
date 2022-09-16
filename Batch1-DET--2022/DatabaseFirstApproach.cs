using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET__2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Batch1_DET__2022
{
    internal class DatabaseFirstApproach
    {
        //public static void Main()
        //{

        //}
        static void Main(string[] args)
        {
            //GetAllEmpDetails();
            //GetEmpDetailsByID();
            //AddNewEmployee();
            //Deleteemp();
            //Updateemp();
            //Console.ReadLine();
            //StoredProcedureupdateEmployeeDetails();
            //CallStoredProcwithSQLParamater_insert();
            updatenames();
        }

        private static void updatenames()
        {

            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7499
                        },

                         new SqlParameter() {
                            ParameterName = "@newname",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Eldin"},

                          //new SqlParameter() {
                          //  ParameterName = "@sal",
                          //  SqlDbType =  System.Data.
                          //  SqlDbType.Decimal,
                          //  Size = 100,
                          //  Direction = System.Data.
                          //  ParameterDirection.Input,
                          //  Value = 1000},

                           //new SqlParameter() {
                           // ParameterName = "@deptno",
                           // SqlDbType =  System.Data.
                           // SqlDbType.Decimal,
                           // Size = 100,
                           // Direction = System.Data.
                           // ParameterDirection.Input,
                           // Value = 10},

                           // new SqlParameter() {
                           // ParameterName = "@job",
                           // SqlDbType =  System.Data.
                           // SqlDbType.VarChar,
                           // Size = 100,
                           // Direction = System.Data.
                           // ParameterDirection.Input,
                           // Value = "Analyst"},


                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("updatenames @empno, @newname" , param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }

            Console.WriteLine("update successful");

        }
            
    }

        //private static void Deleteemp()
        //{
        //    var ctx = new TrainingContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "MIKE";
        //        employee.Sal = 3000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Details of one employee is ");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void Updateemp()
        //{
        //    var ctx = new TrainingContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "SHEELA";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "Manager";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Details of one employee is updated");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //        throw;
        //    }
        //}
        //    private static void StoredProcedureupdateEmployeeDetails()
        //    {
        //        var ctx = new TrainingContext();
        //        var employee = ctx.Emps.FromSqlRaw("Update employee set Sal = 1500 where EMPNO = 7499");
        //        foreach (var emp  in employee)
        //        {
        //            Console.WriteLine(emp.Sal);
        //        }
        //    }
        //}
    }

    //private static void AddNewEmployee()
    //{
    //    var ctx = new TrainingContext();

    //    try
    //    {
    //        Emp employee = new Emp();
    //        employee.Empno = 2979;
    //        employee.Ename = "Harshi";
    //        employee.Sal = 1000;
    //        employee.Deptno = 30;
    //        employee.Job = "Trainee";
    //        ctx.Add(employee);
    //        ctx.SaveChanges();
    //        Console.WriteLine("New employee added");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.InnerException.Message);
    //    }
    //}
    //private static void GetEmpDetailsByID()
    //{
    //    var ctx = new TrainingContext();
    //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
    //    Console.WriteLine(emp.Ename + "   " + emp.Sal + " " + emp.Job);


    //}
    //private static void GetAllEmpDetails()
    //{
    //    var ctx = new TrainingContext();
    //    var emps = ctx.Emps;

    //    foreach (var emp in emps)
    //    {
    //        Console.WriteLine(emp.Ename + " " + emp.Sal);
    //    }
    //}

    





