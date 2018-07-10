#pragma once
#include "stdafx.h"
#include "DllRegisterMode.hpp"

using namespace NetOffice_ShimLoader;

namespace NetOffice_ShimLoader_Register32
{
	//
	// Register Shim as 32 Bit Build on a 32 Bit System
	//
	HRESULT DllRegister(HINSTANCE module, LPCWSTR officeApplications[], DWORD addinLoadBehavior, DWORD addinCommandLineSafe, LPCWSTR progId, LPCWSTR classId, LPCWSTR friendlyName, LPCWSTR description, LPCWSTR version, RegisterMode mode);

	//
	// Unregister Shim as 32 Bit Build on a 32 Bit System
	//
	HRESULT DllUnregister(LPCWSTR officeApplications[], LPCWSTR progId, LPCWSTR classId, LPCWSTR version, RegisterMode mode);
}