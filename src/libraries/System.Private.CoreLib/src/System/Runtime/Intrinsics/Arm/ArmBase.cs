// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
    /// <summary>Provides access to the ARM base hardware instructions via intrinsics.</summary>
    [Intrinsic]
    [CLSCompliant(false)]
    public abstract class ArmBase
    {
        internal ArmBase() { }

        /// <summary>Gets a value that indicates whether the APIs in this class are supported.</summary>
        /// <value><see langword="true" /> if the APIs are supported; otherwise, <see langword="false" />.</value>
        /// <remarks>A value of <see langword="false" /> indicates that the APIs will throw <see cref="PlatformNotSupportedException" />.</remarks>
        public static bool IsSupported { get => IsSupported; }

        /// <summary>Provides access to the ARM base hardware instructions, that are only available to 64-bit processes, via intrinsics.</summary>
        [Intrinsic]
        public abstract class Arm64
        {
            internal Arm64() { }

            /// <summary>Gets a value that indicates whether the APIs in this class are supported.</summary>
            /// <value><see langword="true" /> if the APIs are supported; otherwise, <see langword="false" />.</value>
            /// <remarks>A value of <see langword="false" /> indicates that the APIs will throw <see cref="PlatformNotSupportedException" />.</remarks>
            public static bool IsSupported { get => IsSupported; }

            /// <summary>
            ///   A64: CLS Wd, Wn
            /// </summary>
            public static int LeadingSignCount(int value) => LeadingSignCount(value);

            /// <summary>
            ///   A64: CLS Xd, Xn
            /// </summary>
            public static int LeadingSignCount(long value) => LeadingSignCount(value);

            /// <summary>
            ///   A64: CLZ Xd, Xn
            /// </summary>
            public static int LeadingZeroCount(long value) => LeadingZeroCount(value);

            /// <summary>
            ///   A64: CLZ Xd, Xn
            /// </summary>
            public static int LeadingZeroCount(ulong value) => LeadingZeroCount(value);

            /// <summary>
            ///   A64: SMULH Xd, Xn, Xm
            /// </summary>
            public static long MultiplyHigh(long left, long right) => MultiplyHigh(left, right);

            /// <summary>
            ///   A64: UMULH Xd, Xn, Xm
            /// </summary>
            public static ulong MultiplyHigh(ulong left, ulong right) => MultiplyHigh(left, right);

            /// <summary>
            ///   A64: RBIT Xd, Xn
            /// </summary>
            public static long ReverseElementBits(long value) => ReverseElementBits(value);

            /// <summary>
            ///   A64: RBIT Xd, Xn
            /// </summary>
            public static ulong ReverseElementBits(ulong value) => ReverseElementBits(value);
        }

        /// <summary>
        ///   A32: CLZ Rd, Rm
        ///   A64: CLZ Wd, Wn
        /// </summary>
        public static int LeadingZeroCount(int value) => LeadingZeroCount(value);

        /// <summary>
        ///   A32: CLZ Rd, Rm
        ///   A64: CLZ Wd, Wn
        /// </summary>
        public static int LeadingZeroCount(uint value) => LeadingZeroCount(value);

        /// <summary>
        ///   A32: RBIT Rd, Rm
        ///   A64: RBIT Wd, Wn
        /// </summary>
        public static int ReverseElementBits(int value) => ReverseElementBits(value);

        /// <summary>
        ///   A32: RBIT Rd, Rm
        ///   A64: RBIT Wd, Wn
        /// </summary>
        public static uint ReverseElementBits(uint value) => ReverseElementBits(value);

        /// <summary>
        ///   A32: YIELD
        ///   A64: YIELD
        /// </summary>
        public static void Yield() => Yield();
    }
}
