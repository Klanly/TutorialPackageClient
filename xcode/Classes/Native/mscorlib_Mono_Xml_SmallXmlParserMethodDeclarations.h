﻿#pragma once
#include <stdint.h>
#include <assert.h>
#include <exception>
#include "codegen/il2cpp-codegen.h"

// Mono.Xml.SmallXmlParser
struct SmallXmlParser_t7830;
// System.Exception
struct Exception_t972;
// System.String
struct String_t;
// System.IO.TextReader
struct TextReader_t1019;
// Mono.Xml.SmallXmlParser/IContentHandler
struct IContentHandler_t7833;
// Mono.Xml.SmallXmlParser/AttrListImpl
struct AttrListImpl_t7832;

// System.Void Mono.Xml.SmallXmlParser::.ctor()
 void SmallXmlParser__ctor_m54027 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Exception Mono.Xml.SmallXmlParser::Error(System.String)
 Exception_t972 * SmallXmlParser_Error_m54028 (SmallXmlParser_t7830 * __this, String_t* ___msg, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Exception Mono.Xml.SmallXmlParser::UnexpectedEndError()
 Exception_t972 * SmallXmlParser_UnexpectedEndError_m54029 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean Mono.Xml.SmallXmlParser::IsNameChar(System.Char,System.Boolean)
 bool SmallXmlParser_IsNameChar_m54030 (SmallXmlParser_t7830 * __this, uint16_t ___c, bool ___start, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean Mono.Xml.SmallXmlParser::IsWhitespace(System.Int32)
 bool SmallXmlParser_IsWhitespace_m54031 (SmallXmlParser_t7830 * __this, int32_t ___c, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::SkipWhitespaces()
 void SmallXmlParser_SkipWhitespaces_m54032 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::HandleWhitespaces()
 void SmallXmlParser_HandleWhitespaces_m54033 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::SkipWhitespaces(System.Boolean)
 void SmallXmlParser_SkipWhitespaces_m54034 (SmallXmlParser_t7830 * __this, bool ___expected, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 Mono.Xml.SmallXmlParser::Peek()
 int32_t SmallXmlParser_Peek_m54035 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 Mono.Xml.SmallXmlParser::Read()
 int32_t SmallXmlParser_Read_m54036 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::Expect(System.Int32)
 void SmallXmlParser_Expect_m54037 (SmallXmlParser_t7830 * __this, int32_t ___c, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String Mono.Xml.SmallXmlParser::ReadUntil(System.Char,System.Boolean)
 String_t* SmallXmlParser_ReadUntil_m54038 (SmallXmlParser_t7830 * __this, uint16_t ___until, bool ___handleReferences, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String Mono.Xml.SmallXmlParser::ReadName()
 String_t* SmallXmlParser_ReadName_m54039 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::Parse(System.IO.TextReader,Mono.Xml.SmallXmlParser/IContentHandler)
 void SmallXmlParser_Parse_m54040 (SmallXmlParser_t7830 * __this, TextReader_t1019 * ___input, Object_t * ___handler, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::Cleanup()
 void SmallXmlParser_Cleanup_m54041 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::ReadContent()
 void SmallXmlParser_ReadContent_m54042 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::HandleBufferedContent()
 void SmallXmlParser_HandleBufferedContent_m54043 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::ReadCharacters()
 void SmallXmlParser_ReadCharacters_m54044 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::ReadReference()
 void SmallXmlParser_ReadReference_m54045 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 Mono.Xml.SmallXmlParser::ReadCharacterReference()
 int32_t SmallXmlParser_ReadCharacterReference_m54046 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::ReadAttribute(Mono.Xml.SmallXmlParser/AttrListImpl)
 void SmallXmlParser_ReadAttribute_m54047 (SmallXmlParser_t7830 * __this, AttrListImpl_t7832 * ___a, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::ReadCDATASection()
 void SmallXmlParser_ReadCDATASection_m54048 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Mono.Xml.SmallXmlParser::ReadComment()
 void SmallXmlParser_ReadComment_m54049 (SmallXmlParser_t7830 * __this, MethodInfo* method) IL2CPP_METHOD_ATTR;