using CalcCore;

namespace CalcTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Display_�������������������_���������()
        {
            var calc = new Calc();

            Assert.AreEqual(0, calc.Display);
        }

        [TestMethod]
        public void Display_����������������������_���������������()
        {
            var calc = new Calc();

            calc.Input('1');

            Assert.AreEqual(1, calc.Display);
        }

        [TestMethod]
        public void Display_���������������12_��������12()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');

            Assert.AreEqual(12, calc.Display);
        }

        [TestMethod]
        public void Display_��������������������������������_������������������()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');
            calc.Input('+');
            calc.Input('3');
            calc.Input('4');

            Assert.AreEqual(34, calc.Display);
        }

        [TestMethod]
        public void �����()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');
            calc.Input('+');
            calc.Input('3');
            calc.Input('4');
            calc.Input('=');

            Assert.AreEqual(46, calc.Display);
        }

        [TestMethod]
        public void ����������()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');
            calc.Input('+');
            calc.Input('3');
            calc.Input('4');
            calc.Input('=');
            calc.Input('=');
            calc.Input('=');

            Assert.AreEqual(114, calc.Display);
        }

        [TestMethod]
        public void �������������()
        {
            var calc = new Calc();

            calc.Input('2');
            calc.Input('/');
            calc.Input('0');
            calc.Input('=');

            Assert.AreEqual(0, calc.Display);
        }
        // 2+=                  - �� ������� 4
        [TestMethod]
        public void ���������()
        {
            var calc = new Calc();

            calc.Input('2');
            calc.Input('+');
            calc.Input('=');

            Assert.AreEqual(4, calc.Display);
        }

        // 12+34=78   - �� ������� 9
        [TestMethod]
        public void ����������78()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');
            calc.Input('+');
            calc.Input('3');
            calc.Input('4');
            calc.Input('=');
            calc.Input('7');
            calc.Input('8');

            Assert.AreEqual(78, calc.Display);
        }

        // 12+34=78-   - �� ������� 9
        [TestMethod]
        public void ���������������������()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');
            calc.Input('+');
            calc.Input('3');
            calc.Input('4');
            calc.Input('=');
            calc.Input('7');
            calc.Input('8');
            calc.Input('-');

            Assert.AreEqual(78, calc.Display);
        }

        // 12+34=78-9   - �� ������� 9
        [TestMethod]
        public void ���������������������()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');
            calc.Input('+');
            calc.Input('3');
            calc.Input('4');
            calc.Input('=');
            calc.Input('7');
            calc.Input('8');
            calc.Input('-');
            calc.Input('9');

            Assert.AreEqual(9, calc.Display);
        }

        // 12+34=78-9=  - �� ������� 69
        [TestMethod]
        public void �������������()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');
            calc.Input('+');
            calc.Input('3');
            calc.Input('4');
            calc.Input('=');
            calc.Input('7');
            calc.Input('8');
            calc.Input('-');
            calc.Input('9');
            calc.Input('=');

            Assert.AreEqual(69, calc.Display);
        }

        // 3                  - �� ������� 3
        [TestMethod]
        public void ���������()
        {
            var calc = new Calc();

            calc.Input('3');


            Assert.AreEqual(3, calc.Display);
        }

        //[TestMethod]
        //public void �����_��_����()
        //{
        //    var calc = new Calc();

        //    Assert.ThrowsException<ArgumentException>(() => calc.Input('y'));
        //}

    }
}