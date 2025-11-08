using System;
using System.Collections.Generic;
public class StorageMenuItem{
    public string Name {get;set;}
    public int Price{get;set;}
    public int Stock{get;set;}
    public StorageMenuItem(){}
    public StorageMenuItem(string name,int price,int stock){
        Name = name;
        Price = price;
        Stock = stock;
    }
}

public class WorasakProject
{
    
   
    public static string InputData(){
        ///////////////Get data from user input
        string ChooseMenu = Console.ReadLine();
         ///////////////Make it t upperText
        string UpperText = ChooseMenu.ToUpper();
        ///////////////DeleteSpace//////////
        ///////////////Replace the space with empty
        string ChooseMenuTrueValue = UpperText.Replace(" ", string.Empty);
        ///////////////return value
        return ChooseMenuTrueValue;
    }
    //////////////////This method show category menu that user input the value
    public static void CategoryOrder(List<StorageMenuItem> Category ,string CategoryName){
        
        Console.WriteLine();
        ////////////////////////Get data from user CategoryName and put it in below line
        Console.WriteLine($" __________________{CategoryName} MENU__________________");
        Console.WriteLine("                                             ");
        //////////////////////LOOP to get data from Array
        for (int i = 0; i < Category.Count; i++)
        {
        /////////////////////i+1 because forloop start from 0 
        Console.WriteLine($"   {i + 1}.{Category[i].Name.PadRight(15)}{Category[i].Price} BAHT{"".PadRight(8)}STOCK: {Category[i].Stock}{"".PadRight(2)}");}
        if (Category.Count == 0){
        Console.WriteLine("               | No menu in here |           ");}
        Console.WriteLine("                                             ");
        Console.WriteLine($"      Please choose {CategoryName} to continue -=-");
        Console.WriteLine("_____________________________________________");
        Console.WriteLine();
        Console.Write("Choose Menu to order(Number or Text) : ");
    }
    public static void OrderMenuState1(List<StorageMenuItem> Category,int checkname){
         Console.WriteLine(" _________________ORDER MENU__________________");
         Console.WriteLine("                                             ");
         Console.WriteLine($"         YOUR ORDER IS {Category[checkname].Name.PadRight(22)}");
       
         Console.WriteLine($"   STOCK : {Category[checkname].Stock}{"".PadRight(33)}");
         Console.WriteLine($"   PRICE : {Category[checkname].Price} BAHT{"".PadRight(27)}");
         Console.WriteLine("   AMOUNT: CHOOSE AMOUNT                     ");
         Console.WriteLine("                                             ");
         Console.WriteLine("_____________________________________________");
         Console.WriteLine();
///////////////////////////ENTER AMOUNT TO ORDER ////////////////////
         Console.Write("ENTER AMOUNT TO ORDER : ");
    }
    public static void OrderMenuState2(List<StorageMenuItem>Category,int checkname,int amount){
         Console.WriteLine();
         Console.WriteLine(" _________________ORDER MENU__________________");
         Console.WriteLine("                                             ");
         Console.WriteLine($"         YOUR ORDER IS {Category[checkname].Name.PadRight(22)}");
         Console.WriteLine("                                             ");
         Console.WriteLine($"   PRICE : {Category[checkname].Price} BAHT{"".PadRight(27)}");
         Console.WriteLine($"   AMOUNT : {amount}{"".PadRight(32)}");
         Console.WriteLine("                                             ");
         Console.WriteLine($"             TOTAL PRICE: {amount * Category[checkname].Price} BAHT{"".PadRight(12)}");
        Console.WriteLine("_____________________________________________");
        Console.WriteLine();
        Console.WriteLine(" ___________________PAYMENT __________________");
        Console.WriteLine("                                             ");
        Console.WriteLine($" TOTAL PRICE: {amount * Category[checkname].Price} BAHT{"".PadRight(24)}");
        Console.Write($" ENTER YOUR MONEY : ");
    }
    public static void ChangeBill(List<StorageMenuItem> Category,int moneyPay,int amount,int checkname){
        int  moneyFoodChange = moneyPay-amount*Category[checkname].Price;
        Console.WriteLine($" CHANGE : {moneyFoodChange}{"".PadRight(34)}");
        Console.WriteLine($" HUNDRED BANKNOTE : {moneyFoodChange/100}{"".PadRight(24)}");
        moneyFoodChange %= 100;
        Console.WriteLine($" FIFTY   BANKNOTE : {moneyFoodChange/50}{"".PadRight(24)}");
        moneyFoodChange %= 50;
        Console.WriteLine($" TWENTY  BANKNOTE : {moneyFoodChange/20}{"".PadRight(24)}");
        moneyFoodChange %=20;
        Console.WriteLine($" TEN     COINS    : {moneyFoodChange/10}{"".PadRight(24)}");
        moneyFoodChange %=10;
        Console.WriteLine($" ONE     COINS    : {moneyFoodChange/1}{"".PadRight(24)}");
        Console.WriteLine("                             PAYMENT SUCESS! ");
    }
    public static void NoEnoughMoney(){
     Console.WriteLine("                                             ");
     Console.WriteLine("        YOU DON'T HAVE ENOUGH MONEY          ");
     }
    public static void NoStock(){
    Console.WriteLine("|============================================|");
    Console.WriteLine("|          INSUFFICIENT STOCK QUANTITY       |");
    Console.WriteLine("|                 BACK TO MENU               |");
    
    Console.WriteLine("|____________________________________________|");
    }
    public static void SomethingWrong(){
        
    Console.WriteLine();
    Console.WriteLine("             SOME THING WAS WRONG              ");
    Console.WriteLine();
    Console.WriteLine(" _____________________________________________ ");
    Console.WriteLine("|                                             |");
    Console.WriteLine("|                 BACK TO MENU                |");
    Console.WriteLine("|                                             |");
    Console.WriteLine("|_____________________________________________|");
    Console.WriteLine();
    }
    public static void ListCategory(List<StorageMenuItem> Category,string CategoryName){
    Console.WriteLine();
    Console.WriteLine($" __________________{CategoryName} MENU__________________");
    Console.WriteLine("                                             ");
    /////////////////////////////LOOP TO GET DATA FROM ARRAY
    for (int i = 0; i < Category.Count; i++)
    {
     Console.WriteLine($"   {i + 1}.{Category[i].Name.PadRight(15)}{Category[i].Price} BAHT{"".PadRight(8)}STOCK: {Category[i].Stock}{"".PadRight(2)}");}
if(Category.Count==0){
    Console.WriteLine("               | No menu in here |           ");
}
    Console.WriteLine("                                             ");
    Console.WriteLine("      Enter Any key to go Back       -=-     ");
    Console.WriteLine("_____________________________________________");
    Console.WriteLine();
    Console.Write("Enter Any key to continue : ");
    }
    public static void AdminStateShowCategory(List<StorageMenuItem> Category){
    Console.WriteLine(" ___________________________________ADMIN_____________________________________ ");
    Console.WriteLine("                                                                             ");
    Console.WriteLine("                                   STOCK                                     ");
    if(Category.Count==0){
    Console.WriteLine("                            | No Menu in here |");
    Console.WriteLine("                        | ADD MENU USE ADD COMMAND |");
    }
    for(int i=0;i<Category.Count;i++){
    Console.WriteLine($"         {i+1}.{Category[i].Name.PadRight(50)} x{Category[i].Stock}");
     }
    Console.WriteLine(" -----------------------------------------------------------------------------");
    Console.WriteLine("|                                  COMMAND                                    |");
    Console.WriteLine("|   - select     - Select menu to edit the stock                              |");
    Console.WriteLine("|   - back       - Back to previous page                                      |");
    Console.WriteLine("|   - add        - Add menu in stock                                          |");
    Console.WriteLine("|   - del        - Delete menu in stock                                       |");
    Console.WriteLine("|   - exit       - Exit ADMIN PAGE                                            |");

    Console.WriteLine("|                                                                             |");
    Console.WriteLine("|_____________________________________________________________________________|");
    Console.WriteLine();
    Console.Write("Enter command : ");
}
    public static void AdminStategoto_select(string CategoryName,List<StorageMenuItem> Category){
    Console.WriteLine(" ____________________________________SELECT___________________________________ ");
    Console.WriteLine("");
    Console.Write($"       SELECT {CategoryName}       : ");
    int checkSelectMenu = 0;
    try{
    string SelectEditMenu = Console.ReadLine().Replace(" ",string.Empty).ToUpper();
    checkSelectMenu = Category.FindIndex(item => item.Name.ToUpper() == SelectEditMenu);
    Console.WriteLine($"       YOU SELECT        : {Category[checkSelectMenu].Name}");
    if(SelectEditMenu == Category[checkSelectMenu].Name){
    Console.Write("       EDIT STOCK AMOUNT : ");
    int EditAdminMenu = Convert.ToInt32(Console.ReadLine());
    if(EditAdminMenu >=0){
    Category[checkSelectMenu].Stock = EditAdminMenu;
    Console.WriteLine();
    Console.WriteLine("       CHANGE SUCCESS");
    Console.WriteLine(" _____________________________________________________________________________ ");

    }else{

    Console.WriteLine(" _____________________________________________________________________________ ");
    Console.WriteLine();
    Console.WriteLine("Something Invaild");
    }
 }
}catch(Exception){
    Console.WriteLine(" _____________________________________________________________________________ ");
    Console.WriteLine();
    Console.WriteLine("Something Invaild");
 }
    }
    public static void BackToMenu(){
    Console.WriteLine(" _____________________________________________ ");
    Console.WriteLine("|                                             |");
    Console.WriteLine("|                 BACK TO MENU                |");
    Console.WriteLine("|                                             |");
    Console.WriteLine("|_____________________________________________|");
    Console.WriteLine();
    }
    
