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



// // Q3-string
// // part 1
// using System.ComponentModel;

// string surname,middleName,name,fullname;
// Console.Write("Enter surname: ");
// surname = Console.ReadLine();
// Console.Write("Enter middle name: ");
// middleName = Console.ReadLine();
// Console.Write("Enter name: ");
// name = Console.ReadLine();
// fullname=surname + " " + middleName + " " + name;
// Console.WriteLine(fullname.ToUpper());

// // part 2
// Console.WriteLine(fullname.ToLower());

// // part 3
// Console.WriteLine(fullname.Length);

// // part 4
// Console.Write("Enter a character in your name: ");
// char inputCharacter = Console.ReadKey().KeyChar;
// while(!fullname.Contains(inputCharacter)){
//     Console.Write("\nEnter a character in your name: ");
//     inputCharacter = Console.ReadKey().KeyChar;
// }
// Console.Write("\n");
// Console.WriteLine(fullname.IndexOf(inputCharacter) + 1);

// // part 5
// Console.Write("Enter a position from 1 to " + fullname.Length + ": ");
// int position = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(fullname.IndexOf(inputCharacter,position - 1) + 1);

// // part 6
// int countCharacter = 0;
// foreach(char i in fullname){
//     if(i == inputCharacter) countCharacter++;
// }
// Console.WriteLine(countCharacter);

// // part 7 - 9
// char oldCharacter,newCharacter;
// Console.Write("Enter old character: ");
// oldCharacter = Console.ReadKey().KeyChar;
// Console.Write("\nEnter new character: ");
// newCharacter = Console.ReadKey().KeyChar;
// fullname = fullname.Replace(oldCharacter,newCharacter);
// Console.WriteLine("\n" + fullname);

// // part 8
// Console.Write("Enter character: ");
// inputCharacter = Console.ReadKey().KeyChar;
// fullname = fullname.Remove(fullname.IndexOf(inputCharacter),1);
// Console.WriteLine("\n" + fullname);

// // part 10 - 11
// Console.Write("Enter first position: ");
// int firstPosition = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Enter second position: ");
// int secondPosition = Convert.ToInt32(Console.ReadLine()) - firstPosition;
// Console.WriteLine(fullname.Substring(firstPosition,secondPosition));

// // part 12
// fullname = fullname.Trim();
// Console.WriteLine(fullname);

// // part 13
// string stringNumber = "12345";
// int intNumber = int.Parse(stringNumber);
// Console.WriteLine(intNumber);

// // part 14
// intNumber = 1324;
// stringNumber = intNumber.ToString();
// Console.WriteLine(stringNumber);



// // Q3-string-formating
// // part 1
// Console.Write("Recipient's name: ");
// string name = Console.ReadLine();
// Console.Write("Event date: ");
// string date = Console.ReadLine();
// Console.Write("Hello, " + name + "! You're invited to our team outing on " + date + ". The event starts at 09:00.");

// // part 2
// Console.Write("Customer's name: ");
// string name = Console.ReadLine();
// Console.Write("Order ID: ");
// int ID = Convert.ToInt32(Console.ReadLine());
// Console.Write("Purchase details: ");
// string details = Console.ReadLine();
// Console.Write("Dear " + name + ", your order (ID: " + ID + ") has been confirmed. You've purchased: " + details + ".");

// // part 3
// Console.Write("Task name: ");
// string name = Console.ReadLine();
// Console.Write("Due date: ");
// string date = Console.ReadLine();
// Console.Write("Priority level: ");
// string priority = Console.ReadLine();
// Console.Write("Reminder: " + name + " is due on " + date + ". Priority: " + priority + ".");

// // part 4
// Console.Write("Event title: ");
// string title = Console.ReadLine();
// Console.Write("Location: ");
// string location = Console.ReadLine();
// Console.Write("Start time: ");
// string time = Console.ReadLine();
// Console.Write("Reminder: " + title + " at " + location + " starts at " + time + ".");

// // part 5
// Console.Write("Flight number: ");
// string flightNumber = Console.ReadLine();
// Console.Write("Departure airport: ");
// string airport = Console.ReadLine();
// Console.Write("Scheduled time: ");
// string time = Console.ReadLine();
// Console.Write("Flight " + flightNumber + " departing from " + airport + " is scheduled for " + time + ".");

// // part 6
// Console.Write("Enter your name: ");
// string name = Console.ReadLine();
// Console.Write("Hello, " + name + "! Welcome to our messaging app.");

// // part 7
// Console.Write("Character's name: ");
// string characterName = Console.ReadLine();
// Console.Write("Character's class: ");
// string characterClass = Console.ReadLine();
// Console.Write("Custom Badge: " + characterName + " the " + characterClass);

