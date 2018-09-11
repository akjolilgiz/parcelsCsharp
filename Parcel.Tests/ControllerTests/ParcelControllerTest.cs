using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Controllers;
using Parcels.Models;

namespace Parcels.TestTools
{
  [TestClass]
  public class ParcelControllerTests
  {
    [TestMethod]
    public void Index_HasCorrectModeType_ParcelList()
    {
      //Arrage
      // ParcelController controller = new ParcelController();
      // ViewResult indexView = (ViewResult)controller.Index();
      ViewResult indexView = new ParcelController().Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Parcel>));
    }
  }
}
