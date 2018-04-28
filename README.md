# Repository Pattern in c# and Entity Framework
This is an example of Repository Pattern using _Entity Framework_

File structure (the most relevant):
* models
* repositories
    * IRepository
    * IMyRepository
    * Repository
    * MyRepository
* MyContext.cs
* MyContextFactory.cs
* UnitOfWork.cs

## Run

### Step 1
To run this example, you must have a database (remember to adapt the connection 
string from the file _global.json_) and a table with the follow structure:

```sql
create table treatment
(
    treatmentid int identity primary key,
    treatmenttext varchar(100),
    -- description of the treatment
    price int,
)
```

### Step 2
Intstall dependencies:
```bash
dotnet restore
```

### Step 3
Compile and run _(from the root path of the project)_:
```bash
dotnet run
```