﻿var builder = DistributedApplication.CreateBuilder(args);

var sqlpassword = builder.Configuration["sqlpassword"];

var sql = builder.AddSqlServer("sql", sqlpassword).AddDatabase("sqldata");

builder.AddProject<Projects.AspireSQLEFCore>("aspiresql")
    .WithReference(sql);

builder.Build().Run();
