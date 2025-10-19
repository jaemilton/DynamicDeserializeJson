// See https://aka.ms/new-console-template for more information
using DynamicDeserializeJson;

Console.WriteLine("Hello, World!");


var objModel = new ObjModelReceiver
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
    Json = new System.Text.Json.Nodes.JsonObject
    {
        ["key1"] = "value1",
        ["key2"] = 123
    }
};

string jsonString = System.Text.Json.JsonSerializer.Serialize(objModel);

Console.WriteLine("Serialized JSON:");
Console.WriteLine(jsonString);



var objModelErrorWithCodeOnly = new ObjModelErrorWithCodeOnly
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
    Json = new ErrorWithCodeOnly(new Exception("Sample exception"))
    {
        Code = 1001
    }
};
string objModelErrorWithCodeOnlyJson = System.Text.Json.JsonSerializer.Serialize(objModelErrorWithCodeOnly);
Console.WriteLine("Serialized objModelErrorWithCodeOnly JSON:");
Console.WriteLine(objModelErrorWithCodeOnly);
ObjModelReceiver? objModelErrorWithCodeOnlyObjModel = System.Text.Json.JsonSerializer.Deserialize<ObjModelReceiver>(objModelErrorWithCodeOnlyJson);
string objModelErrorWithCodeOnlyObjModeljsonString = System.Text.Json.JsonSerializer.Serialize(objModelErrorWithCodeOnlyObjModel);
var areEquals = objModelErrorWithCodeOnlyJson == objModelErrorWithCodeOnlyObjModeljsonString;
Console.WriteLine($"Are the serialized JSONs equal? {areEquals}");




var objModelErroWithInnerExceptionOnly = new ObjModelErroWithInnerExceptionOnly
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
    Json = new ErroWithInnerExceptionOnly(new Exception("Inner exception message"))
};
string objModelErroWithInnerExceptionOnlyJson = System.Text.Json.JsonSerializer.Serialize(objModelErroWithInnerExceptionOnly);
Console.WriteLine("Serialized ErroWithInnerExceptionOnly JSON:");
Console.WriteLine(objModelErroWithInnerExceptionOnlyJson);
ObjModelReceiver? objModelErroWithInnerExceptionOnlyObjModel = System.Text.Json.JsonSerializer.Deserialize<ObjModelReceiver>(objModelErroWithInnerExceptionOnlyJson);
string objModelErroWithInnerExceptionOnlyObjModeljsonString = System.Text.Json.JsonSerializer.Serialize(objModelErroWithInnerExceptionOnlyObjModel);
var areEquals2 = objModelErroWithInnerExceptionOnlyJson == objModelErroWithInnerExceptionOnlyObjModeljsonString;
Console.WriteLine($"Are the serialized JSONs equal? {areEquals2}");



var objModelErroWithCodeAndStackTrace = new ObjModelErroWithCodeAndStackTrace
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
    Json = new ErroWithCodeAndStackTrace(new Exception("Inner exception message"))
    {
        Code = 2002
    }
};
string objModelErroWithCodeAndStackTraceJson = System.Text.Json.JsonSerializer.Serialize(objModelErroWithCodeAndStackTrace);
Console.WriteLine("Serialized ErroWithCodeAndStackTrace JSON:");
Console.WriteLine(objModelErroWithCodeAndStackTraceJson);
ObjModelReceiver? objModelErroWithCodeAndStackTraceJsonObjModel = System.Text.Json.JsonSerializer.Deserialize<ObjModelReceiver>(objModelErroWithCodeAndStackTraceJson);
string objModelErroWithCodeAndStackTraceJsonObjModeljsonString = System.Text.Json.JsonSerializer.Serialize(objModelErroWithCodeAndStackTraceJsonObjModel);
var areEquals3 = objModelErroWithCodeAndStackTraceJson == objModelErroWithCodeAndStackTraceJsonObjModeljsonString;
Console.WriteLine($"Are the serialized JSONs equal? {areEquals3}");

Console.WriteLine("Deserialized Objects:");

