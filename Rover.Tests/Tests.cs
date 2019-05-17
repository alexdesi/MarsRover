using System;
using System.Security.Cryptography;
using FluentAssertions;
using NUnit.Framework;

namespace Rover.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void InitialPositionIsCorrect()
        {
            var rover = new Rover(0, 0, 'N');
            
            Assert.AreEqual(rover.x, 0);
            Assert.AreEqual(rover.y, 0);
            Assert.AreEqual(rover.direction, 'N');
        }

        [Test]
        public void ExecuteForwardWhenDirectionIsEast()
        {
            var rover = new Rover(0, 0, 'E');
            rover.execute('F');
            
            rover.Position().Should().Equal(1,0);
        }
        
        [Test]
        public void ExecuteBackward()
        {
            var rover = new Rover(0, 0, 'E');
            rover.execute('B');
            rover.Position().Should().Equal(-1, 0);
        }
        
        [Test]
        public void ExecuteForwardWhenDirectionIsWest()
        {
            var rover = new Rover(0, 0, 'W');
            rover.execute('F');
            
            rover.Position().Should().Equal(-1,0);
        }
        
        [Test]
        public void ExecuteForwardWhenDirectionIsNorth()
        {
            var rover = new Rover(0, 0, 'N');
            rover.execute('F');
            
            rover.Position().Should().Equal(1,0);
            Assert.AreEqual(0, rover.x);
            Assert.AreEqual(1, rover.y);
        }

        [Test]
        public void ExecuteBackwardWhenDirectionIsNorth()
        {
            var rover = new Rover(0, 0, 'N');
            rover.execute('B');
            Assert.AreEqual(0, rover.x);
            Assert.AreEqual(-1, rover.y);
        }
        
    }
}
