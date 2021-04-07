using System;
using System.Numerics;

namespace FibonacciTask
{
    /// <summary>
    /// Generator for Fibonacci sequence.
    /// </summary>
    /// <seealso cref="https://en.wikipedia.org/wiki/Fibonacci_number"/>
    public class FibonacciSequence
    {
        private int _count;
        private int _position = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciSequence"/> class.
        /// </summary>
        /// <param name="count">Count of elements in Fibonacci sequence.</param>
        /// <exception cref="ArgumentException">Thrown if count of elements less than one.</exception>
        public FibonacciSequence(int count)
        {
            if (count < 1)
			{
                throw new ArgumentException();
			}

            _count = count;
        }

        /// <summary>
        /// Current element in Fibonacci sequence.
        /// </summary>
        /// <value>
        /// Value of current element in Fibonacci sequence.
        /// </value>
        public BigInteger Current => Fibonacci(_position);

        /// <summary>
        /// Moves to the next element in the sequence.
        /// </summary>
        /// <returns>
        /// True if there are elements in the sequence, false otherwise.
        /// </returns>
        public bool MoveNext()
        {
            _position++;
            return _position < _count;
        }

        /// <summary>
        /// Resets the sequence to the beginning.
        /// </summary>
        public void Reset()
        {
            _position = -1;
        }

        static BigInteger Fibonacci(int n)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }
    }
}