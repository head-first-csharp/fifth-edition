namespace JimmyLinq;

public class Review(int issue, Critics critic, double score)
{
    public int Issue { get { return issue; } }
    public Critics Critic { get { return critic; } }
    public double Score { get { return score; } }
}