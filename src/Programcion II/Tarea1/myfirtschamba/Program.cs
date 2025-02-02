using Uni;
using Comunity_Members;
using empleado;
using estudiante;
using exalumno;
using docente;
using administrator;
using maestro;
using administrativo;

University entity = new University();
CommunityMembers members1 = new CommunityMembers();
Empleado emple1 = new Empleado();
Estudiante estu1 = new Estudiante();
Estudiante estu2 = new Estudiante();
Exalumno exalum1 = new Exalumno();
Exalumno exalum2 = new Exalumno();
Docente docente1 = new Docente();
Docente docente2 = new Docente();
Administrativo admin1 = new Administrativo();
Administrator person1 = new Administrator();
Maestro person2 = new Maestro();

/*Jose Manuel Santillan*/

/*Universidad*/
entity.UniName = "Harvard";
entity.Years = 388;
entity.Students = 22000;
entity.numberofCommunities = 12;
entity.Employees = 4671;
entity.Location = "California";

Console.WriteLine($"El nombre de la universidad es {entity.UniName}");
Console.WriteLine($"tiene {entity.Years} años");
Console.WriteLine($"tiene {entity.Students} Estudiantes");
Console.WriteLine($"Ademas cuenta con {entity.numberofCommunities} comunidades");
Console.WriteLine($"{entity.Employees} empleados");
Console.WriteLine($" Y esta ubicado en el estado de {entity.Location}");
Console.WriteLine(" ");
/*Miembros de al comunidad*/

Console.WriteLine($"Los miembros de la comunidad son {members1.identifier[0]}, {members1.identifier[1]} y {members1.identifier[2]}");

/*----------------Empleados--------------*/
Console.WriteLine(" ");
Console.WriteLine($"Los empleados son los {emple1.identifier[0]} y los {emple1.identifier[1]}");

/*Docente*/ 

docente1.DocNombres = "Administradores";
docente2.DocNombres = "Maestros";
Console.WriteLine(" ");
Console.WriteLine($"Los docentes son los {docente1.DocNombres} y los {docente2.DocNombres}");


/*Administrador*/
person1.Id=1000111; 
person1.Name = "Julio";
person1.LastName = "Cesar";
person1.Salary = 5000;

Console.WriteLine($"Esta persona es un {person1.identifier[1]}");
Console.WriteLine($"Su id es: {person1.Id}");
Console.WriteLine($"Su nombre es: {person1.Name}");
Console.WriteLine($"Su salario es {person1.Salary}");
Console.WriteLine(" ");



/*Maestro*/
person2.Id = 1000001;
person2.Name = "Angel";
person2.LastName = "Gabriel";
person2.Salary = 3000;

Console.WriteLine($"Esta persona es un {person2.identifier[0]}");
Console.WriteLine($"Su id es: {person2.Id}");
Console.WriteLine($"Su nombre es: {person2.Name}");
Console.WriteLine($"Su salario es {person2.Salary}");
Console.WriteLine(" ");

Console.WriteLine("Tanto maestros como administrador son docentes");
Console.WriteLine("");

/*Ex alumnos*/

exalum1.Name = "Carlos";
exalum1.LastName = "Sánchez";
exalum1.identifier = "Ex alumno";

            
exalum2.Name = "Lucía";
exalum2.LastName = "Gómez";
exalum2.identifier = "Ex alumno";

            
Console.WriteLine($"{exalum1.Name} {exalum1.LastName}, es un {exalum1.identifier}");
Console.WriteLine($"{exalum2.Name} {exalum2.LastName}, es un {exalum2.identifier}");
Console.WriteLine(" ");
estu1.Name = "María";
estu1.LastName = "Rodríguez";
estu1.Id = 1001;
estu1.Indice = 3.8m;

            
estu2.Name = "Juan";
estu2.LastName = "Pérez";
estu2.Id = 1002;
estu2.Indice = 3.5m;

            
Console.WriteLine($"Estudiante 1: {estu1.Name} {estu1.LastName}, ID: {estu1.Id}, Índice: {estu1.Indice}, Identificador: {estu1.identifier[0]}");
Console.WriteLine($"Estudiante 2: {estu2.Name} {estu2.LastName}, ID: {estu2.Id}, Índice: {estu2.Indice}, Identificador: {estu2.identifier[0]}");