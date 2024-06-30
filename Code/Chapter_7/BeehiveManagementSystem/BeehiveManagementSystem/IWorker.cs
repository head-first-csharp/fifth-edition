namespace BeehiveManagementSystem;

interface IWorker
{
    string Job { get; }
    bool WorkTheNextShift();
}
