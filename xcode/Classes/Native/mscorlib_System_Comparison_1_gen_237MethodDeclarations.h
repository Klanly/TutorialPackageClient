﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// System.Comparison`1<System.UInt64>
struct Comparison_1_t16987;
// System.Object
struct Object_t;
// System.IAsyncResult
struct IAsyncResult_t14;
// System.AsyncCallback
struct AsyncCallback_t15;
// System.IntPtr
#include "mscorlib_System_IntPtr.h"

// System.Void System.Comparison`1<System.UInt64>::.ctor(System.Object,System.IntPtr)
 void Comparison_1__ctor_m126757 (Comparison_1_t16987 * __this, Object_t * ___object, IntPtr_t24 ___method, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Comparison`1<System.UInt64>::Invoke(T,T)
 int32_t Comparison_1_Invoke_m126758 (Comparison_1_t16987 * __this, uint64_t ___x, uint64_t ___y, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IAsyncResult System.Comparison`1<System.UInt64>::BeginInvoke(T,T,System.AsyncCallback,System.Object)
 Object_t * Comparison_1_BeginInvoke_m126759 (Comparison_1_t16987 * __this, uint64_t ___x, uint64_t ___y, AsyncCallback_t15 * ___callback, Object_t * ___object, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Comparison`1<System.UInt64>::EndInvoke(System.IAsyncResult)
 int32_t Comparison_1_EndInvoke_m126760 (Comparison_1_t16987 * __this, Object_t * ___result, MethodInfo* method) IL2CPP_METHOD_ATTR;