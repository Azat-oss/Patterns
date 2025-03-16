

namespace Home_Work.Builder;

public interface IComputerBuilder
{
    void SetProcessor(string processor);
    void SetRAM(string ram);
    void SetHardDrive(string hardDrive);
    Computer Build();
}
