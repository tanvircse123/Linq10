using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
// var result = vm.SequenceEqualIntegersQuery();
// var result = vm.SequenceEqualUsingComparerQuery();
// var result = vm.SequenceEqualUsingComparerMethod();
// var result = vm.ExceptIntegersQuery();
// var result = vm.ExceptIntegersMethod();
// var result = vm.ExceptProductSalesQuery();
// var result = vm.ExceptProductSalesMethod();
// var result = vm.ExceptUsingComparerMethod();
// var result = vm.ExceptByMethod();
// var result = vm.IntersectProductSalesQuery();
var result = vm.IntersectProductSalesMethod();
// Display Results
vm.Display(result);