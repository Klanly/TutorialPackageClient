﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// System.RuntimeTypeHandle
struct RuntimeTypeHandle_t7742;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t6402;
// System.Object
struct Object_t;
// System.IntPtr
#include "mscorlib_System_IntPtr.h"
// System.Runtime.Serialization.StreamingContext
#include "mscorlib_System_Runtime_Serialization_StreamingContext.h"

// System.Void System.RuntimeTypeHandle::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
 void RuntimeTypeHandle__ctor_m53537 (RuntimeTypeHandle_t7742 * __this, SerializationInfo_t6402 * ___info, StreamingContext_t6414  ___context, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IntPtr System.RuntimeTypeHandle::get_Value()
 IntPtr_t24 RuntimeTypeHandle_get_Value_m53538 (RuntimeTypeHandle_t7742 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.RuntimeTypeHandle::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
 void RuntimeTypeHandle_GetObjectData_m53539 (RuntimeTypeHandle_t7742 * __this, SerializationInfo_t6402 * ___info, StreamingContext_t6414  ___context, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.RuntimeTypeHandle::Equals(System.Object)
 bool RuntimeTypeHandle_Equals_m53540 (RuntimeTypeHandle_t7742 * __this, Object_t * ___obj, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.RuntimeTypeHandle::GetHashCode()
 int32_t RuntimeTypeHandle_GetHashCode_m53541 (RuntimeTypeHandle_t7742 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