    public static int checkposition(string TrueChooseValue,List<StorageMenuItem> Category){
    int checkname = 0;
    /////////////DECLARE VALUE FOR CHECK VALUE
    int intValue;
    //////////////////////////////CHECK VALUE CAN TURN INTO INT?////////////
    bool canConvert = int.TryParse(TrueChooseValue, out intValue);
    //When user input the value this state will check that value length more than 1 and cannot convert to int that mean that is not number and check that value is not null
    if (TrueChooseValue.Length > 1 && !canConvert && TrueChooseValue != null)
    {
    //Find the number position by find the text that look like the value user input if that two value is equal store the number position in to checkname
    checkname = Category.FindIndex(item => item.Name.ToUpper() == TrueChooseValue);
    }
    //When user input can convert to number and not null value do this if
    else if (canConvert && TrueChooseValue != null)
    {
    //Convert value to int and minus 1, store it to checkname
    //The reason because when user input user see the choice 1 2 3 and the position index start with 0 1 2 that not equal the choice so we need to minus 1 to make the value user input equal to position index
    checkname = Convert.ToInt32(TrueChooseValue) - 1;
    }
    return checkname;
}
//////////////////////////HERERERERERERERERERERERERERE/





public static void CategoryChoice(List<StorageMenuItem> Category ,string CategoryName){
    
    //CategoryOrder(string CategoryName,string[] ArrayCategory,int[] ArrayPriceCategory,int[] ArrayStockCategory)
///USE METHOD 
//INTERFACE Show list menu
CategoryOrder(Category,CategoryName);
/////////////////// GET VALUE FROM METHOD//////////////////////////
string TrueChooseValue = InputData();
///////////////////////////// USE TRY CATCH FOR MANAGE ANY ERROR
try
{
//Use Method to find position that user input with array
int checkname=checkposition(TrueChooseValue,Category);

//// SPACE LINE
Console.WriteLine();
//Check the value that equal with Food array Or Value minus 1 equal position index
if (TrueChooseValue == Category[checkname].Name || Convert.ToInt32(TrueChooseValue) - 1 == checkname)

{
//////////////////declare variable to get the amount user input 
int amountOrder = 0;
//INTERFACE User choose amount
////OrderMenuState1(string[] CategoryArray,int[] CategoryPrice,int[] CategoryStock,int checkname)
//Use Method to show the result user choose
OrderMenuState1(Category,checkname);

    //get value from user and convert to int ,enter amount to order
amountOrder = Convert.ToInt32(Console.ReadLine().Replace(" ", string.Empty));
    ///////////////////INTERFACE TOTAL RESULT///////////////////////////
    //Check the amount user input more than 0 and less or equal STOCK 
    if (amountOrder > 0 && amountOrder <= Category[checkname].Stock){
 //OrderMenuState2(string[] CategoryArray,int[] CategoryPrice,int[] CategoryStock,int checkname,int amount
 //show the total price that user order
 OrderMenuState2(Category,checkname,amountOrder);
     //user input money
int moneyPay = Convert.ToInt32(Console.ReadLine());

////////////////DECLARE VALUE USE FOR CHANGE
int moneyChange;
 ////CHECK IF USER MONEY LESS THAN TOTAL PRICE
 if(moneyPay < amountOrder*Category[checkname].Price){
     //Method use if money user input less than total price
NoEnoughMoney();
 }
 ///if money user input greater than total price do this state
 else if(moneyPay >= amountOrder*Category[checkname].Price){
     ///////////////////////CALCULATE CHANGE///////////////////
//ChangeBill(int[] PriceArray,int moneyPay,int amount,int checkname)
ChangeBill(Category,moneyPay,amountOrder,checkname);
 //decrease stock following user input 
 Category[checkname].Stock-=amountOrder;
 }
 Console.WriteLine("_____________________________________________");
}
//if stock less than user order do this state
else if (Category[checkname].Stock < amountOrder && amountOrder > 0){
   //Method show no stock
   NoStock();
}
//If no choice do this
else{
    //Method Show Something wrong
SomethingWrong();
 }
}

 ///CATCH Error if got any error
}
catch (Exception ex)
{
    //Method show something wrong
SomethingWrong();
 }
}
public static void DeleteMenu(List<StorageMenuItem> Category){
       string delCommand;
       char confirm;
       int findIndex;
Console.WriteLine(" ___________________________________ADMIN_____________________________________ \n");
if(Category.Count == 0){
Console.WriteLine("                                  No Menu in here ");
}
for(int i =0;i<Category.Count;i++){
Console.WriteLine($"         {i+1}.{Category[i].Name.PadRight(50)}x{Category[i].Stock}");
}
 Console.WriteLine(" -----------------------------------------------------------------------------\n");
  if(Category.Count > 0){


 try{
Console.WriteLine("         Type cancel to exit del ");
Console.Write("         Choose menu to delete(Text) : ");
delCommand = InputData();
if(delCommand != "cancer"){

Console.Write($"         Are you sure to delete {delCommand}? (y/n) : ");
confirm = char.Parse(Console.ReadLine());
if(confirm == 'y'){
findIndex =  Category.FindIndex(item => item.Name.ToUpper() == delCommand.ToUpper());
Category.RemoveAt(findIndex);
Console.WriteLine($"         Delete {delCommand} Success!");
 Console.WriteLine(" _____________________________________________________________________________");
}
else{
Console.WriteLine("      ");
 Console.WriteLine(" _____________________________________________________________________________");
}
}
}catch(ArgumentOutOfRangeException){
    Console.WriteLine("\nNo menu choose to delete\n");
     Console.WriteLine(" _____________________________________________________________________________");
}
catch(FormatException){
    Console.WriteLine("\nEnter Only y or n !!");
     Console.WriteLine(" _____________________________________________________________________________");
}
}
else{
    Console.WriteLine("         ADD MENU BEFORE DELETE !!!");
     Console.WriteLine(" _____________________________________________________________________________\n");
}
}
    
    
    