// // part 8
// Console.Write("Enter the song's duration in seconds: ");
// int time = Convert.ToInt32(Console.ReadLine());
// Console.Write("Song Duration: " + time/60 + " minutes " + time%60 + " seconds");

// // part 9
// Console.Write("Enter the number of servings: ");
// int numberOfServing = Convert.ToInt32(Console.ReadLine());
// Console.Write("Serving Size:     " + numberOfServing);

// // part 10
// Console.Write("Enter the account balance: ");
// float numberAccountBalance = float.Parse(Console.ReadLine());
// Console.Write("Account Balance: " + numberAccountBalance);

// // part 11
// Console.Write("Enter the ticket price: ");
// float ticketPrice = float.Parse(Console.ReadLine());
// Console.Write("Enter the discount percentage: ");
// float discount = float.Parse(Console.ReadLine());
// ticketPrice -= discount*ticketPrice/100;
// Console.Write("Discounted Price: " + ticketPrice);

// // part 12
// Console.Write("Enter the player's score: ");
// int score = Convert.ToInt32(Console.ReadLine());
// Console.Write("Player's Score:   " + score);

// // part 13
// Console.Write("Enter a series of numbers: ");
// string numbersList = Console.ReadLine();
// string stringNumber = "";
// float sum = 0;
// float countOfNumbers = 0;
// while(numbersList.Length>0){
//     stringNumber = "";
//     foreach(char i in numbersList){
//         if(i == ' '){
//             numbersList = numbersList.Remove(numbersList.IndexOf(i),1);
//             break;       
//         }
//         stringNumber += i;
//         numbersList = numbersList.Remove(numbersList.IndexOf(i),1);
//     }
//     countOfNumbers++;
//     sum += float.Parse(stringNumber);
// }
// Console.Write("Average Value: " + sum/countOfNumbers);

// // part 14
// Console.Write("Enter temperatures for 3 days: ");
// string temperatureList = Console.ReadLine();
// string stringNumber = "";
// float sum = 0;
// while(temperatureList.Length>0){
//     stringNumber = "";
//     foreach(char i in temperatureList){
//         if(i == ' '){
//             temperatureList = temperatureList.Remove(temperatureList.IndexOf(i),1);
//             break;       
//         }
//         stringNumber += i;
//         temperatureList = temperatureList.Remove(temperatureList.IndexOf(i),1);
//     }
//     sum += float.Parse(stringNumber);
// }
// Console.Write("Average temperature: " + sum/3);

// // part 15
// Console.Write("Enter the steps taken: ");
// int stepsTaken = Convert.ToInt32(Console.ReadLine());
// Console.Write("Step Count:  " + stepsTaken);



// // Q4-Classes
// // question 1
// class PLayer{
//     string name;
//     int level;
//     int HP;
//     int XP;
//     public PLayer(string playerName){
//         name = playerName;
//         level = 1;
//         HP = 200;
//         XP = 0;
//     }
//     public void levelUp(){
//         level++;
//     }
//     public void heal(int amount){
//         HP += amount;
//     }
//     public void gainXP(int amount){
//         XP += amount;
//     }

// }

// // question 2
// class Enemy{
//     string name;
//     int HP;
//     int fullHP;
//     int ATK;
//     int DEF;
//     bool died;
//     public Enemy(string enemyName, int health, int attack, int defense){
//         name = enemyName;
//         HP = health;
//         fullHP = health;
//         ATK = attack;
//         DEF = defense;
//     }
//     public int dealDamage(){
//         if(!died) return ATK-(HP*100/fullHP);
//         return 0;
//     }
//     public void takeDamage(int amount){
//         HP -= amount-DEF;
//         if(DEF<=amount) DEF=0;
//         else DEF -= amount;
//         if(HP<=0) died = true;
//     }

// }

// // question 3
// class Potion{
//     string name;
//     int healingPower;
//     int quantity;
//     public Potion(string potionName, int HPhealing, int number){
//         name = potionName;
//         healingPower = HPhealing;
//         quantity = number;
//     }
//     public int usingPotion(){
//         if(quantity>0){
//             quantity--;
//             return healingPower;
//         }
//         else return 0;
//     }
// }

