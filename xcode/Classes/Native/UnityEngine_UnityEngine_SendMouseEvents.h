﻿#pragma once
#include <stdint.h>
// UnityEngine.SendMouseEvents/HitInfo[]
struct HitInfoU5BU5D_t7476;
// UnityEngine.RaycastHit2D[]
struct RaycastHit2DU5BU5D_t6211;
// UnityEngine.Camera[]
struct CameraU5BU5D_t37;
// System.Object
#include "mscorlib_System_Object.h"
// UnityEngine.SendMouseEvents
struct SendMouseEvents_t7477  : public Object_t
{
};
struct SendMouseEvents_t7477_StaticFields{
	// System.Int32 UnityEngine.SendMouseEvents::m_HitIndexGUI
	int32_t ___m_HitIndexGUI;
	// System.Int32 UnityEngine.SendMouseEvents::m_HitIndexPhysics3D
	int32_t ___m_HitIndexPhysics3D;
	// System.Int32 UnityEngine.SendMouseEvents::m_HitIndexPhysics2D
	int32_t ___m_HitIndexPhysics2D;
	// UnityEngine.SendMouseEvents/HitInfo[] UnityEngine.SendMouseEvents::m_LastHit
	HitInfoU5BU5D_t7476* ___m_LastHit;
	// UnityEngine.SendMouseEvents/HitInfo[] UnityEngine.SendMouseEvents::m_MouseDownHit
	HitInfoU5BU5D_t7476* ___m_MouseDownHit;
	// UnityEngine.SendMouseEvents/HitInfo[] UnityEngine.SendMouseEvents::m_CurrentHit
	HitInfoU5BU5D_t7476* ___m_CurrentHit;
	// UnityEngine.RaycastHit2D[] UnityEngine.SendMouseEvents::m_MouseRayHits2D
	RaycastHit2DU5BU5D_t6211* ___m_MouseRayHits2D;
	// UnityEngine.Camera[] UnityEngine.SendMouseEvents::m_Cameras
	CameraU5BU5D_t37* ___m_Cameras;
};