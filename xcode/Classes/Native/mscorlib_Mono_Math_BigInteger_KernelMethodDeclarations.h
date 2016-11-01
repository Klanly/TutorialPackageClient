﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// Mono.Math.BigInteger/Kernel
struct Kernel_t7797;
// Mono.Math.BigInteger
struct BigInteger_t7791;
// Mono.Math.BigInteger[]
struct BigIntegerU5BU5D_t7798;
// System.UInt32[]
struct UInt32U5BU5D_t4794;
// Mono.Math.BigInteger/Sign
#include "mscorlib_Mono_Math_BigInteger_Sign.h"

// Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::AddSameSign(Mono.Math.BigInteger,Mono.Math.BigInteger)
 BigInteger_t7791 * Kernel_AddSameSign_m53694 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi1, BigInteger_t7791 * ___bi2, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::Subtract(Mono.Math.BigInteger,Mono.Math.BigInteger)
 BigInteger_t7791 * Kernel_Subtract_m53695 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___big, BigInteger_t7791 * ___small, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Math.BigInteger/Kernel::MinusEq(Mono.Math.BigInteger,Mono.Math.BigInteger)
 void Kernel_MinusEq_m53696 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___big, BigInteger_t7791 * ___small, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Math.BigInteger/Kernel::PlusEq(Mono.Math.BigInteger,Mono.Math.BigInteger)
 void Kernel_PlusEq_m53697 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi1, BigInteger_t7791 * ___bi2, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger/Sign Mono.Math.BigInteger/Kernel::Compare(Mono.Math.BigInteger,Mono.Math.BigInteger)
 int32_t Kernel_Compare_m53698 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi1, BigInteger_t7791 * ___bi2, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.UInt32 Mono.Math.BigInteger/Kernel::SingleByteDivideInPlace(Mono.Math.BigInteger,System.UInt32)
 uint32_t Kernel_SingleByteDivideInPlace_m53699 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___n, uint32_t ___d, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.UInt32 Mono.Math.BigInteger/Kernel::DwordMod(Mono.Math.BigInteger,System.UInt32)
 uint32_t Kernel_DwordMod_m53700 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___n, uint32_t ___d, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger[] Mono.Math.BigInteger/Kernel::DwordDivMod(Mono.Math.BigInteger,System.UInt32)
 BigIntegerU5BU5D_t7798* Kernel_DwordDivMod_m53701 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___n, uint32_t ___d, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger[] Mono.Math.BigInteger/Kernel::multiByteDivide(Mono.Math.BigInteger,Mono.Math.BigInteger)
 BigIntegerU5BU5D_t7798* Kernel_multiByteDivide_m53702 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi1, BigInteger_t7791 * ___bi2, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::LeftShift(Mono.Math.BigInteger,System.Int32)
 BigInteger_t7791 * Kernel_LeftShift_m53703 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi, int32_t ___n, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::RightShift(Mono.Math.BigInteger,System.Int32)
 BigInteger_t7791 * Kernel_RightShift_m53704 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi, int32_t ___n, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::MultiplyByDword(Mono.Math.BigInteger,System.UInt32)
 BigInteger_t7791 * Kernel_MultiplyByDword_m53705 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___n, uint32_t ___f, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Math.BigInteger/Kernel::Multiply(System.UInt32[],System.UInt32,System.UInt32,System.UInt32[],System.UInt32,System.UInt32,System.UInt32[],System.UInt32)
 void Kernel_Multiply_m53706 (Object_t * __this/* static, unused */, UInt32U5BU5D_t4794* ___x, uint32_t ___xOffset, uint32_t ___xLen, UInt32U5BU5D_t4794* ___y, uint32_t ___yOffset, uint32_t ___yLen, UInt32U5BU5D_t4794* ___d, uint32_t ___dOffset, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Math.BigInteger/Kernel::MultiplyMod2p32pmod(System.UInt32[],System.Int32,System.Int32,System.UInt32[],System.Int32,System.Int32,System.UInt32[],System.Int32,System.Int32)
 void Kernel_MultiplyMod2p32pmod_m53707 (Object_t * __this/* static, unused */, UInt32U5BU5D_t4794* ___x, int32_t ___xOffset, int32_t ___xLen, UInt32U5BU5D_t4794* ___y, int32_t ___yOffest, int32_t ___yLen, UInt32U5BU5D_t4794* ___d, int32_t ___dOffset, int32_t ___mod, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.UInt32 Mono.Math.BigInteger/Kernel::modInverse(Mono.Math.BigInteger,System.UInt32)
 uint32_t Kernel_modInverse_m53708 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi, uint32_t ___modulus, MethodInfo* method) IL2CPP_METHOD_ATTR;
// Mono.Math.BigInteger Mono.Math.BigInteger/Kernel::modInverse(Mono.Math.BigInteger,Mono.Math.BigInteger)
 BigInteger_t7791 * Kernel_modInverse_m53709 (Object_t * __this/* static, unused */, BigInteger_t7791 * ___bi, BigInteger_t7791 * ___modulus, MethodInfo* method) IL2CPP_METHOD_ATTR;