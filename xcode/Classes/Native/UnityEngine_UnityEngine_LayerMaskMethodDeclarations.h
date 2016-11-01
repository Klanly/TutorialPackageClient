﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// UnityEngine.LayerMask
struct LayerMask_t39;
// System.String
struct String_t;
// System.String[]
struct StringU5BU5D_t333;
// UnityEngine.LayerMask
#include "UnityEngine_UnityEngine_LayerMask.h"

// System.Int32 UnityEngine.LayerMask::get_value()
 int32_t LayerMask_get_value_m40857 (LayerMask_t39 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.LayerMask::set_value(System.Int32)
 void LayerMask_set_value_m51992 (LayerMask_t39 * __this, int32_t ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.LayerMask::LayerToName(System.Int32)
 String_t* LayerMask_LayerToName_m51993 (Object_t * __this/* static, unused */, int32_t ___layer, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.LayerMask::NameToLayer(System.String)
 int32_t LayerMask_NameToLayer_m6594 (Object_t * __this/* static, unused */, String_t* ___layerName, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.LayerMask::GetMask(System.String[])
 int32_t LayerMask_GetMask_m51994 (Object_t * __this/* static, unused */, StringU5BU5D_t333* ___layerNames, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.LayerMask::op_Implicit(UnityEngine.LayerMask)
 int32_t LayerMask_op_Implicit_m4175 (Object_t * __this/* static, unused */, LayerMask_t39  ___mask, MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.LayerMask UnityEngine.LayerMask::op_Implicit(System.Int32)
 LayerMask_t39  LayerMask_op_Implicit_m41464 (Object_t * __this/* static, unused */, int32_t ___intVal, MethodInfo* method) IL2CPP_METHOD_ATTR;