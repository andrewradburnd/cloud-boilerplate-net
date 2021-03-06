﻿using CloudBoilerplateNet.Controllers;
using KenticoCloud.Delivery;
using Microsoft.Extensions.Options;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xunit;

namespace CloudBoilerplateNet.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexTests()
        {
            var options = Options.Create(new ProjectOptions()
            {
                KenticoCloudProjectId = "975bf280-fd91-488c-994c-2f04416e5ee3"
            });

            var controller = new HomeController(options);
            var result = Task.Run(() => controller.Index()).Result;
            
            Assert.Equal(typeof(ReadOnlyCollection<ContentItem>), result.Model.GetType());
        }
    }
}
