
using Employees_Wage_Computation_Problem;
using Employees_Wage_Computation_Problem.EmpWage_FinalSolution;

//EmployeeAttendance.GetAttendance();
//EmpWages.empWages();
//PartTimeEmpWage.partTimeEmpWage();
//EmpWageUsingSwitch.empWageUsingSwitch();
//CalculateWagesFor20DaysInMonth.calculateWagesFor20DaysInMonth();
//CalculateWageTill100HrsOr20IsReached.calculateWageTill100HrsOr20IsReached();

//#region EmpWage
//EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
//EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
//dMart.computeEmpWage();
//Console.WriteLine(dMart.toString());
//reliance.computeEmpWage();
//Console.WriteLine(reliance.toString());
//#endregion  EmpWageEnding

//#region EmpWageEmployees
//EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
//empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();
//#endregion

#region FinalSolution
EmpWageBuilder empWageBuild = new EmpWageBuilder();
empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
empWageBuild.computeEmpWage();
#endregion

Console.ReadKey();
