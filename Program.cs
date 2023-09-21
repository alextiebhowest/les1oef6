Dictionary<String, List<int>> dict_aankopen = new Dictionary<String, List<int>>();
dict_aankopen.Add("jan", new List<int>() { 100, 50, 20 });
dict_aankopen.Add("piet", new List<int>() { 10, 70, 20, 4, 58, 542 });
dict_aankopen.Add("karel", new List<int>() { 9 });
dict_aankopen.Add("sandra", new List<int>() { 45, 45, 10 });



List<String> GetExpensiveShoppingBaskets(Dictionary<String, List<int>> dict_aankopen, int value){
    List<String> names = new List<string>();
    foreach(var customer in dict_aankopen){
        if(customer.Value.Sum() > value){
            names.Add(customer.Key);
        }
    }
    return names;
}

void result(List<String>names, int value){
    Console.WriteLine($"The following individuals had a shopping cart value higher than €{value}:");
    foreach(var name in names){
        Console.WriteLine($"-{name}");
    }
}

List<String> names = GetExpensiveShoppingBaskets(dict_aankopen, 200);
result(names, 200);

