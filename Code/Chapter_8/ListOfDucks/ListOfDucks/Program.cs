using ListOfDucks;

List<Duck> ducks = [
    new Duck(17, KindOfDuck.Mallard),
    new Duck(18, KindOfDuck.Muscovy),
    new Duck(14, KindOfDuck.Loon),
    new Duck(11, KindOfDuck.Muscovy),
    new Duck(14, KindOfDuck.Mallard),
    new Duck(13, KindOfDuck.Loon),
];

// ducks.Sort();

// IComparer<Duck> sizeComparer = new DuckComparerBySize();
// ducks.Sort(sizeComparer);

// IComparer<Duck> kindComparer = new DuckComparerByKind();
// ducks.Sort(kindComparer);

DuckComparer comparer = new DuckComparer();
Console.WriteLine("\nSorting by kind then size\n");
comparer.SortBy = SortCriteria.KindThenSize;
ducks.Sort(comparer);
PrintDucks(ducks);
Console.WriteLine("\nSorting by size then kind\n");
comparer.SortBy = SortCriteria.SizeThenKind;
ducks.Sort(comparer);

PrintDucks(ducks);

void PrintDucks(List<Duck> ducks)
{
    foreach (Duck duck in ducks)
    {
        Console.WriteLine(duck);
    }
}
