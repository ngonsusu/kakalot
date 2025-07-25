using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quasar.Common.Utilities;

namespace Quasar.Common.Tests.Utilities
{
    [TestClass]
    public class ByteConverterTests
    {
        [TestMethod, TestCategory("Utilities")]
        public void StringArrayRoundTrip()
        {
            var input = new[] { "first", "second", "third" };

            var bytes = ByteConverter.GetBytes(input);
            var output = ByteConverter.ToStringArray(bytes);

            CollectionAssert.AreEqual(input, output);
        }
    }
}
