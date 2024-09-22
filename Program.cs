// // Q1-List
// // var declaration
// string nameInput;
// // part 1
// List<string> names = new List<string> {};
// names.Add("Leovis");
// names.Add("John");
// names.Add("Anna");
// names.Add("Elize");
// names.Add("Don");
// foreach (string name in names){
//     Console.WriteLine(name);
// }

// // part 2
// Console.WriteLine(names[2]);

// // part 3
// names.RemoveAt(1);
// foreach (string name in names){
//     Console.WriteLine(name);
// }

// // part 4
// names.Add("Curshy");
// foreach (string name in names){
//     Console.WriteLine(name);
// }

// // part 5
// Console.WriteLine(names.Count());

// // part 6
// Console.Write("Type a name: ");
// nameInput = Console.ReadLine();
// if(names.Contains(nameInput)){
//     Console.WriteLine("YES");
// }
// else Console.WriteLine("NO");

// // part 7
// Console.Write("Type an exist name in the list: ");
// nameInput = Console.ReadLine();
// while(!names.Contains(nameInput)){
//     Console.Write("Type an exist name in the list: ");
//     nameInput = Console.ReadLine();
// }
// Console.WriteLine(names.IndexOf(nameInput) + 1);

// // part 8
// names.Insert(2,"Ken");
// foreach (string name in names){
//     Console.WriteLine(name);
// }

// // part 9
// names.Sort();
// foreach (string name in names){
//     Console.WriteLine(name);
// }

// // part 10
// Console.WriteLine(names[4]);

// // part 11
// names.Clear();
// foreach (string name in names){
//     Console.WriteLine(name);
// }

// // part 12
// List<int> ages = new List<int>() {};
// names.Add("Lily");
// ages.Add(17);
// names.Add("Lucifer");
// ages.Add(18);
// foreach(string name in names){
//     Console.WriteLine(name + " " + ages[names.IndexOf(name)]);
// }





