

namespace Home_Work.Builder;

public class ComputerBuilder : IComputerBuilder
{
    private Computer computer;
    public ComputerBuilder() 
    {
        computer = new Computer();
    }
    public void SetProcessor(string processor)
    {
        computer.Processor = processor;
    }

    public void SetRAM(string ram)
    {
        computer.RAM = ram;
    }

    public void SetHardDrive(string hardDrive)
    {
        computer.HardDrive = hardDrive;
    }

    public Computer Build()
    {
        return computer;
    }
}
