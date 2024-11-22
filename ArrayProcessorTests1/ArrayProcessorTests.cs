using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ArrayProcessorTests
{
    private ArrayProcessor processor;

    [TestInitialize]
    public void Setup()
    {
        processor = new ArrayProcessor();
    }

    // Тесты для SortArray
    [TestMethod]
    public void SortArray_ShouldSortArrayCorrectly()
    {
        int[] input = { 5, 3, 8, 1 };
        int[] expected = { 1, 3, 5, 8 };
        int[] result = processor.SortArray(input);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void SortArray_ShouldThrowException_WhenArrayIsNull()
    {
        processor.SortArray(null);
    }

    [TestMethod]
    public void SortArray_ShouldHandleEmptyArray()
    {
        int[] input = { };
        int[] result = processor.SortArray(input);
        CollectionAssert.AreEqual(new int[] { }, result);
    }

    // Тесты для FindMax
    [TestMethod]
    public void FindMax_ShouldReturnCorrectMax()
    {
        int[] input = { 1, 7, 3, 9 };
        int result = processor.FindMax(input);
        Assert.AreEqual(9, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void FindMax_ShouldThrowException_WhenArrayIsEmpty()
    {
        processor.FindMax(new int[] { });
    }

    [TestMethod]
    public void FindMax_ShouldReturnElement_WhenArrayHasOneElement()
    {
        int[] input = { 42 };
        int result = processor.FindMax(input);
        Assert.AreEqual(42, result);
    }

    // Тесты для CalculateAverage
    [TestMethod]
    public void CalculateAverage_ShouldReturnCorrectAverage()
    {
        int[] input = { 2, 4, 6, 8 };
        double result = processor.CalculateAverage(input);
        Assert.AreEqual(5.0, result, 0.001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateAverage_ShouldThrowException_WhenArrayIsEmpty()
    {
        processor.CalculateAverage(new int[] { });
    }

    [TestMethod]
    public void CalculateAverage_ShouldReturnElement_WhenArrayHasOneElement()
    {
        int[] input = { 10 };
        double result = processor.CalculateAverage(input);
        Assert.AreEqual(10.0, result, 0.001);
    }
}
