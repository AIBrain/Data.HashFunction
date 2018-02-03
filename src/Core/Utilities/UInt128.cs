﻿namespace System.Data.HashFunction.Utilities {

    /// <summary>
    /// Structure to store 128-bit integer as two 64-bit integers.
    /// </summary>
    public struct UInt128
        : IComparable,
            IComparable<UInt128>,
            IEquatable<UInt128> {

        /// <summary>
        /// High-order 64-bits.
        /// </summary>
        public UInt64 High { get; set; }

        /// <summary>
        /// Low-order 64-bits.
        /// </summary>
        public UInt64 Low { get; set; }

        /// <summary>
        /// Implements the add operator.
        /// </summary>
        /// <param name="a">The instance to add to.</param>
        /// <param name="b">The instance to add.</param>
        /// <returns>A new instance representing the first parameter plus the second parameter.</returns>
        public static UInt128 Add( UInt128 a, UInt128 b ) {
            return a + b;
        }

        /// <summary>
        /// Implements the decrement operator.
        /// </summary>
        /// <param name="value">The instance to decrement.</param>
        /// <returns>A new instance representing the value decremented by 1.</returns>
        public static UInt128 Decrement( UInt128 value ) {
            return --value;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="UInt16"/> to <see cref="UInt128"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator UInt128( UInt16 value ) {
            return new UInt128() {
                Low = value,
                High = 0
            };
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="UInt32"/> to <see cref="UInt128"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator UInt128( UInt32 value ) {
            return new UInt128() {
                Low = value,
                High = 0
            };
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="UInt64"/> to <see cref="UInt128"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator UInt128( UInt64 value ) {
            return new UInt128() {
                Low = value,
                High = 0
            };
        }

        /// <summary>
        /// Implements the increment operator.
        /// </summary>
        /// <param name="value">The instance to increment.</param>
        /// <returns>A new instance representing the value incremented by 1.</returns>
        public static UInt128 Increment( UInt128 value ) {
            return ++value;
        }

        /// <summary>
        /// Implements the subtraction operator.
        /// </summary>
        /// <param name="a">The instance to subtract from.</param>
        /// <param name="b">The instance to subtract.</param>
        /// <returns>A new instance representing the first parameter minus the second parameter.</returns>
        public static UInt128 operator -( UInt128 a, UInt128 b ) {
            var borrow = 0UL;
            var lowResult = a.Low - b.Low;

            if ( lowResult > a.Low ) {
                borrow = 1UL;
            }

            return new UInt128() {
                Low = lowResult,
                High = a.High - b.High - borrow
            };
        }

        /// <summary>
        /// Implements the decrement operator.
        /// </summary>
        /// <param name="value">The instance to decrement.</param>
        /// <returns>A new instance representing the value decremented by 1.</returns>
        public static UInt128 operator --( UInt128 value ) {
            return value - 1;
        }

        /// <summary>
        /// Determines whether the second <see cref="UInt128"/> is not equal to the first <see cref="UInt128"/>.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns>
        /// true if the specified value is not equal to the current value; otherwise, false.
        /// </returns>
        public static Boolean operator !=( UInt128 a, UInt128 b ) {
            return !( a == b );
        }

        /// <summary>
        /// Implements the add operator.
        /// </summary>
        /// <param name="a">The instance to add to.</param>
        /// <param name="b">The instance to add.</param>
        /// <returns>A new instance representing the first parameter plus the second parameter.</returns>
        public static UInt128 operator +( UInt128 a, UInt128 b ) {
            var carryOver = 0UL;
            var lowResult = unchecked(a.Low + b.Low);

            if ( lowResult < a.Low ) {
                carryOver = 1UL;
            }

            return new UInt128() {
                Low = lowResult,
                High = a.High + b.High + carryOver
            };
        }

        /// <summary>
        /// Implements the increment operator.
        /// </summary>
        /// <param name="value">The instance to increment.</param>
        /// <returns>A new instance representing the value incremented by 1.</returns>
        public static UInt128 operator ++( UInt128 value ) {
            return value + 1;
        }

        /// <summary>
        /// Implements the less than operator.
        /// </summary>
        /// <param name="a">The instance to compare.</param>
        /// <param name="b">The instance to compare with.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="a"/> is less than <paramref name="b"/>; otherwise <c>false</c>.
        /// </returns>
        public static Boolean operator <( UInt128 a, UInt128 b ) {
            return !( a >= b );
        }

        /// <summary>
        /// Implements the less than or equal to operator.
        /// </summary>
        /// <param name="a">The instance to compare.</param>
        /// <param name="b">The instance to compare with.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="a"/> is less than or equal to <paramref name="b"/>;
        /// otherwise <c>false</c>.
        /// </returns>
        public static Boolean operator <=( UInt128 a, UInt128 b ) {
            return !( a > b );
        }

        /// <summary>
        /// Determines whether the second <see cref="UInt128"/> is equal to the first <see cref="UInt128"/>.
        /// </summary>
        /// <param name="a">The first value to compare.</param>
        /// <param name="b">The second value to compare.</param>
        /// <returns>true if the specified value is equal to the current value; otherwise, false.</returns>
        public static Boolean operator ==( UInt128 a, UInt128 b ) {
            return a.High == b.High && a.Low == b.Low;
        }

        /// <summary>
        /// Implements the greater than operator.
        /// </summary>
        /// <param name="a">The instance to compare.</param>
        /// <param name="b">The instance to compare with.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="a"/> is greater than <paramref name="b"/>; otherwise <c>false</c>.
        /// </returns>
        public static Boolean operator >( UInt128 a, UInt128 b ) {
            return a.High > b.High ||
                ( a.High == b.High && a.Low > b.Low );
        }

        /// <summary>
        /// Implements the greater or equal to than operator.
        /// </summary>
        /// <param name="a">The instance to compare.</param>
        /// <param name="b">The instance to compare with.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="a"/> is greater than or equal to <paramref name="b"/>;
        /// otherwise <c>false</c>.
        /// </returns>
        public static Boolean operator >=( UInt128 a, UInt128 b ) {
            return a.High > b.High ||
                ( a.High == b.High && a.Low >= b.Low );
        }

        /// <summary>
        /// Implements the subtraction operator.
        /// </summary>
        /// <param name="a">The instance to subtract from.</param>
        /// <param name="b">The instance to subtract.</param>
        /// <returns>A new instance representing the first parameter minus the second parameter.</returns>
        public static UInt128 Subtract( UInt128 a, UInt128 b ) {
            return a - b;
        }

        /// <summary>
        /// Compares this instance to a specified object and returns an indication of their relative values.
        /// </summary>
        /// <param name="value">An object to compare, or null.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and <paramref name="value"/>.
        ///
        /// Return Value Description Less than zero This instance is less than <paramref name="value"/>.
        ///
        /// Zero This instance is equal to <paramref name="value"/>.
        ///
        /// Greater than zero This instance is greater than <paramref name="value"/>.-or-
        /// <paramref name="value"/> is null.
        /// </returns>
        /// <exception cref="System.ArgumentException"><paramref name="value"/> is not a <see cref="UInt128"/>.;value</exception>
        public Int32 CompareTo( Object value ) {
            if ( value == null ) {
                return 1;
            }

            if ( !( value is UInt128 ) ) {
                throw new ArgumentException( "value is not a UInt128.", nameof(value) );
            }

            return CompareTo( ( UInt128 )value );
        }

        /// <summary>
        /// Compares this instance to a specified 128-bit unsigned integer and returns an indication
        /// of their relative values.
        /// </summary>
        /// <param name="value">An object to compare with this object.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and <paramref name="value"/>.
        ///
        /// Return Value Description Less than zero This instance is less than <paramref name="value"/>.
        ///
        /// Zero This instance is equal to <paramref name="value"/>.
        ///
        /// Greater than zero This instance is greater than <paramref name="value"/>.
        /// </returns>
        public Int32 CompareTo( UInt128 value ) {
            if ( value < this ) {
                return -1;
            }

            if ( value > this ) {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Determines whether the specified <see cref="UInt128"/> is equal to the current <see cref="UInt128"/>.
        /// </summary>
        /// <param name="obj">The value to compare with the current value.</param>
        /// <returns>true if the specified value is equal to the current value; otherwise, false.</returns>
        public override Boolean Equals( Object obj ) {
            return obj is UInt128 && this == ( UInt128 )obj;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        public Boolean Equals( UInt128 other ) {
            return this == other;
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return Low.GetHashCode() ^
                High.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override String ToString() {
            return String.Format(
                "{{ High = {0}, Low = {1} }}",
                High,
                Low );
        }
    }
}
