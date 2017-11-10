"Use Autentication";
var table = module.exports = require('azure-mobile-apps').table();

var RegisterDoctor = require("documentdb").DocumentClient;
var config = require("./config");
var url = require('url');
// table.read(function (context) {
//     return context.execute();
// });
function getDatabase() {
    console.log(`Getting database:\n${config.database.id}\n`);

}

// table.read.use(customMiddleware, table.operation);
