using Assignment01_EF.Data;

namespace Assignment01_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITI_Context db = new ITI_Context();

            #region Insert
            //Student st1 = new Student()
            //{
            //    FName = "Mohamed",
            //    LName = "Ahmed",
            //    Age = 25,
            //    Address = "Cairo",
            //    Dept_Id = 1
            //};
            //Console.WriteLine("Before Add To DB");
            //Console.WriteLine(db.Entry(st1).State);
            //db.Add(st1);
            //db.SaveChanges();
            //Console.WriteLine("After Add To DB");
            //Console.WriteLine(db.Entry(st1).State);

            //Student st2 = new Student()
            //{
            //    FName = "Noha",
            //    LName = "Khaled",
            //    Age = 22,
            //    Address = "Alex",
            //    Dept_Id = 2
            //};
            //Console.WriteLine("Before Add To DB");
            //Console.WriteLine(db.Entry(st2).State);
            //db.Add(st2);
            //db.SaveChanges();
            //Console.WriteLine("After Add To DB");
            //Console.WriteLine(db.Entry(st2).State);

            //Student st3 = new Student()
            //{
            //    FName = "Fadi",
            //    LName = "Ali",
            //    Age = 33,
            //    Address = "Tanta",
            //    Dept_Id = 1
            //};
            //Console.WriteLine("Before Add To DB");
            //Console.WriteLine(db.Entry(st3).State);
            //db.Add(st3);
            //db.SaveChanges();
            //Console.WriteLine("After Add To DB");
            //Console.WriteLine(db.Entry(st3).State);

            //Student st4 = new Student()
            //{
            //    FName = "Alaa",
            //    LName = "Kareem",
            //    Age = 26,
            //    Address = "Alex",
            //    Dept_Id = 1
            //};
            //db.Add(st4);
            //db.SaveChanges(); 
            #endregion

            #region Update

            //var st = db.Students.FirstOrDefault(s => s.Id==5);
            //Console.WriteLine(st?.FName ?? "N/A");
            //if (st!=null)
            //{
            //    st.FName = "Marwa";
            //}
            //db.SaveChanges();
            //Console.WriteLine(st.FName); 

            #endregion

            #region Delete
            //var str = db.Students.FirstOrDefault(s => s.Id==5);
            //if (str!=null)
            //{
            //    Console.WriteLine("Before Delete");
            //    Console.WriteLine(db.Entry(str).State);
            //    db.Remove(str);
            //    db.SaveChanges();
            //    Console.WriteLine("After Delete");
            //    Console.WriteLine(db.Entry(str).State);
            //} 
            #endregion

            #region Read
            //var students = db.Students.ToList();
            //foreach (var s in students)
            //{
            //    Console.WriteLine($"Id:{s.Id} ....Full Name: {s.FName +' '+ s.LName}.....Age: {s.Age}.....Dept Id: {s.Dept_Id}....Address: {s.Address}");
            //} 
            #endregion
        }
    }
}
