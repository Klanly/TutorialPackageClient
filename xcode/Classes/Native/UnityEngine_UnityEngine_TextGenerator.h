﻿#pragma once
#include <stdint.h>
// System.String
struct String_t;
// System.Collections.Generic.List`1<UnityEngine.UIVertex>
struct List_1_t6085;
// System.Collections.Generic.List`1<UnityEngine.UICharInfo>
struct List_1_t7487;
// System.Collections.Generic.List`1<UnityEngine.UILineInfo>
struct List_1_t7488;
// System.Object
#include "mscorlib_System_Object.h"
// System.IntPtr
#include "mscorlib_System_IntPtr.h"
// UnityEngine.TextGenerationSettings
#include "UnityEngine_UnityEngine_TextGenerationSettings.h"
// UnityEngine.TextGenerator
struct TextGenerator_t6117  : public Object_t
{
	// System.IntPtr UnityEngine.TextGenerator::m_Ptr
	IntPtr_t24 ___m_Ptr;
	// System.String UnityEngine.TextGenerator::m_LastString
	String_t* ___m_LastString;
	// UnityEngine.TextGenerationSettings UnityEngine.TextGenerator::m_LastSettings
	TextGenerationSettings_t6148  ___m_LastSettings;
	// System.Boolean UnityEngine.TextGenerator::m_HasGenerated
	bool ___m_HasGenerated;
	// System.Boolean UnityEngine.TextGenerator::m_LastValid
	bool ___m_LastValid;
	// System.Collections.Generic.List`1<UnityEngine.UIVertex> UnityEngine.TextGenerator::m_Verts
	List_1_t6085 * ___m_Verts;
	// System.Collections.Generic.List`1<UnityEngine.UICharInfo> UnityEngine.TextGenerator::m_Characters
	List_1_t7487 * ___m_Characters;
	// System.Collections.Generic.List`1<UnityEngine.UILineInfo> UnityEngine.TextGenerator::m_Lines
	List_1_t7488 * ___m_Lines;
	// System.Boolean UnityEngine.TextGenerator::m_CachedVerts
	bool ___m_CachedVerts;
	// System.Boolean UnityEngine.TextGenerator::m_CachedCharacters
	bool ___m_CachedCharacters;
	// System.Boolean UnityEngine.TextGenerator::m_CachedLines
	bool ___m_CachedLines;
};