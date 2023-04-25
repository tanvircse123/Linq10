using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
// var result = vm.InnerJoinQuery();
//var result = vm.JoinIntoQuery();
var result = vm.LeftOuterJoinQuery();
// Display Results
vm.Display(result);