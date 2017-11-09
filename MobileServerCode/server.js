var express = require('express'), azureMobileApps = require('azure-mobile-apps');

var app = express(), mobile = azureMobileApps();

//Defining the TodoItem in the java script database
mobile.tables.add('TodoItem');

//Adding the mobile apiso it is accesible to the web api
app.use(mobile);

//Starting the listening of the HTTP
app.listen(process.env.PORT || 3000);
