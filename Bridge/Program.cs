using Bridge.Abstraction;
using Bridge.Implementation;

//Client using

var computerCase = new ComputerCaseAbstraction(new DT3GlassComputerCase());
computerCase.PowerButton(); //Turn On
//computerCase.PowerButton(); //Turn Off

computerCase.ResetButton(); // Forced to turn off and turn on