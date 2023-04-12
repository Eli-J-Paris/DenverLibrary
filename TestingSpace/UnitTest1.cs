using DenverLibrary;
using static System.Reflection.Metadata.BlobBuilder;

namespace TestingSpace
{
    public class UnitTest1
    {   //Book Tests
        [Fact]
        public void CheckIfTitle_of_BookWorks()
        {
            Book book1 = new Book("Harry Potter", "JKR");
            Assert.Equal("Harry Potter", book1.Title);
        }

        [Fact]
        public void CheckIfAuthor_Of_BookWorks()
        {
            Book book1 = new Book("Harry Potter", "JKR");
            Assert.Equal("JKR", book1.Author);
        }


        //Branch tests
        [Fact]
        public void CheckNameOfBranch()
        {
            Branch branch1 = new Branch("sam&gary");
            Assert.Equal("sam&gary", branch1.Name);
        }

        [Fact]
        public void Check_AddBookMethod_Works()
        {
            Book book1 = new Book("Harry Potter", "JKR");
            Branch branch1 = new Branch("sam&gary");

            branch1.AddBook(book1);

            Assert.Equal("Harry Potter", book1.Title);
        }
        [Fact]
        public void Check_AllAuthorsMethod_Works()
        {
            Book book1 = new Book("Harry Potter", "JKR");
            Branch branch1 = new Branch("sam&gary");
            //branch1.AddBook(book1);
            List<string> allAuthors = branch1.AllAuthors();

            Assert.Equal( new List<string>(), allAuthors);
        }

        //Library Test
        [Fact]
        public void Check_Library_Name()
        {
            Library library1 = new Library("DPL");
            Assert.Equal("DPL", library1.Name);
        }
        [Fact]
        public void Check_AddBranchMethod_Works()
        {
            Library library1 = new Library("DPL");
            Branch branch1 = new Branch("s&g");
            library1.AddBranch(branch1);

            Assert.Equal("s&g", library1.Branches.First());

        }



    }
}