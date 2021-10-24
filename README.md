# Factory

### ***An [Asp.Net](http://asp.Net) MVC Web App that handles engineers and their machines within a migrated MySQL Database.***

### **By *Aaron Kauffman***

## **Description**

*This web application helps a hypothetical factory owner manage their engineers and machines.* 

# Instructions

1. Add the file `appsettings.json` to the Factory folder. ***It's contents also include other MVC files and folders.***
2. Here's what `appsettings.json` should contain for this specific project. Replace your [DATABASE] and [PASSWORD] appropriately.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=aaron_kauffman;uid=root;pwd=password;"
  }
}
```

3. From within the 'Factory' folder run: 

```bash
dotnet ef migrations add Initial && dotnet ef database update
```

4. From the uppermost directory of your project run:
<br>
(make sure you don't already have an existing database matching the database name in appsettings.json)

```bash
cd Factory && dotnet run
```

## **Technologies Used**

- C#, MVC, [Asp.Net](http://asp.Net) Core, EF Core, MySQL
- HTML, JS, CSS, Bootstrap, git

## **Known Bugs**

- None found so far. Go ahead and break it i guess.

## **License**

[MIT](https://choosealicense.com/licenses/mit/)

## **Contact Information**

*If you run into any issues, remember: Stop, Drop, and Roll. Or, Contact Aaron at: [Aaron.Christian.Kauffman@gmail.com](mailto:Aaron.Christian.Kauffman@gmail.com)*