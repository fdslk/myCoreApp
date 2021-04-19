using System.Collections.Generic;
using mylib1;
using Xunit;

namespace APP.TEST{
    public class StudentTest{
        [Fact]
        public void ShouldAddStudentCorrect()
        {
        //Given
            List<Class1> studentLists = new List<Class1>();
        //When
            studentLists.Add(new Class1(1, "fzq1", 0));
            studentLists.Add(new Class1(2, "fzq1", 0));
            studentLists.Add(new Class1(3, "fzq1", 0));
        //Then
            Assert.Equal(3, studentLists.Count);
        }
    }
}