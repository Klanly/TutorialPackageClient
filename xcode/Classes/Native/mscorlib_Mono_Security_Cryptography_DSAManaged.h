﻿#pragma once
#include <stdint.h>
// Mono.Math.BigInteger
struct BigInteger_t7791;
// System.Security.Cryptography.RandomNumberGenerator
struct RandomNumberGenerator_t6455;
// Mono.Security.Cryptography.DSAManaged/KeyGeneratedEventHandler
struct KeyGeneratedEventHandler_t7802;
// System.Security.Cryptography.DSA
#include "mscorlib_System_Security_Cryptography_DSA.h"
// Mono.Security.Cryptography.DSAManaged
struct DSAManaged_t7803  : public DSA_t6478
{
	// System.Boolean Mono.Security.Cryptography.DSAManaged::keypairGenerated
	bool ___keypairGenerated;
	// System.Boolean Mono.Security.Cryptography.DSAManaged::m_disposed
	bool ___m_disposed;
	// Mono.Math.BigInteger Mono.Security.Cryptography.DSAManaged::p
	BigInteger_t7791 * ___p;
	// Mono.Math.BigInteger Mono.Security.Cryptography.DSAManaged::q
	BigInteger_t7791 * ___q;
	// Mono.Math.BigInteger Mono.Security.Cryptography.DSAManaged::g
	BigInteger_t7791 * ___g;
	// Mono.Math.BigInteger Mono.Security.Cryptography.DSAManaged::x
	BigInteger_t7791 * ___x;
	// Mono.Math.BigInteger Mono.Security.Cryptography.DSAManaged::y
	BigInteger_t7791 * ___y;
	// Mono.Math.BigInteger Mono.Security.Cryptography.DSAManaged::j
	BigInteger_t7791 * ___j;
	// Mono.Math.BigInteger Mono.Security.Cryptography.DSAManaged::seed
	BigInteger_t7791 * ___seed;
	// System.Int32 Mono.Security.Cryptography.DSAManaged::counter
	int32_t ___counter;
	// System.Boolean Mono.Security.Cryptography.DSAManaged::j_missing
	bool ___j_missing;
	// System.Security.Cryptography.RandomNumberGenerator Mono.Security.Cryptography.DSAManaged::rng
	RandomNumberGenerator_t6455 * ___rng;
	// Mono.Security.Cryptography.DSAManaged/KeyGeneratedEventHandler Mono.Security.Cryptography.DSAManaged::KeyGenerated
	KeyGeneratedEventHandler_t7802 * ___KeyGenerated;
};