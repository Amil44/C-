using TaskLinq.DEbtorss;
List<Debtor> debtors = Debtor.debtors;

//Console.WriteLine("======= SOLUTION2 =======");
//var sol2 = debtors.Where(x => x.Email.Contains("@rhyta.com") || x.Email.Contains("@dayrep.com"));
//foreach (var debtor in sol2)
//{
//    Console.WriteLine(debtor.FullName);
//}


//Console.WriteLine("======= SOLUTION3 =======");
//var sol3 = debtors.Where(x => (2026 - x.BirthDay.Year) >= 26 && (2026 - x.BirthDay.Year) <= 36);
//foreach (var debtor in sol3)
//{
//    Console.WriteLine((debtor.FullName, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION4 =======");
//var sol4 = debtors.Where(x => x.Debt <= 5000);
//foreach (var debtor in sol4)
//{
//    Console.WriteLine((debtor.FullName, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION5 =======");
//var sol5 = debtors.Where(x => x.FullName.Length <= 18 && x.Phone.Count((x => x.Equals('7'))) >= 2);
//foreach (var debtor in sol5)
//{
//    Console.WriteLine((debtor.FullName, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION7 =======");
//var sol7 = debtors.Where(x => x.BirthDay.Month == 10 || x.BirthDay.Month == 11 || x.BirthDay.Month == 12);
//foreach (var debtor in sol7)
//{
//    Console.WriteLine((debtor.FullName, debtor.BirthDay.Month, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION8 =======");
//var sol8 = debtors.Where(x => x.Debt > debtors.Average(x => x.Debt))
//    .OrderByDescending(x => x.FullName.)
//    .OrderByDescending(x => x.Debt);
//foreach (var debtor in sol8)
//{
//    Console.WriteLine((debtor.FullName, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION9 =======");
//var sol9 = debtors.Where(x => !x.Phone.Contains('8'));
//foreach (var debtor in sol9)
//{
//    Console.WriteLine((debtor.FullName, debtor.Phone, debtor.Debt));
//}


Console.WriteLine("======= SOLUTION11 =======");
var sol11 = debtors.Where(x => x.FullName.GroupBy(x => x).Any(g => g.Count() >= 3));
foreach (var debtor in sol11)
{
    Console.WriteLine((debtor.FullName, debtor.Debt));
} 


//Console.WriteLine("======= SOLUTION13 =======");
//var yearMostRepeated = debtors.GroupBy(x => x.BirthDay.Year)
//    .OrderByDescending(x => x.Count())
//    .First().Key;

//var sol13 = debtors.Where(x => (x.BirthDay.Year) == yearMostRepeated);
//foreach (var debtor in sol13)
//{
//    Console.WriteLine((debtor.FullName, debtor.BirthDay.Year, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION14 =======");
//var sol14 = debtors.OrderByDescending(x => x.Debt).Take(5);
//foreach (var debtor in sol14)
//{
//    Console.WriteLine((debtor.FullName, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION15 =======");
//var sol15 = debtors.Sum(x => x.Debt) / debtors.Count();
//Console.WriteLine(sol15); 


//Console.WriteLine("======= SOLUTION16 =======");
//var sol16 = debtors.Where(x => (x.BirthDay.Year) <= 1945);
//foreach (var debtor in sol16)
//{
//    Console.WriteLine((debtor.FullName, debtor.BirthDay.Year, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION18 =======");
//var sol18 = debtors.Where(x => x.Phone.Distinct().Count() == x.Phone.Length);
//foreach (var debtor in sol18)
//{
//    Console.WriteLine((debtor.FullName, debtor.Phone, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION19 =======");
//var sol19 = debtors.Where(x => (x.Debt - 500 * (x.BirthDay.Month) == 0));
//foreach (var debtor in sol19)
//{
//    Console.WriteLine((debtor.FullName, debtor.Debt));
//}


//Console.WriteLine("======= SOLUTION20 =======");
//var sol20 = debtors.Where(x => x.FullName.Contains('s') && x.FullName.Contains('m') && x.FullName.Contains('i') && x.FullName.Contains('l') && x.FullName.Contains('e'));
//foreach (var debtor in sol20)
//{
//    Console.WriteLine((debtor.FullName, debtor.Debt));
//}

