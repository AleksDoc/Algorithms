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

        [Test]
        public void Add()
        {
            Assert.That(TestDataList.SequenceEqual(linkedList.ToArray()));
        }

        [Test]
        public void Remove()
        {
            // Act
            linkedList.Remove(6);

            var expectedArray = new int[] { 2, 4, 8 };
            Assert.That(expectedArray.SequenceEqual(linkedList.ToArray()));
        }

        [Test]
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
