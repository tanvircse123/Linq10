using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.OrderByQuery();
//var result = vm.OrderByMethod();
//var result = vm.OrderByDescendingQuery();
//var result = vm.OrderByDescendingMethod();
//var result = vm.OrderByTwoFieldsQuery();
//var result = vm.OrderByTwoFieldsMethod();
var result = vm.OrderByTwoFieldsDescMethod();
// Display Results
vm.Display(result);