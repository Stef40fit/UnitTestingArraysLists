using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNumberArray = new int[2] { 10, 10 };
        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumberArray);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] evenNumberArray = new int[2] { -9, 7 };
        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumberArray);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixedNumberArray = new int[4] { 9, 7, 2, 6 };
        // Act
        int result = EvenOddSubtraction.FindDifference(mixedNumberArray);

        // Assert
        Assert.That(result, Is.EqualTo(8));
    }
}
