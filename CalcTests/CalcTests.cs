using CalcCore;

namespace CalcTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Display_ƒолженЅыть–авенЌулю_ѕри—тарте()
        {
            var calc = new Calc();

            Assert.AreEqual(0, calc.Display);
        }

        [TestMethod]
        public void Display_ƒолженЅыть–авен≈денице_ѕри¬воде≈деницы()
        {
            var calc = new Calc();

            calc.Input('1');

            Assert.AreEqual(1, calc.Display);
        }

        [TestMethod]
        public void Display_ƒолженЅыть–авен12_ѕри¬воде12()
        {
            var calc = new Calc();

            calc.Input('1');
            calc.Input('2');

            Assert.AreEqual(12, calc.Display);
        }

        [TestMethod]
        public void Display_ƒолжен¬ыводить¬водЌовогоќперанда_ѕосле¬водаќперации()
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
        public void –авно()
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
        public void –авно–авно()
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
        public void ƒелениеЌаЌоль()
        {
            var calc = new Calc();

            calc.Input('2');
            calc.Input('/');
            calc.Input('0');
            calc.Input('=');

            Assert.AreEqual(0, calc.Display);
        }
        // 2+=                  - на дисплее 4
        [TestMethod]
        public void ѕлюс–авно()
        {
            var calc = new Calc();

            calc.Input('2');
            calc.Input('+');
            calc.Input('=');

            Assert.AreEqual(4, calc.Display);
        }

        // 12+34=78   - на дисплее 9
        [TestMethod]
        public void —умма–авно78()
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

        // 12+34=78-   - на дисплее 9
        [TestMethod]
        public void —умма–азностьЅез„исла()
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

        // 12+34=78-9   - на дисплее 9
        [TestMethod]
        public void —умма–азностьЅез–авно()
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

        // 12+34=78-9=  - на дисплее 69
        [TestMethod]
        public void —умма–азность()
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

        // 3                  - на дисплее 3
        [TestMethod]
        public void ќдна÷ифра()
        {
            var calc = new Calc();

            calc.Input('3');


            Assert.AreEqual(3, calc.Display);
        }

        //[TestMethod]
        //public void  акой_то_тест()
        //{
        //    var calc = new Calc();

        //    Assert.ThrowsException<ArgumentException>(() => calc.Input('y'));
        //}

    }
}