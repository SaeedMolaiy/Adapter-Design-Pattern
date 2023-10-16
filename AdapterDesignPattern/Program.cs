using AdapterDesignPattern;

var adaptee = new Adaptee();
var adapter = new Adapter(adaptee);

adapter.Request();