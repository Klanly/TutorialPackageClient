﻿#pragma once
#include <stdint.h>
// System.Int32[]
struct Int32U5BU5D_t116;
// System.Collections.Generic.Link[]
struct LinkU5BU5D_t8437;
// Games.AwardActivity.JoinNumRewardData[]
struct JoinNumRewardDataU5BU5D_t19453;
// System.Collections.Generic.IEqualityComparer`1<System.Int32>
struct IEqualityComparer_1_t9158;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t6402;
// System.Collections.Generic.Dictionary`2/Transform`1<System.Int32,Games.AwardActivity.JoinNumRewardData,System.Collections.DictionaryEntry>
struct Transform_1_t19454;
// System.Object
#include "mscorlib_System_Object.h"
// System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>
struct Dictionary_2_t4954  : public Object_t
{
	// System.Int32[] System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::table
	Int32U5BU5D_t116* ___table;
	// System.Collections.Generic.Link[] System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::linkSlots
	LinkU5BU5D_t8437* ___linkSlots;
	// TKey[] System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::keySlots
	Int32U5BU5D_t116* ___keySlots;
	// TValue[] System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::valueSlots
	JoinNumRewardDataU5BU5D_t19453* ___valueSlots;
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::touchedSlots
	int32_t ___touchedSlots;
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::emptySlot
	int32_t ___emptySlot;
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::count
	int32_t ___count;
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::threshold
	int32_t ___threshold;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::hcp
	Object_t* ___hcp;
	// System.Runtime.Serialization.SerializationInfo System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::serialization_info
	SerializationInfo_t6402 * ___serialization_info;
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::generation
	int32_t ___generation;
};
struct Dictionary_2_t4954_StaticFields{
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::INITIAL_SIZE
	int32_t ___INITIAL_SIZE;
	// System.Single System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::DEFAULT_LOAD_FACTOR
	float ___DEFAULT_LOAD_FACTOR;
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::NO_SLOT
	int32_t ___NO_SLOT;
	// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::HASH_FLAG
	int32_t ___HASH_FLAG;
	// System.Collections.Generic.Dictionary`2/Transform`1<TKey,TValue,System.Collections.DictionaryEntry> System.Collections.Generic.Dictionary`2<System.Int32,Games.AwardActivity.JoinNumRewardData>::<>f__am$cacheB
	Transform_1_t19454 * ___U3CU3Ef__am$cacheB;
};