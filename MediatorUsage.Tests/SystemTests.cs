using Xunit;

namespace MediatorUsage.Tests
{
    public class SystemTests
    {
        [Fact]
        public void Assert_MultipleMediatorUsages_ShouldFail()
        {
            var numberOfMediatorUsages = GetNumberOfUsagesForMultipleMediatorUsages();
            Assert.InRange(numberOfMediatorUsages, 0, 1);
        }

        /// <summary>
        /// should analyze this method <see cref="System.MultipleMediatorUsages"/>
        /// </summary>
        /// <returns></returns>
        private int GetNumberOfUsagesForMultipleMediatorUsages()
        {
            return 2;
        }


        [Fact]
        public void Assert_SingleMediatorUsages_ShouldWork()
        {
            var numberOfMediatorUsages = GetNumberOfUsagesForSingleMediatorUsage();
            Assert.InRange(numberOfMediatorUsages, 0, 1);
        }

        /// <summary>
        /// should analyze this method <see cref="System.SingleMediatorUsage"/>
        /// </summary>
        /// <returns></returns>
        private int GetNumberOfUsagesForSingleMediatorUsage()
        {
            return 1;
        }
    }
}