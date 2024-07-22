namespace BlazorBeehiveManagementSystem;

interface IWorker
{
    string Job { get; }
    bool WorkTheNextShift();
}
