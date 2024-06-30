class DuckComparerBySize : IComparer<Duck>
{
    public int Compare(Duck? x, Duck? y)
    {
        if (x == null || y == null) return 0;

        if (x.Size < y.Size)
            return -1;
        if (x.Size > y.Size)
            return 1;
        return 0;
    }
}