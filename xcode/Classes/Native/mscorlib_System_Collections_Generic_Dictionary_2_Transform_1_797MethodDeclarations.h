﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// System.Collections.Generic.Dictionary`2/Transform`1<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>,System.Collections.Generic.KeyValuePair`2<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>>>
struct Transform_1_t16388;
// System.Object
struct Object_t;
// System.Type
struct Type_t;
// System.Collections.Generic.IList`1<PropertyMetadata>
struct IList_1_t5494;
// System.IAsyncResult
struct IAsyncResult_t14;
// System.AsyncCallback
struct AsyncCallback_t15;
// System.IntPtr
#include "mscorlib_System_IntPtr.h"
// System.Collections.Generic.KeyValuePair`2<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>>
#include "mscorlib_System_Collections_Generic_KeyValuePair_2_gen_241.h"

// System.Void System.Collections.Generic.Dictionary`2/Transform`1<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>,System.Collections.Generic.KeyValuePair`2<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>>>::.ctor(System.Object,System.IntPtr)
 void Transform_1__ctor_m122351 (Transform_1_t16388 * __this, Object_t * ___object, IntPtr_t24 ___method, MethodInfo* method) IL2CPP_METHOD_ATTR;
// TRet System.Collections.Generic.Dictionary`2/Transform`1<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>,System.Collections.Generic.KeyValuePair`2<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>>>::Invoke(TKey,TValue)
 KeyValuePair_2_t16316  Transform_1_Invoke_m122352 (Transform_1_t16388 * __this, Type_t * ___key, Object_t* ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IAsyncResult System.Collections.Generic.Dictionary`2/Transform`1<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>,System.Collections.Generic.KeyValuePair`2<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>>>::BeginInvoke(TKey,TValue,System.AsyncCallback,System.Object)
 Object_t * Transform_1_BeginInvoke_m122353 (Transform_1_t16388 * __this, Type_t * ___key, Object_t* ___value, AsyncCallback_t15 * ___callback, Object_t * ___object, MethodInfo* method) IL2CPP_METHOD_ATTR;
// TRet System.Collections.Generic.Dictionary`2/Transform`1<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>,System.Collections.Generic.KeyValuePair`2<System.Type,System.Collections.Generic.IList`1<PropertyMetadata>>>::EndInvoke(System.IAsyncResult)
 KeyValuePair_2_t16316  Transform_1_EndInvoke_m122354 (Transform_1_t16388 * __this, Object_t * ___result, MethodInfo* method) IL2CPP_METHOD_ATTR;