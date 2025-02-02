﻿//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace System
{
    using Runtime.CompilerServices;
    /// <summary>
    /// Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.
    /// </summary>
    public static class Math
    {
        /// <summary>
        /// Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π.
        /// </summary>
        /// <remarks>The value of this field is 3.14159265358979323846.</remarks>
        public const double PI = 3.14159265358979323846;

        /// <summary>
        /// Represents the natural logarithmic base, specified by the constant, e.
        /// </summary>
        /// <remarks>The value of this field is 2.7182818284590452354.</remarks>
        public const double E = 2.7182818284590452354;

        /// <summary>
        /// Returns the absolute value of a 32-bit signed integer.
        /// </summary>
        /// <param name="value">A number that is greater than <see cref="int.MinValue"/>, but less than or equal to <see cref="int.MaxValue"/>.</param>
        /// <returns>A 32-bit signed integer, x, such that 0 ≤ x ≤ <see cref="int.MaxValue"/>.</returns>
        public static int Abs(int value)
        {
            return MathInternal.Abs(value);
        }

        /// <summary>
        /// Returns the absolute value of a double-precision floating-point number.
        /// </summary>
        /// <param name="value">A number that is greater than or equal to <see cref="double.MinValue"/>, but less than or equal to <see cref="double.MaxValue"/>.</param>
        /// <returns>A double-precision floating-point number, x, such that 0 ≤ x ≤ <see cref="double.MaxValue"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Abs(double value);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the absolute value of a single-precision floating-point number.
        /// </summary>
        /// <param name="value">A number that is greater than or equal to <see cref="float.MinValue"/>, but less than or equal to <see cref="float.MaxValue"/>.</param>
        /// <returns>A single-precision floating-point number, x, such that 0 ≤ x ≤ <see cref="float.MaxValue"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern float Abs(float value);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the angle whose cosine is the specified number.
        /// </summary>
        /// <param name="d">A number representing a cosine, where d must be greater than or equal to -1, but less than or equal to 1. </param>
        /// <returns>An angle, θ, measured in radians, such that 0 ≤ θ ≤ π -or- <see cref="double.NaN"/> if d &lt; -1 or d > 1 or d equals <see cref="double.NaN"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Acos(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        /// <param name="d">A number representing a sine, where d must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <returns>An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2 -or- <see cref="double.NaN"/> if d &lt; -1 or d> 1 or d equals <see cref="double.NaN"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Asin(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the angle whose tangent is the specified number.
        /// </summary>
        /// <param name="d">A number representing a tangent. </param>
        /// <returns>An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2. -or- <see cref="double.NaN"/> if d equals NaN, -π/2 rounded to double precision(-1.5707963267949) if d equals <see cref="double.NegativeInfinity"/>, or π/2 rounded to double precision(1.5707963267949) if d equals <see cref="double.PositiveInfinity"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Atan(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the angle whose tangent is the quotient of two specified numbers.
        /// </summary>
        /// <param name="y">The y coordinate of a point. </param>
        /// <param name="x">The x coordinate of a point. </param>
        /// <returns>An angle, θ, measured in radians, such that -π ≤ θ ≤ π, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Atan2(double y, double x);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the cube root of a specified number.
        /// </summary>
        /// <param name="d">The number whose cube root is to be found.</param>
        /// <returns>The cube root of d. -or- <see cref="double.NaN"/> if <paramref name="d"/> equals <see cref="double.NaN"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Cbrt(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
        /// </summary>
        /// <param name="d">A double-precision floating-point number. </param>
        /// <returns>The smallest integral value that is greater than or equal to d. If d is equal to <see cref="double.NaN"/>, <see cref="double.NegativeInfinity"/>, or <see cref="double.PositiveInfinity"/>, that value is returned. Note that this method returns a <see cref="double"/> instead of an integral type.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Ceiling(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns <paramref name="value"/> clamped to the inclusive range of <paramref name="min"/> and <paramref name="max"/>.
        /// </summary>
        /// <param name="value">The value to be clamped.</param>
        /// <param name="min">The lower bound of the result.</param>
        /// <param name="max">The upper bound of the result.</param>
        /// <exception cref="ArgumentException">If <paramref name="max"/> &lt; <paramref name="min"/>.</exception>
        /// <returns>
        /// <paramref name="value"/> if <paramref name="min"/> ≤ <paramref name="value"/> ≤ <paramref name="max"/>.
        /// -or-
        /// <paramref name="min"/> if <paramref name="value"/>&lt;<paramref name="min"/>.
        /// -or-
        /// max if <paramref name="max"/>&lt;<paramref name="value"/>.
        /// </returns>
        public static double Clamp(
            double value,
            double min,
            double max)
        {
            if (max < min)
            {
#pragma warning disable S3928 // Parameter names used into ArgumentException constructors should match an existing one 
                throw new ArgumentException();
#pragma warning restore S3928 // Parameter names used into ArgumentException constructors should match an existing one 
            }

            if (double.IsNaN(value))
            {
                return double.NaN;
            }

            if (double.IsNaN(min) && double.IsNaN(max))
            {
                return value;
            }

            if (double.IsNaN(min) && !double.IsNaN(max))
            {
                return (value > max) ? max : value;
            }

            if (!double.IsNaN(min) && double.IsNaN(max))
            {
                if (value < min)
                {
                    return min;
                }
                else
                {
                    return value;
                }
            }

            if (value < min)
            {
                return min;
            }
            else
            {
                return (value > max) ? max : value;
            }
        }

        /// <summary>
        /// Returns <paramref name="value"/> clamped to the inclusive range of <paramref name="min"/> and <paramref name="max"/>.
        /// </summary>
        /// <param name="value">The value to be clamped.</param>
        /// <param name="min">The lower bound of the result.</param>
        /// <param name="max">The upper bound of the result.</param>
        /// <exception cref="ArgumentException">If <paramref name="max"/> &lt; <paramref name="min"/>.</exception>
        /// <returns>
        /// <paramref name="value"/> if <paramref name="min"/> ≤ <paramref name="value"/> ≤ <paramref name="max"/>.
        /// -or-
        /// <paramref name="min"/> if <paramref name="value"/>&lt;<paramref name="min"/>.
        /// -or-
        /// max if <paramref name="max"/>&lt;<paramref name="value"/>.
        /// </returns>
        public static long Clamp(
            long value,
            long min,
            long max)
        {
            if (max < min)
            {
#pragma warning disable S3928 // Parameter names used into ArgumentException constructors should match an existing one 
                throw new ArgumentException();
#pragma warning restore S3928 // Parameter names used into ArgumentException constructors should match an existing one 
            }

            if (value < min)
            {
                return min;
            }
            else
            {
                return (value > max) ? max : value;
            }
        }

        /// <summary>
        /// Returns <paramref name="value"/> clamped to the inclusive range of <paramref name="min"/> and <paramref name="max"/>.
        /// </summary>
        /// <param name="value">The value to be clamped.</param>
        /// <param name="min">The lower bound of the result.</param>
        /// <param name="max">The upper bound of the result.</param>
        /// <exception cref="ArgumentException">If <paramref name="max"/> &lt; <paramref name="min"/>.</exception>
        /// <returns>
        /// <paramref name="value"/> if <paramref name="min"/> ≤ <paramref name="value"/> ≤ <paramref name="max"/>.
        /// -or-
        /// <paramref name="min"/> if <paramref name="value"/>&lt;<paramref name="min"/>.
        /// -or-
        /// max if <paramref name="max"/>&lt;<paramref name="value"/>.
        /// </returns>
        public static float Clamp(
            float value,
            float min,
            float max) => (float)Clamp(
                (double)value,
                min,
                max);

        /// <summary>
        /// Returns <paramref name="value"/> clamped to the inclusive range of <paramref name="min"/> and <paramref name="max"/>.
        /// </summary>
        /// <param name="value">The value to be clamped.</param>
        /// <param name="min">The lower bound of the result.</param>
        /// <param name="max">The upper bound of the result.</param>
        /// <exception cref="ArgumentException">If <paramref name="max"/> &lt; <paramref name="min"/>.</exception>
        /// <returns>
        /// <paramref name="value"/> if <paramref name="min"/> ≤ <paramref name="value"/> ≤ <paramref name="max"/>.
        /// -or-
        /// <paramref name="min"/> if <paramref name="value"/>&lt;<paramref name="min"/>.
        /// -or-
        /// max if <paramref name="max"/>&lt;<paramref name="value"/>.
        /// </returns>
        public static ulong Clamp(
            ulong value,
            ulong min,
            ulong max)
        {
            if (max < min)
            {
#pragma warning disable S3928 // Parameter names used into ArgumentException constructors should match an existing one 
                throw new ArgumentException();
#pragma warning restore S3928 // Parameter names used into ArgumentException constructors should match an existing one 
            }

            if (value < min)
            {
                return min;
            }
            else
            {
                return (value > max) ? max : value;
            }
        }

        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        /// <param name="a">An angle, measured in radians. </param>
        /// <returns>The cosine of a. If a is equal to <see cref="double.NaN"/>, <see cref="double.NegativeInfinity"/>, or <see cref="double.PositiveInfinity"/>, this method returns <see cref="double.NaN"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Cos(double a);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in radians. </param>
        /// <returns>The hyperbolic cosine of <paramref name="value"/>. If <paramref name="value"/> is equal to <see cref="double.NegativeInfinity"/> or <see cref="double.PositiveInfinity"/>, <see cref="double.PositiveInfinity"/> is returned. If value is equal to <see cref="double.NaN"/>, <see cref="double.NaN"/> is returned.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Cosh(double value);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns e raised to the specified power.
        /// </summary>
        /// <param name="d">A number specifying a power. </param>
        /// <returns>The number e raised to the power <paramref name="d"/>. If <paramref name="d"/> equals <see cref="double.NaN"/> or <see cref="double.PositiveInfinity"/>, that value is returned. If <paramref name="d"/> equals <see cref="double.NegativeInfinity"/>, 0 is returned.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Exp(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the largest integer less than or equal to the specified double-precision floating-point number.
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>The largest integer less than or equal to <paramref name="d"/>. If <paramref name="d"/> is equal to <see cref="double.NaN"/>, <see cref="double.NegativeInfinity"/>, or <see cref="double.PositiveInfinity"/>, that value is returned.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Floor(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the remainder resulting from the division of a specified number by another specified number.
        /// </summary>
        /// <param name="x">A dividend. </param>
        /// <param name="y">A divisor. </param>
        /// <returns>A number equal to <paramref name="x"/> - (<paramref name="y"/> Q), where Q is the quotient of <paramref name="x"/> / <paramref name="y"/> rounded to the nearest integer (if <paramref name="x"/> / <paramref name="y"/> falls halfway between two integers, the even integer is returned).
        /// If <paramref name="x"/> - (<paramref name="y"/> Q) is zero, the value +0 is returned if <paramref name="x"/> is positive, or -0 if <paramref name="x"/> is negative.
        /// If <paramref name="y"/> = 0, <see cref="double.NaN"/> is returned.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double IEEERemainder(double x, double y);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the natural (base e) logarithm of a specified number.
        /// </summary>
        /// <param name="d">The number whose logarithm is to be found. </param>
        /// <returns>The natural logarithm of <paramref name="d"/>; that is, ln <paramref name="d"/>, or log e <paramref name="d"/></returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Log(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="d">A number whose logarithm is to be found. </param>
        /// <returns>The base 10 log of <paramref name="d"/>; that is, log 10 <paramref name="d"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Log10(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the larger of two 32-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 32-bit signed integers to compare. </param>
        /// <param name="val2">The second of two 32-bit signed integers to compare. </param>
        /// <returns>Parameter <paramref name="val1"/> or <paramref name="val2"/>, whichever is larger.</returns>
        public static int Max(int val1, int val2)
        {
            return MathInternal.Max(val1, val2);
        }

        /// <summary>
        /// Returns the larger of two double-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare. </param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare. </param>
        /// <returns>Parameter <paramref name="val1"/> or <paramref name="val2"/>, whichever is larger. If <paramref name="val1"/>, <paramref name="val2"/>, or both <paramref name="val1"/> and <paramref name="val2"/> are equal to <see cref="double.NaN"/>, <see cref="double.NaN"/> is returned.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Max(double val1, double val2);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the larger of two single-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
        /// <returns>Parameter <paramref name="val1"/> or <paramref name="val2"/>, whichever is larger. If <paramref name="val1"/>, or <paramref name="val2"/>, or both <paramref name="val1"/> and <paramref name="val2"/> are equal to <see cref="float.NaN"/>, <see cref="float.NaN"/> is returned.</returns>
        public static float Max(float val1, float val2)
        {
            return (float)Max((double)val1, val2);
        }

        /// <summary>
        /// Returns the smaller of two 32-bit signed integers.
        /// </summary>
        /// <param name="val1">The first of two 32-bit signed integers to compare. </param>
        /// <param name="val2">The second of two 32-bit signed integers to compare. </param>
        /// <returns>Parameter <paramref name="val1"/> or <paramref name="val2"/>, whichever is smaller.</returns>
        public static int Min(int val1, int val2)
        {
            return MathInternal.Min(val1, val2);
        }

        /// <summary>
        /// Returns the smaller of two double-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare. </param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare. </param>
        /// <returns>Parameter <paramref name="val1"/> or <paramref name="val2"/>, whichever is smaller. If <paramref name="val1"/>, <paramref name="val2"/>, or both <paramref name="val1"/> and <paramref name="val2"/> are equal to <see cref="double.NaN"/>, <see cref="double.NaN"/> is returned.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Min(double val1, double val2);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the smaller of two single-precision floating-point numbers.
        /// </summary>
        /// <param name="val1">The first of two single-precision floating-point numbers to compare. </param>
        /// <param name="val2">The second of two single-precision floating-point numbers to compare. </param>
        /// <returns>Parameter <paramref name="val1"/> or <paramref name="val2"/>, whichever is smaller. If <paramref name="val1"/>, <paramref name="val2"/>, or both <paramref name="val1"/> and <paramref name="val2"/> are equal to <see cref="float.NaN"/>, <see cref="float.NaN"/> is returned.</returns>
        public static float Min(float val1, float val2)
        {
            return (float)Min((double)val1, val2);
        }

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A double-precision floating-point number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number <paramref name="x"/> raised to the power <paramref name="y"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Pow(double x, double y);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Rounds a double-precision floating-point value to the nearest integral value.
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <returns>The integer nearest <paramref name="a"/>. If the fractional component of <paramref name="a"/> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a <see cref="double"/> instead of an integral type.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Round(double a);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns a value indicating the sign of a double-precision floating-point number.
        /// </summary>
        /// <param name="value">A signed number. </param>
        /// <returns>A number that indicates the sign of <paramref name="value"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern int Sign(double value);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns a value indicating the sign of a single-precision floating-point number.
        /// </summary>
        /// <param name="value">A signed number. </param>
        /// <returns>A number that indicates the sign of <paramref name="value"/>.</returns>
        public static int Sign(float value)
        {
            return Sign((double)value);
        }

        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        /// <param name="a">An angle, measured in radians. </param>
        /// <returns>The sine of <paramref name="a"/>. If a is equal to <see cref="double.NaN"/>, <see cref="double.NegativeInfinity"/>, or <see cref="double.PositiveInfinity"/>, this method returns <see cref="double.NaN"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Sin(double a);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the hyperbolic sine of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic sine of <paramref name="value"/>. If <paramref name="value"/> is equal to <see cref="double.NegativeInfinity"/>, <see cref="double.PositiveInfinity"/>, or <see cref="double.NaN"/>, this method returns a <see cref="double"/> equal to <paramref name="value"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Sinh(double value);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="d">The number whose square root is to be found.</param>
        /// <returns>The positive square root of <paramref name="d"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Sqrt(double d);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        /// <param name="a">An angle, measured in radians. </param>
        /// <returns>The tangent of <paramref name="a"/>. If <paramref name="a"/> is equal to <see cref="double.NaN"/>, <see cref="double.NegativeInfinity"/>, or <see cref="double.PositiveInfinity"/>, this method returns <see cref="double.NaN"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Tan(double a);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Returns the hyperbolic tangent of the specified angle.
        /// </summary>
        /// <param name="value">An angle, measured in radians. </param>
        /// <returns>The hyperbolic tangent of <paramref name="value"/>. If <paramref name="value"/> is equal to <see cref="double.NegativeInfinity"/>, this method returns -1. If <paramref name="value"/> is equal to <see cref="double.PositiveInfinity"/>, this method returns 1. If <paramref name="value"/> is equal to <see cref="double.NaN"/>, this method returns <see cref="double.NaN"/>.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Tanh(double value);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Calculates the integral part of a specified double-precision floating-point number.
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>The integral part of <paramref name="d"/>; that is, the number that remains after any fractional digits have been discarded.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // Native methods should be wrapped
        public static extern double Truncate(double d);
#pragma warning restore S4200 // Native methods should be wrapped
    }
}
