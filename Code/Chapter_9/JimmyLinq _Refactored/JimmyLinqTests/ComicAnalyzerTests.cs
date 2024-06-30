namespace JimmyLinqTests;

using JimmyLinq;

[TestClass]
public class ComicAnalyzerTests
{
    [TestMethod]
    public void ComicAnalyzerShouldGroupComics()
    {
        // Arrange: Set up some comics and prices
        IEnumerable<Comic> testComics = [
             new Comic("Issue 1", 1),
             new Comic("Issue 2", 2),
             new Comic("Issue 3", 3),
        ];

        Dictionary<int, decimal> prices = new()
        {
            { 1, 20M },
            { 2, 10M },
            { 3, 1000M },
        };

        // Act: Call the method that groups comics by price
        var groups = ComicAnalyzer.GroupComicsByPrice(testComics, prices);

        // Assert: Check the groups and make sure they're correct
        Assert.AreEqual(2, groups.Count());
        Assert.AreEqual(PriceRange.Cheap, groups.First().Key);
        Assert.AreEqual(2, groups.First().First().Issue);
        Assert.AreEqual("Issue 2", groups.First().First().Name);
    }

    [TestMethod]
    public void ComicAnalyzerShouldGenerateAListOfReviews()
    {
        // Arrange: Set up test data with comics and reviews
        IEnumerable<Comic> testComics = [
            new("Issue 1", 1),
            new("Issue 2", 2),
            new("Issue 3", 3),
        ];

        IEnumerable<Review> testReviews = [
            new(1, Critics.MuddyCritic,14.5),
            new(1, Critics.RottenTornadoes,59.93),
            new(2, Critics.MuddyCritic,40.3),
            new(2, Critics.RottenTornadoes,95.11),
        ];

        // Act: Call the method that gets the reviews
        var actualResults =
                 ComicAnalyzer
                   .GetReviews(testComics, testReviews)
                   .ToList();

        // Assert: Check the results to make sure it got the correct reivews
        var expectedResults = new[]
        {
            "MuddyCritic rated #1 'Issue 1' 14.50",
            "RottenTornadoes rated #1 'Issue 1' 59.93",
            "MuddyCritic rated #2 'Issue 2' 40.30",
            "RottenTornadoes rated #2 'Issue 2' 95.11",
        };
        CollectionAssert.AreEqual(expectedResults, actualResults);
    }

    [TestMethod]
    public void ComicAnalyzerShouldHandleWeirdReviewScores()
    {
        // Arrange: Set up test data with weird edge cases
        IEnumerable<Comic> testComics = [
            new("Issue 1", 1),
            new("Issue 2", 2),
            new("Issue 3", 3),
        ];

        IEnumerable<Review> testReviews = [
            new(1, Critics.MuddyCritic, -12.1212),
            new(1, Critics.RottenTornadoes, 391691234.48931),
            new(2, Critics.RottenTornadoes, 0),
            new(2, Critics.MuddyCritic, 40.3),
            new(2, Critics.MuddyCritic, 40.3),
            new(2, Critics.MuddyCritic, 40.3),
            new(2, Critics.MuddyCritic, 40.3),
        ];

        // Act: Call the method that gets the reviews
        var actualResults = ComicAnalyzer.GetReviews(testComics, testReviews).ToList();

        // Assert: Make sure it got the weird edge cases right
        List<string> expectedResults = [
            "MuddyCritic rated #1 'Issue 1' -12.12",
            "RottenTornadoes rated #1 'Issue 1' 391691234.49",
            "RottenTornadoes rated #2 'Issue 2' 0.00",
            "MuddyCritic rated #2 'Issue 2' 40.30",
            "MuddyCritic rated #2 'Issue 2' 40.30",
            "MuddyCritic rated #2 'Issue 2' 40.30",
            "MuddyCritic rated #2 'Issue 2' 40.30",
        ];
        CollectionAssert.AreEqual(expectedResults, actualResults);
    }


}
