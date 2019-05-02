using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Tests
{
  // [TestClass]
  // public class ItemTest : IDisposable
  // {
  //
  //   public void Dispose()
  //   {
  //     Item.ClearAll();
  //   }
  //
  //   [TestMethod]
  //   public void ItemConstructor_CreatesInstanceOfItem_Item()
  //   {
  //     Item newItem = new Item("test");
  //     Assert.AreEqual(typeof(Item), newItem.GetType());
  //   }
  //
  //   [TestMethod]
  //   public void GetDescription_ReturnsDescription_String()
  //   {
  //     // Arrange
  //     string description = "Do something";
  //     Item newItem = new Item(description);
  //
  //     // Act
  //     string result = newItem.GetDescription();
  //
  //     // Assert
  //     Assert.AreEqual(description, result);
  //   }
  //
  //   [TestMethod]
  //   public void SetDescription_SetDescription_String()
  //   {
  //     // Arrange
  //     string description = "Walk the dog";
  //     Item newItem = new Item(description);
  //
  //     // Act
  //     string updatedDescription = "Do the dishes";
  //     newItem.SetDescription(updatedDescription);
  //     string result = newItem.GetDescription();
  //
  //     // Assert
  //     Assert.AreEqual(updatedDescription, result);
  //   }
  //
  //   [TestMethod]
  //   public void GetAll_ReturnsEmptyList_ITemList()
  //   {
  //     // Arrange
  //     List<Item> newList = new List<Item> {};
  //
  //     // Act
  //     List<Item> result = Item.GetAll();
  //
  //     // Assert
  //     CollectionAssert.AreEqual(newList, result);
  //   }
  //
  //   [TestMethod]
  //   public void GetAll_ReturnsItems_ItemList()
  //   {
  //     // Arrange
  //     string description01 = "Walk the dog";
  //     string description02 = "Wash the dishes";
  //     Item newItem1 = new Item(description01);
  //     Item newItem2 = new Item(description02);
  //     List<Item> newList = new List<Item> { newItem1, newItem2 };
  //
  //     // Act
  //     List<Item> result = Item.GetAll();
  //
  //     // Assert
  //     CollectionAssert.AreEqual(newList, result);
  //   }
  //
  //   [TestMethod]
  //   public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
  //   {
  //     // Arrange
  //     string description = "Suck my butt.";
  //     Item newItem = new Item(description);
  //
  //     //Act
  //     int result = newItem.GetId();
  //
  //     //Assert
  //     Assert.AreEqual(1, result);
  //   }
  //
  //   [TestMethod]
  //   public void Find_ReturnsCorrectItem_Item()
  //   {
  //     //Arrange
  //     string description01 = "wash ass";
  //     string description02 = "party on";
  //     Item newItem1 = new Item(description01);
  //     Item newItem2 = new Item(description02);
  //
  //     //ACT
  //     Item result = Item.Find(2);
  //
  //     //Assert
  //     Assert.AreEqual(newItem2, result);
  //   }

  }
}
