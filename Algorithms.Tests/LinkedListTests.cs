namespace Algorithms
{
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class LinkedListTests
    {
        private static readonly int[] TestDataList = { 2, 4, 6, 8 };

        private LinkedList<int> linkedList;

        [SetUp]
        public void SetUp()
        {
            this.linkedList = this.CreateLinkedList<int>();
            TestDataList.ToList().ForEach(d => this.linkedList.Add(d));
        }

        [Test(Description = "Checks the adding data")]
        public void Add()
        {
            Assert.That(TestDataList.SequenceEqual(linkedList.ToArray()), Is.True);
        }

        [Test(Description = "Checks the removing data")]
        public void Remove()
        {
            this.linkedList.Remove(6);

            var expectedArray = new int[] { 2, 4, 8 };
            Assert.That(expectedArray.SequenceEqual(linkedList.ToArray()), Is.True);

            Assert.That(this.linkedList.Count == expectedArray.Length, Is.True);
        }

        [Test(Description = "Check the removing all data")]
        public void Clear()
        {
            Assert.That(linkedList.IsEmpty(), Is.False);

            // remove all elements
            linkedList.Clear();

            Assert.That(linkedList.IsEmpty(), Is.True);
        }

        private LinkedList<T> CreateLinkedList<T>()
        {
            return new LinkedList<T>();
        }
    }
}
