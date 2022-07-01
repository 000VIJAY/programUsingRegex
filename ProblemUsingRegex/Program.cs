using ProblemUsingRegex;
Pattern GetPattern = new Pattern();
GetPattern.ValidateFirstName("Vijay");
Console.WriteLine("Valid Name : " + GetPattern.ValidateFirstName("Vijay"));
GetPattern.validateLastName("Kumar");
Console.WriteLine("valid Last Name: " +GetPattern.validateLastName("Kumar"));