class DuckComparer : IComparer<Duck>
{
    public SortCriteria SortBy = SortCriteria.SizeThenKind;

    public int Compare(Duck? x, Duck? y)
    {
        if (x == null || y == null) return 0;
        if (SortBy == SortCriteria.SizeThenKind)
            if (x.Size > y.Size)
                return 1;
            else if (x.Size < y.Size)
                return -1;
            else
                if (x.Kind > y.Kind)
                return 1;
            else if (x.Kind < y.Kind)
                return -1;
            else
                return 0;
        else
            if (x.Kind > y.Kind)
            return 1;
        else if (x.Kind < y.Kind)
            return -1;
        else
            if (x.Size > y.Size)
            return 1;
        else if (x.Size < y.Size)
            return -1;
        else
            return 0;
    }
}