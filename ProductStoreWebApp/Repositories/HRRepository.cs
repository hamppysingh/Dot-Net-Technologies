using ProductStoreWebApp.Models;
namespace ProductStoreWebApp.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class RepositoryManager{
    public void Serialize(List<Product> Products,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var ProductsJson=JsonSerializer.Serialize<List<Product>>(Products,options);
    File.WriteAllText(fileName,ProductsJson);
   
    }
    public void SerializeUsers(List<User> user,string fileName){
    
    var options=new JsonSerializerOptions {IncludeFields=true};
    var UsersJson=JsonSerializer.Serialize<List<User>>(user,options);
    File.WriteAllText(fileName,UsersJson);
   
    }
    public List<Product> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
           /* Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Product emp in jsonProducts)
            {
                Console.WriteLine($"{emp.Id} : {emp .Name}");   
            }*/      
        return jsonProducts;
    }
    
    public List<User> DeSerializeUsers(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<User> jsonusers = JsonSerializer.Deserialize<List<User>>(jsonString);
           /* Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Product emp in jsonProducts)
            {
                Console.WriteLine($"{emp.Id} : {emp .Name}");   
            }*/      
        return jsonusers;
    }
}