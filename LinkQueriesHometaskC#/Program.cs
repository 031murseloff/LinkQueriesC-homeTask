

using LinkQueriesHometaskC_;
using System.Numerics;
using System.Threading.Channels;

DeptorManager deptorManager = new DeptorManager();




//2

//var deptors2 = deptorManager.debtors.Where(deptor => deptor.Email.EndsWith("dayrep.com")|| deptor.Email.EndsWith("rhyta.com")).ToList();
//deptors2.ForEach(deptor =>Console.WriteLine(deptor));

//3

//var deptors3 = deptorManager.debtors.Where(deptor => 2024- deptor.Birthday.Year>=26 && 2024 - deptor.Birthday.Year < 36).ToList();
//deptors3.ForEach(deptor => Console.WriteLine(deptor));


//4


//var deptors4 = deptorManager.debtors.Where(deptor => deptor.Debt<=5000).ToList();
//deptors4.ForEach(deptor => Console.WriteLine(deptor));

//5

//var debtors5 = deptorManager.debtors.Where(debtor => debtor.FullName.Length>18 || debtor.Phone.Count(c=>c=='7')>=2).ToList();
//debtors5.ForEach(debtor => Console.WriteLine(debtor));


//7


//var debtors6 = deptorManager.debtors.Where(debtor => debtor.Birthday.Month==12 || debtor.Birthday.Month==1 || debtor.Birthday.Month==2).ToList();
//debtors6.ForEach(debtor => Console.WriteLine(debtor));


//8


//var debtors8 = deptorManager.debtors.Where(debtor => deptorManager.debtors.Average(debtor => debtor.Debt) <debtor.Debt).OrderByDescending(ord => ord.Debt).
//                                     ThenByDescending(ord=>ord.FullName).ToList();
//debtors8.ForEach(debtor => Console.WriteLine(debtor));


//9

//var debtors9 = deptorManager.debtors.Where(debtor =>debtor.Phone.Count(c=>c=='8')==0 ).Select(debtor => $"{debtor.FullName} {debtor.Birthday} {debtor.Debt}").ToList();

//debtors9.ForEach(debtor => Console.WriteLine(debtor));


//13

//var mostCommonBirthYear = deptorManager.debtors
//   .GroupBy(debtor => debtor.Birthday.Year)
//   .OrderByDescending(group => group.Count())
//   .Select(group => group.Key)
//   .FirstOrDefault();

//var debtors13 = deptorManager.debtors.Where(debtor => debtor.Birthday.Year==mostCommonBirthYear).ToList();
//debtors13.ForEach(debtor => Console.WriteLine(debtor));


//14

//var debtors14 = deptorManager.debtors.OrderByDescending(ord=>ord.Debt).Take(5).ToList();

//debtors14.ForEach(debtor => Console.WriteLine(debtor));


//15

//var debtors15 = deptorManager.debtors.Sum(deptor => deptor.Debt);

//Console.WriteLine($"Total dept: {debtors15}");

//16

//var debtors16 = deptorManager.debtors.Where(debtor=>debtor.Birthday.Year>=1939 && debtor.Birthday.Year<=1945).ToList();
//debtors16.ForEach(debtor => Console.WriteLine(debtor));



//20

//var smileCharacters = "smile".ToCharArray();

//var debtors20 = deptorManager.debtors
//    .Where(debtor => smileCharacters.All(c => (debtor.FullName).ToLower().Contains(c)))
//    .ToList();

//debtors20.ForEach(debtor => Console.WriteLine(debtor));





