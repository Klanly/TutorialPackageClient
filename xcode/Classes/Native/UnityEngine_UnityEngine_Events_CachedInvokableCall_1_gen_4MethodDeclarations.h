﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// UnityEngine.Events.CachedInvokableCall`1<System.Object>
struct CachedInvokableCall_1_t8591;
// UnityEngine.Object
struct Object_t982;
struct Object_t982_marshaled;
// System.Reflection.MethodInfo
struct MethodInfo_t1087;
// System.Object
struct Object_t;
// System.Object[]
struct ObjectU5BU5D_t142;

// System.Void UnityEngine.Events.CachedInvokableCall`1<System.Object>::.ctor(UnityEngine.Object,System.Reflection.MethodInfo,T)
 void CachedInvokableCall_1__ctor_m57862_gshared (CachedInvokableCall_1_t8591 * __this, Object_t982 * ___target, MethodInfo_t1087 * ___theFunction, Object_t * ___argument, MethodInfo* method);
#define CachedInvokableCall_1__ctor_m57862(__this, ___target, ___theFunction, ___argument, method) (void)CachedInvokableCall_1__ctor_m57862_gshared((CachedInvokableCall_1_t8591 *)__this, (Object_t982 *)___target, (MethodInfo_t1087 *)___theFunction, (Object_t *)___argument, method)
// System.Void UnityEngine.Events.CachedInvokableCall`1<System.Object>::Invoke(System.Object[])
 void CachedInvokableCall_1_Invoke_m57864_gshared (CachedInvokableCall_1_t8591 * __this, ObjectU5BU5D_t142* ___args, MethodInfo* method);
#define CachedInvokableCall_1_Invoke_m57864(__this, ___args, method) (void)CachedInvokableCall_1_Invoke_m57864_gshared((CachedInvokableCall_1_t8591 *)__this, (ObjectU5BU5D_t142*)___args, method)