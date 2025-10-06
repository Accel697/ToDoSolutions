using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ToDo.Core;

namespace ToDo.Core.Tests
{
    public class ToDoListTests
    {
        [Fact]
        public void Add_IncreasesCount()
        {
            var list = new ToDoList();
            list.Add(" task ");
            Assert.Equal(1, list.Count);
            Assert.Equal("task", list.Items.First().Title);
        }

        [Fact]
        public void Remove_ById_Works()
        {
            var list = new ToDoList();
            var item = list.Add("a");
            Assert.True(list.Remove(item.Id));
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void Find_ReturnsMatches()
        {
            var list = new ToDoList();
            list.Add("Buy milk");
            list.Add("Read book");
            var found = list.Find("buy").ToList();
            Assert.Single(found);
            Assert.Equal("Buy milk", found[0].Title);
        }
    }
}