Console.WriteLine($"Enum value directly : {DaysOfWeek.Monday}"); // Print Monday
Console.WriteLine($"Enum value casted : {(int)DaysOfWeek.TuesDay}"); // Print 2

//Enum to string
var stringMonday = DaysOfWeek.Monday.ToString();

//Cast integer into enum
var number = 3;
var enumValue = (DaysOfWeek)number;
Console.WriteLine(enumValue); // Print Thursday

//String to enum
DaysOfWeek mondayEnum = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), "Monday");
DaysOfWeek mondayEnum2 = Enum.Parse<DaysOfWeek>("Monday");

//Try parse
DaysOfWeek mondayEnum3;
var isSuccess = Enum.TryParse("Monday", out mondayEnum3);
Console.WriteLine($"Enum {(isSuccess? "was parsed" : "was not passed")} : {mondayEnum3}");

//Get all values of enum
foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
{
    Console.WriteLine($"Enum value : {day}");
    //Int value
    Console.WriteLine($"Enum value : {(int)day}");
}
//Get all names
foreach (var day in Enum.GetNames(typeof(DaysOfWeek)))
{
    Console.WriteLine($"Enum name : {day}");
}

//Invalid enum value
DaysOfWeek invalidDay = (DaysOfWeek)8;
Console.WriteLine($"Invalid enum value:{invalidDay}");// prints "Invalid enum value:8"

//Flags: Combine two enum values
FilePermissions filePermissions = FilePermissions.Read | FilePermissions.Write;
Console.WriteLine($"File permissions are: {filePermissions}");

bool hasReadPermission = (filePermissions & FilePermissions.Read) == FilePermissions.Read;
bool hasWritePermission = (filePermissions & FilePermissions.Write) == FilePermissions.Write;
bool hasExecutePermission = (filePermissions & FilePermissions.Execute) == FilePermissions.Execute;
Console.WriteLine($"Can read : {hasReadPermission}");
Console.WriteLine($"Can write : {hasWritePermission}");
Console.WriteLine($"Can execute : {hasExecutePermission}");
enum DaysOfWeek

{
    Monday,
    TuesDay,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

[Flags]
public enum FilePermissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}