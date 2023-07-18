
// authenticator -> logger -> compressor

using chain_of_responsibility_design_pattern.ChainOfResponsibility;

var compressor = new Compressor(null);
var logger = new Logger(compressor);
var authenticator = new Authenticator(logger);

var server = new WebServer(authenticator);

server.Handle(new HttpRequest("admin", "1234"));

Console.ReadLine();