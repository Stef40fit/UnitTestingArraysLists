using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    { 
        // Arrange
        List<int> list = new List<int>() { 1 };
         // Act
        int number = MaxNumber.FindMax(list);
        // Assert
        Assert.That(number, Is.EqualTo(1));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { 1, 2, 3, 4 };

        // Act
        int number = MaxNumber.FindMax(list);
        // Assert
        Assert.That(number, Is.EqualTo(4));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() {-1, -2, -9 };
        // Act
        int number = MaxNumber.FindMax(list);
        // Assert
        Assert.That(number, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { -1, -2, 1, -9 };
        // Act
        int number = MaxNumber.FindMax(list);
        // Assert
        Assert.That(number, Is.EqualTo(1));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { -1, -2, -9, 1 , 1};
        // Act
        int number = MaxNumber.FindMax(list);
        // Assert
        Assert.That(number, Is.EqualTo(1));
    }
}
