
using Home_Work.Builder;
using System.Diagnostics;

var computerBuilder = new ComputerBuilder();
computerBuilder.SetProcessor("Процессор");
computerBuilder.SetRAM("Память");
computerBuilder.SetHardDrive("Жесткий диск");
var computer = computerBuilder.Build();
