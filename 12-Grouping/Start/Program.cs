﻿using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.GroupByMethod();
var result = vm.GroupByWhereMethod();
// Display Results
vm.Display(result);