using System;
using Xunit;
using IIG.BinaryFlag;

namespace Lab2Test
{
    public class BinaryFlagTest
    {
        [Fact]
        public void ConstructorWithOneArgTest()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(5);
            Assert.True(tmp.GetFlag());
        }
        [Fact]
        public void ConstructorWithTwoArgsTest1()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(5, true);
            Assert.True(tmp.GetFlag());
        }
        [Fact]
        public void ConstructorWithTwoArgsTest2()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(5, false);
            Assert.False(tmp.GetFlag());
        }
        /*
        [Fact]
        public void ConstructorLengthTest1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(17179868704));
        }
        */
        [Fact]
        public void ConstructorLengthTest2()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(17179868705));
        }
        [Fact]
        public void ConstructorLengthTest3()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(123456);
            Assert.Equal(123456, tmp.ToString().Length);
        }
        [Fact]
        public void GetFlagTest1()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(10);
            Assert.True(tmp.GetFlag());
        }
        [Fact]
        public void GetFlagTest2()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(10, false);
            Assert.False(tmp.GetFlag());
        }
        [Fact]
        public void GetFlagTest3()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(10);
            tmp.ResetFlag(6);
            Assert.False(tmp.GetFlag());
        }
        [Fact]
        public void ToStringSimpleTest()
        {
            MultipleBinaryFlag tmp1 = new MultipleBinaryFlag(10);
            Assert.Equal("TTTTTTTTTT", tmp1.ToString());
            MultipleBinaryFlag tmp2 = new MultipleBinaryFlag(10, false);
            Assert.Equal("FFFFFFFFFF", tmp2.ToString());
        }
        [Fact]
        public void ToStringWithResetFlagTest()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(10);
            tmp.ResetFlag(4);
            tmp.ResetFlag(7);
            Assert.Equal("TTTTFTTFTT", tmp.ToString());
        }
        [Fact]
        public void ToStringWithSetFlagTest()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(10, false);
            tmp.SetFlag(5);
            tmp.SetFlag(9);
            tmp.SetFlag(0);
            Assert.Equal("TFFFFTFFFT", tmp.ToString());
        }
        [Fact]
        public void GetHashCodeTest1()
        {
            MultipleBinaryFlag tmp2 = new MultipleBinaryFlag(10, false);
            MultipleBinaryFlag tmp1 = tmp2;
            Assert.Equal(tmp1, tmp2);
        }
        [Fact]
        public void GetHashCodeTest2()
        {
            MultipleBinaryFlag tmp1 = new MultipleBinaryFlag(10, false);
            MultipleBinaryFlag tmp2 = new MultipleBinaryFlag(10, false);
            Assert.NotEqual(tmp1, tmp2);
        }
        [Fact]
        public void EqualsTest1()
        {
            MultipleBinaryFlag tmp1 = new MultipleBinaryFlag(10, false);
            MultipleBinaryFlag tmp2 = tmp1;
            Assert.True(tmp1.Equals(tmp2));
        }
        [Fact]
        public void GetTypeTest()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(10, false);
            Assert.Equal("IIG.BinaryFlag.MultipleBinaryFlag", tmp.GetType().ToString());
        }
        [Fact]
        public void DisposeTest()
        {
            MultipleBinaryFlag tmp = new MultipleBinaryFlag(10);
            tmp.Dispose();
            Assert.Null(tmp);
        }
    }
}
