using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
// var result = vm.CountQuery();
// var result = vm.CountMethod();
// var result = vm.SumMethod();
// var result = vm.AggregateQuery(); 
// var result = vm.AverageMethod();
// var result = vm.AggregateCustomQuery(); 
// var result = vm.AggregateCustomMethod();
var result = vm.AggregateUsingGroupByQuery();
// Display Results
vm.Display(result);