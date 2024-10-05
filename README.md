Create a asp.net project.
Download Microsoft.EntityFramework.core,Microsoft.EntityFramework.sql,Microsoft.EntityFramework.tool,Microsoft.EntityFramework.design.
Create product cs file as well as mycontext cs file in models.
Then write connectionstring in appsetting.json file(sql server name and database name from SSMS).
Write builder.services in program.cs file.
Then do migration and update database.
Create a controller .
In Controller , create action method for return(addproduct) .
Create httppost for those action method for taking data from view and create view page .
We need to create image(images) folder in wwwroot.
Create another action method for show data(ShowImage).
Create view page for this(ShowImage) action mehthod.
Pass received data from previous(addproduct) method through return view(....).
