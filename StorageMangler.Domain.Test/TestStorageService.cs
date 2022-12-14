using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using StorageMangler.Domain.Infrastructure;
using StorageMangler.Domain.Service;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace StorageMangler.Domain.Test
{
    [TestClass()]
    public class TestStorageService
    {
        [TestMethod()]
        public void TestSomething()
        {
            var _storageServie = new Mock<IStorageService>();
            Assert.IsNotNull(_storageServie.SetupAllProperties());
        }
    }
}

