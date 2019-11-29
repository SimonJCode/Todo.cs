using System;
using System.Collections.Generic;
using Xunit;

namespace src.tests
{
    public class UnitTest1
    {
        [Fact]
        public void TodoAdded()
        {
            //arrange
            ToDoRepository tr = new ToDoRepository();
            ToDoDeadline tdd = new ToDoDeadline("tests", "test", "tests", 1);
            ToDoChecklist tdc = new ToDoChecklist();
            int expected = 2;

            //Act
            tr.todolist.Add(tdd);
            tr.todolist.Add(tdc);

            //assert
            Assert.Equal(expected, tr.todolist.Count);
        }
        [Fact]
        public void TodoFinished()
        {
            //Arrange
            ToDoRepository tr = new ToDoRepository();
            ToDoChecklist tdc = new ToDoChecklist();
            ToDoDeadline tdd = new ToDoDeadline("tests", "test", "tests", 1);

            //Act
            tr.todolist.Add(tdc);
            tr.todolist.Add(tdd);
            tr.SetToDoFinshed(1);
            tr.SetToDoFinshed(2);
            

            //Assert
            Assert.False(tdc.active);
            Assert.False(tdd.active);
        }
        [Fact]
        public void TodoRemoved()
        {
            //Arrange
            ToDoRepository tr = new ToDoRepository();
            ToDoChecklist tdc = new ToDoChecklist();
            ToDoDeadline tdd = new ToDoDeadline("tests", "test", "tests", 1);
            int expected = 2;

            //Act
            tr.todolist.Add(tdc);
            tr.todolist.Add(tdd);
            tr.SetToDoFinshed(1);
            tr.SetToDoFinshed(2);
            tr.ArchiveInactiveToDo();

            //Assert
            Assert.Empty(tr.todolist);
            Assert.Equal(expected, tr.inactiveTodoList.Count);
        }
    }
}
