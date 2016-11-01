﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>
struct Dictionary_2_t220;
// System.Collections.Generic.ICollection`1<System.Int32>
struct ICollection_1_t5685;
// System.Collections.Generic.ICollection`1<System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>
struct ICollection_1_t11902;
// System.Collections.ICollection
struct ICollection_t1058;
// System.Object
struct Object_t;
// System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>
struct List_1_t490;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>
struct KeyCollection_t11903;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>
struct ValueCollection_t11904;
// System.Collections.Generic.IEqualityComparer`1<System.Int32>
struct IEqualityComparer_1_t9158;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t6402;
// System.Collections.Generic.KeyValuePair`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>[]
struct KeyValuePair_2U5BU5D_t11905;
// System.Array
struct Array_t;
// System.Collections.IEnumerator
struct IEnumerator_t67;
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>>
struct IEnumerator_1_t11906;
// System.Collections.IDictionaryEnumerator
struct IDictionaryEnumerator_t1059;
// System.Runtime.Serialization.StreamingContext
#include "mscorlib_System_Runtime_Serialization_StreamingContext.h"
// System.Collections.Generic.KeyValuePair`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>
#include "mscorlib_System_Collections_Generic_KeyValuePair_2_gen_13.h"
// System.Collections.Generic.Dictionary`2/Enumerator<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>
#include "mscorlib_System_Collections_Generic_Dictionary_2_Enumerator__11.h"
// System.Collections.DictionaryEntry
#include "mscorlib_System_Collections_DictionaryEntry.h"

// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::.ctor()
 void Dictionary_2__ctor_m4645 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::.ctor(System.Collections.Generic.IEqualityComparer`1<TKey>)
 void Dictionary_2__ctor_m85339 (Dictionary_2_t220 * __this, Object_t* ___comparer, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::.ctor(System.Int32)
 void Dictionary_2__ctor_m85340 (Dictionary_2_t220 * __this, int32_t ___capacity, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
 void Dictionary_2__ctor_m85341 (Dictionary_2_t220 * __this, SerializationInfo_t6402 * ___info, StreamingContext_t6414  ___context, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.ICollection`1<TKey> System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys()
 Object_t* Dictionary_2_System_Collections_Generic_IDictionaryU3CTKeyU2CTValueU3E_get_Keys_m85342 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.ICollection`1<TValue> System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.IDictionary<TKey,TValue>.get_Values()
 Object_t* Dictionary_2_System_Collections_Generic_IDictionaryU3CTKeyU2CTValueU3E_get_Values_m85343 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.ICollection System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.get_Keys()
 Object_t * Dictionary_2_System_Collections_IDictionary_get_Keys_m85344 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.ICollection System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.get_Values()
 Object_t * Dictionary_2_System_Collections_IDictionary_get_Values_m85345 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.get_IsFixedSize()
 bool Dictionary_2_System_Collections_IDictionary_get_IsFixedSize_m85346 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.get_IsReadOnly()
 bool Dictionary_2_System_Collections_IDictionary_get_IsReadOnly_m85347 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Object System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.get_Item(System.Object)
 Object_t * Dictionary_2_System_Collections_IDictionary_get_Item_m85348 (Dictionary_2_t220 * __this, Object_t * ___key, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.set_Item(System.Object,System.Object)
 void Dictionary_2_System_Collections_IDictionary_set_Item_m85349 (Dictionary_2_t220 * __this, Object_t * ___key, Object_t * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.Add(System.Object,System.Object)
 void Dictionary_2_System_Collections_IDictionary_Add_m85350 (Dictionary_2_t220 * __this, Object_t * ___key, Object_t * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.Contains(System.Object)
 bool Dictionary_2_System_Collections_IDictionary_Contains_m85351 (Dictionary_2_t220 * __this, Object_t * ___key, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.Remove(System.Object)
 void Dictionary_2_System_Collections_IDictionary_Remove_m85352 (Dictionary_2_t220 * __this, Object_t * ___key, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.ICollection.get_IsSynchronized()
 bool Dictionary_2_System_Collections_ICollection_get_IsSynchronized_m85353 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Object System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.ICollection.get_SyncRoot()
 Object_t * Dictionary_2_System_Collections_ICollection_get_SyncRoot_m85354 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly()
 bool Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_get_IsReadOnly_m85355 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
 void Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Add_m85356 (Dictionary_2_t220 * __this, KeyValuePair_2_t5570  ___keyValuePair, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
 bool Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Contains_m85357 (Dictionary_2_t220 * __this, KeyValuePair_2_t5570  ___keyValuePair, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair`2<TKey,TValue>[],System.Int32)
 void Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_CopyTo_m85358 (Dictionary_2_t220 * __this, KeyValuePair_2U5BU5D_t11905* ___array, int32_t ___index, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
 bool Dictionary_2_System_Collections_Generic_ICollectionU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_Remove_m85359 (Dictionary_2_t220 * __this, KeyValuePair_2_t5570  ___keyValuePair, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.ICollection.CopyTo(System.Array,System.Int32)
 void Dictionary_2_System_Collections_ICollection_CopyTo_m85360 (Dictionary_2_t220 * __this, Array_t * ___array, int32_t ___index, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IEnumerable.GetEnumerator()
 Object_t * Dictionary_2_System_Collections_IEnumerable_GetEnumerator_m85361 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<TKey,TValue>> System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
 Object_t* Dictionary_2_System_Collections_Generic_IEnumerableU3CSystem_Collections_Generic_KeyValuePairU3CTKeyU2CTValueU3EU3E_GetEnumerator_m85362 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IDictionaryEnumerator System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::System.Collections.IDictionary.GetEnumerator()
 Object_t * Dictionary_2_System_Collections_IDictionary_GetEnumerator_m85363 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::get_Count()
 int32_t Dictionary_2_get_Count_m5929 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// TValue System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::get_Item(TKey)
 List_1_t490 * Dictionary_2_get_Item_m5931 (Dictionary_2_t220 * __this, int32_t ___key, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::set_Item(TKey,TValue)
 void Dictionary_2_set_Item_m85364 (Dictionary_2_t220 * __this, int32_t ___key, List_1_t490 * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::Init(System.Int32,System.Collections.Generic.IEqualityComparer`1<TKey>)
 void Dictionary_2_Init_m85365 (Dictionary_2_t220 * __this, int32_t ___capacity, Object_t* ___hcp, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::InitArrays(System.Int32)
 void Dictionary_2_InitArrays_m85366 (Dictionary_2_t220 * __this, int32_t ___size, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::CopyToCheck(System.Array,System.Int32)
 void Dictionary_2_CopyToCheck_m85367 (Dictionary_2_t220 * __this, Array_t * ___array, int32_t ___index, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::make_pair(TKey,TValue)
 KeyValuePair_2_t5570  Dictionary_2_make_pair_m85368 (Object_t * __this/* static, unused */, int32_t ___key, List_1_t490 * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// TKey System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::pick_key(TKey,TValue)
 int32_t Dictionary_2_pick_key_m85369 (Object_t * __this/* static, unused */, int32_t ___key, List_1_t490 * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// TValue System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::pick_value(TKey,TValue)
 List_1_t490 * Dictionary_2_pick_value_m85370 (Object_t * __this/* static, unused */, int32_t ___key, List_1_t490 * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::CopyTo(System.Collections.Generic.KeyValuePair`2<TKey,TValue>[],System.Int32)
 void Dictionary_2_CopyTo_m85371 (Dictionary_2_t220 * __this, KeyValuePair_2U5BU5D_t11905* ___array, int32_t ___index, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::Resize()
 void Dictionary_2_Resize_m85372 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::Add(TKey,TValue)
 void Dictionary_2_Add_m5099 (Dictionary_2_t220 * __this, int32_t ___key, List_1_t490 * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::Clear()
 void Dictionary_2_Clear_m5096 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::ContainsKey(TKey)
 bool Dictionary_2_ContainsKey_m5930 (Dictionary_2_t220 * __this, int32_t ___key, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::ContainsValue(TValue)
 bool Dictionary_2_ContainsValue_m85373 (Dictionary_2_t220 * __this, List_1_t490 * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
 void Dictionary_2_GetObjectData_m85374 (Dictionary_2_t220 * __this, SerializationInfo_t6402 * ___info, StreamingContext_t6414  ___context, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::OnDeserialization(System.Object)
 void Dictionary_2_OnDeserialization_m85375 (Dictionary_2_t220 * __this, Object_t * ___sender, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::Remove(TKey)
 bool Dictionary_2_Remove_m85376 (Dictionary_2_t220 * __this, int32_t ___key, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::TryGetValue(TKey,TValue&)
 bool Dictionary_2_TryGetValue_m85377 (Dictionary_2_t220 * __this, int32_t ___key, List_1_t490 ** ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::get_Keys()
 KeyCollection_t11903 * Dictionary_2_get_Keys_m85378 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::get_Values()
 ValueCollection_t11904 * Dictionary_2_get_Values_m85379 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// TKey System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::ToTKey(System.Object)
 int32_t Dictionary_2_ToTKey_m85380 (Dictionary_2_t220 * __this, Object_t * ___key, MethodInfo* method) IL2CPP_METHOD_ATTR;
// TValue System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::ToTValue(System.Object)
 List_1_t490 * Dictionary_2_ToTValue_m85381 (Dictionary_2_t220 * __this, Object_t * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::ContainsKeyValuePair(System.Collections.Generic.KeyValuePair`2<TKey,TValue>)
 bool Dictionary_2_ContainsKeyValuePair_m85382 (Dictionary_2_t220 * __this, KeyValuePair_2_t5570  ___pair, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.Dictionary`2/Enumerator<TKey,TValue> System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::GetEnumerator()
 Enumerator_t5569  Dictionary_2_GetEnumerator_m39379 (Dictionary_2_t220 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.DictionaryEntry System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<GCGame.Table.Tab_GuildShop>>::<CopyTo>m__0(TKey,TValue)
 DictionaryEntry_t1066  Dictionary_2_U3CCopyToU3Em__0_m85383 (Object_t * __this/* static, unused */, int32_t ___key, List_1_t490 * ___value, MethodInfo* method) IL2CPP_METHOD_ATTR;