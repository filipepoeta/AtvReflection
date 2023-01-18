using System.Reflection;
using AtvReflection;

class Program{

static void Main(string[] args){
    DisplayPublicProperties();
    
}

public static void DisplayPublicProperties(){
    PropertyInfo[] propertyInfos = CreateInstance().GetType().GetProperties();
    System.Console.WriteLine(CreateInstance());
    foreach (var item in propertyInfos)
    {
        System.Console.WriteLine($"Propriedade: {item.Name} dop tipo {item.PropertyType.Name}");
    }
    
}


public static Student CreateInstance(){
    Student student = Activator.CreateInstance<Student>();
    PropertyInfo[] propertyInfos = student.GetType().GetProperties();
    foreach (var item in propertyInfos)
    {
        if(item.Name == "Name") {
            item.SetValue(student, "Filipe");
        }
        if (item.Name == "University"){
            item.SetValue(student, "Cruzeiro do Sul");
        }
        if (item.Name == "RollNumber"){
            item.SetValue(student, 7);
        }
    }
    student.DisplayInfo();
 return student;   
}

}