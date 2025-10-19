// See https://aka.ms/new-console-template for more information
using DynamicDeserializeJson;



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

Console.WriteLine("#####################################################");

var objModelErrorWithCodeOnly = new ObjModelErrorWithCodeOnly
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
};
try
{
    throw new Exception("Sample exception");
}
catch (Exception ex)
{
    objModelErrorWithCodeOnly.Json = new ErrorWithCodeOnly(ex)
    {
        Code = 1001
    };
}

string objModelErrorWithCodeOnlyJson = System.Text.Json.JsonSerializer.Serialize(objModelErrorWithCodeOnly);
Console.WriteLine("Serialized objModelErrorWithCodeOnly JSON:");
Console.WriteLine(objModelErrorWithCodeOnlyJson);
ObjModelReceiver? objModelErrorWithCodeOnlyObjModel = System.Text.Json.JsonSerializer.Deserialize<ObjModelReceiver>(objModelErrorWithCodeOnlyJson);
string objModelErrorWithCodeOnlyObjModeljsonString = System.Text.Json.JsonSerializer.Serialize(objModelErrorWithCodeOnlyObjModel);
var areEquals = objModelErrorWithCodeOnlyJson == objModelErrorWithCodeOnlyObjModeljsonString;
Console.WriteLine($"Are the serialized JSONs equal? {areEquals}");

Console.WriteLine("#####################################################");


var objModelErroWithInnerExceptionOnly = new ObjModelErroWithInnerExceptionOnly
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
};


try
{
    try
    {
        throw new ArgumentNullException();
    }
    catch (Exception ex)
    {
        throw new AggregateException(ex);
    }
    
}
catch (Exception ex)
{
    objModelErroWithInnerExceptionOnly.Json = new ErroWithInnerExceptionOnly(ex);
}

string objModelErroWithInnerExceptionOnlyJson = System.Text.Json.JsonSerializer.Serialize(objModelErroWithInnerExceptionOnly);
Console.WriteLine("Serialized ErroWithInnerExceptionOnly JSON:");
Console.WriteLine(objModelErroWithInnerExceptionOnlyJson);
ObjModelReceiver? objModelErroWithInnerExceptionOnlyObjModel = System.Text.Json.JsonSerializer.Deserialize<ObjModelReceiver>(objModelErroWithInnerExceptionOnlyJson);
string objModelErroWithInnerExceptionOnlyObjModeljsonString = System.Text.Json.JsonSerializer.Serialize(objModelErroWithInnerExceptionOnlyObjModel);
var areEquals2 = objModelErroWithInnerExceptionOnlyJson == objModelErroWithInnerExceptionOnlyObjModeljsonString;
Console.WriteLine($"Are the serialized JSONs equal? {areEquals2}");

Console.WriteLine("#####################################################");


var objModelErroWithCodeAndStackTrace = new ObjModelErroWithCodeAndStackTrace
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
};

try
{
    throw new ArgumentException();
}
catch (Exception ex)
{

    objModelErroWithCodeAndStackTrace.Json = new ErroWithCodeAndStackTrace(ex)
    {
        Code = 2002
    };
}

string objModelErroWithCodeAndStackTraceJson = System.Text.Json.JsonSerializer.Serialize(objModelErroWithCodeAndStackTrace);
Console.WriteLine("Serialized ErroWithCodeAndStackTrace JSON:");
Console.WriteLine(objModelErroWithCodeAndStackTraceJson);
ObjModelReceiver? objModelErroWithCodeAndStackTraceJsonObjModel = System.Text.Json.JsonSerializer.Deserialize<ObjModelReceiver>(objModelErroWithCodeAndStackTraceJson);
string objModelErroWithCodeAndStackTraceJsonObjModeljsonString = System.Text.Json.JsonSerializer.Serialize(objModelErroWithCodeAndStackTraceJsonObjModel);
var areEquals3 = objModelErroWithCodeAndStackTraceJson == objModelErroWithCodeAndStackTraceJsonObjModeljsonString;
Console.WriteLine($"Are the serialized JSONs equal? {areEquals3}");

Console.WriteLine("#####################################################");



var objModelCustomErrorClass = new ObjModelCustomErrorClass    
{
    StringNonNullable = "Test",
    IntNonNullable = 42,
    StringNullable = null,
    IntNullable = null,
    Json = new CustomErrorClass
    {
        Name = "Custom error message",
        Details = new List<string>
        {
            "Detail 1",
            "Detail 2"
        }
    }
};



string objModelCustomErrorClassJson = System.Text.Json.JsonSerializer.Serialize(objModelCustomErrorClass);
Console.WriteLine("Serialized objModelCustomErrorClassJson JSON:");
Console.WriteLine(objModelCustomErrorClassJson);
ObjModelReceiver? objModelCustomErrorClassJsonObjModel = System.Text.Json.JsonSerializer.Deserialize<ObjModelReceiver>(objModelCustomErrorClassJson);
string objModelCustomErrorClassJsonObjModeljsonString = System.Text.Json.JsonSerializer.Serialize(objModelCustomErrorClassJsonObjModel);
var areEquals4 = objModelCustomErrorClassJson == objModelCustomErrorClassJsonObjModeljsonString;
Console.WriteLine($"Are the serialized JSONs equal? {areEquals4}");

Console.WriteLine("#####################################################");


Console.WriteLine("Deserialized Objects:");

