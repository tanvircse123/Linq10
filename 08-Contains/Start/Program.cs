using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

//  Call Sample Method
//  var result = vm.AllQuery();
//  var result = vm.AllMethod();
//  var result = vm.AllSalesQuery();
//  var result = vm.AllSalesMethod();
//  var result = vm.AnyQuery();
//  var result = vm.AnyMethod();
//  var result = vm.ContainsComparerQuery();
//  var result = vm.ContainsComparerMethod();
    var result = vm.ExceptByMethod();
// Display Results
vm.Display(result);