// // question 4
// class Quest{
//     string name;
//     string description;
//     string reward;
//     bool completed;
//     public Quest(string questName){
//         name = questName;
//         switch(name){
//             case "Defeat John":
//                 description = "Go to the pub in the north of Vilancia city to find John and defeat him for the reward.";
//                 reward = "1 x Lickstainent Sword; 500 x Gold coins; 1000 EXP; 20 x 100HP restore potions";
//                 completed = false;
//                 break;
//             case "Kill Orcs":
//                 description = "Go to the southern outskirts of Vilancia in the Temura forest, you will see a herd of Orcs in there, kill 100 of them and you will gain reward.";
//                 reward = "500 x Silver coins; 5 x 150HP restore potions; 5000 EXP";
//                 completed = false;
//                 break;
//             case "Help Oliver":
//                 description = "Go to the chamber of commerce in downtown Vilancia, you will find Oliver in front of the door there, talk to him and help him for the reward.";
//                 reward = "1000 x Gold coins; 100 x 50HP restore potions; 800 EXP";
//                 completed = false;
//                 break;
//         }

//     }
//     public void startQuest(){
//         Console.WriteLine(description);
//     }
//     public void questCompleted(){
//         Console.WriteLine("Congratulations on completing the '" + name + "' quest, here is your reward: " + reward);
//     }
// }

// // question 5
// class Inventory{
//     int capacity;
//     List<string> items = new List<string>(){};
//     List<string> existItem = new List<string>(){"sword","potion 50HP","potion 100HP","full potion","potion 150HP","silver coin","gold coin"};
//     public Inventory(){
//         capacity = 30;
//     }
//     public void addItem(string itemName){
//         if(existItem.Contains(itemName)){
//             items.Add(itemName);
//         }
//     }
//     public void removeItem(string itemName){
//         if(existItem.Contains(itemName) && items.Contains(itemName)){
//             items.RemoveAt(items.IndexOf(itemName));
//         }
//     }
//     public void itemDetail(string itemName){
//         switch(itemName){
//             case "sword":
//                 Console.WriteLine("Function: Increase the damage user deal to the enemy.\nParameters:\n+30ATK");
//                 break;
//             case "potion 50HP":
//                 Console.WriteLine("Function: Healing the user for 50HP.");
//                 break;
//             case "potion 100HP":
//                 Console.WriteLine("Function: Healing the user for 100HP.");
//                 break;
//             case "potion 150HP":
//                 Console.WriteLine("Function: Healing the user for 150HP.");
//                 break;
//             case "full potion":
//                 Console.WriteLine("Function: Healing fully user's HP and heal all negative statuses.");
//                 break;
//             case "silver coin":
//                 Console.WriteLine("Function: Using to trading.");
//                 break;
//             case "gold coin":
//                 Console.WriteLine("Function: Using to trading, exchange value equivalent to 10 silver coins.");
//                 break;
//         }
//     }
// }

// // question 6
// class Spell{
//     string name;
//     int damage;
//     int manaCost;
//     string description;
//     public Spell(string spellName){
//         name = spellName;
//         switch(name){
//             case "fire ball":
//                 damage = 70;
//                 manaCost = 20;
//                 description = "Deals damage and has a 20% chance to cause the target to suffer a Burn effect.";
//                 break;
//             case "ice Beam":
//                 damage = 90;
//                 manaCost = 50;
//                 description = "Deals damage and has a 25% chance to cause the target to suffer a Freeze effect.";
//                 break;
//             case "nature power":
//                 damage = 50;
//                 manaCost = 15;
//                 description = "Deals damage and restores HP to the user equal to 50% of the damage the opponent takes.";
//                 break;
//             case "toxic spikes":
//                 damage = 70;
//                 manaCost = 20;
//                 description = "Deals damage and has a 20% chance to cause the target to suffer a Poisoned effect.";
//                 break;
//         }

//     }
//     public int spellDamage(int userSPATK){
//         return damage*userSPATK/100;
//     }
//     public int manaCosting(int userMana){
//         return userMana-manaCost;
//     }
//     public void spellDetail(){
//         Console.WriteLine(description);
//     }
// }



// // Q5-enum
// // question 1
// enum Weekday{
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Saturday,
//     Sunday,
// }

// // question 2
// enum EnemyState{
//     Idle,
//     Patrol,
//     Attack,
// }

// // question 3
// enum FlightStatus{
//     Ascending,
//     Descending, 
//     Stationary,
// }

// // question 4
// enum TitleRank{
//     Beginner,
//     Intermediate, 
//     Advanced,
// }

// // question 5
// enum PLayerMovement{
//     Idle, 
//     Walk,   
//     Run,
// }

// // question 6
// enum DayOfWeek{
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Saturday,
//     Sunday,
// }
// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine(DayOfWeek.Monday);
//         Console.WriteLine(DayOfWeek.Tuesday);
//         Console.WriteLine(DayOfWeek.Wednesday);
//         Console.WriteLine(DayOfWeek.Thursday);
//         Console.WriteLine(DayOfWeek.Friday);
//         Console.WriteLine(DayOfWeek.Saturday);
//         Console.WriteLine(DayOfWeek.Sunday);
//     }
// }