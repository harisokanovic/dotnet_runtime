// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
    /// <summary>Provides access to X86 BMI1 hardware instructions via intrinsics.</summary>
    [Intrinsic]
    [CLSCompliant(false)]
    public abstract class Bmi1 : X86Base
    {
        internal Bmi1() { }

        /// <summary>Gets a value that indicates whether the APIs in this class are supported.</summary>
        /// <value><see langword="true" /> if the APIs are supported; otherwise, <see langword="false" />.</value>
        /// <remarks>A value of <see langword="false" /> indicates that the APIs will throw <see cref="PlatformNotSupportedException" />.</remarks>
        public static new bool IsSupported { get => IsSupported; }

        /// <summary>Provides access to the x86 BMI1 hardware instructions, that are only available to 64-bit processes, via intrinsics.</summary>
        [Intrinsic]
        public new abstract class X64 : X86Base.X64
        {
            internal X64() { }

            /// <summary>Gets a value that indicates whether the APIs in this class are supported.</summary>
            /// <value><see langword="true" /> if the APIs are supported; otherwise, <see langword="false" />.</value>
            /// <remarks>A value of <see langword="false" /> indicates that the APIs will throw <see cref="PlatformNotSupportedException" />.</remarks>
            public static new bool IsSupported { get => IsSupported; }

            /// <summary>
            /// unsigned __int64 _andn_u64 (unsigned __int64 a, unsigned __int64 b)
            ///   ANDN r64a, r64b, r/m64
            /// This intrinsic is only available on 64-bit processes
            /// </summary>
            public static ulong AndNot(ulong left, ulong right) => AndNot(left, right);

            /// <summary>
            /// unsigned __int64 _bextr_u64 (unsigned __int64 a, unsigned int start, unsigned int len)
            ///   BEXTR r64a, r/m64, r64b
            /// This intrinsic is only available on 64-bit processes
            /// </summary>
            public static ulong BitFieldExtract(ulong value, byte start, byte length) => BitFieldExtract(value, (ushort)(start | (length << 8)));

            /// <summary>
            /// unsigned __int64 _bextr2_u64 (unsigned __int64 a, unsigned __int64 control)
            ///   BEXTR r64a, r/m64, r64b
            /// This intrinsic is only available on 64-bit processes
            /// </summary>
            public static ulong BitFieldExtract(ulong value, ushort control) => BitFieldExtract(value, control);

            /// <summary>
            /// unsigned __int64 _blsi_u64 (unsigned __int64 a)
            ///   BLSI r64, r/m64
            /// This intrinsic is only available on 64-bit processes
            /// </summary>
            public static ulong ExtractLowestSetBit(ulong value) => ExtractLowestSetBit(value);

            /// <summary>
            /// unsigned __int64 _blsmsk_u64 (unsigned __int64 a)
            ///   BLSMSK r64, r/m64
            /// This intrinsic is only available on 64-bit processes
            /// </summary>
            public static ulong GetMaskUpToLowestSetBit(ulong value) => GetMaskUpToLowestSetBit(value);

            /// <summary>
            /// unsigned __int64 _blsr_u64 (unsigned __int64 a)
            ///   BLSR r64, r/m64
            /// This intrinsic is only available on 64-bit processes
            /// </summary>
            public static ulong ResetLowestSetBit(ulong value) => ResetLowestSetBit(value);

            /// <summary>
            /// __int64 _mm_tzcnt_64 (unsigned __int64 a)
            ///   TZCNT r64, r/m64
            /// This intrinsic is only available on 64-bit processes
            /// </summary>
            public static ulong TrailingZeroCount(ulong value) => TrailingZeroCount(value);
        }

        /// <summary>
        /// unsigned int _andn_u32 (unsigned int a, unsigned int b)
        ///   ANDN r32a, r32b, r/m32
        /// </summary>
        public static uint AndNot(uint left, uint right) => AndNot(left, right);

        /// <summary>
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len)
        ///   BEXTR r32a, r/m32, r32b
        /// </summary>
        public static uint BitFieldExtract(uint value, byte start, byte length) => BitFieldExtract(value, (ushort)(start | (length << 8)));

        /// <summary>
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control)
        ///   BEXTR r32a, r/m32, r32b
        /// </summary>
        public static uint BitFieldExtract(uint value, ushort control) => BitFieldExtract(value, control);

        /// <summary>
        /// unsigned int _blsi_u32 (unsigned int a)
        ///   BLSI r32, r/m32
        /// </summary>
        public static uint ExtractLowestSetBit(uint value) => ExtractLowestSetBit(value);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a)
        ///   BLSMSK r32, r/m32
        /// </summary>
        public static uint GetMaskUpToLowestSetBit(uint value) => GetMaskUpToLowestSetBit(value);

        /// <summary>
        /// unsigned int _blsr_u32 (unsigned int a)
        ///   BLSR r32, r/m32
        /// </summary>
        public static uint ResetLowestSetBit(uint value) => ResetLowestSetBit(value);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a)
        ///   TZCNT r32, r/m32
        /// </summary>
        public static uint TrailingZeroCount(uint value) => TrailingZeroCount(value);
    }
}
