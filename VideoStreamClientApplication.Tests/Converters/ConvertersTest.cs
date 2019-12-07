using System;
using AForge.Video;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoStreamClientApplication.Converters.Tests
{
    [TestClass]
    public class ConvertersTest
    {
        private readonly MjpegStreamUriToStringConverter _mjpegStreamUriToStringConverter =
            new MjpegStreamUriToStringConverter();

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void ConvertTest()
        {
            _mjpegStreamUriToStringConverter.Convert(new MJPEGStream(), typeof(string), null, null);
        }

        [TestMethod]
        public void ConvertBackTest()
        {
            Assert.IsInstanceOfType(
                _mjpegStreamUriToStringConverter.ConvertBack("testString", typeof(MJPEGStream), null, null),
                typeof(MJPEGStream));
        }
    }
}