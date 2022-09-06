using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    internal class DataBaseFirstApproach
    {
        public static void Main()
        {
            Updatedetails();
            //GetEmpStoredProcedure();
            //UpdateEmpDetails();
            // DeleteEmpDetails();
            // AddNewEmployee();
            //AddNewEmployee();
            //GetAllEmpDetails();
            // GetEmpDetailsByID(); 
            Console.ReadLine();

        }

        //private static void getallempdetails()
        //{
        //    var ctx = new trainingcontext();
        //    var emps = ctx.emps;
        //    foreach (var emp in emps)
        //    {
        //        console.writeline(emp.ename + "" + emp.sal);
        //    }

        //    //private static void getempdetailsbyid()
        //    //{
        //    //    var ctx = new trainingcontext();
        //    //    var emp = ctx.emps.where(e => e.empno == 7499).singleordefault();
        //    //    console.writeline(emp.ename + "  " + emp.sal + "  "+ emp.job);
        //    //}


        //}

        //private static void AddNewEmployee()

        //{
        //    var ctx = new TrainingContext();
        //    try
        //    {
        //        Batch1_DET_2022.Models.Emp employee = new Batch1_DET_2022.Models.Emp();
        //        employee.Empno = 9998;
        //        employee.Ename = "Kishor";
        //        employee.Sal = 100000;
        //        employee.Deptno = 40;
        //        employee.Job = "Trainee";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Employee Added");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //public static void DeleteEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 9999).SingleOrDefault();
        //    ctx.Remove(emp);
        //    ctx.SaveChanges();

        //}
        //public static void DeleteEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    try
        //    {
        //        Batch1_DET_2022.Models.Emp employee = new Batch1_DET_2022.Models.Emp();
        //        employee.Empno = 9998;
        //        ctx.Remove(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("employee deleted");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}
        ////public static void UpdateEmpDetails()
        ////{
        ////    var ctx = new TrainingContext();
        ////    var emp = ctx.Emps.Where(e => e.Empno == 1234).SingleOrDefault();

        ////    emp.Ename = "ramu";
        ////    ctx.Update(emp);
        ////    ctx.SaveChanges();
        ////    Console.WriteLine("updated");
        ////}


        //public static void UpdateEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    try
        //    {
        //        Batch1_DET_2022.Models.Emp employee = new Batch1_DET_2022.Models.Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "gg";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("employee details updated");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        //private static void GetEmployeesSP()
        //{
        //    var ctx = new TrainingContext();
        //    var employee = ctx.Emps.FromSqlRaw($"getAll").ToList();

        //    foreach (var e in employee)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}


        //private static void GetEmpStoredProcedure()
        //{
        //    var ctx = new TrainingContext();
        //    var employees = ctx.Emps.FromSqlRaw("GetAllEmpsDetails").ToList();

        //    foreach (var e in employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}

        //private static void GetEmpStoredProcedure()
        //{
        //    var ctx = new TrainingContext();
        //    var employees = ctx.Emps.FromSqlRaw($"GetAllEmpsDetailsByEmpNo @p0", 7499).ToList();

        //    foreach (var e in employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}


        private static void Updatedetails()
        {
            var ctx = new TrainingContext();
            try
            {
                var id = 7566;
                string newName = "RAMU";
                int employee = ctx.Database.ExecuteSqlRaw("updatename @p0,@p1", id, newName);
                Console.WriteLine(employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }
    }
}