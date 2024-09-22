// // Q2-Array
// // part 1
// string[] countries = new string[5] {"Japan","Korea","Brunei","Chile","Egypt"};
// foreach(string countriesName in countries) Console.WriteLine(countriesName);

// // part 2
// Console.WriteLine(countries[2]);

// // part 3
// countries[1] = null;
// foreach(string countriesName in countries) Console.WriteLine(countriesName);

// // part 4
// countries[2]="VietNam";
// foreach(string countriesName in countries) Console.WriteLine(countriesName);

// // part 5
// Console.WriteLine(countries.Count());

// // part 6
// Console.Write("Enter a name of a country that you want to check if it existed or not in the list: ");
// string inputCountryName = Console.ReadLine();
// if(countries.Contains(inputCountryName)) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// // part 7
// Console.Write("Enter an existed name in the list: ");
// inputCountryName = Console.ReadLine();
// while(!countries.Contains(inputCountryName)){
//     Console.Write("Enter an existed name in the list: ");
//     inputCountryName = Console.ReadLine();
// }
// Console.WriteLine(Array.IndexOf(countries,inputCountryName) + 1);