    ///////////////////////////////START PROGRAM HERE
    public static void Main(string[] args)
    {   
        
    List<StorageMenuItem> FoodListMenu = new List<StorageMenuItem>(){};
    List<StorageMenuItem> DrinkListMenu = new List<StorageMenuItem>(){};
    List<StorageMenuItem> DessertListMenu = new List<StorageMenuItem>(){};
    StorageMenuItem S = new StorageMenuItem();
    
        //Category
        string[] CategoryMenu = {"FOOD","DRINK","DESSERT"};
         //Total Stock ARRAY
        int[] StockTotal = new int[CategoryMenu.Length];
        //ITEM DEFAULT IN FOOD 

        int TotalFoodStock = 0;
        ////////////////////UPDATE CURRENT TOTAL FOOD STOCK 

        for(int i =0;i<FoodListMenu.Count;i++){
            TotalFoodStock+=FoodListMenu[i].Stock;
            StockTotal[0] = TotalFoodStock;
        }

        /////Total STOCK
         int TotalDrinkStock = 0;
        ////////////////////UPDATE CURRENT TOTAL DRINK STOCK 
        for(int i=0;i<DrinkListMenu.Count;i++){
            TotalDrinkStock+=DrinkListMenu[i].Stock;
            StockTotal[1] = TotalDrinkStock;
        }

        /////////////////////TOTAL STOCK
         int TotalDessertStock = 0;
        ////////////////////UPDATE CURRENT TOTAL FOOD STOCK 
        for(int i=0;i<DessertListMenu.Count;i++){
            TotalDessertStock+=DessertListMenu[i].Stock;
            StockTotal[2] = TotalDessertStock;
        }
       
        
//KEY FOR ADMIN----------------------------------------------------------
        ////////////////USE THIS KEY IN FIRST PAGE 
        string AdminKeyPass = "ADMINKEY";

//MENU FIRST APPEAR WHEN RUN ------------------------------------------
//SET Repeat for Loop
bool repeatouter = true;
//use do_while
do{
    
Console.WriteLine(" _______________Vending Machine_______________");
Console.WriteLine("                                             ");
Console.WriteLine("                   WELCOME                   ");
Console.WriteLine("     Please choose Menu to continue =-=      ");
Console.WriteLine("   1.ORDER MENU                              ");
Console.WriteLine("   2.LIST MENU                               ");
Console.WriteLine("   3.EXIT                                    ");
Console.WriteLine("                                             ");
Console.WriteLine("_____________________________________________");

        Console.WriteLine();
Console.Write("Choose menu to continue(Number or Text) : ");
////////////////////////////This Line use Method to get user input and filter some space,make text to upper case
string ChooseMenuTrueValue = InputData();

    //MENU1--------------------------------------------------------------
////Check Value from user input if value is ordermenu or 1 do this if
if (ChooseMenuTrueValue == "ORDERMENU" || ChooseMenuTrueValue == "1")
        {
            Console.WriteLine();
//    INTERFACE MENU///////////////////////////////////////////
Console.WriteLine(" _________________ORDER MENU__________________");
Console.WriteLine("                                             ");
for(int i =0;i<CategoryMenu.Length;i++){
    Console.WriteLine($"   {i+1}.{CategoryMenu[i]}                                    ");
}
Console.WriteLine("                                             ");
Console.WriteLine("      Please choose Menu to continue -=-     ");
Console.WriteLine("_____________________________________________");
Console.WriteLine();
Console.Write("Choose menu category to order(Number or Text) : ");
/////////////////// GET VALUE FROM METHOD//////////////////////////
string TrueValueChooseOrder = InputData();
Console.WriteLine();
////Check Value from user input if value is FOOD or 1 do this if
if (TrueValueChooseOrder == "FOOD" || TrueValueChooseOrder == "1")
{

 CategoryChoice(FoodListMenu,"FOOD");

}
//////////////////////// Choose DRINK CATEGORY //////////////////////
else if (TrueValueChooseOrder == "DRINK" || TrueValueChooseOrder == "2")
{
   CategoryChoice(DrinkListMenu,"DRINK");
}
///                      DESSERT MENU                
else if (TrueValueChooseOrder == "DESSERT" || TrueValueChooseOrder == "3")
{
CategoryChoice(DessertListMenu,"DESSERT");
}

else{
BackToMenu();
}
}

// MENU2 -----------------------------------------------------------
else if (ChooseMenuTrueValue == "LISTMENU" || ChooseMenuTrueValue == "2")
{
           TotalFoodStock = 0;
            for(int i =0;i<FoodListMenu.Count;i++){
            TotalFoodStock+=FoodListMenu[i].Stock;
            StockTotal[0] = TotalFoodStock;
        }
                   TotalDrinkStock = 0;
            for(int i =0;i<DrinkListMenu.Count;i++){
            TotalDrinkStock+=DrinkListMenu[i].Stock;
            StockTotal[1] = TotalDrinkStock;
        }
                   TotalDessertStock = 0;
            for(int i =0;i<DessertListMenu.Count;i++){
            TotalDessertStock+=DessertListMenu[i].Stock;
            StockTotal[2] = TotalDessertStock;
        }
    Console.WriteLine();
//    INTERFACE MENU///////////////////////////////////////////
Console.WriteLine(" __________________LIST MENU__________________");
Console.WriteLine("                                             ");
for(int i =0;i<CategoryMenu.Length;i++){
    Console.WriteLine($"   {i+1}.{CategoryMenu[i].PadRight(30)}x{StockTotal[i]} ");
}

Console.WriteLine("                                             ");
Console.WriteLine("      Please Choose Category to See          ");
Console.WriteLine("_____________________________________________");
Console.WriteLine();
Console.Write("Enter Number Or Text in Menu to go : ");
////////////////////////////GET INPUT FROM USER AND DELETE SPACE AND TURN IT TO UPPERTEXT
string getInputListCategory = Console.ReadLine().Replace(" ",string.Empty).ToUpper();
///////////////////////////FOOD CHOOSE///////////////////
if(getInputListCategory=="FOOD" || getInputListCategory=="1"){
    ListCategory(FoodListMenu,"FOOD");

////////////////////////////GET INPUT FROM USER 
string keygobackfood = Console.ReadLine();
if (keygobackfood=="" || keygobackfood != null){
    Console.WriteLine();
BackToMenu();
}
    
}

//////////////////////////////////////////////////////////////////

else if(getInputListCategory=="DRINK" || getInputListCategory=="2"){
ListCategory(DrinkListMenu,"DRINK");
///////////////////////////GET INPUT FROM USER///////////////////////
string keygobackdrink = Console.ReadLine();
if (keygobackdrink=="" || keygobackdrink != null){
    Console.WriteLine();
BackToMenu();
}
    
}
/////////////////////////////////////////////////////////////////

else if(getInputListCategory=="DESSERT" || getInputListCategory=="3"){
ListCategory(DessertListMenu,"DESSERT");
///////////////////////GET INPUT FROM USER
string keygobackdessert = Console.ReadLine();
if (keygobackdessert=="" || keygobackdessert != null){
    Console.WriteLine();
BackToMenu();
}
    
}
else{
BackToMenu();
}
///////////// LIST COMPONENTS////////////////////////////////////



}
//EXIT MENU --------------------------------------------------------
else if (ChooseMenuTrueValue == "EXIT" || ChooseMenuTrueValue == "3")
{
    Console.WriteLine();
Console.WriteLine("|/////////////////////////////////////////////|");
Console.WriteLine("|             Thank for use -=-!              |");
Console.WriteLine("|/////////////////////////////////////////////|");
Console.WriteLine();     
Console.WriteLine();
Console.WriteLine("             ______      ______      ____________      ______    ______");
Console.WriteLine("            |      |    |      |    |            |     \\     \\  /     /");     
Console.WriteLine("            |      |    |      |    |     _______|      \\     \\/     / ");
Console.WriteLine("            |      |____|      |    |    |_______        \\          / ");
Console.WriteLine("            |                  |    |            |        \\        / ");
Console.WriteLine("            |       ____       |    |     _______|        /        \\ ");
Console.WriteLine("            |      |    |      |    |    |_______        /          \\ ");
Console.WriteLine("            |      |    |      |    |            |      /     /\\     \\ ");
Console.WriteLine("            |______|    |______|    |____________|     /_____/  \\_____\\ ");
Console.WriteLine();
Console.WriteLine("          ================================================================ ");
Console.WriteLine("          \\_______________________________________________________________/     ");

repeatouter = false;
}
//ADMIN 
/////////////////////////CHECK KEY ADMIN///////////////////
else if (ChooseMenuTrueValue == AdminKeyPass.ToUpper()){
    
     bool ExitAdmin = true;
     /////////////////DO WHILE FOR REPEAT
    do{
 
        string NameMenu;
int PriceMenu;
int StockMenu;
       
 Console.WriteLine(" ___________________________________ADMIN_____________________________________ ");
 Console.WriteLine("                                                                             ");
 Console.WriteLine("                                   STOCK                                     ");
Console.WriteLine($"        1.FOOD                                               x{StockTotal[0]} ");
Console.WriteLine($"        2.DRINK                                              x{StockTotal[1]}");
Console.WriteLine($"        3.DESSERT                                            x{StockTotal[2]}");
 Console.WriteLine(" -----------------------------------------------------------------------------");
 Console.WriteLine("|                                  COMMAND                                    |");
 Console.WriteLine("|   - goto |___| - Select category to see the stock(goto food)                |");
 Console.WriteLine("|   - back       - Back to previous page                                      |");
 Console.WriteLine("|   - exit       - Exit ADMIN PAGE                                            |");
 Console.WriteLine("|                                                                             |");
 Console.WriteLine("|                                                                             |");
 Console.WriteLine("|_____________________________________________________________________________|");
 Console.WriteLine();
    Console.Write("Enter command : ");
    //////////////////////////////////////TO GET COMMAND
string CommandAdmin = Console.ReadLine().Replace(" ",string.Empty).ToLower();
switch (CommandAdmin){
case "gotofood":
    bool FoodLoopSTOCK = true;
    do{
AdminStateShowCategory(FoodListMenu);

 string CommandFoodAdmin = Console.ReadLine().Replace(" ",string.Empty).ToLower();
 
 if(CommandFoodAdmin=="select"){
 AdminStategoto_select("FOOD",FoodListMenu);
  TotalFoodStock =0;
for(int i=0;i<FoodListMenu.Count;i++){
            TotalFoodStock+=FoodListMenu[i].Stock;
        }

 }/////SELECT FOOD
 else if(CommandFoodAdmin == "add"){
Console.WriteLine(" ___________________________________ADMIN_____________________________________ ");
Console.WriteLine("                           Add Stock Food Menu ");
Console.WriteLine("   Type cancel to cancel add");
Console.Write("   Enter Menu Name : ");
NameMenu = InputData();

 if (NameMenu != "CANCEL" && NameMenu != ""){
     try{
     Console.Write("   Enter Price to SET : ");
     PriceMenu = int.Parse(Console.ReadLine());
     Console.Write("   Enter Stock to SET : ");
     StockMenu = int.Parse(Console.ReadLine());
     S.Name = NameMenu;
     S.Price = PriceMenu;
     S.Stock = StockMenu;
     FoodListMenu.Add(S);
     for(int i =0 ;i<FoodListMenu.Count;i++){
         Console.WriteLine($"               ADD Menu {FoodListMenu[i].Name} SUCCESS!");
     }
        for(int i =0;i<FoodListMenu.Count;i++){
            TotalFoodStock+=FoodListMenu[i].Stock;
            StockTotal[0] = TotalFoodStock;
        }

     }catch(Exception){
         Console.WriteLine("                               SOMETHING WRONG      ");
         Console.WriteLine(" _____________________________________________________________________________");
     }
 }
  
}
else if (CommandFoodAdmin == "del" ){
    TotalFoodStock = 0;
   DeleteMenu(FoodListMenu);

            for(int i =0;i<FoodListMenu.Count;i++){
            TotalFoodStock+=FoodListMenu[i].Stock;}
     
            StockTotal[0] = TotalFoodStock;

}

else if(CommandFoodAdmin == "back"){
    FoodLoopSTOCK = false;
}
else if(CommandFoodAdmin == "exit"){
    FoodLoopSTOCK = false;
    ExitAdmin = false;
}
else{
    Console.WriteLine("Command Not Found!!");
}
}while(FoodLoopSTOCK != false);
 
 
 
 
 
 
 
break;//////GOTO FOOD
case "gotodrink":

    bool DrinkLoopSTOCK = true;
    do{
AdminStateShowCategory(DrinkListMenu);
 string CommandDrinkAdmin = Console.ReadLine().Replace(" ",string.Empty).ToLower();
 if(CommandDrinkAdmin=="select"){
AdminStategoto_select("DRINK",DrinkListMenu);
  TotalDrinkStock =0;
for(int i=0;i<DrinkListMenu.Count;i++){
            TotalDrinkStock+=DrinkListMenu[i].Stock;
        }
 }/////SELECT DRINK
  else if(CommandDrinkAdmin == "add"){
Console.WriteLine(" ___________________________________ADMIN_____________________________________ ");
Console.WriteLine("                           Add Stock Drink Menu ");
Console.WriteLine("   Type cancel to cancel add");
Console.Write("   Enter Menu Name : ");
NameMenu = InputData();


 if (NameMenu != "CANCEL" && NameMenu != ""){
     try{
     Console.Write("   Enter Price to SET : ");
     PriceMenu = int.Parse(Console.ReadLine());
     Console.Write("   Enter Stock to SET : ");
     StockMenu = int.Parse(Console.ReadLine());
     S.Name = NameMenu;
     S.Price = PriceMenu;
     S.Stock = StockMenu;
     DrinkListMenu.Add(S);
     for(int i =0 ;i<DrinkListMenu.Count;i++){
         Console.WriteLine($"               ADD Menu {DrinkListMenu[i].Name} SUCCESS!");
     }
        for(int i =0;i<DrinkListMenu.Count;i++){
            TotalDrinkStock+=DrinkListMenu[i].Stock;
            StockTotal[1] = TotalDrinkStock;
        }

     }catch(Exception){
         Console.WriteLine("                               SOMETHING WRONG      ");
         Console.WriteLine(" _____________________________________________________________________________");
     }
 }
  
}
else if(CommandDrinkAdmin == "del"){
    DeleteMenu(DrinkListMenu);
          TotalDrinkStock = 0;
        ////////////////////UPDATE CURRENT TOTAL DRINK STOCK 
        for(int i=0;i<DrinkListMenu.Count;i++){
            TotalDrinkStock+=DrinkListMenu[i].Stock;}
            StockTotal[1] = TotalDrinkStock;
        


}
 else if(CommandDrinkAdmin == "back"){
    DrinkLoopSTOCK = false;
}
else if(CommandDrinkAdmin == "exit"){
    DrinkLoopSTOCK = false;
    ExitAdmin = false;
}

}while(DrinkLoopSTOCK != false);
break;
case "gotodessert":

    bool DessertLoopSTOCK = true;
    do{
AdminStateShowCategory(DessertListMenu);
 string CommandDessertAdmin = Console.ReadLine().Replace(" ",string.Empty).ToLower();
 if(CommandDessertAdmin=="select"){
AdminStategoto_select("Dessert",DessertListMenu);
  TotalDessertStock =0;
for(int i=0;i<DessertListMenu.Count;i++){
            TotalDessertStock+=DessertListMenu[i].Stock;
        }
 }
 /////SELECT DESSERT
  else if(CommandDessertAdmin == "add"){
Console.WriteLine(" ___________________________________ADMIN_____________________________________ ");
Console.WriteLine("                           Add Stock Dessert Menu ");
Console.WriteLine("   Type cancel to cancel add");
Console.Write("   Enter Menu Name : ");
NameMenu = InputData();


 if (NameMenu != "CANCEL" && NameMenu != ""){
     try{
     Console.Write("   Enter Price to SET : ");
     PriceMenu = int.Parse(Console.ReadLine());
     Console.Write("   Enter Stock to SET : ");
     StockMenu = int.Parse(Console.ReadLine());
     S.Name = NameMenu;
     S.Price = PriceMenu;
     S.Stock = StockMenu;
     DessertListMenu.Add(S);
     for(int i =0 ;i<DessertListMenu.Count;i++){
         Console.WriteLine($"               ADD Menu {DessertListMenu[i].Name} SUCCESS!");
     }
        for(int i =0;i<DessertListMenu.Count;i++){
            TotalDessertStock+=DessertListMenu[i].Stock;
            StockTotal[2] = TotalDessertStock;
        }

     }catch(Exception){
         Console.WriteLine("                               SOMETHING WRONG      ");
         Console.WriteLine(" _____________________________________________________________________________");
     }
 }
  
}
else if(CommandDessertAdmin == "del"){
    DeleteMenu(DessertListMenu);

         TotalDessertStock = 0;
        ////////////////////UPDATE CURRENT TOTAL FOOD STOCK 
        for(int i=0;i<DessertListMenu.Count;i++){
            TotalDessertStock+=DessertListMenu[i].Stock;}
            StockTotal[2] = TotalDessertStock;
}
 else if(CommandDessertAdmin == "back"){
    DessertLoopSTOCK = false;
}
else if(CommandDessertAdmin == "exit"){
    DessertLoopSTOCK = false;
    ExitAdmin = false;
}
}while(DessertLoopSTOCK != false);
break;
case "back":

    ExitAdmin = false;
break;
case "exit":

    ExitAdmin = false;
break;
default:

    Console.WriteLine("Command not found!!");
    break;
}
}while(ExitAdmin != false);




}

else
{
Console.WriteLine();
Console.WriteLine(" _____________Hey What are you doing__________");
Console.WriteLine("|                                             |");
Console.WriteLine("|        PLEASE ENTER ONLY 1-3 OR TEXT        |");
Console.WriteLine("|             Try to do again |=-=|           |");
Console.WriteLine("|                                             |");
Console.WriteLine("|_____________________________________________|");
Console.WriteLine();
}

}while(repeatouter==true);


    }
}