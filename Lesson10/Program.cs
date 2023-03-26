namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pupil pupil = new Pupil("John", "Wilson", 127);
            

            //Teacher teacherToUpdate = new Teacher("Jane", "Doe", "Math");
            //UpdateTeacher(teacherToUpdate, "John", "Smith", "Science");

            List <Classes> classes = new List<Classes>();
            new Classes("Math");
            new Classes("Literature");
            new Classes("English");

            Classes.AddClass(classes, "History");

            // Print the list of classes
            foreach (var c in classes)
            {
                Console.WriteLine(c.name);
            }


        }
    }
}