1.Create a asp.net project.
2.Download Microsoft.EntityFramework.core,Microsoft.EntityFramework.sql,Microsoft.EntityFramework.tool,Microsoft.EntityFramework.design.
3.Create product cs file as well as mycontext cs file in models.
4.Then write connectionstring in appsetting.json file(sql server name and database name from SSMS).
5.Write builder.services in program.cs file.
6.Then do migration and update database.
7.Create a controller .
8.In Controller , create action method for return(addproduct) .
9.Create httppost for those action method for taking data from view and create view page .
10.We need to create image(images) folder in wwwroot.
11.Create another action method for show data(ShowImage).
12.Create view page for this(ShowImage) action mehthod.
13.Pass received data from previous(addproduct) method through return view(....).
