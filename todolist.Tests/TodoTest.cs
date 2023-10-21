using System.Collections.Immutable;

namespace todolist.Tests
{
    public static class DateTimeProvider
    {
        private static DateTime? testDateTime;

        public static DateTime Now => testDateTime ?? DateTime.Now;

        public static void SetTestDateTime(DateTime dateTime)
        {
            testDateTime = dateTime;
        }

        public static void Reset()
        {
            testDateTime = null;
        }
    }

    public record TodoItem(string Description, DateTime CreatedAt);

    public class TodoTest
    {
        private DateTime now;

        public TodoTest()
        {
            // Set the current date and time to a fixed value for all tests
            now = DateTime.Now;
            // DateTimeProvider.SetTestDateTime(now);
        }


        [Fact]
        public void Add_TodoItemToTodoList()
        {
            // Arrange
            DateTimeProvider.SetTestDateTime(new DateTime(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var todoItem = new TodoItem("Buy milk", DateTimeProvider.Now);
            ImmutableList<TodoItem> todoList = ImmutableList.Create<TodoItem>();


            // Act
            todoList = todoList.Add(todoItem);

            // Assert
            Assert.Single(todoList);
            Assert.Equal("Buy milk", todoList[0].Description);
            Assert.Equal(DateTimeProvider.Now, todoList[0].CreatedAt);
        }

        [Fact]
        public void Add_MultipleTodoItemsToTodoList()
        {
            // Arrange
            DateTimeProvider.SetTestDateTime(new DateTime(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var todoItem1 = new TodoItem("Buy milk", DateTimeProvider.Now);
            var todoItem2 = new TodoItem("Buy eggs", DateTimeProvider.Now);
            ImmutableList<TodoItem> todoList = ImmutableList.Create<TodoItem>();


            // Act
            todoList = todoList.Add(todoItem1);
            todoList = todoList.Add(todoItem2);

            // Assert
            Assert.Equal(2, todoList.Count);
            Assert.Equal("Buy milk", todoList[0].Description);
            Assert.Equal(new DateTime(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc), todoList[0].CreatedAt);
            Assert.Equal("Buy eggs", todoList[1].Description);
            Assert.Equal(new DateTime(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc), todoList[1].CreatedAt);
        }
    }
}