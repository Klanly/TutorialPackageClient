//This code create by CodeEngine mrd.cyou.com ,don't modify

using System;
 using scg = global::System.Collections.Generic;
 using pb = global::Google.ProtocolBuffers;
 using pbc = global::Google.ProtocolBuffers.Collections;
 #pragma warning disable



[Serializable]
public class CG_LOGIN : PacketDistributed
{
public enum VALIDATETYPE 
 { 
  TEST = 0,                 //���Ե�¼ģʽ 
  CYOU = 1,                 //�ۺ�SDK��½ģʽ 
 }
public const int vtypeFieldNumber = 1;
 private bool hasVtype;
 private Int32 vtype_ = 0;
 public bool HasVtype {
 get { return hasVtype; }
 }
 public Int32 Vtype {
 get { return vtype_; }
 set { SetVtype(value); }
 }
 public void SetVtype(Int32 value) { 
 hasVtype = true;
 vtype_ = value;
 }

public const int gameversionFieldNumber = 2;
 private bool hasGameversion;
 private Int32 gameversion_ = 0;
 public bool HasGameversion {
 get { return hasGameversion; }
 }
 public Int32 Gameversion {
 get { return gameversion_; }
 set { SetGameversion(value); }
 }
 public void SetGameversion(Int32 value) { 
 hasGameversion = true;
 gameversion_ = value;
 }

public const int programversionFieldNumber = 3;
 private bool hasProgramversion;
 private Int32 programversion_ = 0;
 public bool HasProgramversion {
 get { return hasProgramversion; }
 }
 public Int32 Programversion {
 get { return programversion_; }
 set { SetProgramversion(value); }
 }
 public void SetProgramversion(Int32 value) { 
 hasProgramversion = true;
 programversion_ = value;
 }

public const int publicresourceversionFieldNumber = 4;
 private bool hasPublicresourceversion;
 private Int32 publicresourceversion_ = 0;
 public bool HasPublicresourceversion {
 get { return hasPublicresourceversion; }
 }
 public Int32 Publicresourceversion {
 get { return publicresourceversion_; }
 set { SetPublicresourceversion(value); }
 }
 public void SetPublicresourceversion(Int32 value) { 
 hasPublicresourceversion = true;
 publicresourceversion_ = value;
 }

public const int maxpacketidFieldNumber = 5;
 private bool hasMaxpacketid;
 private Int32 maxpacketid_ = 0;
 public bool HasMaxpacketid {
 get { return hasMaxpacketid; }
 }
 public Int32 Maxpacketid {
 get { return maxpacketid_; }
 set { SetMaxpacketid(value); }
 }
 public void SetMaxpacketid(Int32 value) { 
 hasMaxpacketid = true;
 maxpacketid_ = value;
 }

public const int forceenterFieldNumber = 6;
 private bool hasForceenter;
 private Int32 forceenter_ = 0;
 public bool HasForceenter {
 get { return hasForceenter; }
 }
 public Int32 Forceenter {
 get { return forceenter_; }
 set { SetForceenter(value); }
 }
 public void SetForceenter(Int32 value) { 
 hasForceenter = true;
 forceenter_ = value;
 }

public const int deviceidFieldNumber = 7;
 private bool hasDeviceid;
 private string deviceid_ = "";
 public bool HasDeviceid {
 get { return hasDeviceid; }
 }
 public string Deviceid {
 get { return deviceid_; }
 set { SetDeviceid(value); }
 }
 public void SetDeviceid(string value) { 
 hasDeviceid = true;
 deviceid_ = value;
 }

public const int devicetypeFieldNumber = 8;
 private bool hasDevicetype;
 private string devicetype_ = "";
 public bool HasDevicetype {
 get { return hasDevicetype; }
 }
 public string Devicetype {
 get { return devicetype_; }
 set { SetDevicetype(value); }
 }
 public void SetDevicetype(string value) { 
 hasDevicetype = true;
 devicetype_ = value;
 }

public const int deviceversionFieldNumber = 9;
 private bool hasDeviceversion;
 private string deviceversion_ = "";
 public bool HasDeviceversion {
 get { return hasDeviceversion; }
 }
 public string Deviceversion {
 get { return deviceversion_; }
 set { SetDeviceversion(value); }
 }
 public void SetDeviceversion(string value) { 
 hasDeviceversion = true;
 deviceversion_ = value;
 }

public const int accountFieldNumber = 10;
 private bool hasAccount;
 private string account_ = "";
 public bool HasAccount {
 get { return hasAccount; }
 }
 public string Account {
 get { return account_; }
 set { SetAccount(value); }
 }
 public void SetAccount(string value) { 
 hasAccount = true;
 account_ = value;
 }

public const int validateinfoFieldNumber = 11;
 private bool hasValidateinfo;
 private string validateinfo_ = "";
 public bool HasValidateinfo {
 get { return hasValidateinfo; }
 }
 public string Validateinfo {
 get { return validateinfo_; }
 set { SetValidateinfo(value); }
 }
 public void SetValidateinfo(string value) { 
 hasValidateinfo = true;
 validateinfo_ = value;
 }

public const int channelidFieldNumber = 12;
 private bool hasChannelid;
 private string channelid_ = "";
 public bool HasChannelid {
 get { return hasChannelid; }
 }
 public string Channelid {
 get { return channelid_; }
 set { SetChannelid(value); }
 }
 public void SetChannelid(string value) { 
 hasChannelid = true;
 channelid_ = value;
 }

public const int mediachannelFieldNumber = 13;
 private bool hasMediachannel;
 private string mediachannel_ = "";
 public bool HasMediachannel {
 get { return hasMediachannel; }
 }
 public string Mediachannel {
 get { return mediachannel_; }
 set { SetMediachannel(value); }
 }
 public void SetMediachannel(string value) { 
 hasMediachannel = true;
 mediachannel_ = value;
 }

public const int rapidvalidatecodeFieldNumber = 14;
 private bool hasRapidvalidatecode;
 private Int32 rapidvalidatecode_ = 0;
 public bool HasRapidvalidatecode {
 get { return hasRapidvalidatecode; }
 }
 public Int32 Rapidvalidatecode {
 get { return rapidvalidatecode_; }
 set { SetRapidvalidatecode(value); }
 }
 public void SetRapidvalidatecode(Int32 value) { 
 hasRapidvalidatecode = true;
 rapidvalidatecode_ = value;
 }

public const int reservedint1FieldNumber = 15;
 private bool hasReservedint1;
 private Int32 reservedint1_ = 0;
 public bool HasReservedint1 {
 get { return hasReservedint1; }
 }
 public Int32 Reservedint1 {
 get { return reservedint1_; }
 set { SetReservedint1(value); }
 }
 public void SetReservedint1(Int32 value) { 
 hasReservedint1 = true;
 reservedint1_ = value;
 }

public const int reservedint2FieldNumber = 16;
 private bool hasReservedint2;
 private Int32 reservedint2_ = 0;
 public bool HasReservedint2 {
 get { return hasReservedint2; }
 }
 public Int32 Reservedint2 {
 get { return reservedint2_; }
 set { SetReservedint2(value); }
 }
 public void SetReservedint2(Int32 value) { 
 hasReservedint2 = true;
 reservedint2_ = value;
 }

public const int reservedint3FieldNumber = 17;
 private bool hasReservedint3;
 private Int32 reservedint3_ = 0;
 public bool HasReservedint3 {
 get { return hasReservedint3; }
 }
 public Int32 Reservedint3 {
 get { return reservedint3_; }
 set { SetReservedint3(value); }
 }
 public void SetReservedint3(Int32 value) { 
 hasReservedint3 = true;
 reservedint3_ = value;
 }

public const int reservedint4FieldNumber = 18;
 private bool hasReservedint4;
 private Int32 reservedint4_ = 0;
 public bool HasReservedint4 {
 get { return hasReservedint4; }
 }
 public Int32 Reservedint4 {
 get { return reservedint4_; }
 set { SetReservedint4(value); }
 }
 public void SetReservedint4(Int32 value) { 
 hasReservedint4 = true;
 reservedint4_ = value;
 }

public const int reservedstring1FieldNumber = 19;
 private bool hasReservedstring1;
 private string reservedstring1_ = "";
 public bool HasReservedstring1 {
 get { return hasReservedstring1; }
 }
 public string Reservedstring1 {
 get { return reservedstring1_; }
 set { SetReservedstring1(value); }
 }
 public void SetReservedstring1(string value) { 
 hasReservedstring1 = true;
 reservedstring1_ = value;
 }

public const int reservedstring2FieldNumber = 20;
 private bool hasReservedstring2;
 private string reservedstring2_ = "";
 public bool HasReservedstring2 {
 get { return hasReservedstring2; }
 }
 public string Reservedstring2 {
 get { return reservedstring2_; }
 set { SetReservedstring2(value); }
 }
 public void SetReservedstring2(string value) { 
 hasReservedstring2 = true;
 reservedstring2_ = value;
 }

public const int reservedstring3FieldNumber = 21;
 private bool hasReservedstring3;
 private string reservedstring3_ = "";
 public bool HasReservedstring3 {
 get { return hasReservedstring3; }
 }
 public string Reservedstring3 {
 get { return reservedstring3_; }
 set { SetReservedstring3(value); }
 }
 public void SetReservedstring3(string value) { 
 hasReservedstring3 = true;
 reservedstring3_ = value;
 }

public const int reservedstring4FieldNumber = 22;
 private bool hasReservedstring4;
 private string reservedstring4_ = "";
 public bool HasReservedstring4 {
 get { return hasReservedstring4; }
 }
 public string Reservedstring4 {
 get { return reservedstring4_; }
 set { SetReservedstring4(value); }
 }
 public void SetReservedstring4(string value) { 
 hasReservedstring4 = true;
 reservedstring4_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasVtype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Vtype);
}
 if (HasGameversion) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Gameversion);
}
 if (HasProgramversion) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Programversion);
}
 if (HasPublicresourceversion) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Publicresourceversion);
}
 if (HasMaxpacketid) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Maxpacketid);
}
 if (HasForceenter) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Forceenter);
}
 if (HasDeviceid) {
size += pb::CodedOutputStream.ComputeStringSize(7, Deviceid);
}
 if (HasDevicetype) {
size += pb::CodedOutputStream.ComputeStringSize(8, Devicetype);
}
 if (HasDeviceversion) {
size += pb::CodedOutputStream.ComputeStringSize(9, Deviceversion);
}
 if (HasAccount) {
size += pb::CodedOutputStream.ComputeStringSize(10, Account);
}
 if (HasValidateinfo) {
size += pb::CodedOutputStream.ComputeStringSize(11, Validateinfo);
}
 if (HasChannelid) {
size += pb::CodedOutputStream.ComputeStringSize(12, Channelid);
}
 if (HasMediachannel) {
size += pb::CodedOutputStream.ComputeStringSize(13, Mediachannel);
}
 if (HasRapidvalidatecode) {
size += pb::CodedOutputStream.ComputeInt32Size(14, Rapidvalidatecode);
}
 if (HasReservedint1) {
size += pb::CodedOutputStream.ComputeInt32Size(15, Reservedint1);
}
 if (HasReservedint2) {
size += pb::CodedOutputStream.ComputeInt32Size(16, Reservedint2);
}
 if (HasReservedint3) {
size += pb::CodedOutputStream.ComputeInt32Size(17, Reservedint3);
}
 if (HasReservedint4) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Reservedint4);
}
 if (HasReservedstring1) {
size += pb::CodedOutputStream.ComputeStringSize(19, Reservedstring1);
}
 if (HasReservedstring2) {
size += pb::CodedOutputStream.ComputeStringSize(20, Reservedstring2);
}
 if (HasReservedstring3) {
size += pb::CodedOutputStream.ComputeStringSize(21, Reservedstring3);
}
 if (HasReservedstring4) {
size += pb::CodedOutputStream.ComputeStringSize(22, Reservedstring4);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasVtype) {
output.WriteInt32(1, Vtype);
}
 
if (HasGameversion) {
output.WriteInt32(2, Gameversion);
}
 
if (HasProgramversion) {
output.WriteInt32(3, Programversion);
}
 
if (HasPublicresourceversion) {
output.WriteInt32(4, Publicresourceversion);
}
 
if (HasMaxpacketid) {
output.WriteInt32(5, Maxpacketid);
}
 
if (HasForceenter) {
output.WriteInt32(6, Forceenter);
}
 
if (HasDeviceid) {
output.WriteString(7, Deviceid);
}
 
if (HasDevicetype) {
output.WriteString(8, Devicetype);
}
 
if (HasDeviceversion) {
output.WriteString(9, Deviceversion);
}
 
if (HasAccount) {
output.WriteString(10, Account);
}
 
if (HasValidateinfo) {
output.WriteString(11, Validateinfo);
}
 
if (HasChannelid) {
output.WriteString(12, Channelid);
}
 
if (HasMediachannel) {
output.WriteString(13, Mediachannel);
}
 
if (HasRapidvalidatecode) {
output.WriteInt32(14, Rapidvalidatecode);
}
 
if (HasReservedint1) {
output.WriteInt32(15, Reservedint1);
}
 
if (HasReservedint2) {
output.WriteInt32(16, Reservedint2);
}
 
if (HasReservedint3) {
output.WriteInt32(17, Reservedint3);
}
 
if (HasReservedint4) {
output.WriteInt32(18, Reservedint4);
}
 
if (HasReservedstring1) {
output.WriteString(19, Reservedstring1);
}
 
if (HasReservedstring2) {
output.WriteString(20, Reservedstring2);
}
 
if (HasReservedstring3) {
output.WriteString(21, Reservedstring3);
}
 
if (HasReservedstring4) {
output.WriteString(22, Reservedstring4);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_LOGIN _inst = (CG_LOGIN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Vtype = input.ReadInt32();
break;
}
   case  16: {
 _inst.Gameversion = input.ReadInt32();
break;
}
   case  24: {
 _inst.Programversion = input.ReadInt32();
break;
}
   case  32: {
 _inst.Publicresourceversion = input.ReadInt32();
break;
}
   case  40: {
 _inst.Maxpacketid = input.ReadInt32();
break;
}
   case  48: {
 _inst.Forceenter = input.ReadInt32();
break;
}
   case  58: {
 _inst.Deviceid = input.ReadString();
break;
}
   case  66: {
 _inst.Devicetype = input.ReadString();
break;
}
   case  74: {
 _inst.Deviceversion = input.ReadString();
break;
}
   case  82: {
 _inst.Account = input.ReadString();
break;
}
   case  90: {
 _inst.Validateinfo = input.ReadString();
break;
}
   case  98: {
 _inst.Channelid = input.ReadString();
break;
}
   case  106: {
 _inst.Mediachannel = input.ReadString();
break;
}
   case  112: {
 _inst.Rapidvalidatecode = input.ReadInt32();
break;
}
   case  120: {
 _inst.Reservedint1 = input.ReadInt32();
break;
}
   case  128: {
 _inst.Reservedint2 = input.ReadInt32();
break;
}
   case  136: {
 _inst.Reservedint3 = input.ReadInt32();
break;
}
   case  144: {
 _inst.Reservedint4 = input.ReadInt32();
break;
}
   case  154: {
 _inst.Reservedstring1 = input.ReadString();
break;
}
   case  162: {
 _inst.Reservedstring2 = input.ReadString();
break;
}
   case  170: {
 _inst.Reservedstring3 = input.ReadString();
break;
}
   case  178: {
 _inst.Reservedstring4 = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasVtype) return false;
 if (!hasGameversion) return false;
 if (!hasProgramversion) return false;
 if (!hasPublicresourceversion) return false;
 if (!hasMaxpacketid) return false;
 if (!hasForceenter) return false;
 if (!hasDeviceid) return false;
 if (!hasDevicetype) return false;
 if (!hasDeviceversion) return false;
 if (!hasAccount) return false;
 if (!hasValidateinfo) return false;
 if (!hasChannelid) return false;
 if (!hasMediachannel) return false;
 if (!hasRapidvalidatecode) return false;
 if (!hasReservedint1) return false;
 if (!hasReservedint2) return false;
 if (!hasReservedint3) return false;
 if (!hasReservedint4) return false;
 if (!hasReservedstring1) return false;
 if (!hasReservedstring2) return false;
 if (!hasReservedstring3) return false;
 if (!hasReservedstring4) return false;
 return true;
 }

}


[Serializable]
public class GC_LOGIN_RET : PacketDistributed
{
public enum LOGINRESULT 
 { 
  SUCCESS      = 1, 
  ACCOUNTVERIFYFAIL = 2, 
  READROLELISTFAIL = 3, 
  ALREADYLOGIN  = 4, 
  QUEUEFULL  = 5, 
  NEEDFORCEENTER = 6, 
  PACKETNOTMATCH = 7, 
  VERSIONNOTMATCH = 8, 
 }public enum VALIDATERESULT 
 { 
  OK           = 0, 
  FAIL_VALIDATETYPEERROR = 1, 
  FAIL_PERFORM      = 2, 
  FAIL_OPCODE       = 3, 
  FAIL_TAG        = 4, 
  FAIL_STATE       = 5, 
  FAIL_DATA_STATUS    = 6, 
  FAIL_CHANNELID     = 7, 
 }
public const int resultFieldNumber = 1;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

public const int validateresultFieldNumber = 2;
 private bool hasValidateresult;
 private Int32 validateresult_ = 0;
 public bool HasValidateresult {
 get { return hasValidateresult; }
 }
 public Int32 Validateresult {
 get { return validateresult_; }
 set { SetValidateresult(value); }
 }
 public void SetValidateresult(Int32 value) { 
 hasValidateresult = true;
 validateresult_ = value;
 }

public const int useridFieldNumber = 3;
 private bool hasUserid;
 private string userid_ = "";
 public bool HasUserid {
 get { return hasUserid; }
 }
 public string Userid {
 get { return userid_; }
 set { SetUserid(value); }
 }
 public void SetUserid(string value) { 
 hasUserid = true;
 userid_ = value;
 }

public const int oidFieldNumber = 4;
 private bool hasOid;
 private string oid_ = "";
 public bool HasOid {
 get { return hasOid; }
 }
 public string Oid {
 get { return oid_; }
 set { SetOid(value); }
 }
 public void SetOid(string value) { 
 hasOid = true;
 oid_ = value;
 }

public const int accesstokenFieldNumber = 5;
 private bool hasAccesstoken;
 private string accesstoken_ = "";
 public bool HasAccesstoken {
 get { return hasAccesstoken; }
 }
 public string Accesstoken {
 get { return accesstoken_; }
 set { SetAccesstoken(value); }
 }
 public void SetAccesstoken(string value) { 
 hasAccesstoken = true;
 accesstoken_ = value;
 }

public const int rapidvalidatecodeFieldNumber = 6;
 private bool hasRapidvalidatecode;
 private Int32 rapidvalidatecode_ = 0;
 public bool HasRapidvalidatecode {
 get { return hasRapidvalidatecode; }
 }
 public Int32 Rapidvalidatecode {
 get { return rapidvalidatecode_; }
 set { SetRapidvalidatecode(value); }
 }
 public void SetRapidvalidatecode(Int32 value) { 
 hasRapidvalidatecode = true;
 rapidvalidatecode_ = value;
 }

public const int roleGUIDListFieldNumber = 7;
 private pbc::PopsicleList<UInt64> roleGUIDList_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> roleGUIDListList {
 get { return pbc::Lists.AsReadOnly(roleGUIDList_); }
 }
 
 public int roleGUIDListCount {
 get { return roleGUIDList_.Count; }
 }
 
public UInt64 GetRoleGUIDList(int index) {
 return roleGUIDList_[index];
 }
 public void AddRoleGUIDList(UInt64 value) {
 roleGUIDList_.Add(value);
 }

public const int roleTypeListFieldNumber = 8;
 private pbc::PopsicleList<Int32> roleTypeList_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> roleTypeListList {
 get { return pbc::Lists.AsReadOnly(roleTypeList_); }
 }
 
 public int roleTypeListCount {
 get { return roleTypeList_.Count; }
 }
 
public Int32 GetRoleTypeList(int index) {
 return roleTypeList_[index];
 }
 public void AddRoleTypeList(Int32 value) {
 roleTypeList_.Add(value);
 }

public const int playerNameListFieldNumber = 9;
 private pbc::PopsicleList<string> playerNameList_ = new pbc::PopsicleList<string>();
 public scg::IList<string> playerNameListList {
 get { return pbc::Lists.AsReadOnly(playerNameList_); }
 }
 
 public int playerNameListCount {
 get { return playerNameList_.Count; }
 }
 
public string GetPlayerNameList(int index) {
 return playerNameList_[index];
 }
 public void AddPlayerNameList(string value) {
 playerNameList_.Add(value);
 }

public const int roleLevelListFieldNumber = 10;
 private pbc::PopsicleList<Int32> roleLevelList_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> roleLevelListList {
 get { return pbc::Lists.AsReadOnly(roleLevelList_); }
 }
 
 public int roleLevelListCount {
 get { return roleLevelList_.Count; }
 }
 
public Int32 GetRoleLevelList(int index) {
 return roleLevelList_[index];
 }
 public void AddRoleLevelList(Int32 value) {
 roleLevelList_.Add(value);
 }

public const int ModelVisualIDFieldNumber = 11;
 private pbc::PopsicleList<Int32> ModelVisualID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ModelVisualIDList {
 get { return pbc::Lists.AsReadOnly(ModelVisualID_); }
 }
 
 public int ModelVisualIDCount {
 get { return ModelVisualID_.Count; }
 }
 
public Int32 GetModelVisualID(int index) {
 return ModelVisualID_[index];
 }
 public void AddModelVisualID(Int32 value) {
 ModelVisualID_.Add(value);
 }

public const int WeaponIDFieldNumber = 12;
 private pbc::PopsicleList<Int32> WeaponID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> WeaponIDList {
 get { return pbc::Lists.AsReadOnly(WeaponID_); }
 }
 
 public int WeaponIDCount {
 get { return WeaponID_.Count; }
 }
 
public Int32 GetWeaponID(int index) {
 return WeaponID_[index];
 }
 public void AddWeaponID(Int32 value) {
 WeaponID_.Add(value);
 }

public const int WeaponEffectGemFieldNumber = 13;
 private pbc::PopsicleList<Int32> WeaponEffectGem_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> WeaponEffectGemList {
 get { return pbc::Lists.AsReadOnly(WeaponEffectGem_); }
 }
 
 public int WeaponEffectGemCount {
 get { return WeaponEffectGem_.Count; }
 }
 
public Int32 GetWeaponEffectGem(int index) {
 return WeaponEffectGem_[index];
 }
 public void AddWeaponEffectGem(Int32 value) {
 WeaponEffectGem_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 if (HasValidateresult) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Validateresult);
}
 if (HasUserid) {
size += pb::CodedOutputStream.ComputeStringSize(3, Userid);
}
 if (HasOid) {
size += pb::CodedOutputStream.ComputeStringSize(4, Oid);
}
 if (HasAccesstoken) {
size += pb::CodedOutputStream.ComputeStringSize(5, Accesstoken);
}
 if (HasRapidvalidatecode) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Rapidvalidatecode);
}
{
int dataSize = 0;
for(int i=0; i<roleGUIDListList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(roleGUIDListList[i]);
}
size += dataSize;
size += 1 * roleGUIDList_.Count;
}
{
int dataSize = 0;
for(int i=0; i<roleTypeListList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(roleTypeListList[i]);
}
size += dataSize;
size += 1 * roleTypeList_.Count;
}
{
int dataSize = 0;
for(int i=0; i<playerNameListList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(playerNameListList[i]);
}
size += dataSize;
size += 1 * playerNameList_.Count;
}
{
int dataSize = 0;
for(int i=0; i<roleLevelListList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(roleLevelListList[i]);
}
size += dataSize;
size += 1 * roleLevelList_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ModelVisualIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ModelVisualIDList[i]);
}
size += dataSize;
size += 1 * ModelVisualID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<WeaponIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(WeaponIDList[i]);
}
size += dataSize;
size += 1 * WeaponID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<WeaponEffectGemList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(WeaponEffectGemList[i]);
}
size += dataSize;
size += 1 * WeaponEffectGem_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 
if (HasValidateresult) {
output.WriteInt32(2, Validateresult);
}
 
if (HasUserid) {
output.WriteString(3, Userid);
}
 
if (HasOid) {
output.WriteString(4, Oid);
}
 
if (HasAccesstoken) {
output.WriteString(5, Accesstoken);
}
 
if (HasRapidvalidatecode) {
output.WriteInt32(6, Rapidvalidatecode);
}
{
if (roleGUIDList_.Count > 0) {
for(int i=0; i<roleGUIDList_.Count; ++i){
output.WriteUInt64(7,roleGUIDList_[i]);
}
}

}
{
if (roleTypeList_.Count > 0) {
for(int i=0; i<roleTypeList_.Count; ++i){
output.WriteInt32(8,roleTypeList_[i]);
}
}

}
{
if (playerNameList_.Count > 0) {
for(int i=0; i<playerNameList_.Count; ++i){
output.WriteString(9,playerNameList_[i]);
}
}

}
{
if (roleLevelList_.Count > 0) {
for(int i=0; i<roleLevelList_.Count; ++i){
output.WriteInt32(10,roleLevelList_[i]);
}
}

}
{
if (ModelVisualID_.Count > 0) {
for(int i=0; i<ModelVisualID_.Count; ++i){
output.WriteInt32(11,ModelVisualID_[i]);
}
}

}
{
if (WeaponID_.Count > 0) {
for(int i=0; i<WeaponID_.Count; ++i){
output.WriteInt32(12,WeaponID_[i]);
}
}

}
{
if (WeaponEffectGem_.Count > 0) {
for(int i=0; i<WeaponEffectGem_.Count; ++i){
output.WriteInt32(13,WeaponEffectGem_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_LOGIN_RET _inst = (GC_LOGIN_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.Validateresult = input.ReadInt32();
break;
}
   case  26: {
 _inst.Userid = input.ReadString();
break;
}
   case  34: {
 _inst.Oid = input.ReadString();
break;
}
   case  42: {
 _inst.Accesstoken = input.ReadString();
break;
}
   case  48: {
 _inst.Rapidvalidatecode = input.ReadInt32();
break;
}
   case  56: {
 _inst.AddRoleGUIDList(input.ReadUInt64());
break;
}
   case  64: {
 _inst.AddRoleTypeList(input.ReadInt32());
break;
}
   case  74: {
 _inst.AddPlayerNameList(input.ReadString());
break;
}
   case  80: {
 _inst.AddRoleLevelList(input.ReadInt32());
break;
}
   case  88: {
 _inst.AddModelVisualID(input.ReadInt32());
break;
}
   case  96: {
 _inst.AddWeaponID(input.ReadInt32());
break;
}
   case  104: {
 _inst.AddWeaponEffectGem(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 if (!hasValidateresult) return false;
 if (!hasUserid) return false;
 if (!hasOid) return false;
 if (!hasAccesstoken) return false;
 if (!hasRapidvalidatecode) return false;
 return true;
 }

}


[Serializable]
public class CG_CONNECTED_HEARTBEAT : PacketDistributed
{

public const int isresponseFieldNumber = 1;
 private bool hasIsresponse;
 private Int32 isresponse_ = 0;
 public bool HasIsresponse {
 get { return hasIsresponse; }
 }
 public Int32 Isresponse {
 get { return isresponse_; }
 set { SetIsresponse(value); }
 }
 public void SetIsresponse(Int32 value) { 
 hasIsresponse = true;
 isresponse_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasIsresponse) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Isresponse);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasIsresponse) {
output.WriteInt32(1, Isresponse);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CONNECTED_HEARTBEAT _inst = (CG_CONNECTED_HEARTBEAT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Isresponse = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasIsresponse) return false;
 return true;
 }

}


[Serializable]
public class GC_CONNECTED_HEARTBEAT : PacketDistributed
{

public const int serveransitimeFieldNumber = 1;
 private bool hasServeransitime;
 private Int32 serveransitime_ = 0;
 public bool HasServeransitime {
 get { return hasServeransitime; }
 }
 public Int32 Serveransitime {
 get { return serveransitime_; }
 set { SetServeransitime(value); }
 }
 public void SetServeransitime(Int32 value) { 
 hasServeransitime = true;
 serveransitime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServeransitime) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Serveransitime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServeransitime) {
output.WriteInt32(1, Serveransitime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CONNECTED_HEARTBEAT _inst = (GC_CONNECTED_HEARTBEAT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Serveransitime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServeransitime) return false;
 return true;
 }

}


[Serializable]
public class GC_NOTICE : PacketDistributed
{

public const int noticeFieldNumber = 1;
 private bool hasNotice;
 private string notice_ = "";
 public bool HasNotice {
 get { return hasNotice; }
 }
 public string Notice {
 get { return notice_; }
 set { SetNotice(value); }
 }
 public void SetNotice(string value) { 
 hasNotice = true;
 notice_ = value;
 }

public const int filterRepeatFieldNumber = 2;
 private bool hasFilterRepeat;
 private Int32 filterRepeat_ = 0;
 public bool HasFilterRepeat {
 get { return hasFilterRepeat; }
 }
 public Int32 FilterRepeat {
 get { return filterRepeat_; }
 set { SetFilterRepeat(value); }
 }
 public void SetFilterRepeat(Int32 value) { 
 hasFilterRepeat = true;
 filterRepeat_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNotice) {
size += pb::CodedOutputStream.ComputeStringSize(1, Notice);
}
 if (HasFilterRepeat) {
size += pb::CodedOutputStream.ComputeInt32Size(2, FilterRepeat);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNotice) {
output.WriteString(1, Notice);
}
 
if (HasFilterRepeat) {
output.WriteInt32(2, FilterRepeat);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_NOTICE _inst = (GC_NOTICE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.Notice = input.ReadString();
break;
}
   case  16: {
 _inst.FilterRepeat = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNotice) return false;
 return true;
 }

}


[Serializable]
public class GC_MISSION_SYNC_MISSIONLIST : PacketDistributed
{

public const int missionIDFieldNumber = 1;
 private pbc::PopsicleList<Int32> missionID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> missionIDList {
 get { return pbc::Lists.AsReadOnly(missionID_); }
 }
 
 public int missionIDCount {
 get { return missionID_.Count; }
 }
 
public Int32 GetMissionID(int index) {
 return missionID_[index];
 }
 public void AddMissionID(Int32 value) {
 missionID_.Add(value);
 }

public const int stateFieldNumber = 2;
 private pbc::PopsicleList<Int32> state_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> stateList {
 get { return pbc::Lists.AsReadOnly(state_); }
 }
 
 public int stateCount {
 get { return state_.Count; }
 }
 
public Int32 GetState(int index) {
 return state_[index];
 }
 public void AddState(Int32 value) {
 state_.Add(value);
 }

public const int nParamFieldNumber = 3;
 private pbc::PopsicleList<Int32> nParam_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> nParamList {
 get { return pbc::Lists.AsReadOnly(nParam_); }
 }
 
 public int nParamCount {
 get { return nParam_.Count; }
 }
 
public Int32 GetNParam(int index) {
 return nParam_[index];
 }
 public void AddNParam(Int32 value) {
 nParam_.Add(value);
 }

public const int havedoneFlagFieldNumber = 4;
 private pbc::PopsicleList<UInt32> havedoneFlag_ = new pbc::PopsicleList<UInt32>();
 public scg::IList<UInt32> havedoneFlagList {
 get { return pbc::Lists.AsReadOnly(havedoneFlag_); }
 }
 
 public int havedoneFlagCount {
 get { return havedoneFlag_.Count; }
 }
 
public UInt32 GetHavedoneFlag(int index) {
 return havedoneFlag_[index];
 }
 public void AddHavedoneFlag(UInt32 value) {
 havedoneFlag_.Add(value);
 }

public const int qualitytypeFieldNumber = 5;
 private pbc::PopsicleList<Int32> qualitytype_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> qualitytypeList {
 get { return pbc::Lists.AsReadOnly(qualitytype_); }
 }
 
 public int qualitytypeCount {
 get { return qualitytype_.Count; }
 }
 
public Int32 GetQualitytype(int index) {
 return qualitytype_[index];
 }
 public void AddQualitytype(Int32 value) {
 qualitytype_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<missionIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(missionIDList[i]);
}
size += dataSize;
size += 1 * missionID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<stateList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(stateList[i]);
}
size += dataSize;
size += 1 * state_.Count;
}
{
int dataSize = 0;
for(int i=0; i<nParamList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(nParamList[i]);
}
size += dataSize;
size += 1 * nParam_.Count;
}
{
int dataSize = 0;
for(int i=0; i<havedoneFlagList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt32SizeNoTag(havedoneFlagList[i]);
}
size += dataSize;
size += 1 * havedoneFlag_.Count;
}
{
int dataSize = 0;
for(int i=0; i<qualitytypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(qualitytypeList[i]);
}
size += dataSize;
size += 1 * qualitytype_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (missionID_.Count > 0) {
for(int i=0; i<missionID_.Count; ++i){
output.WriteInt32(1,missionID_[i]);
}
}

}
{
if (state_.Count > 0) {
for(int i=0; i<state_.Count; ++i){
output.WriteInt32(2,state_[i]);
}
}

}
{
if (nParam_.Count > 0) {
for(int i=0; i<nParam_.Count; ++i){
output.WriteInt32(3,nParam_[i]);
}
}

}
{
if (havedoneFlag_.Count > 0) {
for(int i=0; i<havedoneFlag_.Count; ++i){
output.WriteUInt32(4,havedoneFlag_[i]);
}
}

}
{
if (qualitytype_.Count > 0) {
for(int i=0; i<qualitytype_.Count; ++i){
output.WriteInt32(5,qualitytype_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MISSION_SYNC_MISSIONLIST _inst = (GC_MISSION_SYNC_MISSIONLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddMissionID(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddState(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddNParam(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddHavedoneFlag(input.ReadUInt32());
break;
}
   case  40: {
 _inst.AddQualitytype(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_ACCEPTMISSION : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ACCEPTMISSION _inst = (CG_ACCEPTMISSION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 return true;
 }

}


[Serializable]
public class GC_ACCEPTMISSION_RET : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

public const int QualityTypeFieldNumber = 2;
 private bool hasQualityType;
 private Int32 QualityType_ = 0;
 public bool HasQualityType {
 get { return hasQualityType; }
 }
 public Int32 QualityType {
 get { return QualityType_; }
 set { SetQualityType(value); }
 }
 public void SetQualityType(Int32 value) { 
 hasQualityType = true;
 QualityType_ = value;
 }

public const int RetFieldNumber = 3;
 private bool hasRet;
 private Int32 Ret_ = 0;
 public bool HasRet {
 get { return hasRet; }
 }
 public Int32 Ret {
 get { return Ret_; }
 set { SetRet(value); }
 }
 public void SetRet(Int32 value) { 
 hasRet = true;
 Ret_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 if (HasQualityType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, QualityType);
}
 if (HasRet) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Ret);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 
if (HasQualityType) {
output.WriteInt32(2, QualityType);
}
 
if (HasRet) {
output.WriteInt32(3, Ret);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ACCEPTMISSION_RET _inst = (GC_ACCEPTMISSION_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}
   case  16: {
 _inst.QualityType = input.ReadInt32();
break;
}
   case  24: {
 _inst.Ret = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 if (!hasQualityType) return false;
 if (!hasRet) return false;
 return true;
 }

}


[Serializable]
public class CG_COMPLETEMISSION : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_COMPLETEMISSION _inst = (CG_COMPLETEMISSION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 return true;
 }

}


[Serializable]
public class GC_COMPLETEMISSION_RET : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

public const int RetFieldNumber = 2;
 private bool hasRet;
 private Int32 Ret_ = 0;
 public bool HasRet {
 get { return hasRet; }
 }
 public Int32 Ret {
 get { return Ret_; }
 set { SetRet(value); }
 }
 public void SetRet(Int32 value) { 
 hasRet = true;
 Ret_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 if (HasRet) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Ret);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 
if (HasRet) {
output.WriteInt32(2, Ret);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_COMPLETEMISSION_RET _inst = (GC_COMPLETEMISSION_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Ret = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 if (!hasRet) return false;
 return true;
 }

}


[Serializable]
public class CG_ABANDONMISSION : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ABANDONMISSION _inst = (CG_ABANDONMISSION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 return true;
 }

}


[Serializable]
public class GC_ABANDONMISSION_RET : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

public const int RetFieldNumber = 2;
 private bool hasRet;
 private Int32 Ret_ = 0;
 public bool HasRet {
 get { return hasRet; }
 }
 public Int32 Ret {
 get { return Ret_; }
 set { SetRet(value); }
 }
 public void SetRet(Int32 value) { 
 hasRet = true;
 Ret_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 if (HasRet) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Ret);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 
if (HasRet) {
output.WriteInt32(2, Ret);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ABANDONMISSION_RET _inst = (GC_ABANDONMISSION_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Ret = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 if (!hasRet) return false;
 return true;
 }

}


[Serializable]
public class GC_MISSION_STATE : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

public const int StateFieldNumber = 2;
 private bool hasState;
 private Int32 State_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return State_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 State_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(2, State);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 
if (HasState) {
output.WriteInt32(2, State);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MISSION_STATE _inst = (GC_MISSION_STATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}
   case  16: {
 _inst.State = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 if (!hasState) return false;
 return true;
 }

}


[Serializable]
public class GC_MISSION_PARAM : PacketDistributed
{

public const int MissionIDFieldNumber = 1;
 private bool hasMissionID;
 private Int32 MissionID_ = 0;
 public bool HasMissionID {
 get { return hasMissionID; }
 }
 public Int32 MissionID {
 get { return MissionID_; }
 set { SetMissionID(value); }
 }
 public void SetMissionID(Int32 value) { 
 hasMissionID = true;
 MissionID_ = value;
 }

public const int ParamIndexFieldNumber = 2;
 private bool hasParamIndex;
 private Int32 ParamIndex_ = 0;
 public bool HasParamIndex {
 get { return hasParamIndex; }
 }
 public Int32 ParamIndex {
 get { return ParamIndex_; }
 set { SetParamIndex(value); }
 }
 public void SetParamIndex(Int32 value) { 
 hasParamIndex = true;
 ParamIndex_ = value;
 }

public const int ParamFieldNumber = 3;
 private bool hasParam;
 private Int32 Param_ = 0;
 public bool HasParam {
 get { return hasParam; }
 }
 public Int32 Param {
 get { return Param_; }
 set { SetParam(value); }
 }
 public void SetParam(Int32 value) { 
 hasParam = true;
 Param_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMissionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MissionID);
}
 if (HasParamIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(2, ParamIndex);
}
 if (HasParam) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Param);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMissionID) {
output.WriteInt32(1, MissionID);
}
 
if (HasParamIndex) {
output.WriteInt32(2, ParamIndex);
}
 
if (HasParam) {
output.WriteInt32(3, Param);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MISSION_PARAM _inst = (GC_MISSION_PARAM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MissionID = input.ReadInt32();
break;
}
   case  16: {
 _inst.ParamIndex = input.ReadInt32();
break;
}
   case  24: {
 _inst.Param = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMissionID) return false;
 if (!hasParamIndex) return false;
 if (!hasParam) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_CHANGE_SCENE : PacketDistributed
{
public enum CHANGETYPE 
 { 
  TELEPORT = 0,    //����ʯ 
  WORLDMAP = 1,    //�����ͼ 
  TRAIL   = 2,    //׷ɱ���� 
  POINT   = 3,    //����㴫�� 
  TEAMFOLLOW = 4,   //��Ӹ����г��� ���ðɹ� 
 }
public const int ctypeFieldNumber = 1;
 private bool hasCtype;
 private Int32 ctype_ = 0;
 public bool HasCtype {
 get { return hasCtype; }
 }
 public Int32 Ctype {
 get { return ctype_; }
 set { SetCtype(value); }
 }
 public void SetCtype(Int32 value) { 
 hasCtype = true;
 ctype_ = value;
 }

public const int teleportidFieldNumber = 2;
 private bool hasTeleportid;
 private Int32 teleportid_ = 0;
 public bool HasTeleportid {
 get { return hasTeleportid; }
 }
 public Int32 Teleportid {
 get { return teleportid_; }
 set { SetTeleportid(value); }
 }
 public void SetTeleportid(Int32 value) { 
 hasTeleportid = true;
 teleportid_ = value;
 }

public const int sceneclassidFieldNumber = 3;
 private bool hasSceneclassid;
 private Int32 sceneclassid_ = 0;
 public bool HasSceneclassid {
 get { return hasSceneclassid; }
 }
 public Int32 Sceneclassid {
 get { return sceneclassid_; }
 set { SetSceneclassid(value); }
 }
 public void SetSceneclassid(Int32 value) { 
 hasSceneclassid = true;
 sceneclassid_ = value;
 }

public const int sceneinstidFieldNumber = 4;
 private bool hasSceneinstid;
 private Int32 sceneinstid_ = 0;
 public bool HasSceneinstid {
 get { return hasSceneinstid; }
 }
 public Int32 Sceneinstid {
 get { return sceneinstid_; }
 set { SetSceneinstid(value); }
 }
 public void SetSceneinstid(Int32 value) { 
 hasSceneinstid = true;
 sceneinstid_ = value;
 }

public const int posXFieldNumber = 5;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 6;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCtype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Ctype);
}
 if (HasTeleportid) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Teleportid);
}
 if (HasSceneclassid) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Sceneclassid);
}
 if (HasSceneinstid) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Sceneinstid);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(5, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(6, PosZ);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCtype) {
output.WriteInt32(1, Ctype);
}
 
if (HasTeleportid) {
output.WriteInt32(2, Teleportid);
}
 
if (HasSceneclassid) {
output.WriteInt32(3, Sceneclassid);
}
 
if (HasSceneinstid) {
output.WriteInt32(4, Sceneinstid);
}
 
if (HasPosX) {
output.WriteInt32(5, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(6, PosZ);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_CHANGE_SCENE _inst = (CG_REQ_CHANGE_SCENE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Ctype = input.ReadInt32();
break;
}
   case  16: {
 _inst.Teleportid = input.ReadInt32();
break;
}
   case  24: {
 _inst.Sceneclassid = input.ReadInt32();
break;
}
   case  32: {
 _inst.Sceneinstid = input.ReadInt32();
break;
}
   case  40: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  48: {
 _inst.PosZ = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCtype) return false;
 if (!hasTeleportid) return false;
 if (!hasSceneclassid) return false;
 if (!hasSceneinstid) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 return true;
 }

}


[Serializable]
public class GC_ENTER_SCENE : PacketDistributed
{

public const int sceneclassFieldNumber = 1;
 private bool hasSceneclass;
 private Int32 sceneclass_ = 0;
 public bool HasSceneclass {
 get { return hasSceneclass; }
 }
 public Int32 Sceneclass {
 get { return sceneclass_; }
 set { SetSceneclass(value); }
 }
 public void SetSceneclass(Int32 value) { 
 hasSceneclass = true;
 sceneclass_ = value;
 }

public const int sceneinstFieldNumber = 2;
 private bool hasSceneinst;
 private Int32 sceneinst_ = 0;
 public bool HasSceneinst {
 get { return hasSceneinst; }
 }
 public Int32 Sceneinst {
 get { return sceneinst_; }
 set { SetSceneinst(value); }
 }
 public void SetSceneinst(Int32 value) { 
 hasSceneinst = true;
 sceneinst_ = value;
 }

public const int mainplayerserveridFieldNumber = 3;
 private bool hasMainplayerserverid;
 private Int32 mainplayerserverid_ = 0;
 public bool HasMainplayerserverid {
 get { return hasMainplayerserverid; }
 }
 public Int32 Mainplayerserverid {
 get { return mainplayerserverid_; }
 set { SetMainplayerserverid(value); }
 }
 public void SetMainplayerserverid(Int32 value) { 
 hasMainplayerserverid = true;
 mainplayerserverid_ = value;
 }

public const int posXFieldNumber = 4;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 5;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

public const int ExistTimeFieldNumber = 6;
 private bool hasExistTime;
 private Int32 ExistTime_ = 0;
 public bool HasExistTime {
 get { return hasExistTime; }
 }
 public Int32 ExistTime {
 get { return ExistTime_; }
 set { SetExistTime(value); }
 }
 public void SetExistTime(Int32 value) { 
 hasExistTime = true;
 ExistTime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneclass) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Sceneclass);
}
 if (HasSceneinst) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Sceneinst);
}
 if (HasMainplayerserverid) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Mainplayerserverid);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(4, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(5, PosZ);
}
 if (HasExistTime) {
size += pb::CodedOutputStream.ComputeInt32Size(6, ExistTime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneclass) {
output.WriteInt32(1, Sceneclass);
}
 
if (HasSceneinst) {
output.WriteInt32(2, Sceneinst);
}
 
if (HasMainplayerserverid) {
output.WriteInt32(3, Mainplayerserverid);
}
 
if (HasPosX) {
output.WriteInt32(4, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(5, PosZ);
}
 
if (HasExistTime) {
output.WriteInt32(6, ExistTime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ENTER_SCENE _inst = (GC_ENTER_SCENE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Sceneclass = input.ReadInt32();
break;
}
   case  16: {
 _inst.Sceneinst = input.ReadInt32();
break;
}
   case  24: {
 _inst.Mainplayerserverid = input.ReadInt32();
break;
}
   case  32: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  40: {
 _inst.PosZ = input.ReadInt32();
break;
}
   case  48: {
 _inst.ExistTime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneclass) return false;
 if (!hasSceneinst) return false;
 if (!hasMainplayerserverid) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 return true;
 }

}


[Serializable]
public class CG_ENTER_SCENE_OK : PacketDistributed
{

public const int isOKFieldNumber = 1;
 private bool hasIsOK;
 private Int32 isOK_ = 0;
 public bool HasIsOK {
 get { return hasIsOK; }
 }
 public Int32 IsOK {
 get { return isOK_; }
 set { SetIsOK(value); }
 }
 public void SetIsOK(Int32 value) { 
 hasIsOK = true;
 isOK_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasIsOK) {
size += pb::CodedOutputStream.ComputeInt32Size(1, IsOK);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasIsOK) {
output.WriteInt32(1, IsOK);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ENTER_SCENE_OK _inst = (CG_ENTER_SCENE_OK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.IsOK = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasIsOK) return false;
 return true;
 }

}


[Serializable]
public class GC_CREATE_PLAYER : PacketDistributed
{

public const int serverIdFieldNumber = 1;
 private bool hasServerId;
 private Int32 serverId_ = 0;
 public bool HasServerId {
 get { return hasServerId; }
 }
 public Int32 ServerId {
 get { return serverId_; }
 set { SetServerId(value); }
 }
 public void SetServerId(Int32 value) { 
 hasServerId = true;
 serverId_ = value;
 }

public const int guidFieldNumber = 2;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int sceneInstFieldNumber = 3;
 private bool hasSceneInst;
 private Int32 sceneInst_ = 0;
 public bool HasSceneInst {
 get { return hasSceneInst; }
 }
 public Int32 SceneInst {
 get { return sceneInst_; }
 set { SetSceneInst(value); }
 }
 public void SetSceneInst(Int32 value) { 
 hasSceneInst = true;
 sceneInst_ = value;
 }

public const int sceneClassFieldNumber = 4;
 private bool hasSceneClass;
 private Int32 sceneClass_ = 0;
 public bool HasSceneClass {
 get { return hasSceneClass; }
 }
 public Int32 SceneClass {
 get { return sceneClass_; }
 set { SetSceneClass(value); }
 }
 public void SetSceneClass(Int32 value) { 
 hasSceneClass = true;
 sceneClass_ = value;
 }

public const int dataIdFieldNumber = 5;
 private bool hasDataId;
 private Int32 dataId_ = 0;
 public bool HasDataId {
 get { return hasDataId; }
 }
 public Int32 DataId {
 get { return dataId_; }
 set { SetDataId(value); }
 }
 public void SetDataId(Int32 value) { 
 hasDataId = true;
 dataId_ = value;
 }

public const int posXFieldNumber = 6;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 7;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

public const int curforceFieldNumber = 8;
 private bool hasCurforce;
 private Int32 curforce_ = 0;
 public bool HasCurforce {
 get { return hasCurforce; }
 }
 public Int32 Curforce {
 get { return curforce_; }
 set { SetCurforce(value); }
 }
 public void SetCurforce(Int32 value) { 
 hasCurforce = true;
 curforce_ = value;
 }

public const int nameFieldNumber = 9;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int curProfessionFieldNumber = 10;
 private bool hasCurProfession;
 private Int32 curProfession_ = 0;
 public bool HasCurProfession {
 get { return hasCurProfession; }
 }
 public Int32 CurProfession {
 get { return curProfession_; }
 set { SetCurProfession(value); }
 }
 public void SetCurProfession(Int32 value) { 
 hasCurProfession = true;
 curProfession_ = value;
 }

public const int facedirFieldNumber = 11;
 private bool hasFacedir;
 private Int32 facedir_ = 0;
 public bool HasFacedir {
 get { return hasFacedir; }
 }
 public Int32 Facedir {
 get { return facedir_; }
 set { SetFacedir(value); }
 }
 public void SetFacedir(Int32 value) { 
 hasFacedir = true;
 facedir_ = value;
 }

public const int titlenameFieldNumber = 12;
 private bool hasTitlename;
 private string titlename_ = "";
 public bool HasTitlename {
 get { return hasTitlename; }
 }
 public string Titlename {
 get { return titlename_; }
 set { SetTitlename(value); }
 }
 public void SetTitlename(string value) { 
 hasTitlename = true;
 titlename_ = value;
 }

public const int isInPkListFieldNumber = 13;
 private bool hasIsInPkList;
 private Int32 isInPkList_ = 0;
 public bool HasIsInPkList {
 get { return hasIsInPkList; }
 }
 public Int32 IsInPkList {
 get { return isInPkList_; }
 set { SetIsInPkList(value); }
 }
 public void SetIsInPkList(Int32 value) { 
 hasIsInPkList = true;
 isInPkList_ = value;
 }

public const int isDieFieldNumber = 14;
 private bool hasIsDie;
 private Int32 isDie_ = 0;
 public bool HasIsDie {
 get { return hasIsDie; }
 }
 public Int32 IsDie {
 get { return isDie_; }
 set { SetIsDie(value); }
 }
 public void SetIsDie(Int32 value) { 
 hasIsDie = true;
 isDie_ = value;
 }

public const int ReliveTimeFieldNumber = 15;
 private bool hasReliveTime;
 private Int32 ReliveTime_ = 0;
 public bool HasReliveTime {
 get { return hasReliveTime; }
 }
 public Int32 ReliveTime {
 get { return ReliveTime_; }
 set { SetReliveTime(value); }
 }
 public void SetReliveTime(Int32 value) { 
 hasReliveTime = true;
 ReliveTime_ = value;
 }

public const int PKModleFieldNumber = 16;
 private bool hasPKModle;
 private Int32 PKModle_ = 0;
 public bool HasPKModle {
 get { return hasPKModle; }
 }
 public Int32 PKModle {
 get { return PKModle_; }
 set { SetPKModle(value); }
 }
 public void SetPKModle(Int32 value) { 
 hasPKModle = true;
 PKModle_ = value;
 }

public const int MountIDFieldNumber = 17;
 private bool hasMountID;
 private Int32 MountID_ = 0;
 public bool HasMountID {
 get { return hasMountID; }
 }
 public Int32 MountID {
 get { return MountID_; }
 set { SetMountID(value); }
 }
 public void SetMountID(Int32 value) { 
 hasMountID = true;
 MountID_ = value;
 }

public const int MoveSpeedFieldNumber = 18;
 private bool hasMoveSpeed;
 private Int32 MoveSpeed_ = 0;
 public bool HasMoveSpeed {
 get { return hasMoveSpeed; }
 }
 public Int32 MoveSpeed {
 get { return MoveSpeed_; }
 set { SetMoveSpeed(value); }
 }
 public void SetMoveSpeed(Int32 value) { 
 hasMoveSpeed = true;
 MoveSpeed_ = value;
 }

public const int ModelVisualIDFieldNumber = 19;
 private bool hasModelVisualID;
 private Int32 ModelVisualID_ = 0;
 public bool HasModelVisualID {
 get { return hasModelVisualID; }
 }
 public Int32 ModelVisualID {
 get { return ModelVisualID_; }
 set { SetModelVisualID(value); }
 }
 public void SetModelVisualID(Int32 value) { 
 hasModelVisualID = true;
 ModelVisualID_ = value;
 }

public const int WeaponDataIDFieldNumber = 20;
 private bool hasWeaponDataID;
 private Int32 WeaponDataID_ = 0;
 public bool HasWeaponDataID {
 get { return hasWeaponDataID; }
 }
 public Int32 WeaponDataID {
 get { return WeaponDataID_; }
 set { SetWeaponDataID(value); }
 }
 public void SetWeaponDataID(Int32 value) { 
 hasWeaponDataID = true;
 WeaponDataID_ = value;
 }

public const int WeaponEffectGemFieldNumber = 22;
 private bool hasWeaponEffectGem;
 private Int32 WeaponEffectGem_ = 0;
 public bool HasWeaponEffectGem {
 get { return hasWeaponEffectGem; }
 }
 public Int32 WeaponEffectGem {
 get { return WeaponEffectGem_; }
 set { SetWeaponEffectGem(value); }
 }
 public void SetWeaponEffectGem(Int32 value) { 
 hasWeaponEffectGem = true;
 WeaponEffectGem_ = value;
 }

public const int CurTitleIDFieldNumber = 23;
 private bool hasCurTitleID;
 private Int32 CurTitleID_ = 0;
 public bool HasCurTitleID {
 get { return hasCurTitleID; }
 }
 public Int32 CurTitleID {
 get { return CurTitleID_; }
 set { SetCurTitleID(value); }
 }
 public void SetCurTitleID(Int32 value) { 
 hasCurTitleID = true;
 CurTitleID_ = value;
 }

public const int StealthLevFieldNumber = 24;
 private bool hasStealthLev;
 private Int32 StealthLev_ = 0;
 public bool HasStealthLev {
 get { return hasStealthLev; }
 }
 public Int32 StealthLev {
 get { return StealthLev_; }
 set { SetStealthLev(value); }
 }
 public void SetStealthLev(Int32 value) { 
 hasStealthLev = true;
 StealthLev_ = value;
 }

public const int VipCostFieldNumber = 25;
 private bool hasVipCost;
 private Int32 VipCost_ = 0;
 public bool HasVipCost {
 get { return hasVipCost; }
 }
 public Int32 VipCost {
 get { return VipCost_; }
 set { SetVipCost(value); }
 }
 public void SetVipCost(Int32 value) { 
 hasVipCost = true;
 VipCost_ = value;
 }

public const int GuildGuidFieldNumber = 26;
 private bool hasGuildGuid;
 private UInt64 GuildGuid_ = 0;
 public bool HasGuildGuid {
 get { return hasGuildGuid; }
 }
 public UInt64 GuildGuid {
 get { return GuildGuid_; }
 set { SetGuildGuid(value); }
 }
 public void SetGuildGuid(UInt64 value) { 
 hasGuildGuid = true;
 GuildGuid_ = value;
 }

public const int CombatValueFieldNumber = 27;
 private bool hasCombatValue;
 private Int32 CombatValue_ = 0;
 public bool HasCombatValue {
 get { return hasCombatValue; }
 }
 public Int32 CombatValue {
 get { return CombatValue_; }
 set { SetCombatValue(value); }
 }
 public void SetCombatValue(Int32 value) { 
 hasCombatValue = true;
 CombatValue_ = value;
 }

public const int bindparentFieldNumber = 28;
 private bool hasBindparent;
 private Int32 bindparent_ = 0;
 public bool HasBindparent {
 get { return hasBindparent; }
 }
 public Int32 Bindparent {
 get { return bindparent_; }
 set { SetBindparent(value); }
 }
 public void SetBindparent(Int32 value) { 
 hasBindparent = true;
 bindparent_ = value;
 }

public const int bindchildrenFieldNumber = 29;
 private pbc::PopsicleList<Int32> bindchildren_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> bindchildrenList {
 get { return pbc::Lists.AsReadOnly(bindchildren_); }
 }
 
 public int bindchildrenCount {
 get { return bindchildren_.Count; }
 }
 
public Int32 GetBindchildren(int index) {
 return bindchildren_[index];
 }
 public void AddBindchildren(Int32 value) {
 bindchildren_.Add(value);
 }

public const int isEnemy2SelfFieldNumber = 30;
 private bool hasIsEnemy2Self;
 private Int32 isEnemy2Self_ = 0;
 public bool HasIsEnemy2Self {
 get { return hasIsEnemy2Self; }
 }
 public Int32 IsEnemy2Self {
 get { return isEnemy2Self_; }
 set { SetIsEnemy2Self(value); }
 }
 public void SetIsEnemy2Self(Int32 value) { 
 hasIsEnemy2Self = true;
 isEnemy2Self_ = value;
 }

public const int paoshangStateFieldNumber = 31;
 private bool hasPaoshangState;
 private Int32 paoshangState_ = 0;
 public bool HasPaoshangState {
 get { return hasPaoshangState; }
 }
 public Int32 PaoshangState {
 get { return paoshangState_; }
 set { SetPaoshangState(value); }
 }
 public void SetPaoshangState(Int32 value) { 
 hasPaoshangState = true;
 paoshangState_ = value;
 }

public const int lightSkillLevelFieldNumber = 32;
 private bool hasLightSkillLevel;
 private Int32 lightSkillLevel_ = 0;
 public bool HasLightSkillLevel {
 get { return hasLightSkillLevel; }
 }
 public Int32 LightSkillLevel {
 get { return lightSkillLevel_; }
 set { SetLightSkillLevel(value); }
 }
 public void SetLightSkillLevel(Int32 value) { 
 hasLightSkillLevel = true;
 lightSkillLevel_ = value;
 }

public const int followStateFieldNumber = 33;
 private bool hasFollowState;
 private Int32 followState_ = 0;
 public bool HasFollowState {
 get { return hasFollowState; }
 }
 public Int32 FollowState {
 get { return followState_; }
 set { SetFollowState(value); }
 }
 public void SetFollowState(Int32 value) { 
 hasFollowState = true;
 followState_ = value;
 }

public const int changeStateFieldNumber = 34;
 private bool hasChangeState;
 private Int32 changeState_ = 0;
 public bool HasChangeState {
 get { return hasChangeState; }
 }
 public Int32 ChangeState {
 get { return changeState_; }
 set { SetChangeState(value); }
 }
 public void SetChangeState(Int32 value) { 
 hasChangeState = true;
 changeState_ = value;
 }

public const int flyWingIdFieldNumber = 35;
 private bool hasFlyWingId;
 private Int32 flyWingId_ = 0;
 public bool HasFlyWingId {
 get { return hasFlyWingId; }
 }
 public Int32 FlyWingId {
 get { return flyWingId_; }
 set { SetFlyWingId(value); }
 }
 public void SetFlyWingId(Int32 value) { 
 hasFlyWingId = true;
 flyWingId_ = value;
 }

public const int BelleIdFieldNumber = 36;
 private pbc::PopsicleList<Int32> BelleId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> BelleIdList {
 get { return pbc::Lists.AsReadOnly(BelleId_); }
 }
 
 public int BelleIdCount {
 get { return BelleId_.Count; }
 }
 
public Int32 GetBelleId(int index) {
 return BelleId_[index];
 }
 public void AddBelleId(Int32 value) {
 BelleId_.Add(value);
 }

public const int BelleCloseFieldNumber = 37;
 private pbc::PopsicleList<Int32> BelleClose_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> BelleCloseList {
 get { return pbc::Lists.AsReadOnly(BelleClose_); }
 }
 
 public int BelleCloseCount {
 get { return BelleClose_.Count; }
 }
 
public Int32 GetBelleClose(int index) {
 return BelleClose_[index];
 }
 public void AddBelleClose(Int32 value) {
 BelleClose_.Add(value);
 }

public const int BelleLevelFieldNumber = 38;
 private pbc::PopsicleList<Int32> BelleLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> BelleLevelList {
 get { return pbc::Lists.AsReadOnly(BelleLevel_); }
 }
 
 public int BelleLevelCount {
 get { return BelleLevel_.Count; }
 }
 
public Int32 GetBelleLevel(int index) {
 return BelleLevel_[index];
 }
 public void AddBelleLevel(Int32 value) {
 BelleLevel_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ServerId);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Guid);
}
 if (HasSceneInst) {
size += pb::CodedOutputStream.ComputeInt32Size(3, SceneInst);
}
 if (HasSceneClass) {
size += pb::CodedOutputStream.ComputeInt32Size(4, SceneClass);
}
 if (HasDataId) {
size += pb::CodedOutputStream.ComputeInt32Size(5, DataId);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(6, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(7, PosZ);
}
 if (HasCurforce) {
size += pb::CodedOutputStream.ComputeInt32Size(8, Curforce);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(9, Name);
}
 if (HasCurProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(10, CurProfession);
}
 if (HasFacedir) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Facedir);
}
 if (HasTitlename) {
size += pb::CodedOutputStream.ComputeStringSize(12, Titlename);
}
 if (HasIsInPkList) {
size += pb::CodedOutputStream.ComputeInt32Size(13, IsInPkList);
}
 if (HasIsDie) {
size += pb::CodedOutputStream.ComputeInt32Size(14, IsDie);
}
 if (HasReliveTime) {
size += pb::CodedOutputStream.ComputeInt32Size(15, ReliveTime);
}
 if (HasPKModle) {
size += pb::CodedOutputStream.ComputeInt32Size(16, PKModle);
}
 if (HasMountID) {
size += pb::CodedOutputStream.ComputeInt32Size(17, MountID);
}
 if (HasMoveSpeed) {
size += pb::CodedOutputStream.ComputeInt32Size(18, MoveSpeed);
}
 if (HasModelVisualID) {
size += pb::CodedOutputStream.ComputeInt32Size(19, ModelVisualID);
}
 if (HasWeaponDataID) {
size += pb::CodedOutputStream.ComputeInt32Size(20, WeaponDataID);
}
 if (HasWeaponEffectGem) {
size += pb::CodedOutputStream.ComputeInt32Size(22, WeaponEffectGem);
}
 if (HasCurTitleID) {
size += pb::CodedOutputStream.ComputeInt32Size(23, CurTitleID);
}
 if (HasStealthLev) {
size += pb::CodedOutputStream.ComputeInt32Size(24, StealthLev);
}
 if (HasVipCost) {
size += pb::CodedOutputStream.ComputeInt32Size(25, VipCost);
}
 if (HasGuildGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(26, GuildGuid);
}
 if (HasCombatValue) {
size += pb::CodedOutputStream.ComputeInt32Size(27, CombatValue);
}
 if (HasBindparent) {
size += pb::CodedOutputStream.ComputeInt32Size(28, Bindparent);
}
{
int dataSize = 0;
for(int i=0; i<bindchildrenList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(bindchildrenList[i]);
}
size += dataSize;
size += 1 * bindchildren_.Count;
}
 if (HasIsEnemy2Self) {
size += pb::CodedOutputStream.ComputeInt32Size(30, IsEnemy2Self);
}
 if (HasPaoshangState) {
size += pb::CodedOutputStream.ComputeInt32Size(31, PaoshangState);
}
 if (HasLightSkillLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(32, LightSkillLevel);
}
 if (HasFollowState) {
size += pb::CodedOutputStream.ComputeInt32Size(33, FollowState);
}
 if (HasChangeState) {
size += pb::CodedOutputStream.ComputeInt32Size(34, ChangeState);
}
 if (HasFlyWingId) {
size += pb::CodedOutputStream.ComputeInt32Size(35, FlyWingId);
}
{
int dataSize = 0;
for(int i=0; i<BelleIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(BelleIdList[i]);
}
size += dataSize;
size += 1 * BelleId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<BelleCloseList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(BelleCloseList[i]);
}
size += dataSize;
size += 1 * BelleClose_.Count;
}
{
int dataSize = 0;
for(int i=0; i<BelleLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(BelleLevelList[i]);
}
size += dataSize;
size += 1 * BelleLevel_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerId) {
output.WriteInt32(1, ServerId);
}
 
if (HasGuid) {
output.WriteUInt64(2, Guid);
}
 
if (HasSceneInst) {
output.WriteInt32(3, SceneInst);
}
 
if (HasSceneClass) {
output.WriteInt32(4, SceneClass);
}
 
if (HasDataId) {
output.WriteInt32(5, DataId);
}
 
if (HasPosX) {
output.WriteInt32(6, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(7, PosZ);
}
 
if (HasCurforce) {
output.WriteInt32(8, Curforce);
}
 
if (HasName) {
output.WriteString(9, Name);
}
 
if (HasCurProfession) {
output.WriteInt32(10, CurProfession);
}
 
if (HasFacedir) {
output.WriteInt32(11, Facedir);
}
 
if (HasTitlename) {
output.WriteString(12, Titlename);
}
 
if (HasIsInPkList) {
output.WriteInt32(13, IsInPkList);
}
 
if (HasIsDie) {
output.WriteInt32(14, IsDie);
}
 
if (HasReliveTime) {
output.WriteInt32(15, ReliveTime);
}
 
if (HasPKModle) {
output.WriteInt32(16, PKModle);
}
 
if (HasMountID) {
output.WriteInt32(17, MountID);
}
 
if (HasMoveSpeed) {
output.WriteInt32(18, MoveSpeed);
}
 
if (HasModelVisualID) {
output.WriteInt32(19, ModelVisualID);
}
 
if (HasWeaponDataID) {
output.WriteInt32(20, WeaponDataID);
}
 
if (HasWeaponEffectGem) {
output.WriteInt32(22, WeaponEffectGem);
}
 
if (HasCurTitleID) {
output.WriteInt32(23, CurTitleID);
}
 
if (HasStealthLev) {
output.WriteInt32(24, StealthLev);
}
 
if (HasVipCost) {
output.WriteInt32(25, VipCost);
}
 
if (HasGuildGuid) {
output.WriteUInt64(26, GuildGuid);
}
 
if (HasCombatValue) {
output.WriteInt32(27, CombatValue);
}
 
if (HasBindparent) {
output.WriteInt32(28, Bindparent);
}
{
if (bindchildren_.Count > 0) {
for(int i=0; i<bindchildren_.Count; ++i){
output.WriteInt32(29,bindchildren_[i]);
}
}

}
 
if (HasIsEnemy2Self) {
output.WriteInt32(30, IsEnemy2Self);
}
 
if (HasPaoshangState) {
output.WriteInt32(31, PaoshangState);
}
 
if (HasLightSkillLevel) {
output.WriteInt32(32, LightSkillLevel);
}
 
if (HasFollowState) {
output.WriteInt32(33, FollowState);
}
 
if (HasChangeState) {
output.WriteInt32(34, ChangeState);
}
 
if (HasFlyWingId) {
output.WriteInt32(35, FlyWingId);
}
{
if (BelleId_.Count > 0) {
for(int i=0; i<BelleId_.Count; ++i){
output.WriteInt32(36,BelleId_[i]);
}
}

}
{
if (BelleClose_.Count > 0) {
for(int i=0; i<BelleClose_.Count; ++i){
output.WriteInt32(37,BelleClose_[i]);
}
}

}
{
if (BelleLevel_.Count > 0) {
for(int i=0; i<BelleLevel_.Count; ++i){
output.WriteInt32(38,BelleLevel_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CREATE_PLAYER _inst = (GC_CREATE_PLAYER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ServerId = input.ReadInt32();
break;
}
   case  16: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  24: {
 _inst.SceneInst = input.ReadInt32();
break;
}
   case  32: {
 _inst.SceneClass = input.ReadInt32();
break;
}
   case  40: {
 _inst.DataId = input.ReadInt32();
break;
}
   case  48: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  56: {
 _inst.PosZ = input.ReadInt32();
break;
}
   case  64: {
 _inst.Curforce = input.ReadInt32();
break;
}
   case  74: {
 _inst.Name = input.ReadString();
break;
}
   case  80: {
 _inst.CurProfession = input.ReadInt32();
break;
}
   case  88: {
 _inst.Facedir = input.ReadInt32();
break;
}
   case  98: {
 _inst.Titlename = input.ReadString();
break;
}
   case  104: {
 _inst.IsInPkList = input.ReadInt32();
break;
}
   case  112: {
 _inst.IsDie = input.ReadInt32();
break;
}
   case  120: {
 _inst.ReliveTime = input.ReadInt32();
break;
}
   case  128: {
 _inst.PKModle = input.ReadInt32();
break;
}
   case  136: {
 _inst.MountID = input.ReadInt32();
break;
}
   case  144: {
 _inst.MoveSpeed = input.ReadInt32();
break;
}
   case  152: {
 _inst.ModelVisualID = input.ReadInt32();
break;
}
   case  160: {
 _inst.WeaponDataID = input.ReadInt32();
break;
}
   case  176: {
 _inst.WeaponEffectGem = input.ReadInt32();
break;
}
   case  184: {
 _inst.CurTitleID = input.ReadInt32();
break;
}
   case  192: {
 _inst.StealthLev = input.ReadInt32();
break;
}
   case  200: {
 _inst.VipCost = input.ReadInt32();
break;
}
   case  208: {
 _inst.GuildGuid = input.ReadUInt64();
break;
}
   case  216: {
 _inst.CombatValue = input.ReadInt32();
break;
}
   case  224: {
 _inst.Bindparent = input.ReadInt32();
break;
}
   case  232: {
 _inst.AddBindchildren(input.ReadInt32());
break;
}
   case  240: {
 _inst.IsEnemy2Self = input.ReadInt32();
break;
}
   case  248: {
 _inst.PaoshangState = input.ReadInt32();
break;
}
   case  256: {
 _inst.LightSkillLevel = input.ReadInt32();
break;
}
   case  264: {
 _inst.FollowState = input.ReadInt32();
break;
}
   case  272: {
 _inst.ChangeState = input.ReadInt32();
break;
}
   case  280: {
 _inst.FlyWingId = input.ReadInt32();
break;
}
   case  288: {
 _inst.AddBelleId(input.ReadInt32());
break;
}
   case  296: {
 _inst.AddBelleClose(input.ReadInt32());
break;
}
   case  304: {
 _inst.AddBelleLevel(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerId) return false;
 if (!hasGuid) return false;
 if (!hasSceneInst) return false;
 if (!hasSceneClass) return false;
 if (!hasDataId) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 if (!hasCurforce) return false;
 if (!hasName) return false;
 if (!hasCurProfession) return false;
 if (!hasFacedir) return false;
 if (!hasTitlename) return false;
 if (!hasIsInPkList) return false;
 if (!hasIsDie) return false;
 if (!hasPKModle) return false;
 if (!hasMountID) return false;
 if (!hasMoveSpeed) return false;
 if (!hasModelVisualID) return false;
 if (!hasWeaponDataID) return false;
 if (!hasWeaponEffectGem) return false;
 if (!hasCurTitleID) return false;
 if (!hasStealthLev) return false;
 if (!hasVipCost) return false;
 if (!hasGuildGuid) return false;
 if (!hasCombatValue) return false;
 if (!hasBindparent) return false;
 if (!hasIsEnemy2Self) return false;
 return true;
 }

}


[Serializable]
public class GC_DELETE_OBJ : PacketDistributed
{

public const int serverIdFieldNumber = 1;
 private bool hasServerId;
 private Int32 serverId_ = 0;
 public bool HasServerId {
 get { return hasServerId; }
 }
 public Int32 ServerId {
 get { return serverId_; }
 set { SetServerId(value); }
 }
 public void SetServerId(Int32 value) { 
 hasServerId = true;
 serverId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ServerId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerId) {
output.WriteInt32(1, ServerId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DELETE_OBJ _inst = (GC_DELETE_OBJ) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ServerId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerId) return false;
 return true;
 }

}


[Serializable]
public class CG_SYNC_POS : PacketDistributed
{

public const int posXFieldNumber = 1;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 2;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

public const int ismoviongFieldNumber = 3;
 private bool hasIsmoviong;
 private Int32 ismoviong_ = 0;
 public bool HasIsmoviong {
 get { return hasIsmoviong; }
 }
 public Int32 Ismoviong {
 get { return ismoviong_; }
 set { SetIsmoviong(value); }
 }
 public void SetIsmoviong(Int32 value) { 
 hasIsmoviong = true;
 ismoviong_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(1, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(2, PosZ);
}
 if (HasIsmoviong) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Ismoviong);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPosX) {
output.WriteInt32(1, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(2, PosZ);
}
 
if (HasIsmoviong) {
output.WriteInt32(3, Ismoviong);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_SYNC_POS _inst = (CG_SYNC_POS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  16: {
 _inst.PosZ = input.ReadInt32();
break;
}
   case  24: {
 _inst.Ismoviong = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPosX) return false;
 if (!hasPosZ) return false;
 if (!hasIsmoviong) return false;
 return true;
 }

}


[Serializable]
public class GC_SYNC_POS : PacketDistributed
{

public const int serverIdFieldNumber = 1;
 private bool hasServerId;
 private Int32 serverId_ = 0;
 public bool HasServerId {
 get { return hasServerId; }
 }
 public Int32 ServerId {
 get { return serverId_; }
 set { SetServerId(value); }
 }
 public void SetServerId(Int32 value) { 
 hasServerId = true;
 serverId_ = value;
 }

public const int posXFieldNumber = 2;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 3;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ServerId);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(2, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(3, PosZ);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerId) {
output.WriteInt32(1, ServerId);
}
 
if (HasPosX) {
output.WriteInt32(2, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(3, PosZ);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_POS _inst = (GC_SYNC_POS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ServerId = input.ReadInt32();
break;
}
   case  16: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  24: {
 _inst.PosZ = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerId) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 return true;
 }

}


[Serializable]
public class CG_MOVE : PacketDistributed
{

public const int poscountFieldNumber = 1;
 private bool hasPoscount;
 private Int32 poscount_ = 0;
 public bool HasPoscount {
 get { return hasPoscount; }
 }
 public Int32 Poscount {
 get { return poscount_; }
 set { SetPoscount(value); }
 }
 public void SetPoscount(Int32 value) { 
 hasPoscount = true;
 poscount_ = value;
 }

public const int posxFieldNumber = 2;
 private pbc::PopsicleList<Int32> posx_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posxList {
 get { return pbc::Lists.AsReadOnly(posx_); }
 }
 
 public int posxCount {
 get { return posx_.Count; }
 }
 
public Int32 GetPosx(int index) {
 return posx_[index];
 }
 public void AddPosx(Int32 value) {
 posx_.Add(value);
 }

public const int poszFieldNumber = 3;
 private pbc::PopsicleList<Int32> posz_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> poszList {
 get { return pbc::Lists.AsReadOnly(posz_); }
 }
 
 public int poszCount {
 get { return posz_.Count; }
 }
 
public Int32 GetPosz(int index) {
 return posz_[index];
 }
 public void AddPosz(Int32 value) {
 posz_.Add(value);
 }

public const int ismovingFieldNumber = 4;
 private bool hasIsmoving;
 private Int32 ismoving_ = 0;
 public bool HasIsmoving {
 get { return hasIsmoving; }
 }
 public Int32 Ismoving {
 get { return ismoving_; }
 set { SetIsmoving(value); }
 }
 public void SetIsmoving(Int32 value) { 
 hasIsmoving = true;
 ismoving_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPoscount) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Poscount);
}
{
int dataSize = 0;
for(int i=0; i<posxList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posxList[i]);
}
size += dataSize;
size += 1 * posx_.Count;
}
{
int dataSize = 0;
for(int i=0; i<poszList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(poszList[i]);
}
size += dataSize;
size += 1 * posz_.Count;
}
 if (HasIsmoving) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Ismoving);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPoscount) {
output.WriteInt32(1, Poscount);
}
{
if (posx_.Count > 0) {
for(int i=0; i<posx_.Count; ++i){
output.WriteInt32(2,posx_[i]);
}
}

}
{
if (posz_.Count > 0) {
for(int i=0; i<posz_.Count; ++i){
output.WriteInt32(3,posz_[i]);
}
}

}
 
if (HasIsmoving) {
output.WriteInt32(4, Ismoving);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MOVE _inst = (CG_MOVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Poscount = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddPosx(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddPosz(input.ReadInt32());
break;
}
   case  32: {
 _inst.Ismoving = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPoscount) return false;
 if (!hasIsmoving) return false;
 return true;
 }

}


[Serializable]
public class GC_MOVE : PacketDistributed
{

public const int serveridFieldNumber = 1;
 private bool hasServerid;
 private Int32 serverid_ = 0;
 public bool HasServerid {
 get { return hasServerid; }
 }
 public Int32 Serverid {
 get { return serverid_; }
 set { SetServerid(value); }
 }
 public void SetServerid(Int32 value) { 
 hasServerid = true;
 serverid_ = value;
 }

public const int poscountFieldNumber = 2;
 private bool hasPoscount;
 private Int32 poscount_ = 0;
 public bool HasPoscount {
 get { return hasPoscount; }
 }
 public Int32 Poscount {
 get { return poscount_; }
 set { SetPoscount(value); }
 }
 public void SetPoscount(Int32 value) { 
 hasPoscount = true;
 poscount_ = value;
 }

public const int posserialFieldNumber = 3;
 private pbc::PopsicleList<Int32> posserial_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posserialList {
 get { return pbc::Lists.AsReadOnly(posserial_); }
 }
 
 public int posserialCount {
 get { return posserial_.Count; }
 }
 
public Int32 GetPosserial(int index) {
 return posserial_[index];
 }
 public void AddPosserial(Int32 value) {
 posserial_.Add(value);
 }

public const int posxFieldNumber = 4;
 private pbc::PopsicleList<Int32> posx_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posxList {
 get { return pbc::Lists.AsReadOnly(posx_); }
 }
 
 public int posxCount {
 get { return posx_.Count; }
 }
 
public Int32 GetPosx(int index) {
 return posx_[index];
 }
 public void AddPosx(Int32 value) {
 posx_.Add(value);
 }

public const int poszFieldNumber = 5;
 private pbc::PopsicleList<Int32> posz_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> poszList {
 get { return pbc::Lists.AsReadOnly(posz_); }
 }
 
 public int poszCount {
 get { return posz_.Count; }
 }
 
public Int32 GetPosz(int index) {
 return posz_[index];
 }
 public void AddPosz(Int32 value) {
 posz_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerid) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Serverid);
}
 if (HasPoscount) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Poscount);
}
{
int dataSize = 0;
for(int i=0; i<posserialList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posserialList[i]);
}
size += dataSize;
size += 1 * posserial_.Count;
}
{
int dataSize = 0;
for(int i=0; i<posxList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posxList[i]);
}
size += dataSize;
size += 1 * posx_.Count;
}
{
int dataSize = 0;
for(int i=0; i<poszList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(poszList[i]);
}
size += dataSize;
size += 1 * posz_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerid) {
output.WriteInt32(1, Serverid);
}
 
if (HasPoscount) {
output.WriteInt32(2, Poscount);
}
{
if (posserial_.Count > 0) {
for(int i=0; i<posserial_.Count; ++i){
output.WriteInt32(3,posserial_[i]);
}
}

}
{
if (posx_.Count > 0) {
for(int i=0; i<posx_.Count; ++i){
output.WriteInt32(4,posx_[i]);
}
}

}
{
if (posz_.Count > 0) {
for(int i=0; i<posz_.Count; ++i){
output.WriteInt32(5,posz_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MOVE _inst = (GC_MOVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Serverid = input.ReadInt32();
break;
}
   case  16: {
 _inst.Poscount = input.ReadInt32();
break;
}
   case  24: {
 _inst.AddPosserial(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddPosx(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddPosz(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerid) return false;
 if (!hasPoscount) return false;
 return true;
 }

}


[Serializable]
public class GC_STOP : PacketDistributed
{

public const int serveridFieldNumber = 1;
 private bool hasServerid;
 private Int32 serverid_ = 0;
 public bool HasServerid {
 get { return hasServerid; }
 }
 public Int32 Serverid {
 get { return serverid_; }
 set { SetServerid(value); }
 }
 public void SetServerid(Int32 value) { 
 hasServerid = true;
 serverid_ = value;
 }

public const int posserialFieldNumber = 2;
 private bool hasPosserial;
 private Int32 posserial_ = 0;
 public bool HasPosserial {
 get { return hasPosserial; }
 }
 public Int32 Posserial {
 get { return posserial_; }
 set { SetPosserial(value); }
 }
 public void SetPosserial(Int32 value) { 
 hasPosserial = true;
 posserial_ = value;
 }

public const int posxFieldNumber = 3;
 private bool hasPosx;
 private Int32 posx_ = 0;
 public bool HasPosx {
 get { return hasPosx; }
 }
 public Int32 Posx {
 get { return posx_; }
 set { SetPosx(value); }
 }
 public void SetPosx(Int32 value) { 
 hasPosx = true;
 posx_ = value;
 }

public const int poszFieldNumber = 4;
 private bool hasPosz;
 private Int32 posz_ = 0;
 public bool HasPosz {
 get { return hasPosz; }
 }
 public Int32 Posz {
 get { return posz_; }
 set { SetPosz(value); }
 }
 public void SetPosz(Int32 value) { 
 hasPosz = true;
 posz_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerid) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Serverid);
}
 if (HasPosserial) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Posserial);
}
 if (HasPosx) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Posx);
}
 if (HasPosz) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Posz);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerid) {
output.WriteInt32(1, Serverid);
}
 
if (HasPosserial) {
output.WriteInt32(2, Posserial);
}
 
if (HasPosx) {
output.WriteInt32(3, Posx);
}
 
if (HasPosz) {
output.WriteInt32(4, Posz);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_STOP _inst = (GC_STOP) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Serverid = input.ReadInt32();
break;
}
   case  16: {
 _inst.Posserial = input.ReadInt32();
break;
}
   case  24: {
 _inst.Posx = input.ReadInt32();
break;
}
   case  32: {
 _inst.Posz = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerid) return false;
 if (!hasPosserial) return false;
 if (!hasPosx) return false;
 if (!hasPosz) return false;
 return true;
 }

}


[Serializable]
public class CG_SYSTEMSHOP_VIEW : PacketDistributed
{

public const int NpcIdFieldNumber = 1;
 private bool hasNpcId;
 private Int32 NpcId_ = 0;
 public bool HasNpcId {
 get { return hasNpcId; }
 }
 public Int32 NpcId {
 get { return NpcId_; }
 set { SetNpcId(value); }
 }
 public void SetNpcId(Int32 value) { 
 hasNpcId = true;
 NpcId_ = value;
 }

public const int ShopIdFieldNumber = 2;
 private bool hasShopId;
 private Int32 ShopId_ = 0;
 public bool HasShopId {
 get { return hasShopId; }
 }
 public Int32 ShopId {
 get { return ShopId_; }
 set { SetShopId(value); }
 }
 public void SetShopId(Int32 value) { 
 hasShopId = true;
 ShopId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNpcId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NpcId);
}
 if (HasShopId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, ShopId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNpcId) {
output.WriteInt32(1, NpcId);
}
 
if (HasShopId) {
output.WriteInt32(2, ShopId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_SYSTEMSHOP_VIEW _inst = (CG_SYSTEMSHOP_VIEW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NpcId = input.ReadInt32();
break;
}
   case  16: {
 _inst.ShopId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasShopId) return false;
 return true;
 }

}


[Serializable]
public class CG_SYSTEMSHOP_BUY : PacketDistributed
{

public const int NpcIdFieldNumber = 1;
 private bool hasNpcId;
 private Int32 NpcId_ = 0;
 public bool HasNpcId {
 get { return hasNpcId; }
 }
 public Int32 NpcId {
 get { return NpcId_; }
 set { SetNpcId(value); }
 }
 public void SetNpcId(Int32 value) { 
 hasNpcId = true;
 NpcId_ = value;
 }

public const int ShopIdFieldNumber = 2;
 private bool hasShopId;
 private Int32 ShopId_ = 0;
 public bool HasShopId {
 get { return hasShopId; }
 }
 public Int32 ShopId {
 get { return ShopId_; }
 set { SetShopId(value); }
 }
 public void SetShopId(Int32 value) { 
 hasShopId = true;
 ShopId_ = value;
 }

public const int MercIndexFieldNumber = 3;
 private bool hasMercIndex;
 private Int32 MercIndex_ = 0;
 public bool HasMercIndex {
 get { return hasMercIndex; }
 }
 public Int32 MercIndex {
 get { return MercIndex_; }
 set { SetMercIndex(value); }
 }
 public void SetMercIndex(Int32 value) { 
 hasMercIndex = true;
 MercIndex_ = value;
 }

public const int BuyNumFieldNumber = 4;
 private bool hasBuyNum;
 private Int32 BuyNum_ = 0;
 public bool HasBuyNum {
 get { return hasBuyNum; }
 }
 public Int32 BuyNum {
 get { return BuyNum_; }
 set { SetBuyNum(value); }
 }
 public void SetBuyNum(Int32 value) { 
 hasBuyNum = true;
 BuyNum_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNpcId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NpcId);
}
 if (HasShopId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, ShopId);
}
 if (HasMercIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(3, MercIndex);
}
 if (HasBuyNum) {
size += pb::CodedOutputStream.ComputeInt32Size(4, BuyNum);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNpcId) {
output.WriteInt32(1, NpcId);
}
 
if (HasShopId) {
output.WriteInt32(2, ShopId);
}
 
if (HasMercIndex) {
output.WriteInt32(3, MercIndex);
}
 
if (HasBuyNum) {
output.WriteInt32(4, BuyNum);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_SYSTEMSHOP_BUY _inst = (CG_SYSTEMSHOP_BUY) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NpcId = input.ReadInt32();
break;
}
   case  16: {
 _inst.ShopId = input.ReadInt32();
break;
}
   case  24: {
 _inst.MercIndex = input.ReadInt32();
break;
}
   case  32: {
 _inst.BuyNum = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasShopId) return false;
 if (!hasMercIndex) return false;
 if (!hasBuyNum) return false;
 return true;
 }

}


[Serializable]
public class CG_SYSTEMSHOP_BUYBACK : PacketDistributed
{

public const int NpcIdFieldNumber = 1;
 private bool hasNpcId;
 private Int32 NpcId_ = 0;
 public bool HasNpcId {
 get { return hasNpcId; }
 }
 public Int32 NpcId {
 get { return NpcId_; }
 set { SetNpcId(value); }
 }
 public void SetNpcId(Int32 value) { 
 hasNpcId = true;
 NpcId_ = value;
 }

public const int ShopIdFieldNumber = 2;
 private bool hasShopId;
 private Int32 ShopId_ = 0;
 public bool HasShopId {
 get { return hasShopId; }
 }
 public Int32 ShopId {
 get { return ShopId_; }
 set { SetShopId(value); }
 }
 public void SetShopId(Int32 value) { 
 hasShopId = true;
 ShopId_ = value;
 }

public const int ItemGuidFieldNumber = 3;
 private bool hasItemGuid;
 private UInt64 ItemGuid_ = 0;
 public bool HasItemGuid {
 get { return hasItemGuid; }
 }
 public UInt64 ItemGuid {
 get { return ItemGuid_; }
 set { SetItemGuid(value); }
 }
 public void SetItemGuid(UInt64 value) { 
 hasItemGuid = true;
 ItemGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNpcId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NpcId);
}
 if (HasShopId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, ShopId);
}
 if (HasItemGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, ItemGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNpcId) {
output.WriteInt32(1, NpcId);
}
 
if (HasShopId) {
output.WriteInt32(2, ShopId);
}
 
if (HasItemGuid) {
output.WriteUInt64(3, ItemGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_SYSTEMSHOP_BUYBACK _inst = (CG_SYSTEMSHOP_BUYBACK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NpcId = input.ReadInt32();
break;
}
   case  16: {
 _inst.ShopId = input.ReadInt32();
break;
}
   case  24: {
 _inst.ItemGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasShopId) return false;
 if (!hasItemGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_SYSTEMSHOP_SELL : PacketDistributed
{

public const int PackageFieldNumber = 1;
 private bool hasPackage;
 private Int32 Package_ = 0;
 public bool HasPackage {
 get { return hasPackage; }
 }
 public Int32 Package {
 get { return Package_; }
 set { SetPackage(value); }
 }
 public void SetPackage(Int32 value) { 
 hasPackage = true;
 Package_ = value;
 }

public const int ItemGuidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> ItemGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> ItemGuidList {
 get { return pbc::Lists.AsReadOnly(ItemGuid_); }
 }
 
 public int ItemGuidCount {
 get { return ItemGuid_.Count; }
 }
 
public UInt64 GetItemGuid(int index) {
 return ItemGuid_[index];
 }
 public void AddItemGuid(UInt64 value) {
 ItemGuid_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPackage) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Package);
}
{
int dataSize = 0;
for(int i=0; i<ItemGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(ItemGuidList[i]);
}
size += dataSize;
size += 1 * ItemGuid_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPackage) {
output.WriteInt32(1, Package);
}
{
if (ItemGuid_.Count > 0) {
for(int i=0; i<ItemGuid_.Count; ++i){
output.WriteUInt64(2,ItemGuid_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_SYSTEMSHOP_SELL _inst = (CG_SYSTEMSHOP_SELL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Package = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddItemGuid(input.ReadUInt64());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPackage) return false;
 return true;
 }

}


[Serializable]
public class GC_SYSTEMSHOP_MERCHANDISELIST : PacketDistributed
{
public enum SYSTEMSHOPTYPE 
 { 
  STATIC_SHOP  = 1, 
  DYNAMIC_SHOP = 2, 
 }public enum MERCHANDISEBIND 
 { 
  BIND   = 1, 
  UNBIND = 2, 
 }
public const int ShopTypeFieldNumber = 1;
 private bool hasShopType;
 private Int32 ShopType_ = 0;
 public bool HasShopType {
 get { return hasShopType; }
 }
 public Int32 ShopType {
 get { return ShopType_; }
 set { SetShopType(value); }
 }
 public void SetShopType(Int32 value) { 
 hasShopType = true;
 ShopType_ = value;
 }

public const int NpcIdFieldNumber = 2;
 private bool hasNpcId;
 private Int32 NpcId_ = 0;
 public bool HasNpcId {
 get { return hasNpcId; }
 }
 public Int32 NpcId {
 get { return NpcId_; }
 set { SetNpcId(value); }
 }
 public void SetNpcId(Int32 value) { 
 hasNpcId = true;
 NpcId_ = value;
 }

public const int ShopIdFieldNumber = 3;
 private bool hasShopId;
 private Int32 ShopId_ = 0;
 public bool HasShopId {
 get { return hasShopId; }
 }
 public Int32 ShopId {
 get { return ShopId_; }
 set { SetShopId(value); }
 }
 public void SetShopId(Int32 value) { 
 hasShopId = true;
 ShopId_ = value;
 }

public const int MerCountFieldNumber = 4;
 private bool hasMerCount;
 private Int32 MerCount_ = 0;
 public bool HasMerCount {
 get { return hasMerCount; }
 }
 public Int32 MerCount {
 get { return MerCount_; }
 set { SetMerCount(value); }
 }
 public void SetMerCount(Int32 value) { 
 hasMerCount = true;
 MerCount_ = value;
 }

public const int MercIdFieldNumber = 5;
 private pbc::PopsicleList<Int32> MercId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> MercIdList {
 get { return pbc::Lists.AsReadOnly(MercId_); }
 }
 
 public int MercIdCount {
 get { return MercId_.Count; }
 }
 
public Int32 GetMercId(int index) {
 return MercId_[index];
 }
 public void AddMercId(Int32 value) {
 MercId_.Add(value);
 }

public const int GroupSizeFieldNumber = 6;
 private pbc::PopsicleList<Int32> GroupSize_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> GroupSizeList {
 get { return pbc::Lists.AsReadOnly(GroupSize_); }
 }
 
 public int GroupSizeCount {
 get { return GroupSize_.Count; }
 }
 
public Int32 GetGroupSize(int index) {
 return GroupSize_[index];
 }
 public void AddGroupSize(Int32 value) {
 GroupSize_.Add(value);
 }

public const int MoneyTypeFieldNumber = 7;
 private pbc::PopsicleList<Int32> MoneyType_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> MoneyTypeList {
 get { return pbc::Lists.AsReadOnly(MoneyType_); }
 }
 
 public int MoneyTypeCount {
 get { return MoneyType_.Count; }
 }
 
public Int32 GetMoneyType(int index) {
 return MoneyType_[index];
 }
 public void AddMoneyType(Int32 value) {
 MoneyType_.Add(value);
 }

public const int PriceFieldNumber = 8;
 private pbc::PopsicleList<Int32> Price_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> PriceList {
 get { return pbc::Lists.AsReadOnly(Price_); }
 }
 
 public int PriceCount {
 get { return Price_.Count; }
 }
 
public Int32 GetPrice(int index) {
 return Price_[index];
 }
 public void AddPrice(Int32 value) {
 Price_.Add(value);
 }

public const int DisPriceFieldNumber = 9;
 private pbc::PopsicleList<Int32> DisPrice_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> DisPriceList {
 get { return pbc::Lists.AsReadOnly(DisPrice_); }
 }
 
 public int DisPriceCount {
 get { return DisPrice_.Count; }
 }
 
public Int32 GetDisPrice(int index) {
 return DisPrice_[index];
 }
 public void AddDisPrice(Int32 value) {
 DisPrice_.Add(value);
 }

public const int IsBindFieldNumber = 10;
 private pbc::PopsicleList<Int32> IsBind_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> IsBindList {
 get { return pbc::Lists.AsReadOnly(IsBind_); }
 }
 
 public int IsBindCount {
 get { return IsBind_.Count; }
 }
 
public Int32 GetIsBind(int index) {
 return IsBind_[index];
 }
 public void AddIsBind(Int32 value) {
 IsBind_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasShopType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ShopType);
}
 if (HasNpcId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, NpcId);
}
 if (HasShopId) {
size += pb::CodedOutputStream.ComputeInt32Size(3, ShopId);
}
 if (HasMerCount) {
size += pb::CodedOutputStream.ComputeInt32Size(4, MerCount);
}
{
int dataSize = 0;
for(int i=0; i<MercIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(MercIdList[i]);
}
size += dataSize;
size += 1 * MercId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<GroupSizeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(GroupSizeList[i]);
}
size += dataSize;
size += 1 * GroupSize_.Count;
}
{
int dataSize = 0;
for(int i=0; i<MoneyTypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(MoneyTypeList[i]);
}
size += dataSize;
size += 1 * MoneyType_.Count;
}
{
int dataSize = 0;
for(int i=0; i<PriceList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(PriceList[i]);
}
size += dataSize;
size += 1 * Price_.Count;
}
{
int dataSize = 0;
for(int i=0; i<DisPriceList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(DisPriceList[i]);
}
size += dataSize;
size += 1 * DisPrice_.Count;
}
{
int dataSize = 0;
for(int i=0; i<IsBindList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(IsBindList[i]);
}
size += dataSize;
size += 1 * IsBind_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasShopType) {
output.WriteInt32(1, ShopType);
}
 
if (HasNpcId) {
output.WriteInt32(2, NpcId);
}
 
if (HasShopId) {
output.WriteInt32(3, ShopId);
}
 
if (HasMerCount) {
output.WriteInt32(4, MerCount);
}
{
if (MercId_.Count > 0) {
for(int i=0; i<MercId_.Count; ++i){
output.WriteInt32(5,MercId_[i]);
}
}

}
{
if (GroupSize_.Count > 0) {
for(int i=0; i<GroupSize_.Count; ++i){
output.WriteInt32(6,GroupSize_[i]);
}
}

}
{
if (MoneyType_.Count > 0) {
for(int i=0; i<MoneyType_.Count; ++i){
output.WriteInt32(7,MoneyType_[i]);
}
}

}
{
if (Price_.Count > 0) {
for(int i=0; i<Price_.Count; ++i){
output.WriteInt32(8,Price_[i]);
}
}

}
{
if (DisPrice_.Count > 0) {
for(int i=0; i<DisPrice_.Count; ++i){
output.WriteInt32(9,DisPrice_[i]);
}
}

}
{
if (IsBind_.Count > 0) {
for(int i=0; i<IsBind_.Count; ++i){
output.WriteInt32(10,IsBind_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYSTEMSHOP_MERCHANDISELIST _inst = (GC_SYSTEMSHOP_MERCHANDISELIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ShopType = input.ReadInt32();
break;
}
   case  16: {
 _inst.NpcId = input.ReadInt32();
break;
}
   case  24: {
 _inst.ShopId = input.ReadInt32();
break;
}
   case  32: {
 _inst.MerCount = input.ReadInt32();
break;
}
   case  40: {
 _inst.AddMercId(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddGroupSize(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddMoneyType(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddPrice(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddDisPrice(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddIsBind(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasShopType) return false;
 if (!hasShopId) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATENOTICEDATA : PacketDistributed
{

public const int newsFieldNumber = 1;
 private pbc::PopsicleList<string> news_ = new pbc::PopsicleList<string>();
 public scg::IList<string> newsList {
 get { return pbc::Lists.AsReadOnly(news_); }
 }
 
 public int newsCount {
 get { return news_.Count; }
 }
 
public string GetNews(int index) {
 return news_[index];
 }
 public void AddNews(string value) {
 news_.Add(value);
 }

public const int dataFieldNumber = 2;
 private pbc::PopsicleList<string> data_ = new pbc::PopsicleList<string>();
 public scg::IList<string> dataList {
 get { return pbc::Lists.AsReadOnly(data_); }
 }
 
 public int dataCount {
 get { return data_.Count; }
 }
 
public string GetData(int index) {
 return data_[index];
 }
 public void AddData(string value) {
 data_.Add(value);
 }

public const int IsShowFieldNumber = 3;
 private bool hasIsShow;
 private Int32 IsShow_ = 0;
 public bool HasIsShow {
 get { return hasIsShow; }
 }
 public Int32 IsShow {
 get { return IsShow_; }
 set { SetIsShow(value); }
 }
 public void SetIsShow(Int32 value) { 
 hasIsShow = true;
 IsShow_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<newsList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(newsList[i]);
}
size += dataSize;
size += 1 * news_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dataList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(dataList[i]);
}
size += dataSize;
size += 1 * data_.Count;
}
 if (HasIsShow) {
size += pb::CodedOutputStream.ComputeInt32Size(3, IsShow);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (news_.Count > 0) {
for(int i=0; i<news_.Count; ++i){
output.WriteString(1,news_[i]);
}
}

}
{
if (data_.Count > 0) {
for(int i=0; i<data_.Count; ++i){
output.WriteString(2,data_[i]);
}
}

}
 
if (HasIsShow) {
output.WriteInt32(3, IsShow);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATENOTICEDATA _inst = (GC_UPDATENOTICEDATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.AddNews(input.ReadString());
break;
}
   case  18: {
 _inst.AddData(input.ReadString());
break;
}
   case  24: {
 _inst.IsShow = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_UPDATEITEM : PacketDistributed
{

public const int packtypeFieldNumber = 1;
 private bool hasPacktype;
 private Int32 packtype_ = 0;
 public bool HasPacktype {
 get { return hasPacktype; }
 }
 public Int32 Packtype {
 get { return packtype_; }
 set { SetPacktype(value); }
 }
 public void SetPacktype(Int32 value) { 
 hasPacktype = true;
 packtype_ = value;
 }

public const int packindexFieldNumber = 2;
 private bool hasPackindex;
 private Int32 packindex_ = 0;
 public bool HasPackindex {
 get { return hasPackindex; }
 }
 public Int32 Packindex {
 get { return packindex_; }
 set { SetPackindex(value); }
 }
 public void SetPackindex(Int32 value) { 
 hasPackindex = true;
 packindex_ = value;
 }

public const int dataidFieldNumber = 3;
 private bool hasDataid;
 private Int32 dataid_ = 0;
 public bool HasDataid {
 get { return hasDataid; }
 }
 public Int32 Dataid {
 get { return dataid_; }
 set { SetDataid(value); }
 }
 public void SetDataid(Int32 value) { 
 hasDataid = true;
 dataid_ = value;
 }

public const int guidFieldNumber = 4;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int bindflagFieldNumber = 5;
 private bool hasBindflag;
 private Int32 bindflag_ = 0;
 public bool HasBindflag {
 get { return hasBindflag; }
 }
 public Int32 Bindflag {
 get { return bindflag_; }
 set { SetBindflag(value); }
 }
 public void SetBindflag(Int32 value) { 
 hasBindflag = true;
 bindflag_ = value;
 }

public const int stackcountFieldNumber = 6;
 private bool hasStackcount;
 private Int32 stackcount_ = 0;
 public bool HasStackcount {
 get { return hasStackcount; }
 }
 public Int32 Stackcount {
 get { return stackcount_; }
 set { SetStackcount(value); }
 }
 public void SetStackcount(Int32 value) { 
 hasStackcount = true;
 stackcount_ = value;
 }

public const int enchancelevelFieldNumber = 7;
 private bool hasEnchancelevel;
 private Int32 enchancelevel_ = 0;
 public bool HasEnchancelevel {
 get { return hasEnchancelevel; }
 }
 public Int32 Enchancelevel {
 get { return enchancelevel_; }
 set { SetEnchancelevel(value); }
 }
 public void SetEnchancelevel(Int32 value) { 
 hasEnchancelevel = true;
 enchancelevel_ = value;
 }

public const int starlevelFieldNumber = 8;
 private bool hasStarlevel;
 private Int32 starlevel_ = 0;
 public bool HasStarlevel {
 get { return hasStarlevel; }
 }
 public Int32 Starlevel {
 get { return starlevel_; }
 set { SetStarlevel(value); }
 }
 public void SetStarlevel(Int32 value) { 
 hasStarlevel = true;
 starlevel_ = value;
 }

public const int dynamicdata1FieldNumber = 9;
 private bool hasDynamicdata1;
 private Int32 dynamicdata1_ = 0;
 public bool HasDynamicdata1 {
 get { return hasDynamicdata1; }
 }
 public Int32 Dynamicdata1 {
 get { return dynamicdata1_; }
 set { SetDynamicdata1(value); }
 }
 public void SetDynamicdata1(Int32 value) { 
 hasDynamicdata1 = true;
 dynamicdata1_ = value;
 }

public const int dynamicdata2FieldNumber = 10;
 private bool hasDynamicdata2;
 private Int32 dynamicdata2_ = 0;
 public bool HasDynamicdata2 {
 get { return hasDynamicdata2; }
 }
 public Int32 Dynamicdata2 {
 get { return dynamicdata2_; }
 set { SetDynamicdata2(value); }
 }
 public void SetDynamicdata2(Int32 value) { 
 hasDynamicdata2 = true;
 dynamicdata2_ = value;
 }

public const int dynamicdata3FieldNumber = 11;
 private bool hasDynamicdata3;
 private Int32 dynamicdata3_ = 0;
 public bool HasDynamicdata3 {
 get { return hasDynamicdata3; }
 }
 public Int32 Dynamicdata3 {
 get { return dynamicdata3_; }
 set { SetDynamicdata3(value); }
 }
 public void SetDynamicdata3(Int32 value) { 
 hasDynamicdata3 = true;
 dynamicdata3_ = value;
 }

public const int dynamicdata4FieldNumber = 12;
 private bool hasDynamicdata4;
 private Int32 dynamicdata4_ = 0;
 public bool HasDynamicdata4 {
 get { return hasDynamicdata4; }
 }
 public Int32 Dynamicdata4 {
 get { return dynamicdata4_; }
 set { SetDynamicdata4(value); }
 }
 public void SetDynamicdata4(Int32 value) { 
 hasDynamicdata4 = true;
 dynamicdata4_ = value;
 }

public const int createtimeFieldNumber = 13;
 private bool hasCreatetime;
 private Int32 createtime_ = 0;
 public bool HasCreatetime {
 get { return hasCreatetime; }
 }
 public Int32 Createtime {
 get { return createtime_; }
 set { SetCreatetime(value); }
 }
 public void SetCreatetime(Int32 value) { 
 hasCreatetime = true;
 createtime_ = value;
 }

public const int enchanceexpFieldNumber = 14;
 private bool hasEnchanceexp;
 private Int32 enchanceexp_ = 0;
 public bool HasEnchanceexp {
 get { return hasEnchanceexp; }
 }
 public Int32 Enchanceexp {
 get { return enchanceexp_; }
 set { SetEnchanceexp(value); }
 }
 public void SetEnchanceexp(Int32 value) { 
 hasEnchanceexp = true;
 enchanceexp_ = value;
 }

public const int enctotaltexpFieldNumber = 15;
 private bool hasEnctotaltexp;
 private Int64 enctotaltexp_ = 0;
 public bool HasEnctotaltexp {
 get { return hasEnctotaltexp; }
 }
 public Int64 Enctotaltexp {
 get { return enctotaltexp_; }
 set { SetEnctotaltexp(value); }
 }
 public void SetEnctotaltexp(Int64 value) { 
 hasEnctotaltexp = true;
 enctotaltexp_ = value;
 }

public const int startimesFieldNumber = 16;
 private bool hasStartimes;
 private Int32 startimes_ = 0;
 public bool HasStartimes {
 get { return hasStartimes; }
 }
 public Int32 Startimes {
 get { return startimes_; }
 set { SetStartimes(value); }
 }
 public void SetStartimes(Int32 value) { 
 hasStartimes = true;
 startimes_ = value;
 }

public const int dynamicdata5FieldNumber = 17;
 private bool hasDynamicdata5;
 private Int32 dynamicdata5_ = 0;
 public bool HasDynamicdata5 {
 get { return hasDynamicdata5; }
 }
 public Int32 Dynamicdata5 {
 get { return dynamicdata5_; }
 set { SetDynamicdata5(value); }
 }
 public void SetDynamicdata5(Int32 value) { 
 hasDynamicdata5 = true;
 dynamicdata5_ = value;
 }

public const int dynamicdata6FieldNumber = 18;
 private bool hasDynamicdata6;
 private Int32 dynamicdata6_ = 0;
 public bool HasDynamicdata6 {
 get { return hasDynamicdata6; }
 }
 public Int32 Dynamicdata6 {
 get { return dynamicdata6_; }
 set { SetDynamicdata6(value); }
 }
 public void SetDynamicdata6(Int32 value) { 
 hasDynamicdata6 = true;
 dynamicdata6_ = value;
 }

public const int dynamicdata7FieldNumber = 19;
 private bool hasDynamicdata7;
 private Int32 dynamicdata7_ = 0;
 public bool HasDynamicdata7 {
 get { return hasDynamicdata7; }
 }
 public Int32 Dynamicdata7 {
 get { return dynamicdata7_; }
 set { SetDynamicdata7(value); }
 }
 public void SetDynamicdata7(Int32 value) { 
 hasDynamicdata7 = true;
 dynamicdata7_ = value;
 }

public const int dynamicdata8FieldNumber = 20;
 private bool hasDynamicdata8;
 private Int32 dynamicdata8_ = 0;
 public bool HasDynamicdata8 {
 get { return hasDynamicdata8; }
 }
 public Int32 Dynamicdata8 {
 get { return dynamicdata8_; }
 set { SetDynamicdata8(value); }
 }
 public void SetDynamicdata8(Int32 value) { 
 hasDynamicdata8 = true;
 dynamicdata8_ = value;
 }

public const int attrfactorFieldNumber = 21;
 private bool hasAttrfactor;
 private Int32 attrfactor_ = 0;
 public bool HasAttrfactor {
 get { return hasAttrfactor; }
 }
 public Int32 Attrfactor {
 get { return attrfactor_; }
 set { SetAttrfactor(value); }
 }
 public void SetAttrfactor(Int32 value) { 
 hasAttrfactor = true;
 attrfactor_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPacktype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Packtype);
}
 if (HasPackindex) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Packindex);
}
 if (HasDataid) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Dataid);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(4, Guid);
}
 if (HasBindflag) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Bindflag);
}
 if (HasStackcount) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Stackcount);
}
 if (HasEnchancelevel) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Enchancelevel);
}
 if (HasStarlevel) {
size += pb::CodedOutputStream.ComputeInt32Size(8, Starlevel);
}
 if (HasDynamicdata1) {
size += pb::CodedOutputStream.ComputeInt32Size(9, Dynamicdata1);
}
 if (HasDynamicdata2) {
size += pb::CodedOutputStream.ComputeInt32Size(10, Dynamicdata2);
}
 if (HasDynamicdata3) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Dynamicdata3);
}
 if (HasDynamicdata4) {
size += pb::CodedOutputStream.ComputeInt32Size(12, Dynamicdata4);
}
 if (HasCreatetime) {
size += pb::CodedOutputStream.ComputeInt32Size(13, Createtime);
}
 if (HasEnchanceexp) {
size += pb::CodedOutputStream.ComputeInt32Size(14, Enchanceexp);
}
 if (HasEnctotaltexp) {
size += pb::CodedOutputStream.ComputeInt64Size(15, Enctotaltexp);
}
 if (HasStartimes) {
size += pb::CodedOutputStream.ComputeInt32Size(16, Startimes);
}
 if (HasDynamicdata5) {
size += pb::CodedOutputStream.ComputeInt32Size(17, Dynamicdata5);
}
 if (HasDynamicdata6) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Dynamicdata6);
}
 if (HasDynamicdata7) {
size += pb::CodedOutputStream.ComputeInt32Size(19, Dynamicdata7);
}
 if (HasDynamicdata8) {
size += pb::CodedOutputStream.ComputeInt32Size(20, Dynamicdata8);
}
 if (HasAttrfactor) {
size += pb::CodedOutputStream.ComputeInt32Size(21, Attrfactor);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPacktype) {
output.WriteInt32(1, Packtype);
}
 
if (HasPackindex) {
output.WriteInt32(2, Packindex);
}
 
if (HasDataid) {
output.WriteInt32(3, Dataid);
}
 
if (HasGuid) {
output.WriteUInt64(4, Guid);
}
 
if (HasBindflag) {
output.WriteInt32(5, Bindflag);
}
 
if (HasStackcount) {
output.WriteInt32(6, Stackcount);
}
 
if (HasEnchancelevel) {
output.WriteInt32(7, Enchancelevel);
}
 
if (HasStarlevel) {
output.WriteInt32(8, Starlevel);
}
 
if (HasDynamicdata1) {
output.WriteInt32(9, Dynamicdata1);
}
 
if (HasDynamicdata2) {
output.WriteInt32(10, Dynamicdata2);
}
 
if (HasDynamicdata3) {
output.WriteInt32(11, Dynamicdata3);
}
 
if (HasDynamicdata4) {
output.WriteInt32(12, Dynamicdata4);
}
 
if (HasCreatetime) {
output.WriteInt32(13, Createtime);
}
 
if (HasEnchanceexp) {
output.WriteInt32(14, Enchanceexp);
}
 
if (HasEnctotaltexp) {
output.WriteInt64(15, Enctotaltexp);
}
 
if (HasStartimes) {
output.WriteInt32(16, Startimes);
}
 
if (HasDynamicdata5) {
output.WriteInt32(17, Dynamicdata5);
}
 
if (HasDynamicdata6) {
output.WriteInt32(18, Dynamicdata6);
}
 
if (HasDynamicdata7) {
output.WriteInt32(19, Dynamicdata7);
}
 
if (HasDynamicdata8) {
output.WriteInt32(20, Dynamicdata8);
}
 
if (HasAttrfactor) {
output.WriteInt32(21, Attrfactor);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATEITEM _inst = (GC_UPDATEITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Packtype = input.ReadInt32();
break;
}
   case  16: {
 _inst.Packindex = input.ReadInt32();
break;
}
   case  24: {
 _inst.Dataid = input.ReadInt32();
break;
}
   case  32: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  40: {
 _inst.Bindflag = input.ReadInt32();
break;
}
   case  48: {
 _inst.Stackcount = input.ReadInt32();
break;
}
   case  56: {
 _inst.Enchancelevel = input.ReadInt32();
break;
}
   case  64: {
 _inst.Starlevel = input.ReadInt32();
break;
}
   case  72: {
 _inst.Dynamicdata1 = input.ReadInt32();
break;
}
   case  80: {
 _inst.Dynamicdata2 = input.ReadInt32();
break;
}
   case  88: {
 _inst.Dynamicdata3 = input.ReadInt32();
break;
}
   case  96: {
 _inst.Dynamicdata4 = input.ReadInt32();
break;
}
   case  104: {
 _inst.Createtime = input.ReadInt32();
break;
}
   case  112: {
 _inst.Enchanceexp = input.ReadInt32();
break;
}
   case  120: {
 _inst.Enctotaltexp = input.ReadInt64();
break;
}
   case  128: {
 _inst.Startimes = input.ReadInt32();
break;
}
   case  136: {
 _inst.Dynamicdata5 = input.ReadInt32();
break;
}
   case  144: {
 _inst.Dynamicdata6 = input.ReadInt32();
break;
}
   case  152: {
 _inst.Dynamicdata7 = input.ReadInt32();
break;
}
   case  160: {
 _inst.Dynamicdata8 = input.ReadInt32();
break;
}
   case  168: {
 _inst.Attrfactor = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPacktype) return false;
 if (!hasPackindex) return false;
 if (!hasDataid) return false;
 if (!hasGuid) return false;
 if (!hasCreatetime) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_TEAM_INVITE : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_TEAM_INVITE _inst = (CG_REQ_TEAM_INVITE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_TEAM_JOIN : PacketDistributed
{

public const int teamMemberGuidFieldNumber = 1;
 private bool hasTeamMemberGuid;
 private UInt64 teamMemberGuid_ = 0;
 public bool HasTeamMemberGuid {
 get { return hasTeamMemberGuid; }
 }
 public UInt64 TeamMemberGuid {
 get { return teamMemberGuid_; }
 set { SetTeamMemberGuid(value); }
 }
 public void SetTeamMemberGuid(UInt64 value) { 
 hasTeamMemberGuid = true;
 teamMemberGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTeamMemberGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, TeamMemberGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTeamMemberGuid) {
output.WriteUInt64(1, TeamMemberGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_TEAM_JOIN _inst = (CG_REQ_TEAM_JOIN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TeamMemberGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTeamMemberGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_TEAM_LEAVE : PacketDistributed
{

public const int teamIDFieldNumber = 1;
 private bool hasTeamID;
 private Int32 teamID_ = 0;
 public bool HasTeamID {
 get { return hasTeamID; }
 }
 public Int32 TeamID {
 get { return teamID_; }
 set { SetTeamID(value); }
 }
 public void SetTeamID(Int32 value) { 
 hasTeamID = true;
 teamID_ = value;
 }

public const int NewTeamMemberFieldNumber = 2;
 private bool hasNewTeamMember;
 private UInt64 NewTeamMember_ = 0;
 public bool HasNewTeamMember {
 get { return hasNewTeamMember; }
 }
 public UInt64 NewTeamMember {
 get { return NewTeamMember_; }
 set { SetNewTeamMember(value); }
 }
 public void SetNewTeamMember(UInt64 value) { 
 hasNewTeamMember = true;
 NewTeamMember_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTeamID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TeamID);
}
 if (HasNewTeamMember) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, NewTeamMember);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTeamID) {
output.WriteInt32(1, TeamID);
}
 
if (HasNewTeamMember) {
output.WriteUInt64(2, NewTeamMember);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_TEAM_LEAVE _inst = (CG_REQ_TEAM_LEAVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TeamID = input.ReadInt32();
break;
}
   case  16: {
 _inst.NewTeamMember = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTeamID) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_TEAM_KICK_MEMBER : PacketDistributed
{

public const int teamMemberGuidFieldNumber = 1;
 private bool hasTeamMemberGuid;
 private UInt64 teamMemberGuid_ = 0;
 public bool HasTeamMemberGuid {
 get { return hasTeamMemberGuid; }
 }
 public UInt64 TeamMemberGuid {
 get { return teamMemberGuid_; }
 set { SetTeamMemberGuid(value); }
 }
 public void SetTeamMemberGuid(UInt64 value) { 
 hasTeamMemberGuid = true;
 teamMemberGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTeamMemberGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, TeamMemberGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTeamMemberGuid) {
output.WriteUInt64(1, TeamMemberGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_TEAM_KICK_MEMBER _inst = (CG_REQ_TEAM_KICK_MEMBER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TeamMemberGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTeamMemberGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_TEAM_CHANGE_LEADER : PacketDistributed
{

public const int teamMemberGuidFieldNumber = 1;
 private bool hasTeamMemberGuid;
 private UInt64 teamMemberGuid_ = 0;
 public bool HasTeamMemberGuid {
 get { return hasTeamMemberGuid; }
 }
 public UInt64 TeamMemberGuid {
 get { return teamMemberGuid_; }
 set { SetTeamMemberGuid(value); }
 }
 public void SetTeamMemberGuid(UInt64 value) { 
 hasTeamMemberGuid = true;
 teamMemberGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTeamMemberGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, TeamMemberGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTeamMemberGuid) {
output.WriteUInt64(1, TeamMemberGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_TEAM_CHANGE_LEADER _inst = (CG_REQ_TEAM_CHANGE_LEADER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TeamMemberGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTeamMemberGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_TEAM_LEAVE : PacketDistributed
{

public const int teamIDFieldNumber = 1;
 private bool hasTeamID;
 private Int32 teamID_ = 0;
 public bool HasTeamID {
 get { return hasTeamID; }
 }
 public Int32 TeamID {
 get { return teamID_; }
 set { SetTeamID(value); }
 }
 public void SetTeamID(Int32 value) { 
 hasTeamID = true;
 teamID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTeamID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TeamID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTeamID) {
output.WriteInt32(1, TeamID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_TEAM_LEAVE _inst = (GC_TEAM_LEAVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TeamID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTeamID) return false;
 return true;
 }

}


[Serializable]
public class GC_TEAM_SYNC_TEAMINFO : PacketDistributed
{

public const int teamIDFieldNumber = 1;
 private bool hasTeamID;
 private Int32 teamID_ = 0;
 public bool HasTeamID {
 get { return hasTeamID; }
 }
 public Int32 TeamID {
 get { return teamID_; }
 set { SetTeamID(value); }
 }
 public void SetTeamID(Int32 value) { 
 hasTeamID = true;
 teamID_ = value;
 }

public const int memberGuidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> memberGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> memberGuidList {
 get { return pbc::Lists.AsReadOnly(memberGuid_); }
 }
 
 public int memberGuidCount {
 get { return memberGuid_.Count; }
 }
 
public UInt64 GetMemberGuid(int index) {
 return memberGuid_[index];
 }
 public void AddMemberGuid(UInt64 value) {
 memberGuid_.Add(value);
 }

public const int memberNameFieldNumber = 3;
 private pbc::PopsicleList<string> memberName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> memberNameList {
 get { return pbc::Lists.AsReadOnly(memberName_); }
 }
 
 public int memberNameCount {
 get { return memberName_.Count; }
 }
 
public string GetMemberName(int index) {
 return memberName_[index];
 }
 public void AddMemberName(string value) {
 memberName_.Add(value);
 }

public const int memberLevelFieldNumber = 4;
 private pbc::PopsicleList<Int32> memberLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberLevelList {
 get { return pbc::Lists.AsReadOnly(memberLevel_); }
 }
 
 public int memberLevelCount {
 get { return memberLevel_.Count; }
 }
 
public Int32 GetMemberLevel(int index) {
 return memberLevel_[index];
 }
 public void AddMemberLevel(Int32 value) {
 memberLevel_.Add(value);
 }

public const int memberProfFieldNumber = 5;
 private pbc::PopsicleList<Int32> memberProf_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberProfList {
 get { return pbc::Lists.AsReadOnly(memberProf_); }
 }
 
 public int memberProfCount {
 get { return memberProf_.Count; }
 }
 
public Int32 GetMemberProf(int index) {
 return memberProf_[index];
 }
 public void AddMemberProf(Int32 value) {
 memberProf_.Add(value);
 }

public const int memberHPFieldNumber = 6;
 private pbc::PopsicleList<Int32> memberHP_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberHPList {
 get { return pbc::Lists.AsReadOnly(memberHP_); }
 }
 
 public int memberHPCount {
 get { return memberHP_.Count; }
 }
 
public Int32 GetMemberHP(int index) {
 return memberHP_[index];
 }
 public void AddMemberHP(Int32 value) {
 memberHP_.Add(value);
 }

public const int memberMaxHPFieldNumber = 7;
 private pbc::PopsicleList<Int32> memberMaxHP_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberMaxHPList {
 get { return pbc::Lists.AsReadOnly(memberMaxHP_); }
 }
 
 public int memberMaxHPCount {
 get { return memberMaxHP_.Count; }
 }
 
public Int32 GetMemberMaxHP(int index) {
 return memberMaxHP_[index];
 }
 public void AddMemberMaxHP(Int32 value) {
 memberMaxHP_.Add(value);
 }

public const int memberCombatFieldNumber = 8;
 private pbc::PopsicleList<Int32> memberCombat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberCombatList {
 get { return pbc::Lists.AsReadOnly(memberCombat_); }
 }
 
 public int memberCombatCount {
 get { return memberCombat_.Count; }
 }
 
public Int32 GetMemberCombat(int index) {
 return memberCombat_[index];
 }
 public void AddMemberCombat(Int32 value) {
 memberCombat_.Add(value);
 }

public const int sceneclassFieldNumber = 9;
 private pbc::PopsicleList<Int32> sceneclass_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sceneclassList {
 get { return pbc::Lists.AsReadOnly(sceneclass_); }
 }
 
 public int sceneclassCount {
 get { return sceneclass_.Count; }
 }
 
public Int32 GetSceneclass(int index) {
 return sceneclass_[index];
 }
 public void AddSceneclass(Int32 value) {
 sceneclass_.Add(value);
 }

public const int sceneinstFieldNumber = 10;
 private pbc::PopsicleList<Int32> sceneinst_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sceneinstList {
 get { return pbc::Lists.AsReadOnly(sceneinst_); }
 }
 
 public int sceneinstCount {
 get { return sceneinst_.Count; }
 }
 
public Int32 GetSceneinst(int index) {
 return sceneinst_[index];
 }
 public void AddSceneinst(Int32 value) {
 sceneinst_.Add(value);
 }

public const int posXFieldNumber = 11;
 private pbc::PopsicleList<Int32> posX_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posXList {
 get { return pbc::Lists.AsReadOnly(posX_); }
 }
 
 public int posXCount {
 get { return posX_.Count; }
 }
 
public Int32 GetPosX(int index) {
 return posX_[index];
 }
 public void AddPosX(Int32 value) {
 posX_.Add(value);
 }

public const int posZFieldNumber = 12;
 private pbc::PopsicleList<Int32> posZ_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posZList {
 get { return pbc::Lists.AsReadOnly(posZ_); }
 }
 
 public int posZCount {
 get { return posZ_.Count; }
 }
 
public Int32 GetPosZ(int index) {
 return posZ_[index];
 }
 public void AddPosZ(Int32 value) {
 posZ_.Add(value);
 }

public const int ModelVisualIdFieldNumber = 13;
 private pbc::PopsicleList<Int32> ModelVisualId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ModelVisualIdList {
 get { return pbc::Lists.AsReadOnly(ModelVisualId_); }
 }
 
 public int ModelVisualIdCount {
 get { return ModelVisualId_.Count; }
 }
 
public Int32 GetModelVisualId(int index) {
 return ModelVisualId_[index];
 }
 public void AddModelVisualId(Int32 value) {
 ModelVisualId_.Add(value);
 }

public const int WeaponDataIdFieldNumber = 14;
 private pbc::PopsicleList<Int32> WeaponDataId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> WeaponDataIdList {
 get { return pbc::Lists.AsReadOnly(WeaponDataId_); }
 }
 
 public int WeaponDataIdCount {
 get { return WeaponDataId_.Count; }
 }
 
public Int32 GetWeaponDataId(int index) {
 return WeaponDataId_[index];
 }
 public void AddWeaponDataId(Int32 value) {
 WeaponDataId_.Add(value);
 }

public const int WeaponEffectGemFieldNumber = 15;
 private pbc::PopsicleList<Int32> WeaponEffectGem_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> WeaponEffectGemList {
 get { return pbc::Lists.AsReadOnly(WeaponEffectGem_); }
 }
 
 public int WeaponEffectGemCount {
 get { return WeaponEffectGem_.Count; }
 }
 
public Int32 GetWeaponEffectGem(int index) {
 return WeaponEffectGem_[index];
 }
 public void AddWeaponEffectGem(Int32 value) {
 WeaponEffectGem_.Add(value);
 }

public const int teamCJGTierFieldNumber = 16;
 private pbc::PopsicleList<Int32> teamCJGTier_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> teamCJGTierList {
 get { return pbc::Lists.AsReadOnly(teamCJGTier_); }
 }
 
 public int teamCJGTierCount {
 get { return teamCJGTier_.Count; }
 }
 
public Int32 GetTeamCJGTier(int index) {
 return teamCJGTier_[index];
 }
 public void AddTeamCJGTier(Int32 value) {
 teamCJGTier_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTeamID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TeamID);
}
{
int dataSize = 0;
for(int i=0; i<memberGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(memberGuidList[i]);
}
size += dataSize;
size += 1 * memberGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(memberNameList[i]);
}
size += dataSize;
size += 1 * memberName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberLevelList[i]);
}
size += dataSize;
size += 1 * memberLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberProfList[i]);
}
size += dataSize;
size += 1 * memberProf_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberHPList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberHPList[i]);
}
size += dataSize;
size += 1 * memberHP_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberMaxHPList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberMaxHPList[i]);
}
size += dataSize;
size += 1 * memberMaxHP_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberCombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberCombatList[i]);
}
size += dataSize;
size += 1 * memberCombat_.Count;
}
{
int dataSize = 0;
for(int i=0; i<sceneclassList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sceneclassList[i]);
}
size += dataSize;
size += 1 * sceneclass_.Count;
}
{
int dataSize = 0;
for(int i=0; i<sceneinstList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sceneinstList[i]);
}
size += dataSize;
size += 1 * sceneinst_.Count;
}
{
int dataSize = 0;
for(int i=0; i<posXList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posXList[i]);
}
size += dataSize;
size += 1 * posX_.Count;
}
{
int dataSize = 0;
for(int i=0; i<posZList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posZList[i]);
}
size += dataSize;
size += 1 * posZ_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ModelVisualIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ModelVisualIdList[i]);
}
size += dataSize;
size += 1 * ModelVisualId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<WeaponDataIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(WeaponDataIdList[i]);
}
size += dataSize;
size += 1 * WeaponDataId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<WeaponEffectGemList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(WeaponEffectGemList[i]);
}
size += dataSize;
size += 1 * WeaponEffectGem_.Count;
}
{
int dataSize = 0;
for(int i=0; i<teamCJGTierList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(teamCJGTierList[i]);
}
size += dataSize;
size += 1 * teamCJGTier_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTeamID) {
output.WriteInt32(1, TeamID);
}
{
if (memberGuid_.Count > 0) {
for(int i=0; i<memberGuid_.Count; ++i){
output.WriteUInt64(2,memberGuid_[i]);
}
}

}
{
if (memberName_.Count > 0) {
for(int i=0; i<memberName_.Count; ++i){
output.WriteString(3,memberName_[i]);
}
}

}
{
if (memberLevel_.Count > 0) {
for(int i=0; i<memberLevel_.Count; ++i){
output.WriteInt32(4,memberLevel_[i]);
}
}

}
{
if (memberProf_.Count > 0) {
for(int i=0; i<memberProf_.Count; ++i){
output.WriteInt32(5,memberProf_[i]);
}
}

}
{
if (memberHP_.Count > 0) {
for(int i=0; i<memberHP_.Count; ++i){
output.WriteInt32(6,memberHP_[i]);
}
}

}
{
if (memberMaxHP_.Count > 0) {
for(int i=0; i<memberMaxHP_.Count; ++i){
output.WriteInt32(7,memberMaxHP_[i]);
}
}

}
{
if (memberCombat_.Count > 0) {
for(int i=0; i<memberCombat_.Count; ++i){
output.WriteInt32(8,memberCombat_[i]);
}
}

}
{
if (sceneclass_.Count > 0) {
for(int i=0; i<sceneclass_.Count; ++i){
output.WriteInt32(9,sceneclass_[i]);
}
}

}
{
if (sceneinst_.Count > 0) {
for(int i=0; i<sceneinst_.Count; ++i){
output.WriteInt32(10,sceneinst_[i]);
}
}

}
{
if (posX_.Count > 0) {
for(int i=0; i<posX_.Count; ++i){
output.WriteInt32(11,posX_[i]);
}
}

}
{
if (posZ_.Count > 0) {
for(int i=0; i<posZ_.Count; ++i){
output.WriteInt32(12,posZ_[i]);
}
}

}
{
if (ModelVisualId_.Count > 0) {
for(int i=0; i<ModelVisualId_.Count; ++i){
output.WriteInt32(13,ModelVisualId_[i]);
}
}

}
{
if (WeaponDataId_.Count > 0) {
for(int i=0; i<WeaponDataId_.Count; ++i){
output.WriteInt32(14,WeaponDataId_[i]);
}
}

}
{
if (WeaponEffectGem_.Count > 0) {
for(int i=0; i<WeaponEffectGem_.Count; ++i){
output.WriteInt32(15,WeaponEffectGem_[i]);
}
}

}
{
if (teamCJGTier_.Count > 0) {
for(int i=0; i<teamCJGTier_.Count; ++i){
output.WriteInt32(16,teamCJGTier_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_TEAM_SYNC_TEAMINFO _inst = (GC_TEAM_SYNC_TEAMINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TeamID = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddMemberGuid(input.ReadUInt64());
break;
}
   case  26: {
 _inst.AddMemberName(input.ReadString());
break;
}
   case  32: {
 _inst.AddMemberLevel(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddMemberProf(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddMemberHP(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddMemberMaxHP(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddMemberCombat(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddSceneclass(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddSceneinst(input.ReadInt32());
break;
}
   case  88: {
 _inst.AddPosX(input.ReadInt32());
break;
}
   case  96: {
 _inst.AddPosZ(input.ReadInt32());
break;
}
   case  104: {
 _inst.AddModelVisualId(input.ReadInt32());
break;
}
   case  112: {
 _inst.AddWeaponDataId(input.ReadInt32());
break;
}
   case  120: {
 _inst.AddWeaponEffectGem(input.ReadInt32());
break;
}
   case  128: {
 _inst.AddTeamCJGTier(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTeamID) return false;
 return true;
 }

}


[Serializable]
public class GC_TEAM_SYNC_MEMBERINFO : PacketDistributed
{

public const int indexFieldNumber = 1;
 private bool hasIndex;
 private Int32 index_ = 0;
 public bool HasIndex {
 get { return hasIndex; }
 }
 public Int32 Index {
 get { return index_; }
 set { SetIndex(value); }
 }
 public void SetIndex(Int32 value) { 
 hasIndex = true;
 index_ = value;
 }

public const int memberGuidFieldNumber = 2;
 private bool hasMemberGuid;
 private UInt64 memberGuid_ = 0;
 public bool HasMemberGuid {
 get { return hasMemberGuid; }
 }
 public UInt64 MemberGuid {
 get { return memberGuid_; }
 set { SetMemberGuid(value); }
 }
 public void SetMemberGuid(UInt64 value) { 
 hasMemberGuid = true;
 memberGuid_ = value;
 }

public const int memberNameFieldNumber = 3;
 private bool hasMemberName;
 private string memberName_ = "";
 public bool HasMemberName {
 get { return hasMemberName; }
 }
 public string MemberName {
 get { return memberName_; }
 set { SetMemberName(value); }
 }
 public void SetMemberName(string value) { 
 hasMemberName = true;
 memberName_ = value;
 }

public const int memberLevelFieldNumber = 4;
 private bool hasMemberLevel;
 private Int32 memberLevel_ = 0;
 public bool HasMemberLevel {
 get { return hasMemberLevel; }
 }
 public Int32 MemberLevel {
 get { return memberLevel_; }
 set { SetMemberLevel(value); }
 }
 public void SetMemberLevel(Int32 value) { 
 hasMemberLevel = true;
 memberLevel_ = value;
 }

public const int memberProfFieldNumber = 5;
 private bool hasMemberProf;
 private Int32 memberProf_ = 0;
 public bool HasMemberProf {
 get { return hasMemberProf; }
 }
 public Int32 MemberProf {
 get { return memberProf_; }
 set { SetMemberProf(value); }
 }
 public void SetMemberProf(Int32 value) { 
 hasMemberProf = true;
 memberProf_ = value;
 }

public const int memberHPFieldNumber = 6;
 private bool hasMemberHP;
 private Int32 memberHP_ = 0;
 public bool HasMemberHP {
 get { return hasMemberHP; }
 }
 public Int32 MemberHP {
 get { return memberHP_; }
 set { SetMemberHP(value); }
 }
 public void SetMemberHP(Int32 value) { 
 hasMemberHP = true;
 memberHP_ = value;
 }

public const int memberMaxHPFieldNumber = 7;
 private bool hasMemberMaxHP;
 private Int32 memberMaxHP_ = 0;
 public bool HasMemberMaxHP {
 get { return hasMemberMaxHP; }
 }
 public Int32 MemberMaxHP {
 get { return memberMaxHP_; }
 set { SetMemberMaxHP(value); }
 }
 public void SetMemberMaxHP(Int32 value) { 
 hasMemberMaxHP = true;
 memberMaxHP_ = value;
 }

public const int memberCombatFieldNumber = 8;
 private bool hasMemberCombat;
 private Int32 memberCombat_ = 0;
 public bool HasMemberCombat {
 get { return hasMemberCombat; }
 }
 public Int32 MemberCombat {
 get { return memberCombat_; }
 set { SetMemberCombat(value); }
 }
 public void SetMemberCombat(Int32 value) { 
 hasMemberCombat = true;
 memberCombat_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Index);
}
 if (HasMemberGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, MemberGuid);
}
 if (HasMemberName) {
size += pb::CodedOutputStream.ComputeStringSize(3, MemberName);
}
 if (HasMemberLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(4, MemberLevel);
}
 if (HasMemberProf) {
size += pb::CodedOutputStream.ComputeInt32Size(5, MemberProf);
}
 if (HasMemberHP) {
size += pb::CodedOutputStream.ComputeInt32Size(6, MemberHP);
}
 if (HasMemberMaxHP) {
size += pb::CodedOutputStream.ComputeInt32Size(7, MemberMaxHP);
}
 if (HasMemberCombat) {
size += pb::CodedOutputStream.ComputeInt32Size(8, MemberCombat);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasIndex) {
output.WriteInt32(1, Index);
}
 
if (HasMemberGuid) {
output.WriteUInt64(2, MemberGuid);
}
 
if (HasMemberName) {
output.WriteString(3, MemberName);
}
 
if (HasMemberLevel) {
output.WriteInt32(4, MemberLevel);
}
 
if (HasMemberProf) {
output.WriteInt32(5, MemberProf);
}
 
if (HasMemberHP) {
output.WriteInt32(6, MemberHP);
}
 
if (HasMemberMaxHP) {
output.WriteInt32(7, MemberMaxHP);
}
 
if (HasMemberCombat) {
output.WriteInt32(8, MemberCombat);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_TEAM_SYNC_MEMBERINFO _inst = (GC_TEAM_SYNC_MEMBERINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Index = input.ReadInt32();
break;
}
   case  16: {
 _inst.MemberGuid = input.ReadUInt64();
break;
}
   case  26: {
 _inst.MemberName = input.ReadString();
break;
}
   case  32: {
 _inst.MemberLevel = input.ReadInt32();
break;
}
   case  40: {
 _inst.MemberProf = input.ReadInt32();
break;
}
   case  48: {
 _inst.MemberHP = input.ReadInt32();
break;
}
   case  56: {
 _inst.MemberMaxHP = input.ReadInt32();
break;
}
   case  64: {
 _inst.MemberCombat = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasIndex) return false;
 if (!hasMemberHP) return false;
 if (!hasMemberMaxHP) return false;
 return true;
 }

}


[Serializable]
public class GC_JOIN_TEAM_INVITE : PacketDistributed
{

public const int inviterGuidFieldNumber = 1;
 private bool hasInviterGuid;
 private UInt64 inviterGuid_ = 0;
 public bool HasInviterGuid {
 get { return hasInviterGuid; }
 }
 public UInt64 InviterGuid {
 get { return inviterGuid_; }
 set { SetInviterGuid(value); }
 }
 public void SetInviterGuid(UInt64 value) { 
 hasInviterGuid = true;
 inviterGuid_ = value;
 }

public const int inviterNameFieldNumber = 2;
 private bool hasInviterName;
 private string inviterName_ = "";
 public bool HasInviterName {
 get { return hasInviterName; }
 }
 public string InviterName {
 get { return inviterName_; }
 set { SetInviterName(value); }
 }
 public void SetInviterName(string value) { 
 hasInviterName = true;
 inviterName_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasInviterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, InviterGuid);
}
 if (HasInviterName) {
size += pb::CodedOutputStream.ComputeStringSize(2, InviterName);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasInviterGuid) {
output.WriteUInt64(1, InviterGuid);
}
 
if (HasInviterName) {
output.WriteString(2, InviterName);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_JOIN_TEAM_INVITE _inst = (GC_JOIN_TEAM_INVITE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.InviterGuid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.InviterName = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasInviterGuid) return false;
 if (!hasInviterName) return false;
 return true;
 }

}


[Serializable]
public class CG_JOIN_TEAM_INVITE_RESULT : PacketDistributed
{

public const int inviterGuidFieldNumber = 1;
 private bool hasInviterGuid;
 private UInt64 inviterGuid_ = 0;
 public bool HasInviterGuid {
 get { return hasInviterGuid; }
 }
 public UInt64 InviterGuid {
 get { return inviterGuid_; }
 set { SetInviterGuid(value); }
 }
 public void SetInviterGuid(UInt64 value) { 
 hasInviterGuid = true;
 inviterGuid_ = value;
 }

public const int resultFieldNumber = 2;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasInviterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, InviterGuid);
}
 if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Result);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasInviterGuid) {
output.WriteUInt64(1, InviterGuid);
}
 
if (HasResult) {
output.WriteInt32(2, Result);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_JOIN_TEAM_INVITE_RESULT _inst = (CG_JOIN_TEAM_INVITE_RESULT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.InviterGuid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.Result = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasInviterGuid) return false;
 if (!hasResult) return false;
 return true;
 }

}


[Serializable]
public class GC_JOIN_TEAM_REQUEST : PacketDistributed
{

public const int requesterGuidFieldNumber = 1;
 private bool hasRequesterGuid;
 private UInt64 requesterGuid_ = 0;
 public bool HasRequesterGuid {
 get { return hasRequesterGuid; }
 }
 public UInt64 RequesterGuid {
 get { return requesterGuid_; }
 set { SetRequesterGuid(value); }
 }
 public void SetRequesterGuid(UInt64 value) { 
 hasRequesterGuid = true;
 requesterGuid_ = value;
 }

public const int requesterNameFieldNumber = 2;
 private bool hasRequesterName;
 private string requesterName_ = "";
 public bool HasRequesterName {
 get { return hasRequesterName; }
 }
 public string RequesterName {
 get { return requesterName_; }
 set { SetRequesterName(value); }
 }
 public void SetRequesterName(string value) { 
 hasRequesterName = true;
 requesterName_ = value;
 }

public const int requesterlevelFieldNumber = 3;
 private bool hasRequesterlevel;
 private Int32 requesterlevel_ = 0;
 public bool HasRequesterlevel {
 get { return hasRequesterlevel; }
 }
 public Int32 Requesterlevel {
 get { return requesterlevel_; }
 set { SetRequesterlevel(value); }
 }
 public void SetRequesterlevel(Int32 value) { 
 hasRequesterlevel = true;
 requesterlevel_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequesterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, RequesterGuid);
}
 if (HasRequesterName) {
size += pb::CodedOutputStream.ComputeStringSize(2, RequesterName);
}
 if (HasRequesterlevel) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Requesterlevel);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequesterGuid) {
output.WriteUInt64(1, RequesterGuid);
}
 
if (HasRequesterName) {
output.WriteString(2, RequesterName);
}
 
if (HasRequesterlevel) {
output.WriteInt32(3, Requesterlevel);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_JOIN_TEAM_REQUEST _inst = (GC_JOIN_TEAM_REQUEST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.RequesterGuid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.RequesterName = input.ReadString();
break;
}
   case  24: {
 _inst.Requesterlevel = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequesterGuid) return false;
 if (!hasRequesterName) return false;
 return true;
 }

}


[Serializable]
public class CG_JOIN_TEAM_REQUEST_RESULT : PacketDistributed
{

public const int requesterGuidFieldNumber = 1;
 private bool hasRequesterGuid;
 private UInt64 requesterGuid_ = 0;
 public bool HasRequesterGuid {
 get { return hasRequesterGuid; }
 }
 public UInt64 RequesterGuid {
 get { return requesterGuid_; }
 set { SetRequesterGuid(value); }
 }
 public void SetRequesterGuid(UInt64 value) { 
 hasRequesterGuid = true;
 requesterGuid_ = value;
 }

public const int resultFieldNumber = 2;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

public const int requestnameFieldNumber = 3;
 private bool hasRequestname;
 private string requestname_ = "";
 public bool HasRequestname {
 get { return hasRequestname; }
 }
 public string Requestname {
 get { return requestname_; }
 set { SetRequestname(value); }
 }
 public void SetRequestname(string value) { 
 hasRequestname = true;
 requestname_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequesterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, RequesterGuid);
}
 if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Result);
}
 if (HasRequestname) {
size += pb::CodedOutputStream.ComputeStringSize(3, Requestname);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequesterGuid) {
output.WriteUInt64(1, RequesterGuid);
}
 
if (HasResult) {
output.WriteInt32(2, Result);
}
 
if (HasRequestname) {
output.WriteString(3, Requestname);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_JOIN_TEAM_REQUEST_RESULT _inst = (CG_JOIN_TEAM_REQUEST_RESULT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.RequesterGuid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.Result = input.ReadInt32();
break;
}
   case  26: {
 _inst.Requestname = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequesterGuid) return false;
 if (!hasResult) return false;
 if (!hasRequestname) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_NEAR_LIST : PacketDistributed
{

public const int isNearPlayerListFieldNumber = 1;
 private bool hasIsNearPlayerList;
 private Int32 isNearPlayerList_ = 0;
 public bool HasIsNearPlayerList {
 get { return hasIsNearPlayerList; }
 }
 public Int32 IsNearPlayerList {
 get { return isNearPlayerList_; }
 set { SetIsNearPlayerList(value); }
 }
 public void SetIsNearPlayerList(Int32 value) { 
 hasIsNearPlayerList = true;
 isNearPlayerList_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasIsNearPlayerList) {
size += pb::CodedOutputStream.ComputeInt32Size(1, IsNearPlayerList);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasIsNearPlayerList) {
output.WriteInt32(1, IsNearPlayerList);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_NEAR_LIST _inst = (CG_REQ_NEAR_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.IsNearPlayerList = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasIsNearPlayerList) return false;
 return true;
 }

}


[Serializable]
public class GC_NEAR_PLAYERLIST : PacketDistributed
{

public const int GuidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> Guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> GuidList {
 get { return pbc::Lists.AsReadOnly(Guid_); }
 }
 
 public int GuidCount {
 get { return Guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return Guid_[index];
 }
 public void AddGuid(UInt64 value) {
 Guid_.Add(value);
 }

public const int NameFieldNumber = 2;
 private pbc::PopsicleList<string> Name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> NameList {
 get { return pbc::Lists.AsReadOnly(Name_); }
 }
 
 public int NameCount {
 get { return Name_.Count; }
 }
 
public string GetName(int index) {
 return Name_[index];
 }
 public void AddName(string value) {
 Name_.Add(value);
 }

public const int LevelFieldNumber = 3;
 private pbc::PopsicleList<Int32> Level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> LevelList {
 get { return pbc::Lists.AsReadOnly(Level_); }
 }
 
 public int LevelCount {
 get { return Level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return Level_[index];
 }
 public void AddLevel(Int32 value) {
 Level_.Add(value);
 }

public const int ProfFieldNumber = 4;
 private pbc::PopsicleList<Int32> Prof_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ProfList {
 get { return pbc::Lists.AsReadOnly(Prof_); }
 }
 
 public int ProfCount {
 get { return Prof_.Count; }
 }
 
public Int32 GetProf(int index) {
 return Prof_[index];
 }
 public void AddProf(Int32 value) {
 Prof_.Add(value);
 }

public const int CombatNumFieldNumber = 5;
 private pbc::PopsicleList<Int32> CombatNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> CombatNumList {
 get { return pbc::Lists.AsReadOnly(CombatNum_); }
 }
 
 public int CombatNumCount {
 get { return CombatNum_.Count; }
 }
 
public Int32 GetCombatNum(int index) {
 return CombatNum_[index];
 }
 public void AddCombatNum(Int32 value) {
 CombatNum_.Add(value);
 }

public const int VipLevelFieldNumber = 6;
 private pbc::PopsicleList<Int32> VipLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> VipLevelList {
 get { return pbc::Lists.AsReadOnly(VipLevel_); }
 }
 
 public int VipLevelCount {
 get { return VipLevel_.Count; }
 }
 
public Int32 GetVipLevel(int index) {
 return VipLevel_[index];
 }
 public void AddVipLevel(Int32 value) {
 VipLevel_.Add(value);
 }

public const int GuildNameFieldNumber = 7;
 private pbc::PopsicleList<string> GuildName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> GuildNameList {
 get { return pbc::Lists.AsReadOnly(GuildName_); }
 }
 
 public int GuildNameCount {
 get { return GuildName_.Count; }
 }
 
public string GetGuildName(int index) {
 return GuildName_[index];
 }
 public void AddGuildName(string value) {
 GuildName_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<GuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(GuidList[i]);
}
size += dataSize;
size += 1 * Guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<NameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(NameList[i]);
}
size += dataSize;
size += 1 * Name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<LevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(LevelList[i]);
}
size += dataSize;
size += 1 * Level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ProfList[i]);
}
size += dataSize;
size += 1 * Prof_.Count;
}
{
int dataSize = 0;
for(int i=0; i<CombatNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(CombatNumList[i]);
}
size += dataSize;
size += 1 * CombatNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<VipLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(VipLevelList[i]);
}
size += dataSize;
size += 1 * VipLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<GuildNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(GuildNameList[i]);
}
size += dataSize;
size += 1 * GuildName_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (Guid_.Count > 0) {
for(int i=0; i<Guid_.Count; ++i){
output.WriteUInt64(1,Guid_[i]);
}
}

}
{
if (Name_.Count > 0) {
for(int i=0; i<Name_.Count; ++i){
output.WriteString(2,Name_[i]);
}
}

}
{
if (Level_.Count > 0) {
for(int i=0; i<Level_.Count; ++i){
output.WriteInt32(3,Level_[i]);
}
}

}
{
if (Prof_.Count > 0) {
for(int i=0; i<Prof_.Count; ++i){
output.WriteInt32(4,Prof_[i]);
}
}

}
{
if (CombatNum_.Count > 0) {
for(int i=0; i<CombatNum_.Count; ++i){
output.WriteInt32(5,CombatNum_[i]);
}
}

}
{
if (VipLevel_.Count > 0) {
for(int i=0; i<VipLevel_.Count; ++i){
output.WriteInt32(6,VipLevel_[i]);
}
}

}
{
if (GuildName_.Count > 0) {
for(int i=0; i<GuildName_.Count; ++i){
output.WriteString(7,GuildName_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_NEAR_PLAYERLIST _inst = (GC_NEAR_PLAYERLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddName(input.ReadString());
break;
}
   case  24: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddProf(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddCombatNum(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddVipLevel(input.ReadInt32());
break;
}
   case  58: {
 _inst.AddGuildName(input.ReadString());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_NEAR_TEAMLIST : PacketDistributed
{

public const int GuidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> Guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> GuidList {
 get { return pbc::Lists.AsReadOnly(Guid_); }
 }
 
 public int GuidCount {
 get { return Guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return Guid_[index];
 }
 public void AddGuid(UInt64 value) {
 Guid_.Add(value);
 }

public const int NameFieldNumber = 2;
 private pbc::PopsicleList<string> Name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> NameList {
 get { return pbc::Lists.AsReadOnly(Name_); }
 }
 
 public int NameCount {
 get { return Name_.Count; }
 }
 
public string GetName(int index) {
 return Name_[index];
 }
 public void AddName(string value) {
 Name_.Add(value);
 }

public const int LevelFieldNumber = 3;
 private pbc::PopsicleList<Int32> Level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> LevelList {
 get { return pbc::Lists.AsReadOnly(Level_); }
 }
 
 public int LevelCount {
 get { return Level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return Level_[index];
 }
 public void AddLevel(Int32 value) {
 Level_.Add(value);
 }

public const int ProfFieldNumber = 4;
 private pbc::PopsicleList<Int32> Prof_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ProfList {
 get { return pbc::Lists.AsReadOnly(Prof_); }
 }
 
 public int ProfCount {
 get { return Prof_.Count; }
 }
 
public Int32 GetProf(int index) {
 return Prof_[index];
 }
 public void AddProf(Int32 value) {
 Prof_.Add(value);
 }

public const int CombatNumFieldNumber = 5;
 private pbc::PopsicleList<Int32> CombatNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> CombatNumList {
 get { return pbc::Lists.AsReadOnly(CombatNum_); }
 }
 
 public int CombatNumCount {
 get { return CombatNum_.Count; }
 }
 
public Int32 GetCombatNum(int index) {
 return CombatNum_[index];
 }
 public void AddCombatNum(Int32 value) {
 CombatNum_.Add(value);
 }

public const int TeamIDFieldNumber = 6;
 private pbc::PopsicleList<Int32> TeamID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> TeamIDList {
 get { return pbc::Lists.AsReadOnly(TeamID_); }
 }
 
 public int TeamIDCount {
 get { return TeamID_.Count; }
 }
 
public Int32 GetTeamID(int index) {
 return TeamID_[index];
 }
 public void AddTeamID(Int32 value) {
 TeamID_.Add(value);
 }

public const int TeamCombatFieldNumber = 7;
 private pbc::PopsicleList<Int32> TeamCombat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> TeamCombatList {
 get { return pbc::Lists.AsReadOnly(TeamCombat_); }
 }
 
 public int TeamCombatCount {
 get { return TeamCombat_.Count; }
 }
 
public Int32 GetTeamCombat(int index) {
 return TeamCombat_[index];
 }
 public void AddTeamCombat(Int32 value) {
 TeamCombat_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<GuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(GuidList[i]);
}
size += dataSize;
size += 1 * Guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<NameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(NameList[i]);
}
size += dataSize;
size += 1 * Name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<LevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(LevelList[i]);
}
size += dataSize;
size += 1 * Level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ProfList[i]);
}
size += dataSize;
size += 1 * Prof_.Count;
}
{
int dataSize = 0;
for(int i=0; i<CombatNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(CombatNumList[i]);
}
size += dataSize;
size += 1 * CombatNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<TeamIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(TeamIDList[i]);
}
size += dataSize;
size += 1 * TeamID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<TeamCombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(TeamCombatList[i]);
}
size += dataSize;
size += 1 * TeamCombat_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (Guid_.Count > 0) {
for(int i=0; i<Guid_.Count; ++i){
output.WriteUInt64(1,Guid_[i]);
}
}

}
{
if (Name_.Count > 0) {
for(int i=0; i<Name_.Count; ++i){
output.WriteString(2,Name_[i]);
}
}

}
{
if (Level_.Count > 0) {
for(int i=0; i<Level_.Count; ++i){
output.WriteInt32(3,Level_[i]);
}
}

}
{
if (Prof_.Count > 0) {
for(int i=0; i<Prof_.Count; ++i){
output.WriteInt32(4,Prof_[i]);
}
}

}
{
if (CombatNum_.Count > 0) {
for(int i=0; i<CombatNum_.Count; ++i){
output.WriteInt32(5,CombatNum_[i]);
}
}

}
{
if (TeamID_.Count > 0) {
for(int i=0; i<TeamID_.Count; ++i){
output.WriteInt32(6,TeamID_[i]);
}
}

}
{
if (TeamCombat_.Count > 0) {
for(int i=0; i<TeamCombat_.Count; ++i){
output.WriteInt32(7,TeamCombat_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_NEAR_TEAMLIST _inst = (GC_NEAR_TEAMLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddName(input.ReadString());
break;
}
   case  24: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddProf(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddCombatNum(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddTeamID(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddTeamCombat(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_USE_ITEM : PacketDistributed
{

public const int itemguidFieldNumber = 1;
 private bool hasItemguid;
 private UInt64 itemguid_ = 0;
 public bool HasItemguid {
 get { return hasItemguid; }
 }
 public UInt64 Itemguid {
 get { return itemguid_; }
 set { SetItemguid(value); }
 }
 public void SetItemguid(UInt64 value) { 
 hasItemguid = true;
 itemguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasItemguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Itemguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasItemguid) {
output.WriteUInt64(1, Itemguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_USE_ITEM _inst = (CG_USE_ITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Itemguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasItemguid) return false;
 return true;
 }

}


[Serializable]
public class CG_EQUIP_ITEM : PacketDistributed
{

public const int equipguidFieldNumber = 1;
 private bool hasEquipguid;
 private UInt64 equipguid_ = 0;
 public bool HasEquipguid {
 get { return hasEquipguid; }
 }
 public UInt64 Equipguid {
 get { return equipguid_; }
 set { SetEquipguid(value); }
 }
 public void SetEquipguid(UInt64 value) { 
 hasEquipguid = true;
 equipguid_ = value;
 }

public const int IsEquipRemindFieldNumber = 2;
 private bool hasIsEquipRemind;
 private Int32 IsEquipRemind_ = 0;
 public bool HasIsEquipRemind {
 get { return hasIsEquipRemind; }
 }
 public Int32 IsEquipRemind {
 get { return IsEquipRemind_; }
 set { SetIsEquipRemind(value); }
 }
 public void SetIsEquipRemind(Int32 value) { 
 hasIsEquipRemind = true;
 IsEquipRemind_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasEquipguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Equipguid);
}
 if (HasIsEquipRemind) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsEquipRemind);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasEquipguid) {
output.WriteUInt64(1, Equipguid);
}
 
if (HasIsEquipRemind) {
output.WriteInt32(2, IsEquipRemind);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_EQUIP_ITEM _inst = (CG_EQUIP_ITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Equipguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.IsEquipRemind = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasEquipguid) return false;
 return true;
 }

}


[Serializable]
public class CG_UNEQUIP_ITEM : PacketDistributed
{

public const int equipguidFieldNumber = 1;
 private bool hasEquipguid;
 private UInt64 equipguid_ = 0;
 public bool HasEquipguid {
 get { return hasEquipguid; }
 }
 public UInt64 Equipguid {
 get { return equipguid_; }
 set { SetEquipguid(value); }
 }
 public void SetEquipguid(UInt64 value) { 
 hasEquipguid = true;
 equipguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasEquipguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Equipguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasEquipguid) {
output.WriteUInt64(1, Equipguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_UNEQUIP_ITEM _inst = (CG_UNEQUIP_ITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Equipguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasEquipguid) return false;
 return true;
 }

}


[Serializable]
public class CG_CREATEROLE : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int nameFieldNumber = 2;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(2, Name);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 
if (HasName) {
output.WriteString(2, Name);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CREATEROLE _inst = (CG_CREATEROLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}
   case  18: {
 _inst.Name = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 if (!hasName) return false;
 return true;
 }

}


[Serializable]
public class GC_CREATEROLE_RET : PacketDistributed
{
public enum CREATEROLE_RESULT 
 { 
  CREATEROLE_SUCCESS    = 0,  // ��������ɹ� 
  CREATEROLE_FAIL    = 1,  // �������ڲ����� 
  CREATEROLE_FAIL_NAMEEXIST  = 2,  // �����Ѿ����� 
  CREATEROLE_FAIL_NAMESCREENING  = 3,  // ���ֺ��������� 
  CREATEROLE_FAIL_LONGNAME  = 4,  // ����̫�� 
 
 
 }
public const int resultFieldNumber = 1;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

public const int professionFieldNumber = 2;
 private bool hasProfession;
 private Int32 profession_ = 0;
 public bool HasProfession {
 get { return hasProfession; }
 }
 public Int32 Profession {
 get { return profession_; }
 set { SetProfession(value); }
 }
 public void SetProfession(Int32 value) { 
 hasProfession = true;
 profession_ = value;
 }

public const int playerGuidFieldNumber = 3;
 private bool hasPlayerGuid;
 private UInt64 playerGuid_ = 0;
 public bool HasPlayerGuid {
 get { return hasPlayerGuid; }
 }
 public UInt64 PlayerGuid {
 get { return playerGuid_; }
 set { SetPlayerGuid(value); }
 }
 public void SetPlayerGuid(UInt64 value) { 
 hasPlayerGuid = true;
 playerGuid_ = value;
 }

public const int playerNameFieldNumber = 4;
 private bool hasPlayerName;
 private string playerName_ = "";
 public bool HasPlayerName {
 get { return hasPlayerName; }
 }
 public string PlayerName {
 get { return playerName_; }
 set { SetPlayerName(value); }
 }
 public void SetPlayerName(string value) { 
 hasPlayerName = true;
 playerName_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 if (HasProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Profession);
}
 if (HasPlayerGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, PlayerGuid);
}
 if (HasPlayerName) {
size += pb::CodedOutputStream.ComputeStringSize(4, PlayerName);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 
if (HasProfession) {
output.WriteInt32(2, Profession);
}
 
if (HasPlayerGuid) {
output.WriteUInt64(3, PlayerGuid);
}
 
if (HasPlayerName) {
output.WriteString(4, PlayerName);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CREATEROLE_RET _inst = (GC_CREATEROLE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.Profession = input.ReadInt32();
break;
}
   case  24: {
 _inst.PlayerGuid = input.ReadUInt64();
break;
}
   case  34: {
 _inst.PlayerName = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 if (!hasProfession) return false;
 if (!hasPlayerGuid) return false;
 if (!hasPlayerName) return false;
 return true;
 }

}


[Serializable]
public class CG_SELECTROLE : PacketDistributed
{

public const int roleGUIDFieldNumber = 1;
 private bool hasRoleGUID;
 private UInt64 roleGUID_ = 0;
 public bool HasRoleGUID {
 get { return hasRoleGUID; }
 }
 public UInt64 RoleGUID {
 get { return roleGUID_; }
 set { SetRoleGUID(value); }
 }
 public void SetRoleGUID(UInt64 value) { 
 hasRoleGUID = true;
 roleGUID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRoleGUID) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, RoleGUID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRoleGUID) {
output.WriteUInt64(1, RoleGUID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_SELECTROLE _inst = (CG_SELECTROLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.RoleGUID = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRoleGUID) return false;
 return true;
 }

}


[Serializable]
public class GC_SELECTROLE_RET : PacketDistributed
{
public enum SELECTROLE_RESULT 
 { 
  SELECTROLE_SUCCESS  = 0, 
  SELECTROLE_FAIL   = 1, 
 }
public const int resultFieldNumber = 1;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

public const int playerGuidFieldNumber = 2;
 private bool hasPlayerGuid;
 private UInt64 playerGuid_ = 0;
 public bool HasPlayerGuid {
 get { return hasPlayerGuid; }
 }
 public UInt64 PlayerGuid {
 get { return playerGuid_; }
 set { SetPlayerGuid(value); }
 }
 public void SetPlayerGuid(UInt64 value) { 
 hasPlayerGuid = true;
 playerGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 if (HasPlayerGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, PlayerGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 
if (HasPlayerGuid) {
output.WriteUInt64(2, PlayerGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SELECTROLE_RET _inst = (GC_SELECTROLE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.PlayerGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 if (!hasPlayerGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_SKILL_USE : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

public const int targetIdFieldNumber = 2;
 private bool hasTargetId;
 private Int32 targetId_ = 0;
 public bool HasTargetId {
 get { return hasTargetId; }
 }
 public Int32 TargetId {
 get { return targetId_; }
 set { SetTargetId(value); }
 }
 public void SetTargetId(Int32 value) { 
 hasTargetId = true;
 targetId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 if (HasTargetId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, TargetId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 
if (HasTargetId) {
output.WriteInt32(2, TargetId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_SKILL_USE _inst = (CG_SKILL_USE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}
   case  16: {
 _inst.TargetId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 if (!hasTargetId) return false;
 return true;
 }

}


[Serializable]
public class GC_CDTIME_UPDATE : PacketDistributed
{

public const int CDTimeIdFieldNumber = 1;
 private bool hasCDTimeId;
 private Int32 CDTimeId_ = 0;
 public bool HasCDTimeId {
 get { return hasCDTimeId; }
 }
 public Int32 CDTimeId {
 get { return CDTimeId_; }
 set { SetCDTimeId(value); }
 }
 public void SetCDTimeId(Int32 value) { 
 hasCDTimeId = true;
 CDTimeId_ = value;
 }

public const int CDTimeFieldNumber = 2;
 private bool hasCDTime;
 private Int32 CDTime_ = 0;
 public bool HasCDTime {
 get { return hasCDTime; }
 }
 public Int32 CDTime {
 get { return CDTime_; }
 set { SetCDTime(value); }
 }
 public void SetCDTime(Int32 value) { 
 hasCDTime = true;
 CDTime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCDTimeId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, CDTimeId);
}
 if (HasCDTime) {
size += pb::CodedOutputStream.ComputeInt32Size(2, CDTime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCDTimeId) {
output.WriteInt32(1, CDTimeId);
}
 
if (HasCDTime) {
output.WriteInt32(2, CDTime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CDTIME_UPDATE _inst = (GC_CDTIME_UPDATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.CDTimeId = input.ReadInt32();
break;
}
   case  16: {
 _inst.CDTime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCDTimeId) return false;
 if (!hasCDTime) return false;
 return true;
 }

}


[Serializable]
public class GC_BROADCAST_ATTR : PacketDistributed
{

public const int ObjIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 ObjId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return ObjId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 ObjId_ = value;
 }

public const int CurProfessionFieldNumber = 2;
 private bool hasCurProfession;
 private Int32 CurProfession_ = 0;
 public bool HasCurProfession {
 get { return hasCurProfession; }
 }
 public Int32 CurProfession {
 get { return CurProfession_; }
 set { SetCurProfession(value); }
 }
 public void SetCurProfession(Int32 value) { 
 hasCurProfession = true;
 CurProfession_ = value;
 }

public const int NameFieldNumber = 3;
 private bool hasName;
 private string Name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return Name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 Name_ = value;
 }

public const int CurForceFieldNumber = 4;
 private bool hasCurForce;
 private Int32 CurForce_ = 0;
 public bool HasCurForce {
 get { return hasCurForce; }
 }
 public Int32 CurForce {
 get { return CurForce_; }
 set { SetCurForce(value); }
 }
 public void SetCurForce(Int32 value) { 
 hasCurForce = true;
 CurForce_ = value;
 }

public const int MoveSpeedFieldNumber = 5;
 private bool hasMoveSpeed;
 private Int32 MoveSpeed_ = 0;
 public bool HasMoveSpeed {
 get { return hasMoveSpeed; }
 }
 public Int32 MoveSpeed {
 get { return MoveSpeed_; }
 set { SetMoveSpeed(value); }
 }
 public void SetMoveSpeed(Int32 value) { 
 hasMoveSpeed = true;
 MoveSpeed_ = value;
 }

public const int bDieFieldNumber = 6;
 private bool hasBDie;
 private Int32 bDie_ = 0;
 public bool HasBDie {
 get { return hasBDie; }
 }
 public Int32 BDie {
 get { return bDie_; }
 set { SetBDie(value); }
 }
 public void SetBDie(Int32 value) { 
 hasBDie = true;
 bDie_ = value;
 }

public const int faceDirFieldNumber = 7;
 private bool hasFaceDir;
 private Int32 faceDir_ = 0;
 public bool HasFaceDir {
 get { return hasFaceDir; }
 }
 public Int32 FaceDir {
 get { return faceDir_; }
 set { SetFaceDir(value); }
 }
 public void SetFaceDir(Int32 value) { 
 hasFaceDir = true;
 faceDir_ = value;
 }

public const int ModelVisualIDFieldNumber = 8;
 private bool hasModelVisualID;
 private Int32 ModelVisualID_ = 0;
 public bool HasModelVisualID {
 get { return hasModelVisualID; }
 }
 public Int32 ModelVisualID {
 get { return ModelVisualID_; }
 set { SetModelVisualID(value); }
 }
 public void SetModelVisualID(Int32 value) { 
 hasModelVisualID = true;
 ModelVisualID_ = value;
 }

public const int WeaponDataIDFieldNumber = 9;
 private bool hasWeaponDataID;
 private Int32 WeaponDataID_ = 0;
 public bool HasWeaponDataID {
 get { return hasWeaponDataID; }
 }
 public Int32 WeaponDataID {
 get { return WeaponDataID_; }
 set { SetWeaponDataID(value); }
 }
 public void SetWeaponDataID(Int32 value) { 
 hasWeaponDataID = true;
 WeaponDataID_ = value;
 }

public const int WeaponEffectGemFieldNumber = 11;
 private bool hasWeaponEffectGem;
 private Int32 WeaponEffectGem_ = 0;
 public bool HasWeaponEffectGem {
 get { return hasWeaponEffectGem; }
 }
 public Int32 WeaponEffectGem {
 get { return WeaponEffectGem_; }
 set { SetWeaponEffectGem(value); }
 }
 public void SetWeaponEffectGem(Int32 value) { 
 hasWeaponEffectGem = true;
 WeaponEffectGem_ = value;
 }

public const int StealthLevFieldNumber = 12;
 private bool hasStealthLev;
 private Int32 StealthLev_ = 0;
 public bool HasStealthLev {
 get { return hasStealthLev; }
 }
 public Int32 StealthLev {
 get { return StealthLev_; }
 set { SetStealthLev(value); }
 }
 public void SetStealthLev(Int32 value) { 
 hasStealthLev = true;
 StealthLev_ = value;
 }

public const int VipCostFieldNumber = 13;
 private bool hasVipCost;
 private Int32 VipCost_ = 0;
 public bool HasVipCost {
 get { return hasVipCost; }
 }
 public Int32 VipCost {
 get { return VipCost_; }
 set { SetVipCost(value); }
 }
 public void SetVipCost(Int32 value) { 
 hasVipCost = true;
 VipCost_ = value;
 }

public const int CombatValueFieldNumber = 14;
 private bool hasCombatValue;
 private Int32 CombatValue_ = 0;
 public bool HasCombatValue {
 get { return hasCombatValue; }
 }
 public Int32 CombatValue {
 get { return CombatValue_; }
 set { SetCombatValue(value); }
 }
 public void SetCombatValue(Int32 value) { 
 hasCombatValue = true;
 CombatValue_ = value;
 }

public const int bindparentFieldNumber = 15;
 private bool hasBindparent;
 private Int32 bindparent_ = 0;
 public bool HasBindparent {
 get { return hasBindparent; }
 }
 public Int32 Bindparent {
 get { return bindparent_; }
 set { SetBindparent(value); }
 }
 public void SetBindparent(Int32 value) { 
 hasBindparent = true;
 bindparent_ = value;
 }

public const int bindchildrenFieldNumber = 16;
 private pbc::PopsicleList<Int32> bindchildren_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> bindchildrenList {
 get { return pbc::Lists.AsReadOnly(bindchildren_); }
 }
 
 public int bindchildrenCount {
 get { return bindchildren_.Count; }
 }
 
public Int32 GetBindchildren(int index) {
 return bindchildren_[index];
 }
 public void AddBindchildren(Int32 value) {
 bindchildren_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasCurProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(2, CurProfession);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(3, Name);
}
 if (HasCurForce) {
size += pb::CodedOutputStream.ComputeInt32Size(4, CurForce);
}
 if (HasMoveSpeed) {
size += pb::CodedOutputStream.ComputeInt32Size(5, MoveSpeed);
}
 if (HasBDie) {
size += pb::CodedOutputStream.ComputeInt32Size(6, BDie);
}
 if (HasFaceDir) {
size += pb::CodedOutputStream.ComputeInt32Size(7, FaceDir);
}
 if (HasModelVisualID) {
size += pb::CodedOutputStream.ComputeInt32Size(8, ModelVisualID);
}
 if (HasWeaponDataID) {
size += pb::CodedOutputStream.ComputeInt32Size(9, WeaponDataID);
}
 if (HasWeaponEffectGem) {
size += pb::CodedOutputStream.ComputeInt32Size(11, WeaponEffectGem);
}
 if (HasStealthLev) {
size += pb::CodedOutputStream.ComputeInt32Size(12, StealthLev);
}
 if (HasVipCost) {
size += pb::CodedOutputStream.ComputeInt32Size(13, VipCost);
}
 if (HasCombatValue) {
size += pb::CodedOutputStream.ComputeInt32Size(14, CombatValue);
}
 if (HasBindparent) {
size += pb::CodedOutputStream.ComputeInt32Size(15, Bindparent);
}
{
int dataSize = 0;
for(int i=0; i<bindchildrenList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(bindchildrenList[i]);
}
size += dataSize;
size += 1 * bindchildren_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasCurProfession) {
output.WriteInt32(2, CurProfession);
}
 
if (HasName) {
output.WriteString(3, Name);
}
 
if (HasCurForce) {
output.WriteInt32(4, CurForce);
}
 
if (HasMoveSpeed) {
output.WriteInt32(5, MoveSpeed);
}
 
if (HasBDie) {
output.WriteInt32(6, BDie);
}
 
if (HasFaceDir) {
output.WriteInt32(7, FaceDir);
}
 
if (HasModelVisualID) {
output.WriteInt32(8, ModelVisualID);
}
 
if (HasWeaponDataID) {
output.WriteInt32(9, WeaponDataID);
}
 
if (HasWeaponEffectGem) {
output.WriteInt32(11, WeaponEffectGem);
}
 
if (HasStealthLev) {
output.WriteInt32(12, StealthLev);
}
 
if (HasVipCost) {
output.WriteInt32(13, VipCost);
}
 
if (HasCombatValue) {
output.WriteInt32(14, CombatValue);
}
 
if (HasBindparent) {
output.WriteInt32(15, Bindparent);
}
{
if (bindchildren_.Count > 0) {
for(int i=0; i<bindchildren_.Count; ++i){
output.WriteInt32(16,bindchildren_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BROADCAST_ATTR _inst = (GC_BROADCAST_ATTR) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.CurProfession = input.ReadInt32();
break;
}
   case  26: {
 _inst.Name = input.ReadString();
break;
}
   case  32: {
 _inst.CurForce = input.ReadInt32();
break;
}
   case  40: {
 _inst.MoveSpeed = input.ReadInt32();
break;
}
   case  48: {
 _inst.BDie = input.ReadInt32();
break;
}
   case  56: {
 _inst.FaceDir = input.ReadInt32();
break;
}
   case  64: {
 _inst.ModelVisualID = input.ReadInt32();
break;
}
   case  72: {
 _inst.WeaponDataID = input.ReadInt32();
break;
}
   case  88: {
 _inst.WeaponEffectGem = input.ReadInt32();
break;
}
   case  96: {
 _inst.StealthLev = input.ReadInt32();
break;
}
   case  104: {
 _inst.VipCost = input.ReadInt32();
break;
}
   case  112: {
 _inst.CombatValue = input.ReadInt32();
break;
}
   case  120: {
 _inst.Bindparent = input.ReadInt32();
break;
}
   case  128: {
 _inst.AddBindchildren(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 return true;
 }

}


[Serializable]
public class GC_SYN_ATTR : PacketDistributed
{

public const int ObjIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 ObjId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return ObjId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 ObjId_ = value;
 }

public const int CurHpFieldNumber = 2;
 private bool hasCurHp;
 private Int32 CurHp_ = 0;
 public bool HasCurHp {
 get { return hasCurHp; }
 }
 public Int32 CurHp {
 get { return CurHp_; }
 set { SetCurHp(value); }
 }
 public void SetCurHp(Int32 value) { 
 hasCurHp = true;
 CurHp_ = value;
 }

public const int CurMpFieldNumber = 3;
 private bool hasCurMp;
 private Int32 CurMp_ = 0;
 public bool HasCurMp {
 get { return hasCurMp; }
 }
 public Int32 CurMp {
 get { return CurMp_; }
 set { SetCurMp(value); }
 }
 public void SetCurMp(Int32 value) { 
 hasCurMp = true;
 CurMp_ = value;
 }

public const int CurXpFieldNumber = 4;
 private bool hasCurXp;
 private Int32 CurXp_ = 0;
 public bool HasCurXp {
 get { return hasCurXp; }
 }
 public Int32 CurXp {
 get { return CurXp_; }
 set { SetCurXp(value); }
 }
 public void SetCurXp(Int32 value) { 
 hasCurXp = true;
 CurXp_ = value;
 }

public const int MaxHPFieldNumber = 5;
 private bool hasMaxHP;
 private Int32 MaxHP_ = 0;
 public bool HasMaxHP {
 get { return hasMaxHP; }
 }
 public Int32 MaxHP {
 get { return MaxHP_; }
 set { SetMaxHP(value); }
 }
 public void SetMaxHP(Int32 value) { 
 hasMaxHP = true;
 MaxHP_ = value;
 }

public const int MaxMPFieldNumber = 6;
 private bool hasMaxMP;
 private Int32 MaxMP_ = 0;
 public bool HasMaxMP {
 get { return hasMaxMP; }
 }
 public Int32 MaxMP {
 get { return MaxMP_; }
 set { SetMaxMP(value); }
 }
 public void SetMaxMP(Int32 value) { 
 hasMaxMP = true;
 MaxMP_ = value;
 }

public const int MaxXPFieldNumber = 7;
 private bool hasMaxXP;
 private Int32 MaxXP_ = 0;
 public bool HasMaxXP {
 get { return hasMaxXP; }
 }
 public Int32 MaxXP {
 get { return MaxXP_; }
 set { SetMaxXP(value); }
 }
 public void SetMaxXP(Int32 value) { 
 hasMaxXP = true;
 MaxXP_ = value;
 }

public const int CurLevFieldNumber = 8;
 private bool hasCurLev;
 private Int32 CurLev_ = 0;
 public bool HasCurLev {
 get { return hasCurLev; }
 }
 public Int32 CurLev {
 get { return CurLev_; }
 set { SetCurLev(value); }
 }
 public void SetCurLev(Int32 value) { 
 hasCurLev = true;
 CurLev_ = value;
 }

public const int CurExpFieldNumber = 9;
 private bool hasCurExp;
 private Int32 CurExp_ = 0;
 public bool HasCurExp {
 get { return hasCurExp; }
 }
 public Int32 CurExp {
 get { return CurExp_; }
 set { SetCurExp(value); }
 }
 public void SetCurExp(Int32 value) { 
 hasCurExp = true;
 CurExp_ = value;
 }

public const int CurMoneyFieldNumber = 10;
 private bool hasCurMoney;
 private Int32 CurMoney_ = 0;
 public bool HasCurMoney {
 get { return hasCurMoney; }
 }
 public Int32 CurMoney {
 get { return CurMoney_; }
 set { SetCurMoney(value); }
 }
 public void SetCurMoney(Int32 value) { 
 hasCurMoney = true;
 CurMoney_ = value;
 }

public const int CurYuanBaoFieldNumber = 11;
 private bool hasCurYuanBao;
 private Int32 CurYuanBao_ = 0;
 public bool HasCurYuanBao {
 get { return hasCurYuanBao; }
 }
 public Int32 CurYuanBao {
 get { return CurYuanBao_; }
 set { SetCurYuanBao(value); }
 }
 public void SetCurYuanBao(Int32 value) { 
 hasCurYuanBao = true;
 CurYuanBao_ = value;
 }

public const int CurBDYuanBaoFieldNumber = 12;
 private bool hasCurBDYuanBao;
 private Int32 CurBDYuanBao_ = 0;
 public bool HasCurBDYuanBao {
 get { return hasCurBDYuanBao; }
 }
 public Int32 CurBDYuanBao {
 get { return CurBDYuanBao_; }
 set { SetCurBDYuanBao(value); }
 }
 public void SetCurBDYuanBao(Int32 value) { 
 hasCurBDYuanBao = true;
 CurBDYuanBao_ = value;
 }

public const int CurZhenQiFieldNumber = 13;
 private bool hasCurZhenQi;
 private Int32 CurZhenQi_ = 0;
 public bool HasCurZhenQi {
 get { return hasCurZhenQi; }
 }
 public Int32 CurZhenQi {
 get { return CurZhenQi_; }
 set { SetCurZhenQi(value); }
 }
 public void SetCurZhenQi(Int32 value) { 
 hasCurZhenQi = true;
 CurZhenQi_ = value;
 }

public const int isInCombatFieldNumber = 14;
 private bool hasIsInCombat;
 private Int32 isInCombat_ = 0;
 public bool HasIsInCombat {
 get { return hasIsInCombat; }
 }
 public Int32 IsInCombat {
 get { return isInCombat_; }
 set { SetIsInCombat(value); }
 }
 public void SetIsInCombat(Int32 value) { 
 hasIsInCombat = true;
 isInCombat_ = value;
 }

public const int CurStaminaFieldNumber = 15;
 private bool hasCurStamina;
 private Int32 CurStamina_ = 0;
 public bool HasCurStamina {
 get { return hasCurStamina; }
 }
 public Int32 CurStamina {
 get { return CurStamina_; }
 set { SetCurStamina(value); }
 }
 public void SetCurStamina(Int32 value) { 
 hasCurStamina = true;
 CurStamina_ = value;
 }

public const int OffLineExpFieldNumber = 16;
 private bool hasOffLineExp;
 private Int32 OffLineExp_ = 0;
 public bool HasOffLineExp {
 get { return hasOffLineExp; }
 }
 public Int32 OffLineExp {
 get { return OffLineExp_; }
 set { SetOffLineExp(value); }
 }
 public void SetOffLineExp(Int32 value) { 
 hasOffLineExp = true;
 OffLineExp_ = value;
 }

public const int SwordsManScoreFieldNumber = 17;
 private bool hasSwordsManScore;
 private Int32 SwordsManScore_ = 0;
 public bool HasSwordsManScore {
 get { return hasSwordsManScore; }
 }
 public Int32 SwordsManScore {
 get { return SwordsManScore_; }
 set { SetSwordsManScore(value); }
 }
 public void SetSwordsManScore(Int32 value) { 
 hasSwordsManScore = true;
 SwordsManScore_ = value;
 }

public const int ReputationFieldNumber = 18;
 private bool hasReputation;
 private Int32 Reputation_ = 0;
 public bool HasReputation {
 get { return hasReputation; }
 }
 public Int32 Reputation {
 get { return Reputation_; }
 set { SetReputation(value); }
 }
 public void SetReputation(Int32 value) { 
 hasReputation = true;
 Reputation_ = value;
 }

public const int GuildDKPFieldNumber = 19;
 private bool hasGuildDKP;
 private Int32 GuildDKP_ = 0;
 public bool HasGuildDKP {
 get { return hasGuildDKP; }
 }
 public Int32 GuildDKP {
 get { return GuildDKP_; }
 set { SetGuildDKP(value); }
 }
 public void SetGuildDKP(Int32 value) { 
 hasGuildDKP = true;
 GuildDKP_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasCurHp) {
size += pb::CodedOutputStream.ComputeInt32Size(2, CurHp);
}
 if (HasCurMp) {
size += pb::CodedOutputStream.ComputeInt32Size(3, CurMp);
}
 if (HasCurXp) {
size += pb::CodedOutputStream.ComputeInt32Size(4, CurXp);
}
 if (HasMaxHP) {
size += pb::CodedOutputStream.ComputeInt32Size(5, MaxHP);
}
 if (HasMaxMP) {
size += pb::CodedOutputStream.ComputeInt32Size(6, MaxMP);
}
 if (HasMaxXP) {
size += pb::CodedOutputStream.ComputeInt32Size(7, MaxXP);
}
 if (HasCurLev) {
size += pb::CodedOutputStream.ComputeInt32Size(8, CurLev);
}
 if (HasCurExp) {
size += pb::CodedOutputStream.ComputeInt32Size(9, CurExp);
}
 if (HasCurMoney) {
size += pb::CodedOutputStream.ComputeInt32Size(10, CurMoney);
}
 if (HasCurYuanBao) {
size += pb::CodedOutputStream.ComputeInt32Size(11, CurYuanBao);
}
 if (HasCurBDYuanBao) {
size += pb::CodedOutputStream.ComputeInt32Size(12, CurBDYuanBao);
}
 if (HasCurZhenQi) {
size += pb::CodedOutputStream.ComputeInt32Size(13, CurZhenQi);
}
 if (HasIsInCombat) {
size += pb::CodedOutputStream.ComputeInt32Size(14, IsInCombat);
}
 if (HasCurStamina) {
size += pb::CodedOutputStream.ComputeInt32Size(15, CurStamina);
}
 if (HasOffLineExp) {
size += pb::CodedOutputStream.ComputeInt32Size(16, OffLineExp);
}
 if (HasSwordsManScore) {
size += pb::CodedOutputStream.ComputeInt32Size(17, SwordsManScore);
}
 if (HasReputation) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Reputation);
}
 if (HasGuildDKP) {
size += pb::CodedOutputStream.ComputeInt32Size(19, GuildDKP);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasCurHp) {
output.WriteInt32(2, CurHp);
}
 
if (HasCurMp) {
output.WriteInt32(3, CurMp);
}
 
if (HasCurXp) {
output.WriteInt32(4, CurXp);
}
 
if (HasMaxHP) {
output.WriteInt32(5, MaxHP);
}
 
if (HasMaxMP) {
output.WriteInt32(6, MaxMP);
}
 
if (HasMaxXP) {
output.WriteInt32(7, MaxXP);
}
 
if (HasCurLev) {
output.WriteInt32(8, CurLev);
}
 
if (HasCurExp) {
output.WriteInt32(9, CurExp);
}
 
if (HasCurMoney) {
output.WriteInt32(10, CurMoney);
}
 
if (HasCurYuanBao) {
output.WriteInt32(11, CurYuanBao);
}
 
if (HasCurBDYuanBao) {
output.WriteInt32(12, CurBDYuanBao);
}
 
if (HasCurZhenQi) {
output.WriteInt32(13, CurZhenQi);
}
 
if (HasIsInCombat) {
output.WriteInt32(14, IsInCombat);
}
 
if (HasCurStamina) {
output.WriteInt32(15, CurStamina);
}
 
if (HasOffLineExp) {
output.WriteInt32(16, OffLineExp);
}
 
if (HasSwordsManScore) {
output.WriteInt32(17, SwordsManScore);
}
 
if (HasReputation) {
output.WriteInt32(18, Reputation);
}
 
if (HasGuildDKP) {
output.WriteInt32(19, GuildDKP);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYN_ATTR _inst = (GC_SYN_ATTR) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.CurHp = input.ReadInt32();
break;
}
   case  24: {
 _inst.CurMp = input.ReadInt32();
break;
}
   case  32: {
 _inst.CurXp = input.ReadInt32();
break;
}
   case  40: {
 _inst.MaxHP = input.ReadInt32();
break;
}
   case  48: {
 _inst.MaxMP = input.ReadInt32();
break;
}
   case  56: {
 _inst.MaxXP = input.ReadInt32();
break;
}
   case  64: {
 _inst.CurLev = input.ReadInt32();
break;
}
   case  72: {
 _inst.CurExp = input.ReadInt32();
break;
}
   case  80: {
 _inst.CurMoney = input.ReadInt32();
break;
}
   case  88: {
 _inst.CurYuanBao = input.ReadInt32();
break;
}
   case  96: {
 _inst.CurBDYuanBao = input.ReadInt32();
break;
}
   case  104: {
 _inst.CurZhenQi = input.ReadInt32();
break;
}
   case  112: {
 _inst.IsInCombat = input.ReadInt32();
break;
}
   case  120: {
 _inst.CurStamina = input.ReadInt32();
break;
}
   case  128: {
 _inst.OffLineExp = input.ReadInt32();
break;
}
   case  136: {
 _inst.SwordsManScore = input.ReadInt32();
break;
}
   case  144: {
 _inst.Reputation = input.ReadInt32();
break;
}
   case  152: {
 _inst.GuildDKP = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 return true;
 }

}


[Serializable]
public class CG_THROW_ITEM : PacketDistributed
{

public const int itemguidFieldNumber = 1;
 private bool hasItemguid;
 private UInt64 itemguid_ = 0;
 public bool HasItemguid {
 get { return hasItemguid; }
 }
 public UInt64 Itemguid {
 get { return itemguid_; }
 set { SetItemguid(value); }
 }
 public void SetItemguid(UInt64 value) { 
 hasItemguid = true;
 itemguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasItemguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Itemguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasItemguid) {
output.WriteUInt64(1, Itemguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_THROW_ITEM _inst = (CG_THROW_ITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Itemguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasItemguid) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_DATA : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private pbc::PopsicleList<Int32> belleID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> belleIDList {
 get { return pbc::Lists.AsReadOnly(belleID_); }
 }
 
 public int belleIDCount {
 get { return belleID_.Count; }
 }
 
public Int32 GetBelleID(int index) {
 return belleID_[index];
 }
 public void AddBelleID(Int32 value) {
 belleID_.Add(value);
 }

public const int belleLevelFieldNumber = 2;
 private pbc::PopsicleList<Int32> belleLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> belleLevelList {
 get { return pbc::Lists.AsReadOnly(belleLevel_); }
 }
 
 public int belleLevelCount {
 get { return belleLevel_.Count; }
 }
 
public Int32 GetBelleLevel(int index) {
 return belleLevel_[index];
 }
 public void AddBelleLevel(Int32 value) {
 belleLevel_.Add(value);
 }

public const int belleMatrixIDFieldNumber = 3;
 private pbc::PopsicleList<Int32> belleMatrixID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> belleMatrixIDList {
 get { return pbc::Lists.AsReadOnly(belleMatrixID_); }
 }
 
 public int belleMatrixIDCount {
 get { return belleMatrixID_.Count; }
 }
 
public Int32 GetBelleMatrixID(int index) {
 return belleMatrixID_[index];
 }
 public void AddBelleMatrixID(Int32 value) {
 belleMatrixID_.Add(value);
 }

public const int belleMatrixIndexFieldNumber = 4;
 private pbc::PopsicleList<Int32> belleMatrixIndex_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> belleMatrixIndexList {
 get { return pbc::Lists.AsReadOnly(belleMatrixIndex_); }
 }
 
 public int belleMatrixIndexCount {
 get { return belleMatrixIndex_.Count; }
 }
 
public Int32 GetBelleMatrixIndex(int index) {
 return belleMatrixIndex_[index];
 }
 public void AddBelleMatrixIndex(Int32 value) {
 belleMatrixIndex_.Add(value);
 }

public const int belleNextEvolutionTimerFieldNumber = 5;
 private pbc::PopsicleList<Int32> belleNextEvolutionTimer_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> belleNextEvolutionTimerList {
 get { return pbc::Lists.AsReadOnly(belleNextEvolutionTimer_); }
 }
 
 public int belleNextEvolutionTimerCount {
 get { return belleNextEvolutionTimer_.Count; }
 }
 
public Int32 GetBelleNextEvolutionTimer(int index) {
 return belleNextEvolutionTimer_[index];
 }
 public void AddBelleNextEvolutionTimer(Int32 value) {
 belleNextEvolutionTimer_.Add(value);
 }

public const int belleFavourValueFieldNumber = 6;
 private pbc::PopsicleList<Int32> belleFavourValue_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> belleFavourValueList {
 get { return pbc::Lists.AsReadOnly(belleFavourValue_); }
 }
 
 public int belleFavourValueCount {
 get { return belleFavourValue_.Count; }
 }
 
public Int32 GetBelleFavourValue(int index) {
 return belleFavourValue_[index];
 }
 public void AddBelleFavourValue(Int32 value) {
 belleFavourValue_.Add(value);
 }

public const int matrixIDFieldNumber = 7;
 private pbc::PopsicleList<Int32> matrixID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> matrixIDList {
 get { return pbc::Lists.AsReadOnly(matrixID_); }
 }
 
 public int matrixIDCount {
 get { return matrixID_.Count; }
 }
 
public Int32 GetMatrixID(int index) {
 return matrixID_[index];
 }
 public void AddMatrixID(Int32 value) {
 matrixID_.Add(value);
 }

public const int matrixIsActiveFieldNumber = 8;
 private pbc::PopsicleList<Int32> matrixIsActive_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> matrixIsActiveList {
 get { return pbc::Lists.AsReadOnly(matrixIsActive_); }
 }
 
 public int matrixIsActiveCount {
 get { return matrixIsActive_.Count; }
 }
 
public Int32 GetMatrixIsActive(int index) {
 return matrixIsActive_[index];
 }
 public void AddMatrixIsActive(Int32 value) {
 matrixIsActive_.Add(value);
 }

public const int matrixBellesFieldNumber = 9;
 private pbc::PopsicleList<Int32> matrixBelles_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> matrixBellesList {
 get { return pbc::Lists.AsReadOnly(matrixBelles_); }
 }
 
 public int matrixBellesCount {
 get { return matrixBelles_.Count; }
 }
 
public Int32 GetMatrixBelles(int index) {
 return matrixBelles_[index];
 }
 public void AddMatrixBelles(Int32 value) {
 matrixBelles_.Add(value);
 }

public const int dayCloseTimeFieldNumber = 10;
 private bool hasDayCloseTime;
 private Int32 dayCloseTime_ = 0;
 public bool HasDayCloseTime {
 get { return hasDayCloseTime; }
 }
 public Int32 DayCloseTime {
 get { return dayCloseTime_; }
 set { SetDayCloseTime(value); }
 }
 public void SetDayCloseTime(Int32 value) { 
 hasDayCloseTime = true;
 dayCloseTime_ = value;
 }

public const int dayMaxCloseTimeFieldNumber = 11;
 private bool hasDayMaxCloseTime;
 private Int32 dayMaxCloseTime_ = 0;
 public bool HasDayMaxCloseTime {
 get { return hasDayMaxCloseTime; }
 }
 public Int32 DayMaxCloseTime {
 get { return dayMaxCloseTime_; }
 set { SetDayMaxCloseTime(value); }
 }
 public void SetDayMaxCloseTime(Int32 value) { 
 hasDayMaxCloseTime = true;
 dayMaxCloseTime_ = value;
 }

public const int belleMatrixActiveMaxFieldNumber = 12;
 private bool hasBelleMatrixActiveMax;
 private Int32 belleMatrixActiveMax_ = 0;
 public bool HasBelleMatrixActiveMax {
 get { return hasBelleMatrixActiveMax; }
 }
 public Int32 BelleMatrixActiveMax {
 get { return belleMatrixActiveMax_; }
 set { SetBelleMatrixActiveMax(value); }
 }
 public void SetBelleMatrixActiveMax(Int32 value) { 
 hasBelleMatrixActiveMax = true;
 belleMatrixActiveMax_ = value;
 }

public const int nextCloseTimerFieldNumber = 13;
 private bool hasNextCloseTimer;
 private Int32 nextCloseTimer_ = 0;
 public bool HasNextCloseTimer {
 get { return hasNextCloseTimer; }
 }
 public Int32 NextCloseTimer {
 get { return nextCloseTimer_; }
 set { SetNextCloseTimer(value); }
 }
 public void SetNextCloseTimer(Int32 value) { 
 hasNextCloseTimer = true;
 nextCloseTimer_ = value;
 }

public const int belleCloseAddAttrValueFieldNumber = 14;
 private pbc::PopsicleList<Int32> belleCloseAddAttrValue_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> belleCloseAddAttrValueList {
 get { return pbc::Lists.AsReadOnly(belleCloseAddAttrValue_); }
 }
 
 public int belleCloseAddAttrValueCount {
 get { return belleCloseAddAttrValue_.Count; }
 }
 
public Int32 GetBelleCloseAddAttrValue(int index) {
 return belleCloseAddAttrValue_[index];
 }
 public void AddBelleCloseAddAttrValue(Int32 value) {
 belleCloseAddAttrValue_.Add(value);
 }

public const int closeLevelFieldNumber = 15;
 private pbc::PopsicleList<Int32> closeLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> closeLevelList {
 get { return pbc::Lists.AsReadOnly(closeLevel_); }
 }
 
 public int closeLevelCount {
 get { return closeLevel_.Count; }
 }
 
public Int32 GetCloseLevel(int index) {
 return closeLevel_[index];
 }
 public void AddCloseLevel(Int32 value) {
 closeLevel_.Add(value);
 }

public const int subLevelFieldNumber = 16;
 private pbc::PopsicleList<Int32> subLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> subLevelList {
 get { return pbc::Lists.AsReadOnly(subLevel_); }
 }
 
 public int subLevelCount {
 get { return subLevel_.Count; }
 }
 
public Int32 GetSubLevel(int index) {
 return subLevel_[index];
 }
 public void AddSubLevel(Int32 value) {
 subLevel_.Add(value);
 }

public const int absorbSumFieldNumber = 17;
 private pbc::PopsicleList<Int32> absorbSum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> absorbSumList {
 get { return pbc::Lists.AsReadOnly(absorbSum_); }
 }
 
 public int absorbSumCount {
 get { return absorbSum_.Count; }
 }
 
public Int32 GetAbsorbSum(int index) {
 return absorbSum_[index];
 }
 public void AddAbsorbSum(Int32 value) {
 absorbSum_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<belleIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(belleIDList[i]);
}
size += dataSize;
size += 1 * belleID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<belleLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(belleLevelList[i]);
}
size += dataSize;
size += 1 * belleLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<belleMatrixIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(belleMatrixIDList[i]);
}
size += dataSize;
size += 1 * belleMatrixID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<belleMatrixIndexList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(belleMatrixIndexList[i]);
}
size += dataSize;
size += 1 * belleMatrixIndex_.Count;
}
{
int dataSize = 0;
for(int i=0; i<belleNextEvolutionTimerList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(belleNextEvolutionTimerList[i]);
}
size += dataSize;
size += 1 * belleNextEvolutionTimer_.Count;
}
{
int dataSize = 0;
for(int i=0; i<belleFavourValueList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(belleFavourValueList[i]);
}
size += dataSize;
size += 1 * belleFavourValue_.Count;
}
{
int dataSize = 0;
for(int i=0; i<matrixIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(matrixIDList[i]);
}
size += dataSize;
size += 1 * matrixID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<matrixIsActiveList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(matrixIsActiveList[i]);
}
size += dataSize;
size += 1 * matrixIsActive_.Count;
}
{
int dataSize = 0;
for(int i=0; i<matrixBellesList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(matrixBellesList[i]);
}
size += dataSize;
size += 1 * matrixBelles_.Count;
}
 if (HasDayCloseTime) {
size += pb::CodedOutputStream.ComputeInt32Size(10, DayCloseTime);
}
 if (HasDayMaxCloseTime) {
size += pb::CodedOutputStream.ComputeInt32Size(11, DayMaxCloseTime);
}
 if (HasBelleMatrixActiveMax) {
size += pb::CodedOutputStream.ComputeInt32Size(12, BelleMatrixActiveMax);
}
 if (HasNextCloseTimer) {
size += pb::CodedOutputStream.ComputeInt32Size(13, NextCloseTimer);
}
{
int dataSize = 0;
for(int i=0; i<belleCloseAddAttrValueList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(belleCloseAddAttrValueList[i]);
}
size += dataSize;
size += 1 * belleCloseAddAttrValue_.Count;
}
{
int dataSize = 0;
for(int i=0; i<closeLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(closeLevelList[i]);
}
size += dataSize;
size += 1 * closeLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<subLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(subLevelList[i]);
}
size += dataSize;
size += 1 * subLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<absorbSumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(absorbSumList[i]);
}
size += dataSize;
size += 1 * absorbSum_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (belleID_.Count > 0) {
for(int i=0; i<belleID_.Count; ++i){
output.WriteInt32(1,belleID_[i]);
}
}

}
{
if (belleLevel_.Count > 0) {
for(int i=0; i<belleLevel_.Count; ++i){
output.WriteInt32(2,belleLevel_[i]);
}
}

}
{
if (belleMatrixID_.Count > 0) {
for(int i=0; i<belleMatrixID_.Count; ++i){
output.WriteInt32(3,belleMatrixID_[i]);
}
}

}
{
if (belleMatrixIndex_.Count > 0) {
for(int i=0; i<belleMatrixIndex_.Count; ++i){
output.WriteInt32(4,belleMatrixIndex_[i]);
}
}

}
{
if (belleNextEvolutionTimer_.Count > 0) {
for(int i=0; i<belleNextEvolutionTimer_.Count; ++i){
output.WriteInt32(5,belleNextEvolutionTimer_[i]);
}
}

}
{
if (belleFavourValue_.Count > 0) {
for(int i=0; i<belleFavourValue_.Count; ++i){
output.WriteInt32(6,belleFavourValue_[i]);
}
}

}
{
if (matrixID_.Count > 0) {
for(int i=0; i<matrixID_.Count; ++i){
output.WriteInt32(7,matrixID_[i]);
}
}

}
{
if (matrixIsActive_.Count > 0) {
for(int i=0; i<matrixIsActive_.Count; ++i){
output.WriteInt32(8,matrixIsActive_[i]);
}
}

}
{
if (matrixBelles_.Count > 0) {
for(int i=0; i<matrixBelles_.Count; ++i){
output.WriteInt32(9,matrixBelles_[i]);
}
}

}
 
if (HasDayCloseTime) {
output.WriteInt32(10, DayCloseTime);
}
 
if (HasDayMaxCloseTime) {
output.WriteInt32(11, DayMaxCloseTime);
}
 
if (HasBelleMatrixActiveMax) {
output.WriteInt32(12, BelleMatrixActiveMax);
}
 
if (HasNextCloseTimer) {
output.WriteInt32(13, NextCloseTimer);
}
{
if (belleCloseAddAttrValue_.Count > 0) {
for(int i=0; i<belleCloseAddAttrValue_.Count; ++i){
output.WriteInt32(14,belleCloseAddAttrValue_[i]);
}
}

}
{
if (closeLevel_.Count > 0) {
for(int i=0; i<closeLevel_.Count; ++i){
output.WriteInt32(15,closeLevel_[i]);
}
}

}
{
if (subLevel_.Count > 0) {
for(int i=0; i<subLevel_.Count; ++i){
output.WriteInt32(16,subLevel_[i]);
}
}

}
{
if (absorbSum_.Count > 0) {
for(int i=0; i<absorbSum_.Count; ++i){
output.WriteInt32(17,absorbSum_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_DATA _inst = (GC_BELLE_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddBelleID(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddBelleLevel(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddBelleMatrixID(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddBelleMatrixIndex(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddBelleNextEvolutionTimer(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddBelleFavourValue(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddMatrixID(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddMatrixIsActive(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddMatrixBelles(input.ReadInt32());
break;
}
   case  80: {
 _inst.DayCloseTime = input.ReadInt32();
break;
}
   case  88: {
 _inst.DayMaxCloseTime = input.ReadInt32();
break;
}
   case  96: {
 _inst.BelleMatrixActiveMax = input.ReadInt32();
break;
}
   case  104: {
 _inst.NextCloseTimer = input.ReadInt32();
break;
}
   case  112: {
 _inst.AddBelleCloseAddAttrValue(input.ReadInt32());
break;
}
   case  120: {
 _inst.AddCloseLevel(input.ReadInt32());
break;
}
   case  128: {
 _inst.AddSubLevel(input.ReadInt32());
break;
}
   case  136: {
 _inst.AddAbsorbSum(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasDayCloseTime) return false;
 if (!hasDayMaxCloseTime) return false;
 if (!hasBelleMatrixActiveMax) return false;
 if (!hasNextCloseTimer) return false;
 return true;
 }

}


[Serializable]
public class CG_BELLE_CLOSE : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BELLE_CLOSE _inst = (CG_BELLE_CLOSE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_CLOSE_RET : PacketDistributed
{

public const int dayCloseTimeFieldNumber = 1;
 private bool hasDayCloseTime;
 private Int32 dayCloseTime_ = 0;
 public bool HasDayCloseTime {
 get { return hasDayCloseTime; }
 }
 public Int32 DayCloseTime {
 get { return dayCloseTime_; }
 set { SetDayCloseTime(value); }
 }
 public void SetDayCloseTime(Int32 value) { 
 hasDayCloseTime = true;
 dayCloseTime_ = value;
 }

public const int dayMaxCloseTimeFieldNumber = 2;
 private bool hasDayMaxCloseTime;
 private Int32 dayMaxCloseTime_ = 0;
 public bool HasDayMaxCloseTime {
 get { return hasDayMaxCloseTime; }
 }
 public Int32 DayMaxCloseTime {
 get { return dayMaxCloseTime_; }
 set { SetDayMaxCloseTime(value); }
 }
 public void SetDayMaxCloseTime(Int32 value) { 
 hasDayMaxCloseTime = true;
 dayMaxCloseTime_ = value;
 }

public const int belleIDFieldNumber = 3;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

public const int belleFavourValueFieldNumber = 4;
 private bool hasBelleFavourValue;
 private Int32 belleFavourValue_ = 0;
 public bool HasBelleFavourValue {
 get { return hasBelleFavourValue; }
 }
 public Int32 BelleFavourValue {
 get { return belleFavourValue_; }
 set { SetBelleFavourValue(value); }
 }
 public void SetBelleFavourValue(Int32 value) { 
 hasBelleFavourValue = true;
 belleFavourValue_ = value;
 }

public const int nextCloserTimerFieldNumber = 5;
 private bool hasNextCloserTimer;
 private Int32 nextCloserTimer_ = 0;
 public bool HasNextCloserTimer {
 get { return hasNextCloserTimer; }
 }
 public Int32 NextCloserTimer {
 get { return nextCloserTimer_; }
 set { SetNextCloserTimer(value); }
 }
 public void SetNextCloserTimer(Int32 value) { 
 hasNextCloserTimer = true;
 nextCloserTimer_ = value;
 }

public const int belleCloseAddAttrValueFieldNumber = 6;
 private bool hasBelleCloseAddAttrValue;
 private Int32 belleCloseAddAttrValue_ = 0;
 public bool HasBelleCloseAddAttrValue {
 get { return hasBelleCloseAddAttrValue; }
 }
 public Int32 BelleCloseAddAttrValue {
 get { return belleCloseAddAttrValue_; }
 set { SetBelleCloseAddAttrValue(value); }
 }
 public void SetBelleCloseAddAttrValue(Int32 value) { 
 hasBelleCloseAddAttrValue = true;
 belleCloseAddAttrValue_ = value;
 }

public const int closeLevelFieldNumber = 7;
 private bool hasCloseLevel;
 private Int32 closeLevel_ = 0;
 public bool HasCloseLevel {
 get { return hasCloseLevel; }
 }
 public Int32 CloseLevel {
 get { return closeLevel_; }
 set { SetCloseLevel(value); }
 }
 public void SetCloseLevel(Int32 value) { 
 hasCloseLevel = true;
 closeLevel_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasDayCloseTime) {
size += pb::CodedOutputStream.ComputeInt32Size(1, DayCloseTime);
}
 if (HasDayMaxCloseTime) {
size += pb::CodedOutputStream.ComputeInt32Size(2, DayMaxCloseTime);
}
 if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(3, BelleID);
}
 if (HasBelleFavourValue) {
size += pb::CodedOutputStream.ComputeInt32Size(4, BelleFavourValue);
}
 if (HasNextCloserTimer) {
size += pb::CodedOutputStream.ComputeInt32Size(5, NextCloserTimer);
}
 if (HasBelleCloseAddAttrValue) {
size += pb::CodedOutputStream.ComputeInt32Size(6, BelleCloseAddAttrValue);
}
 if (HasCloseLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(7, CloseLevel);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasDayCloseTime) {
output.WriteInt32(1, DayCloseTime);
}
 
if (HasDayMaxCloseTime) {
output.WriteInt32(2, DayMaxCloseTime);
}
 
if (HasBelleID) {
output.WriteInt32(3, BelleID);
}
 
if (HasBelleFavourValue) {
output.WriteInt32(4, BelleFavourValue);
}
 
if (HasNextCloserTimer) {
output.WriteInt32(5, NextCloserTimer);
}
 
if (HasBelleCloseAddAttrValue) {
output.WriteInt32(6, BelleCloseAddAttrValue);
}
 
if (HasCloseLevel) {
output.WriteInt32(7, CloseLevel);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_CLOSE_RET _inst = (GC_BELLE_CLOSE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.DayCloseTime = input.ReadInt32();
break;
}
   case  16: {
 _inst.DayMaxCloseTime = input.ReadInt32();
break;
}
   case  24: {
 _inst.BelleID = input.ReadInt32();
break;
}
   case  32: {
 _inst.BelleFavourValue = input.ReadInt32();
break;
}
   case  40: {
 _inst.NextCloserTimer = input.ReadInt32();
break;
}
   case  48: {
 _inst.BelleCloseAddAttrValue = input.ReadInt32();
break;
}
   case  56: {
 _inst.CloseLevel = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasDayCloseTime) return false;
 if (!hasDayMaxCloseTime) return false;
 if (!hasBelleID) return false;
 if (!hasBelleFavourValue) return false;
 if (!hasNextCloserTimer) return false;
 if (!hasCloseLevel) return false;
 return true;
 }

}


[Serializable]
public class CG_BELLE_EVOLUTION : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BELLE_EVOLUTION _inst = (CG_BELLE_EVOLUTION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_EVOLUTION_RET : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

public const int nextEvolutionTimerFieldNumber = 2;
 private bool hasNextEvolutionTimer;
 private Int32 nextEvolutionTimer_ = 0;
 public bool HasNextEvolutionTimer {
 get { return hasNextEvolutionTimer; }
 }
 public Int32 NextEvolutionTimer {
 get { return nextEvolutionTimer_; }
 set { SetNextEvolutionTimer(value); }
 }
 public void SetNextEvolutionTimer(Int32 value) { 
 hasNextEvolutionTimer = true;
 nextEvolutionTimer_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 if (HasNextEvolutionTimer) {
size += pb::CodedOutputStream.ComputeInt32Size(2, NextEvolutionTimer);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 
if (HasNextEvolutionTimer) {
output.WriteInt32(2, NextEvolutionTimer);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_EVOLUTION_RET _inst = (GC_BELLE_EVOLUTION_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}
   case  16: {
 _inst.NextEvolutionTimer = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 if (!hasNextEvolutionTimer) return false;
 return true;
 }

}


[Serializable]
public class CG_BELLE_EVOLUTIONRAPID : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BELLE_EVOLUTIONRAPID _inst = (CG_BELLE_EVOLUTIONRAPID) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_EVOLUTIONRAPID_RET : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

public const int levelFieldNumber = 3;
 private bool hasLevel;
 private Int32 level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 level_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Level);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 
if (HasLevel) {
output.WriteInt32(3, Level);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_EVOLUTIONRAPID_RET _inst = (GC_BELLE_EVOLUTIONRAPID_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}
   case  24: {
 _inst.Level = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 if (!hasLevel) return false;
 return true;
 }

}


[Serializable]
public class CG_BELLE_BATTLE : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

public const int MatrixIDFieldNumber = 2;
 private bool hasMatrixID;
 private Int32 MatrixID_ = 0;
 public bool HasMatrixID {
 get { return hasMatrixID; }
 }
 public Int32 MatrixID {
 get { return MatrixID_; }
 set { SetMatrixID(value); }
 }
 public void SetMatrixID(Int32 value) { 
 hasMatrixID = true;
 MatrixID_ = value;
 }

public const int MatrixIndexFieldNumber = 3;
 private bool hasMatrixIndex;
 private Int32 MatrixIndex_ = 0;
 public bool HasMatrixIndex {
 get { return hasMatrixIndex; }
 }
 public Int32 MatrixIndex {
 get { return MatrixIndex_; }
 set { SetMatrixIndex(value); }
 }
 public void SetMatrixIndex(Int32 value) { 
 hasMatrixIndex = true;
 MatrixIndex_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 if (HasMatrixID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, MatrixID);
}
 if (HasMatrixIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(3, MatrixIndex);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 
if (HasMatrixID) {
output.WriteInt32(2, MatrixID);
}
 
if (HasMatrixIndex) {
output.WriteInt32(3, MatrixIndex);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BELLE_BATTLE _inst = (CG_BELLE_BATTLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}
   case  16: {
 _inst.MatrixID = input.ReadInt32();
break;
}
   case  24: {
 _inst.MatrixIndex = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 if (!hasMatrixID) return false;
 if (!hasMatrixIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_BATTLE_RET : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

public const int oldMatrixIDFieldNumber = 2;
 private bool hasOldMatrixID;
 private Int32 oldMatrixID_ = 0;
 public bool HasOldMatrixID {
 get { return hasOldMatrixID; }
 }
 public Int32 OldMatrixID {
 get { return oldMatrixID_; }
 set { SetOldMatrixID(value); }
 }
 public void SetOldMatrixID(Int32 value) { 
 hasOldMatrixID = true;
 oldMatrixID_ = value;
 }

public const int oldMatrixIndexFieldNumber = 3;
 private bool hasOldMatrixIndex;
 private Int32 oldMatrixIndex_ = 0;
 public bool HasOldMatrixIndex {
 get { return hasOldMatrixIndex; }
 }
 public Int32 OldMatrixIndex {
 get { return oldMatrixIndex_; }
 set { SetOldMatrixIndex(value); }
 }
 public void SetOldMatrixIndex(Int32 value) { 
 hasOldMatrixIndex = true;
 oldMatrixIndex_ = value;
 }

public const int oldMatrixIsActiveFieldNumber = 4;
 private bool hasOldMatrixIsActive;
 private Int32 oldMatrixIsActive_ = 0;
 public bool HasOldMatrixIsActive {
 get { return hasOldMatrixIsActive; }
 }
 public Int32 OldMatrixIsActive {
 get { return oldMatrixIsActive_; }
 set { SetOldMatrixIsActive(value); }
 }
 public void SetOldMatrixIsActive(Int32 value) { 
 hasOldMatrixIsActive = true;
 oldMatrixIsActive_ = value;
 }

public const int newMatrixIDFieldNumber = 5;
 private bool hasNewMatrixID;
 private Int32 newMatrixID_ = 0;
 public bool HasNewMatrixID {
 get { return hasNewMatrixID; }
 }
 public Int32 NewMatrixID {
 get { return newMatrixID_; }
 set { SetNewMatrixID(value); }
 }
 public void SetNewMatrixID(Int32 value) { 
 hasNewMatrixID = true;
 newMatrixID_ = value;
 }

public const int newMatrixIndexFieldNumber = 6;
 private bool hasNewMatrixIndex;
 private Int32 newMatrixIndex_ = 0;
 public bool HasNewMatrixIndex {
 get { return hasNewMatrixIndex; }
 }
 public Int32 NewMatrixIndex {
 get { return newMatrixIndex_; }
 set { SetNewMatrixIndex(value); }
 }
 public void SetNewMatrixIndex(Int32 value) { 
 hasNewMatrixIndex = true;
 newMatrixIndex_ = value;
 }

public const int newMatrixIsActiveFieldNumber = 7;
 private bool hasNewMatrixIsActive;
 private Int32 newMatrixIsActive_ = 0;
 public bool HasNewMatrixIsActive {
 get { return hasNewMatrixIsActive; }
 }
 public Int32 NewMatrixIsActive {
 get { return newMatrixIsActive_; }
 set { SetNewMatrixIsActive(value); }
 }
 public void SetNewMatrixIsActive(Int32 value) { 
 hasNewMatrixIsActive = true;
 newMatrixIsActive_ = value;
 }

public const int restBelleIDFieldNumber = 8;
 private bool hasRestBelleID;
 private Int32 restBelleID_ = 0;
 public bool HasRestBelleID {
 get { return hasRestBelleID; }
 }
 public Int32 RestBelleID {
 get { return restBelleID_; }
 set { SetRestBelleID(value); }
 }
 public void SetRestBelleID(Int32 value) { 
 hasRestBelleID = true;
 restBelleID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 if (HasOldMatrixID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, OldMatrixID);
}
 if (HasOldMatrixIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(3, OldMatrixIndex);
}
 if (HasOldMatrixIsActive) {
size += pb::CodedOutputStream.ComputeInt32Size(4, OldMatrixIsActive);
}
 if (HasNewMatrixID) {
size += pb::CodedOutputStream.ComputeInt32Size(5, NewMatrixID);
}
 if (HasNewMatrixIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(6, NewMatrixIndex);
}
 if (HasNewMatrixIsActive) {
size += pb::CodedOutputStream.ComputeInt32Size(7, NewMatrixIsActive);
}
 if (HasRestBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(8, RestBelleID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 
if (HasOldMatrixID) {
output.WriteInt32(2, OldMatrixID);
}
 
if (HasOldMatrixIndex) {
output.WriteInt32(3, OldMatrixIndex);
}
 
if (HasOldMatrixIsActive) {
output.WriteInt32(4, OldMatrixIsActive);
}
 
if (HasNewMatrixID) {
output.WriteInt32(5, NewMatrixID);
}
 
if (HasNewMatrixIndex) {
output.WriteInt32(6, NewMatrixIndex);
}
 
if (HasNewMatrixIsActive) {
output.WriteInt32(7, NewMatrixIsActive);
}
 
if (HasRestBelleID) {
output.WriteInt32(8, RestBelleID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_BATTLE_RET _inst = (GC_BELLE_BATTLE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}
   case  16: {
 _inst.OldMatrixID = input.ReadInt32();
break;
}
   case  24: {
 _inst.OldMatrixIndex = input.ReadInt32();
break;
}
   case  32: {
 _inst.OldMatrixIsActive = input.ReadInt32();
break;
}
   case  40: {
 _inst.NewMatrixID = input.ReadInt32();
break;
}
   case  48: {
 _inst.NewMatrixIndex = input.ReadInt32();
break;
}
   case  56: {
 _inst.NewMatrixIsActive = input.ReadInt32();
break;
}
   case  64: {
 _inst.RestBelleID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 if (!hasOldMatrixID) return false;
 if (!hasOldMatrixIndex) return false;
 if (!hasOldMatrixIsActive) return false;
 if (!hasNewMatrixID) return false;
 if (!hasNewMatrixIndex) return false;
 if (!hasNewMatrixIsActive) return false;
 if (!hasRestBelleID) return false;
 return true;
 }

}


[Serializable]
public class CG_BELLE_REST : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BELLE_REST _inst = (CG_BELLE_REST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_REST_RET : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

public const int matrixIDFieldNumber = 2;
 private bool hasMatrixID;
 private Int32 matrixID_ = 0;
 public bool HasMatrixID {
 get { return hasMatrixID; }
 }
 public Int32 MatrixID {
 get { return matrixID_; }
 set { SetMatrixID(value); }
 }
 public void SetMatrixID(Int32 value) { 
 hasMatrixID = true;
 matrixID_ = value;
 }

public const int matrixIndexFieldNumber = 3;
 private bool hasMatrixIndex;
 private Int32 matrixIndex_ = 0;
 public bool HasMatrixIndex {
 get { return hasMatrixIndex; }
 }
 public Int32 MatrixIndex {
 get { return matrixIndex_; }
 set { SetMatrixIndex(value); }
 }
 public void SetMatrixIndex(Int32 value) { 
 hasMatrixIndex = true;
 matrixIndex_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 if (HasMatrixID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, MatrixID);
}
 if (HasMatrixIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(3, MatrixIndex);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 
if (HasMatrixID) {
output.WriteInt32(2, MatrixID);
}
 
if (HasMatrixIndex) {
output.WriteInt32(3, MatrixIndex);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_REST_RET _inst = (GC_BELLE_REST_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}
   case  16: {
 _inst.MatrixID = input.ReadInt32();
break;
}
   case  24: {
 _inst.MatrixIndex = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 if (!hasMatrixID) return false;
 if (!hasMatrixIndex) return false;
 return true;
 }

}


[Serializable]
public class CG_BELLE_ACTIVEMATRIX : PacketDistributed
{

public const int MatrixIDFieldNumber = 1;
 private bool hasMatrixID;
 private Int32 MatrixID_ = 0;
 public bool HasMatrixID {
 get { return hasMatrixID; }
 }
 public Int32 MatrixID {
 get { return MatrixID_; }
 set { SetMatrixID(value); }
 }
 public void SetMatrixID(Int32 value) { 
 hasMatrixID = true;
 MatrixID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMatrixID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MatrixID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMatrixID) {
output.WriteInt32(1, MatrixID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BELLE_ACTIVEMATRIX _inst = (CG_BELLE_ACTIVEMATRIX) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MatrixID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMatrixID) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_ACTIVEMATRIX_RET : PacketDistributed
{

public const int ActiveMatrixIDFieldNumber = 1;
 private bool hasActiveMatrixID;
 private Int32 ActiveMatrixID_ = 0;
 public bool HasActiveMatrixID {
 get { return hasActiveMatrixID; }
 }
 public Int32 ActiveMatrixID {
 get { return ActiveMatrixID_; }
 set { SetActiveMatrixID(value); }
 }
 public void SetActiveMatrixID(Int32 value) { 
 hasActiveMatrixID = true;
 ActiveMatrixID_ = value;
 }

public const int UnActiveMatrixFieldNumber = 2;
 private bool hasUnActiveMatrix;
 private Int32 UnActiveMatrix_ = 0;
 public bool HasUnActiveMatrix {
 get { return hasUnActiveMatrix; }
 }
 public Int32 UnActiveMatrix {
 get { return UnActiveMatrix_; }
 set { SetUnActiveMatrix(value); }
 }
 public void SetUnActiveMatrix(Int32 value) { 
 hasUnActiveMatrix = true;
 UnActiveMatrix_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasActiveMatrixID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ActiveMatrixID);
}
 if (HasUnActiveMatrix) {
size += pb::CodedOutputStream.ComputeInt32Size(2, UnActiveMatrix);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasActiveMatrixID) {
output.WriteInt32(1, ActiveMatrixID);
}
 
if (HasUnActiveMatrix) {
output.WriteInt32(2, UnActiveMatrix);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_ACTIVEMATRIX_RET _inst = (GC_BELLE_ACTIVEMATRIX_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ActiveMatrixID = input.ReadInt32();
break;
}
   case  16: {
 _inst.UnActiveMatrix = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasActiveMatrixID) return false;
 return true;
 }

}


[Serializable]
public class GC_BELLE_ACTIVE : PacketDistributed
{

public const int belleIDFieldNumber = 1;
 private bool hasBelleID;
 private Int32 belleID_ = 0;
 public bool HasBelleID {
 get { return hasBelleID; }
 }
 public Int32 BelleID {
 get { return belleID_; }
 set { SetBelleID(value); }
 }
 public void SetBelleID(Int32 value) { 
 hasBelleID = true;
 belleID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBelleID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BelleID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBelleID) {
output.WriteInt32(1, BelleID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BELLE_ACTIVE _inst = (GC_BELLE_ACTIVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BelleID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBelleID) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATE_ALL_TITLEINVESTITIVE : PacketDistributed
{

public const int TitleIndexFieldNumber = 1;
 private pbc::PopsicleList<Int32> TitleIndex_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> TitleIndexList {
 get { return pbc::Lists.AsReadOnly(TitleIndex_); }
 }
 
 public int TitleIndexCount {
 get { return TitleIndex_.Count; }
 }
 
public Int32 GetTitleIndex(int index) {
 return TitleIndex_[index];
 }
 public void AddTitleIndex(Int32 value) {
 TitleIndex_.Add(value);
 }

public const int TitleIDFieldNumber = 2;
 private pbc::PopsicleList<Int32> TitleID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> TitleIDList {
 get { return pbc::Lists.AsReadOnly(TitleID_); }
 }
 
 public int TitleIDCount {
 get { return TitleID_.Count; }
 }
 
public Int32 GetTitleID(int index) {
 return TitleID_[index];
 }
 public void AddTitleID(Int32 value) {
 TitleID_.Add(value);
 }

public const int UserDefFullTitleNameFieldNumber = 3;
 private pbc::PopsicleList<string> UserDefFullTitleName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> UserDefFullTitleNameList {
 get { return pbc::Lists.AsReadOnly(UserDefFullTitleName_); }
 }
 
 public int UserDefFullTitleNameCount {
 get { return UserDefFullTitleName_.Count; }
 }
 
public string GetUserDefFullTitleName(int index) {
 return UserDefFullTitleName_[index];
 }
 public void AddUserDefFullTitleName(string value) {
 UserDefFullTitleName_.Add(value);
 }

public const int ActiveTitleFieldNumber = 4;
 private bool hasActiveTitle;
 private Int32 ActiveTitle_ = 0;
 public bool HasActiveTitle {
 get { return hasActiveTitle; }
 }
 public Int32 ActiveTitle {
 get { return ActiveTitle_; }
 set { SetActiveTitle(value); }
 }
 public void SetActiveTitle(Int32 value) { 
 hasActiveTitle = true;
 ActiveTitle_ = value;
 }

public const int IsLockTitleFieldNumber = 5;
 private bool hasIsLockTitle;
 private Int32 IsLockTitle_ = 0;
 public bool HasIsLockTitle {
 get { return hasIsLockTitle; }
 }
 public Int32 IsLockTitle {
 get { return IsLockTitle_; }
 set { SetIsLockTitle(value); }
 }
 public void SetIsLockTitle(Int32 value) { 
 hasIsLockTitle = true;
 IsLockTitle_ = value;
 }

public const int GainTimeFieldNumber = 6;
 private pbc::PopsicleList<Int32> GainTime_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> GainTimeList {
 get { return pbc::Lists.AsReadOnly(GainTime_); }
 }
 
 public int GainTimeCount {
 get { return GainTime_.Count; }
 }
 
public Int32 GetGainTime(int index) {
 return GainTime_[index];
 }
 public void AddGainTime(Int32 value) {
 GainTime_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<TitleIndexList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(TitleIndexList[i]);
}
size += dataSize;
size += 1 * TitleIndex_.Count;
}
{
int dataSize = 0;
for(int i=0; i<TitleIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(TitleIDList[i]);
}
size += dataSize;
size += 1 * TitleID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<UserDefFullTitleNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(UserDefFullTitleNameList[i]);
}
size += dataSize;
size += 1 * UserDefFullTitleName_.Count;
}
 if (HasActiveTitle) {
size += pb::CodedOutputStream.ComputeInt32Size(4, ActiveTitle);
}
 if (HasIsLockTitle) {
size += pb::CodedOutputStream.ComputeInt32Size(5, IsLockTitle);
}
{
int dataSize = 0;
for(int i=0; i<GainTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(GainTimeList[i]);
}
size += dataSize;
size += 1 * GainTime_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (TitleIndex_.Count > 0) {
for(int i=0; i<TitleIndex_.Count; ++i){
output.WriteInt32(1,TitleIndex_[i]);
}
}

}
{
if (TitleID_.Count > 0) {
for(int i=0; i<TitleID_.Count; ++i){
output.WriteInt32(2,TitleID_[i]);
}
}

}
{
if (UserDefFullTitleName_.Count > 0) {
for(int i=0; i<UserDefFullTitleName_.Count; ++i){
output.WriteString(3,UserDefFullTitleName_[i]);
}
}

}
 
if (HasActiveTitle) {
output.WriteInt32(4, ActiveTitle);
}
 
if (HasIsLockTitle) {
output.WriteInt32(5, IsLockTitle);
}
{
if (GainTime_.Count > 0) {
for(int i=0; i<GainTime_.Count; ++i){
output.WriteInt32(6,GainTime_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_ALL_TITLEINVESTITIVE _inst = (GC_UPDATE_ALL_TITLEINVESTITIVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddTitleIndex(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddTitleID(input.ReadInt32());
break;
}
   case  26: {
 _inst.AddUserDefFullTitleName(input.ReadString());
break;
}
   case  32: {
 _inst.ActiveTitle = input.ReadInt32();
break;
}
   case  40: {
 _inst.IsLockTitle = input.ReadInt32();
break;
}
   case  48: {
 _inst.AddGainTime(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasActiveTitle) return false;
 if (!hasIsLockTitle) return false;
 return true;
 }

}


[Serializable]
public class CG_ACTIVE_TITLE : PacketDistributed
{

public const int TitleIndexFieldNumber = 1;
 private bool hasTitleIndex;
 private Int32 TitleIndex_ = 0;
 public bool HasTitleIndex {
 get { return hasTitleIndex; }
 }
 public Int32 TitleIndex {
 get { return TitleIndex_; }
 set { SetTitleIndex(value); }
 }
 public void SetTitleIndex(Int32 value) { 
 hasTitleIndex = true;
 TitleIndex_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTitleIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TitleIndex);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTitleIndex) {
output.WriteInt32(1, TitleIndex);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ACTIVE_TITLE _inst = (CG_ACTIVE_TITLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TitleIndex = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTitleIndex) return false;
 return true;
 }

}


[Serializable]
public class CG_DELETE_TITLE : PacketDistributed
{

public const int TitleIndexFieldNumber = 1;
 private bool hasTitleIndex;
 private Int32 TitleIndex_ = 0;
 public bool HasTitleIndex {
 get { return hasTitleIndex; }
 }
 public Int32 TitleIndex {
 get { return TitleIndex_; }
 set { SetTitleIndex(value); }
 }
 public void SetTitleIndex(Int32 value) { 
 hasTitleIndex = true;
 TitleIndex_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTitleIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TitleIndex);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTitleIndex) {
output.WriteInt32(1, TitleIndex);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_DELETE_TITLE _inst = (CG_DELETE_TITLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TitleIndex = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTitleIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_GAIN_TITLE : PacketDistributed
{

public const int TitleIndexFieldNumber = 1;
 private bool hasTitleIndex;
 private Int32 TitleIndex_ = 0;
 public bool HasTitleIndex {
 get { return hasTitleIndex; }
 }
 public Int32 TitleIndex {
 get { return TitleIndex_; }
 set { SetTitleIndex(value); }
 }
 public void SetTitleIndex(Int32 value) { 
 hasTitleIndex = true;
 TitleIndex_ = value;
 }

public const int TitleIDFieldNumber = 2;
 private bool hasTitleID;
 private Int32 TitleID_ = 0;
 public bool HasTitleID {
 get { return hasTitleID; }
 }
 public Int32 TitleID {
 get { return TitleID_; }
 set { SetTitleID(value); }
 }
 public void SetTitleID(Int32 value) { 
 hasTitleID = true;
 TitleID_ = value;
 }

public const int UserDefFullTitleNameFieldNumber = 3;
 private bool hasUserDefFullTitleName;
 private string UserDefFullTitleName_ = "";
 public bool HasUserDefFullTitleName {
 get { return hasUserDefFullTitleName; }
 }
 public string UserDefFullTitleName {
 get { return UserDefFullTitleName_; }
 set { SetUserDefFullTitleName(value); }
 }
 public void SetUserDefFullTitleName(string value) { 
 hasUserDefFullTitleName = true;
 UserDefFullTitleName_ = value;
 }

public const int ActiveTitleFieldNumber = 4;
 private bool hasActiveTitle;
 private Int32 ActiveTitle_ = 0;
 public bool HasActiveTitle {
 get { return hasActiveTitle; }
 }
 public Int32 ActiveTitle {
 get { return ActiveTitle_; }
 set { SetActiveTitle(value); }
 }
 public void SetActiveTitle(Int32 value) { 
 hasActiveTitle = true;
 ActiveTitle_ = value;
 }

public const int GainTimeFieldNumber = 5;
 private bool hasGainTime;
 private Int32 GainTime_ = 0;
 public bool HasGainTime {
 get { return hasGainTime; }
 }
 public Int32 GainTime {
 get { return GainTime_; }
 set { SetGainTime(value); }
 }
 public void SetGainTime(Int32 value) { 
 hasGainTime = true;
 GainTime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTitleIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TitleIndex);
}
 if (HasTitleID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, TitleID);
}
 if (HasUserDefFullTitleName) {
size += pb::CodedOutputStream.ComputeStringSize(3, UserDefFullTitleName);
}
 if (HasActiveTitle) {
size += pb::CodedOutputStream.ComputeInt32Size(4, ActiveTitle);
}
 if (HasGainTime) {
size += pb::CodedOutputStream.ComputeInt32Size(5, GainTime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTitleIndex) {
output.WriteInt32(1, TitleIndex);
}
 
if (HasTitleID) {
output.WriteInt32(2, TitleID);
}
 
if (HasUserDefFullTitleName) {
output.WriteString(3, UserDefFullTitleName);
}
 
if (HasActiveTitle) {
output.WriteInt32(4, ActiveTitle);
}
 
if (HasGainTime) {
output.WriteInt32(5, GainTime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_GAIN_TITLE _inst = (GC_GAIN_TITLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TitleIndex = input.ReadInt32();
break;
}
   case  16: {
 _inst.TitleID = input.ReadInt32();
break;
}
   case  26: {
 _inst.UserDefFullTitleName = input.ReadString();
break;
}
   case  32: {
 _inst.ActiveTitle = input.ReadInt32();
break;
}
   case  40: {
 _inst.GainTime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTitleIndex) return false;
 if (!hasTitleID) return false;
 if (!hasActiveTitle) return false;
 return true;
 }

}


[Serializable]
public class GC_DELETE_TITLE : PacketDistributed
{

public const int TitleIndexFieldNumber = 1;
 private bool hasTitleIndex;
 private Int32 TitleIndex_ = 0;
 public bool HasTitleIndex {
 get { return hasTitleIndex; }
 }
 public Int32 TitleIndex {
 get { return TitleIndex_; }
 set { SetTitleIndex(value); }
 }
 public void SetTitleIndex(Int32 value) { 
 hasTitleIndex = true;
 TitleIndex_ = value;
 }

public const int ActiveTitleFieldNumber = 2;
 private bool hasActiveTitle;
 private Int32 ActiveTitle_ = 0;
 public bool HasActiveTitle {
 get { return hasActiveTitle; }
 }
 public Int32 ActiveTitle {
 get { return ActiveTitle_; }
 set { SetActiveTitle(value); }
 }
 public void SetActiveTitle(Int32 value) { 
 hasActiveTitle = true;
 ActiveTitle_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTitleIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TitleIndex);
}
 if (HasActiveTitle) {
size += pb::CodedOutputStream.ComputeInt32Size(2, ActiveTitle);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTitleIndex) {
output.WriteInt32(1, TitleIndex);
}
 
if (HasActiveTitle) {
output.WriteInt32(2, ActiveTitle);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DELETE_TITLE _inst = (GC_DELETE_TITLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TitleIndex = input.ReadInt32();
break;
}
   case  16: {
 _inst.ActiveTitle = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTitleIndex) return false;
 if (!hasActiveTitle) return false;
 return true;
 }

}


[Serializable]
public class GC_ACTIVE_TITLE : PacketDistributed
{

public const int TitleIndexFieldNumber = 1;
 private bool hasTitleIndex;
 private Int32 TitleIndex_ = 0;
 public bool HasTitleIndex {
 get { return hasTitleIndex; }
 }
 public Int32 TitleIndex {
 get { return TitleIndex_; }
 set { SetTitleIndex(value); }
 }
 public void SetTitleIndex(Int32 value) { 
 hasTitleIndex = true;
 TitleIndex_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTitleIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TitleIndex);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTitleIndex) {
output.WriteInt32(1, TitleIndex);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ACTIVE_TITLE _inst = (GC_ACTIVE_TITLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TitleIndex = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTitleIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_SYNC_ACTIVETITLE : PacketDistributed
{

public const int serveridFieldNumber = 1;
 private bool hasServerid;
 private Int32 serverid_ = 0;
 public bool HasServerid {
 get { return hasServerid; }
 }
 public Int32 Serverid {
 get { return serverid_; }
 set { SetServerid(value); }
 }
 public void SetServerid(Int32 value) { 
 hasServerid = true;
 serverid_ = value;
 }

public const int titleidFieldNumber = 2;
 private bool hasTitleid;
 private Int32 titleid_ = 0;
 public bool HasTitleid {
 get { return hasTitleid; }
 }
 public Int32 Titleid {
 get { return titleid_; }
 set { SetTitleid(value); }
 }
 public void SetTitleid(Int32 value) { 
 hasTitleid = true;
 titleid_ = value;
 }

public const int titlenameFieldNumber = 3;
 private bool hasTitlename;
 private string titlename_ = "";
 public bool HasTitlename {
 get { return hasTitlename; }
 }
 public string Titlename {
 get { return titlename_; }
 set { SetTitlename(value); }
 }
 public void SetTitlename(string value) { 
 hasTitlename = true;
 titlename_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerid) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Serverid);
}
 if (HasTitleid) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Titleid);
}
 if (HasTitlename) {
size += pb::CodedOutputStream.ComputeStringSize(3, Titlename);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerid) {
output.WriteInt32(1, Serverid);
}
 
if (HasTitleid) {
output.WriteInt32(2, Titleid);
}
 
if (HasTitlename) {
output.WriteString(3, Titlename);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_ACTIVETITLE _inst = (GC_SYNC_ACTIVETITLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Serverid = input.ReadInt32();
break;
}
   case  16: {
 _inst.Titleid = input.ReadInt32();
break;
}
   case  26: {
 _inst.Titlename = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerid) return false;
 if (!hasTitleid) return false;
 return true;
 }

}


[Serializable]
public class GC_MOUNTCOLLECTED_FLAG : PacketDistributed
{

public const int AutoMountFlagFieldNumber = 1;
 private bool hasAutoMountFlag;
 private Int32 AutoMountFlag_ = 0;
 public bool HasAutoMountFlag {
 get { return hasAutoMountFlag; }
 }
 public Int32 AutoMountFlag {
 get { return AutoMountFlag_; }
 set { SetAutoMountFlag(value); }
 }
 public void SetAutoMountFlag(Int32 value) { 
 hasAutoMountFlag = true;
 AutoMountFlag_ = value;
 }

public const int CurMountIDFieldNumber = 2;
 private bool hasCurMountID;
 private Int32 CurMountID_ = 0;
 public bool HasCurMountID {
 get { return hasCurMountID; }
 }
 public Int32 CurMountID {
 get { return CurMountID_; }
 set { SetCurMountID(value); }
 }
 public void SetCurMountID(Int32 value) { 
 hasCurMountID = true;
 CurMountID_ = value;
 }

public const int MountCollectedFlagFieldNumber = 3;
 private pbc::PopsicleList<Int32> MountCollectedFlag_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> MountCollectedFlagList {
 get { return pbc::Lists.AsReadOnly(MountCollectedFlag_); }
 }
 
 public int MountCollectedFlagCount {
 get { return MountCollectedFlag_.Count; }
 }
 
public Int32 GetMountCollectedFlag(int index) {
 return MountCollectedFlag_[index];
 }
 public void AddMountCollectedFlag(Int32 value) {
 MountCollectedFlag_.Add(value);
 }

public const int MountLeftTimeFieldNumber = 4;
 private pbc::PopsicleList<Int32> MountLeftTime_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> MountLeftTimeList {
 get { return pbc::Lists.AsReadOnly(MountLeftTime_); }
 }
 
 public int MountLeftTimeCount {
 get { return MountLeftTime_.Count; }
 }
 
public Int32 GetMountLeftTime(int index) {
 return MountLeftTime_[index];
 }
 public void AddMountLeftTime(Int32 value) {
 MountLeftTime_.Add(value);
 }

public const int MountRemindFlagFieldNumber = 5;
 private pbc::PopsicleList<Int32> MountRemindFlag_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> MountRemindFlagList {
 get { return pbc::Lists.AsReadOnly(MountRemindFlag_); }
 }
 
 public int MountRemindFlagCount {
 get { return MountRemindFlag_.Count; }
 }
 
public Int32 GetMountRemindFlag(int index) {
 return MountRemindFlag_[index];
 }
 public void AddMountRemindFlag(Int32 value) {
 MountRemindFlag_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasAutoMountFlag) {
size += pb::CodedOutputStream.ComputeInt32Size(1, AutoMountFlag);
}
 if (HasCurMountID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, CurMountID);
}
{
int dataSize = 0;
for(int i=0; i<MountCollectedFlagList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(MountCollectedFlagList[i]);
}
size += dataSize;
size += 1 * MountCollectedFlag_.Count;
}
{
int dataSize = 0;
for(int i=0; i<MountLeftTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(MountLeftTimeList[i]);
}
size += dataSize;
size += 1 * MountLeftTime_.Count;
}
{
int dataSize = 0;
for(int i=0; i<MountRemindFlagList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(MountRemindFlagList[i]);
}
size += dataSize;
size += 1 * MountRemindFlag_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasAutoMountFlag) {
output.WriteInt32(1, AutoMountFlag);
}
 
if (HasCurMountID) {
output.WriteInt32(2, CurMountID);
}
{
if (MountCollectedFlag_.Count > 0) {
for(int i=0; i<MountCollectedFlag_.Count; ++i){
output.WriteInt32(3,MountCollectedFlag_[i]);
}
}

}
{
if (MountLeftTime_.Count > 0) {
for(int i=0; i<MountLeftTime_.Count; ++i){
output.WriteInt32(4,MountLeftTime_[i]);
}
}

}
{
if (MountRemindFlag_.Count > 0) {
for(int i=0; i<MountRemindFlag_.Count; ++i){
output.WriteInt32(5,MountRemindFlag_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MOUNTCOLLECTED_FLAG _inst = (GC_MOUNTCOLLECTED_FLAG) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AutoMountFlag = input.ReadInt32();
break;
}
   case  16: {
 _inst.CurMountID = input.ReadInt32();
break;
}
   case  24: {
 _inst.AddMountCollectedFlag(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddMountLeftTime(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddMountRemindFlag(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasAutoMountFlag) return false;
 if (!hasCurMountID) return false;
 return true;
 }

}


[Serializable]
public class GC_MOUNT_DATA : PacketDistributed
{

public const int ObjServerIDFieldNumber = 1;
 private bool hasObjServerID;
 private Int32 ObjServerID_ = 0;
 public bool HasObjServerID {
 get { return hasObjServerID; }
 }
 public Int32 ObjServerID {
 get { return ObjServerID_; }
 set { SetObjServerID(value); }
 }
 public void SetObjServerID(Int32 value) { 
 hasObjServerID = true;
 ObjServerID_ = value;
 }

public const int MountIDFieldNumber = 2;
 private bool hasMountID;
 private Int32 MountID_ = 0;
 public bool HasMountID {
 get { return hasMountID; }
 }
 public Int32 MountID {
 get { return MountID_; }
 set { SetMountID(value); }
 }
 public void SetMountID(Int32 value) { 
 hasMountID = true;
 MountID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjServerID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjServerID);
}
 if (HasMountID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, MountID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjServerID) {
output.WriteInt32(1, ObjServerID);
}
 
if (HasMountID) {
output.WriteInt32(2, MountID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MOUNT_DATA _inst = (GC_MOUNT_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjServerID = input.ReadInt32();
break;
}
   case  16: {
 _inst.MountID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjServerID) return false;
 if (!hasMountID) return false;
 return true;
 }

}


[Serializable]
public class CG_MOUNT_MARK : PacketDistributed
{

public const int MountIDFieldNumber = 1;
 private bool hasMountID;
 private Int32 MountID_ = 0;
 public bool HasMountID {
 get { return hasMountID; }
 }
 public Int32 MountID {
 get { return MountID_; }
 set { SetMountID(value); }
 }
 public void SetMountID(Int32 value) { 
 hasMountID = true;
 MountID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMountID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MountID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMountID) {
output.WriteInt32(1, MountID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MOUNT_MARK _inst = (CG_MOUNT_MARK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MountID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMountID) return false;
 return true;
 }

}


[Serializable]
public class GC_MOUNT_MARK_RET : PacketDistributed
{

public const int MountIDFieldNumber = 1;
 private bool hasMountID;
 private Int32 MountID_ = 0;
 public bool HasMountID {
 get { return hasMountID; }
 }
 public Int32 MountID {
 get { return MountID_; }
 set { SetMountID(value); }
 }
 public void SetMountID(Int32 value) { 
 hasMountID = true;
 MountID_ = value;
 }

public const int RetFieldNumber = 2;
 private bool hasRet;
 private Int32 Ret_ = 0;
 public bool HasRet {
 get { return hasRet; }
 }
 public Int32 Ret {
 get { return Ret_; }
 set { SetRet(value); }
 }
 public void SetRet(Int32 value) { 
 hasRet = true;
 Ret_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMountID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MountID);
}
 if (HasRet) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Ret);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMountID) {
output.WriteInt32(1, MountID);
}
 
if (HasRet) {
output.WriteInt32(2, Ret);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MOUNT_MARK_RET _inst = (GC_MOUNT_MARK_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MountID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Ret = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMountID) return false;
 if (!hasRet) return false;
 return true;
 }

}


[Serializable]
public class CG_MOUNT_MOUNT : PacketDistributed
{

public const int MountIDFieldNumber = 1;
 private bool hasMountID;
 private Int32 MountID_ = 0;
 public bool HasMountID {
 get { return hasMountID; }
 }
 public Int32 MountID {
 get { return MountID_; }
 set { SetMountID(value); }
 }
 public void SetMountID(Int32 value) { 
 hasMountID = true;
 MountID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMountID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MountID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMountID) {
output.WriteInt32(1, MountID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MOUNT_MOUNT _inst = (CG_MOUNT_MOUNT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MountID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMountID) return false;
 return true;
 }

}


[Serializable]
public class CG_MOUNT_UNMOUNT : PacketDistributed
{

public const int MountIDFieldNumber = 1;
 private bool hasMountID;
 private Int32 MountID_ = 0;
 public bool HasMountID {
 get { return hasMountID; }
 }
 public Int32 MountID {
 get { return MountID_; }
 set { SetMountID(value); }
 }
 public void SetMountID(Int32 value) { 
 hasMountID = true;
 MountID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMountID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, MountID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMountID) {
output.WriteInt32(1, MountID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MOUNT_UNMOUNT _inst = (CG_MOUNT_UNMOUNT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MountID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMountID) return false;
 return true;
 }

}


[Serializable]
public class CG_EQUIP_ENCHANCE : PacketDistributed
{

public const int packtypeFieldNumber = 1;
 private bool hasPacktype;
 private Int32 packtype_ = 0;
 public bool HasPacktype {
 get { return hasPacktype; }
 }
 public Int32 Packtype {
 get { return packtype_; }
 set { SetPacktype(value); }
 }
 public void SetPacktype(Int32 value) { 
 hasPacktype = true;
 packtype_ = value;
 }

public const int equipguidFieldNumber = 2;
 private bool hasEquipguid;
 private UInt64 equipguid_ = 0;
 public bool HasEquipguid {
 get { return hasEquipguid; }
 }
 public UInt64 Equipguid {
 get { return equipguid_; }
 set { SetEquipguid(value); }
 }
 public void SetEquipguid(UInt64 value) { 
 hasEquipguid = true;
 equipguid_ = value;
 }

public const int materialguidFieldNumber = 3;
 private pbc::PopsicleList<UInt64> materialguid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> materialguidList {
 get { return pbc::Lists.AsReadOnly(materialguid_); }
 }
 
 public int materialguidCount {
 get { return materialguid_.Count; }
 }
 
public UInt64 GetMaterialguid(int index) {
 return materialguid_[index];
 }
 public void AddMaterialguid(UInt64 value) {
 materialguid_.Add(value);
 }

public const int materialcountFieldNumber = 4;
 private pbc::PopsicleList<Int32> materialcount_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> materialcountList {
 get { return pbc::Lists.AsReadOnly(materialcount_); }
 }
 
 public int materialcountCount {
 get { return materialcount_.Count; }
 }
 
public Int32 GetMaterialcount(int index) {
 return materialcount_[index];
 }
 public void AddMaterialcount(Int32 value) {
 materialcount_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPacktype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Packtype);
}
 if (HasEquipguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Equipguid);
}
{
int dataSize = 0;
for(int i=0; i<materialguidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(materialguidList[i]);
}
size += dataSize;
size += 1 * materialguid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<materialcountList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(materialcountList[i]);
}
size += dataSize;
size += 1 * materialcount_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPacktype) {
output.WriteInt32(1, Packtype);
}
 
if (HasEquipguid) {
output.WriteUInt64(2, Equipguid);
}
{
if (materialguid_.Count > 0) {
for(int i=0; i<materialguid_.Count; ++i){
output.WriteUInt64(3,materialguid_[i]);
}
}

}
{
if (materialcount_.Count > 0) {
for(int i=0; i<materialcount_.Count; ++i){
output.WriteInt32(4,materialcount_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_EQUIP_ENCHANCE _inst = (CG_EQUIP_ENCHANCE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Packtype = input.ReadInt32();
break;
}
   case  16: {
 _inst.Equipguid = input.ReadUInt64();
break;
}
   case  24: {
 _inst.AddMaterialguid(input.ReadUInt64());
break;
}
   case  32: {
 _inst.AddMaterialcount(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPacktype) return false;
 if (!hasEquipguid) return false;
 return true;
 }

}


[Serializable]
public class CG_EQUIP_STAR : PacketDistributed
{

public const int packtypeFieldNumber = 1;
 private bool hasPacktype;
 private Int32 packtype_ = 0;
 public bool HasPacktype {
 get { return hasPacktype; }
 }
 public Int32 Packtype {
 get { return packtype_; }
 set { SetPacktype(value); }
 }
 public void SetPacktype(Int32 value) { 
 hasPacktype = true;
 packtype_ = value;
 }

public const int equipguidFieldNumber = 2;
 private bool hasEquipguid;
 private UInt64 equipguid_ = 0;
 public bool HasEquipguid {
 get { return hasEquipguid; }
 }
 public UInt64 Equipguid {
 get { return equipguid_; }
 set { SetEquipguid(value); }
 }
 public void SetEquipguid(UInt64 value) { 
 hasEquipguid = true;
 equipguid_ = value;
 }

public const int starlevelFieldNumber = 3;
 private bool hasStarlevel;
 private Int32 starlevel_ = 0;
 public bool HasStarlevel {
 get { return hasStarlevel; }
 }
 public Int32 Starlevel {
 get { return starlevel_; }
 set { SetStarlevel(value); }
 }
 public void SetStarlevel(Int32 value) { 
 hasStarlevel = true;
 starlevel_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPacktype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Packtype);
}
 if (HasEquipguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Equipguid);
}
 if (HasStarlevel) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Starlevel);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPacktype) {
output.WriteInt32(1, Packtype);
}
 
if (HasEquipguid) {
output.WriteUInt64(2, Equipguid);
}
 
if (HasStarlevel) {
output.WriteInt32(3, Starlevel);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_EQUIP_STAR _inst = (CG_EQUIP_STAR) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Packtype = input.ReadInt32();
break;
}
   case  16: {
 _inst.Equipguid = input.ReadUInt64();
break;
}
   case  24: {
 _inst.Starlevel = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPacktype) return false;
 if (!hasEquipguid) return false;
 return true;
 }

}


[Serializable]
public class GC_EQUIP_ENCHANCE_RET : PacketDistributed
{

public const int successFieldNumber = 1;
 private bool hasSuccess;
 private Int32 success_ = 0;
 public bool HasSuccess {
 get { return hasSuccess; }
 }
 public Int32 Success {
 get { return success_; }
 set { SetSuccess(value); }
 }
 public void SetSuccess(Int32 value) { 
 hasSuccess = true;
 success_ = value;
 }

public const int packtypeFieldNumber = 2;
 private bool hasPacktype;
 private Int32 packtype_ = 0;
 public bool HasPacktype {
 get { return hasPacktype; }
 }
 public Int32 Packtype {
 get { return packtype_; }
 set { SetPacktype(value); }
 }
 public void SetPacktype(Int32 value) { 
 hasPacktype = true;
 packtype_ = value;
 }

public const int equipguidFieldNumber = 3;
 private bool hasEquipguid;
 private UInt64 equipguid_ = 0;
 public bool HasEquipguid {
 get { return hasEquipguid; }
 }
 public UInt64 Equipguid {
 get { return equipguid_; }
 set { SetEquipguid(value); }
 }
 public void SetEquipguid(UInt64 value) { 
 hasEquipguid = true;
 equipguid_ = value;
 }

public const int expFieldNumber = 4;
 private bool hasExp;
 private Int32 exp_ = 0;
 public bool HasExp {
 get { return hasExp; }
 }
 public Int32 Exp {
 get { return exp_; }
 set { SetExp(value); }
 }
 public void SetExp(Int32 value) { 
 hasExp = true;
 exp_ = value;
 }

public const int inclevelFieldNumber = 5;
 private bool hasInclevel;
 private Int32 inclevel_ = 0;
 public bool HasInclevel {
 get { return hasInclevel; }
 }
 public Int32 Inclevel {
 get { return inclevel_; }
 set { SetInclevel(value); }
 }
 public void SetInclevel(Int32 value) { 
 hasInclevel = true;
 inclevel_ = value;
 }

public const int hittimesFieldNumber = 6;
 private bool hasHittimes;
 private Int32 hittimes_ = 0;
 public bool HasHittimes {
 get { return hasHittimes; }
 }
 public Int32 Hittimes {
 get { return hittimes_; }
 set { SetHittimes(value); }
 }
 public void SetHittimes(Int32 value) { 
 hasHittimes = true;
 hittimes_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSuccess) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Success);
}
 if (HasPacktype) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Packtype);
}
 if (HasEquipguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, Equipguid);
}
 if (HasExp) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Exp);
}
 if (HasInclevel) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Inclevel);
}
 if (HasHittimes) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Hittimes);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSuccess) {
output.WriteInt32(1, Success);
}
 
if (HasPacktype) {
output.WriteInt32(2, Packtype);
}
 
if (HasEquipguid) {
output.WriteUInt64(3, Equipguid);
}
 
if (HasExp) {
output.WriteInt32(4, Exp);
}
 
if (HasInclevel) {
output.WriteInt32(5, Inclevel);
}
 
if (HasHittimes) {
output.WriteInt32(6, Hittimes);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_EQUIP_ENCHANCE_RET _inst = (GC_EQUIP_ENCHANCE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Success = input.ReadInt32();
break;
}
   case  16: {
 _inst.Packtype = input.ReadInt32();
break;
}
   case  24: {
 _inst.Equipguid = input.ReadUInt64();
break;
}
   case  32: {
 _inst.Exp = input.ReadInt32();
break;
}
   case  40: {
 _inst.Inclevel = input.ReadInt32();
break;
}
   case  48: {
 _inst.Hittimes = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSuccess) return false;
 if (!hasPacktype) return false;
 if (!hasEquipguid) return false;
 if (!hasExp) return false;
 if (!hasInclevel) return false;
 if (!hasHittimes) return false;
 return true;
 }

}


[Serializable]
public class GC_EQUIP_STAR_RET : PacketDistributed
{

public const int successFieldNumber = 1;
 private bool hasSuccess;
 private Int32 success_ = 0;
 public bool HasSuccess {
 get { return hasSuccess; }
 }
 public Int32 Success {
 get { return success_; }
 set { SetSuccess(value); }
 }
 public void SetSuccess(Int32 value) { 
 hasSuccess = true;
 success_ = value;
 }

public const int packtypeFieldNumber = 2;
 private bool hasPacktype;
 private Int32 packtype_ = 0;
 public bool HasPacktype {
 get { return hasPacktype; }
 }
 public Int32 Packtype {
 get { return packtype_; }
 set { SetPacktype(value); }
 }
 public void SetPacktype(Int32 value) { 
 hasPacktype = true;
 packtype_ = value;
 }

public const int equipguidFieldNumber = 3;
 private bool hasEquipguid;
 private UInt64 equipguid_ = 0;
 public bool HasEquipguid {
 get { return hasEquipguid; }
 }
 public UInt64 Equipguid {
 get { return equipguid_; }
 set { SetEquipguid(value); }
 }
 public void SetEquipguid(UInt64 value) { 
 hasEquipguid = true;
 equipguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSuccess) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Success);
}
 if (HasPacktype) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Packtype);
}
 if (HasEquipguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, Equipguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSuccess) {
output.WriteInt32(1, Success);
}
 
if (HasPacktype) {
output.WriteInt32(2, Packtype);
}
 
if (HasEquipguid) {
output.WriteUInt64(3, Equipguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_EQUIP_STAR_RET _inst = (GC_EQUIP_STAR_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Success = input.ReadInt32();
break;
}
   case  16: {
 _inst.Packtype = input.ReadInt32();
break;
}
   case  24: {
 _inst.Equipguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSuccess) return false;
 if (!hasPacktype) return false;
 if (!hasEquipguid) return false;
 return true;
 }

}


[Serializable]
public class CG_CHAT : PacketDistributed
{
public enum CHATTYPE 
 { 
  CHAT_TYPE_INVALID    = 0, 
  CHAT_TYPE_NORMAL     = 1,  // ����Ƶ�� 
  CHAT_TYPE_TELL     = 2,  // ����Ƶ�� 
  CHAT_TYPE_TEAM     = 3,  // ����Ƶ�� 
  CHAT_TYPE_GUILD     = 4,  // ���Ƶ�� 
  CHAT_TYPE_WORLD     = 5,  // ����Ƶ�� 
  CHAT_TYPE_SYSTEM    = 6,  // ϵͳƵ�� 
  CHAT_TYPE_LOUDSPEAKER  = 7,  // С���� 
  CHAT_TYPE_FRIEND    = 8,  // ����Ƶ�� 
  CHAT_TYPE_MASTER    = 9,  // ʦ��Ƶ�� 
  CHAT_TYPE_PROPAGATE             = 10,       //��ֳƵ�� 
  CHAT_TYPE_VARIOUS               = 11,       //�ۺ�Ƶ�� 
 }
public const int chattypeFieldNumber = 1;
 private bool hasChattype;
 private Int32 chattype_ = 0;
 public bool HasChattype {
 get { return hasChattype; }
 }
 public Int32 Chattype {
 get { return chattype_; }
 set { SetChattype(value); }
 }
 public void SetChattype(Int32 value) { 
 hasChattype = true;
 chattype_ = value;
 }

public const int chatinfoFieldNumber = 2;
 private bool hasChatinfo;
 private string chatinfo_ = "";
 public bool HasChatinfo {
 get { return hasChatinfo; }
 }
 public string Chatinfo {
 get { return chatinfo_; }
 set { SetChatinfo(value); }
 }
 public void SetChatinfo(string value) { 
 hasChatinfo = true;
 chatinfo_ = value;
 }

public const int receiverguidFieldNumber = 3;
 private bool hasReceiverguid;
 private UInt64 receiverguid_ = 0;
 public bool HasReceiverguid {
 get { return hasReceiverguid; }
 }
 public UInt64 Receiverguid {
 get { return receiverguid_; }
 set { SetReceiverguid(value); }
 }
 public void SetReceiverguid(UInt64 value) { 
 hasReceiverguid = true;
 receiverguid_ = value;
 }

public const int receivernameFieldNumber = 4;
 private bool hasReceivername;
 private string receivername_ = "";
 public bool HasReceivername {
 get { return hasReceivername; }
 }
 public string Receivername {
 get { return receivername_; }
 set { SetReceivername(value); }
 }
 public void SetReceivername(string value) { 
 hasReceivername = true;
 receivername_ = value;
 }
public enum LINKTYPE 
 { 
  LINK_TYPE_INVALID   = 0, 
  LINK_TYPE_ITEM    = 1,   // ��Ʒ���� 
  LINK_TYPE_EQUIP    = 2,   // װ������ 
  LINK_TYPE_COPYTEAM   = 3,   // ������� 
  LINK_TYPE_MOVETO   = 4,   // Ѱ· 
  LINK_TYPE_PLAYERINFO = 5,   // ������Ϣ 
  LINK_TYPE_SWORDSMAN  = 6,   // ������Ϣ 
  LINK_TYPE_GUILDCRUITE = 7,   // �����ļ 
  LINK_TYPE_HONGBAO   = 8,   // ����� 
  LINK_TYPE_PROPAGATE         = 9,            //��ֳ���� 
  LINK_TYPE_MISSION           = 10,           //�������� 
  LINK_TYPE_SUB_PROPAGATE     = 11,           //��ֳ�����ӣ�������ʾ�Լ��ܷ�ֳ�б��� 
  LINK_TYPE_PROPAGATE_ACCEPT  = 12,           //��ֳͬ��ķ������ӣ��Ͳ�Ҫ���������ˣ��������ƾ������ˣ����Űɣ����̾��߰ɡ��� 
  LINK_TYPE_PROPAGATE_AGREE   = 13,           //��ֳͬ�ⷵ������    
 }
public const int linktypeFieldNumber = 5;
 private bool hasLinktype;
 private Int32 linktype_ = 0;
 public bool HasLinktype {
 get { return hasLinktype; }
 }
 public Int32 Linktype {
 get { return linktype_; }
 set { SetLinktype(value); }
 }
 public void SetLinktype(Int32 value) { 
 hasLinktype = true;
 linktype_ = value;
 }

public const int intdataFieldNumber = 6;
 private pbc::PopsicleList<Int32> intdata_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> intdataList {
 get { return pbc::Lists.AsReadOnly(intdata_); }
 }
 
 public int intdataCount {
 get { return intdata_.Count; }
 }
 
public Int32 GetIntdata(int index) {
 return intdata_[index];
 }
 public void AddIntdata(Int32 value) {
 intdata_.Add(value);
 }

public const int strdataFieldNumber = 7;
 private pbc::PopsicleList<string> strdata_ = new pbc::PopsicleList<string>();
 public scg::IList<string> strdataList {
 get { return pbc::Lists.AsReadOnly(strdata_); }
 }
 
 public int strdataCount {
 get { return strdata_.Count; }
 }
 
public string GetStrdata(int index) {
 return strdata_[index];
 }
 public void AddStrdata(string value) {
 strdata_.Add(value);
 }

public const int LoudSpeakerNumFieldNumber = 8;
 private bool hasLoudSpeakerNum;
 private Int32 LoudSpeakerNum_ = 0;
 public bool HasLoudSpeakerNum {
 get { return hasLoudSpeakerNum; }
 }
 public Int32 LoudSpeakerNum {
 get { return LoudSpeakerNum_; }
 set { SetLoudSpeakerNum(value); }
 }
 public void SetLoudSpeakerNum(Int32 value) { 
 hasLoudSpeakerNum = true;
 LoudSpeakerNum_ = value;
 }

public const int VoiceChatFieldNumber = 9;
 private bool hasVoiceChat;
 private  pb::ByteString VoiceChat_ = pb::ByteString.Empty;
 public bool HasVoiceChat {
 get { return hasVoiceChat; }
 }
 public  pb::ByteString VoiceChat {
 get { return VoiceChat_; }
 set { SetVoiceChat(value); }
 }
 public void SetVoiceChat( pb::ByteString value) { 
 hasVoiceChat = true;
 VoiceChat_ = value;
 }

public const int isYaoHeFieldNumber = 10;
 private bool hasIsYaoHe;
 private Int32 isYaoHe_ = 0;
 public bool HasIsYaoHe {
 get { return hasIsYaoHe; }
 }
 public Int32 IsYaoHe {
 get { return isYaoHe_; }
 set { SetIsYaoHe(value); }
 }
 public void SetIsYaoHe(Int32 value) { 
 hasIsYaoHe = true;
 isYaoHe_ = value;
 }
public enum   ANOYMOUS_STATE 
 { 
  NORMAL = 0, 
  ANOYMOUS = 1, 
 }
public const int anoymousStateFieldNumber = 11;
 private bool hasAnoymousState;
 private Int32 anoymousState_ = 0;
 public bool HasAnoymousState {
 get { return hasAnoymousState; }
 }
 public Int32 AnoymousState {
 get { return anoymousState_; }
 set { SetAnoymousState(value); }
 }
 public void SetAnoymousState(Int32 value) { 
 hasAnoymousState = true;
 anoymousState_ = value;
 }

public const int fellowguidFieldNumber = 12;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasChattype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Chattype);
}
 if (HasChatinfo) {
size += pb::CodedOutputStream.ComputeStringSize(2, Chatinfo);
}
 if (HasReceiverguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, Receiverguid);
}
 if (HasReceivername) {
size += pb::CodedOutputStream.ComputeStringSize(4, Receivername);
}
 if (HasLinktype) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Linktype);
}
{
int dataSize = 0;
for(int i=0; i<intdataList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(intdataList[i]);
}
size += dataSize;
size += 1 * intdata_.Count;
}
{
int dataSize = 0;
for(int i=0; i<strdataList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(strdataList[i]);
}
size += dataSize;
size += 1 * strdata_.Count;
}
 if (HasLoudSpeakerNum) {
size += pb::CodedOutputStream.ComputeInt32Size(8, LoudSpeakerNum);
}
 if (HasVoiceChat) {
size += pb::CodedOutputStream.ComputeBytesSize(9, VoiceChat);
}
 if (HasIsYaoHe) {
size += pb::CodedOutputStream.ComputeInt32Size(10, IsYaoHe);
}
 if (HasAnoymousState) {
size += pb::CodedOutputStream.ComputeInt32Size(11, AnoymousState);
}
 if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(12, Fellowguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasChattype) {
output.WriteInt32(1, Chattype);
}
 
if (HasChatinfo) {
output.WriteString(2, Chatinfo);
}
 
if (HasReceiverguid) {
output.WriteUInt64(3, Receiverguid);
}
 
if (HasReceivername) {
output.WriteString(4, Receivername);
}
 
if (HasLinktype) {
output.WriteInt32(5, Linktype);
}
{
if (intdata_.Count > 0) {
for(int i=0; i<intdata_.Count; ++i){
output.WriteInt32(6,intdata_[i]);
}
}

}
{
if (strdata_.Count > 0) {
for(int i=0; i<strdata_.Count; ++i){
output.WriteString(7,strdata_[i]);
}
}

}
 
if (HasLoudSpeakerNum) {
output.WriteInt32(8, LoudSpeakerNum);
}
 
if (HasVoiceChat) {
output.WriteBytes(9, VoiceChat);
}
 
if (HasIsYaoHe) {
output.WriteInt32(10, IsYaoHe);
}
 
if (HasAnoymousState) {
output.WriteInt32(11, AnoymousState);
}
 
if (HasFellowguid) {
output.WriteUInt64(12, Fellowguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CHAT _inst = (CG_CHAT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Chattype = input.ReadInt32();
break;
}
   case  18: {
 _inst.Chatinfo = input.ReadString();
break;
}
   case  24: {
 _inst.Receiverguid = input.ReadUInt64();
break;
}
   case  34: {
 _inst.Receivername = input.ReadString();
break;
}
   case  40: {
 _inst.Linktype = input.ReadInt32();
break;
}
   case  48: {
 _inst.AddIntdata(input.ReadInt32());
break;
}
   case  58: {
 _inst.AddStrdata(input.ReadString());
break;
}
   case  64: {
 _inst.LoudSpeakerNum = input.ReadInt32();
break;
}
   case  74: {
 _inst.VoiceChat = input.ReadBytes();
break;
}
   case  80: {
 _inst.IsYaoHe = input.ReadInt32();
break;
}
   case  88: {
 _inst.AnoymousState = input.ReadInt32();
break;
}
   case  96: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasChattype) return false;
 if (!hasChatinfo) return false;
 return true;
 }

}


[Serializable]
public class GC_CHAT : PacketDistributed
{
public enum CHATTYPE 
 { 
  CHAT_TYPE_INVALID    = 0, 
  CHAT_TYPE_NORMAL     = 1,  // ����Ƶ�� 
  CHAT_TYPE_TELL     = 2,  // ����Ƶ�� 
  CHAT_TYPE_TEAM     = 3,  // ����Ƶ�� 
  CHAT_TYPE_GUILD     = 4,  // ���Ƶ�� 
  CHAT_TYPE_WORLD     = 5,  // ����Ƶ�� 
  CHAT_TYPE_SYSTEM    = 6,  // ϵͳƵ�� 
  CHAT_TYPE_LOUDSPEAKER  = 7,  // С���� 
  CHAT_TYPE_FRIEND    = 8,  // ����Ƶ�� 
  CHAT_TYPE_MASTER    = 9,  // ʦ��Ƶ�� 
  CHAT_TYPE_PROPAGATE             = 10,       //��ֳƵ�� 
  CHAT_TYPE_VARIOUS               = 11,       //�ۺ�Ƶ�� 
 }
public const int chattypeFieldNumber = 1;
 private bool hasChattype;
 private Int32 chattype_ = 0;
 public bool HasChattype {
 get { return hasChattype; }
 }
 public Int32 Chattype {
 get { return chattype_; }
 set { SetChattype(value); }
 }
 public void SetChattype(Int32 value) { 
 hasChattype = true;
 chattype_ = value;
 }

public const int chatinfoFieldNumber = 2;
 private bool hasChatinfo;
 private string chatinfo_ = "";
 public bool HasChatinfo {
 get { return hasChatinfo; }
 }
 public string Chatinfo {
 get { return chatinfo_; }
 set { SetChatinfo(value); }
 }
 public void SetChatinfo(string value) { 
 hasChatinfo = true;
 chatinfo_ = value;
 }

public const int senderguidFieldNumber = 3;
 private bool hasSenderguid;
 private UInt64 senderguid_ = 0;
 public bool HasSenderguid {
 get { return hasSenderguid; }
 }
 public UInt64 Senderguid {
 get { return senderguid_; }
 set { SetSenderguid(value); }
 }
 public void SetSenderguid(UInt64 value) { 
 hasSenderguid = true;
 senderguid_ = value;
 }

public const int sendernameFieldNumber = 4;
 private bool hasSendername;
 private string sendername_ = "";
 public bool HasSendername {
 get { return hasSendername; }
 }
 public string Sendername {
 get { return sendername_; }
 set { SetSendername(value); }
 }
 public void SetSendername(string value) { 
 hasSendername = true;
 sendername_ = value;
 }

public const int receiverguidFieldNumber = 5;
 private bool hasReceiverguid;
 private UInt64 receiverguid_ = 0;
 public bool HasReceiverguid {
 get { return hasReceiverguid; }
 }
 public UInt64 Receiverguid {
 get { return receiverguid_; }
 set { SetReceiverguid(value); }
 }
 public void SetReceiverguid(UInt64 value) { 
 hasReceiverguid = true;
 receiverguid_ = value;
 }

public const int receivernameFieldNumber = 6;
 private bool hasReceivername;
 private string receivername_ = "";
 public bool HasReceivername {
 get { return hasReceivername; }
 }
 public string Receivername {
 get { return receivername_; }
 set { SetReceivername(value); }
 }
 public void SetReceivername(string value) { 
 hasReceivername = true;
 receivername_ = value;
 }
public enum LINKTYPE 
 { 
  LINK_TYPE_INVALID   = 0, 
  LINK_TYPE_ITEM    = 1,   // ��Ʒ���� 
  LINK_TYPE_EQUIP    = 2,   // װ������ 
  LINK_TYPE_COPYTEAM   = 3,   // ������� 
  LINK_TYPE_MOVETO   = 4,   // Ѱ· 
  LINK_TYPE_PLAYERINFO = 5,   // ������Ϣ 
  LINK_TYPE_SWORDSMAN  = 6,   // ������Ϣ 
  LINK_TYPE_GUILDCRUITE = 7,   // �����ļ 
  LINK_TYPE_HONGBAO   = 8,   // ����� 
  LINK_TYPE_PROPAGATE         = 9,            //��ֳ���� 
  LINK_TYPE_MISSION           = 10,           //�������� 
  LINK_TYPE_SUB_PROPAGATE     = 11,           //��ֳ�����ӣ�������ʾ�Լ��ܷ�ֳ�б��� 
  LINK_TYPE_PROPAGATE_ACCEPT  = 12,           //��ֳͬ��ķ������ӣ��Ͳ�Ҫ���������ˣ��������ƾ������ˣ����Űɣ����̾��߰ɡ��� 
  LINK_TYPE_PROPAGATE_AGREE   = 13,           //��ֳͬ�ⷵ������    
 }
public const int linktypeFieldNumber = 7;
 private pbc::PopsicleList<Int32> linktype_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> linktypeList {
 get { return pbc::Lists.AsReadOnly(linktype_); }
 }
 
 public int linktypeCount {
 get { return linktype_.Count; }
 }
 
public Int32 GetLinktype(int index) {
 return linktype_[index];
 }
 public void AddLinktype(Int32 value) {
 linktype_.Add(value);
 }

public const int intdataFieldNumber = 8;
 private pbc::PopsicleList<Int32> intdata_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> intdataList {
 get { return pbc::Lists.AsReadOnly(intdata_); }
 }
 
 public int intdataCount {
 get { return intdata_.Count; }
 }
 
public Int32 GetIntdata(int index) {
 return intdata_[index];
 }
 public void AddIntdata(Int32 value) {
 intdata_.Add(value);
 }

public const int strdataFieldNumber = 9;
 private pbc::PopsicleList<string> strdata_ = new pbc::PopsicleList<string>();
 public scg::IList<string> strdataList {
 get { return pbc::Lists.AsReadOnly(strdata_); }
 }
 
 public int strdataCount {
 get { return strdata_.Count; }
 }
 
public string GetStrdata(int index) {
 return strdata_[index];
 }
 public void AddStrdata(string value) {
 strdata_.Add(value);
 }

public const int SenderVIPLevelFieldNumber = 10;
 private bool hasSenderVIPLevel;
 private Int32 SenderVIPLevel_ = 0;
 public bool HasSenderVIPLevel {
 get { return hasSenderVIPLevel; }
 }
 public Int32 SenderVIPLevel {
 get { return SenderVIPLevel_; }
 set { SetSenderVIPLevel(value); }
 }
 public void SetSenderVIPLevel(Int32 value) { 
 hasSenderVIPLevel = true;
 SenderVIPLevel_ = value;
 }

public const int ReceiverVIPLevelFieldNumber = 11;
 private bool hasReceiverVIPLevel;
 private Int32 ReceiverVIPLevel_ = 0;
 public bool HasReceiverVIPLevel {
 get { return hasReceiverVIPLevel; }
 }
 public Int32 ReceiverVIPLevel {
 get { return ReceiverVIPLevel_; }
 set { SetReceiverVIPLevel(value); }
 }
 public void SetReceiverVIPLevel(Int32 value) { 
 hasReceiverVIPLevel = true;
 ReceiverVIPLevel_ = value;
 }

public const int VoiceChatIndexFieldNumber = 12;
 private bool hasVoiceChatIndex;
 private Int32 VoiceChatIndex_ = 0;
 public bool HasVoiceChatIndex {
 get { return hasVoiceChatIndex; }
 }
 public Int32 VoiceChatIndex {
 get { return VoiceChatIndex_; }
 set { SetVoiceChatIndex(value); }
 }
 public void SetVoiceChatIndex(Int32 value) { 
 hasVoiceChatIndex = true;
 VoiceChatIndex_ = value;
 }
public enum   ANOYMOUS_STATE 
 { 
  NORMAL = 0, 
  ANOYMOUS_SUCCESS = 1, 
  ANOYMOUS_FALIED = 2, 
 }
public const int anoymousStateFieldNumber = 13;
 private bool hasAnoymousState;
 private Int32 anoymousState_ = 0;
 public bool HasAnoymousState {
 get { return hasAnoymousState; }
 }
 public Int32 AnoymousState {
 get { return anoymousState_; }
 set { SetAnoymousState(value); }
 }
 public void SetAnoymousState(Int32 value) { 
 hasAnoymousState = true;
 anoymousState_ = value;
 }

public const int senderLevelFieldNumber = 14;
 private bool hasSenderLevel;
 private Int32 senderLevel_ = 0;
 public bool HasSenderLevel {
 get { return hasSenderLevel; }
 }
 public Int32 SenderLevel {
 get { return senderLevel_; }
 set { SetSenderLevel(value); }
 }
 public void SetSenderLevel(Int32 value) { 
 hasSenderLevel = true;
 senderLevel_ = value;
 }

public const int senderProfessionFieldNumber = 15;
 private bool hasSenderProfession;
 private Int32 senderProfession_ = 0;
 public bool HasSenderProfession {
 get { return hasSenderProfession; }
 }
 public Int32 SenderProfession {
 get { return senderProfession_; }
 set { SetSenderProfession(value); }
 }
 public void SetSenderProfession(Int32 value) { 
 hasSenderProfession = true;
 senderProfession_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasChattype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Chattype);
}
 if (HasChatinfo) {
size += pb::CodedOutputStream.ComputeStringSize(2, Chatinfo);
}
 if (HasSenderguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, Senderguid);
}
 if (HasSendername) {
size += pb::CodedOutputStream.ComputeStringSize(4, Sendername);
}
 if (HasReceiverguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(5, Receiverguid);
}
 if (HasReceivername) {
size += pb::CodedOutputStream.ComputeStringSize(6, Receivername);
}
{
int dataSize = 0;
for(int i=0; i<linktypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(linktypeList[i]);
}
size += dataSize;
size += 1 * linktype_.Count;
}
{
int dataSize = 0;
for(int i=0; i<intdataList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(intdataList[i]);
}
size += dataSize;
size += 1 * intdata_.Count;
}
{
int dataSize = 0;
for(int i=0; i<strdataList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(strdataList[i]);
}
size += dataSize;
size += 1 * strdata_.Count;
}
 if (HasSenderVIPLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(10, SenderVIPLevel);
}
 if (HasReceiverVIPLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(11, ReceiverVIPLevel);
}
 if (HasVoiceChatIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(12, VoiceChatIndex);
}
 if (HasAnoymousState) {
size += pb::CodedOutputStream.ComputeInt32Size(13, AnoymousState);
}
 if (HasSenderLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(14, SenderLevel);
}
 if (HasSenderProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(15, SenderProfession);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasChattype) {
output.WriteInt32(1, Chattype);
}
 
if (HasChatinfo) {
output.WriteString(2, Chatinfo);
}
 
if (HasSenderguid) {
output.WriteUInt64(3, Senderguid);
}
 
if (HasSendername) {
output.WriteString(4, Sendername);
}
 
if (HasReceiverguid) {
output.WriteUInt64(5, Receiverguid);
}
 
if (HasReceivername) {
output.WriteString(6, Receivername);
}
{
if (linktype_.Count > 0) {
for(int i=0; i<linktype_.Count; ++i){
output.WriteInt32(7,linktype_[i]);
}
}

}
{
if (intdata_.Count > 0) {
for(int i=0; i<intdata_.Count; ++i){
output.WriteInt32(8,intdata_[i]);
}
}

}
{
if (strdata_.Count > 0) {
for(int i=0; i<strdata_.Count; ++i){
output.WriteString(9,strdata_[i]);
}
}

}
 
if (HasSenderVIPLevel) {
output.WriteInt32(10, SenderVIPLevel);
}
 
if (HasReceiverVIPLevel) {
output.WriteInt32(11, ReceiverVIPLevel);
}
 
if (HasVoiceChatIndex) {
output.WriteInt32(12, VoiceChatIndex);
}
 
if (HasAnoymousState) {
output.WriteInt32(13, AnoymousState);
}
 
if (HasSenderLevel) {
output.WriteInt32(14, SenderLevel);
}
 
if (HasSenderProfession) {
output.WriteInt32(15, SenderProfession);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CHAT _inst = (GC_CHAT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Chattype = input.ReadInt32();
break;
}
   case  18: {
 _inst.Chatinfo = input.ReadString();
break;
}
   case  24: {
 _inst.Senderguid = input.ReadUInt64();
break;
}
   case  34: {
 _inst.Sendername = input.ReadString();
break;
}
   case  40: {
 _inst.Receiverguid = input.ReadUInt64();
break;
}
   case  50: {
 _inst.Receivername = input.ReadString();
break;
}
   case  56: {
 _inst.AddLinktype(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddIntdata(input.ReadInt32());
break;
}
   case  74: {
 _inst.AddStrdata(input.ReadString());
break;
}
   case  80: {
 _inst.SenderVIPLevel = input.ReadInt32();
break;
}
   case  88: {
 _inst.ReceiverVIPLevel = input.ReadInt32();
break;
}
   case  96: {
 _inst.VoiceChatIndex = input.ReadInt32();
break;
}
   case  104: {
 _inst.AnoymousState = input.ReadInt32();
break;
}
   case  112: {
 _inst.SenderLevel = input.ReadInt32();
break;
}
   case  120: {
 _inst.SenderProfession = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasChattype) return false;
 if (!hasChatinfo) return false;
 return true;
 }

}


[Serializable]
public class CG_ADDFRIEND : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ADDFRIEND _inst = (CG_ADDFRIEND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_ADDFRIEND : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int NameFieldNumber = 2;
 private bool hasName;
 private string Name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return Name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 Name_ = value;
 }

public const int LevelFieldNumber = 3;
 private bool hasLevel;
 private Int32 Level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return Level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 Level_ = value;
 }

public const int ProfFieldNumber = 4;
 private bool hasProf;
 private Int32 Prof_ = 0;
 public bool HasProf {
 get { return hasProf; }
 }
 public Int32 Prof {
 get { return Prof_; }
 set { SetProf(value); }
 }
 public void SetProf(Int32 value) { 
 hasProf = true;
 Prof_ = value;
 }

public const int CombatFieldNumber = 5;
 private bool hasCombat;
 private Int32 Combat_ = 0;
 public bool HasCombat {
 get { return hasCombat; }
 }
 public Int32 Combat {
 get { return Combat_; }
 set { SetCombat(value); }
 }
 public void SetCombat(Int32 value) { 
 hasCombat = true;
 Combat_ = value;
 }

public const int StateFieldNumber = 6;
 private bool hasState;
 private Int32 State_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return State_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 State_ = value;
 }

public const int TimeInfoFieldNumber = 7;
 private bool hasTimeInfo;
 private UInt32 TimeInfo_ = 0;
 public bool HasTimeInfo {
 get { return hasTimeInfo; }
 }
 public UInt32 TimeInfo {
 get { return TimeInfo_; }
 set { SetTimeInfo(value); }
 }
 public void SetTimeInfo(UInt32 value) { 
 hasTimeInfo = true;
 TimeInfo_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(2, Name);
}
 if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Level);
}
 if (HasProf) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Prof);
}
 if (HasCombat) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Combat);
}
 if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(6, State);
}
 if (HasTimeInfo) {
size += pb::CodedOutputStream.ComputeUInt32Size(7, TimeInfo);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 
if (HasName) {
output.WriteString(2, Name);
}
 
if (HasLevel) {
output.WriteInt32(3, Level);
}
 
if (HasProf) {
output.WriteInt32(4, Prof);
}
 
if (HasCombat) {
output.WriteInt32(5, Combat);
}
 
if (HasState) {
output.WriteInt32(6, State);
}
 
if (HasTimeInfo) {
output.WriteUInt32(7, TimeInfo);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ADDFRIEND _inst = (GC_ADDFRIEND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.Name = input.ReadString();
break;
}
   case  24: {
 _inst.Level = input.ReadInt32();
break;
}
   case  32: {
 _inst.Prof = input.ReadInt32();
break;
}
   case  40: {
 _inst.Combat = input.ReadInt32();
break;
}
   case  48: {
 _inst.State = input.ReadInt32();
break;
}
   case  56: {
 _inst.TimeInfo = input.ReadUInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 if (!hasName) return false;
 if (!hasLevel) return false;
 if (!hasProf) return false;
 if (!hasCombat) return false;
 if (!hasState) return false;
 if (!hasTimeInfo) return false;
 return true;
 }

}


[Serializable]
public class CG_DELFRIEND : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_DELFRIEND _inst = (CG_DELFRIEND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_FRIEND_USERINFO : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_FRIEND_USERINFO _inst = (CG_REQ_FRIEND_USERINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_FRIEND_USERINFO : PacketDistributed
{

public const int guidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int LevelFieldNumber = 2;
 private pbc::PopsicleList<Int32> Level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> LevelList {
 get { return pbc::Lists.AsReadOnly(Level_); }
 }
 
 public int LevelCount {
 get { return Level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return Level_[index];
 }
 public void AddLevel(Int32 value) {
 Level_.Add(value);
 }

public const int ProfFieldNumber = 3;
 private pbc::PopsicleList<Int32> Prof_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ProfList {
 get { return pbc::Lists.AsReadOnly(Prof_); }
 }
 
 public int ProfCount {
 get { return Prof_.Count; }
 }
 
public Int32 GetProf(int index) {
 return Prof_[index];
 }
 public void AddProf(Int32 value) {
 Prof_.Add(value);
 }

public const int CombatFieldNumber = 4;
 private pbc::PopsicleList<Int32> Combat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> CombatList {
 get { return pbc::Lists.AsReadOnly(Combat_); }
 }
 
 public int CombatCount {
 get { return Combat_.Count; }
 }
 
public Int32 GetCombat(int index) {
 return Combat_[index];
 }
 public void AddCombat(Int32 value) {
 Combat_.Add(value);
 }

public const int StateFieldNumber = 5;
 private pbc::PopsicleList<Int32> State_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> StateList {
 get { return pbc::Lists.AsReadOnly(State_); }
 }
 
 public int StateCount {
 get { return State_.Count; }
 }
 
public Int32 GetState(int index) {
 return State_[index];
 }
 public void AddState(Int32 value) {
 State_.Add(value);
 }

public const int NameFieldNumber = 6;
 private pbc::PopsicleList<string> Name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> NameList {
 get { return pbc::Lists.AsReadOnly(Name_); }
 }
 
 public int NameCount {
 get { return Name_.Count; }
 }
 
public string GetName(int index) {
 return Name_[index];
 }
 public void AddName(string value) {
 Name_.Add(value);
 }

public const int TimeInfoFieldNumber = 7;
 private pbc::PopsicleList<UInt32> TimeInfo_ = new pbc::PopsicleList<UInt32>();
 public scg::IList<UInt32> TimeInfoList {
 get { return pbc::Lists.AsReadOnly(TimeInfo_); }
 }
 
 public int TimeInfoCount {
 get { return TimeInfo_.Count; }
 }
 
public UInt32 GetTimeInfo(int index) {
 return TimeInfo_[index];
 }
 public void AddTimeInfo(UInt32 value) {
 TimeInfo_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<LevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(LevelList[i]);
}
size += dataSize;
size += 1 * Level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ProfList[i]);
}
size += dataSize;
size += 1 * Prof_.Count;
}
{
int dataSize = 0;
for(int i=0; i<CombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(CombatList[i]);
}
size += dataSize;
size += 1 * Combat_.Count;
}
{
int dataSize = 0;
for(int i=0; i<StateList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(StateList[i]);
}
size += dataSize;
size += 1 * State_.Count;
}
{
int dataSize = 0;
for(int i=0; i<NameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(NameList[i]);
}
size += dataSize;
size += 1 * Name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<TimeInfoList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt32SizeNoTag(TimeInfoList[i]);
}
size += dataSize;
size += 1 * TimeInfo_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(1,guid_[i]);
}
}

}
{
if (Level_.Count > 0) {
for(int i=0; i<Level_.Count; ++i){
output.WriteInt32(2,Level_[i]);
}
}

}
{
if (Prof_.Count > 0) {
for(int i=0; i<Prof_.Count; ++i){
output.WriteInt32(3,Prof_[i]);
}
}

}
{
if (Combat_.Count > 0) {
for(int i=0; i<Combat_.Count; ++i){
output.WriteInt32(4,Combat_[i]);
}
}

}
{
if (State_.Count > 0) {
for(int i=0; i<State_.Count; ++i){
output.WriteInt32(5,State_[i]);
}
}

}
{
if (Name_.Count > 0) {
for(int i=0; i<Name_.Count; ++i){
output.WriteString(6,Name_[i]);
}
}

}
{
if (TimeInfo_.Count > 0) {
for(int i=0; i<TimeInfo_.Count; ++i){
output.WriteUInt32(7,TimeInfo_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_FRIEND_USERINFO _inst = (GC_RET_FRIEND_USERINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  16: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddProf(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddCombat(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddState(input.ReadInt32());
break;
}
   case  50: {
 _inst.AddName(input.ReadString());
break;
}
   case  56: {
 _inst.AddTimeInfo(input.ReadUInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_DELFRIEND : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DELFRIEND _inst = (GC_DELFRIEND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_NOTICE_ADDED_FRIEND : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int nameFieldNumber = 2;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int profFieldNumber = 3;
 private bool hasProf;
 private Int32 prof_ = 0;
 public bool HasProf {
 get { return hasProf; }
 }
 public Int32 Prof {
 get { return prof_; }
 set { SetProf(value); }
 }
 public void SetProf(Int32 value) { 
 hasProf = true;
 prof_ = value;
 }

public const int fightFieldNumber = 4;
 private bool hasFight;
 private Int32 fight_ = 0;
 public bool HasFight {
 get { return hasFight; }
 }
 public Int32 Fight {
 get { return fight_; }
 set { SetFight(value); }
 }
 public void SetFight(Int32 value) { 
 hasFight = true;
 fight_ = value;
 }

public const int levelFieldNumber = 5;
 private bool hasLevel;
 private Int32 level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 level_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(2, Name);
}
 if (HasProf) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Prof);
}
 if (HasFight) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Fight);
}
 if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Level);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 
if (HasName) {
output.WriteString(2, Name);
}
 
if (HasProf) {
output.WriteInt32(3, Prof);
}
 
if (HasFight) {
output.WriteInt32(4, Fight);
}
 
if (HasLevel) {
output.WriteInt32(5, Level);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_NOTICE_ADDED_FRIEND _inst = (GC_NOTICE_ADDED_FRIEND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.Name = input.ReadString();
break;
}
   case  24: {
 _inst.Prof = input.ReadInt32();
break;
}
   case  32: {
 _inst.Fight = input.ReadInt32();
break;
}
   case  40: {
 _inst.Level = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 if (!hasName) return false;
 return true;
 }

}


[Serializable]
public class GC_SYC_FRIEND_STATE : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int StateFieldNumber = 2;
 private bool hasState;
 private Int32 State_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return State_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 State_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(2, State);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 
if (HasState) {
output.WriteInt32(2, State);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYC_FRIEND_STATE _inst = (GC_SYC_FRIEND_STATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.State = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 if (!hasState) return false;
 return true;
 }

}


[Serializable]
public class GC_SYC_FRIEND_INFO : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int NameFieldNumber = 2;
 private bool hasName;
 private string Name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return Name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 Name_ = value;
 }

public const int LevelFieldNumber = 3;
 private bool hasLevel;
 private Int32 Level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return Level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 Level_ = value;
 }

public const int ProfFieldNumber = 4;
 private bool hasProf;
 private Int32 Prof_ = 0;
 public bool HasProf {
 get { return hasProf; }
 }
 public Int32 Prof {
 get { return Prof_; }
 set { SetProf(value); }
 }
 public void SetProf(Int32 value) { 
 hasProf = true;
 Prof_ = value;
 }

public const int CombatFieldNumber = 5;
 private bool hasCombat;
 private Int32 Combat_ = 0;
 public bool HasCombat {
 get { return hasCombat; }
 }
 public Int32 Combat {
 get { return Combat_; }
 set { SetCombat(value); }
 }
 public void SetCombat(Int32 value) { 
 hasCombat = true;
 Combat_ = value;
 }

public const int StateFieldNumber = 6;
 private bool hasState;
 private Int32 State_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return State_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 State_ = value;
 }

public const int TimeInfoFieldNumber = 7;
 private bool hasTimeInfo;
 private UInt32 TimeInfo_ = 0;
 public bool HasTimeInfo {
 get { return hasTimeInfo; }
 }
 public UInt32 TimeInfo {
 get { return TimeInfo_; }
 set { SetTimeInfo(value); }
 }
 public void SetTimeInfo(UInt32 value) { 
 hasTimeInfo = true;
 TimeInfo_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(2, Name);
}
 if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Level);
}
 if (HasProf) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Prof);
}
 if (HasCombat) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Combat);
}
 if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(6, State);
}
 if (HasTimeInfo) {
size += pb::CodedOutputStream.ComputeUInt32Size(7, TimeInfo);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 
if (HasName) {
output.WriteString(2, Name);
}
 
if (HasLevel) {
output.WriteInt32(3, Level);
}
 
if (HasProf) {
output.WriteInt32(4, Prof);
}
 
if (HasCombat) {
output.WriteInt32(5, Combat);
}
 
if (HasState) {
output.WriteInt32(6, State);
}
 
if (HasTimeInfo) {
output.WriteUInt32(7, TimeInfo);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYC_FRIEND_INFO _inst = (GC_SYC_FRIEND_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.Name = input.ReadString();
break;
}
   case  24: {
 _inst.Level = input.ReadInt32();
break;
}
   case  32: {
 _inst.Prof = input.ReadInt32();
break;
}
   case  40: {
 _inst.Combat = input.ReadInt32();
break;
}
   case  48: {
 _inst.State = input.ReadInt32();
break;
}
   case  56: {
 _inst.TimeInfo = input.ReadUInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 if (!hasName) return false;
 if (!hasLevel) return false;
 if (!hasProf) return false;
 if (!hasCombat) return false;
 if (!hasState) return false;
 if (!hasTimeInfo) return false;
 return true;
 }

}


[Serializable]
public class GC_SYC_FULL_FRIEND_LIST : PacketDistributed
{

public const int guidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int NameFieldNumber = 2;
 private pbc::PopsicleList<string> Name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> NameList {
 get { return pbc::Lists.AsReadOnly(Name_); }
 }
 
 public int NameCount {
 get { return Name_.Count; }
 }
 
public string GetName(int index) {
 return Name_[index];
 }
 public void AddName(string value) {
 Name_.Add(value);
 }

public const int LevelFieldNumber = 3;
 private pbc::PopsicleList<Int32> Level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> LevelList {
 get { return pbc::Lists.AsReadOnly(Level_); }
 }
 
 public int LevelCount {
 get { return Level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return Level_[index];
 }
 public void AddLevel(Int32 value) {
 Level_.Add(value);
 }

public const int ProfFieldNumber = 4;
 private pbc::PopsicleList<Int32> Prof_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ProfList {
 get { return pbc::Lists.AsReadOnly(Prof_); }
 }
 
 public int ProfCount {
 get { return Prof_.Count; }
 }
 
public Int32 GetProf(int index) {
 return Prof_[index];
 }
 public void AddProf(Int32 value) {
 Prof_.Add(value);
 }

public const int CombatFieldNumber = 5;
 private pbc::PopsicleList<Int32> Combat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> CombatList {
 get { return pbc::Lists.AsReadOnly(Combat_); }
 }
 
 public int CombatCount {
 get { return Combat_.Count; }
 }
 
public Int32 GetCombat(int index) {
 return Combat_[index];
 }
 public void AddCombat(Int32 value) {
 Combat_.Add(value);
 }

public const int StateFieldNumber = 6;
 private pbc::PopsicleList<Int32> State_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> StateList {
 get { return pbc::Lists.AsReadOnly(State_); }
 }
 
 public int StateCount {
 get { return State_.Count; }
 }
 
public Int32 GetState(int index) {
 return State_[index];
 }
 public void AddState(Int32 value) {
 State_.Add(value);
 }

public const int TimeInfoFieldNumber = 7;
 private pbc::PopsicleList<UInt32> TimeInfo_ = new pbc::PopsicleList<UInt32>();
 public scg::IList<UInt32> TimeInfoList {
 get { return pbc::Lists.AsReadOnly(TimeInfo_); }
 }
 
 public int TimeInfoCount {
 get { return TimeInfo_.Count; }
 }
 
public UInt32 GetTimeInfo(int index) {
 return TimeInfo_[index];
 }
 public void AddTimeInfo(UInt32 value) {
 TimeInfo_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<NameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(NameList[i]);
}
size += dataSize;
size += 1 * Name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<LevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(LevelList[i]);
}
size += dataSize;
size += 1 * Level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ProfList[i]);
}
size += dataSize;
size += 1 * Prof_.Count;
}
{
int dataSize = 0;
for(int i=0; i<CombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(CombatList[i]);
}
size += dataSize;
size += 1 * Combat_.Count;
}
{
int dataSize = 0;
for(int i=0; i<StateList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(StateList[i]);
}
size += dataSize;
size += 1 * State_.Count;
}
{
int dataSize = 0;
for(int i=0; i<TimeInfoList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt32SizeNoTag(TimeInfoList[i]);
}
size += dataSize;
size += 1 * TimeInfo_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(1,guid_[i]);
}
}

}
{
if (Name_.Count > 0) {
for(int i=0; i<Name_.Count; ++i){
output.WriteString(2,Name_[i]);
}
}

}
{
if (Level_.Count > 0) {
for(int i=0; i<Level_.Count; ++i){
output.WriteInt32(3,Level_[i]);
}
}

}
{
if (Prof_.Count > 0) {
for(int i=0; i<Prof_.Count; ++i){
output.WriteInt32(4,Prof_[i]);
}
}

}
{
if (Combat_.Count > 0) {
for(int i=0; i<Combat_.Count; ++i){
output.WriteInt32(5,Combat_[i]);
}
}

}
{
if (State_.Count > 0) {
for(int i=0; i<State_.Count; ++i){
output.WriteInt32(6,State_[i]);
}
}

}
{
if (TimeInfo_.Count > 0) {
for(int i=0; i<TimeInfo_.Count; ++i){
output.WriteUInt32(7,TimeInfo_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYC_FULL_FRIEND_LIST _inst = (GC_SYC_FULL_FRIEND_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddName(input.ReadString());
break;
}
   case  24: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddProf(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddCombat(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddState(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddTimeInfo(input.ReadUInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_ADDBLACKLIST : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ADDBLACKLIST _inst = (CG_ADDBLACKLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_ADDBLACKLIST : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int NameFieldNumber = 2;
 private bool hasName;
 private string Name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return Name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 Name_ = value;
 }

public const int LevelFieldNumber = 3;
 private bool hasLevel;
 private Int32 Level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return Level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 Level_ = value;
 }

public const int ProfFieldNumber = 4;
 private bool hasProf;
 private Int32 Prof_ = 0;
 public bool HasProf {
 get { return hasProf; }
 }
 public Int32 Prof {
 get { return Prof_; }
 set { SetProf(value); }
 }
 public void SetProf(Int32 value) { 
 hasProf = true;
 Prof_ = value;
 }

public const int CombatFieldNumber = 5;
 private bool hasCombat;
 private Int32 Combat_ = 0;
 public bool HasCombat {
 get { return hasCombat; }
 }
 public Int32 Combat {
 get { return Combat_; }
 set { SetCombat(value); }
 }
 public void SetCombat(Int32 value) { 
 hasCombat = true;
 Combat_ = value;
 }

public const int StateFieldNumber = 6;
 private bool hasState;
 private Int32 State_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return State_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 State_ = value;
 }

public const int TimeInfoFieldNumber = 7;
 private bool hasTimeInfo;
 private UInt32 TimeInfo_ = 0;
 public bool HasTimeInfo {
 get { return hasTimeInfo; }
 }
 public UInt32 TimeInfo {
 get { return TimeInfo_; }
 set { SetTimeInfo(value); }
 }
 public void SetTimeInfo(UInt32 value) { 
 hasTimeInfo = true;
 TimeInfo_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(2, Name);
}
 if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Level);
}
 if (HasProf) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Prof);
}
 if (HasCombat) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Combat);
}
 if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(6, State);
}
 if (HasTimeInfo) {
size += pb::CodedOutputStream.ComputeUInt32Size(7, TimeInfo);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 
if (HasName) {
output.WriteString(2, Name);
}
 
if (HasLevel) {
output.WriteInt32(3, Level);
}
 
if (HasProf) {
output.WriteInt32(4, Prof);
}
 
if (HasCombat) {
output.WriteInt32(5, Combat);
}
 
if (HasState) {
output.WriteInt32(6, State);
}
 
if (HasTimeInfo) {
output.WriteUInt32(7, TimeInfo);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ADDBLACKLIST _inst = (GC_ADDBLACKLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.Name = input.ReadString();
break;
}
   case  24: {
 _inst.Level = input.ReadInt32();
break;
}
   case  32: {
 _inst.Prof = input.ReadInt32();
break;
}
   case  40: {
 _inst.Combat = input.ReadInt32();
break;
}
   case  48: {
 _inst.State = input.ReadInt32();
break;
}
   case  56: {
 _inst.TimeInfo = input.ReadUInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 if (!hasName) return false;
 if (!hasLevel) return false;
 if (!hasProf) return false;
 if (!hasCombat) return false;
 if (!hasState) return false;
 if (!hasTimeInfo) return false;
 return true;
 }

}


[Serializable]
public class GC_SYC_FULL_BLACK_LIST : PacketDistributed
{

public const int guidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int NameFieldNumber = 2;
 private pbc::PopsicleList<string> Name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> NameList {
 get { return pbc::Lists.AsReadOnly(Name_); }
 }
 
 public int NameCount {
 get { return Name_.Count; }
 }
 
public string GetName(int index) {
 return Name_[index];
 }
 public void AddName(string value) {
 Name_.Add(value);
 }

public const int LevelFieldNumber = 3;
 private pbc::PopsicleList<Int32> Level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> LevelList {
 get { return pbc::Lists.AsReadOnly(Level_); }
 }
 
 public int LevelCount {
 get { return Level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return Level_[index];
 }
 public void AddLevel(Int32 value) {
 Level_.Add(value);
 }

public const int ProfFieldNumber = 4;
 private pbc::PopsicleList<Int32> Prof_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ProfList {
 get { return pbc::Lists.AsReadOnly(Prof_); }
 }
 
 public int ProfCount {
 get { return Prof_.Count; }
 }
 
public Int32 GetProf(int index) {
 return Prof_[index];
 }
 public void AddProf(Int32 value) {
 Prof_.Add(value);
 }

public const int CombatFieldNumber = 5;
 private pbc::PopsicleList<Int32> Combat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> CombatList {
 get { return pbc::Lists.AsReadOnly(Combat_); }
 }
 
 public int CombatCount {
 get { return Combat_.Count; }
 }
 
public Int32 GetCombat(int index) {
 return Combat_[index];
 }
 public void AddCombat(Int32 value) {
 Combat_.Add(value);
 }

public const int StateFieldNumber = 6;
 private pbc::PopsicleList<Int32> State_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> StateList {
 get { return pbc::Lists.AsReadOnly(State_); }
 }
 
 public int StateCount {
 get { return State_.Count; }
 }
 
public Int32 GetState(int index) {
 return State_[index];
 }
 public void AddState(Int32 value) {
 State_.Add(value);
 }

public const int TimeInfoFieldNumber = 7;
 private pbc::PopsicleList<UInt32> TimeInfo_ = new pbc::PopsicleList<UInt32>();
 public scg::IList<UInt32> TimeInfoList {
 get { return pbc::Lists.AsReadOnly(TimeInfo_); }
 }
 
 public int TimeInfoCount {
 get { return TimeInfo_.Count; }
 }
 
public UInt32 GetTimeInfo(int index) {
 return TimeInfo_[index];
 }
 public void AddTimeInfo(UInt32 value) {
 TimeInfo_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<NameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(NameList[i]);
}
size += dataSize;
size += 1 * Name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<LevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(LevelList[i]);
}
size += dataSize;
size += 1 * Level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ProfList[i]);
}
size += dataSize;
size += 1 * Prof_.Count;
}
{
int dataSize = 0;
for(int i=0; i<CombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(CombatList[i]);
}
size += dataSize;
size += 1 * Combat_.Count;
}
{
int dataSize = 0;
for(int i=0; i<StateList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(StateList[i]);
}
size += dataSize;
size += 1 * State_.Count;
}
{
int dataSize = 0;
for(int i=0; i<TimeInfoList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt32SizeNoTag(TimeInfoList[i]);
}
size += dataSize;
size += 1 * TimeInfo_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(1,guid_[i]);
}
}

}
{
if (Name_.Count > 0) {
for(int i=0; i<Name_.Count; ++i){
output.WriteString(2,Name_[i]);
}
}

}
{
if (Level_.Count > 0) {
for(int i=0; i<Level_.Count; ++i){
output.WriteInt32(3,Level_[i]);
}
}

}
{
if (Prof_.Count > 0) {
for(int i=0; i<Prof_.Count; ++i){
output.WriteInt32(4,Prof_[i]);
}
}

}
{
if (Combat_.Count > 0) {
for(int i=0; i<Combat_.Count; ++i){
output.WriteInt32(5,Combat_[i]);
}
}

}
{
if (State_.Count > 0) {
for(int i=0; i<State_.Count; ++i){
output.WriteInt32(6,State_[i]);
}
}

}
{
if (TimeInfo_.Count > 0) {
for(int i=0; i<TimeInfo_.Count; ++i){
output.WriteUInt32(7,TimeInfo_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYC_FULL_BLACK_LIST _inst = (GC_SYC_FULL_BLACK_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddName(input.ReadString());
break;
}
   case  24: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddProf(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddCombat(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddState(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddTimeInfo(input.ReadUInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_DELBLACKLIST : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_DELBLACKLIST _inst = (CG_DELBLACKLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_DELBLACKLIST : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DELBLACKLIST _inst = (GC_DELBLACKLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_FINDPLAYER : PacketDistributed
{

public const int GuidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 Guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return Guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 Guid_ = value;
 }

public const int NameFieldNumber = 2;
 private bool hasName;
 private string Name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return Name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 Name_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(2, Name);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 
if (HasName) {
output.WriteString(2, Name);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_FINDPLAYER _inst = (CG_FINDPLAYER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.Name = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 if (!hasName) return false;
 return true;
 }

}


[Serializable]
public class GC_FINDPLAYER : PacketDistributed
{
public enum FindPlayerRetType 
 { 
  RETTYPE_SUCCESS = 0,  // �ɹ� 
  RETTYPE_NOPLAYER = 1,  // û���ҵ�������������� 
  RETTYPE_TOOQUICK = 2,  // ����̫Ƶ�� 
 }
public const int guidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int NameFieldNumber = 2;
 private pbc::PopsicleList<string> Name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> NameList {
 get { return pbc::Lists.AsReadOnly(Name_); }
 }
 
 public int NameCount {
 get { return Name_.Count; }
 }
 
public string GetName(int index) {
 return Name_[index];
 }
 public void AddName(string value) {
 Name_.Add(value);
 }

public const int LevelFieldNumber = 3;
 private pbc::PopsicleList<Int32> Level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> LevelList {
 get { return pbc::Lists.AsReadOnly(Level_); }
 }
 
 public int LevelCount {
 get { return Level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return Level_[index];
 }
 public void AddLevel(Int32 value) {
 Level_.Add(value);
 }

public const int ProfFieldNumber = 4;
 private pbc::PopsicleList<Int32> Prof_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ProfList {
 get { return pbc::Lists.AsReadOnly(Prof_); }
 }
 
 public int ProfCount {
 get { return Prof_.Count; }
 }
 
public Int32 GetProf(int index) {
 return Prof_[index];
 }
 public void AddProf(Int32 value) {
 Prof_.Add(value);
 }

public const int CombatFieldNumber = 5;
 private pbc::PopsicleList<Int32> Combat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> CombatList {
 get { return pbc::Lists.AsReadOnly(Combat_); }
 }
 
 public int CombatCount {
 get { return Combat_.Count; }
 }
 
public Int32 GetCombat(int index) {
 return Combat_[index];
 }
 public void AddCombat(Int32 value) {
 Combat_.Add(value);
 }

public const int RetFieldNumber = 6;
 private bool hasRet;
 private Int32 Ret_ = 0;
 public bool HasRet {
 get { return hasRet; }
 }
 public Int32 Ret {
 get { return Ret_; }
 set { SetRet(value); }
 }
 public void SetRet(Int32 value) { 
 hasRet = true;
 Ret_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<NameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(NameList[i]);
}
size += dataSize;
size += 1 * Name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<LevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(LevelList[i]);
}
size += dataSize;
size += 1 * Level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ProfList[i]);
}
size += dataSize;
size += 1 * Prof_.Count;
}
{
int dataSize = 0;
for(int i=0; i<CombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(CombatList[i]);
}
size += dataSize;
size += 1 * Combat_.Count;
}
 if (HasRet) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Ret);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(1,guid_[i]);
}
}

}
{
if (Name_.Count > 0) {
for(int i=0; i<Name_.Count; ++i){
output.WriteString(2,Name_[i]);
}
}

}
{
if (Level_.Count > 0) {
for(int i=0; i<Level_.Count; ++i){
output.WriteInt32(3,Level_[i]);
}
}

}
{
if (Prof_.Count > 0) {
for(int i=0; i<Prof_.Count; ++i){
output.WriteInt32(4,Prof_[i]);
}
}

}
{
if (Combat_.Count > 0) {
for(int i=0; i<Combat_.Count; ++i){
output.WriteInt32(5,Combat_[i]);
}
}

}
 
if (HasRet) {
output.WriteInt32(6, Ret);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_FINDPLAYER _inst = (GC_FINDPLAYER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddName(input.ReadString());
break;
}
   case  24: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddProf(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddCombat(input.ReadInt32());
break;
}
   case  48: {
 _inst.Ret = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_SYNSELTRAGET_ATTR : PacketDistributed
{

public const int ObjIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 ObjId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return ObjId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 ObjId_ = value;
 }

public const int CurHpFieldNumber = 2;
 private bool hasCurHp;
 private Int32 CurHp_ = 0;
 public bool HasCurHp {
 get { return hasCurHp; }
 }
 public Int32 CurHp {
 get { return CurHp_; }
 set { SetCurHp(value); }
 }
 public void SetCurHp(Int32 value) { 
 hasCurHp = true;
 CurHp_ = value;
 }

public const int CurMpFieldNumber = 3;
 private bool hasCurMp;
 private Int32 CurMp_ = 0;
 public bool HasCurMp {
 get { return hasCurMp; }
 }
 public Int32 CurMp {
 get { return CurMp_; }
 set { SetCurMp(value); }
 }
 public void SetCurMp(Int32 value) { 
 hasCurMp = true;
 CurMp_ = value;
 }

public const int MaxHPFieldNumber = 4;
 private bool hasMaxHP;
 private Int32 MaxHP_ = 0;
 public bool HasMaxHP {
 get { return hasMaxHP; }
 }
 public Int32 MaxHP {
 get { return MaxHP_; }
 set { SetMaxHP(value); }
 }
 public void SetMaxHP(Int32 value) { 
 hasMaxHP = true;
 MaxHP_ = value;
 }

public const int MaxMPFieldNumber = 5;
 private bool hasMaxMP;
 private Int32 MaxMP_ = 0;
 public bool HasMaxMP {
 get { return hasMaxMP; }
 }
 public Int32 MaxMP {
 get { return MaxMP_; }
 set { SetMaxMP(value); }
 }
 public void SetMaxMP(Int32 value) { 
 hasMaxMP = true;
 MaxMP_ = value;
 }

public const int CurLevFieldNumber = 6;
 private bool hasCurLev;
 private Int32 CurLev_ = 0;
 public bool HasCurLev {
 get { return hasCurLev; }
 }
 public Int32 CurLev {
 get { return CurLev_; }
 set { SetCurLev(value); }
 }
 public void SetCurLev(Int32 value) { 
 hasCurLev = true;
 CurLev_ = value;
 }

public const int NameFieldNumber = 7;
 private bool hasName;
 private string Name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return Name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 Name_ = value;
 }

public const int BelongTeamIDFieldNumber = 8;
 private bool hasBelongTeamID;
 private Int32 BelongTeamID_ = 0;
 public bool HasBelongTeamID {
 get { return hasBelongTeamID; }
 }
 public Int32 BelongTeamID {
 get { return BelongTeamID_; }
 set { SetBelongTeamID(value); }
 }
 public void SetBelongTeamID(Int32 value) { 
 hasBelongTeamID = true;
 BelongTeamID_ = value;
 }

public const int BelongObjIDFieldNumber = 9;
 private bool hasBelongObjID;
 private Int32 BelongObjID_ = 0;
 public bool HasBelongObjID {
 get { return hasBelongObjID; }
 }
 public Int32 BelongObjID {
 get { return BelongObjID_; }
 set { SetBelongObjID(value); }
 }
 public void SetBelongObjID(Int32 value) { 
 hasBelongObjID = true;
 BelongObjID_ = value;
 }

public const int DeBuffIDFieldNumber = 10;
 private pbc::PopsicleList<Int32> DeBuffID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> DeBuffIDList {
 get { return pbc::Lists.AsReadOnly(DeBuffID_); }
 }
 
 public int DeBuffIDCount {
 get { return DeBuffID_.Count; }
 }
 
public Int32 GetDeBuffID(int index) {
 return DeBuffID_[index];
 }
 public void AddDeBuffID(Int32 value) {
 DeBuffID_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasCurHp) {
size += pb::CodedOutputStream.ComputeInt32Size(2, CurHp);
}
 if (HasCurMp) {
size += pb::CodedOutputStream.ComputeInt32Size(3, CurMp);
}
 if (HasMaxHP) {
size += pb::CodedOutputStream.ComputeInt32Size(4, MaxHP);
}
 if (HasMaxMP) {
size += pb::CodedOutputStream.ComputeInt32Size(5, MaxMP);
}
 if (HasCurLev) {
size += pb::CodedOutputStream.ComputeInt32Size(6, CurLev);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(7, Name);
}
 if (HasBelongTeamID) {
size += pb::CodedOutputStream.ComputeInt32Size(8, BelongTeamID);
}
 if (HasBelongObjID) {
size += pb::CodedOutputStream.ComputeInt32Size(9, BelongObjID);
}
{
int dataSize = 0;
for(int i=0; i<DeBuffIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(DeBuffIDList[i]);
}
size += dataSize;
size += 1 * DeBuffID_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasCurHp) {
output.WriteInt32(2, CurHp);
}
 
if (HasCurMp) {
output.WriteInt32(3, CurMp);
}
 
if (HasMaxHP) {
output.WriteInt32(4, MaxHP);
}
 
if (HasMaxMP) {
output.WriteInt32(5, MaxMP);
}
 
if (HasCurLev) {
output.WriteInt32(6, CurLev);
}
 
if (HasName) {
output.WriteString(7, Name);
}
 
if (HasBelongTeamID) {
output.WriteInt32(8, BelongTeamID);
}
 
if (HasBelongObjID) {
output.WriteInt32(9, BelongObjID);
}
{
if (DeBuffID_.Count > 0) {
for(int i=0; i<DeBuffID_.Count; ++i){
output.WriteInt32(10,DeBuffID_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNSELTRAGET_ATTR _inst = (GC_SYNSELTRAGET_ATTR) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.CurHp = input.ReadInt32();
break;
}
   case  24: {
 _inst.CurMp = input.ReadInt32();
break;
}
   case  32: {
 _inst.MaxHP = input.ReadInt32();
break;
}
   case  40: {
 _inst.MaxMP = input.ReadInt32();
break;
}
   case  48: {
 _inst.CurLev = input.ReadInt32();
break;
}
   case  58: {
 _inst.Name = input.ReadString();
break;
}
   case  64: {
 _inst.BelongTeamID = input.ReadInt32();
break;
}
   case  72: {
 _inst.BelongObjID = input.ReadInt32();
break;
}
   case  80: {
 _inst.AddDeBuffID(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 return true;
 }

}


[Serializable]
public class GC_CREATE_NPC : PacketDistributed
{

public const int serverIdFieldNumber = 1;
 private bool hasServerId;
 private Int32 serverId_ = 0;
 public bool HasServerId {
 get { return hasServerId; }
 }
 public Int32 ServerId {
 get { return serverId_; }
 set { SetServerId(value); }
 }
 public void SetServerId(Int32 value) { 
 hasServerId = true;
 serverId_ = value;
 }

public const int sceneInstFieldNumber = 2;
 private bool hasSceneInst;
 private Int32 sceneInst_ = 0;
 public bool HasSceneInst {
 get { return hasSceneInst; }
 }
 public Int32 SceneInst {
 get { return sceneInst_; }
 set { SetSceneInst(value); }
 }
 public void SetSceneInst(Int32 value) { 
 hasSceneInst = true;
 sceneInst_ = value;
 }

public const int sceneClassFieldNumber = 3;
 private bool hasSceneClass;
 private Int32 sceneClass_ = 0;
 public bool HasSceneClass {
 get { return hasSceneClass; }
 }
 public Int32 SceneClass {
 get { return sceneClass_; }
 set { SetSceneClass(value); }
 }
 public void SetSceneClass(Int32 value) { 
 hasSceneClass = true;
 sceneClass_ = value;
 }

public const int dataIdFieldNumber = 4;
 private bool hasDataId;
 private Int32 dataId_ = 0;
 public bool HasDataId {
 get { return hasDataId; }
 }
 public Int32 DataId {
 get { return dataId_; }
 set { SetDataId(value); }
 }
 public void SetDataId(Int32 value) { 
 hasDataId = true;
 dataId_ = value;
 }

public const int posXFieldNumber = 5;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 6;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

public const int curforceFieldNumber = 7;
 private bool hasCurforce;
 private Int32 curforce_ = 0;
 public bool HasCurforce {
 get { return hasCurforce; }
 }
 public Int32 Curforce {
 get { return curforce_; }
 set { SetCurforce(value); }
 }
 public void SetCurforce(Int32 value) { 
 hasCurforce = true;
 curforce_ = value;
 }

public const int nameFieldNumber = 8;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int facedirFieldNumber = 10;
 private bool hasFacedir;
 private Int32 facedir_ = 0;
 public bool HasFacedir {
 get { return hasFacedir; }
 }
 public Int32 Facedir {
 get { return facedir_; }
 set { SetFacedir(value); }
 }
 public void SetFacedir(Int32 value) { 
 hasFacedir = true;
 facedir_ = value;
 }

public const int isDieFieldNumber = 11;
 private bool hasIsDie;
 private Int32 isDie_ = 0;
 public bool HasIsDie {
 get { return hasIsDie; }
 }
 public Int32 IsDie {
 get { return isDie_; }
 set { SetIsDie(value); }
 }
 public void SetIsDie(Int32 value) { 
 hasIsDie = true;
 isDie_ = value;
 }

public const int movespeedFieldNumber = 12;
 private bool hasMovespeed;
 private Int32 movespeed_ = 0;
 public bool HasMovespeed {
 get { return hasMovespeed; }
 }
 public Int32 Movespeed {
 get { return movespeed_; }
 set { SetMovespeed(value); }
 }
 public void SetMovespeed(Int32 value) { 
 hasMovespeed = true;
 movespeed_ = value;
 }

public const int ModelVisualIDFieldNumber = 13;
 private bool hasModelVisualID;
 private Int32 ModelVisualID_ = 0;
 public bool HasModelVisualID {
 get { return hasModelVisualID; }
 }
 public Int32 ModelVisualID {
 get { return ModelVisualID_; }
 set { SetModelVisualID(value); }
 }
 public void SetModelVisualID(Int32 value) { 
 hasModelVisualID = true;
 ModelVisualID_ = value;
 }

public const int WeaponDataIDFieldNumber = 14;
 private bool hasWeaponDataID;
 private Int32 WeaponDataID_ = 0;
 public bool HasWeaponDataID {
 get { return hasWeaponDataID; }
 }
 public Int32 WeaponDataID {
 get { return WeaponDataID_; }
 set { SetWeaponDataID(value); }
 }
 public void SetWeaponDataID(Int32 value) { 
 hasWeaponDataID = true;
 WeaponDataID_ = value;
 }

public const int ProfessionFieldNumber = 15;
 private bool hasProfession;
 private Int32 Profession_ = 0;
 public bool HasProfession {
 get { return hasProfession; }
 }
 public Int32 Profession {
 get { return Profession_; }
 set { SetProfession(value); }
 }
 public void SetProfession(Int32 value) { 
 hasProfession = true;
 Profession_ = value;
 }

public const int stealthLeveFieldNumber = 16;
 private bool hasStealthLeve;
 private Int32 stealthLeve_ = 0;
 public bool HasStealthLeve {
 get { return hasStealthLeve; }
 }
 public Int32 StealthLeve {
 get { return stealthLeve_; }
 set { SetStealthLeve(value); }
 }
 public void SetStealthLeve(Int32 value) { 
 hasStealthLeve = true;
 stealthLeve_ = value;
 }

public const int isBornFieldNumber = 17;
 private bool hasIsBorn;
 private Int32 isBorn_ = 0;
 public bool HasIsBorn {
 get { return hasIsBorn; }
 }
 public Int32 IsBorn {
 get { return isBorn_; }
 set { SetIsBorn(value); }
 }
 public void SetIsBorn(Int32 value) { 
 hasIsBorn = true;
 isBorn_ = value;
 }

public const int bindparentFieldNumber = 18;
 private bool hasBindparent;
 private Int32 bindparent_ = 0;
 public bool HasBindparent {
 get { return hasBindparent; }
 }
 public Int32 Bindparent {
 get { return bindparent_; }
 set { SetBindparent(value); }
 }
 public void SetBindparent(Int32 value) { 
 hasBindparent = true;
 bindparent_ = value;
 }

public const int bindchildrenFieldNumber = 19;
 private pbc::PopsicleList<Int32> bindchildren_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> bindchildrenList {
 get { return pbc::Lists.AsReadOnly(bindchildren_); }
 }
 
 public int bindchildrenCount {
 get { return bindchildren_.Count; }
 }
 
public Int32 GetBindchildren(int index) {
 return bindchildren_[index];
 }
 public void AddBindchildren(Int32 value) {
 bindchildren_.Add(value);
 }

public const int SceneNpcIdFieldNumber = 20;
 private bool hasSceneNpcId;
 private Int32 SceneNpcId_ = 0;
 public bool HasSceneNpcId {
 get { return hasSceneNpcId; }
 }
 public Int32 SceneNpcId {
 get { return SceneNpcId_; }
 set { SetSceneNpcId(value); }
 }
 public void SetSceneNpcId(Int32 value) { 
 hasSceneNpcId = true;
 SceneNpcId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ServerId);
}
 if (HasSceneInst) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SceneInst);
}
 if (HasSceneClass) {
size += pb::CodedOutputStream.ComputeInt32Size(3, SceneClass);
}
 if (HasDataId) {
size += pb::CodedOutputStream.ComputeInt32Size(4, DataId);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(5, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(6, PosZ);
}
 if (HasCurforce) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Curforce);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(8, Name);
}
 if (HasFacedir) {
size += pb::CodedOutputStream.ComputeInt32Size(10, Facedir);
}
 if (HasIsDie) {
size += pb::CodedOutputStream.ComputeInt32Size(11, IsDie);
}
 if (HasMovespeed) {
size += pb::CodedOutputStream.ComputeInt32Size(12, Movespeed);
}
 if (HasModelVisualID) {
size += pb::CodedOutputStream.ComputeInt32Size(13, ModelVisualID);
}
 if (HasWeaponDataID) {
size += pb::CodedOutputStream.ComputeInt32Size(14, WeaponDataID);
}
 if (HasProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(15, Profession);
}
 if (HasStealthLeve) {
size += pb::CodedOutputStream.ComputeInt32Size(16, StealthLeve);
}
 if (HasIsBorn) {
size += pb::CodedOutputStream.ComputeInt32Size(17, IsBorn);
}
 if (HasBindparent) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Bindparent);
}
{
int dataSize = 0;
for(int i=0; i<bindchildrenList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(bindchildrenList[i]);
}
size += dataSize;
size += 1 * bindchildren_.Count;
}
 if (HasSceneNpcId) {
size += pb::CodedOutputStream.ComputeInt32Size(20, SceneNpcId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerId) {
output.WriteInt32(1, ServerId);
}
 
if (HasSceneInst) {
output.WriteInt32(2, SceneInst);
}
 
if (HasSceneClass) {
output.WriteInt32(3, SceneClass);
}
 
if (HasDataId) {
output.WriteInt32(4, DataId);
}
 
if (HasPosX) {
output.WriteInt32(5, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(6, PosZ);
}
 
if (HasCurforce) {
output.WriteInt32(7, Curforce);
}
 
if (HasName) {
output.WriteString(8, Name);
}
 
if (HasFacedir) {
output.WriteInt32(10, Facedir);
}
 
if (HasIsDie) {
output.WriteInt32(11, IsDie);
}
 
if (HasMovespeed) {
output.WriteInt32(12, Movespeed);
}
 
if (HasModelVisualID) {
output.WriteInt32(13, ModelVisualID);
}
 
if (HasWeaponDataID) {
output.WriteInt32(14, WeaponDataID);
}
 
if (HasProfession) {
output.WriteInt32(15, Profession);
}
 
if (HasStealthLeve) {
output.WriteInt32(16, StealthLeve);
}
 
if (HasIsBorn) {
output.WriteInt32(17, IsBorn);
}
 
if (HasBindparent) {
output.WriteInt32(18, Bindparent);
}
{
if (bindchildren_.Count > 0) {
for(int i=0; i<bindchildren_.Count; ++i){
output.WriteInt32(19,bindchildren_[i]);
}
}

}
 
if (HasSceneNpcId) {
output.WriteInt32(20, SceneNpcId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CREATE_NPC _inst = (GC_CREATE_NPC) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ServerId = input.ReadInt32();
break;
}
   case  16: {
 _inst.SceneInst = input.ReadInt32();
break;
}
   case  24: {
 _inst.SceneClass = input.ReadInt32();
break;
}
   case  32: {
 _inst.DataId = input.ReadInt32();
break;
}
   case  40: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  48: {
 _inst.PosZ = input.ReadInt32();
break;
}
   case  56: {
 _inst.Curforce = input.ReadInt32();
break;
}
   case  66: {
 _inst.Name = input.ReadString();
break;
}
   case  80: {
 _inst.Facedir = input.ReadInt32();
break;
}
   case  88: {
 _inst.IsDie = input.ReadInt32();
break;
}
   case  96: {
 _inst.Movespeed = input.ReadInt32();
break;
}
   case  104: {
 _inst.ModelVisualID = input.ReadInt32();
break;
}
   case  112: {
 _inst.WeaponDataID = input.ReadInt32();
break;
}
   case  120: {
 _inst.Profession = input.ReadInt32();
break;
}
   case  128: {
 _inst.StealthLeve = input.ReadInt32();
break;
}
   case  136: {
 _inst.IsBorn = input.ReadInt32();
break;
}
   case  144: {
 _inst.Bindparent = input.ReadInt32();
break;
}
   case  152: {
 _inst.AddBindchildren(input.ReadInt32());
break;
}
   case  160: {
 _inst.SceneNpcId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerId) return false;
 if (!hasSceneInst) return false;
 if (!hasSceneClass) return false;
 if (!hasDataId) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 if (!hasCurforce) return false;
 if (!hasName) return false;
 if (!hasFacedir) return false;
 if (!hasIsDie) return false;
 if (!hasMovespeed) return false;
 if (!hasStealthLeve) return false;
 if (!hasIsBorn) return false;
 if (!hasBindparent) return false;
 if (!hasSceneNpcId) return false;
 return true;
 }

}


[Serializable]
public class CG_GMCOMMAND : PacketDistributed
{

public const int cmdFieldNumber = 1;
 private bool hasCmd;
 private string cmd_ = "";
 public bool HasCmd {
 get { return hasCmd; }
 }
 public string Cmd {
 get { return cmd_; }
 set { SetCmd(value); }
 }
 public void SetCmd(string value) { 
 hasCmd = true;
 cmd_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCmd) {
size += pb::CodedOutputStream.ComputeStringSize(1, Cmd);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCmd) {
output.WriteString(1, Cmd);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GMCOMMAND _inst = (CG_GMCOMMAND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.Cmd = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCmd) return false;
 return true;
 }

}


[Serializable]
public class GC_PLAYSTORY : PacketDistributed
{

public const int storyIDFieldNumber = 1;
 private bool hasStoryID;
 private Int32 storyID_ = 0;
 public bool HasStoryID {
 get { return hasStoryID; }
 }
 public Int32 StoryID {
 get { return storyID_; }
 set { SetStoryID(value); }
 }
 public void SetStoryID(Int32 value) { 
 hasStoryID = true;
 storyID_ = value;
 }

public const int dialogIDFieldNumber = 2;
 private bool hasDialogID;
 private Int32 dialogID_ = 0;
 public bool HasDialogID {
 get { return hasDialogID; }
 }
 public Int32 DialogID {
 get { return dialogID_; }
 set { SetDialogID(value); }
 }
 public void SetDialogID(Int32 value) { 
 hasDialogID = true;
 dialogID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasStoryID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, StoryID);
}
 if (HasDialogID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, DialogID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasStoryID) {
output.WriteInt32(1, StoryID);
}
 
if (HasDialogID) {
output.WriteInt32(2, DialogID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_PLAYSTORY _inst = (GC_PLAYSTORY) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.StoryID = input.ReadInt32();
break;
}
   case  16: {
 _inst.DialogID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasStoryID) return false;
 return true;
 }

}


[Serializable]
public class CG_PLAYSTORY_OVER : PacketDistributed
{

public const int storyIDFieldNumber = 1;
 private bool hasStoryID;
 private Int32 storyID_ = 0;
 public bool HasStoryID {
 get { return hasStoryID; }
 }
 public Int32 StoryID {
 get { return storyID_; }
 set { SetStoryID(value); }
 }
 public void SetStoryID(Int32 value) { 
 hasStoryID = true;
 storyID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasStoryID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, StoryID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasStoryID) {
output.WriteInt32(1, StoryID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_PLAYSTORY_OVER _inst = (CG_PLAYSTORY_OVER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.StoryID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasStoryID) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_RELIVE : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_RELIVE _inst = (CG_ASK_RELIVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_RELIVE : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int pos_xFieldNumber = 2;
 private bool hasPos_x;
 private Int32 pos_x_ = 0;
 public bool HasPos_x {
 get { return hasPos_x; }
 }
 public Int32 Pos_x {
 get { return pos_x_; }
 set { SetPos_x(value); }
 }
 public void SetPos_x(Int32 value) { 
 hasPos_x = true;
 pos_x_ = value;
 }

public const int pos_zFieldNumber = 3;
 private bool hasPos_z;
 private Int32 pos_z_ = 0;
 public bool HasPos_z {
 get { return hasPos_z; }
 }
 public Int32 Pos_z {
 get { return pos_z_; }
 set { SetPos_z(value); }
 }
 public void SetPos_z(Int32 value) { 
 hasPos_z = true;
 pos_z_ = value;
 }

public const int facedirFieldNumber = 4;
 private bool hasFacedir;
 private Int32 facedir_ = 0;
 public bool HasFacedir {
 get { return hasFacedir; }
 }
 public Int32 Facedir {
 get { return facedir_; }
 set { SetFacedir(value); }
 }
 public void SetFacedir(Int32 value) { 
 hasFacedir = true;
 facedir_ = value;
 }

public const int reviveTimeFieldNumber = 5;
 private bool hasReviveTime;
 private Int32 reviveTime_ = 0;
 public bool HasReviveTime {
 get { return hasReviveTime; }
 }
 public Int32 ReviveTime {
 get { return reviveTime_; }
 set { SetReviveTime(value); }
 }
 public void SetReviveTime(Int32 value) { 
 hasReviveTime = true;
 reviveTime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasPos_x) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Pos_x);
}
 if (HasPos_z) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Pos_z);
}
 if (HasFacedir) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Facedir);
}
 if (HasReviveTime) {
size += pb::CodedOutputStream.ComputeInt32Size(5, ReviveTime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasPos_x) {
output.WriteInt32(2, Pos_x);
}
 
if (HasPos_z) {
output.WriteInt32(3, Pos_z);
}
 
if (HasFacedir) {
output.WriteInt32(4, Facedir);
}
 
if (HasReviveTime) {
output.WriteInt32(5, ReviveTime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_RELIVE _inst = (GC_RET_RELIVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.Pos_x = input.ReadInt32();
break;
}
   case  24: {
 _inst.Pos_z = input.ReadInt32();
break;
}
   case  32: {
 _inst.Facedir = input.ReadInt32();
break;
}
   case  40: {
 _inst.ReviveTime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 return true;
 }

}


[Serializable]
public class GC_DROPITEM_INFO : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int ownerGuidFieldNumber = 2;
 private bool hasOwnerGuid;
 private UInt64 ownerGuid_ = 0;
 public bool HasOwnerGuid {
 get { return hasOwnerGuid; }
 }
 public UInt64 OwnerGuid {
 get { return ownerGuid_; }
 set { SetOwnerGuid(value); }
 }
 public void SetOwnerGuid(UInt64 value) { 
 hasOwnerGuid = true;
 ownerGuid_ = value;
 }

public const int dropItemIdFieldNumber = 3;
 private bool hasDropItemId;
 private Int32 dropItemId_ = 0;
 public bool HasDropItemId {
 get { return hasDropItemId; }
 }
 public Int32 DropItemId {
 get { return dropItemId_; }
 set { SetDropItemId(value); }
 }
 public void SetDropItemId(Int32 value) { 
 hasDropItemId = true;
 dropItemId_ = value;
 }

public const int pos_xFieldNumber = 4;
 private bool hasPos_x;
 private Int32 pos_x_ = 0;
 public bool HasPos_x {
 get { return hasPos_x; }
 }
 public Int32 Pos_x {
 get { return pos_x_; }
 set { SetPos_x(value); }
 }
 public void SetPos_x(Int32 value) { 
 hasPos_x = true;
 pos_x_ = value;
 }

public const int pos_zFieldNumber = 5;
 private bool hasPos_z;
 private Int32 pos_z_ = 0;
 public bool HasPos_z {
 get { return hasPos_z; }
 }
 public Int32 Pos_z {
 get { return pos_z_; }
 set { SetPos_z(value); }
 }
 public void SetPos_z(Int32 value) { 
 hasPos_z = true;
 pos_z_ = value;
 }

public const int typeFieldNumber = 6;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int countFieldNumber = 7;
 private bool hasCount;
 private Int32 count_ = 0;
 public bool HasCount {
 get { return hasCount; }
 }
 public Int32 Count {
 get { return count_; }
 set { SetCount(value); }
 }
 public void SetCount(Int32 value) { 
 hasCount = true;
 count_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasOwnerGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, OwnerGuid);
}
 if (HasDropItemId) {
size += pb::CodedOutputStream.ComputeInt32Size(3, DropItemId);
}
 if (HasPos_x) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Pos_x);
}
 if (HasPos_z) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Pos_z);
}
 if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Type);
}
 if (HasCount) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Count);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasOwnerGuid) {
output.WriteUInt64(2, OwnerGuid);
}
 
if (HasDropItemId) {
output.WriteInt32(3, DropItemId);
}
 
if (HasPos_x) {
output.WriteInt32(4, Pos_x);
}
 
if (HasPos_z) {
output.WriteInt32(5, Pos_z);
}
 
if (HasType) {
output.WriteInt32(6, Type);
}
 
if (HasCount) {
output.WriteInt32(7, Count);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DROPITEM_INFO _inst = (GC_DROPITEM_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.OwnerGuid = input.ReadUInt64();
break;
}
   case  24: {
 _inst.DropItemId = input.ReadInt32();
break;
}
   case  32: {
 _inst.Pos_x = input.ReadInt32();
break;
}
   case  40: {
 _inst.Pos_z = input.ReadInt32();
break;
}
   case  48: {
 _inst.Type = input.ReadInt32();
break;
}
   case  56: {
 _inst.Count = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasOwnerGuid) return false;
 if (!hasDropItemId) return false;
 if (!hasPos_x) return false;
 if (!hasPos_z) return false;
 if (!hasType) return false;
 if (!hasCount) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_PICKUP_ITEM : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_PICKUP_ITEM _inst = (CG_ASK_PICKUP_ITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_PICKUP_ITEM : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int itemIdFieldNumber = 2;
 private bool hasItemId;
 private Int32 itemId_ = 0;
 public bool HasItemId {
 get { return hasItemId; }
 }
 public Int32 ItemId {
 get { return itemId_; }
 set { SetItemId(value); }
 }
 public void SetItemId(Int32 value) { 
 hasItemId = true;
 itemId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasItemId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, ItemId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasItemId) {
output.WriteInt32(2, ItemId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_PICKUP_ITEM _inst = (GC_RET_PICKUP_ITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.ItemId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasItemId) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATE_FELLOW : PacketDistributed
{

public const int packindexFieldNumber = 1;
 private bool hasPackindex;
 private Int32 packindex_ = 0;
 public bool HasPackindex {
 get { return hasPackindex; }
 }
 public Int32 Packindex {
 get { return packindex_; }
 set { SetPackindex(value); }
 }
 public void SetPackindex(Int32 value) { 
 hasPackindex = true;
 packindex_ = value;
 }

public const int guidFieldNumber = 2;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int dataidFieldNumber = 3;
 private bool hasDataid;
 private Int32 dataid_ = 0;
 public bool HasDataid {
 get { return hasDataid; }
 }
 public Int32 Dataid {
 get { return dataid_; }
 set { SetDataid(value); }
 }
 public void SetDataid(Int32 value) { 
 hasDataid = true;
 dataid_ = value;
 }

public const int nameFieldNumber = 4;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int qualityFieldNumber = 5;
 private bool hasQuality;
 private Int32 quality_ = 0;
 public bool HasQuality {
 get { return hasQuality; }
 }
 public Int32 Quality {
 get { return quality_; }
 set { SetQuality(value); }
 }
 public void SetQuality(Int32 value) { 
 hasQuality = true;
 quality_ = value;
 }

public const int expFieldNumber = 6;
 private bool hasExp;
 private Int32 exp_ = 0;
 public bool HasExp {
 get { return hasExp; }
 }
 public Int32 Exp {
 get { return exp_; }
 set { SetExp(value); }
 }
 public void SetExp(Int32 value) { 
 hasExp = true;
 exp_ = value;
 }

public const int levelFieldNumber = 7;
 private bool hasLevel;
 private Int32 level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 level_ = value;
 }

public const int starexpFieldNumber = 8;
 private bool hasStarexp;
 private Int32 starexp_ = 0;
 public bool HasStarexp {
 get { return hasStarexp; }
 }
 public Int32 Starexp {
 get { return starexp_; }
 set { SetStarexp(value); }
 }
 public void SetStarexp(Int32 value) { 
 hasStarexp = true;
 starexp_ = value;
 }

public const int starlevelFieldNumber = 9;
 private bool hasStarlevel;
 private Int32 starlevel_ = 0;
 public bool HasStarlevel {
 get { return hasStarlevel; }
 }
 public Int32 Starlevel {
 get { return starlevel_; }
 set { SetStarlevel(value); }
 }
 public void SetStarlevel(Int32 value) { 
 hasStarlevel = true;
 starlevel_ = value;
 }

public const int growupFieldNumber = 10;
 private bool hasGrowup;
 private Int32 growup_ = 0;
 public bool HasGrowup {
 get { return hasGrowup; }
 }
 public Int32 Growup {
 get { return growup_; }
 set { SetGrowup(value); }
 }
 public void SetGrowup(Int32 value) { 
 hasGrowup = true;
 growup_ = value;
 }

public const int luckyFieldNumber = 11;
 private bool hasLucky;
 private Int32 lucky_ = 0;
 public bool HasLucky {
 get { return hasLucky; }
 }
 public Int32 Lucky {
 get { return lucky_; }
 set { SetLucky(value); }
 }
 public void SetLucky(Int32 value) { 
 hasLucky = true;
 lucky_ = value;
 }

public const int procreatecountFieldNumber = 12;
 private bool hasProcreatecount;
 private Int32 procreatecount_ = 0;
 public bool HasProcreatecount {
 get { return hasProcreatecount; }
 }
 public Int32 Procreatecount {
 get { return procreatecount_; }
 set { SetProcreatecount(value); }
 }
 public void SetProcreatecount(Int32 value) { 
 hasProcreatecount = true;
 procreatecount_ = value;
 }

public const int elementattrFieldNumber = 13;
 private bool hasElementattr;
 private Int32 elementattr_ = 0;
 public bool HasElementattr {
 get { return hasElementattr; }
 }
 public Int32 Elementattr {
 get { return elementattr_; }
 set { SetElementattr(value); }
 }
 public void SetElementattr(Int32 value) { 
 hasElementattr = true;
 elementattr_ = value;
 }

public const int islockFieldNumber = 14;
 private bool hasIslock;
 private Int32 islock_ = 0;
 public bool HasIslock {
 get { return hasIslock; }
 }
 public Int32 Islock {
 get { return islock_; }
 set { SetIslock(value); }
 }
 public void SetIslock(Int32 value) { 
 hasIslock = true;
 islock_ = value;
 }

public const int baseattackFieldNumber = 15;
 private bool hasBaseattack;
 private Int32 baseattack_ = 0;
 public bool HasBaseattack {
 get { return hasBaseattack; }
 }
 public Int32 Baseattack {
 get { return baseattack_; }
 set { SetBaseattack(value); }
 }
 public void SetBaseattack(Int32 value) { 
 hasBaseattack = true;
 baseattack_ = value;
 }

public const int basehitFieldNumber = 16;
 private bool hasBasehit;
 private Int32 basehit_ = 0;
 public bool HasBasehit {
 get { return hasBasehit; }
 }
 public Int32 Basehit {
 get { return basehit_; }
 set { SetBasehit(value); }
 }
 public void SetBasehit(Int32 value) { 
 hasBasehit = true;
 basehit_ = value;
 }

public const int basecriticalFieldNumber = 17;
 private bool hasBasecritical;
 private Int32 basecritical_ = 0;
 public bool HasBasecritical {
 get { return hasBasecritical; }
 }
 public Int32 Basecritical {
 get { return basecritical_; }
 set { SetBasecritical(value); }
 }
 public void SetBasecritical(Int32 value) { 
 hasBasecritical = true;
 basecritical_ = value;
 }

public const int baseguardFieldNumber = 18;
 private bool hasBaseguard;
 private Int32 baseguard_ = 0;
 public bool HasBaseguard {
 get { return hasBaseguard; }
 }
 public Int32 Baseguard {
 get { return baseguard_; }
 set { SetBaseguard(value); }
 }
 public void SetBaseguard(Int32 value) { 
 hasBaseguard = true;
 baseguard_ = value;
 }

public const int baseblessFieldNumber = 19;
 private bool hasBasebless;
 private Int32 basebless_ = 0;
 public bool HasBasebless {
 get { return hasBasebless; }
 }
 public Int32 Basebless {
 get { return basebless_; }
 set { SetBasebless(value); }
 }
 public void SetBasebless(Int32 value) { 
 hasBasebless = true;
 basebless_ = value;
 }

public const int tallentskillidFieldNumber = 20;
 private pbc::PopsicleList<Int32> tallentskillid_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> tallentskillidList {
 get { return pbc::Lists.AsReadOnly(tallentskillid_); }
 }
 
 public int tallentskillidCount {
 get { return tallentskillid_.Count; }
 }
 
public Int32 GetTallentskillid(int index) {
 return tallentskillid_[index];
 }
 public void AddTallentskillid(Int32 value) {
 tallentskillid_.Add(value);
 }

public const int tallentskilllevelFieldNumber = 21;
 private pbc::PopsicleList<Int32> tallentskilllevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> tallentskilllevelList {
 get { return pbc::Lists.AsReadOnly(tallentskilllevel_); }
 }
 
 public int tallentskilllevelCount {
 get { return tallentskilllevel_.Count; }
 }
 
public Int32 GetTallentskilllevel(int index) {
 return tallentskilllevel_[index];
 }
 public void AddTallentskilllevel(Int32 value) {
 tallentskilllevel_.Add(value);
 }

public const int elementskillidFieldNumber = 22;
 private pbc::PopsicleList<Int32> elementskillid_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> elementskillidList {
 get { return pbc::Lists.AsReadOnly(elementskillid_); }
 }
 
 public int elementskillidCount {
 get { return elementskillid_.Count; }
 }
 
public Int32 GetElementskillid(int index) {
 return elementskillid_[index];
 }
 public void AddElementskillid(Int32 value) {
 elementskillid_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPackindex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Packindex);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Guid);
}
 if (HasDataid) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Dataid);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(4, Name);
}
 if (HasQuality) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Quality);
}
 if (HasExp) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Exp);
}
 if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Level);
}
 if (HasStarexp) {
size += pb::CodedOutputStream.ComputeInt32Size(8, Starexp);
}
 if (HasStarlevel) {
size += pb::CodedOutputStream.ComputeInt32Size(9, Starlevel);
}
 if (HasGrowup) {
size += pb::CodedOutputStream.ComputeInt32Size(10, Growup);
}
 if (HasLucky) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Lucky);
}
 if (HasProcreatecount) {
size += pb::CodedOutputStream.ComputeInt32Size(12, Procreatecount);
}
 if (HasElementattr) {
size += pb::CodedOutputStream.ComputeInt32Size(13, Elementattr);
}
 if (HasIslock) {
size += pb::CodedOutputStream.ComputeInt32Size(14, Islock);
}
 if (HasBaseattack) {
size += pb::CodedOutputStream.ComputeInt32Size(15, Baseattack);
}
 if (HasBasehit) {
size += pb::CodedOutputStream.ComputeInt32Size(16, Basehit);
}
 if (HasBasecritical) {
size += pb::CodedOutputStream.ComputeInt32Size(17, Basecritical);
}
 if (HasBaseguard) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Baseguard);
}
 if (HasBasebless) {
size += pb::CodedOutputStream.ComputeInt32Size(19, Basebless);
}
{
int dataSize = 0;
for(int i=0; i<tallentskillidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(tallentskillidList[i]);
}
size += dataSize;
size += 1 * tallentskillid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<tallentskilllevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(tallentskilllevelList[i]);
}
size += dataSize;
size += 1 * tallentskilllevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<elementskillidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(elementskillidList[i]);
}
size += dataSize;
size += 1 * elementskillid_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPackindex) {
output.WriteInt32(1, Packindex);
}
 
if (HasGuid) {
output.WriteUInt64(2, Guid);
}
 
if (HasDataid) {
output.WriteInt32(3, Dataid);
}
 
if (HasName) {
output.WriteString(4, Name);
}
 
if (HasQuality) {
output.WriteInt32(5, Quality);
}
 
if (HasExp) {
output.WriteInt32(6, Exp);
}
 
if (HasLevel) {
output.WriteInt32(7, Level);
}
 
if (HasStarexp) {
output.WriteInt32(8, Starexp);
}
 
if (HasStarlevel) {
output.WriteInt32(9, Starlevel);
}
 
if (HasGrowup) {
output.WriteInt32(10, Growup);
}
 
if (HasLucky) {
output.WriteInt32(11, Lucky);
}
 
if (HasProcreatecount) {
output.WriteInt32(12, Procreatecount);
}
 
if (HasElementattr) {
output.WriteInt32(13, Elementattr);
}
 
if (HasIslock) {
output.WriteInt32(14, Islock);
}
 
if (HasBaseattack) {
output.WriteInt32(15, Baseattack);
}
 
if (HasBasehit) {
output.WriteInt32(16, Basehit);
}
 
if (HasBasecritical) {
output.WriteInt32(17, Basecritical);
}
 
if (HasBaseguard) {
output.WriteInt32(18, Baseguard);
}
 
if (HasBasebless) {
output.WriteInt32(19, Basebless);
}
{
if (tallentskillid_.Count > 0) {
for(int i=0; i<tallentskillid_.Count; ++i){
output.WriteInt32(20,tallentskillid_[i]);
}
}

}
{
if (tallentskilllevel_.Count > 0) {
for(int i=0; i<tallentskilllevel_.Count; ++i){
output.WriteInt32(21,tallentskilllevel_[i]);
}
}

}
{
if (elementskillid_.Count > 0) {
for(int i=0; i<elementskillid_.Count; ++i){
output.WriteInt32(22,elementskillid_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_FELLOW _inst = (GC_UPDATE_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Packindex = input.ReadInt32();
break;
}
   case  16: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  24: {
 _inst.Dataid = input.ReadInt32();
break;
}
   case  34: {
 _inst.Name = input.ReadString();
break;
}
   case  40: {
 _inst.Quality = input.ReadInt32();
break;
}
   case  48: {
 _inst.Exp = input.ReadInt32();
break;
}
   case  56: {
 _inst.Level = input.ReadInt32();
break;
}
   case  64: {
 _inst.Starexp = input.ReadInt32();
break;
}
   case  72: {
 _inst.Starlevel = input.ReadInt32();
break;
}
   case  80: {
 _inst.Growup = input.ReadInt32();
break;
}
   case  88: {
 _inst.Lucky = input.ReadInt32();
break;
}
   case  96: {
 _inst.Procreatecount = input.ReadInt32();
break;
}
   case  104: {
 _inst.Elementattr = input.ReadInt32();
break;
}
   case  112: {
 _inst.Islock = input.ReadInt32();
break;
}
   case  120: {
 _inst.Baseattack = input.ReadInt32();
break;
}
   case  128: {
 _inst.Basehit = input.ReadInt32();
break;
}
   case  136: {
 _inst.Basecritical = input.ReadInt32();
break;
}
   case  144: {
 _inst.Baseguard = input.ReadInt32();
break;
}
   case  152: {
 _inst.Basebless = input.ReadInt32();
break;
}
   case  160: {
 _inst.AddTallentskillid(input.ReadInt32());
break;
}
   case  168: {
 _inst.AddTallentskilllevel(input.ReadInt32());
break;
}
   case  176: {
 _inst.AddElementskillid(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPackindex) return false;
 if (!hasGuid) return false;
 if (!hasDataid) return false;
 if (!hasName) return false;
 return true;
 }

}


[Serializable]
public class GC_SERVER_SERIOUSERROR : PacketDistributed
{
public enum ServerSeriousErrorType 
 { 
  ERRORTYPE_CREATEROLE = 0,  // ������ɫʧ�� 
  ERRORTYPE_SELECTROLE = 1,  // ѡ���ɫʧ�� 
 }
public const int errorTypeFieldNumber = 1;
 private bool hasErrorType;
 private Int32 errorType_ = 0;
 public bool HasErrorType {
 get { return hasErrorType; }
 }
 public Int32 ErrorType {
 get { return errorType_; }
 set { SetErrorType(value); }
 }
 public void SetErrorType(Int32 value) { 
 hasErrorType = true;
 errorType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasErrorType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ErrorType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasErrorType) {
output.WriteInt32(1, ErrorType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SERVER_SERIOUSERROR _inst = (GC_SERVER_SERIOUSERROR) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ErrorType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasErrorType) return false;
 return true;
 }

}


[Serializable]
public class GC_ADDITIONINFO_UPDATE : PacketDistributed
{

public const int doubleExpDurtaionFieldNumber = 2;
 private bool hasDoubleExpDurtaion;
 private Int32 doubleExpDurtaion_ = 0;
 public bool HasDoubleExpDurtaion {
 get { return hasDoubleExpDurtaion; }
 }
 public Int32 DoubleExpDurtaion {
 get { return doubleExpDurtaion_; }
 set { SetDoubleExpDurtaion(value); }
 }
 public void SetDoubleExpDurtaion(Int32 value) { 
 hasDoubleExpDurtaion = true;
 doubleExpDurtaion_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasDoubleExpDurtaion) {
size += pb::CodedOutputStream.ComputeInt32Size(2, DoubleExpDurtaion);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasDoubleExpDurtaion) {
output.WriteInt32(2, DoubleExpDurtaion);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ADDITIONINFO_UPDATE _inst = (GC_ADDITIONINFO_UPDATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  16: {
 _inst.DoubleExpDurtaion = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_ASK_SELOBJ_INFO : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int seleobjIdFieldNumber = 2;
 private bool hasSeleobjId;
 private Int32 seleobjId_ = 0;
 public bool HasSeleobjId {
 get { return hasSeleobjId; }
 }
 public Int32 SeleobjId {
 get { return seleobjId_; }
 set { SetSeleobjId(value); }
 }
 public void SetSeleobjId(Int32 value) { 
 hasSeleobjId = true;
 seleobjId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasSeleobjId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SeleobjId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasSeleobjId) {
output.WriteInt32(2, SeleobjId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_SELOBJ_INFO _inst = (CG_ASK_SELOBJ_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.SeleobjId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasSeleobjId) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_SELOBJ_INFO : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int seleobjIdFieldNumber = 2;
 private bool hasSeleobjId;
 private Int32 seleobjId_ = 0;
 public bool HasSeleobjId {
 get { return hasSeleobjId; }
 }
 public Int32 SeleobjId {
 get { return seleobjId_; }
 set { SetSeleobjId(value); }
 }
 public void SetSeleobjId(Int32 value) { 
 hasSeleobjId = true;
 seleobjId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasSeleobjId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SeleobjId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasSeleobjId) {
output.WriteInt32(2, SeleobjId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_SELOBJ_INFO _inst = (GC_RET_SELOBJ_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.SeleobjId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasSeleobjId) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_USE_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

public const int senderIdFieldNumber = 2;
 private bool hasSenderId;
 private Int32 senderId_ = 0;
 public bool HasSenderId {
 get { return hasSenderId; }
 }
 public Int32 SenderId {
 get { return senderId_; }
 set { SetSenderId(value); }
 }
 public void SetSenderId(Int32 value) { 
 hasSenderId = true;
 senderId_ = value;
 }

public const int TargetIdFieldNumber = 3;
 private bool hasTargetId;
 private Int32 TargetId_ = 0;
 public bool HasTargetId {
 get { return hasTargetId; }
 }
 public Int32 TargetId {
 get { return TargetId_; }
 set { SetTargetId(value); }
 }
 public void SetTargetId(Int32 value) { 
 hasTargetId = true;
 TargetId_ = value;
 }

public const int skillfailTypeFieldNumber = 4;
 private bool hasSkillfailType;
 private Int32 skillfailType_ = 0;
 public bool HasSkillfailType {
 get { return hasSkillfailType; }
 }
 public Int32 SkillfailType {
 get { return skillfailType_; }
 set { SetSkillfailType(value); }
 }
 public void SetSkillfailType(Int32 value) { 
 hasSkillfailType = true;
 skillfailType_ = value;
 }

public const int skillnameFieldNumber = 5;
 private bool hasSkillname;
 private string skillname_ = "";
 public bool HasSkillname {
 get { return hasSkillname; }
 }
 public string Skillname {
 get { return skillname_; }
 set { SetSkillname(value); }
 }
 public void SetSkillname(string value) { 
 hasSkillname = true;
 skillname_ = value;
 }

public const int fixedSkillIdFieldNumber = 6;
 private bool hasFixedSkillId;
 private Int32 fixedSkillId_ = 0;
 public bool HasFixedSkillId {
 get { return hasFixedSkillId; }
 }
 public Int32 FixedSkillId {
 get { return fixedSkillId_; }
 set { SetFixedSkillId(value); }
 }
 public void SetFixedSkillId(Int32 value) { 
 hasFixedSkillId = true;
 fixedSkillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 if (HasSenderId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SenderId);
}
 if (HasTargetId) {
size += pb::CodedOutputStream.ComputeInt32Size(3, TargetId);
}
 if (HasSkillfailType) {
size += pb::CodedOutputStream.ComputeInt32Size(4, SkillfailType);
}
 if (HasSkillname) {
size += pb::CodedOutputStream.ComputeStringSize(5, Skillname);
}
 if (HasFixedSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(6, FixedSkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 
if (HasSenderId) {
output.WriteInt32(2, SenderId);
}
 
if (HasTargetId) {
output.WriteInt32(3, TargetId);
}
 
if (HasSkillfailType) {
output.WriteInt32(4, SkillfailType);
}
 
if (HasSkillname) {
output.WriteString(5, Skillname);
}
 
if (HasFixedSkillId) {
output.WriteInt32(6, FixedSkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_USE_SKILL _inst = (GC_RET_USE_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}
   case  16: {
 _inst.SenderId = input.ReadInt32();
break;
}
   case  24: {
 _inst.TargetId = input.ReadInt32();
break;
}
   case  32: {
 _inst.SkillfailType = input.ReadInt32();
break;
}
   case  42: {
 _inst.Skillname = input.ReadString();
break;
}
   case  48: {
 _inst.FixedSkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 if (!hasSenderId) return false;
 if (!hasTargetId) return false;
 return true;
 }

}


[Serializable]
public class GC_CREATE_FELLOW : PacketDistributed
{

public const int serverIdFieldNumber = 1;
 private bool hasServerId;
 private Int32 serverId_ = 0;
 public bool HasServerId {
 get { return hasServerId; }
 }
 public Int32 ServerId {
 get { return serverId_; }
 set { SetServerId(value); }
 }
 public void SetServerId(Int32 value) { 
 hasServerId = true;
 serverId_ = value;
 }

public const int sceneInstFieldNumber = 2;
 private bool hasSceneInst;
 private Int32 sceneInst_ = 0;
 public bool HasSceneInst {
 get { return hasSceneInst; }
 }
 public Int32 SceneInst {
 get { return sceneInst_; }
 set { SetSceneInst(value); }
 }
 public void SetSceneInst(Int32 value) { 
 hasSceneInst = true;
 sceneInst_ = value;
 }

public const int sceneClassFieldNumber = 3;
 private bool hasSceneClass;
 private Int32 sceneClass_ = 0;
 public bool HasSceneClass {
 get { return hasSceneClass; }
 }
 public Int32 SceneClass {
 get { return sceneClass_; }
 set { SetSceneClass(value); }
 }
 public void SetSceneClass(Int32 value) { 
 hasSceneClass = true;
 sceneClass_ = value;
 }

public const int dataIdFieldNumber = 4;
 private bool hasDataId;
 private Int32 dataId_ = 0;
 public bool HasDataId {
 get { return hasDataId; }
 }
 public Int32 DataId {
 get { return dataId_; }
 set { SetDataId(value); }
 }
 public void SetDataId(Int32 value) { 
 hasDataId = true;
 dataId_ = value;
 }

public const int guidFieldNumber = 5;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int posXFieldNumber = 6;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 7;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

public const int curforceFieldNumber = 8;
 private bool hasCurforce;
 private Int32 curforce_ = 0;
 public bool HasCurforce {
 get { return hasCurforce; }
 }
 public Int32 Curforce {
 get { return curforce_; }
 set { SetCurforce(value); }
 }
 public void SetCurforce(Int32 value) { 
 hasCurforce = true;
 curforce_ = value;
 }

public const int nameFieldNumber = 9;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int facedirFieldNumber = 10;
 private bool hasFacedir;
 private Int32 facedir_ = 0;
 public bool HasFacedir {
 get { return hasFacedir; }
 }
 public Int32 Facedir {
 get { return facedir_; }
 set { SetFacedir(value); }
 }
 public void SetFacedir(Int32 value) { 
 hasFacedir = true;
 facedir_ = value;
 }

public const int ownerobjidFieldNumber = 11;
 private bool hasOwnerobjid;
 private Int32 ownerobjid_ = 0;
 public bool HasOwnerobjid {
 get { return hasOwnerobjid; }
 }
 public Int32 Ownerobjid {
 get { return ownerobjid_; }
 set { SetOwnerobjid(value); }
 }
 public void SetOwnerobjid(Int32 value) { 
 hasOwnerobjid = true;
 ownerobjid_ = value;
 }

public const int movespeedFieldNumber = 12;
 private bool hasMovespeed;
 private Int32 movespeed_ = 0;
 public bool HasMovespeed {
 get { return hasMovespeed; }
 }
 public Int32 Movespeed {
 get { return movespeed_; }
 set { SetMovespeed(value); }
 }
 public void SetMovespeed(Int32 value) { 
 hasMovespeed = true;
 movespeed_ = value;
 }

public const int stealthLevFieldNumber = 13;
 private bool hasStealthLev;
 private Int32 stealthLev_ = 0;
 public bool HasStealthLev {
 get { return hasStealthLev; }
 }
 public Int32 StealthLev {
 get { return stealthLev_; }
 set { SetStealthLev(value); }
 }
 public void SetStealthLev(Int32 value) { 
 hasStealthLev = true;
 stealthLev_ = value;
 }

public const int qualityFieldNumber = 14;
 private bool hasQuality;
 private Int32 quality_ = 0;
 public bool HasQuality {
 get { return hasQuality; }
 }
 public Int32 Quality {
 get { return quality_; }
 set { SetQuality(value); }
 }
 public void SetQuality(Int32 value) { 
 hasQuality = true;
 quality_ = value;
 }

public const int bindparentFieldNumber = 15;
 private bool hasBindparent;
 private Int32 bindparent_ = 0;
 public bool HasBindparent {
 get { return hasBindparent; }
 }
 public Int32 Bindparent {
 get { return bindparent_; }
 set { SetBindparent(value); }
 }
 public void SetBindparent(Int32 value) { 
 hasBindparent = true;
 bindparent_ = value;
 }

public const int bindchildrenFieldNumber = 16;
 private pbc::PopsicleList<Int32> bindchildren_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> bindchildrenList {
 get { return pbc::Lists.AsReadOnly(bindchildren_); }
 }
 
 public int bindchildrenCount {
 get { return bindchildren_.Count; }
 }
 
public Int32 GetBindchildren(int index) {
 return bindchildren_[index];
 }
 public void AddBindchildren(Int32 value) {
 bindchildren_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ServerId);
}
 if (HasSceneInst) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SceneInst);
}
 if (HasSceneClass) {
size += pb::CodedOutputStream.ComputeInt32Size(3, SceneClass);
}
 if (HasDataId) {
size += pb::CodedOutputStream.ComputeInt32Size(4, DataId);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(5, Guid);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(6, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(7, PosZ);
}
 if (HasCurforce) {
size += pb::CodedOutputStream.ComputeInt32Size(8, Curforce);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(9, Name);
}
 if (HasFacedir) {
size += pb::CodedOutputStream.ComputeInt32Size(10, Facedir);
}
 if (HasOwnerobjid) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Ownerobjid);
}
 if (HasMovespeed) {
size += pb::CodedOutputStream.ComputeInt32Size(12, Movespeed);
}
 if (HasStealthLev) {
size += pb::CodedOutputStream.ComputeInt32Size(13, StealthLev);
}
 if (HasQuality) {
size += pb::CodedOutputStream.ComputeInt32Size(14, Quality);
}
 if (HasBindparent) {
size += pb::CodedOutputStream.ComputeInt32Size(15, Bindparent);
}
{
int dataSize = 0;
for(int i=0; i<bindchildrenList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(bindchildrenList[i]);
}
size += dataSize;
size += 1 * bindchildren_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerId) {
output.WriteInt32(1, ServerId);
}
 
if (HasSceneInst) {
output.WriteInt32(2, SceneInst);
}
 
if (HasSceneClass) {
output.WriteInt32(3, SceneClass);
}
 
if (HasDataId) {
output.WriteInt32(4, DataId);
}
 
if (HasGuid) {
output.WriteUInt64(5, Guid);
}
 
if (HasPosX) {
output.WriteInt32(6, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(7, PosZ);
}
 
if (HasCurforce) {
output.WriteInt32(8, Curforce);
}
 
if (HasName) {
output.WriteString(9, Name);
}
 
if (HasFacedir) {
output.WriteInt32(10, Facedir);
}
 
if (HasOwnerobjid) {
output.WriteInt32(11, Ownerobjid);
}
 
if (HasMovespeed) {
output.WriteInt32(12, Movespeed);
}
 
if (HasStealthLev) {
output.WriteInt32(13, StealthLev);
}
 
if (HasQuality) {
output.WriteInt32(14, Quality);
}
 
if (HasBindparent) {
output.WriteInt32(15, Bindparent);
}
{
if (bindchildren_.Count > 0) {
for(int i=0; i<bindchildren_.Count; ++i){
output.WriteInt32(16,bindchildren_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CREATE_FELLOW _inst = (GC_CREATE_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ServerId = input.ReadInt32();
break;
}
   case  16: {
 _inst.SceneInst = input.ReadInt32();
break;
}
   case  24: {
 _inst.SceneClass = input.ReadInt32();
break;
}
   case  32: {
 _inst.DataId = input.ReadInt32();
break;
}
   case  40: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  48: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  56: {
 _inst.PosZ = input.ReadInt32();
break;
}
   case  64: {
 _inst.Curforce = input.ReadInt32();
break;
}
   case  74: {
 _inst.Name = input.ReadString();
break;
}
   case  80: {
 _inst.Facedir = input.ReadInt32();
break;
}
   case  88: {
 _inst.Ownerobjid = input.ReadInt32();
break;
}
   case  96: {
 _inst.Movespeed = input.ReadInt32();
break;
}
   case  104: {
 _inst.StealthLev = input.ReadInt32();
break;
}
   case  112: {
 _inst.Quality = input.ReadInt32();
break;
}
   case  120: {
 _inst.Bindparent = input.ReadInt32();
break;
}
   case  128: {
 _inst.AddBindchildren(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerId) return false;
 if (!hasSceneInst) return false;
 if (!hasSceneClass) return false;
 if (!hasDataId) return false;
 if (!hasGuid) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 if (!hasCurforce) return false;
 if (!hasName) return false;
 if (!hasFacedir) return false;
 if (!hasOwnerobjid) return false;
 if (!hasMovespeed) return false;
 if (!hasStealthLev) return false;
 if (!hasQuality) return false;
 if (!hasBindparent) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_ROLE_DATA : PacketDistributed
{

public const int userguidFieldNumber = 1;
 private bool hasUserguid;
 private UInt64 userguid_ = 0;
 public bool HasUserguid {
 get { return hasUserguid; }
 }
 public UInt64 Userguid {
 get { return userguid_; }
 set { SetUserguid(value); }
 }
 public void SetUserguid(UInt64 value) { 
 hasUserguid = true;
 userguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasUserguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Userguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasUserguid) {
output.WriteUInt64(1, Userguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_ROLE_DATA _inst = (CG_ASK_ROLE_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Userguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasUserguid) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_ROLE_DATA : PacketDistributed
{

public const int rolenameFieldNumber = 1;
 private bool hasRolename;
 private string rolename_ = "";
 public bool HasRolename {
 get { return hasRolename; }
 }
 public string Rolename {
 get { return rolename_; }
 set { SetRolename(value); }
 }
 public void SetRolename(string value) { 
 hasRolename = true;
 rolename_ = value;
 }

public const int combatvalueFieldNumber = 2;
 private bool hasCombatvalue;
 private Int32 combatvalue_ = 0;
 public bool HasCombatvalue {
 get { return hasCombatvalue; }
 }
 public Int32 Combatvalue {
 get { return combatvalue_; }
 set { SetCombatvalue(value); }
 }
 public void SetCombatvalue(Int32 value) { 
 hasCombatvalue = true;
 combatvalue_ = value;
 }

public const int leveFieldNumber = 3;
 private bool hasLeve;
 private Int32 leve_ = 0;
 public bool HasLeve {
 get { return hasLeve; }
 }
 public Int32 Leve {
 get { return leve_; }
 set { SetLeve(value); }
 }
 public void SetLeve(Int32 value) { 
 hasLeve = true;
 leve_ = value;
 }

public const int professionFieldNumber = 4;
 private bool hasProfession;
 private Int32 profession_ = 0;
 public bool HasProfession {
 get { return hasProfession; }
 }
 public Int32 Profession {
 get { return profession_; }
 set { SetProfession(value); }
 }
 public void SetProfession(Int32 value) { 
 hasProfession = true;
 profession_ = value;
 }

public const int guidFieldNumber = 5;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int curhpFieldNumber = 6;
 private bool hasCurhp;
 private Int32 curhp_ = 0;
 public bool HasCurhp {
 get { return hasCurhp; }
 }
 public Int32 Curhp {
 get { return curhp_; }
 set { SetCurhp(value); }
 }
 public void SetCurhp(Int32 value) { 
 hasCurhp = true;
 curhp_ = value;
 }

public const int maxhpFieldNumber = 7;
 private bool hasMaxhp;
 private Int32 maxhp_ = 0;
 public bool HasMaxhp {
 get { return hasMaxhp; }
 }
 public Int32 Maxhp {
 get { return maxhp_; }
 set { SetMaxhp(value); }
 }
 public void SetMaxhp(Int32 value) { 
 hasMaxhp = true;
 maxhp_ = value;
 }

public const int curmpFieldNumber = 8;
 private bool hasCurmp;
 private Int32 curmp_ = 0;
 public bool HasCurmp {
 get { return hasCurmp; }
 }
 public Int32 Curmp {
 get { return curmp_; }
 set { SetCurmp(value); }
 }
 public void SetCurmp(Int32 value) { 
 hasCurmp = true;
 curmp_ = value;
 }

public const int maxmpFieldNumber = 9;
 private bool hasMaxmp;
 private Int32 maxmp_ = 0;
 public bool HasMaxmp {
 get { return hasMaxmp; }
 }
 public Int32 Maxmp {
 get { return maxmp_; }
 set { SetMaxmp(value); }
 }
 public void SetMaxmp(Int32 value) { 
 hasMaxmp = true;
 maxmp_ = value;
 }

public const int curexpFieldNumber = 10;
 private bool hasCurexp;
 private Int32 curexp_ = 0;
 public bool HasCurexp {
 get { return hasCurexp; }
 }
 public Int32 Curexp {
 get { return curexp_; }
 set { SetCurexp(value); }
 }
 public void SetCurexp(Int32 value) { 
 hasCurexp = true;
 curexp_ = value;
 }

public const int maxexpFieldNumber = 11;
 private bool hasMaxexp;
 private Int32 maxexp_ = 0;
 public bool HasMaxexp {
 get { return hasMaxexp; }
 }
 public Int32 Maxexp {
 get { return maxexp_; }
 set { SetMaxexp(value); }
 }
 public void SetMaxexp(Int32 value) { 
 hasMaxexp = true;
 maxexp_ = value;
 }

public const int pattackFieldNumber = 12;
 private bool hasPattack;
 private Int32 pattack_ = 0;
 public bool HasPattack {
 get { return hasPattack; }
 }
 public Int32 Pattack {
 get { return pattack_; }
 set { SetPattack(value); }
 }
 public void SetPattack(Int32 value) { 
 hasPattack = true;
 pattack_ = value;
 }

public const int mattackFieldNumber = 13;
 private bool hasMattack;
 private Int32 mattack_ = 0;
 public bool HasMattack {
 get { return hasMattack; }
 }
 public Int32 Mattack {
 get { return mattack_; }
 set { SetMattack(value); }
 }
 public void SetMattack(Int32 value) { 
 hasMattack = true;
 mattack_ = value;
 }

public const int hitFieldNumber = 14;
 private bool hasHit;
 private Int32 hit_ = 0;
 public bool HasHit {
 get { return hasHit; }
 }
 public Int32 Hit {
 get { return hit_; }
 set { SetHit(value); }
 }
 public void SetHit(Int32 value) { 
 hasHit = true;
 hit_ = value;
 }

public const int criticalFieldNumber = 15;
 private bool hasCritical;
 private Int32 critical_ = 0;
 public bool HasCritical {
 get { return hasCritical; }
 }
 public Int32 Critical {
 get { return critical_; }
 set { SetCritical(value); }
 }
 public void SetCritical(Int32 value) { 
 hasCritical = true;
 critical_ = value;
 }

public const int pdefenseFieldNumber = 16;
 private bool hasPdefense;
 private Int32 pdefense_ = 0;
 public bool HasPdefense {
 get { return hasPdefense; }
 }
 public Int32 Pdefense {
 get { return pdefense_; }
 set { SetPdefense(value); }
 }
 public void SetPdefense(Int32 value) { 
 hasPdefense = true;
 pdefense_ = value;
 }

public const int mdefenseFieldNumber = 17;
 private bool hasMdefense;
 private Int32 mdefense_ = 0;
 public bool HasMdefense {
 get { return hasMdefense; }
 }
 public Int32 Mdefense {
 get { return mdefense_; }
 set { SetMdefense(value); }
 }
 public void SetMdefense(Int32 value) { 
 hasMdefense = true;
 mdefense_ = value;
 }

public const int decriticalFieldNumber = 18;
 private bool hasDecritical;
 private Int32 decritical_ = 0;
 public bool HasDecritical {
 get { return hasDecritical; }
 }
 public Int32 Decritical {
 get { return decritical_; }
 set { SetDecritical(value); }
 }
 public void SetDecritical(Int32 value) { 
 hasDecritical = true;
 decritical_ = value;
 }

public const int dogeFieldNumber = 19;
 private bool hasDoge;
 private Int32 doge_ = 0;
 public bool HasDoge {
 get { return hasDoge; }
 }
 public Int32 Doge {
 get { return doge_; }
 set { SetDoge(value); }
 }
 public void SetDoge(Int32 value) { 
 hasDoge = true;
 doge_ = value;
 }

public const int strikeFieldNumber = 20;
 private bool hasStrike;
 private Int32 strike_ = 0;
 public bool HasStrike {
 get { return hasStrike; }
 }
 public Int32 Strike {
 get { return strike_; }
 set { SetStrike(value); }
 }
 public void SetStrike(Int32 value) { 
 hasStrike = true;
 strike_ = value;
 }

public const int criticaladdFieldNumber = 21;
 private bool hasCriticaladd;
 private Int32 criticaladd_ = 0;
 public bool HasCriticaladd {
 get { return hasCriticaladd; }
 }
 public Int32 Criticaladd {
 get { return criticaladd_; }
 set { SetCriticaladd(value); }
 }
 public void SetCriticaladd(Int32 value) { 
 hasCriticaladd = true;
 criticaladd_ = value;
 }

public const int duticalFieldNumber = 22;
 private bool hasDutical;
 private Int32 dutical_ = 0;
 public bool HasDutical {
 get { return hasDutical; }
 }
 public Int32 Dutical {
 get { return dutical_; }
 set { SetDutical(value); }
 }
 public void SetDutical(Int32 value) { 
 hasDutical = true;
 dutical_ = value;
 }

public const int criticalmisFieldNumber = 23;
 private bool hasCriticalmis;
 private Int32 criticalmis_ = 0;
 public bool HasCriticalmis {
 get { return hasCriticalmis; }
 }
 public Int32 Criticalmis {
 get { return criticalmis_; }
 set { SetCriticalmis(value); }
 }
 public void SetCriticalmis(Int32 value) { 
 hasCriticalmis = true;
 criticalmis_ = value;
 }

public const int curofflineexpFieldNumber = 24;
 private bool hasCurofflineexp;
 private Int32 curofflineexp_ = 0;
 public bool HasCurofflineexp {
 get { return hasCurofflineexp; }
 }
 public Int32 Curofflineexp {
 get { return curofflineexp_; }
 set { SetCurofflineexp(value); }
 }
 public void SetCurofflineexp(Int32 value) { 
 hasCurofflineexp = true;
 curofflineexp_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRolename) {
size += pb::CodedOutputStream.ComputeStringSize(1, Rolename);
}
 if (HasCombatvalue) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Combatvalue);
}
 if (HasLeve) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Leve);
}
 if (HasProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Profession);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(5, Guid);
}
 if (HasCurhp) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Curhp);
}
 if (HasMaxhp) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Maxhp);
}
 if (HasCurmp) {
size += pb::CodedOutputStream.ComputeInt32Size(8, Curmp);
}
 if (HasMaxmp) {
size += pb::CodedOutputStream.ComputeInt32Size(9, Maxmp);
}
 if (HasCurexp) {
size += pb::CodedOutputStream.ComputeInt32Size(10, Curexp);
}
 if (HasMaxexp) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Maxexp);
}
 if (HasPattack) {
size += pb::CodedOutputStream.ComputeInt32Size(12, Pattack);
}
 if (HasMattack) {
size += pb::CodedOutputStream.ComputeInt32Size(13, Mattack);
}
 if (HasHit) {
size += pb::CodedOutputStream.ComputeInt32Size(14, Hit);
}
 if (HasCritical) {
size += pb::CodedOutputStream.ComputeInt32Size(15, Critical);
}
 if (HasPdefense) {
size += pb::CodedOutputStream.ComputeInt32Size(16, Pdefense);
}
 if (HasMdefense) {
size += pb::CodedOutputStream.ComputeInt32Size(17, Mdefense);
}
 if (HasDecritical) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Decritical);
}
 if (HasDoge) {
size += pb::CodedOutputStream.ComputeInt32Size(19, Doge);
}
 if (HasStrike) {
size += pb::CodedOutputStream.ComputeInt32Size(20, Strike);
}
 if (HasCriticaladd) {
size += pb::CodedOutputStream.ComputeInt32Size(21, Criticaladd);
}
 if (HasDutical) {
size += pb::CodedOutputStream.ComputeInt32Size(22, Dutical);
}
 if (HasCriticalmis) {
size += pb::CodedOutputStream.ComputeInt32Size(23, Criticalmis);
}
 if (HasCurofflineexp) {
size += pb::CodedOutputStream.ComputeInt32Size(24, Curofflineexp);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRolename) {
output.WriteString(1, Rolename);
}
 
if (HasCombatvalue) {
output.WriteInt32(2, Combatvalue);
}
 
if (HasLeve) {
output.WriteInt32(3, Leve);
}
 
if (HasProfession) {
output.WriteInt32(4, Profession);
}
 
if (HasGuid) {
output.WriteUInt64(5, Guid);
}
 
if (HasCurhp) {
output.WriteInt32(6, Curhp);
}
 
if (HasMaxhp) {
output.WriteInt32(7, Maxhp);
}
 
if (HasCurmp) {
output.WriteInt32(8, Curmp);
}
 
if (HasMaxmp) {
output.WriteInt32(9, Maxmp);
}
 
if (HasCurexp) {
output.WriteInt32(10, Curexp);
}
 
if (HasMaxexp) {
output.WriteInt32(11, Maxexp);
}
 
if (HasPattack) {
output.WriteInt32(12, Pattack);
}
 
if (HasMattack) {
output.WriteInt32(13, Mattack);
}
 
if (HasHit) {
output.WriteInt32(14, Hit);
}
 
if (HasCritical) {
output.WriteInt32(15, Critical);
}
 
if (HasPdefense) {
output.WriteInt32(16, Pdefense);
}
 
if (HasMdefense) {
output.WriteInt32(17, Mdefense);
}
 
if (HasDecritical) {
output.WriteInt32(18, Decritical);
}
 
if (HasDoge) {
output.WriteInt32(19, Doge);
}
 
if (HasStrike) {
output.WriteInt32(20, Strike);
}
 
if (HasCriticaladd) {
output.WriteInt32(21, Criticaladd);
}
 
if (HasDutical) {
output.WriteInt32(22, Dutical);
}
 
if (HasCriticalmis) {
output.WriteInt32(23, Criticalmis);
}
 
if (HasCurofflineexp) {
output.WriteInt32(24, Curofflineexp);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_ROLE_DATA _inst = (GC_RET_ROLE_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.Rolename = input.ReadString();
break;
}
   case  16: {
 _inst.Combatvalue = input.ReadInt32();
break;
}
   case  24: {
 _inst.Leve = input.ReadInt32();
break;
}
   case  32: {
 _inst.Profession = input.ReadInt32();
break;
}
   case  40: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  48: {
 _inst.Curhp = input.ReadInt32();
break;
}
   case  56: {
 _inst.Maxhp = input.ReadInt32();
break;
}
   case  64: {
 _inst.Curmp = input.ReadInt32();
break;
}
   case  72: {
 _inst.Maxmp = input.ReadInt32();
break;
}
   case  80: {
 _inst.Curexp = input.ReadInt32();
break;
}
   case  88: {
 _inst.Maxexp = input.ReadInt32();
break;
}
   case  96: {
 _inst.Pattack = input.ReadInt32();
break;
}
   case  104: {
 _inst.Mattack = input.ReadInt32();
break;
}
   case  112: {
 _inst.Hit = input.ReadInt32();
break;
}
   case  120: {
 _inst.Critical = input.ReadInt32();
break;
}
   case  128: {
 _inst.Pdefense = input.ReadInt32();
break;
}
   case  136: {
 _inst.Mdefense = input.ReadInt32();
break;
}
   case  144: {
 _inst.Decritical = input.ReadInt32();
break;
}
   case  152: {
 _inst.Doge = input.ReadInt32();
break;
}
   case  160: {
 _inst.Strike = input.ReadInt32();
break;
}
   case  168: {
 _inst.Criticaladd = input.ReadInt32();
break;
}
   case  176: {
 _inst.Dutical = input.ReadInt32();
break;
}
   case  184: {
 _inst.Criticalmis = input.ReadInt32();
break;
}
   case  192: {
 _inst.Curofflineexp = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRolename) return false;
 if (!hasCombatvalue) return false;
 if (!hasLeve) return false;
 if (!hasProfession) return false;
 if (!hasGuid) return false;
 if (!hasCurhp) return false;
 if (!hasMaxhp) return false;
 if (!hasCurmp) return false;
 if (!hasMaxmp) return false;
 if (!hasCurexp) return false;
 if (!hasMaxexp) return false;
 if (!hasPattack) return false;
 if (!hasMattack) return false;
 if (!hasHit) return false;
 if (!hasCritical) return false;
 if (!hasPdefense) return false;
 if (!hasMdefense) return false;
 if (!hasDecritical) return false;
 if (!hasDoge) return false;
 if (!hasStrike) return false;
 if (!hasCriticaladd) return false;
 if (!hasDutical) return false;
 if (!hasCriticalmis) return false;
 if (!hasCurofflineexp) return false;
 return true;
 }

}


[Serializable]
public class CG_CALL_FELLOW : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CALL_FELLOW _inst = (CG_CALL_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_CALL_FELLOW_RET : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

public const int objidFieldNumber = 2;
 private bool hasObjid;
 private Int32 objid_ = 0;
 public bool HasObjid {
 get { return hasObjid; }
 }
 public Int32 Objid {
 get { return objid_; }
 set { SetObjid(value); }
 }
 public void SetObjid(Int32 value) { 
 hasObjid = true;
 objid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 if (HasObjid) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Objid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 
if (HasObjid) {
output.WriteInt32(2, Objid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CALL_FELLOW_RET _inst = (GC_CALL_FELLOW_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.Objid = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 if (!hasObjid) return false;
 return true;
 }

}


[Serializable]
public class CG_UNCALL_FELLOW : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_UNCALL_FELLOW _inst = (CG_UNCALL_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_UNCALL_FELLOW_RET : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UNCALL_FELLOW_RET _inst = (GC_UNCALL_FELLOW_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_NEWSERVERAWARD : PacketDistributed
{

public const int dayFieldNumber = 1;
 private bool hasDay;
 private Int32 day_ = 0;
 public bool HasDay {
 get { return hasDay; }
 }
 public Int32 Day {
 get { return day_; }
 set { SetDay(value); }
 }
 public void SetDay(Int32 value) { 
 hasDay = true;
 day_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasDay) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Day);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasDay) {
output.WriteInt32(1, Day);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_NEWSERVERAWARD _inst = (CG_ASK_NEWSERVERAWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Day = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasDay) return false;
 return true;
 }

}


[Serializable]
public class GC_NEWSERVERAWARD_DATA : PacketDistributed
{

public const int dayFieldNumber = 1;
 private bool hasDay;
 private Int32 day_ = 0;
 public bool HasDay {
 get { return hasDay; }
 }
 public Int32 Day {
 get { return day_; }
 set { SetDay(value); }
 }
 public void SetDay(Int32 value) { 
 hasDay = true;
 day_ = value;
 }

public const int flagFieldNumber = 2;
 private pbc::PopsicleList<Int32> flag_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> flagList {
 get { return pbc::Lists.AsReadOnly(flag_); }
 }
 
 public int flagCount {
 get { return flag_.Count; }
 }
 
public Int32 GetFlag(int index) {
 return flag_[index];
 }
 public void AddFlag(Int32 value) {
 flag_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasDay) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Day);
}
{
int dataSize = 0;
for(int i=0; i<flagList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(flagList[i]);
}
size += dataSize;
size += 1 * flag_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasDay) {
output.WriteInt32(1, Day);
}
{
if (flag_.Count > 0) {
for(int i=0; i<flag_.Count; ++i){
output.WriteInt32(2,flag_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_NEWSERVERAWARD_DATA _inst = (GC_NEWSERVERAWARD_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Day = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddFlag(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasDay) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_DAYAWARD : PacketDistributed
{

public const int weekDayFieldNumber = 1;
 private bool hasWeekDay;
 private Int32 weekDay_ = 0;
 public bool HasWeekDay {
 get { return hasWeekDay; }
 }
 public Int32 WeekDay {
 get { return weekDay_; }
 set { SetWeekDay(value); }
 }
 public void SetWeekDay(Int32 value) { 
 hasWeekDay = true;
 weekDay_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasWeekDay) {
size += pb::CodedOutputStream.ComputeInt32Size(1, WeekDay);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasWeekDay) {
output.WriteInt32(1, WeekDay);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_DAYAWARD _inst = (CG_ASK_DAYAWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.WeekDay = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasWeekDay) return false;
 return true;
 }

}


[Serializable]
public class GC_DAYAWARD_DATA : PacketDistributed
{

public const int weekDayFieldNumber = 1;
 private bool hasWeekDay;
 private Int32 weekDay_ = 0;
 public bool HasWeekDay {
 get { return hasWeekDay; }
 }
 public Int32 WeekDay {
 get { return weekDay_; }
 set { SetWeekDay(value); }
 }
 public void SetWeekDay(Int32 value) { 
 hasWeekDay = true;
 weekDay_ = value;
 }

public const int flagFieldNumber = 2;
 private bool hasFlag;
 private Int32 flag_ = 0;
 public bool HasFlag {
 get { return hasFlag; }
 }
 public Int32 Flag {
 get { return flag_; }
 set { SetFlag(value); }
 }
 public void SetFlag(Int32 value) { 
 hasFlag = true;
 flag_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasWeekDay) {
size += pb::CodedOutputStream.ComputeInt32Size(1, WeekDay);
}
 if (HasFlag) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Flag);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasWeekDay) {
output.WriteInt32(1, WeekDay);
}
 
if (HasFlag) {
output.WriteInt32(2, Flag);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DAYAWARD_DATA _inst = (GC_DAYAWARD_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.WeekDay = input.ReadInt32();
break;
}
   case  16: {
 _inst.Flag = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasWeekDay) return false;
 if (!hasFlag) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_ONLINEAWARD : PacketDistributed
{

public const int OnlineAwardIDFieldNumber = 1;
 private bool hasOnlineAwardID;
 private Int32 OnlineAwardID_ = 0;
 public bool HasOnlineAwardID {
 get { return hasOnlineAwardID; }
 }
 public Int32 OnlineAwardID {
 get { return OnlineAwardID_; }
 set { SetOnlineAwardID(value); }
 }
 public void SetOnlineAwardID(Int32 value) { 
 hasOnlineAwardID = true;
 OnlineAwardID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasOnlineAwardID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, OnlineAwardID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasOnlineAwardID) {
output.WriteInt32(1, OnlineAwardID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_ONLINEAWARD _inst = (CG_ASK_ONLINEAWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.OnlineAwardID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasOnlineAwardID) return false;
 return true;
 }

}


[Serializable]
public class GC_ONLINEAWARD_DATA : PacketDistributed
{

public const int OnlineAwardIDFieldNumber = 1;
 private bool hasOnlineAwardID;
 private Int32 OnlineAwardID_ = 0;
 public bool HasOnlineAwardID {
 get { return hasOnlineAwardID; }
 }
 public Int32 OnlineAwardID {
 get { return OnlineAwardID_; }
 set { SetOnlineAwardID(value); }
 }
 public void SetOnlineAwardID(Int32 value) { 
 hasOnlineAwardID = true;
 OnlineAwardID_ = value;
 }

public const int leftTimeFieldNumber = 2;
 private bool hasLeftTime;
 private Int32 leftTime_ = 0;
 public bool HasLeftTime {
 get { return hasLeftTime; }
 }
 public Int32 LeftTime {
 get { return leftTime_; }
 set { SetLeftTime(value); }
 }
 public void SetLeftTime(Int32 value) { 
 hasLeftTime = true;
 leftTime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasOnlineAwardID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, OnlineAwardID);
}
 if (HasLeftTime) {
size += pb::CodedOutputStream.ComputeInt32Size(2, LeftTime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasOnlineAwardID) {
output.WriteInt32(1, OnlineAwardID);
}
 
if (HasLeftTime) {
output.WriteInt32(2, LeftTime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ONLINEAWARD_DATA _inst = (GC_ONLINEAWARD_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.OnlineAwardID = input.ReadInt32();
break;
}
   case  16: {
 _inst.LeftTime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasOnlineAwardID) return false;
 if (!hasLeftTime) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_ACTIVENESSAWARD : PacketDistributed
{

public const int turnidFieldNumber = 1;
 private bool hasTurnid;
 private Int32 turnid_ = 0;
 public bool HasTurnid {
 get { return hasTurnid; }
 }
 public Int32 Turnid {
 get { return turnid_; }
 set { SetTurnid(value); }
 }
 public void SetTurnid(Int32 value) { 
 hasTurnid = true;
 turnid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTurnid) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Turnid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTurnid) {
output.WriteInt32(1, Turnid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_ACTIVENESSAWARD _inst = (CG_ASK_ACTIVENESSAWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Turnid = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTurnid) return false;
 return true;
 }

}


[Serializable]
public class GC_ASK_ACTIVENESSAWARD_RET : PacketDistributed
{

public const int turnidFieldNumber = 1;
 private bool hasTurnid;
 private Int32 turnid_ = 0;
 public bool HasTurnid {
 get { return hasTurnid; }
 }
 public Int32 Turnid {
 get { return turnid_; }
 set { SetTurnid(value); }
 }
 public void SetTurnid(Int32 value) { 
 hasTurnid = true;
 turnid_ = value;
 }

public const int flagFieldNumber = 2;
 private bool hasFlag;
 private Int32 flag_ = 0;
 public bool HasFlag {
 get { return hasFlag; }
 }
 public Int32 Flag {
 get { return flag_; }
 set { SetFlag(value); }
 }
 public void SetFlag(Int32 value) { 
 hasFlag = true;
 flag_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTurnid) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Turnid);
}
 if (HasFlag) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Flag);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTurnid) {
output.WriteInt32(1, Turnid);
}
 
if (HasFlag) {
output.WriteInt32(2, Flag);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ASK_ACTIVENESSAWARD_RET _inst = (GC_ASK_ACTIVENESSAWARD_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Turnid = input.ReadInt32();
break;
}
   case  16: {
 _inst.Flag = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTurnid) return false;
 if (!hasFlag) return false;
 return true;
 }

}


[Serializable]
public class GC_SYNC_ACTIVENESSAWARD : PacketDistributed
{

public const int flagFieldNumber = 1;
 private pbc::PopsicleList<Int32> flag_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> flagList {
 get { return pbc::Lists.AsReadOnly(flag_); }
 }
 
 public int flagCount {
 get { return flag_.Count; }
 }
 
public Int32 GetFlag(int index) {
 return flag_[index];
 }
 public void AddFlag(Int32 value) {
 flag_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<flagList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(flagList[i]);
}
size += dataSize;
size += 1 * flag_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (flag_.Count > 0) {
for(int i=0; i<flag_.Count; ++i){
output.WriteInt32(1,flag_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_ACTIVENESSAWARD _inst = (GC_SYNC_ACTIVENESSAWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddFlag(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_DAMAGEBOARD_INFO : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int typeFieldNumber = 2;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int valueFieldNumber = 3;
 private bool hasValue;
 private Int32 value_ = 0;
 public bool HasValue {
 get { return hasValue; }
 }
 public Int32 Value {
 get { return value_; }
 set { SetValue(value); }
 }
 public void SetValue(Int32 value) { 
 hasValue = true;
 value_ = value;
 }

public const int showtimesFieldNumber = 4;
 private bool hasShowtimes;
 private Int32 showtimes_ = 0;
 public bool HasShowtimes {
 get { return hasShowtimes; }
 }
 public Int32 Showtimes {
 get { return showtimes_; }
 set { SetShowtimes(value); }
 }
 public void SetShowtimes(Int32 value) { 
 hasShowtimes = true;
 showtimes_ = value;
 }

public const int showinterFieldNumber = 5;
 private bool hasShowinter;
 private Int32 showinter_ = 0;
 public bool HasShowinter {
 get { return hasShowinter; }
 }
 public Int32 Showinter {
 get { return showinter_; }
 set { SetShowinter(value); }
 }
 public void SetShowinter(Int32 value) { 
 hasShowinter = true;
 showinter_ = value;
 }

public const int addanimstateFieldNumber = 6;
 private bool hasAddanimstate;
 private Int32 addanimstate_ = 0;
 public bool HasAddanimstate {
 get { return hasAddanimstate; }
 }
 public Int32 Addanimstate {
 get { return addanimstate_; }
 set { SetAddanimstate(value); }
 }
 public void SetAddanimstate(Int32 value) { 
 hasAddanimstate = true;
 addanimstate_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Type);
}
 if (HasValue) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Value);
}
 if (HasShowtimes) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Showtimes);
}
 if (HasShowinter) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Showinter);
}
 if (HasAddanimstate) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Addanimstate);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasType) {
output.WriteInt32(2, Type);
}
 
if (HasValue) {
output.WriteInt32(3, Value);
}
 
if (HasShowtimes) {
output.WriteInt32(4, Showtimes);
}
 
if (HasShowinter) {
output.WriteInt32(5, Showinter);
}
 
if (HasAddanimstate) {
output.WriteInt32(6, Addanimstate);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DAMAGEBOARD_INFO _inst = (GC_DAMAGEBOARD_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.Type = input.ReadInt32();
break;
}
   case  24: {
 _inst.Value = input.ReadInt32();
break;
}
   case  32: {
 _inst.Showtimes = input.ReadInt32();
break;
}
   case  40: {
 _inst.Showinter = input.ReadInt32();
break;
}
   case  48: {
 _inst.Addanimstate = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasType) return false;
 if (!hasValue) return false;
 return true;
 }

}


[Serializable]
public class CG_OPEN_COPYSCENE : PacketDistributed
{

public const int SceneIDFieldNumber = 1;
 private bool hasSceneID;
 private Int32 SceneID_ = 0;
 public bool HasSceneID {
 get { return hasSceneID; }
 }
 public Int32 SceneID {
 get { return SceneID_; }
 set { SetSceneID(value); }
 }
 public void SetSceneID(Int32 value) { 
 hasSceneID = true;
 SceneID_ = value;
 }

public const int TypeFieldNumber = 2;
 private bool hasType;
 private Int32 Type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return Type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 Type_ = value;
 }

public const int DifficultFieldNumber = 3;
 private bool hasDifficult;
 private Int32 Difficult_ = 0;
 public bool HasDifficult {
 get { return hasDifficult; }
 }
 public Int32 Difficult {
 get { return Difficult_; }
 set { SetDifficult(value); }
 }
 public void SetDifficult(Int32 value) { 
 hasDifficult = true;
 Difficult_ = value;
 }

public const int EnterTypeFieldNumber = 4;
 private bool hasEnterType;
 private Int32 EnterType_ = 0;
 public bool HasEnterType {
 get { return hasEnterType; }
 }
 public Int32 EnterType {
 get { return EnterType_; }
 set { SetEnterType(value); }
 }
 public void SetEnterType(Int32 value) { 
 hasEnterType = true;
 EnterType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SceneID);
}
 if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Type);
}
 if (HasDifficult) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Difficult);
}
 if (HasEnterType) {
size += pb::CodedOutputStream.ComputeInt32Size(4, EnterType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneID) {
output.WriteInt32(1, SceneID);
}
 
if (HasType) {
output.WriteInt32(2, Type);
}
 
if (HasDifficult) {
output.WriteInt32(3, Difficult);
}
 
if (HasEnterType) {
output.WriteInt32(4, EnterType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_OPEN_COPYSCENE _inst = (CG_OPEN_COPYSCENE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SceneID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Type = input.ReadInt32();
break;
}
   case  24: {
 _inst.Difficult = input.ReadInt32();
break;
}
   case  32: {
 _inst.EnterType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneID) return false;
 if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class GC_COPYSCENE_INVITE : PacketDistributed
{

public const int SceneIDFieldNumber = 1;
 private bool hasSceneID;
 private Int32 SceneID_ = 0;
 public bool HasSceneID {
 get { return hasSceneID; }
 }
 public Int32 SceneID {
 get { return SceneID_; }
 set { SetSceneID(value); }
 }
 public void SetSceneID(Int32 value) { 
 hasSceneID = true;
 SceneID_ = value;
 }

public const int InviterNameFieldNumber = 2;
 private bool hasInviterName;
 private string InviterName_ = "";
 public bool HasInviterName {
 get { return hasInviterName; }
 }
 public string InviterName {
 get { return InviterName_; }
 set { SetInviterName(value); }
 }
 public void SetInviterName(string value) { 
 hasInviterName = true;
 InviterName_ = value;
 }

public const int DifficultFieldNumber = 3;
 private bool hasDifficult;
 private Int32 Difficult_ = 0;
 public bool HasDifficult {
 get { return hasDifficult; }
 }
 public Int32 Difficult {
 get { return Difficult_; }
 set { SetDifficult(value); }
 }
 public void SetDifficult(Int32 value) { 
 hasDifficult = true;
 Difficult_ = value;
 }

public const int MultipleTypeFieldNumber = 4;
 private bool hasMultipleType;
 private Int32 MultipleType_ = 0;
 public bool HasMultipleType {
 get { return hasMultipleType; }
 }
 public Int32 MultipleType {
 get { return MultipleType_; }
 set { SetMultipleType(value); }
 }
 public void SetMultipleType(Int32 value) { 
 hasMultipleType = true;
 MultipleType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SceneID);
}
 if (HasInviterName) {
size += pb::CodedOutputStream.ComputeStringSize(2, InviterName);
}
 if (HasDifficult) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Difficult);
}
 if (HasMultipleType) {
size += pb::CodedOutputStream.ComputeInt32Size(4, MultipleType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneID) {
output.WriteInt32(1, SceneID);
}
 
if (HasInviterName) {
output.WriteString(2, InviterName);
}
 
if (HasDifficult) {
output.WriteInt32(3, Difficult);
}
 
if (HasMultipleType) {
output.WriteInt32(4, MultipleType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_COPYSCENE_INVITE _inst = (GC_COPYSCENE_INVITE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SceneID = input.ReadInt32();
break;
}
   case  18: {
 _inst.InviterName = input.ReadString();
break;
}
   case  24: {
 _inst.Difficult = input.ReadInt32();
break;
}
   case  32: {
 _inst.MultipleType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneID) return false;
 if (!hasInviterName) return false;
 if (!hasDifficult) return false;
 return true;
 }

}


[Serializable]
public class CG_COPYSCENE_INVITE_RET : PacketDistributed
{

public const int SceneIDFieldNumber = 1;
 private bool hasSceneID;
 private Int32 SceneID_ = 0;
 public bool HasSceneID {
 get { return hasSceneID; }
 }
 public Int32 SceneID {
 get { return SceneID_; }
 set { SetSceneID(value); }
 }
 public void SetSceneID(Int32 value) { 
 hasSceneID = true;
 SceneID_ = value;
 }
public enum InviteResultType 
 { 
  RESULTTYPE_WAIT      = 1,  // �Ժ�ش� 
  RESULTTYPE_YES      = 2,  // �������� 
  RESULTTYPE_NO       = 3,  // �ܾ����� 
 }
public const int InviteResultFieldNumber = 2;
 private bool hasInviteResult;
 private Int32 InviteResult_ = 0;
 public bool HasInviteResult {
 get { return hasInviteResult; }
 }
 public Int32 InviteResult {
 get { return InviteResult_; }
 set { SetInviteResult(value); }
 }
 public void SetInviteResult(Int32 value) { 
 hasInviteResult = true;
 InviteResult_ = value;
 }

public const int DifficultFieldNumber = 3;
 private bool hasDifficult;
 private Int32 Difficult_ = 0;
 public bool HasDifficult {
 get { return hasDifficult; }
 }
 public Int32 Difficult {
 get { return Difficult_; }
 set { SetDifficult(value); }
 }
 public void SetDifficult(Int32 value) { 
 hasDifficult = true;
 Difficult_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SceneID);
}
 if (HasInviteResult) {
size += pb::CodedOutputStream.ComputeInt32Size(2, InviteResult);
}
 if (HasDifficult) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Difficult);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneID) {
output.WriteInt32(1, SceneID);
}
 
if (HasInviteResult) {
output.WriteInt32(2, InviteResult);
}
 
if (HasDifficult) {
output.WriteInt32(3, Difficult);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_COPYSCENE_INVITE_RET _inst = (CG_COPYSCENE_INVITE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SceneID = input.ReadInt32();
break;
}
   case  16: {
 _inst.InviteResult = input.ReadInt32();
break;
}
   case  24: {
 _inst.Difficult = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneID) return false;
 if (!hasInviteResult) return false;
 if (!hasDifficult) return false;
 return true;
 }

}


[Serializable]
public class GC_COPYSCENE_RESULT : PacketDistributed
{
public enum CopySceneResult 
 { 
  RESULT_LOSE      = 0,  // ʧ�� 
  RESULT_WIN      = 1,  // �ɹ� 
  RESULT_DRAW      = 2,  // ƽ�� 
 }
public const int ResultFieldNumber = 1;
 private bool hasResult;
 private Int32 Result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return Result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 Result_ = value;
 }

public const int SceneIDFieldNumber = 2;
 private bool hasSceneID;
 private Int32 SceneID_ = 0;
 public bool HasSceneID {
 get { return hasSceneID; }
 }
 public Int32 SceneID {
 get { return SceneID_; }
 set { SetSceneID(value); }
 }
 public void SetSceneID(Int32 value) { 
 hasSceneID = true;
 SceneID_ = value;
 }

public const int IsSoloFieldNumber = 3;
 private bool hasIsSolo;
 private Int32 IsSolo_ = 0;
 public bool HasIsSolo {
 get { return hasIsSolo; }
 }
 public Int32 IsSolo {
 get { return IsSolo_; }
 set { SetIsSolo(value); }
 }
 public void SetIsSolo(Int32 value) { 
 hasIsSolo = true;
 IsSolo_ = value;
 }

public const int DifficultFieldNumber = 4;
 private bool hasDifficult;
 private Int32 Difficult_ = 0;
 public bool HasDifficult {
 get { return hasDifficult; }
 }
 public Int32 Difficult {
 get { return Difficult_; }
 set { SetDifficult(value); }
 }
 public void SetDifficult(Int32 value) { 
 hasDifficult = true;
 Difficult_ = value;
 }

public const int StarFieldNumber = 5;
 private bool hasStar;
 private Int32 Star_ = 0;
 public bool HasStar {
 get { return hasStar; }
 }
 public Int32 Star {
 get { return Star_; }
 set { SetStar(value); }
 }
 public void SetStar(Int32 value) { 
 hasStar = true;
 Star_ = value;
 }

public const int ScoreFieldNumber = 6;
 private bool hasScore;
 private Int32 Score_ = 0;
 public bool HasScore {
 get { return hasScore; }
 }
 public Int32 Score {
 get { return Score_; }
 set { SetScore(value); }
 }
 public void SetScore(Int32 value) { 
 hasScore = true;
 Score_ = value;
 }

public const int CaromFieldNumber = 7;
 private bool hasCarom;
 private Int32 Carom_ = 0;
 public bool HasCarom {
 get { return hasCarom; }
 }
 public Int32 Carom {
 get { return Carom_; }
 set { SetCarom(value); }
 }
 public void SetCarom(Int32 value) { 
 hasCarom = true;
 Carom_ = value;
 }

public const int TimeFieldNumber = 8;
 private bool hasTime;
 private Int32 Time_ = 0;
 public bool HasTime {
 get { return hasTime; }
 }
 public Int32 Time {
 get { return Time_; }
 set { SetTime(value); }
 }
 public void SetTime(Int32 value) { 
 hasTime = true;
 Time_ = value;
 }

public const int ExpFieldNumber = 9;
 private bool hasExp;
 private Int32 Exp_ = 0;
 public bool HasExp {
 get { return hasExp; }
 }
 public Int32 Exp {
 get { return Exp_; }
 set { SetExp(value); }
 }
 public void SetExp(Int32 value) { 
 hasExp = true;
 Exp_ = value;
 }

public const int VipExpFieldNumber = 10;
 private bool hasVipExp;
 private Int32 VipExp_ = 0;
 public bool HasVipExp {
 get { return hasVipExp; }
 }
 public Int32 VipExp {
 get { return VipExp_; }
 set { SetVipExp(value); }
 }
 public void SetVipExp(Int32 value) { 
 hasVipExp = true;
 VipExp_ = value;
 }

public const int MoneyFieldNumber = 11;
 private bool hasMoney;
 private Int32 Money_ = 0;
 public bool HasMoney {
 get { return hasMoney; }
 }
 public Int32 Money {
 get { return Money_; }
 set { SetMoney(value); }
 }
 public void SetMoney(Int32 value) { 
 hasMoney = true;
 Money_ = value;
 }

public const int RewardTypeFieldNumber = 12;
 private pbc::PopsicleList<Int32> RewardType_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> RewardTypeList {
 get { return pbc::Lists.AsReadOnly(RewardType_); }
 }
 
 public int RewardTypeCount {
 get { return RewardType_.Count; }
 }
 
public Int32 GetRewardType(int index) {
 return RewardType_[index];
 }
 public void AddRewardType(Int32 value) {
 RewardType_.Add(value);
 }

public const int RewardItemIdFieldNumber = 13;
 private pbc::PopsicleList<Int32> RewardItemId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> RewardItemIdList {
 get { return pbc::Lists.AsReadOnly(RewardItemId_); }
 }
 
 public int RewardItemIdCount {
 get { return RewardItemId_.Count; }
 }
 
public Int32 GetRewardItemId(int index) {
 return RewardItemId_[index];
 }
 public void AddRewardItemId(Int32 value) {
 RewardItemId_.Add(value);
 }

public const int RewardCountFieldNumber = 14;
 private pbc::PopsicleList<Int32> RewardCount_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> RewardCountList {
 get { return pbc::Lists.AsReadOnly(RewardCount_); }
 }
 
 public int RewardCountCount {
 get { return RewardCount_.Count; }
 }
 
public Int32 GetRewardCount(int index) {
 return RewardCount_[index];
 }
 public void AddRewardCount(Int32 value) {
 RewardCount_.Add(value);
 }

public const int DrawTypeFieldNumber = 15;
 private pbc::PopsicleList<Int32> DrawType_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> DrawTypeList {
 get { return pbc::Lists.AsReadOnly(DrawType_); }
 }
 
 public int DrawTypeCount {
 get { return DrawType_.Count; }
 }
 
public Int32 GetDrawType(int index) {
 return DrawType_[index];
 }
 public void AddDrawType(Int32 value) {
 DrawType_.Add(value);
 }

public const int DrawItemIdFieldNumber = 16;
 private pbc::PopsicleList<Int32> DrawItemId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> DrawItemIdList {
 get { return pbc::Lists.AsReadOnly(DrawItemId_); }
 }
 
 public int DrawItemIdCount {
 get { return DrawItemId_.Count; }
 }
 
public Int32 GetDrawItemId(int index) {
 return DrawItemId_[index];
 }
 public void AddDrawItemId(Int32 value) {
 DrawItemId_.Add(value);
 }

public const int DrawCountFieldNumber = 17;
 private pbc::PopsicleList<Int32> DrawCount_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> DrawCountList {
 get { return pbc::Lists.AsReadOnly(DrawCount_); }
 }
 
 public int DrawCountCount {
 get { return DrawCount_.Count; }
 }
 
public Int32 GetDrawCount(int index) {
 return DrawCount_[index];
 }
 public void AddDrawCount(Int32 value) {
 DrawCount_.Add(value);
 }

public const int DrawIndexFieldNumber = 18;
 private bool hasDrawIndex;
 private Int32 DrawIndex_ = 0;
 public bool HasDrawIndex {
 get { return hasDrawIndex; }
 }
 public Int32 DrawIndex {
 get { return DrawIndex_; }
 set { SetDrawIndex(value); }
 }
 public void SetDrawIndex(Int32 value) { 
 hasDrawIndex = true;
 DrawIndex_ = value;
 }

public const int UserInSceneFieldNumber = 19;
 private pbc::PopsicleList<UInt64> UserInScene_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> UserInSceneList {
 get { return pbc::Lists.AsReadOnly(UserInScene_); }
 }
 
 public int UserInSceneCount {
 get { return UserInScene_.Count; }
 }
 
public UInt64 GetUserInScene(int index) {
 return UserInScene_[index];
 }
 public void AddUserInScene(UInt64 value) {
 UserInScene_.Add(value);
 }

public const int DrawIndexTwoFieldNumber = 20;
 private bool hasDrawIndexTwo;
 private Int32 DrawIndexTwo_ = 0;
 public bool HasDrawIndexTwo {
 get { return hasDrawIndexTwo; }
 }
 public Int32 DrawIndexTwo {
 get { return DrawIndexTwo_; }
 set { SetDrawIndexTwo(value); }
 }
 public void SetDrawIndexTwo(Int32 value) { 
 hasDrawIndexTwo = true;
 DrawIndexTwo_ = value;
 }

public const int PetExpFieldNumber = 21;
 private bool hasPetExp;
 private Int32 PetExp_ = 0;
 public bool HasPetExp {
 get { return hasPetExp; }
 }
 public Int32 PetExp {
 get { return PetExp_; }
 set { SetPetExp(value); }
 }
 public void SetPetExp(Int32 value) { 
 hasPetExp = true;
 PetExp_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 if (HasSceneID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SceneID);
}
 if (HasIsSolo) {
size += pb::CodedOutputStream.ComputeInt32Size(3, IsSolo);
}
 if (HasDifficult) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Difficult);
}
 if (HasStar) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Star);
}
 if (HasScore) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Score);
}
 if (HasCarom) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Carom);
}
 if (HasTime) {
size += pb::CodedOutputStream.ComputeInt32Size(8, Time);
}
 if (HasExp) {
size += pb::CodedOutputStream.ComputeInt32Size(9, Exp);
}
 if (HasVipExp) {
size += pb::CodedOutputStream.ComputeInt32Size(10, VipExp);
}
 if (HasMoney) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Money);
}
{
int dataSize = 0;
for(int i=0; i<RewardTypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(RewardTypeList[i]);
}
size += dataSize;
size += 1 * RewardType_.Count;
}
{
int dataSize = 0;
for(int i=0; i<RewardItemIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(RewardItemIdList[i]);
}
size += dataSize;
size += 1 * RewardItemId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<RewardCountList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(RewardCountList[i]);
}
size += dataSize;
size += 1 * RewardCount_.Count;
}
{
int dataSize = 0;
for(int i=0; i<DrawTypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(DrawTypeList[i]);
}
size += dataSize;
size += 1 * DrawType_.Count;
}
{
int dataSize = 0;
for(int i=0; i<DrawItemIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(DrawItemIdList[i]);
}
size += dataSize;
size += 1 * DrawItemId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<DrawCountList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(DrawCountList[i]);
}
size += dataSize;
size += 1 * DrawCount_.Count;
}
 if (HasDrawIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(18, DrawIndex);
}
{
int dataSize = 0;
for(int i=0; i<UserInSceneList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(UserInSceneList[i]);
}
size += dataSize;
size += 1 * UserInScene_.Count;
}
 if (HasDrawIndexTwo) {
size += pb::CodedOutputStream.ComputeInt32Size(20, DrawIndexTwo);
}
 if (HasPetExp) {
size += pb::CodedOutputStream.ComputeInt32Size(21, PetExp);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 
if (HasSceneID) {
output.WriteInt32(2, SceneID);
}
 
if (HasIsSolo) {
output.WriteInt32(3, IsSolo);
}
 
if (HasDifficult) {
output.WriteInt32(4, Difficult);
}
 
if (HasStar) {
output.WriteInt32(5, Star);
}
 
if (HasScore) {
output.WriteInt32(6, Score);
}
 
if (HasCarom) {
output.WriteInt32(7, Carom);
}
 
if (HasTime) {
output.WriteInt32(8, Time);
}
 
if (HasExp) {
output.WriteInt32(9, Exp);
}
 
if (HasVipExp) {
output.WriteInt32(10, VipExp);
}
 
if (HasMoney) {
output.WriteInt32(11, Money);
}
{
if (RewardType_.Count > 0) {
for(int i=0; i<RewardType_.Count; ++i){
output.WriteInt32(12,RewardType_[i]);
}
}

}
{
if (RewardItemId_.Count > 0) {
for(int i=0; i<RewardItemId_.Count; ++i){
output.WriteInt32(13,RewardItemId_[i]);
}
}

}
{
if (RewardCount_.Count > 0) {
for(int i=0; i<RewardCount_.Count; ++i){
output.WriteInt32(14,RewardCount_[i]);
}
}

}
{
if (DrawType_.Count > 0) {
for(int i=0; i<DrawType_.Count; ++i){
output.WriteInt32(15,DrawType_[i]);
}
}

}
{
if (DrawItemId_.Count > 0) {
for(int i=0; i<DrawItemId_.Count; ++i){
output.WriteInt32(16,DrawItemId_[i]);
}
}

}
{
if (DrawCount_.Count > 0) {
for(int i=0; i<DrawCount_.Count; ++i){
output.WriteInt32(17,DrawCount_[i]);
}
}

}
 
if (HasDrawIndex) {
output.WriteInt32(18, DrawIndex);
}
{
if (UserInScene_.Count > 0) {
for(int i=0; i<UserInScene_.Count; ++i){
output.WriteUInt64(19,UserInScene_[i]);
}
}

}
 
if (HasDrawIndexTwo) {
output.WriteInt32(20, DrawIndexTwo);
}
 
if (HasPetExp) {
output.WriteInt32(21, PetExp);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_COPYSCENE_RESULT _inst = (GC_COPYSCENE_RESULT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.SceneID = input.ReadInt32();
break;
}
   case  24: {
 _inst.IsSolo = input.ReadInt32();
break;
}
   case  32: {
 _inst.Difficult = input.ReadInt32();
break;
}
   case  40: {
 _inst.Star = input.ReadInt32();
break;
}
   case  48: {
 _inst.Score = input.ReadInt32();
break;
}
   case  56: {
 _inst.Carom = input.ReadInt32();
break;
}
   case  64: {
 _inst.Time = input.ReadInt32();
break;
}
   case  72: {
 _inst.Exp = input.ReadInt32();
break;
}
   case  80: {
 _inst.VipExp = input.ReadInt32();
break;
}
   case  88: {
 _inst.Money = input.ReadInt32();
break;
}
   case  96: {
 _inst.AddRewardType(input.ReadInt32());
break;
}
   case  104: {
 _inst.AddRewardItemId(input.ReadInt32());
break;
}
   case  112: {
 _inst.AddRewardCount(input.ReadInt32());
break;
}
   case  120: {
 _inst.AddDrawType(input.ReadInt32());
break;
}
   case  128: {
 _inst.AddDrawItemId(input.ReadInt32());
break;
}
   case  136: {
 _inst.AddDrawCount(input.ReadInt32());
break;
}
   case  144: {
 _inst.DrawIndex = input.ReadInt32();
break;
}
   case  152: {
 _inst.AddUserInScene(input.ReadUInt64());
break;
}
   case  160: {
 _inst.DrawIndexTwo = input.ReadInt32();
break;
}
   case  168: {
 _inst.PetExp = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 if (!hasSceneID) return false;
 if (!hasIsSolo) return false;
 if (!hasDifficult) return false;
 if (!hasStar) return false;
 if (!hasScore) return false;
 if (!hasCarom) return false;
 if (!hasTime) return false;
 if (!hasExp) return false;
 if (!hasVipExp) return false;
 if (!hasMoney) return false;
 if (!hasDrawIndex) return false;
 if (!hasDrawIndexTwo) return false;
 if (!hasPetExp) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_COPYSCENE_REWARD : PacketDistributed
{

public const int SceneIDFieldNumber = 1;
 private bool hasSceneID;
 private Int32 SceneID_ = 0;
 public bool HasSceneID {
 get { return hasSceneID; }
 }
 public Int32 SceneID {
 get { return SceneID_; }
 set { SetSceneID(value); }
 }
 public void SetSceneID(Int32 value) { 
 hasSceneID = true;
 SceneID_ = value;
 }

public const int TypeFieldNumber = 2;
 private bool hasType;
 private Int32 Type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return Type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 Type_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SceneID);
}
 if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Type);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneID) {
output.WriteInt32(1, SceneID);
}
 
if (HasType) {
output.WriteInt32(2, Type);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_COPYSCENE_REWARD _inst = (CG_ASK_COPYSCENE_REWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SceneID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Type = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneID) return false;
 if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_COPYSCENE_REWARD : PacketDistributed
{

public const int ResultFieldNumber = 1;
 private bool hasResult;
 private Int32 Result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return Result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 Result_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_COPYSCENE_REWARD _inst = (GC_RET_COPYSCENE_REWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_COPYSCENE_SWEEP : PacketDistributed
{

public const int SceneIDFieldNumber = 1;
 private bool hasSceneID;
 private Int32 SceneID_ = 0;
 public bool HasSceneID {
 get { return hasSceneID; }
 }
 public Int32 SceneID {
 get { return SceneID_; }
 set { SetSceneID(value); }
 }
 public void SetSceneID(Int32 value) { 
 hasSceneID = true;
 SceneID_ = value;
 }

public const int TypeFieldNumber = 2;
 private bool hasType;
 private Int32 Type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return Type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 Type_ = value;
 }

public const int DifficultFieldNumber = 3;
 private bool hasDifficult;
 private Int32 Difficult_ = 0;
 public bool HasDifficult {
 get { return hasDifficult; }
 }
 public Int32 Difficult {
 get { return Difficult_; }
 set { SetDifficult(value); }
 }
 public void SetDifficult(Int32 value) { 
 hasDifficult = true;
 Difficult_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SceneID);
}
 if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Type);
}
 if (HasDifficult) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Difficult);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneID) {
output.WriteInt32(1, SceneID);
}
 
if (HasType) {
output.WriteInt32(2, Type);
}
 
if (HasDifficult) {
output.WriteInt32(3, Difficult);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_COPYSCENE_SWEEP _inst = (CG_ASK_COPYSCENE_SWEEP) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SceneID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Type = input.ReadInt32();
break;
}
   case  24: {
 _inst.Difficult = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneID) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_COPYSCENE_SWEEP : PacketDistributed
{

public const int ResultFieldNumber = 1;
 private bool hasResult;
 private Int32 Result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return Result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 Result_ = value;
 }

public const int SweepTypeFieldNumber = 2;
 private pbc::PopsicleList<Int32> SweepType_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> SweepTypeList {
 get { return pbc::Lists.AsReadOnly(SweepType_); }
 }
 
 public int SweepTypeCount {
 get { return SweepType_.Count; }
 }
 
public Int32 GetSweepType(int index) {
 return SweepType_[index];
 }
 public void AddSweepType(Int32 value) {
 SweepType_.Add(value);
 }

public const int SweepItemIdFieldNumber = 3;
 private pbc::PopsicleList<Int32> SweepItemId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> SweepItemIdList {
 get { return pbc::Lists.AsReadOnly(SweepItemId_); }
 }
 
 public int SweepItemIdCount {
 get { return SweepItemId_.Count; }
 }
 
public Int32 GetSweepItemId(int index) {
 return SweepItemId_[index];
 }
 public void AddSweepItemId(Int32 value) {
 SweepItemId_.Add(value);
 }

public const int SweepCountFieldNumber = 4;
 private pbc::PopsicleList<Int32> SweepCount_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> SweepCountList {
 get { return pbc::Lists.AsReadOnly(SweepCount_); }
 }
 
 public int SweepCountCount {
 get { return SweepCount_.Count; }
 }
 
public Int32 GetSweepCount(int index) {
 return SweepCount_[index];
 }
 public void AddSweepCount(Int32 value) {
 SweepCount_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
{
int dataSize = 0;
for(int i=0; i<SweepTypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(SweepTypeList[i]);
}
size += dataSize;
size += 1 * SweepType_.Count;
}
{
int dataSize = 0;
for(int i=0; i<SweepItemIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(SweepItemIdList[i]);
}
size += dataSize;
size += 1 * SweepItemId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<SweepCountList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(SweepCountList[i]);
}
size += dataSize;
size += 1 * SweepCount_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
{
if (SweepType_.Count > 0) {
for(int i=0; i<SweepType_.Count; ++i){
output.WriteInt32(2,SweepType_[i]);
}
}

}
{
if (SweepItemId_.Count > 0) {
for(int i=0; i<SweepItemId_.Count; ++i){
output.WriteInt32(3,SweepItemId_[i]);
}
}

}
{
if (SweepCount_.Count > 0) {
for(int i=0; i<SweepCount_.Count; ++i){
output.WriteInt32(4,SweepCount_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_COPYSCENE_SWEEP _inst = (GC_RET_COPYSCENE_SWEEP) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddSweepType(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddSweepItemId(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddSweepCount(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 return true;
 }

}


[Serializable]
public class GC_MISSION_IGNOREMISSIONPREFLAG : PacketDistributed
{

public const int flagFieldNumber = 1;
 private bool hasFlag;
 private Int32 flag_ = 0;
 public bool HasFlag {
 get { return hasFlag; }
 }
 public Int32 Flag {
 get { return flag_; }
 set { SetFlag(value); }
 }
 public void SetFlag(Int32 value) { 
 hasFlag = true;
 flag_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFlag) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Flag);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFlag) {
output.WriteInt32(1, Flag);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MISSION_IGNOREMISSIONPREFLAG _inst = (GC_MISSION_IGNOREMISSIONPREFLAG) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Flag = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFlag) return false;
 return true;
 }

}


[Serializable]
public class CG_COMBATVALUE_ASK : PacketDistributed
{

public const int ShowPowerRemindFieldNumber = 1;
 private bool hasShowPowerRemind;
 private Int32 ShowPowerRemind_ = 0;
 public bool HasShowPowerRemind {
 get { return hasShowPowerRemind; }
 }
 public Int32 ShowPowerRemind {
 get { return ShowPowerRemind_; }
 set { SetShowPowerRemind(value); }
 }
 public void SetShowPowerRemind(Int32 value) { 
 hasShowPowerRemind = true;
 ShowPowerRemind_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasShowPowerRemind) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ShowPowerRemind);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasShowPowerRemind) {
output.WriteInt32(1, ShowPowerRemind);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_COMBATVALUE_ASK _inst = (CG_COMBATVALUE_ASK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ShowPowerRemind = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasShowPowerRemind) return false;
 return true;
 }

}


[Serializable]
public class GC_COMBATVALUE_RET : PacketDistributed
{

public const int CombatValueFieldNumber = 1;
 private bool hasCombatValue;
 private Int32 CombatValue_ = 0;
 public bool HasCombatValue {
 get { return hasCombatValue; }
 }
 public Int32 CombatValue {
 get { return CombatValue_; }
 set { SetCombatValue(value); }
 }
 public void SetCombatValue(Int32 value) { 
 hasCombatValue = true;
 CombatValue_ = value;
 }

public const int ShowPowerRemindFieldNumber = 2;
 private bool hasShowPowerRemind;
 private Int32 ShowPowerRemind_ = 0;
 public bool HasShowPowerRemind {
 get { return hasShowPowerRemind; }
 }
 public Int32 ShowPowerRemind {
 get { return ShowPowerRemind_; }
 set { SetShowPowerRemind(value); }
 }
 public void SetShowPowerRemind(Int32 value) { 
 hasShowPowerRemind = true;
 ShowPowerRemind_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCombatValue) {
size += pb::CodedOutputStream.ComputeInt32Size(1, CombatValue);
}
 if (HasShowPowerRemind) {
size += pb::CodedOutputStream.ComputeInt32Size(2, ShowPowerRemind);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCombatValue) {
output.WriteInt32(1, CombatValue);
}
 
if (HasShowPowerRemind) {
output.WriteInt32(2, ShowPowerRemind);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_COMBATVALUE_RET _inst = (GC_COMBATVALUE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.CombatValue = input.ReadInt32();
break;
}
   case  16: {
 _inst.ShowPowerRemind = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCombatValue) return false;
 if (!hasShowPowerRemind) return false;
 return true;
 }

}


[Serializable]
public class GC_PLAY_EFFECT : PacketDistributed
{

public const int ObjIDFieldNumber = 1;
 private bool hasObjID;
 private Int32 ObjID_ = 0;
 public bool HasObjID {
 get { return hasObjID; }
 }
 public Int32 ObjID {
 get { return ObjID_; }
 set { SetObjID(value); }
 }
 public void SetObjID(Int32 value) { 
 hasObjID = true;
 ObjID_ = value;
 }

public const int EffectIDFieldNumber = 2;
 private bool hasEffectID;
 private Int32 EffectID_ = 0;
 public bool HasEffectID {
 get { return hasEffectID; }
 }
 public Int32 EffectID {
 get { return EffectID_; }
 set { SetEffectID(value); }
 }
 public void SetEffectID(Int32 value) { 
 hasEffectID = true;
 EffectID_ = value;
 }

public const int StartMotionIDFieldNumber = 3;
 private bool hasStartMotionID;
 private Int32 StartMotionID_ = 0;
 public bool HasStartMotionID {
 get { return hasStartMotionID; }
 }
 public Int32 StartMotionID {
 get { return StartMotionID_; }
 set { SetStartMotionID(value); }
 }
 public void SetStartMotionID(Int32 value) { 
 hasStartMotionID = true;
 StartMotionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjID);
}
 if (HasEffectID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, EffectID);
}
 if (HasStartMotionID) {
size += pb::CodedOutputStream.ComputeInt32Size(3, StartMotionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjID) {
output.WriteInt32(1, ObjID);
}
 
if (HasEffectID) {
output.WriteInt32(2, EffectID);
}
 
if (HasStartMotionID) {
output.WriteInt32(3, StartMotionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_PLAY_EFFECT _inst = (GC_PLAY_EFFECT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjID = input.ReadInt32();
break;
}
   case  16: {
 _inst.EffectID = input.ReadInt32();
break;
}
   case  24: {
 _inst.StartMotionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjID) return false;
 if (!hasEffectID) return false;
 if (!hasStartMotionID) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_PKINFO : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_PKINFO _inst = (CG_ASK_PKINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_PKINFO : PacketDistributed
{

public const int PKModleFieldNumber = 1;
 private bool hasPKModle;
 private Int32 PKModle_ = 0;
 public bool HasPKModle {
 get { return hasPKModle; }
 }
 public Int32 PKModle {
 get { return PKModle_; }
 set { SetPKModle(value); }
 }
 public void SetPKModle(Int32 value) { 
 hasPKModle = true;
 PKModle_ = value;
 }

public const int PKCDTimeFieldNumber = 2;
 private bool hasPKCDTime;
 private Int32 PKCDTime_ = 0;
 public bool HasPKCDTime {
 get { return hasPKCDTime; }
 }
 public Int32 PKCDTime {
 get { return PKCDTime_; }
 set { SetPKCDTime(value); }
 }
 public void SetPKCDTime(Int32 value) { 
 hasPKCDTime = true;
 PKCDTime_ = value;
 }

public const int PKValueFieldNumber = 3;
 private bool hasPKValue;
 private Int32 PKValue_ = 0;
 public bool HasPKValue {
 get { return hasPKValue; }
 }
 public Int32 PKValue {
 get { return PKValue_; }
 set { SetPKValue(value); }
 }
 public void SetPKValue(Int32 value) { 
 hasPKValue = true;
 PKValue_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPKModle) {
size += pb::CodedOutputStream.ComputeInt32Size(1, PKModle);
}
 if (HasPKCDTime) {
size += pb::CodedOutputStream.ComputeInt32Size(2, PKCDTime);
}
 if (HasPKValue) {
size += pb::CodedOutputStream.ComputeInt32Size(3, PKValue);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPKModle) {
output.WriteInt32(1, PKModle);
}
 
if (HasPKCDTime) {
output.WriteInt32(2, PKCDTime);
}
 
if (HasPKValue) {
output.WriteInt32(3, PKValue);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_PKINFO _inst = (GC_RET_PKINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.PKModle = input.ReadInt32();
break;
}
   case  16: {
 _inst.PKCDTime = input.ReadInt32();
break;
}
   case  24: {
 _inst.PKValue = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPKModle) return false;
 if (!hasPKCDTime) return false;
 if (!hasPKValue) return false;
 return true;
 }

}


[Serializable]
public class CG_CHANGE_PKMODLE : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int PKModleFieldNumber = 2;
 private bool hasPKModle;
 private Int32 PKModle_ = 0;
 public bool HasPKModle {
 get { return hasPKModle; }
 }
 public Int32 PKModle {
 get { return PKModle_; }
 set { SetPKModle(value); }
 }
 public void SetPKModle(Int32 value) { 
 hasPKModle = true;
 PKModle_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasPKModle) {
size += pb::CodedOutputStream.ComputeInt32Size(2, PKModle);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasPKModle) {
output.WriteInt32(2, PKModle);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CHANGE_PKMODLE _inst = (CG_CHANGE_PKMODLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.PKModle = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasPKModle) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_CHANGE_PKMODLE : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int PKModleFieldNumber = 2;
 private bool hasPKModle;
 private Int32 PKModle_ = 0;
 public bool HasPKModle {
 get { return hasPKModle; }
 }
 public Int32 PKModle {
 get { return PKModle_; }
 set { SetPKModle(value); }
 }
 public void SetPKModle(Int32 value) { 
 hasPKModle = true;
 PKModle_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasPKModle) {
size += pb::CodedOutputStream.ComputeInt32Size(2, PKModle);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasPKModle) {
output.WriteInt32(2, PKModle);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_CHANGE_PKMODLE _inst = (GC_RET_CHANGE_PKMODLE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.PKModle = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasPKModle) return false;
 return true;
 }

}


[Serializable]
public class GC_CHANGE_PKLIST : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int isInPkListFieldNumber = 2;
 private bool hasIsInPkList;
 private Int32 isInPkList_ = 0;
 public bool HasIsInPkList {
 get { return hasIsInPkList; }
 }
 public Int32 IsInPkList {
 get { return isInPkList_; }
 set { SetIsInPkList(value); }
 }
 public void SetIsInPkList(Int32 value) { 
 hasIsInPkList = true;
 isInPkList_ = value;
 }

public const int isPKListEmptyFieldNumber = 3;
 private bool hasIsPKListEmpty;
 private Int32 isPKListEmpty_ = 0;
 public bool HasIsPKListEmpty {
 get { return hasIsPKListEmpty; }
 }
 public Int32 IsPKListEmpty {
 get { return isPKListEmpty_; }
 set { SetIsPKListEmpty(value); }
 }
 public void SetIsPKListEmpty(Int32 value) { 
 hasIsPKListEmpty = true;
 isPKListEmpty_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasIsInPkList) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsInPkList);
}
 if (HasIsPKListEmpty) {
size += pb::CodedOutputStream.ComputeInt32Size(3, IsPKListEmpty);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasIsInPkList) {
output.WriteInt32(2, IsInPkList);
}
 
if (HasIsPKListEmpty) {
output.WriteInt32(3, IsPKListEmpty);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CHANGE_PKLIST _inst = (GC_CHANGE_PKLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.IsInPkList = input.ReadInt32();
break;
}
   case  24: {
 _inst.IsPKListEmpty = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasIsInPkList) return false;
 if (!hasIsPKListEmpty) return false;
 return true;
 }

}


[Serializable]
public class GC_MAIL_UPDATE : PacketDistributed
{
public enum MailSender 
 { 
  MAILSENDER_SYS  = 0,  // ������Ϊϵͳ 
  MAILSENDER_USER = 1,  // ������Ϊ��� 
 }
public const int MailGuidFieldNumber = 1;
 private bool hasMailGuid;
 private UInt64 MailGuid_ = 0;
 public bool HasMailGuid {
 get { return hasMailGuid; }
 }
 public UInt64 MailGuid {
 get { return MailGuid_; }
 set { SetMailGuid(value); }
 }
 public void SetMailGuid(UInt64 value) { 
 hasMailGuid = true;
 MailGuid_ = value;
 }

public const int SenderTypeFieldNumber = 2;
 private bool hasSenderType;
 private Int32 SenderType_ = 0;
 public bool HasSenderType {
 get { return hasSenderType; }
 }
 public Int32 SenderType {
 get { return SenderType_; }
 set { SetSenderType(value); }
 }
 public void SetSenderType(Int32 value) { 
 hasSenderType = true;
 SenderType_ = value;
 }

public const int SenderGuidFieldNumber = 3;
 private bool hasSenderGuid;
 private UInt64 SenderGuid_ = 0;
 public bool HasSenderGuid {
 get { return hasSenderGuid; }
 }
 public UInt64 SenderGuid {
 get { return SenderGuid_; }
 set { SetSenderGuid(value); }
 }
 public void SetSenderGuid(UInt64 value) { 
 hasSenderGuid = true;
 SenderGuid_ = value;
 }

public const int SenderNameFieldNumber = 4;
 private bool hasSenderName;
 private string SenderName_ = "";
 public bool HasSenderName {
 get { return hasSenderName; }
 }
 public string SenderName {
 get { return SenderName_; }
 set { SetSenderName(value); }
 }
 public void SetSenderName(string value) { 
 hasSenderName = true;
 SenderName_ = value;
 }

public const int SendTimeFieldNumber = 5;
 private bool hasSendTime;
 private Int32 SendTime_ = 0;
 public bool HasSendTime {
 get { return hasSendTime; }
 }
 public Int32 SendTime {
 get { return SendTime_; }
 set { SetSendTime(value); }
 }
 public void SetSendTime(Int32 value) { 
 hasSendTime = true;
 SendTime_ = value;
 }

public const int RecevierGuidFieldNumber = 6;
 private bool hasRecevierGuid;
 private UInt64 RecevierGuid_ = 0;
 public bool HasRecevierGuid {
 get { return hasRecevierGuid; }
 }
 public UInt64 RecevierGuid {
 get { return RecevierGuid_; }
 set { SetRecevierGuid(value); }
 }
 public void SetRecevierGuid(UInt64 value) { 
 hasRecevierGuid = true;
 RecevierGuid_ = value;
 }

public const int ReadTimeFieldNumber = 7;
 private bool hasReadTime;
 private Int32 ReadTime_ = 0;
 public bool HasReadTime {
 get { return hasReadTime; }
 }
 public Int32 ReadTime {
 get { return ReadTime_; }
 set { SetReadTime(value); }
 }
 public void SetReadTime(Int32 value) { 
 hasReadTime = true;
 ReadTime_ = value;
 }

public const int TextContentFieldNumber = 8;
 private bool hasTextContent;
 private string TextContent_ = "";
 public bool HasTextContent {
 get { return hasTextContent; }
 }
 public string TextContent {
 get { return TextContent_; }
 set { SetTextContent(value); }
 }
 public void SetTextContent(string value) { 
 hasTextContent = true;
 TextContent_ = value;
 }

public const int MoneyTypeFieldNumber = 9;
 private bool hasMoneyType;
 private Int32 MoneyType_ = 0;
 public bool HasMoneyType {
 get { return hasMoneyType; }
 }
 public Int32 MoneyType {
 get { return MoneyType_; }
 set { SetMoneyType(value); }
 }
 public void SetMoneyType(Int32 value) { 
 hasMoneyType = true;
 MoneyType_ = value;
 }

public const int MoneyCountFieldNumber = 10;
 private bool hasMoneyCount;
 private Int32 MoneyCount_ = 0;
 public bool HasMoneyCount {
 get { return hasMoneyCount; }
 }
 public Int32 MoneyCount {
 get { return MoneyCount_; }
 set { SetMoneyCount(value); }
 }
 public void SetMoneyCount(Int32 value) { 
 hasMoneyCount = true;
 MoneyCount_ = value;
 }

public const int ItemIDFieldNumber = 11;
 private bool hasItemID;
 private Int32 ItemID_ = 0;
 public bool HasItemID {
 get { return hasItemID; }
 }
 public Int32 ItemID {
 get { return ItemID_; }
 set { SetItemID(value); }
 }
 public void SetItemID(Int32 value) { 
 hasItemID = true;
 ItemID_ = value;
 }

public const int ItemCountFieldNumber = 12;
 private bool hasItemCount;
 private Int32 ItemCount_ = 0;
 public bool HasItemCount {
 get { return hasItemCount; }
 }
 public Int32 ItemCount {
 get { return ItemCount_; }
 set { SetItemCount(value); }
 }
 public void SetItemCount(Int32 value) { 
 hasItemCount = true;
 ItemCount_ = value;
 }

public const int OriginFieldNumber = 13;
 private bool hasOrigin;
 private Int32 Origin_ = 0;
 public bool HasOrigin {
 get { return hasOrigin; }
 }
 public Int32 Origin {
 get { return Origin_; }
 set { SetOrigin(value); }
 }
 public void SetOrigin(Int32 value) { 
 hasOrigin = true;
 Origin_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMailGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, MailGuid);
}
 if (HasSenderType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SenderType);
}
 if (HasSenderGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, SenderGuid);
}
 if (HasSenderName) {
size += pb::CodedOutputStream.ComputeStringSize(4, SenderName);
}
 if (HasSendTime) {
size += pb::CodedOutputStream.ComputeInt32Size(5, SendTime);
}
 if (HasRecevierGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(6, RecevierGuid);
}
 if (HasReadTime) {
size += pb::CodedOutputStream.ComputeInt32Size(7, ReadTime);
}
 if (HasTextContent) {
size += pb::CodedOutputStream.ComputeStringSize(8, TextContent);
}
 if (HasMoneyType) {
size += pb::CodedOutputStream.ComputeInt32Size(9, MoneyType);
}
 if (HasMoneyCount) {
size += pb::CodedOutputStream.ComputeInt32Size(10, MoneyCount);
}
 if (HasItemID) {
size += pb::CodedOutputStream.ComputeInt32Size(11, ItemID);
}
 if (HasItemCount) {
size += pb::CodedOutputStream.ComputeInt32Size(12, ItemCount);
}
 if (HasOrigin) {
size += pb::CodedOutputStream.ComputeInt32Size(13, Origin);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMailGuid) {
output.WriteUInt64(1, MailGuid);
}
 
if (HasSenderType) {
output.WriteInt32(2, SenderType);
}
 
if (HasSenderGuid) {
output.WriteUInt64(3, SenderGuid);
}
 
if (HasSenderName) {
output.WriteString(4, SenderName);
}
 
if (HasSendTime) {
output.WriteInt32(5, SendTime);
}
 
if (HasRecevierGuid) {
output.WriteUInt64(6, RecevierGuid);
}
 
if (HasReadTime) {
output.WriteInt32(7, ReadTime);
}
 
if (HasTextContent) {
output.WriteString(8, TextContent);
}
 
if (HasMoneyType) {
output.WriteInt32(9, MoneyType);
}
 
if (HasMoneyCount) {
output.WriteInt32(10, MoneyCount);
}
 
if (HasItemID) {
output.WriteInt32(11, ItemID);
}
 
if (HasItemCount) {
output.WriteInt32(12, ItemCount);
}
 
if (HasOrigin) {
output.WriteInt32(13, Origin);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MAIL_UPDATE _inst = (GC_MAIL_UPDATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MailGuid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.SenderType = input.ReadInt32();
break;
}
   case  24: {
 _inst.SenderGuid = input.ReadUInt64();
break;
}
   case  34: {
 _inst.SenderName = input.ReadString();
break;
}
   case  40: {
 _inst.SendTime = input.ReadInt32();
break;
}
   case  48: {
 _inst.RecevierGuid = input.ReadUInt64();
break;
}
   case  56: {
 _inst.ReadTime = input.ReadInt32();
break;
}
   case  66: {
 _inst.TextContent = input.ReadString();
break;
}
   case  72: {
 _inst.MoneyType = input.ReadInt32();
break;
}
   case  80: {
 _inst.MoneyCount = input.ReadInt32();
break;
}
   case  88: {
 _inst.ItemID = input.ReadInt32();
break;
}
   case  96: {
 _inst.ItemCount = input.ReadInt32();
break;
}
   case  104: {
 _inst.Origin = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMailGuid) return false;
 if (!hasSenderType) return false;
 if (!hasSenderGuid) return false;
 if (!hasSenderName) return false;
 if (!hasSendTime) return false;
 if (!hasRecevierGuid) return false;
 if (!hasReadTime) return false;
 if (!hasTextContent) return false;
 return true;
 }

}


[Serializable]
public class GC_MAIL_DELETE : PacketDistributed
{

public const int MailGuidFieldNumber = 1;
 private bool hasMailGuid;
 private UInt64 MailGuid_ = 0;
 public bool HasMailGuid {
 get { return hasMailGuid; }
 }
 public UInt64 MailGuid {
 get { return MailGuid_; }
 set { SetMailGuid(value); }
 }
 public void SetMailGuid(UInt64 value) { 
 hasMailGuid = true;
 MailGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMailGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, MailGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMailGuid) {
output.WriteUInt64(1, MailGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MAIL_DELETE _inst = (GC_MAIL_DELETE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MailGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMailGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_MAIL_SEND : PacketDistributed
{

public const int ReceiverGuidFieldNumber = 1;
 private bool hasReceiverGuid;
 private UInt64 ReceiverGuid_ = 0;
 public bool HasReceiverGuid {
 get { return hasReceiverGuid; }
 }
 public UInt64 ReceiverGuid {
 get { return ReceiverGuid_; }
 set { SetReceiverGuid(value); }
 }
 public void SetReceiverGuid(UInt64 value) { 
 hasReceiverGuid = true;
 ReceiverGuid_ = value;
 }

public const int TextContentFieldNumber = 2;
 private bool hasTextContent;
 private string TextContent_ = "";
 public bool HasTextContent {
 get { return hasTextContent; }
 }
 public string TextContent {
 get { return TextContent_; }
 set { SetTextContent(value); }
 }
 public void SetTextContent(string value) { 
 hasTextContent = true;
 TextContent_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasReceiverGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, ReceiverGuid);
}
 if (HasTextContent) {
size += pb::CodedOutputStream.ComputeStringSize(2, TextContent);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasReceiverGuid) {
output.WriteUInt64(1, ReceiverGuid);
}
 
if (HasTextContent) {
output.WriteString(2, TextContent);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MAIL_SEND _inst = (CG_MAIL_SEND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ReceiverGuid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.TextContent = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasReceiverGuid) return false;
 if (!hasTextContent) return false;
 return true;
 }

}


[Serializable]
public class CG_MAIL_OPERATION : PacketDistributed
{
public enum MailOperation 
 { 
  OPERATION_DELETE  = 0,   // ɾ�� 
  OPERATION_GETITEM = 1,   // ��ȡ��Ʒ 
  OPERATION_SETREAD = 2,   // ���Ϊ�Ѷ� 
 }
public const int OperationTypeFieldNumber = 1;
 private bool hasOperationType;
 private Int32 OperationType_ = 0;
 public bool HasOperationType {
 get { return hasOperationType; }
 }
 public Int32 OperationType {
 get { return OperationType_; }
 set { SetOperationType(value); }
 }
 public void SetOperationType(Int32 value) { 
 hasOperationType = true;
 OperationType_ = value;
 }

public const int MailGuidFieldNumber = 2;
 private bool hasMailGuid;
 private UInt64 MailGuid_ = 0;
 public bool HasMailGuid {
 get { return hasMailGuid; }
 }
 public UInt64 MailGuid {
 get { return MailGuid_; }
 set { SetMailGuid(value); }
 }
 public void SetMailGuid(UInt64 value) { 
 hasMailGuid = true;
 MailGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasOperationType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, OperationType);
}
 if (HasMailGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, MailGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasOperationType) {
output.WriteInt32(1, OperationType);
}
 
if (HasMailGuid) {
output.WriteUInt64(2, MailGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MAIL_OPERATION _inst = (CG_MAIL_OPERATION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.OperationType = input.ReadInt32();
break;
}
   case  16: {
 _inst.MailGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasOperationType) return false;
 if (!hasMailGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_OP_TELEPORT : PacketDistributed
{

public const int isShowFieldNumber = 1;
 private bool hasIsShow;
 private Int32 isShow_ = 0;
 public bool HasIsShow {
 get { return hasIsShow; }
 }
 public Int32 IsShow {
 get { return isShow_; }
 set { SetIsShow(value); }
 }
 public void SetIsShow(Int32 value) { 
 hasIsShow = true;
 isShow_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasIsShow) {
size += pb::CodedOutputStream.ComputeInt32Size(1, IsShow);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasIsShow) {
output.WriteInt32(1, IsShow);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_OP_TELEPORT _inst = (GC_OP_TELEPORT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.IsShow = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasIsShow) return false;
 return true;
 }

}


[Serializable]
public class GC_OP_QINGGONGPOINT : PacketDistributed
{

public const int nameFieldNumber = 1;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int isShowFieldNumber = 2;
 private bool hasIsShow;
 private Int32 isShow_ = 0;
 public bool HasIsShow {
 get { return hasIsShow; }
 }
 public Int32 IsShow {
 get { return isShow_; }
 set { SetIsShow(value); }
 }
 public void SetIsShow(Int32 value) { 
 hasIsShow = true;
 isShow_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(1, Name);
}
 if (HasIsShow) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsShow);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasName) {
output.WriteString(1, Name);
}
 
if (HasIsShow) {
output.WriteInt32(2, IsShow);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_OP_QINGGONGPOINT _inst = (GC_OP_QINGGONGPOINT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.Name = input.ReadString();
break;
}
   case  16: {
 _inst.IsShow = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasName) return false;
 if (!hasIsShow) return false;
 return true;
 }

}


[Serializable]
public class GC_CHALLENGE_MYDATA : PacketDistributed
{

public const int challengeTimesFieldNumber = 1;
 private bool hasChallengeTimes;
 private Int32 challengeTimes_ = 0;
 public bool HasChallengeTimes {
 get { return hasChallengeTimes; }
 }
 public Int32 ChallengeTimes {
 get { return challengeTimes_; }
 set { SetChallengeTimes(value); }
 }
 public void SetChallengeTimes(Int32 value) { 
 hasChallengeTimes = true;
 challengeTimes_ = value;
 }

public const int spiritValFieldNumber = 2;
 private bool hasSpiritVal;
 private Int32 spiritVal_ = 0;
 public bool HasSpiritVal {
 get { return hasSpiritVal; }
 }
 public Int32 SpiritVal {
 get { return spiritVal_; }
 set { SetSpiritVal(value); }
 }
 public void SetSpiritVal(Int32 value) { 
 hasSpiritVal = true;
 spiritVal_ = value;
 }

public const int rankPosFieldNumber = 3;
 private bool hasRankPos;
 private Int32 rankPos_ = 0;
 public bool HasRankPos {
 get { return hasRankPos; }
 }
 public Int32 RankPos {
 get { return rankPos_; }
 set { SetRankPos(value); }
 }
 public void SetRankPos(Int32 value) { 
 hasRankPos = true;
 rankPos_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasChallengeTimes) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ChallengeTimes);
}
 if (HasSpiritVal) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SpiritVal);
}
 if (HasRankPos) {
size += pb::CodedOutputStream.ComputeInt32Size(3, RankPos);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasChallengeTimes) {
output.WriteInt32(1, ChallengeTimes);
}
 
if (HasSpiritVal) {
output.WriteInt32(2, SpiritVal);
}
 
if (HasRankPos) {
output.WriteInt32(3, RankPos);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CHALLENGE_MYDATA _inst = (GC_CHALLENGE_MYDATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ChallengeTimes = input.ReadInt32();
break;
}
   case  16: {
 _inst.SpiritVal = input.ReadInt32();
break;
}
   case  24: {
 _inst.RankPos = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasChallengeTimes) return false;
 if (!hasSpiritVal) return false;
 if (!hasRankPos) return false;
 return true;
 }

}


[Serializable]
public class CG_RANDOM_OPPONENT : PacketDistributed
{

public const int noneFieldNumber = 1;
 private bool hasNone;
 private Int32 none_ = 0;
 public bool HasNone {
 get { return hasNone; }
 }
 public Int32 None {
 get { return none_; }
 set { SetNone(value); }
 }
 public void SetNone(Int32 value) { 
 hasNone = true;
 none_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNone) {
size += pb::CodedOutputStream.ComputeInt32Size(1, None);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNone) {
output.WriteInt32(1, None);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_RANDOM_OPPONENT _inst = (CG_RANDOM_OPPONENT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.None = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNone) return false;
 return true;
 }

}


[Serializable]
public class GC_OPPONENT_LIST : PacketDistributed
{

public const int opponumFieldNumber = 1;
 private bool hasOpponum;
 private Int32 opponum_ = 0;
 public bool HasOpponum {
 get { return hasOpponum; }
 }
 public Int32 Opponum {
 get { return opponum_; }
 set { SetOpponum(value); }
 }
 public void SetOpponum(Int32 value) { 
 hasOpponum = true;
 opponum_ = value;
 }

public const int levelFieldNumber = 2;
 private pbc::PopsicleList<Int32> level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> levelList {
 get { return pbc::Lists.AsReadOnly(level_); }
 }
 
 public int levelCount {
 get { return level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return level_[index];
 }
 public void AddLevel(Int32 value) {
 level_.Add(value);
 }

public const int professionFieldNumber = 3;
 private pbc::PopsicleList<Int32> profession_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> professionList {
 get { return pbc::Lists.AsReadOnly(profession_); }
 }
 
 public int professionCount {
 get { return profession_.Count; }
 }
 
public Int32 GetProfession(int index) {
 return profession_[index];
 }
 public void AddProfession(Int32 value) {
 profession_.Add(value);
 }

public const int combatNumFieldNumber = 4;
 private pbc::PopsicleList<Int32> combatNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> combatNumList {
 get { return pbc::Lists.AsReadOnly(combatNum_); }
 }
 
 public int combatNumCount {
 get { return combatNum_.Count; }
 }
 
public Int32 GetCombatNum(int index) {
 return combatNum_[index];
 }
 public void AddCombatNum(Int32 value) {
 combatNum_.Add(value);
 }

public const int nameFieldNumber = 5;
 private pbc::PopsicleList<string> name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> nameList {
 get { return pbc::Lists.AsReadOnly(name_); }
 }
 
 public int nameCount {
 get { return name_.Count; }
 }
 
public string GetName(int index) {
 return name_[index];
 }
 public void AddName(string value) {
 name_.Add(value);
 }

public const int rankPosFieldNumber = 6;
 private pbc::PopsicleList<Int32> rankPos_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> rankPosList {
 get { return pbc::Lists.AsReadOnly(rankPos_); }
 }
 
 public int rankPosCount {
 get { return rankPos_.Count; }
 }
 
public Int32 GetRankPos(int index) {
 return rankPos_[index];
 }
 public void AddRankPos(Int32 value) {
 rankPos_.Add(value);
 }

public const int winSpiritFieldNumber = 7;
 private pbc::PopsicleList<Int32> winSpirit_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> winSpiritList {
 get { return pbc::Lists.AsReadOnly(winSpirit_); }
 }
 
 public int winSpiritCount {
 get { return winSpirit_.Count; }
 }
 
public Int32 GetWinSpirit(int index) {
 return winSpirit_[index];
 }
 public void AddWinSpirit(Int32 value) {
 winSpirit_.Add(value);
 }

public const int loseSpiritFieldNumber = 8;
 private pbc::PopsicleList<Int32> loseSpirit_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> loseSpiritList {
 get { return pbc::Lists.AsReadOnly(loseSpirit_); }
 }
 
 public int loseSpiritCount {
 get { return loseSpirit_.Count; }
 }
 
public Int32 GetLoseSpirit(int index) {
 return loseSpirit_[index];
 }
 public void AddLoseSpirit(Int32 value) {
 loseSpirit_.Add(value);
 }

public const int userGuidFieldNumber = 9;
 private pbc::PopsicleList<UInt64> userGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> userGuidList {
 get { return pbc::Lists.AsReadOnly(userGuid_); }
 }
 
 public int userGuidCount {
 get { return userGuid_.Count; }
 }
 
public UInt64 GetUserGuid(int index) {
 return userGuid_[index];
 }
 public void AddUserGuid(UInt64 value) {
 userGuid_.Add(value);
 }

public const int needCostFieldNumber = 10;
 private bool hasNeedCost;
 private Int32 needCost_ = 0;
 public bool HasNeedCost {
 get { return hasNeedCost; }
 }
 public Int32 NeedCost {
 get { return needCost_; }
 set { SetNeedCost(value); }
 }
 public void SetNeedCost(Int32 value) { 
 hasNeedCost = true;
 needCost_ = value;
 }

public const int winReputataionFieldNumber = 11;
 private pbc::PopsicleList<Int32> winReputataion_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> winReputataionList {
 get { return pbc::Lists.AsReadOnly(winReputataion_); }
 }
 
 public int winReputataionCount {
 get { return winReputataion_.Count; }
 }
 
public Int32 GetWinReputataion(int index) {
 return winReputataion_[index];
 }
 public void AddWinReputataion(Int32 value) {
 winReputataion_.Add(value);
 }

public const int loseReputataionFieldNumber = 12;
 private pbc::PopsicleList<Int32> loseReputataion_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> loseReputataionList {
 get { return pbc::Lists.AsReadOnly(loseReputataion_); }
 }
 
 public int loseReputataionCount {
 get { return loseReputataion_.Count; }
 }
 
public Int32 GetLoseReputataion(int index) {
 return loseReputataion_[index];
 }
 public void AddLoseReputataion(Int32 value) {
 loseReputataion_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasOpponum) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Opponum);
}
{
int dataSize = 0;
for(int i=0; i<levelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(levelList[i]);
}
size += dataSize;
size += 1 * level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<professionList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(professionList[i]);
}
size += dataSize;
size += 1 * profession_.Count;
}
{
int dataSize = 0;
for(int i=0; i<combatNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(combatNumList[i]);
}
size += dataSize;
size += 1 * combatNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<nameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(nameList[i]);
}
size += dataSize;
size += 1 * name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<rankPosList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(rankPosList[i]);
}
size += dataSize;
size += 1 * rankPos_.Count;
}
{
int dataSize = 0;
for(int i=0; i<winSpiritList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(winSpiritList[i]);
}
size += dataSize;
size += 1 * winSpirit_.Count;
}
{
int dataSize = 0;
for(int i=0; i<loseSpiritList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(loseSpiritList[i]);
}
size += dataSize;
size += 1 * loseSpirit_.Count;
}
{
int dataSize = 0;
for(int i=0; i<userGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(userGuidList[i]);
}
size += dataSize;
size += 1 * userGuid_.Count;
}
 if (HasNeedCost) {
size += pb::CodedOutputStream.ComputeInt32Size(10, NeedCost);
}
{
int dataSize = 0;
for(int i=0; i<winReputataionList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(winReputataionList[i]);
}
size += dataSize;
size += 1 * winReputataion_.Count;
}
{
int dataSize = 0;
for(int i=0; i<loseReputataionList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(loseReputataionList[i]);
}
size += dataSize;
size += 1 * loseReputataion_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasOpponum) {
output.WriteInt32(1, Opponum);
}
{
if (level_.Count > 0) {
for(int i=0; i<level_.Count; ++i){
output.WriteInt32(2,level_[i]);
}
}

}
{
if (profession_.Count > 0) {
for(int i=0; i<profession_.Count; ++i){
output.WriteInt32(3,profession_[i]);
}
}

}
{
if (combatNum_.Count > 0) {
for(int i=0; i<combatNum_.Count; ++i){
output.WriteInt32(4,combatNum_[i]);
}
}

}
{
if (name_.Count > 0) {
for(int i=0; i<name_.Count; ++i){
output.WriteString(5,name_[i]);
}
}

}
{
if (rankPos_.Count > 0) {
for(int i=0; i<rankPos_.Count; ++i){
output.WriteInt32(6,rankPos_[i]);
}
}

}
{
if (winSpirit_.Count > 0) {
for(int i=0; i<winSpirit_.Count; ++i){
output.WriteInt32(7,winSpirit_[i]);
}
}

}
{
if (loseSpirit_.Count > 0) {
for(int i=0; i<loseSpirit_.Count; ++i){
output.WriteInt32(8,loseSpirit_[i]);
}
}

}
{
if (userGuid_.Count > 0) {
for(int i=0; i<userGuid_.Count; ++i){
output.WriteUInt64(9,userGuid_[i]);
}
}

}
 
if (HasNeedCost) {
output.WriteInt32(10, NeedCost);
}
{
if (winReputataion_.Count > 0) {
for(int i=0; i<winReputataion_.Count; ++i){
output.WriteInt32(11,winReputataion_[i]);
}
}

}
{
if (loseReputataion_.Count > 0) {
for(int i=0; i<loseReputataion_.Count; ++i){
output.WriteInt32(12,loseReputataion_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_OPPONENT_LIST _inst = (GC_OPPONENT_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Opponum = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddProfession(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddCombatNum(input.ReadInt32());
break;
}
   case  42: {
 _inst.AddName(input.ReadString());
break;
}
   case  48: {
 _inst.AddRankPos(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddWinSpirit(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddLoseSpirit(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddUserGuid(input.ReadUInt64());
break;
}
   case  80: {
 _inst.NeedCost = input.ReadInt32();
break;
}
   case  88: {
 _inst.AddWinReputataion(input.ReadInt32());
break;
}
   case  96: {
 _inst.AddLoseReputataion(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasOpponum) return false;
 return true;
 }

}


[Serializable]
public class CG_CHALLENGERANKLIST_REQ : PacketDistributed
{

public const int pageFieldNumber = 1;
 private bool hasPage;
 private Int32 page_ = 0;
 public bool HasPage {
 get { return hasPage; }
 }
 public Int32 Page {
 get { return page_; }
 set { SetPage(value); }
 }
 public void SetPage(Int32 value) { 
 hasPage = true;
 page_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPage) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Page);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPage) {
output.WriteInt32(1, Page);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CHALLENGERANKLIST_REQ _inst = (CG_CHALLENGERANKLIST_REQ) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Page = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPage) return false;
 return true;
 }

}


[Serializable]
public class GC_CHALLENGERANKLIST : PacketDistributed
{

public const int pageFieldNumber = 1;
 private bool hasPage;
 private Int32 page_ = 0;
 public bool HasPage {
 get { return hasPage; }
 }
 public Int32 Page {
 get { return page_; }
 set { SetPage(value); }
 }
 public void SetPage(Int32 value) { 
 hasPage = true;
 page_ = value;
 }

public const int totalpageFieldNumber = 2;
 private bool hasTotalpage;
 private Int32 totalpage_ = 0;
 public bool HasTotalpage {
 get { return hasTotalpage; }
 }
 public Int32 Totalpage {
 get { return totalpage_; }
 set { SetTotalpage(value); }
 }
 public void SetTotalpage(Int32 value) { 
 hasTotalpage = true;
 totalpage_ = value;
 }

public const int levelFieldNumber = 3;
 private pbc::PopsicleList<Int32> level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> levelList {
 get { return pbc::Lists.AsReadOnly(level_); }
 }
 
 public int levelCount {
 get { return level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return level_[index];
 }
 public void AddLevel(Int32 value) {
 level_.Add(value);
 }

public const int professionFieldNumber = 4;
 private pbc::PopsicleList<Int32> profession_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> professionList {
 get { return pbc::Lists.AsReadOnly(profession_); }
 }
 
 public int professionCount {
 get { return profession_.Count; }
 }
 
public Int32 GetProfession(int index) {
 return profession_[index];
 }
 public void AddProfession(Int32 value) {
 profession_.Add(value);
 }

public const int combatNumFieldNumber = 5;
 private pbc::PopsicleList<Int32> combatNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> combatNumList {
 get { return pbc::Lists.AsReadOnly(combatNum_); }
 }
 
 public int combatNumCount {
 get { return combatNum_.Count; }
 }
 
public Int32 GetCombatNum(int index) {
 return combatNum_[index];
 }
 public void AddCombatNum(Int32 value) {
 combatNum_.Add(value);
 }

public const int nameFieldNumber = 6;
 private pbc::PopsicleList<string> name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> nameList {
 get { return pbc::Lists.AsReadOnly(name_); }
 }
 
 public int nameCount {
 get { return name_.Count; }
 }
 
public string GetName(int index) {
 return name_[index];
 }
 public void AddName(string value) {
 name_.Add(value);
 }

public const int posFieldNumber = 7;
 private pbc::PopsicleList<Int32> pos_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posList {
 get { return pbc::Lists.AsReadOnly(pos_); }
 }
 
 public int posCount {
 get { return pos_.Count; }
 }
 
public Int32 GetPos(int index) {
 return pos_[index];
 }
 public void AddPos(Int32 value) {
 pos_.Add(value);
 }

public const int userGuidFieldNumber = 8;
 private pbc::PopsicleList<UInt64> userGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> userGuidList {
 get { return pbc::Lists.AsReadOnly(userGuid_); }
 }
 
 public int userGuidCount {
 get { return userGuid_.Count; }
 }
 
public UInt64 GetUserGuid(int index) {
 return userGuid_[index];
 }
 public void AddUserGuid(UInt64 value) {
 userGuid_.Add(value);
 }

public const int zhenqiFieldNumber = 9;
 private pbc::PopsicleList<Int32> zhenqi_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> zhenqiList {
 get { return pbc::Lists.AsReadOnly(zhenqi_); }
 }
 
 public int zhenqiCount {
 get { return zhenqi_.Count; }
 }
 
public Int32 GetZhenqi(int index) {
 return zhenqi_[index];
 }
 public void AddZhenqi(Int32 value) {
 zhenqi_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPage) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Page);
}
 if (HasTotalpage) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Totalpage);
}
{
int dataSize = 0;
for(int i=0; i<levelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(levelList[i]);
}
size += dataSize;
size += 1 * level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<professionList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(professionList[i]);
}
size += dataSize;
size += 1 * profession_.Count;
}
{
int dataSize = 0;
for(int i=0; i<combatNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(combatNumList[i]);
}
size += dataSize;
size += 1 * combatNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<nameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(nameList[i]);
}
size += dataSize;
size += 1 * name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<posList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posList[i]);
}
size += dataSize;
size += 1 * pos_.Count;
}
{
int dataSize = 0;
for(int i=0; i<userGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(userGuidList[i]);
}
size += dataSize;
size += 1 * userGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<zhenqiList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(zhenqiList[i]);
}
size += dataSize;
size += 1 * zhenqi_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPage) {
output.WriteInt32(1, Page);
}
 
if (HasTotalpage) {
output.WriteInt32(2, Totalpage);
}
{
if (level_.Count > 0) {
for(int i=0; i<level_.Count; ++i){
output.WriteInt32(3,level_[i]);
}
}

}
{
if (profession_.Count > 0) {
for(int i=0; i<profession_.Count; ++i){
output.WriteInt32(4,profession_[i]);
}
}

}
{
if (combatNum_.Count > 0) {
for(int i=0; i<combatNum_.Count; ++i){
output.WriteInt32(5,combatNum_[i]);
}
}

}
{
if (name_.Count > 0) {
for(int i=0; i<name_.Count; ++i){
output.WriteString(6,name_[i]);
}
}

}
{
if (pos_.Count > 0) {
for(int i=0; i<pos_.Count; ++i){
output.WriteInt32(7,pos_[i]);
}
}

}
{
if (userGuid_.Count > 0) {
for(int i=0; i<userGuid_.Count; ++i){
output.WriteUInt64(8,userGuid_[i]);
}
}

}
{
if (zhenqi_.Count > 0) {
for(int i=0; i<zhenqi_.Count; ++i){
output.WriteInt32(9,zhenqi_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CHALLENGERANKLIST _inst = (GC_CHALLENGERANKLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Page = input.ReadInt32();
break;
}
   case  16: {
 _inst.Totalpage = input.ReadInt32();
break;
}
   case  24: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddProfession(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddCombatNum(input.ReadInt32());
break;
}
   case  50: {
 _inst.AddName(input.ReadString());
break;
}
   case  56: {
 _inst.AddPos(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddUserGuid(input.ReadUInt64());
break;
}
   case  72: {
 _inst.AddZhenqi(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPage) return false;
 if (!hasTotalpage) return false;
 return true;
 }

}


[Serializable]
public class CG_REQ_CHALLENGE : PacketDistributed
{

public const int opponentGuidFieldNumber = 1;
 private bool hasOpponentGuid;
 private UInt64 opponentGuid_ = 0;
 public bool HasOpponentGuid {
 get { return hasOpponentGuid; }
 }
 public UInt64 OpponentGuid {
 get { return opponentGuid_; }
 set { SetOpponentGuid(value); }
 }
 public void SetOpponentGuid(UInt64 value) { 
 hasOpponentGuid = true;
 opponentGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasOpponentGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, OpponentGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasOpponentGuid) {
output.WriteUInt64(1, OpponentGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_REQ_CHALLENGE _inst = (CG_REQ_CHALLENGE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.OpponentGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasOpponentGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_CREATE_ZOMBIEUSER : PacketDistributed
{

public const int serverIdFieldNumber = 1;
 private bool hasServerId;
 private Int32 serverId_ = 0;
 public bool HasServerId {
 get { return hasServerId; }
 }
 public Int32 ServerId {
 get { return serverId_; }
 set { SetServerId(value); }
 }
 public void SetServerId(Int32 value) { 
 hasServerId = true;
 serverId_ = value;
 }

public const int sceneInstFieldNumber = 2;
 private bool hasSceneInst;
 private Int32 sceneInst_ = 0;
 public bool HasSceneInst {
 get { return hasSceneInst; }
 }
 public Int32 SceneInst {
 get { return sceneInst_; }
 set { SetSceneInst(value); }
 }
 public void SetSceneInst(Int32 value) { 
 hasSceneInst = true;
 sceneInst_ = value;
 }

public const int sceneClassFieldNumber = 3;
 private bool hasSceneClass;
 private Int32 sceneClass_ = 0;
 public bool HasSceneClass {
 get { return hasSceneClass; }
 }
 public Int32 SceneClass {
 get { return sceneClass_; }
 set { SetSceneClass(value); }
 }
 public void SetSceneClass(Int32 value) { 
 hasSceneClass = true;
 sceneClass_ = value;
 }

public const int dataIdFieldNumber = 4;
 private bool hasDataId;
 private Int32 dataId_ = 0;
 public bool HasDataId {
 get { return hasDataId; }
 }
 public Int32 DataId {
 get { return dataId_; }
 set { SetDataId(value); }
 }
 public void SetDataId(Int32 value) { 
 hasDataId = true;
 dataId_ = value;
 }

public const int posXFieldNumber = 5;
 private bool hasPosX;
 private Int32 posX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return posX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 posX_ = value;
 }

public const int posZFieldNumber = 6;
 private bool hasPosZ;
 private Int32 posZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return posZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 posZ_ = value;
 }

public const int curforceFieldNumber = 7;
 private bool hasCurforce;
 private Int32 curforce_ = 0;
 public bool HasCurforce {
 get { return hasCurforce; }
 }
 public Int32 Curforce {
 get { return curforce_; }
 set { SetCurforce(value); }
 }
 public void SetCurforce(Int32 value) { 
 hasCurforce = true;
 curforce_ = value;
 }

public const int nameFieldNumber = 8;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int facedirFieldNumber = 9;
 private bool hasFacedir;
 private Int32 facedir_ = 0;
 public bool HasFacedir {
 get { return hasFacedir; }
 }
 public Int32 Facedir {
 get { return facedir_; }
 set { SetFacedir(value); }
 }
 public void SetFacedir(Int32 value) { 
 hasFacedir = true;
 facedir_ = value;
 }

public const int isDieFieldNumber = 10;
 private bool hasIsDie;
 private Int32 isDie_ = 0;
 public bool HasIsDie {
 get { return hasIsDie; }
 }
 public Int32 IsDie {
 get { return isDie_; }
 set { SetIsDie(value); }
 }
 public void SetIsDie(Int32 value) { 
 hasIsDie = true;
 isDie_ = value;
 }

public const int movespeedFieldNumber = 11;
 private bool hasMovespeed;
 private Int32 movespeed_ = 0;
 public bool HasMovespeed {
 get { return hasMovespeed; }
 }
 public Int32 Movespeed {
 get { return movespeed_; }
 set { SetMovespeed(value); }
 }
 public void SetMovespeed(Int32 value) { 
 hasMovespeed = true;
 movespeed_ = value;
 }

public const int ModelVisualIDFieldNumber = 12;
 private bool hasModelVisualID;
 private Int32 ModelVisualID_ = 0;
 public bool HasModelVisualID {
 get { return hasModelVisualID; }
 }
 public Int32 ModelVisualID {
 get { return ModelVisualID_; }
 set { SetModelVisualID(value); }
 }
 public void SetModelVisualID(Int32 value) { 
 hasModelVisualID = true;
 ModelVisualID_ = value;
 }

public const int weaponidFieldNumber = 13;
 private bool hasWeaponid;
 private Int32 weaponid_ = 0;
 public bool HasWeaponid {
 get { return hasWeaponid; }
 }
 public Int32 Weaponid {
 get { return weaponid_; }
 set { SetWeaponid(value); }
 }
 public void SetWeaponid(Int32 value) { 
 hasWeaponid = true;
 weaponid_ = value;
 }

public const int WeaponEffectGemFieldNumber = 14;
 private bool hasWeaponEffectGem;
 private Int32 WeaponEffectGem_ = 0;
 public bool HasWeaponEffectGem {
 get { return hasWeaponEffectGem; }
 }
 public Int32 WeaponEffectGem {
 get { return WeaponEffectGem_; }
 set { SetWeaponEffectGem(value); }
 }
 public void SetWeaponEffectGem(Int32 value) { 
 hasWeaponEffectGem = true;
 WeaponEffectGem_ = value;
 }

public const int StealthLevFieldNumber = 15;
 private bool hasStealthLev;
 private Int32 StealthLev_ = 0;
 public bool HasStealthLev {
 get { return hasStealthLev; }
 }
 public Int32 StealthLev {
 get { return StealthLev_; }
 set { SetStealthLev(value); }
 }
 public void SetStealthLev(Int32 value) { 
 hasStealthLev = true;
 StealthLev_ = value;
 }

public const int ProfessionFieldNumber = 16;
 private bool hasProfession;
 private Int32 Profession_ = 0;
 public bool HasProfession {
 get { return hasProfession; }
 }
 public Int32 Profession {
 get { return Profession_; }
 set { SetProfession(value); }
 }
 public void SetProfession(Int32 value) { 
 hasProfession = true;
 Profession_ = value;
 }

public const int bindparentFieldNumber = 17;
 private bool hasBindparent;
 private Int32 bindparent_ = 0;
 public bool HasBindparent {
 get { return hasBindparent; }
 }
 public Int32 Bindparent {
 get { return bindparent_; }
 set { SetBindparent(value); }
 }
 public void SetBindparent(Int32 value) { 
 hasBindparent = true;
 bindparent_ = value;
 }

public const int bindchildrenFieldNumber = 18;
 private pbc::PopsicleList<Int32> bindchildren_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> bindchildrenList {
 get { return pbc::Lists.AsReadOnly(bindchildren_); }
 }
 
 public int bindchildrenCount {
 get { return bindchildren_.Count; }
 }
 
public Int32 GetBindchildren(int index) {
 return bindchildren_[index];
 }
 public void AddBindchildren(Int32 value) {
 bindchildren_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ServerId);
}
 if (HasSceneInst) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SceneInst);
}
 if (HasSceneClass) {
size += pb::CodedOutputStream.ComputeInt32Size(3, SceneClass);
}
 if (HasDataId) {
size += pb::CodedOutputStream.ComputeInt32Size(4, DataId);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(5, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(6, PosZ);
}
 if (HasCurforce) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Curforce);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(8, Name);
}
 if (HasFacedir) {
size += pb::CodedOutputStream.ComputeInt32Size(9, Facedir);
}
 if (HasIsDie) {
size += pb::CodedOutputStream.ComputeInt32Size(10, IsDie);
}
 if (HasMovespeed) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Movespeed);
}
 if (HasModelVisualID) {
size += pb::CodedOutputStream.ComputeInt32Size(12, ModelVisualID);
}
 if (HasWeaponid) {
size += pb::CodedOutputStream.ComputeInt32Size(13, Weaponid);
}
 if (HasWeaponEffectGem) {
size += pb::CodedOutputStream.ComputeInt32Size(14, WeaponEffectGem);
}
 if (HasStealthLev) {
size += pb::CodedOutputStream.ComputeInt32Size(15, StealthLev);
}
 if (HasProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(16, Profession);
}
 if (HasBindparent) {
size += pb::CodedOutputStream.ComputeInt32Size(17, Bindparent);
}
{
int dataSize = 0;
for(int i=0; i<bindchildrenList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(bindchildrenList[i]);
}
size += dataSize;
size += 1 * bindchildren_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerId) {
output.WriteInt32(1, ServerId);
}
 
if (HasSceneInst) {
output.WriteInt32(2, SceneInst);
}
 
if (HasSceneClass) {
output.WriteInt32(3, SceneClass);
}
 
if (HasDataId) {
output.WriteInt32(4, DataId);
}
 
if (HasPosX) {
output.WriteInt32(5, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(6, PosZ);
}
 
if (HasCurforce) {
output.WriteInt32(7, Curforce);
}
 
if (HasName) {
output.WriteString(8, Name);
}
 
if (HasFacedir) {
output.WriteInt32(9, Facedir);
}
 
if (HasIsDie) {
output.WriteInt32(10, IsDie);
}
 
if (HasMovespeed) {
output.WriteInt32(11, Movespeed);
}
 
if (HasModelVisualID) {
output.WriteInt32(12, ModelVisualID);
}
 
if (HasWeaponid) {
output.WriteInt32(13, Weaponid);
}
 
if (HasWeaponEffectGem) {
output.WriteInt32(14, WeaponEffectGem);
}
 
if (HasStealthLev) {
output.WriteInt32(15, StealthLev);
}
 
if (HasProfession) {
output.WriteInt32(16, Profession);
}
 
if (HasBindparent) {
output.WriteInt32(17, Bindparent);
}
{
if (bindchildren_.Count > 0) {
for(int i=0; i<bindchildren_.Count; ++i){
output.WriteInt32(18,bindchildren_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CREATE_ZOMBIEUSER _inst = (GC_CREATE_ZOMBIEUSER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ServerId = input.ReadInt32();
break;
}
   case  16: {
 _inst.SceneInst = input.ReadInt32();
break;
}
   case  24: {
 _inst.SceneClass = input.ReadInt32();
break;
}
   case  32: {
 _inst.DataId = input.ReadInt32();
break;
}
   case  40: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  48: {
 _inst.PosZ = input.ReadInt32();
break;
}
   case  56: {
 _inst.Curforce = input.ReadInt32();
break;
}
   case  66: {
 _inst.Name = input.ReadString();
break;
}
   case  72: {
 _inst.Facedir = input.ReadInt32();
break;
}
   case  80: {
 _inst.IsDie = input.ReadInt32();
break;
}
   case  88: {
 _inst.Movespeed = input.ReadInt32();
break;
}
   case  96: {
 _inst.ModelVisualID = input.ReadInt32();
break;
}
   case  104: {
 _inst.Weaponid = input.ReadInt32();
break;
}
   case  112: {
 _inst.WeaponEffectGem = input.ReadInt32();
break;
}
   case  120: {
 _inst.StealthLev = input.ReadInt32();
break;
}
   case  128: {
 _inst.Profession = input.ReadInt32();
break;
}
   case  136: {
 _inst.Bindparent = input.ReadInt32();
break;
}
   case  144: {
 _inst.AddBindchildren(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerId) return false;
 if (!hasSceneInst) return false;
 if (!hasSceneClass) return false;
 if (!hasDataId) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 if (!hasCurforce) return false;
 if (!hasName) return false;
 if (!hasFacedir) return false;
 if (!hasIsDie) return false;
 if (!hasMovespeed) return false;
 if (!hasModelVisualID) return false;
 if (!hasWeaponid) return false;
 if (!hasWeaponEffectGem) return false;
 if (!hasStealthLev) return false;
 if (!hasProfession) return false;
 if (!hasBindparent) return false;
 return true;
 }

}


[Serializable]
public class GC_CHALLENGE_REWARD : PacketDistributed
{

public const int spiritValFieldNumber = 1;
 private bool hasSpiritVal;
 private Int32 spiritVal_ = 0;
 public bool HasSpiritVal {
 get { return hasSpiritVal; }
 }
 public Int32 SpiritVal {
 get { return spiritVal_; }
 set { SetSpiritVal(value); }
 }
 public void SetSpiritVal(Int32 value) { 
 hasSpiritVal = true;
 spiritVal_ = value;
 }

public const int isLoseFieldNumber = 2;
 private bool hasIsLose;
 private Int32 isLose_ = 0;
 public bool HasIsLose {
 get { return hasIsLose; }
 }
 public Int32 IsLose {
 get { return isLose_; }
 set { SetIsLose(value); }
 }
 public void SetIsLose(Int32 value) { 
 hasIsLose = true;
 isLose_ = value;
 }

public const int reputationValFieldNumber = 3;
 private bool hasReputationVal;
 private Int32 reputationVal_ = 0;
 public bool HasReputationVal {
 get { return hasReputationVal; }
 }
 public Int32 ReputationVal {
 get { return reputationVal_; }
 set { SetReputationVal(value); }
 }
 public void SetReputationVal(Int32 value) { 
 hasReputationVal = true;
 reputationVal_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSpiritVal) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SpiritVal);
}
 if (HasIsLose) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsLose);
}
 if (HasReputationVal) {
size += pb::CodedOutputStream.ComputeInt32Size(3, ReputationVal);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSpiritVal) {
output.WriteInt32(1, SpiritVal);
}
 
if (HasIsLose) {
output.WriteInt32(2, IsLose);
}
 
if (HasReputationVal) {
output.WriteInt32(3, ReputationVal);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CHALLENGE_REWARD _inst = (GC_CHALLENGE_REWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SpiritVal = input.ReadInt32();
break;
}
   case  16: {
 _inst.IsLose = input.ReadInt32();
break;
}
   case  24: {
 _inst.ReputationVal = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSpiritVal) return false;
 if (!hasIsLose) return false;
 return true;
 }

}


[Serializable]
public class GC_CHALLENGE_HISTORY : PacketDistributed
{

public const int userGuidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> userGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> userGuidList {
 get { return pbc::Lists.AsReadOnly(userGuid_); }
 }
 
 public int userGuidCount {
 get { return userGuid_.Count; }
 }
 
public UInt64 GetUserGuid(int index) {
 return userGuid_[index];
 }
 public void AddUserGuid(UInt64 value) {
 userGuid_.Add(value);
 }

public const int nameFieldNumber = 2;
 private pbc::PopsicleList<string> name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> nameList {
 get { return pbc::Lists.AsReadOnly(name_); }
 }
 
 public int nameCount {
 get { return name_.Count; }
 }
 
public string GetName(int index) {
 return name_[index];
 }
 public void AddName(string value) {
 name_.Add(value);
 }

public const int isLoseFieldNumber = 3;
 private pbc::PopsicleList<Int32> isLose_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> isLoseList {
 get { return pbc::Lists.AsReadOnly(isLose_); }
 }
 
 public int isLoseCount {
 get { return isLose_.Count; }
 }
 
public Int32 GetIsLose(int index) {
 return isLose_[index];
 }
 public void AddIsLose(Int32 value) {
 isLose_.Add(value);
 }

public const int occurTimeFieldNumber = 4;
 private pbc::PopsicleList<UInt32> occurTime_ = new pbc::PopsicleList<UInt32>();
 public scg::IList<UInt32> occurTimeList {
 get { return pbc::Lists.AsReadOnly(occurTime_); }
 }
 
 public int occurTimeCount {
 get { return occurTime_.Count; }
 }
 
public UInt32 GetOccurTime(int index) {
 return occurTime_[index];
 }
 public void AddOccurTime(UInt32 value) {
 occurTime_.Add(value);
 }

public const int isActiveFieldNumber = 5;
 private pbc::PopsicleList<Int32> isActive_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> isActiveList {
 get { return pbc::Lists.AsReadOnly(isActive_); }
 }
 
 public int isActiveCount {
 get { return isActive_.Count; }
 }
 
public Int32 GetIsActive(int index) {
 return isActive_[index];
 }
 public void AddIsActive(Int32 value) {
 isActive_.Add(value);
 }

public const int rankPosFieldNumber = 6;
 private pbc::PopsicleList<Int32> rankPos_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> rankPosList {
 get { return pbc::Lists.AsReadOnly(rankPos_); }
 }
 
 public int rankPosCount {
 get { return rankPos_.Count; }
 }
 
public Int32 GetRankPos(int index) {
 return rankPos_[index];
 }
 public void AddRankPos(Int32 value) {
 rankPos_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<userGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(userGuidList[i]);
}
size += dataSize;
size += 1 * userGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<nameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(nameList[i]);
}
size += dataSize;
size += 1 * name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<isLoseList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(isLoseList[i]);
}
size += dataSize;
size += 1 * isLose_.Count;
}
{
int dataSize = 0;
for(int i=0; i<occurTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt32SizeNoTag(occurTimeList[i]);
}
size += dataSize;
size += 1 * occurTime_.Count;
}
{
int dataSize = 0;
for(int i=0; i<isActiveList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(isActiveList[i]);
}
size += dataSize;
size += 1 * isActive_.Count;
}
{
int dataSize = 0;
for(int i=0; i<rankPosList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(rankPosList[i]);
}
size += dataSize;
size += 1 * rankPos_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (userGuid_.Count > 0) {
for(int i=0; i<userGuid_.Count; ++i){
output.WriteUInt64(1,userGuid_[i]);
}
}

}
{
if (name_.Count > 0) {
for(int i=0; i<name_.Count; ++i){
output.WriteString(2,name_[i]);
}
}

}
{
if (isLose_.Count > 0) {
for(int i=0; i<isLose_.Count; ++i){
output.WriteInt32(3,isLose_[i]);
}
}

}
{
if (occurTime_.Count > 0) {
for(int i=0; i<occurTime_.Count; ++i){
output.WriteUInt32(4,occurTime_[i]);
}
}

}
{
if (isActive_.Count > 0) {
for(int i=0; i<isActive_.Count; ++i){
output.WriteInt32(5,isActive_[i]);
}
}

}
{
if (rankPos_.Count > 0) {
for(int i=0; i<rankPos_.Count; ++i){
output.WriteInt32(6,rankPos_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_CHALLENGE_HISTORY _inst = (GC_CHALLENGE_HISTORY) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddUserGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddName(input.ReadString());
break;
}
   case  24: {
 _inst.AddIsLose(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddOccurTime(input.ReadUInt32());
break;
}
   case  40: {
 _inst.AddIsActive(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddRankPos(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_UI_OPERATION : PacketDistributed
{
public enum UIOPERATION 
 { 
  UI_SHOW  = 0, 
  UI_CLOSE = 1, 
 }
public const int operationFieldNumber = 1;
 private bool hasOperation;
 private Int32 operation_ = 0;
 public bool HasOperation {
 get { return hasOperation; }
 }
 public Int32 Operation {
 get { return operation_; }
 set { SetOperation(value); }
 }
 public void SetOperation(Int32 value) { 
 hasOperation = true;
 operation_ = value;
 }

public const int tableIDFieldNumber = 2;
 private bool hasTableID;
 private Int32 tableID_ = 0;
 public bool HasTableID {
 get { return hasTableID; }
 }
 public Int32 TableID {
 get { return tableID_; }
 set { SetTableID(value); }
 }
 public void SetTableID(Int32 value) { 
 hasTableID = true;
 tableID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasOperation) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Operation);
}
 if (HasTableID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, TableID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasOperation) {
output.WriteInt32(1, Operation);
}
 
if (HasTableID) {
output.WriteInt32(2, TableID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UI_OPERATION _inst = (GC_UI_OPERATION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Operation = input.ReadInt32();
break;
}
   case  16: {
 _inst.TableID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasOperation) return false;
 if (!hasTableID) return false;
 return true;
 }

}


[Serializable]
public class GC_SCENE_TIMESCALE : PacketDistributed
{

public const int TimeScaleTypeFieldNumber = 1;
 private bool hasTimeScaleType;
 private Int32 TimeScaleType_ = 0;
 public bool HasTimeScaleType {
 get { return hasTimeScaleType; }
 }
 public Int32 TimeScaleType {
 get { return TimeScaleType_; }
 set { SetTimeScaleType(value); }
 }
 public void SetTimeScaleType(Int32 value) { 
 hasTimeScaleType = true;
 TimeScaleType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTimeScaleType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TimeScaleType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTimeScaleType) {
output.WriteInt32(1, TimeScaleType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SCENE_TIMESCALE _inst = (GC_SCENE_TIMESCALE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TimeScaleType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTimeScaleType) return false;
 return true;
 }

}


[Serializable]
public class CG_LEAVE_COPYSCENE : PacketDistributed
{

public const int noParamFieldNumber = 1;
 private bool hasNoParam;
 private Int32 noParam_ = 0;
 public bool HasNoParam {
 get { return hasNoParam; }
 }
 public Int32 NoParam {
 get { return noParam_; }
 set { SetNoParam(value); }
 }
 public void SetNoParam(Int32 value) { 
 hasNoParam = true;
 noParam_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNoParam) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NoParam);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNoParam) {
output.WriteInt32(1, NoParam);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_LEAVE_COPYSCENE _inst = (CG_LEAVE_COPYSCENE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NoParam = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNoParam) return false;
 return true;
 }

}


[Serializable]
public class GC_SKILL_FINISH : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int FinsjTypeFieldNumber = 2;
 private bool hasFinsjType;
 private Int32 FinsjType_ = 0;
 public bool HasFinsjType {
 get { return hasFinsjType; }
 }
 public Int32 FinsjType {
 get { return FinsjType_; }
 set { SetFinsjType(value); }
 }
 public void SetFinsjType(Int32 value) { 
 hasFinsjType = true;
 FinsjType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasFinsjType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, FinsjType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasFinsjType) {
output.WriteInt32(2, FinsjType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SKILL_FINISH _inst = (GC_SKILL_FINISH) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.FinsjType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasFinsjType) return false;
 return true;
 }

}


[Serializable]
public class GC_SHOW_EQUIPREMIND : PacketDistributed
{

public const int EquipGUIDFieldNumber = 1;
 private bool hasEquipGUID;
 private UInt64 EquipGUID_ = 0;
 public bool HasEquipGUID {
 get { return hasEquipGUID; }
 }
 public UInt64 EquipGUID {
 get { return EquipGUID_; }
 set { SetEquipGUID(value); }
 }
 public void SetEquipGUID(UInt64 value) { 
 hasEquipGUID = true;
 EquipGUID_ = value;
 }

public const int EquipIDFieldNumber = 2;
 private bool hasEquipID;
 private Int32 EquipID_ = 0;
 public bool HasEquipID {
 get { return hasEquipID; }
 }
 public Int32 EquipID {
 get { return EquipID_; }
 set { SetEquipID(value); }
 }
 public void SetEquipID(Int32 value) { 
 hasEquipID = true;
 EquipID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasEquipGUID) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, EquipGUID);
}
 if (HasEquipID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, EquipID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasEquipGUID) {
output.WriteUInt64(1, EquipGUID);
}
 
if (HasEquipID) {
output.WriteInt32(2, EquipID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SHOW_EQUIPREMIND _inst = (GC_SHOW_EQUIPREMIND) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.EquipGUID = input.ReadUInt64();
break;
}
   case  16: {
 _inst.EquipID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasEquipGUID) return false;
 if (!hasEquipID) return false;
 return true;
 }

}


[Serializable]
public class CG_USER_BEHAVIOR : PacketDistributed
{
public enum BehaviorType 
 { 
  CLICK_AIMBAR   = 0,   // ���Ŀ���� 
 }
public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_USER_BEHAVIOR _inst = (CG_USER_BEHAVIOR) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class GC_UI_NEWPLAYERGUIDE : PacketDistributed
{

public const int UINameFieldNumber = 1;
 private bool hasUIName;
 private string UIName_ = "";
 public bool HasUIName {
 get { return hasUIName; }
 }
 public string UIName {
 get { return UIName_; }
 set { SetUIName(value); }
 }
 public void SetUIName(string value) { 
 hasUIName = true;
 UIName_ = value;
 }

public const int IndexFieldNumber = 2;
 private bool hasIndex;
 private Int32 Index_ = 0;
 public bool HasIndex {
 get { return hasIndex; }
 }
 public Int32 Index {
 get { return Index_; }
 set { SetIndex(value); }
 }
 public void SetIndex(Int32 value) { 
 hasIndex = true;
 Index_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasUIName) {
size += pb::CodedOutputStream.ComputeStringSize(1, UIName);
}
 if (HasIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Index);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasUIName) {
output.WriteString(1, UIName);
}
 
if (HasIndex) {
output.WriteInt32(2, Index);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UI_NEWPLAYERGUIDE _inst = (GC_UI_NEWPLAYERGUIDE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.UIName = input.ReadString();
break;
}
   case  16: {
 _inst.Index = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasUIName) return false;
 if (!hasIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_SKILL_STUDY : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

public const int skillindexFieldNumber = 2;
 private bool hasSkillindex;
 private Int32 skillindex_ = 0;
 public bool HasSkillindex {
 get { return hasSkillindex; }
 }
 public Int32 Skillindex {
 get { return skillindex_; }
 set { SetSkillindex(value); }
 }
 public void SetSkillindex(Int32 value) { 
 hasSkillindex = true;
 skillindex_ = value;
 }

public const int attachSkillIdFieldNumber = 3;
 private bool hasAttachSkillId;
 private Int32 attachSkillId_ = 0;
 public bool HasAttachSkillId {
 get { return hasAttachSkillId; }
 }
 public Int32 AttachSkillId {
 get { return attachSkillId_; }
 set { SetAttachSkillId(value); }
 }
 public void SetAttachSkillId(Int32 value) { 
 hasAttachSkillId = true;
 attachSkillId_ = value;
 }

public const int attachSkillIndexFieldNumber = 4;
 private bool hasAttachSkillIndex;
 private Int32 attachSkillIndex_ = 0;
 public bool HasAttachSkillIndex {
 get { return hasAttachSkillIndex; }
 }
 public Int32 AttachSkillIndex {
 get { return attachSkillIndex_; }
 set { SetAttachSkillIndex(value); }
 }
 public void SetAttachSkillIndex(Int32 value) { 
 hasAttachSkillIndex = true;
 attachSkillIndex_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 if (HasSkillindex) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Skillindex);
}
 if (HasAttachSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(3, AttachSkillId);
}
 if (HasAttachSkillIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(4, AttachSkillIndex);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 
if (HasSkillindex) {
output.WriteInt32(2, Skillindex);
}
 
if (HasAttachSkillId) {
output.WriteInt32(3, AttachSkillId);
}
 
if (HasAttachSkillIndex) {
output.WriteInt32(4, AttachSkillIndex);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SKILL_STUDY _inst = (GC_SKILL_STUDY) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}
   case  16: {
 _inst.Skillindex = input.ReadInt32();
break;
}
   case  24: {
 _inst.AttachSkillId = input.ReadInt32();
break;
}
   case  32: {
 _inst.AttachSkillIndex = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 if (!hasSkillindex) return false;
 if (!hasAttachSkillId) return false;
 if (!hasAttachSkillIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_PLAY_MODELSOTRY : PacketDistributed
{

public const int ModelStoryIDFieldNumber = 1;
 private bool hasModelStoryID;
 private Int32 ModelStoryID_ = 0;
 public bool HasModelStoryID {
 get { return hasModelStoryID; }
 }
 public Int32 ModelStoryID {
 get { return ModelStoryID_; }
 set { SetModelStoryID(value); }
 }
 public void SetModelStoryID(Int32 value) { 
 hasModelStoryID = true;
 ModelStoryID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasModelStoryID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ModelStoryID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasModelStoryID) {
output.WriteInt32(1, ModelStoryID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_PLAY_MODELSOTRY _inst = (GC_PLAY_MODELSOTRY) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ModelStoryID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasModelStoryID) return false;
 return true;
 }

}


[Serializable]
public class GC_SYN_SKILLINFO : PacketDistributed
{

public const int skillidFieldNumber = 1;
 private pbc::PopsicleList<Int32> skillid_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillidList {
 get { return pbc::Lists.AsReadOnly(skillid_); }
 }
 
 public int skillidCount {
 get { return skillid_.Count; }
 }
 
public Int32 GetSkillid(int index) {
 return skillid_[index];
 }
 public void AddSkillid(Int32 value) {
 skillid_.Add(value);
 }

public const int skillindexFieldNumber = 2;
 private pbc::PopsicleList<Int32> skillindex_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillindexList {
 get { return pbc::Lists.AsReadOnly(skillindex_); }
 }
 
 public int skillindexCount {
 get { return skillindex_.Count; }
 }
 
public Int32 GetSkillindex(int index) {
 return skillindex_[index];
 }
 public void AddSkillindex(Int32 value) {
 skillindex_.Add(value);
 }

public const int CDTimeFieldNumber = 3;
 private pbc::PopsicleList<Int32> CDTime_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> CDTimeList {
 get { return pbc::Lists.AsReadOnly(CDTime_); }
 }
 
 public int CDTimeCount {
 get { return CDTime_.Count; }
 }
 
public Int32 GetCDTime(int index) {
 return CDTime_[index];
 }
 public void AddCDTime(Int32 value) {
 CDTime_.Add(value);
 }

public const int isSkillLevelUpFieldNumber = 4;
 private bool hasIsSkillLevelUp;
 private Int32 isSkillLevelUp_ = 0;
 public bool HasIsSkillLevelUp {
 get { return hasIsSkillLevelUp; }
 }
 public Int32 IsSkillLevelUp {
 get { return isSkillLevelUp_; }
 set { SetIsSkillLevelUp(value); }
 }
 public void SetIsSkillLevelUp(Int32 value) { 
 hasIsSkillLevelUp = true;
 isSkillLevelUp_ = value;
 }

public const int skillExpFieldNumber = 5;
 private pbc::PopsicleList<Int32> skillExp_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillExpList {
 get { return pbc::Lists.AsReadOnly(skillExp_); }
 }
 
 public int skillExpCount {
 get { return skillExp_.Count; }
 }
 
public Int32 GetSkillExp(int index) {
 return skillExp_[index];
 }
 public void AddSkillExp(Int32 value) {
 skillExp_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<skillidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillidList[i]);
}
size += dataSize;
size += 1 * skillid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<skillindexList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillindexList[i]);
}
size += dataSize;
size += 1 * skillindex_.Count;
}
{
int dataSize = 0;
for(int i=0; i<CDTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(CDTimeList[i]);
}
size += dataSize;
size += 1 * CDTime_.Count;
}
 if (HasIsSkillLevelUp) {
size += pb::CodedOutputStream.ComputeInt32Size(4, IsSkillLevelUp);
}
{
int dataSize = 0;
for(int i=0; i<skillExpList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillExpList[i]);
}
size += dataSize;
size += 1 * skillExp_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (skillid_.Count > 0) {
for(int i=0; i<skillid_.Count; ++i){
output.WriteInt32(1,skillid_[i]);
}
}

}
{
if (skillindex_.Count > 0) {
for(int i=0; i<skillindex_.Count; ++i){
output.WriteInt32(2,skillindex_[i]);
}
}

}
{
if (CDTime_.Count > 0) {
for(int i=0; i<CDTime_.Count; ++i){
output.WriteInt32(3,CDTime_[i]);
}
}

}
 
if (HasIsSkillLevelUp) {
output.WriteInt32(4, IsSkillLevelUp);
}
{
if (skillExp_.Count > 0) {
for(int i=0; i<skillExp_.Count; ++i){
output.WriteInt32(5,skillExp_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYN_SKILLINFO _inst = (GC_SYN_SKILLINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddSkillid(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddSkillindex(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddCDTime(input.ReadInt32());
break;
}
   case  32: {
 _inst.IsSkillLevelUp = input.ReadInt32();
break;
}
   case  40: {
 _inst.AddSkillExp(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_UPDATE_SCENE_INSTACTIVATION : PacketDistributed
{

public const int sceneclassidFieldNumber = 1;
 private bool hasSceneclassid;
 private Int32 sceneclassid_ = 0;
 public bool HasSceneclassid {
 get { return hasSceneclassid; }
 }
 public Int32 Sceneclassid {
 get { return sceneclassid_; }
 set { SetSceneclassid(value); }
 }
 public void SetSceneclassid(Int32 value) { 
 hasSceneclassid = true;
 sceneclassid_ = value;
 }

public const int sceneinstcountFieldNumber = 2;
 private bool hasSceneinstcount;
 private Int32 sceneinstcount_ = 0;
 public bool HasSceneinstcount {
 get { return hasSceneinstcount; }
 }
 public Int32 Sceneinstcount {
 get { return sceneinstcount_; }
 set { SetSceneinstcount(value); }
 }
 public void SetSceneinstcount(Int32 value) { 
 hasSceneinstcount = true;
 sceneinstcount_ = value;
 }

public const int sceneactivationFieldNumber = 3;
 private pbc::PopsicleList<Int32> sceneactivation_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sceneactivationList {
 get { return pbc::Lists.AsReadOnly(sceneactivation_); }
 }
 
 public int sceneactivationCount {
 get { return sceneactivation_.Count; }
 }
 
public Int32 GetSceneactivation(int index) {
 return sceneactivation_[index];
 }
 public void AddSceneactivation(Int32 value) {
 sceneactivation_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneclassid) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Sceneclassid);
}
 if (HasSceneinstcount) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Sceneinstcount);
}
{
int dataSize = 0;
for(int i=0; i<sceneactivationList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sceneactivationList[i]);
}
size += dataSize;
size += 1 * sceneactivation_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneclassid) {
output.WriteInt32(1, Sceneclassid);
}
 
if (HasSceneinstcount) {
output.WriteInt32(2, Sceneinstcount);
}
{
if (sceneactivation_.Count > 0) {
for(int i=0; i<sceneactivation_.Count; ++i){
output.WriteInt32(3,sceneactivation_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_SCENE_INSTACTIVATION _inst = (GC_UPDATE_SCENE_INSTACTIVATION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Sceneclassid = input.ReadInt32();
break;
}
   case  16: {
 _inst.Sceneinstcount = input.ReadInt32();
break;
}
   case  24: {
 _inst.AddSceneactivation(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneclassid) return false;
 if (!hasSceneinstcount) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATE_ANIMATION_STATE : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int AnimationStateFieldNumber = 2;
 private bool hasAnimationState;
 private Int32 AnimationState_ = 0;
 public bool HasAnimationState {
 get { return hasAnimationState; }
 }
 public Int32 AnimationState {
 get { return AnimationState_; }
 set { SetAnimationState(value); }
 }
 public void SetAnimationState(Int32 value) { 
 hasAnimationState = true;
 AnimationState_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasAnimationState) {
size += pb::CodedOutputStream.ComputeInt32Size(2, AnimationState);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasAnimationState) {
output.WriteInt32(2, AnimationState);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_ANIMATION_STATE _inst = (GC_UPDATE_ANIMATION_STATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.AnimationState = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasAnimationState) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATE_HITPONIT : PacketDistributed
{

public const int hitponitFieldNumber = 1;
 private bool hasHitponit;
 private Int32 hitponit_ = 0;
 public bool HasHitponit {
 get { return hasHitponit; }
 }
 public Int32 Hitponit {
 get { return hitponit_; }
 set { SetHitponit(value); }
 }
 public void SetHitponit(Int32 value) { 
 hasHitponit = true;
 hitponit_ = value;
 }

public const int isCriticalFieldNumber = 2;
 private bool hasIsCritical;
 private Int32 isCritical_ = 0;
 public bool HasIsCritical {
 get { return hasIsCritical; }
 }
 public Int32 IsCritical {
 get { return isCritical_; }
 set { SetIsCritical(value); }
 }
 public void SetIsCritical(Int32 value) { 
 hasIsCritical = true;
 isCritical_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasHitponit) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Hitponit);
}
 if (HasIsCritical) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsCritical);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasHitponit) {
output.WriteInt32(1, Hitponit);
}
 
if (HasIsCritical) {
output.WriteInt32(2, IsCritical);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_HITPONIT _inst = (GC_UPDATE_HITPONIT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Hitponit = input.ReadInt32();
break;
}
   case  16: {
 _inst.IsCritical = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasHitponit) return false;
 if (!hasIsCritical) return false;
 return true;
 }

}


[Serializable]
public class GC_TELEMOVE : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int targetPosXFieldNumber = 2;
 private bool hasTargetPosX;
 private Int32 targetPosX_ = 0;
 public bool HasTargetPosX {
 get { return hasTargetPosX; }
 }
 public Int32 TargetPosX {
 get { return targetPosX_; }
 set { SetTargetPosX(value); }
 }
 public void SetTargetPosX(Int32 value) { 
 hasTargetPosX = true;
 targetPosX_ = value;
 }

public const int targetPosZFieldNumber = 3;
 private bool hasTargetPosZ;
 private Int32 targetPosZ_ = 0;
 public bool HasTargetPosZ {
 get { return hasTargetPosZ; }
 }
 public Int32 TargetPosZ {
 get { return targetPosZ_; }
 set { SetTargetPosZ(value); }
 }
 public void SetTargetPosZ(Int32 value) { 
 hasTargetPosZ = true;
 targetPosZ_ = value;
 }

public const int needChangeFacetoFieldNumber = 4;
 private bool hasNeedChangeFaceto;
 private Int32 needChangeFaceto_ = 0;
 public bool HasNeedChangeFaceto {
 get { return hasNeedChangeFaceto; }
 }
 public Int32 NeedChangeFaceto {
 get { return needChangeFaceto_; }
 set { SetNeedChangeFaceto(value); }
 }
 public void SetNeedChangeFaceto(Int32 value) { 
 hasNeedChangeFaceto = true;
 needChangeFaceto_ = value;
 }

public const int animaIdFieldNumber = 5;
 private bool hasAnimaId;
 private Int32 animaId_ = 0;
 public bool HasAnimaId {
 get { return hasAnimaId; }
 }
 public Int32 AnimaId {
 get { return animaId_; }
 set { SetAnimaId(value); }
 }
 public void SetAnimaId(Int32 value) { 
 hasAnimaId = true;
 animaId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasTargetPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(2, TargetPosX);
}
 if (HasTargetPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(3, TargetPosZ);
}
 if (HasNeedChangeFaceto) {
size += pb::CodedOutputStream.ComputeInt32Size(4, NeedChangeFaceto);
}
 if (HasAnimaId) {
size += pb::CodedOutputStream.ComputeInt32Size(5, AnimaId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasTargetPosX) {
output.WriteInt32(2, TargetPosX);
}
 
if (HasTargetPosZ) {
output.WriteInt32(3, TargetPosZ);
}
 
if (HasNeedChangeFaceto) {
output.WriteInt32(4, NeedChangeFaceto);
}
 
if (HasAnimaId) {
output.WriteInt32(5, AnimaId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_TELEMOVE _inst = (GC_TELEMOVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.TargetPosX = input.ReadInt32();
break;
}
   case  24: {
 _inst.TargetPosZ = input.ReadInt32();
break;
}
   case  32: {
 _inst.NeedChangeFaceto = input.ReadInt32();
break;
}
   case  40: {
 _inst.AnimaId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasTargetPosX) return false;
 if (!hasTargetPosZ) return false;
 if (!hasNeedChangeFaceto) return false;
 return true;
 }

}


[Serializable]
public class GC_PLAYSHANDIANLIANEFFECT : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int targetIdFieldNumber = 2;
 private bool hasTargetId;
 private Int32 targetId_ = 0;
 public bool HasTargetId {
 get { return hasTargetId; }
 }
 public Int32 TargetId {
 get { return targetId_; }
 set { SetTargetId(value); }
 }
 public void SetTargetId(Int32 value) { 
 hasTargetId = true;
 targetId_ = value;
 }

public const int effectIdFieldNumber = 3;
 private bool hasEffectId;
 private Int32 effectId_ = 0;
 public bool HasEffectId {
 get { return hasEffectId; }
 }
 public Int32 EffectId {
 get { return effectId_; }
 set { SetEffectId(value); }
 }
 public void SetEffectId(Int32 value) { 
 hasEffectId = true;
 effectId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasTargetId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, TargetId);
}
 if (HasEffectId) {
size += pb::CodedOutputStream.ComputeInt32Size(3, EffectId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasTargetId) {
output.WriteInt32(2, TargetId);
}
 
if (HasEffectId) {
output.WriteInt32(3, EffectId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_PLAYSHANDIANLIANEFFECT _inst = (GC_PLAYSHANDIANLIANEFFECT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.TargetId = input.ReadInt32();
break;
}
   case  24: {
 _inst.EffectId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasTargetId) return false;
 if (!hasEffectId) return false;
 return true;
 }

}


[Serializable]
public class GC_REMOVEEFFECT : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int effectIdFieldNumber = 2;
 private bool hasEffectId;
 private Int32 effectId_ = 0;
 public bool HasEffectId {
 get { return hasEffectId; }
 }
 public Int32 EffectId {
 get { return effectId_; }
 set { SetEffectId(value); }
 }
 public void SetEffectId(Int32 value) { 
 hasEffectId = true;
 effectId_ = value;
 }

public const int startMotionIDFieldNumber = 3;
 private bool hasStartMotionID;
 private Int32 startMotionID_ = 0;
 public bool HasStartMotionID {
 get { return hasStartMotionID; }
 }
 public Int32 StartMotionID {
 get { return startMotionID_; }
 set { SetStartMotionID(value); }
 }
 public void SetStartMotionID(Int32 value) { 
 hasStartMotionID = true;
 startMotionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasEffectId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, EffectId);
}
 if (HasStartMotionID) {
size += pb::CodedOutputStream.ComputeInt32Size(3, StartMotionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasEffectId) {
output.WriteInt32(2, EffectId);
}
 
if (HasStartMotionID) {
output.WriteInt32(3, StartMotionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_REMOVEEFFECT _inst = (GC_REMOVEEFFECT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.EffectId = input.ReadInt32();
break;
}
   case  24: {
 _inst.StartMotionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasEffectId) return false;
 if (!hasStartMotionID) return false;
 return true;
 }

}


[Serializable]
public class GC_ATTACKFLY : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int DisFieldNumber = 2;
 private bool hasDis;
 private Int32 Dis_ = 0;
 public bool HasDis {
 get { return hasDis; }
 }
 public Int32 Dis {
 get { return Dis_; }
 set { SetDis(value); }
 }
 public void SetDis(Int32 value) { 
 hasDis = true;
 Dis_ = value;
 }

public const int HightFieldNumber = 3;
 private bool hasHight;
 private Int32 Hight_ = 0;
 public bool HasHight {
 get { return hasHight; }
 }
 public Int32 Hight {
 get { return Hight_; }
 set { SetHight(value); }
 }
 public void SetHight(Int32 value) { 
 hasHight = true;
 Hight_ = value;
 }

public const int FlyTimeFieldNumber = 4;
 private bool hasFlyTime;
 private Int32 FlyTime_ = 0;
 public bool HasFlyTime {
 get { return hasFlyTime; }
 }
 public Int32 FlyTime {
 get { return FlyTime_; }
 set { SetFlyTime(value); }
 }
 public void SetFlyTime(Int32 value) { 
 hasFlyTime = true;
 FlyTime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
 if (HasDis) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Dis);
}
 if (HasHight) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Hight);
}
 if (HasFlyTime) {
size += pb::CodedOutputStream.ComputeInt32Size(4, FlyTime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
 
if (HasDis) {
output.WriteInt32(2, Dis);
}
 
if (HasHight) {
output.WriteInt32(3, Hight);
}
 
if (HasFlyTime) {
output.WriteInt32(4, FlyTime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ATTACKFLY _inst = (GC_ATTACKFLY) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.Dis = input.ReadInt32();
break;
}
   case  24: {
 _inst.Hight = input.ReadInt32();
break;
}
   case  32: {
 _inst.FlyTime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 if (!hasDis) return false;
 if (!hasHight) return false;
 if (!hasFlyTime) return false;
 return true;
 }

}


[Serializable]
public class GC_COUNTDOWN : PacketDistributed
{

public const int CountDownSecondFieldNumber = 1;
 private bool hasCountDownSecond;
 private Int32 CountDownSecond_ = 0;
 public bool HasCountDownSecond {
 get { return hasCountDownSecond; }
 }
 public Int32 CountDownSecond {
 get { return CountDownSecond_; }
 set { SetCountDownSecond(value); }
 }
 public void SetCountDownSecond(Int32 value) { 
 hasCountDownSecond = true;
 CountDownSecond_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCountDownSecond) {
size += pb::CodedOutputStream.ComputeInt32Size(1, CountDownSecond);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCountDownSecond) {
output.WriteInt32(1, CountDownSecond);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_COUNTDOWN _inst = (GC_COUNTDOWN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.CountDownSecond = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCountDownSecond) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_LEVELUPSKILL : PacketDistributed
{

public const int SkillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 SkillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return SkillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 SkillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_LEVELUPSKILL _inst = (CG_ASK_LEVELUPSKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class CG_BACKPACK_UNLOCK : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BACKPACK_UNLOCK _inst = (CG_BACKPACK_UNLOCK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class GC_BACKPACK_RESIZE : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int sizeFieldNumber = 2;
 private bool hasSize;
 private Int32 size_ = 0;
 public bool HasSize {
 get { return hasSize; }
 }
 public Int32 Size {
 get { return size_; }
 set { SetSize(value); }
 }
 public void SetSize(Int32 value) { 
 hasSize = true;
 size_ = value;
 }

public const int packtypeFieldNumber = 3;
 private bool hasPacktype;
 private Int32 packtype_ = 0;
 public bool HasPacktype {
 get { return hasPacktype; }
 }
 public Int32 Packtype {
 get { return packtype_; }
 set { SetPacktype(value); }
 }
 public void SetPacktype(Int32 value) { 
 hasPacktype = true;
 packtype_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 if (HasSize) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Size);
}
 if (HasPacktype) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Packtype);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 
if (HasSize) {
output.WriteInt32(2, Size);
}
 
if (HasPacktype) {
output.WriteInt32(3, Packtype);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_BACKPACK_RESIZE _inst = (GC_BACKPACK_RESIZE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}
   case  16: {
 _inst.Size = input.ReadInt32();
break;
}
   case  24: {
 _inst.Packtype = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 if (!hasSize) return false;
 if (!hasPacktype) return false;
 return true;
 }

}


[Serializable]
public class GC_USE_ITEM_RET : PacketDistributed
{

public const int successFieldNumber = 1;
 private bool hasSuccess;
 private Int32 success_ = 0;
 public bool HasSuccess {
 get { return hasSuccess; }
 }
 public Int32 Success {
 get { return success_; }
 set { SetSuccess(value); }
 }
 public void SetSuccess(Int32 value) { 
 hasSuccess = true;
 success_ = value;
 }

public const int dataidFieldNumber = 2;
 private bool hasDataid;
 private Int32 dataid_ = 0;
 public bool HasDataid {
 get { return hasDataid; }
 }
 public Int32 Dataid {
 get { return dataid_; }
 set { SetDataid(value); }
 }
 public void SetDataid(Int32 value) { 
 hasDataid = true;
 dataid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSuccess) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Success);
}
 if (HasDataid) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Dataid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSuccess) {
output.WriteInt32(1, Success);
}
 
if (HasDataid) {
output.WriteInt32(2, Dataid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_USE_ITEM_RET _inst = (GC_USE_ITEM_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Success = input.ReadInt32();
break;
}
   case  16: {
 _inst.Dataid = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSuccess) return false;
 if (!hasDataid) return false;
 return true;
 }

}


[Serializable]
public class GC_USERTIP : PacketDistributed
{
public enum TipType 
 { 
  TIP_YUANBAO_NOTENOUGH = 0, // Ԫ������ 
 }
public const int tipFieldNumber = 1;
 private bool hasTip;
 private Int32 tip_ = 0;
 public bool HasTip {
 get { return hasTip; }
 }
 public Int32 Tip {
 get { return tip_; }
 set { SetTip(value); }
 }
 public void SetTip(Int32 value) { 
 hasTip = true;
 tip_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTip) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Tip);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTip) {
output.WriteInt32(1, Tip);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_USERTIP _inst = (GC_USERTIP) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Tip = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTip) return false;
 return true;
 }

}


[Serializable]
public class CG_MONEYTREE_ASKAWARD : PacketDistributed
{

public const int CurTurnIDFieldNumber = 1;
 private bool hasCurTurnID;
 private Int32 CurTurnID_ = 0;
 public bool HasCurTurnID {
 get { return hasCurTurnID; }
 }
 public Int32 CurTurnID {
 get { return CurTurnID_; }
 set { SetCurTurnID(value); }
 }
 public void SetCurTurnID(Int32 value) { 
 hasCurTurnID = true;
 CurTurnID_ = value;
 }

public const int AwardCountFieldNumber = 2;
 private bool hasAwardCount;
 private Int32 AwardCount_ = 0;
 public bool HasAwardCount {
 get { return hasAwardCount; }
 }
 public Int32 AwardCount {
 get { return AwardCount_; }
 set { SetAwardCount(value); }
 }
 public void SetAwardCount(Int32 value) { 
 hasAwardCount = true;
 AwardCount_ = value;
 }

public const int AwardTypeFieldNumber = 3;
 private bool hasAwardType;
 private Int32 AwardType_ = 0;
 public bool HasAwardType {
 get { return hasAwardType; }
 }
 public Int32 AwardType {
 get { return AwardType_; }
 set { SetAwardType(value); }
 }
 public void SetAwardType(Int32 value) { 
 hasAwardType = true;
 AwardType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCurTurnID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, CurTurnID);
}
 if (HasAwardCount) {
size += pb::CodedOutputStream.ComputeInt32Size(2, AwardCount);
}
 if (HasAwardType) {
size += pb::CodedOutputStream.ComputeInt32Size(3, AwardType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCurTurnID) {
output.WriteInt32(1, CurTurnID);
}
 
if (HasAwardCount) {
output.WriteInt32(2, AwardCount);
}
 
if (HasAwardType) {
output.WriteInt32(3, AwardType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MONEYTREE_ASKAWARD _inst = (CG_MONEYTREE_ASKAWARD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.CurTurnID = input.ReadInt32();
break;
}
   case  16: {
 _inst.AwardCount = input.ReadInt32();
break;
}
   case  24: {
 _inst.AwardType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurTurnID) return false;
 if (!hasAwardCount) return false;
 if (!hasAwardType) return false;
 return true;
 }

}


[Serializable]
public class GC_MONEYTREE_DATA : PacketDistributed
{

public const int CurTurnIDFieldNumber = 1;
 private bool hasCurTurnID;
 private Int32 CurTurnID_ = 0;
 public bool HasCurTurnID {
 get { return hasCurTurnID; }
 }
 public Int32 CurTurnID {
 get { return CurTurnID_; }
 set { SetCurTurnID(value); }
 }
 public void SetCurTurnID(Int32 value) { 
 hasCurTurnID = true;
 CurTurnID_ = value;
 }

public const int AwardCDTimeFieldNumber = 2;
 private bool hasAwardCDTime;
 private Int32 AwardCDTime_ = 0;
 public bool HasAwardCDTime {
 get { return hasAwardCDTime; }
 }
 public Int32 AwardCDTime {
 get { return AwardCDTime_; }
 set { SetAwardCDTime(value); }
 }
 public void SetAwardCDTime(Int32 value) { 
 hasAwardCDTime = true;
 AwardCDTime_ = value;
 }

public const int retFieldNumber = 3;
 private bool hasRet;
 private Int32 ret_ = 0;
 public bool HasRet {
 get { return hasRet; }
 }
 public Int32 Ret {
 get { return ret_; }
 set { SetRet(value); }
 }
 public void SetRet(Int32 value) { 
 hasRet = true;
 ret_ = value;
 }

public const int YuanBaoCountFieldNumber = 4;
 private bool hasYuanBaoCount;
 private Int32 YuanBaoCount_ = 0;
 public bool HasYuanBaoCount {
 get { return hasYuanBaoCount; }
 }
 public Int32 YuanBaoCount {
 get { return YuanBaoCount_; }
 set { SetYuanBaoCount(value); }
 }
 public void SetYuanBaoCount(Int32 value) { 
 hasYuanBaoCount = true;
 YuanBaoCount_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCurTurnID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, CurTurnID);
}
 if (HasAwardCDTime) {
size += pb::CodedOutputStream.ComputeInt32Size(2, AwardCDTime);
}
 if (HasRet) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Ret);
}
 if (HasYuanBaoCount) {
size += pb::CodedOutputStream.ComputeInt32Size(4, YuanBaoCount);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCurTurnID) {
output.WriteInt32(1, CurTurnID);
}
 
if (HasAwardCDTime) {
output.WriteInt32(2, AwardCDTime);
}
 
if (HasRet) {
output.WriteInt32(3, Ret);
}
 
if (HasYuanBaoCount) {
output.WriteInt32(4, YuanBaoCount);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MONEYTREE_DATA _inst = (GC_MONEYTREE_DATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.CurTurnID = input.ReadInt32();
break;
}
   case  16: {
 _inst.AwardCDTime = input.ReadInt32();
break;
}
   case  24: {
 _inst.Ret = input.ReadInt32();
break;
}
   case  32: {
 _inst.YuanBaoCount = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurTurnID) return false;
 if (!hasAwardCDTime) return false;
 if (!hasRet) return false;
 if (!hasYuanBaoCount) return false;
 return true;
 }

}


[Serializable]
public class CG_CHANGE_MAJORCITY : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CHANGE_MAJORCITY _inst = (CG_CHANGE_MAJORCITY) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_QUIT_GAME : PacketDistributed
{
public enum GameSelecTType 
 { 
  GAMESELECTTYPE_QUIT= 0,   // �˳���Ϸ 
  GAMESELECTTYPE_ACCOUNT= 1, // �û�ѡ�� 
  GAMESELECTTYPE_ROLE= 2,   // ��ɫѡ�� 
 }
public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_QUIT_GAME _inst = (CG_ASK_QUIT_GAME) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_QUIT_GAME : PacketDistributed
{
public enum GameSelectType 
 { 
 
  GAMESELECTTYPE_QUIT= 0,   // �˳���Ϸ 
  GAMESELECTTYPE_ACCOUNT= 1, // �û�ѡ�� 
  GAMESELECTTYPE_ROLE= 2,   // ��ɫѡ�� 
 }
public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int resultFieldNumber = 2;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Result);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 
if (HasResult) {
output.WriteInt32(2, Result);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_QUIT_GAME _inst = (GC_RET_QUIT_GAME) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}
   case  16: {
 _inst.Result = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 if (!hasResult) return false;
 return true;
 }

}


[Serializable]
public class CG_LOCK_FELLOW : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_LOCK_FELLOW _inst = (CG_LOCK_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_UNLOCK_FELLOW : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_UNLOCK_FELLOW _inst = (CG_UNLOCK_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_RESOLVE_FELLOW : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_RESOLVE_FELLOW _inst = (CG_RESOLVE_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_RESOLVE_FELLOW_RET : PacketDistributed
{

public const int successFieldNumber = 1;
 private bool hasSuccess;
 private Int32 success_ = 0;
 public bool HasSuccess {
 get { return hasSuccess; }
 }
 public Int32 Success {
 get { return success_; }
 set { SetSuccess(value); }
 }
 public void SetSuccess(Int32 value) { 
 hasSuccess = true;
 success_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSuccess) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Success);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSuccess) {
output.WriteInt32(1, Success);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RESOLVE_FELLOW_RET _inst = (GC_RESOLVE_FELLOW_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Success = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSuccess) return false;
 return true;
 }

}


[Serializable]
public class GC_SYNC_REACHEDSCENE : PacketDistributed
{

public const int reachedSceneIDFieldNumber = 1;
 private pbc::PopsicleList<Int32> reachedSceneID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> reachedSceneIDList {
 get { return pbc::Lists.AsReadOnly(reachedSceneID_); }
 }
 
 public int reachedSceneIDCount {
 get { return reachedSceneID_.Count; }
 }
 
public Int32 GetReachedSceneID(int index) {
 return reachedSceneID_[index];
 }
 public void AddReachedSceneID(Int32 value) {
 reachedSceneID_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<reachedSceneIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(reachedSceneIDList[i]);
}
size += dataSize;
size += 1 * reachedSceneID_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (reachedSceneID_.Count > 0) {
for(int i=0; i<reachedSceneID_.Count; ++i){
output.WriteInt32(1,reachedSceneID_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_REACHEDSCENE _inst = (GC_SYNC_REACHEDSCENE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddReachedSceneID(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_UPDATE_ACTIVE_FELLOWSKILL : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int skillIdFieldNumber = 2;
 private pbc::PopsicleList<Int32> skillId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillIdList {
 get { return pbc::Lists.AsReadOnly(skillId_); }
 }
 
 public int skillIdCount {
 get { return skillId_.Count; }
 }
 
public Int32 GetSkillId(int index) {
 return skillId_[index];
 }
 public void AddSkillId(Int32 value) {
 skillId_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
{
int dataSize = 0;
for(int i=0; i<skillIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillIdList[i]);
}
size += dataSize;
size += 1 * skillId_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
{
if (skillId_.Count > 0) {
for(int i=0; i<skillId_.Count; ++i){
output.WriteInt32(2,skillId_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_ACTIVE_FELLOWSKILL _inst = (GC_UPDATE_ACTIVE_FELLOWSKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddSkillId(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class CG_EQUIP_FELLOW_SKILL : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int skillIdFieldNumber = 2;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
 if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
 
if (HasSkillId) {
output.WriteInt32(2, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_EQUIP_FELLOW_SKILL _inst = (CG_EQUIP_FELLOW_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class GC_EQUIP_FELLOW_SKILL_RET : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int skillIdFieldNumber = 2;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
 if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
 
if (HasSkillId) {
output.WriteInt32(2, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_EQUIP_FELLOW_SKILL_RET _inst = (GC_EQUIP_FELLOW_SKILL_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class CG_UNEQUIP_FELLOW_SKILL : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int skillIdFieldNumber = 2;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
 if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
 
if (HasSkillId) {
output.WriteInt32(2, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_UNEQUIP_FELLOW_SKILL _inst = (CG_UNEQUIP_FELLOW_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class GC_UNEQUIP_FELLOW_SKILL_RET : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int skillIdFieldNumber = 2;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
 if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
 
if (HasSkillId) {
output.WriteInt32(2, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UNEQUIP_FELLOW_SKILL_RET _inst = (GC_UNEQUIP_FELLOW_SKILL_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class CG_LEVELUP_FELLOW_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_LEVELUP_FELLOW_SKILL _inst = (CG_LEVELUP_FELLOW_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class GC_LEVELUP_FELLOW_SKILL_RET : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_LEVELUP_FELLOW_SKILL_RET _inst = (GC_LEVELUP_FELLOW_SKILL_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class GC_FORCE_SETPOS : PacketDistributed
{

public const int ServerIDFieldNumber = 1;
 private bool hasServerID;
 private Int32 ServerID_ = 0;
 public bool HasServerID {
 get { return hasServerID; }
 }
 public Int32 ServerID {
 get { return ServerID_; }
 set { SetServerID(value); }
 }
 public void SetServerID(Int32 value) { 
 hasServerID = true;
 ServerID_ = value;
 }

public const int PosXFieldNumber = 2;
 private bool hasPosX;
 private Int32 PosX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return PosX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 PosX_ = value;
 }

public const int PosZFieldNumber = 3;
 private bool hasPosZ;
 private Int32 PosZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return PosZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 PosZ_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasServerID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ServerID);
}
 if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(2, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(3, PosZ);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasServerID) {
output.WriteInt32(1, ServerID);
}
 
if (HasPosX) {
output.WriteInt32(2, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(3, PosZ);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_FORCE_SETPOS _inst = (GC_FORCE_SETPOS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ServerID = input.ReadInt32();
break;
}
   case  16: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  24: {
 _inst.PosZ = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasServerID) return false;
 if (!hasPosX) return false;
 if (!hasPosZ) return false;
 return true;
 }

}


[Serializable]
public class GC_DEBUG_MY_POS : PacketDistributed
{

public const int PosXFieldNumber = 1;
 private bool hasPosX;
 private Int32 PosX_ = 0;
 public bool HasPosX {
 get { return hasPosX; }
 }
 public Int32 PosX {
 get { return PosX_; }
 set { SetPosX(value); }
 }
 public void SetPosX(Int32 value) { 
 hasPosX = true;
 PosX_ = value;
 }

public const int PosZFieldNumber = 2;
 private bool hasPosZ;
 private Int32 PosZ_ = 0;
 public bool HasPosZ {
 get { return hasPosZ; }
 }
 public Int32 PosZ {
 get { return PosZ_; }
 set { SetPosZ(value); }
 }
 public void SetPosZ(Int32 value) { 
 hasPosZ = true;
 PosZ_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPosX) {
size += pb::CodedOutputStream.ComputeInt32Size(1, PosX);
}
 if (HasPosZ) {
size += pb::CodedOutputStream.ComputeInt32Size(2, PosZ);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPosX) {
output.WriteInt32(1, PosX);
}
 
if (HasPosZ) {
output.WriteInt32(2, PosZ);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DEBUG_MY_POS _inst = (GC_DEBUG_MY_POS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.PosX = input.ReadInt32();
break;
}
   case  16: {
 _inst.PosZ = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPosX) return false;
 if (!hasPosZ) return false;
 return true;
 }

}


[Serializable]
public class GC_PLAY_SOUNDS : PacketDistributed
{
public enum SOUNDTYPE 
 { 
  SOUND_EFFECT  = 1, //��Ч 
  SOUND_SCENE = 2, //������������ 
 }
public const int SoundIDFieldNumber = 1;
 private bool hasSoundID;
 private Int32 SoundID_ = 0;
 public bool HasSoundID {
 get { return hasSoundID; }
 }
 public Int32 SoundID {
 get { return SoundID_; }
 set { SetSoundID(value); }
 }
 public void SetSoundID(Int32 value) { 
 hasSoundID = true;
 SoundID_ = value;
 }

public const int SoundTypeFieldNumber = 2;
 private bool hasSoundType;
 private Int32 SoundType_ = 0;
 public bool HasSoundType {
 get { return hasSoundType; }
 }
 public Int32 SoundType {
 get { return SoundType_; }
 set { SetSoundType(value); }
 }
 public void SetSoundType(Int32 value) { 
 hasSoundType = true;
 SoundType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSoundID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SoundID);
}
 if (HasSoundType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, SoundType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSoundID) {
output.WriteInt32(1, SoundID);
}
 
if (HasSoundType) {
output.WriteInt32(2, SoundType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_PLAY_SOUNDS _inst = (GC_PLAY_SOUNDS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SoundID = input.ReadInt32();
break;
}
   case  16: {
 _inst.SoundType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSoundID) return false;
 if (!hasSoundType) return false;
 return true;
 }

}


[Serializable]
public class CG_DAILYMISSION_UPDATE : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_DAILYMISSION_UPDATE _inst = (CG_DAILYMISSION_UPDATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 return true;
 }

}


[Serializable]
public class GC_DAILYMISSION_UPDATE_RET : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int donecountFieldNumber = 2;
 private bool hasDonecount;
 private Int32 donecount_ = 0;
 public bool HasDonecount {
 get { return hasDonecount; }
 }
 public Int32 Donecount {
 get { return donecount_; }
 set { SetDonecount(value); }
 }
 public void SetDonecount(Int32 value) { 
 hasDonecount = true;
 donecount_ = value;
 }

public const int missionIDFieldNumber = 3;
 private pbc::PopsicleList<Int32> missionID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> missionIDList {
 get { return pbc::Lists.AsReadOnly(missionID_); }
 }
 
 public int missionIDCount {
 get { return missionID_.Count; }
 }
 
public Int32 GetMissionID(int index) {
 return missionID_[index];
 }
 public void AddMissionID(Int32 value) {
 missionID_.Add(value);
 }

public const int qualityTypeFieldNumber = 4;
 private pbc::PopsicleList<Int32> qualityType_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> qualityTypeList {
 get { return pbc::Lists.AsReadOnly(qualityType_); }
 }
 
 public int qualityTypeCount {
 get { return qualityType_.Count; }
 }
 
public Int32 GetQualityType(int index) {
 return qualityType_[index];
 }
 public void AddQualityType(Int32 value) {
 qualityType_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Type);
}
 if (HasDonecount) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Donecount);
}
{
int dataSize = 0;
for(int i=0; i<missionIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(missionIDList[i]);
}
size += dataSize;
size += 1 * missionID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<qualityTypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(qualityTypeList[i]);
}
size += dataSize;
size += 1 * qualityType_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasType) {
output.WriteInt32(1, Type);
}
 
if (HasDonecount) {
output.WriteInt32(2, Donecount);
}
{
if (missionID_.Count > 0) {
for(int i=0; i<missionID_.Count; ++i){
output.WriteInt32(3,missionID_[i]);
}
}

}
{
if (qualityType_.Count > 0) {
for(int i=0; i<qualityType_.Count; ++i){
output.WriteInt32(4,qualityType_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DAILYMISSION_UPDATE_RET _inst = (GC_DAILYMISSION_UPDATE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Type = input.ReadInt32();
break;
}
   case  16: {
 _inst.Donecount = input.ReadInt32();
break;
}
   case  24: {
 _inst.AddMissionID(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddQualityType(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasType) return false;
 if (!hasDonecount) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_LOUDSPEAKER_POOL : PacketDistributed
{

public const int SpeakerNumFieldNumber = 1;
 private bool hasSpeakerNum;
 private Int32 SpeakerNum_ = 0;
 public bool HasSpeakerNum {
 get { return hasSpeakerNum; }
 }
 public Int32 SpeakerNum {
 get { return SpeakerNum_; }
 set { SetSpeakerNum(value); }
 }
 public void SetSpeakerNum(Int32 value) { 
 hasSpeakerNum = true;
 SpeakerNum_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSpeakerNum) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SpeakerNum);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSpeakerNum) {
output.WriteInt32(1, SpeakerNum);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_LOUDSPEAKER_POOL _inst = (CG_ASK_LOUDSPEAKER_POOL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SpeakerNum = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSpeakerNum) return false;
 return true;
 }

}


[Serializable]
public class GC_ASK_LOUDSPEAKER_CONTENT : PacketDistributed
{

public const int NoneParamFieldNumber = 1;
 private bool hasNoneParam;
 private Int32 NoneParam_ = 0;
 public bool HasNoneParam {
 get { return hasNoneParam; }
 }
 public Int32 NoneParam {
 get { return NoneParam_; }
 set { SetNoneParam(value); }
 }
 public void SetNoneParam(Int32 value) { 
 hasNoneParam = true;
 NoneParam_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNoneParam) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NoneParam);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNoneParam) {
output.WriteInt32(1, NoneParam);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ASK_LOUDSPEAKER_CONTENT _inst = (GC_ASK_LOUDSPEAKER_CONTENT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NoneParam = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNoneParam) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_GAIN_FELLOW : PacketDistributed
{

public const int gainTypeeFieldNumber = 1;
 private bool hasGainTypee;
 private Int32 gainTypee_ = 0;
 public bool HasGainTypee {
 get { return hasGainTypee; }
 }
 public Int32 GainTypee {
 get { return gainTypee_; }
 set { SetGainTypee(value); }
 }
 public void SetGainTypee(Int32 value) { 
 hasGainTypee = true;
 gainTypee_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGainTypee) {
size += pb::CodedOutputStream.ComputeInt32Size(1, GainTypee);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGainTypee) {
output.WriteInt32(1, GainTypee);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_GAIN_FELLOW _inst = (CG_ASK_GAIN_FELLOW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GainTypee = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGainTypee) return false;
 return true;
 }

}


[Serializable]
public class GC_ASK_GAIN_FELLOW_RET : PacketDistributed
{

public const int fellowidFieldNumber = 1;
 private bool hasFellowid;
 private Int32 fellowid_ = 0;
 public bool HasFellowid {
 get { return hasFellowid; }
 }
 public Int32 Fellowid {
 get { return fellowid_; }
 set { SetFellowid(value); }
 }
 public void SetFellowid(Int32 value) { 
 hasFellowid = true;
 fellowid_ = value;
 }

public const int fellowguidFieldNumber = 2;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int fellowstarlevelFieldNumber = 3;
 private bool hasFellowstarlevel;
 private Int32 fellowstarlevel_ = 0;
 public bool HasFellowstarlevel {
 get { return hasFellowstarlevel; }
 }
 public Int32 Fellowstarlevel {
 get { return fellowstarlevel_; }
 set { SetFellowstarlevel(value); }
 }
 public void SetFellowstarlevel(Int32 value) { 
 hasFellowstarlevel = true;
 fellowstarlevel_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowid) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Fellowid);
}
 if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Fellowguid);
}
 if (HasFellowstarlevel) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Fellowstarlevel);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowid) {
output.WriteInt32(1, Fellowid);
}
 
if (HasFellowguid) {
output.WriteUInt64(2, Fellowguid);
}
 
if (HasFellowstarlevel) {
output.WriteInt32(3, Fellowstarlevel);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ASK_GAIN_FELLOW_RET _inst = (GC_ASK_GAIN_FELLOW_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowid = input.ReadInt32();
break;
}
   case  16: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  24: {
 _inst.Fellowstarlevel = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowid) return false;
 if (!hasFellowguid) return false;
 if (!hasFellowstarlevel) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATE_GAIN_FELLOW_COUNT : PacketDistributed
{

public const int normalCountFieldNumber = 1;
 private bool hasNormalCount;
 private Int32 normalCount_ = 0;
 public bool HasNormalCount {
 get { return hasNormalCount; }
 }
 public Int32 NormalCount {
 get { return normalCount_; }
 set { SetNormalCount(value); }
 }
 public void SetNormalCount(Int32 value) { 
 hasNormalCount = true;
 normalCount_ = value;
 }

public const int yuanbaoCountFieldNumber = 2;
 private bool hasYuanbaoCount;
 private Int32 yuanbaoCount_ = 0;
 public bool HasYuanbaoCount {
 get { return hasYuanbaoCount; }
 }
 public Int32 YuanbaoCount {
 get { return yuanbaoCount_; }
 set { SetYuanbaoCount(value); }
 }
 public void SetYuanbaoCount(Int32 value) { 
 hasYuanbaoCount = true;
 yuanbaoCount_ = value;
 }

public const int normalCDFieldNumber = 3;
 private bool hasNormalCD;
 private Int32 normalCD_ = 0;
 public bool HasNormalCD {
 get { return hasNormalCD; }
 }
 public Int32 NormalCD {
 get { return normalCD_; }
 set { SetNormalCD(value); }
 }
 public void SetNormalCD(Int32 value) { 
 hasNormalCD = true;
 normalCD_ = value;
 }

public const int freeCountFieldNumber = 4;
 private bool hasFreeCount;
 private Int32 freeCount_ = 0;
 public bool HasFreeCount {
 get { return hasFreeCount; }
 }
 public Int32 FreeCount {
 get { return freeCount_; }
 set { SetFreeCount(value); }
 }
 public void SetFreeCount(Int32 value) { 
 hasFreeCount = true;
 freeCount_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNormalCount) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NormalCount);
}
 if (HasYuanbaoCount) {
size += pb::CodedOutputStream.ComputeInt32Size(2, YuanbaoCount);
}
 if (HasNormalCD) {
size += pb::CodedOutputStream.ComputeInt32Size(3, NormalCD);
}
 if (HasFreeCount) {
size += pb::CodedOutputStream.ComputeInt32Size(4, FreeCount);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNormalCount) {
output.WriteInt32(1, NormalCount);
}
 
if (HasYuanbaoCount) {
output.WriteInt32(2, YuanbaoCount);
}
 
if (HasNormalCD) {
output.WriteInt32(3, NormalCD);
}
 
if (HasFreeCount) {
output.WriteInt32(4, FreeCount);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_GAIN_FELLOW_COUNT _inst = (GC_UPDATE_GAIN_FELLOW_COUNT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NormalCount = input.ReadInt32();
break;
}
   case  16: {
 _inst.YuanbaoCount = input.ReadInt32();
break;
}
   case  24: {
 _inst.NormalCD = input.ReadInt32();
break;
}
   case  32: {
 _inst.FreeCount = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNormalCount) return false;
 if (!hasYuanbaoCount) return false;
 if (!hasNormalCD) return false;
 if (!hasFreeCount) return false;
 return true;
 }

}


[Serializable]
public class CG_HUASHAN_PVP_REGISTER : PacketDistributed
{

public const int noneFieldNumber = 1;
 private bool hasNone;
 private Int32 none_ = 0;
 public bool HasNone {
 get { return hasNone; }
 }
 public Int32 None {
 get { return none_; }
 set { SetNone(value); }
 }
 public void SetNone(Int32 value) { 
 hasNone = true;
 none_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNone) {
size += pb::CodedOutputStream.ComputeInt32Size(1, None);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNone) {
output.WriteInt32(1, None);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_HUASHAN_PVP_REGISTER _inst = (CG_HUASHAN_PVP_REGISTER) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.None = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNone) return false;
 return true;
 }

}


[Serializable]
public class CG_HUASHAN_PVP_MEMBERLIST : PacketDistributed
{

public const int noneFieldNumber = 1;
 private bool hasNone;
 private Int32 none_ = 0;
 public bool HasNone {
 get { return hasNone; }
 }
 public Int32 None {
 get { return none_; }
 set { SetNone(value); }
 }
 public void SetNone(Int32 value) { 
 hasNone = true;
 none_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNone) {
size += pb::CodedOutputStream.ComputeInt32Size(1, None);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNone) {
output.WriteInt32(1, None);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_HUASHAN_PVP_MEMBERLIST _inst = (CG_HUASHAN_PVP_MEMBERLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.None = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNone) return false;
 return true;
 }

}


[Serializable]
public class GC_HUASHAN_PVP_MEMBERLIST : PacketDistributed
{

public const int selfPosFieldNumber = 1;
 private bool hasSelfPos;
 private Int32 selfPos_ = 0;
 public bool HasSelfPos {
 get { return hasSelfPos; }
 }
 public Int32 SelfPos {
 get { return selfPos_; }
 set { SetSelfPos(value); }
 }
 public void SetSelfPos(Int32 value) { 
 hasSelfPos = true;
 selfPos_ = value;
 }

public const int combatnumFieldNumber = 2;
 private pbc::PopsicleList<Int32> combatnum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> combatnumList {
 get { return pbc::Lists.AsReadOnly(combatnum_); }
 }
 
 public int combatnumCount {
 get { return combatnum_.Count; }
 }
 
public Int32 GetCombatnum(int index) {
 return combatnum_[index];
 }
 public void AddCombatnum(Int32 value) {
 combatnum_.Add(value);
 }

public const int levelFieldNumber = 3;
 private pbc::PopsicleList<Int32> level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> levelList {
 get { return pbc::Lists.AsReadOnly(level_); }
 }
 
 public int levelCount {
 get { return level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return level_[index];
 }
 public void AddLevel(Int32 value) {
 level_.Add(value);
 }

public const int professionFieldNumber = 4;
 private pbc::PopsicleList<Int32> profession_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> professionList {
 get { return pbc::Lists.AsReadOnly(profession_); }
 }
 
 public int professionCount {
 get { return profession_.Count; }
 }
 
public Int32 GetProfession(int index) {
 return profession_[index];
 }
 public void AddProfession(Int32 value) {
 profession_.Add(value);
 }

public const int posFieldNumber = 5;
 private pbc::PopsicleList<Int32> pos_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posList {
 get { return pbc::Lists.AsReadOnly(pos_); }
 }
 
 public int posCount {
 get { return pos_.Count; }
 }
 
public Int32 GetPos(int index) {
 return pos_[index];
 }
 public void AddPos(Int32 value) {
 pos_.Add(value);
 }

public const int nameFieldNumber = 6;
 private pbc::PopsicleList<string> name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> nameList {
 get { return pbc::Lists.AsReadOnly(name_); }
 }
 
 public int nameCount {
 get { return name_.Count; }
 }
 
public string GetName(int index) {
 return name_[index];
 }
 public void AddName(string value) {
 name_.Add(value);
 }

public const int guidFieldNumber = 7;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSelfPos) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SelfPos);
}
{
int dataSize = 0;
for(int i=0; i<combatnumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(combatnumList[i]);
}
size += dataSize;
size += 1 * combatnum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<levelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(levelList[i]);
}
size += dataSize;
size += 1 * level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<professionList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(professionList[i]);
}
size += dataSize;
size += 1 * profession_.Count;
}
{
int dataSize = 0;
for(int i=0; i<posList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posList[i]);
}
size += dataSize;
size += 1 * pos_.Count;
}
{
int dataSize = 0;
for(int i=0; i<nameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(nameList[i]);
}
size += dataSize;
size += 1 * name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSelfPos) {
output.WriteInt32(1, SelfPos);
}
{
if (combatnum_.Count > 0) {
for(int i=0; i<combatnum_.Count; ++i){
output.WriteInt32(2,combatnum_[i]);
}
}

}
{
if (level_.Count > 0) {
for(int i=0; i<level_.Count; ++i){
output.WriteInt32(3,level_[i]);
}
}

}
{
if (profession_.Count > 0) {
for(int i=0; i<profession_.Count; ++i){
output.WriteInt32(4,profession_[i]);
}
}

}
{
if (pos_.Count > 0) {
for(int i=0; i<pos_.Count; ++i){
output.WriteInt32(5,pos_[i]);
}
}

}
{
if (name_.Count > 0) {
for(int i=0; i<name_.Count; ++i){
output.WriteString(6,name_[i]);
}
}

}
{
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(7,guid_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_HUASHAN_PVP_MEMBERLIST _inst = (GC_HUASHAN_PVP_MEMBERLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SelfPos = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddCombatnum(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddProfession(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddPos(input.ReadInt32());
break;
}
   case  50: {
 _inst.AddName(input.ReadString());
break;
}
   case  56: {
 _inst.AddGuid(input.ReadUInt64());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSelfPos) return false;
 return true;
 }

}


[Serializable]
public class GC_HUASHAN_PVP_STATE : PacketDistributed
{
public enum HSPVPSTATE 
 { 
  CLOSED = 0, //δ���� 
  WIN    = 1, //ʤ�� 
  LOSE = 2, //ʧ�� 
  LUCKDOG = 3, //ֱ�ӽ��� 
  FINISH = 4, //���� 
  WAITFOR = 5, //�ȴ��������ҽ��븱�� 
  REGISTER= 6, //����ע�� 
  KICKED = 7, //������ 
  MAKEEFF = 8, //�б����������һ������ 
  REGISTERED=9,//�Ѿ�ע�� 
  WAITNEXTROUND=10,//�ȴ���һ�� 
  SEARCH=11,//��ʾƥ����ֽ׶� 
  OPPVIEW=12,//Ԥ���׶� 
  REGOK=13,//ע��ɹ� 
  START=14,//�Ѿ���ʼ 
 }
public const int stateFieldNumber = 1;
 private bool hasState;
 private Int32 state_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return state_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 state_ = value;
 }

public const int rounderFieldNumber = 2;
 private bool hasRounder;
 private Int32 rounder_ = 0;
 public bool HasRounder {
 get { return hasRounder; }
 }
 public Int32 Rounder {
 get { return rounder_; }
 set { SetRounder(value); }
 }
 public void SetRounder(Int32 value) { 
 hasRounder = true;
 rounder_ = value;
 }

public const int positionFieldNumber = 3;
 private bool hasPosition;
 private Int32 position_ = 0;
 public bool HasPosition {
 get { return hasPosition; }
 }
 public Int32 Position {
 get { return position_; }
 set { SetPosition(value); }
 }
 public void SetPosition(Int32 value) { 
 hasPosition = true;
 position_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(1, State);
}
 if (HasRounder) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Rounder);
}
 if (HasPosition) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Position);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasState) {
output.WriteInt32(1, State);
}
 
if (HasRounder) {
output.WriteInt32(2, Rounder);
}
 
if (HasPosition) {
output.WriteInt32(3, Position);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_HUASHAN_PVP_STATE _inst = (GC_HUASHAN_PVP_STATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.State = input.ReadInt32();
break;
}
   case  16: {
 _inst.Rounder = input.ReadInt32();
break;
}
   case  24: {
 _inst.Position = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasState) return false;
 if (!hasRounder) return false;
 return true;
 }

}


[Serializable]
public class GC_HUASHAN_PVP_SELFPOSITION : PacketDistributed
{

public const int selfPosFieldNumber = 1;
 private bool hasSelfPos;
 private Int32 selfPos_ = 0;
 public bool HasSelfPos {
 get { return hasSelfPos; }
 }
 public Int32 SelfPos {
 get { return selfPos_; }
 set { SetSelfPos(value); }
 }
 public void SetSelfPos(Int32 value) { 
 hasSelfPos = true;
 selfPos_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSelfPos) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SelfPos);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSelfPos) {
output.WriteInt32(1, SelfPos);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_HUASHAN_PVP_SELFPOSITION _inst = (GC_HUASHAN_PVP_SELFPOSITION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SelfPos = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSelfPos) return false;
 return true;
 }

}


[Serializable]
public class GC_HUASHAN_PVP_ShowSearch : PacketDistributed
{

public const int continueSecondFieldNumber = 1;
 private bool hasContinueSecond;
 private Int32 continueSecond_ = 0;
 public bool HasContinueSecond {
 get { return hasContinueSecond; }
 }
 public Int32 ContinueSecond {
 get { return continueSecond_; }
 set { SetContinueSecond(value); }
 }
 public void SetContinueSecond(Int32 value) { 
 hasContinueSecond = true;
 continueSecond_ = value;
 }

public const int progressFieldNumber = 2;
 private bool hasProgress;
 private Int32 progress_ = 0;
 public bool HasProgress {
 get { return hasProgress; }
 }
 public Int32 Progress {
 get { return progress_; }
 set { SetProgress(value); }
 }
 public void SetProgress(Int32 value) { 
 hasProgress = true;
 progress_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasContinueSecond) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ContinueSecond);
}
 if (HasProgress) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Progress);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasContinueSecond) {
output.WriteInt32(1, ContinueSecond);
}
 
if (HasProgress) {
output.WriteInt32(2, Progress);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_HUASHAN_PVP_ShowSearch _inst = (GC_HUASHAN_PVP_ShowSearch) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ContinueSecond = input.ReadInt32();
break;
}
   case  16: {
 _inst.Progress = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasContinueSecond) return false;
 if (!hasProgress) return false;
 return true;
 }

}


[Serializable]
public class GC_HUASHAN_PVP_OPPONENTVIEW : PacketDistributed
{

public const int professionFieldNumber = 1;
 private bool hasProfession;
 private Int32 profession_ = 0;
 public bool HasProfession {
 get { return hasProfession; }
 }
 public Int32 Profession {
 get { return profession_; }
 set { SetProfession(value); }
 }
 public void SetProfession(Int32 value) { 
 hasProfession = true;
 profession_ = value;
 }

public const int combatnumFieldNumber = 2;
 private bool hasCombatnum;
 private Int32 combatnum_ = 0;
 public bool HasCombatnum {
 get { return hasCombatnum; }
 }
 public Int32 Combatnum {
 get { return combatnum_; }
 set { SetCombatnum(value); }
 }
 public void SetCombatnum(Int32 value) { 
 hasCombatnum = true;
 combatnum_ = value;
 }

public const int hpFieldNumber = 3;
 private bool hasHp;
 private Int32 hp_ = 0;
 public bool HasHp {
 get { return hasHp; }
 }
 public Int32 Hp {
 get { return hp_; }
 set { SetHp(value); }
 }
 public void SetHp(Int32 value) { 
 hasHp = true;
 hp_ = value;
 }

public const int mpFieldNumber = 4;
 private bool hasMp;
 private Int32 mp_ = 0;
 public bool HasMp {
 get { return hasMp; }
 }
 public Int32 Mp {
 get { return mp_; }
 set { SetMp(value); }
 }
 public void SetMp(Int32 value) { 
 hasMp = true;
 mp_ = value;
 }

public const int attackFieldNumber = 5;
 private bool hasAttack;
 private Int32 attack_ = 0;
 public bool HasAttack {
 get { return hasAttack; }
 }
 public Int32 Attack {
 get { return attack_; }
 set { SetAttack(value); }
 }
 public void SetAttack(Int32 value) { 
 hasAttack = true;
 attack_ = value;
 }

public const int defenseFieldNumber = 6;
 private bool hasDefense;
 private Int32 defense_ = 0;
 public bool HasDefense {
 get { return hasDefense; }
 }
 public Int32 Defense {
 get { return defense_; }
 set { SetDefense(value); }
 }
 public void SetDefense(Int32 value) { 
 hasDefense = true;
 defense_ = value;
 }

public const int criticalFieldNumber = 7;
 private bool hasCritical;
 private Int32 critical_ = 0;
 public bool HasCritical {
 get { return hasCritical; }
 }
 public Int32 Critical {
 get { return critical_; }
 set { SetCritical(value); }
 }
 public void SetCritical(Int32 value) { 
 hasCritical = true;
 critical_ = value;
 }

public const int speedFieldNumber = 8;
 private bool hasSpeed;
 private Int32 speed_ = 0;
 public bool HasSpeed {
 get { return hasSpeed; }
 }
 public Int32 Speed {
 get { return speed_; }
 set { SetSpeed(value); }
 }
 public void SetSpeed(Int32 value) { 
 hasSpeed = true;
 speed_ = value;
 }

public const int dodgeFieldNumber = 9;
 private bool hasDodge;
 private Int32 dodge_ = 0;
 public bool HasDodge {
 get { return hasDodge; }
 }
 public Int32 Dodge {
 get { return dodge_; }
 set { SetDodge(value); }
 }
 public void SetDodge(Int32 value) { 
 hasDodge = true;
 dodge_ = value;
 }

public const int nameFieldNumber = 10;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int levelFieldNumber = 11;
 private bool hasLevel;
 private Int32 level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 level_ = value;
 }

public const int posFieldNumber = 12;
 private bool hasPos;
 private Int32 pos_ = 0;
 public bool HasPos {
 get { return hasPos; }
 }
 public Int32 Pos {
 get { return pos_; }
 set { SetPos(value); }
 }
 public void SetPos(Int32 value) { 
 hasPos = true;
 pos_ = value;
 }

public const int guidFieldNumber = 13;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasProfession) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Profession);
}
 if (HasCombatnum) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Combatnum);
}
 if (HasHp) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Hp);
}
 if (HasMp) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Mp);
}
 if (HasAttack) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Attack);
}
 if (HasDefense) {
size += pb::CodedOutputStream.ComputeInt32Size(6, Defense);
}
 if (HasCritical) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Critical);
}
 if (HasSpeed) {
size += pb::CodedOutputStream.ComputeInt32Size(8, Speed);
}
 if (HasDodge) {
size += pb::CodedOutputStream.ComputeInt32Size(9, Dodge);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(10, Name);
}
 if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(11, Level);
}
 if (HasPos) {
size += pb::CodedOutputStream.ComputeInt32Size(12, Pos);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(13, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasProfession) {
output.WriteInt32(1, Profession);
}
 
if (HasCombatnum) {
output.WriteInt32(2, Combatnum);
}
 
if (HasHp) {
output.WriteInt32(3, Hp);
}
 
if (HasMp) {
output.WriteInt32(4, Mp);
}
 
if (HasAttack) {
output.WriteInt32(5, Attack);
}
 
if (HasDefense) {
output.WriteInt32(6, Defense);
}
 
if (HasCritical) {
output.WriteInt32(7, Critical);
}
 
if (HasSpeed) {
output.WriteInt32(8, Speed);
}
 
if (HasDodge) {
output.WriteInt32(9, Dodge);
}
 
if (HasName) {
output.WriteString(10, Name);
}
 
if (HasLevel) {
output.WriteInt32(11, Level);
}
 
if (HasPos) {
output.WriteInt32(12, Pos);
}
 
if (HasGuid) {
output.WriteUInt64(13, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_HUASHAN_PVP_OPPONENTVIEW _inst = (GC_HUASHAN_PVP_OPPONENTVIEW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Profession = input.ReadInt32();
break;
}
   case  16: {
 _inst.Combatnum = input.ReadInt32();
break;
}
   case  24: {
 _inst.Hp = input.ReadInt32();
break;
}
   case  32: {
 _inst.Mp = input.ReadInt32();
break;
}
   case  40: {
 _inst.Attack = input.ReadInt32();
break;
}
   case  48: {
 _inst.Defense = input.ReadInt32();
break;
}
   case  56: {
 _inst.Critical = input.ReadInt32();
break;
}
   case  64: {
 _inst.Speed = input.ReadInt32();
break;
}
   case  72: {
 _inst.Dodge = input.ReadInt32();
break;
}
   case  82: {
 _inst.Name = input.ReadString();
break;
}
   case  88: {
 _inst.Level = input.ReadInt32();
break;
}
   case  96: {
 _inst.Pos = input.ReadInt32();
break;
}
   case  104: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasProfession) return false;
 if (!hasCombatnum) return false;
 if (!hasHp) return false;
 if (!hasMp) return false;
 if (!hasAttack) return false;
 if (!hasDefense) return false;
 if (!hasCritical) return false;
 if (!hasSpeed) return false;
 if (!hasDodge) return false;
 if (!hasName) return false;
 if (!hasLevel) return false;
 if (!hasPos) return false;
 if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_HUASHAN_PVP_ASSIST_STATE : PacketDistributed
{

public const int stateFieldNumber = 1;
 private bool hasState;
 private Int32 state_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return state_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 state_ = value;
 }

public const int timesFieldNumber = 2;
 private bool hasTimes;
 private Int32 times_ = 0;
 public bool HasTimes {
 get { return hasTimes; }
 }
 public Int32 Times {
 get { return times_; }
 set { SetTimes(value); }
 }
 public void SetTimes(Int32 value) { 
 hasTimes = true;
 times_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(1, State);
}
 if (HasTimes) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Times);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasState) {
output.WriteInt32(1, State);
}
 
if (HasTimes) {
output.WriteInt32(2, Times);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_HUASHAN_PVP_ASSIST_STATE _inst = (GC_HUASHAN_PVP_ASSIST_STATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.State = input.ReadInt32();
break;
}
   case  16: {
 _inst.Times = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasState) return false;
 if (!hasTimes) return false;
 return true;
 }

}


[Serializable]
public class CG_HUASHAN_ASSIST_REQ : PacketDistributed
{

public const int noneFieldNumber = 1;
 private bool hasNone;
 private Int32 none_ = 0;
 public bool HasNone {
 get { return hasNone; }
 }
 public Int32 None {
 get { return none_; }
 set { SetNone(value); }
 }
 public void SetNone(Int32 value) { 
 hasNone = true;
 none_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNone) {
size += pb::CodedOutputStream.ComputeInt32Size(1, None);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNone) {
output.WriteInt32(1, None);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_HUASHAN_ASSIST_REQ _inst = (CG_HUASHAN_ASSIST_REQ) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.None = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNone) return false;
 return true;
 }

}


[Serializable]
public class CG_DUEL_REQUEST : PacketDistributed
{

public const int guidFieldNumber = 1;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuid) {
output.WriteUInt64(1, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_DUEL_REQUEST _inst = (CG_DUEL_REQUEST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_DUEL_REQUESTU : PacketDistributed
{

public const int nameFieldNumber = 1;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

public const int guidFieldNumber = 2;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(1, Name);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasName) {
output.WriteString(1, Name);
}
 
if (HasGuid) {
output.WriteUInt64(2, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DUEL_REQUESTU _inst = (GC_DUEL_REQUESTU) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.Name = input.ReadString();
break;
}
   case  16: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasName) return false;
 if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_DUEL_RESPONSE : PacketDistributed
{

public const int agreeFieldNumber = 1;
 private bool hasAgree;
 private Int32 agree_ = 0;
 public bool HasAgree {
 get { return hasAgree; }
 }
 public Int32 Agree {
 get { return agree_; }
 set { SetAgree(value); }
 }
 public void SetAgree(Int32 value) { 
 hasAgree = true;
 agree_ = value;
 }

public const int guidFieldNumber = 2;
 private bool hasGuid;
 private UInt64 guid_ = 0;
 public bool HasGuid {
 get { return hasGuid; }
 }
 public UInt64 Guid {
 get { return guid_; }
 set { SetGuid(value); }
 }
 public void SetGuid(UInt64 value) { 
 hasGuid = true;
 guid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasAgree) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Agree);
}
 if (HasGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Guid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasAgree) {
output.WriteInt32(1, Agree);
}
 
if (HasGuid) {
output.WriteUInt64(2, Guid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_DUEL_RESPONSE _inst = (CG_DUEL_RESPONSE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Agree = input.ReadInt32();
break;
}
   case  16: {
 _inst.Guid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasAgree) return false;
 if (!hasGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_DUEL_STATE : PacketDistributed
{
public enum DUELSTATE 
 { 
  WIN    = 1, 
  LOSE = 2, 
 }
public const int stateFieldNumber = 1;
 private bool hasState;
 private Int32 state_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return state_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 state_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(1, State);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasState) {
output.WriteInt32(1, State);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DUEL_STATE _inst = (GC_DUEL_STATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.State = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasState) return false;
 return true;
 }

}


[Serializable]
public class CG_MERCENARY_LIST_REQ : PacketDistributed
{

public const int sceneclassFieldNumber = 1;
 private bool hasSceneclass;
 private Int32 sceneclass_ = 0;
 public bool HasSceneclass {
 get { return hasSceneclass; }
 }
 public Int32 Sceneclass {
 get { return sceneclass_; }
 set { SetSceneclass(value); }
 }
 public void SetSceneclass(Int32 value) { 
 hasSceneclass = true;
 sceneclass_ = value;
 }

public const int diffcultFieldNumber = 2;
 private bool hasDiffcult;
 private Int32 diffcult_ = 0;
 public bool HasDiffcult {
 get { return hasDiffcult; }
 }
 public Int32 Diffcult {
 get { return diffcult_; }
 set { SetDiffcult(value); }
 }
 public void SetDiffcult(Int32 value) { 
 hasDiffcult = true;
 diffcult_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneclass) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Sceneclass);
}
 if (HasDiffcult) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Diffcult);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneclass) {
output.WriteInt32(1, Sceneclass);
}
 
if (HasDiffcult) {
output.WriteInt32(2, Diffcult);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MERCENARY_LIST_REQ _inst = (CG_MERCENARY_LIST_REQ) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Sceneclass = input.ReadInt32();
break;
}
   case  16: {
 _inst.Diffcult = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneclass) return false;
 if (!hasDiffcult) return false;
 return true;
 }

}


[Serializable]
public class GC_MERCENARY_LIST_RES : PacketDistributed
{

public const int lefttimesFieldNumber = 1;
 private bool hasLefttimes;
 private Int32 lefttimes_ = 0;
 public bool HasLefttimes {
 get { return hasLefttimes; }
 }
 public Int32 Lefttimes {
 get { return lefttimes_; }
 set { SetLefttimes(value); }
 }
 public void SetLefttimes(Int32 value) { 
 hasLefttimes = true;
 lefttimes_ = value;
 }

public const int nameFieldNumber = 2;
 private pbc::PopsicleList<string> name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> nameList {
 get { return pbc::Lists.AsReadOnly(name_); }
 }
 
 public int nameCount {
 get { return name_.Count; }
 }
 
public string GetName(int index) {
 return name_[index];
 }
 public void AddName(string value) {
 name_.Add(value);
 }

public const int costFieldNumber = 3;
 private pbc::PopsicleList<Int32> cost_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> costList {
 get { return pbc::Lists.AsReadOnly(cost_); }
 }
 
 public int costCount {
 get { return cost_.Count; }
 }
 
public Int32 GetCost(int index) {
 return cost_[index];
 }
 public void AddCost(Int32 value) {
 cost_.Add(value);
 }

public const int sourceFieldNumber = 4;
 private pbc::PopsicleList<Int32> source_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sourceList {
 get { return pbc::Lists.AsReadOnly(source_); }
 }
 
 public int sourceCount {
 get { return source_.Count; }
 }
 
public Int32 GetSource(int index) {
 return source_[index];
 }
 public void AddSource(Int32 value) {
 source_.Add(value);
 }

public const int guidFieldNumber = 5;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int professionFieldNumber = 6;
 private pbc::PopsicleList<Int32> profession_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> professionList {
 get { return pbc::Lists.AsReadOnly(profession_); }
 }
 
 public int professionCount {
 get { return profession_.Count; }
 }
 
public Int32 GetProfession(int index) {
 return profession_[index];
 }
 public void AddProfession(Int32 value) {
 profession_.Add(value);
 }

public const int levelFieldNumber = 7;
 private pbc::PopsicleList<Int32> level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> levelList {
 get { return pbc::Lists.AsReadOnly(level_); }
 }
 
 public int levelCount {
 get { return level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return level_[index];
 }
 public void AddLevel(Int32 value) {
 level_.Add(value);
 }

public const int combatFieldNumber = 8;
 private pbc::PopsicleList<Int32> combat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> combatList {
 get { return pbc::Lists.AsReadOnly(combat_); }
 }
 
 public int combatCount {
 get { return combat_.Count; }
 }
 
public Int32 GetCombat(int index) {
 return combat_[index];
 }
 public void AddCombat(Int32 value) {
 combat_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasLefttimes) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Lefttimes);
}
{
int dataSize = 0;
for(int i=0; i<nameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(nameList[i]);
}
size += dataSize;
size += 1 * name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<costList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(costList[i]);
}
size += dataSize;
size += 1 * cost_.Count;
}
{
int dataSize = 0;
for(int i=0; i<sourceList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sourceList[i]);
}
size += dataSize;
size += 1 * source_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<professionList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(professionList[i]);
}
size += dataSize;
size += 1 * profession_.Count;
}
{
int dataSize = 0;
for(int i=0; i<levelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(levelList[i]);
}
size += dataSize;
size += 1 * level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<combatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(combatList[i]);
}
size += dataSize;
size += 1 * combat_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasLefttimes) {
output.WriteInt32(1, Lefttimes);
}
{
if (name_.Count > 0) {
for(int i=0; i<name_.Count; ++i){
output.WriteString(2,name_[i]);
}
}

}
{
if (cost_.Count > 0) {
for(int i=0; i<cost_.Count; ++i){
output.WriteInt32(3,cost_[i]);
}
}

}
{
if (source_.Count > 0) {
for(int i=0; i<source_.Count; ++i){
output.WriteInt32(4,source_[i]);
}
}

}
{
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(5,guid_[i]);
}
}

}
{
if (profession_.Count > 0) {
for(int i=0; i<profession_.Count; ++i){
output.WriteInt32(6,profession_[i]);
}
}

}
{
if (level_.Count > 0) {
for(int i=0; i<level_.Count; ++i){
output.WriteInt32(7,level_[i]);
}
}

}
{
if (combat_.Count > 0) {
for(int i=0; i<combat_.Count; ++i){
output.WriteInt32(8,combat_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MERCENARY_LIST_RES _inst = (GC_MERCENARY_LIST_RES) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Lefttimes = input.ReadInt32();
break;
}
   case  18: {
 _inst.AddName(input.ReadString());
break;
}
   case  24: {
 _inst.AddCost(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddSource(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  48: {
 _inst.AddProfession(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddCombat(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasLefttimes) return false;
 return true;
 }

}


[Serializable]
public class GC_MERCENARY_LEFTTIMES : PacketDistributed
{

public const int lefttimesFieldNumber = 1;
 private bool hasLefttimes;
 private Int32 lefttimes_ = 0;
 public bool HasLefttimes {
 get { return hasLefttimes; }
 }
 public Int32 Lefttimes {
 get { return lefttimes_; }
 set { SetLefttimes(value); }
 }
 public void SetLefttimes(Int32 value) { 
 hasLefttimes = true;
 lefttimes_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasLefttimes) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Lefttimes);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasLefttimes) {
output.WriteInt32(1, Lefttimes);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MERCENARY_LEFTTIMES _inst = (GC_MERCENARY_LEFTTIMES) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Lefttimes = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasLefttimes) return false;
 return true;
 }

}


[Serializable]
public class GC_MERCENARY_EMPLOYLIST : PacketDistributed
{

public const int nameFieldNumber = 1;
 private pbc::PopsicleList<string> name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> nameList {
 get { return pbc::Lists.AsReadOnly(name_); }
 }
 
 public int nameCount {
 get { return name_.Count; }
 }
 
public string GetName(int index) {
 return name_[index];
 }
 public void AddName(string value) {
 name_.Add(value);
 }

public const int costFieldNumber = 2;
 private pbc::PopsicleList<Int32> cost_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> costList {
 get { return pbc::Lists.AsReadOnly(cost_); }
 }
 
 public int costCount {
 get { return cost_.Count; }
 }
 
public Int32 GetCost(int index) {
 return cost_[index];
 }
 public void AddCost(Int32 value) {
 cost_.Add(value);
 }

public const int sourceFieldNumber = 3;
 private pbc::PopsicleList<Int32> source_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sourceList {
 get { return pbc::Lists.AsReadOnly(source_); }
 }
 
 public int sourceCount {
 get { return source_.Count; }
 }
 
public Int32 GetSource(int index) {
 return source_[index];
 }
 public void AddSource(Int32 value) {
 source_.Add(value);
 }

public const int guidFieldNumber = 4;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int professionFieldNumber = 5;
 private pbc::PopsicleList<Int32> profession_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> professionList {
 get { return pbc::Lists.AsReadOnly(profession_); }
 }
 
 public int professionCount {
 get { return profession_.Count; }
 }
 
public Int32 GetProfession(int index) {
 return profession_[index];
 }
 public void AddProfession(Int32 value) {
 profession_.Add(value);
 }

public const int levelFieldNumber = 6;
 private pbc::PopsicleList<Int32> level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> levelList {
 get { return pbc::Lists.AsReadOnly(level_); }
 }
 
 public int levelCount {
 get { return level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return level_[index];
 }
 public void AddLevel(Int32 value) {
 level_.Add(value);
 }

public const int combatFieldNumber = 7;
 private pbc::PopsicleList<Int32> combat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> combatList {
 get { return pbc::Lists.AsReadOnly(combat_); }
 }
 
 public int combatCount {
 get { return combat_.Count; }
 }
 
public Int32 GetCombat(int index) {
 return combat_[index];
 }
 public void AddCombat(Int32 value) {
 combat_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<nameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(nameList[i]);
}
size += dataSize;
size += 1 * name_.Count;
}
{
int dataSize = 0;
for(int i=0; i<costList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(costList[i]);
}
size += dataSize;
size += 1 * cost_.Count;
}
{
int dataSize = 0;
for(int i=0; i<sourceList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sourceList[i]);
}
size += dataSize;
size += 1 * source_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<professionList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(professionList[i]);
}
size += dataSize;
size += 1 * profession_.Count;
}
{
int dataSize = 0;
for(int i=0; i<levelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(levelList[i]);
}
size += dataSize;
size += 1 * level_.Count;
}
{
int dataSize = 0;
for(int i=0; i<combatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(combatList[i]);
}
size += dataSize;
size += 1 * combat_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (name_.Count > 0) {
for(int i=0; i<name_.Count; ++i){
output.WriteString(1,name_[i]);
}
}

}
{
if (cost_.Count > 0) {
for(int i=0; i<cost_.Count; ++i){
output.WriteInt32(2,cost_[i]);
}
}

}
{
if (source_.Count > 0) {
for(int i=0; i<source_.Count; ++i){
output.WriteInt32(3,source_[i]);
}
}

}
{
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(4,guid_[i]);
}
}

}
{
if (profession_.Count > 0) {
for(int i=0; i<profession_.Count; ++i){
output.WriteInt32(5,profession_[i]);
}
}

}
{
if (level_.Count > 0) {
for(int i=0; i<level_.Count; ++i){
output.WriteInt32(6,level_[i]);
}
}

}
{
if (combat_.Count > 0) {
for(int i=0; i<combat_.Count; ++i){
output.WriteInt32(7,combat_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MERCENARY_EMPLOYLIST _inst = (GC_MERCENARY_EMPLOYLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.AddName(input.ReadString());
break;
}
   case  16: {
 _inst.AddCost(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddSource(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  40: {
 _inst.AddProfession(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddLevel(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddCombat(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_MERCENARY_REQ : PacketDistributed
{

public const int sceneclassFieldNumber = 1;
 private bool hasSceneclass;
 private Int32 sceneclass_ = 0;
 public bool HasSceneclass {
 get { return hasSceneclass; }
 }
 public Int32 Sceneclass {
 get { return sceneclass_; }
 set { SetSceneclass(value); }
 }
 public void SetSceneclass(Int32 value) { 
 hasSceneclass = true;
 sceneclass_ = value;
 }

public const int guidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int sourceFieldNumber = 3;
 private pbc::PopsicleList<Int32> source_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sourceList {
 get { return pbc::Lists.AsReadOnly(source_); }
 }
 
 public int sourceCount {
 get { return source_.Count; }
 }
 
public Int32 GetSource(int index) {
 return source_[index];
 }
 public void AddSource(Int32 value) {
 source_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneclass) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Sceneclass);
}
{
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<sourceList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sourceList[i]);
}
size += dataSize;
size += 1 * source_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneclass) {
output.WriteInt32(1, Sceneclass);
}
{
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(2,guid_[i]);
}
}

}
{
if (source_.Count > 0) {
for(int i=0; i<source_.Count; ++i){
output.WriteInt32(3,source_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MERCENARY_REQ _inst = (CG_MERCENARY_REQ) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Sceneclass = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  24: {
 _inst.AddSource(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneclass) return false;
 return true;
 }

}


[Serializable]
public class GC_WORLDBOSS_DEAD : PacketDistributed
{

public const int realHpFieldNumber = 1;
 private bool hasRealHp;
 private Int32 realHp_ = 0;
 public bool HasRealHp {
 get { return hasRealHp; }
 }
 public Int32 RealHp {
 get { return realHp_; }
 set { SetRealHp(value); }
 }
 public void SetRealHp(Int32 value) { 
 hasRealHp = true;
 realHp_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRealHp) {
size += pb::CodedOutputStream.ComputeInt32Size(1, RealHp);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRealHp) {
output.WriteInt32(1, RealHp);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_WORLDBOSS_DEAD _inst = (GC_WORLDBOSS_DEAD) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.RealHp = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRealHp) return false;
 return true;
 }

}


[Serializable]
public class CG_WORLDBOSS_TEAMLIST_REQ : PacketDistributed
{

public const int pageFieldNumber = 1;
 private bool hasPage;
 private Int32 page_ = 0;
 public bool HasPage {
 get { return hasPage; }
 }
 public Int32 Page {
 get { return page_; }
 set { SetPage(value); }
 }
 public void SetPage(Int32 value) { 
 hasPage = true;
 page_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasPage) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Page);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasPage) {
output.WriteInt32(1, Page);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_WORLDBOSS_TEAMLIST_REQ _inst = (CG_WORLDBOSS_TEAMLIST_REQ) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Page = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasPage) return false;
 return true;
 }

}


[Serializable]
public class GC_WORLDBOSS_TEAMLIST : PacketDistributed
{

public const int curpageFieldNumber = 1;
 private bool hasCurpage;
 private Int32 curpage_ = 0;
 public bool HasCurpage {
 get { return hasCurpage; }
 }
 public Int32 Curpage {
 get { return curpage_; }
 set { SetCurpage(value); }
 }
 public void SetCurpage(Int32 value) { 
 hasCurpage = true;
 curpage_ = value;
 }

public const int totalpageFieldNumber = 2;
 private bool hasTotalpage;
 private Int32 totalpage_ = 0;
 public bool HasTotalpage {
 get { return hasTotalpage; }
 }
 public Int32 Totalpage {
 get { return totalpage_; }
 set { SetTotalpage(value); }
 }
 public void SetTotalpage(Int32 value) { 
 hasTotalpage = true;
 totalpage_ = value;
 }

public const int teamIdFieldNumber = 3;
 private pbc::PopsicleList<Int32> teamId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> teamIdList {
 get { return pbc::Lists.AsReadOnly(teamId_); }
 }
 
 public int teamIdCount {
 get { return teamId_.Count; }
 }
 
public Int32 GetTeamId(int index) {
 return teamId_[index];
 }
 public void AddTeamId(Int32 value) {
 teamId_.Add(value);
 }

public const int scoreFieldNumber = 4;
 private pbc::PopsicleList<Int32> score_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> scoreList {
 get { return pbc::Lists.AsReadOnly(score_); }
 }
 
 public int scoreCount {
 get { return score_.Count; }
 }
 
public Int32 GetScore(int index) {
 return score_[index];
 }
 public void AddScore(Int32 value) {
 score_.Add(value);
 }

public const int posFieldNumber = 5;
 private pbc::PopsicleList<Int32> pos_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> posList {
 get { return pbc::Lists.AsReadOnly(pos_); }
 }
 
 public int posCount {
 get { return pos_.Count; }
 }
 
public Int32 GetPos(int index) {
 return pos_[index];
 }
 public void AddPos(Int32 value) {
 pos_.Add(value);
 }

public const int leadernameFieldNumber = 6;
 private pbc::PopsicleList<string> leadername_ = new pbc::PopsicleList<string>();
 public scg::IList<string> leadernameList {
 get { return pbc::Lists.AsReadOnly(leadername_); }
 }
 
 public int leadernameCount {
 get { return leadername_.Count; }
 }
 
public string GetLeadername(int index) {
 return leadername_[index];
 }
 public void AddLeadername(string value) {
 leadername_.Add(value);
 }

public const int sceneClassIdFieldNumber = 7;
 private pbc::PopsicleList<Int32> sceneClassId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sceneClassIdList {
 get { return pbc::Lists.AsReadOnly(sceneClassId_); }
 }
 
 public int sceneClassIdCount {
 get { return sceneClassId_.Count; }
 }
 
public Int32 GetSceneClassId(int index) {
 return sceneClassId_[index];
 }
 public void AddSceneClassId(Int32 value) {
 sceneClassId_.Add(value);
 }

public const int cdFieldNumber = 8;
 private pbc::PopsicleList<Int32> cd_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> cdList {
 get { return pbc::Lists.AsReadOnly(cd_); }
 }
 
 public int cdCount {
 get { return cd_.Count; }
 }
 
public Int32 GetCd(int index) {
 return cd_[index];
 }
 public void AddCd(Int32 value) {
 cd_.Add(value);
 }

public const int sceneInstIdFieldNumber = 9;
 private pbc::PopsicleList<Int32> sceneInstId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> sceneInstIdList {
 get { return pbc::Lists.AsReadOnly(sceneInstId_); }
 }
 
 public int sceneInstIdCount {
 get { return sceneInstId_.Count; }
 }
 
public Int32 GetSceneInstId(int index) {
 return sceneInstId_[index];
 }
 public void AddSceneInstId(Int32 value) {
 sceneInstId_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCurpage) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Curpage);
}
 if (HasTotalpage) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Totalpage);
}
{
int dataSize = 0;
for(int i=0; i<teamIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(teamIdList[i]);
}
size += dataSize;
size += 1 * teamId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<scoreList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(scoreList[i]);
}
size += dataSize;
size += 1 * score_.Count;
}
{
int dataSize = 0;
for(int i=0; i<posList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(posList[i]);
}
size += dataSize;
size += 1 * pos_.Count;
}
{
int dataSize = 0;
for(int i=0; i<leadernameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(leadernameList[i]);
}
size += dataSize;
size += 1 * leadername_.Count;
}
{
int dataSize = 0;
for(int i=0; i<sceneClassIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sceneClassIdList[i]);
}
size += dataSize;
size += 1 * sceneClassId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<cdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(cdList[i]);
}
size += dataSize;
size += 1 * cd_.Count;
}
{
int dataSize = 0;
for(int i=0; i<sceneInstIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(sceneInstIdList[i]);
}
size += dataSize;
size += 1 * sceneInstId_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCurpage) {
output.WriteInt32(1, Curpage);
}
 
if (HasTotalpage) {
output.WriteInt32(2, Totalpage);
}
{
if (teamId_.Count > 0) {
for(int i=0; i<teamId_.Count; ++i){
output.WriteInt32(3,teamId_[i]);
}
}

}
{
if (score_.Count > 0) {
for(int i=0; i<score_.Count; ++i){
output.WriteInt32(4,score_[i]);
}
}

}
{
if (pos_.Count > 0) {
for(int i=0; i<pos_.Count; ++i){
output.WriteInt32(5,pos_[i]);
}
}

}
{
if (leadername_.Count > 0) {
for(int i=0; i<leadername_.Count; ++i){
output.WriteString(6,leadername_[i]);
}
}

}
{
if (sceneClassId_.Count > 0) {
for(int i=0; i<sceneClassId_.Count; ++i){
output.WriteInt32(7,sceneClassId_[i]);
}
}

}
{
if (cd_.Count > 0) {
for(int i=0; i<cd_.Count; ++i){
output.WriteInt32(8,cd_[i]);
}
}

}
{
if (sceneInstId_.Count > 0) {
for(int i=0; i<sceneInstId_.Count; ++i){
output.WriteInt32(9,sceneInstId_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_WORLDBOSS_TEAMLIST _inst = (GC_WORLDBOSS_TEAMLIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Curpage = input.ReadInt32();
break;
}
   case  16: {
 _inst.Totalpage = input.ReadInt32();
break;
}
   case  24: {
 _inst.AddTeamId(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddScore(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddPos(input.ReadInt32());
break;
}
   case  50: {
 _inst.AddLeadername(input.ReadString());
break;
}
   case  56: {
 _inst.AddSceneClassId(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddCd(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddSceneInstId(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurpage) return false;
 if (!hasTotalpage) return false;
 return true;
 }

}


[Serializable]
public class GC_WORLDBOSS_OPEN : PacketDistributed
{

public const int bossIdFieldNumber = 1;
 private bool hasBossId;
 private Int32 bossId_ = 0;
 public bool HasBossId {
 get { return hasBossId; }
 }
 public Int32 BossId {
 get { return bossId_; }
 set { SetBossId(value); }
 }
 public void SetBossId(Int32 value) { 
 hasBossId = true;
 bossId_ = value;
 }

public const int stateFieldNumber = 2;
 private bool hasState;
 private Int32 state_ = 0;
 public bool HasState {
 get { return hasState; }
 }
 public Int32 State {
 get { return state_; }
 set { SetState(value); }
 }
 public void SetState(Int32 value) { 
 hasState = true;
 state_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasBossId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, BossId);
}
 if (HasState) {
size += pb::CodedOutputStream.ComputeInt32Size(2, State);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasBossId) {
output.WriteInt32(1, BossId);
}
 
if (HasState) {
output.WriteInt32(2, State);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_WORLDBOSS_OPEN _inst = (GC_WORLDBOSS_OPEN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.BossId = input.ReadInt32();
break;
}
   case  16: {
 _inst.State = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasBossId) return false;
 if (!hasState) return false;
 return true;
 }

}


[Serializable]
public class CG_WORLDBOSS_CHALLENGE : PacketDistributed
{

public const int teamIdFieldNumber = 1;
 private bool hasTeamId;
 private Int32 teamId_ = 0;
 public bool HasTeamId {
 get { return hasTeamId; }
 }
 public Int32 TeamId {
 get { return teamId_; }
 set { SetTeamId(value); }
 }
 public void SetTeamId(Int32 value) { 
 hasTeamId = true;
 teamId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasTeamId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, TeamId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasTeamId) {
output.WriteInt32(1, TeamId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_WORLDBOSS_CHALLENGE _inst = (CG_WORLDBOSS_CHALLENGE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.TeamId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasTeamId) return false;
 return true;
 }

}


[Serializable]
public class CG_WORLDBOSS_JOIN : PacketDistributed
{

public const int noneFieldNumber = 1;
 private bool hasNone;
 private Int32 none_ = 0;
 public bool HasNone {
 get { return hasNone; }
 }
 public Int32 None {
 get { return none_; }
 set { SetNone(value); }
 }
 public void SetNone(Int32 value) { 
 hasNone = true;
 none_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNone) {
size += pb::CodedOutputStream.ComputeInt32Size(1, None);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNone) {
output.WriteInt32(1, None);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_WORLDBOSS_JOIN _inst = (CG_WORLDBOSS_JOIN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.None = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNone) return false;
 return true;
 }

}


[Serializable]
public class CG_CONSIGNSALEITEM : PacketDistributed
{

public const int itemguidFieldNumber = 1;
 private bool hasItemguid;
 private UInt64 itemguid_ = 0;
 public bool HasItemguid {
 get { return hasItemguid; }
 }
 public UInt64 Itemguid {
 get { return itemguid_; }
 set { SetItemguid(value); }
 }
 public void SetItemguid(UInt64 value) { 
 hasItemguid = true;
 itemguid_ = value;
 }

public const int itemcountFieldNumber = 2;
 private bool hasItemcount;
 private Int32 itemcount_ = 0;
 public bool HasItemcount {
 get { return hasItemcount; }
 }
 public Int32 Itemcount {
 get { return itemcount_; }
 set { SetItemcount(value); }
 }
 public void SetItemcount(Int32 value) { 
 hasItemcount = true;
 itemcount_ = value;
 }

public const int itempriceFieldNumber = 3;
 private bool hasItemprice;
 private Int32 itemprice_ = 0;
 public bool HasItemprice {
 get { return hasItemprice; }
 }
 public Int32 Itemprice {
 get { return itemprice_; }
 set { SetItemprice(value); }
 }
 public void SetItemprice(Int32 value) { 
 hasItemprice = true;
 itemprice_ = value;
 }

public const int curpageFieldNumber = 4;
 private bool hasCurpage;
 private Int32 curpage_ = 0;
 public bool HasCurpage {
 get { return hasCurpage; }
 }
 public Int32 Curpage {
 get { return curpage_; }
 set { SetCurpage(value); }
 }
 public void SetCurpage(Int32 value) { 
 hasCurpage = true;
 curpage_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasItemguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Itemguid);
}
 if (HasItemcount) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Itemcount);
}
 if (HasItemprice) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Itemprice);
}
 if (HasCurpage) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Curpage);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasItemguid) {
output.WriteUInt64(1, Itemguid);
}
 
if (HasItemcount) {
output.WriteInt32(2, Itemcount);
}
 
if (HasItemprice) {
output.WriteInt32(3, Itemprice);
}
 
if (HasCurpage) {
output.WriteInt32(4, Curpage);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CONSIGNSALEITEM _inst = (CG_CONSIGNSALEITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Itemguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.Itemcount = input.ReadInt32();
break;
}
   case  24: {
 _inst.Itemprice = input.ReadInt32();
break;
}
   case  32: {
 _inst.Curpage = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasItemguid) return false;
 if (!hasItemcount) return false;
 if (!hasItemprice) return false;
 if (!hasCurpage) return false;
 return true;
 }

}


[Serializable]
public class CG_CANCELCONSIGNSALEITEM : PacketDistributed
{

public const int itemguidFieldNumber = 1;
 private bool hasItemguid;
 private UInt64 itemguid_ = 0;
 public bool HasItemguid {
 get { return hasItemguid; }
 }
 public UInt64 Itemguid {
 get { return itemguid_; }
 set { SetItemguid(value); }
 }
 public void SetItemguid(UInt64 value) { 
 hasItemguid = true;
 itemguid_ = value;
 }

public const int curpageFieldNumber = 2;
 private bool hasCurpage;
 private Int32 curpage_ = 0;
 public bool HasCurpage {
 get { return hasCurpage; }
 }
 public Int32 Curpage {
 get { return curpage_; }
 set { SetCurpage(value); }
 }
 public void SetCurpage(Int32 value) { 
 hasCurpage = true;
 curpage_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasItemguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Itemguid);
}
 if (HasCurpage) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Curpage);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasItemguid) {
output.WriteUInt64(1, Itemguid);
}
 
if (HasCurpage) {
output.WriteInt32(2, Curpage);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_CANCELCONSIGNSALEITEM _inst = (CG_CANCELCONSIGNSALEITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Itemguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.Curpage = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasItemguid) return false;
 if (!hasCurpage) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_MYCONSIGNSALEITEM : PacketDistributed
{

public const int curpageFieldNumber = 1;
 private bool hasCurpage;
 private Int32 curpage_ = 0;
 public bool HasCurpage {
 get { return hasCurpage; }
 }
 public Int32 Curpage {
 get { return curpage_; }
 set { SetCurpage(value); }
 }
 public void SetCurpage(Int32 value) { 
 hasCurpage = true;
 curpage_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCurpage) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Curpage);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCurpage) {
output.WriteInt32(1, Curpage);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_MYCONSIGNSALEITEM _inst = (CG_ASK_MYCONSIGNSALEITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Curpage = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurpage) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_MYCONSIGNSALEITEM : PacketDistributed
{

public const int dataidFieldNumber = 1;
 private pbc::PopsicleList<Int32> dataid_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dataidList {
 get { return pbc::Lists.AsReadOnly(dataid_); }
 }
 
 public int dataidCount {
 get { return dataid_.Count; }
 }
 
public Int32 GetDataid(int index) {
 return dataid_[index];
 }
 public void AddDataid(Int32 value) {
 dataid_.Add(value);
 }

public const int guidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int bindflagFieldNumber = 3;
 private pbc::PopsicleList<Int32> bindflag_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> bindflagList {
 get { return pbc::Lists.AsReadOnly(bindflag_); }
 }
 
 public int bindflagCount {
 get { return bindflag_.Count; }
 }
 
public Int32 GetBindflag(int index) {
 return bindflag_[index];
 }
 public void AddBindflag(Int32 value) {
 bindflag_.Add(value);
 }

public const int stackcountFieldNumber = 4;
 private pbc::PopsicleList<Int32> stackcount_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> stackcountList {
 get { return pbc::Lists.AsReadOnly(stackcount_); }
 }
 
 public int stackcountCount {
 get { return stackcount_.Count; }
 }
 
public Int32 GetStackcount(int index) {
 return stackcount_[index];
 }
 public void AddStackcount(Int32 value) {
 stackcount_.Add(value);
 }

public const int enchancelevelFieldNumber = 5;
 private pbc::PopsicleList<Int32> enchancelevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> enchancelevelList {
 get { return pbc::Lists.AsReadOnly(enchancelevel_); }
 }
 
 public int enchancelevelCount {
 get { return enchancelevel_.Count; }
 }
 
public Int32 GetEnchancelevel(int index) {
 return enchancelevel_[index];
 }
 public void AddEnchancelevel(Int32 value) {
 enchancelevel_.Add(value);
 }

public const int starlevelFieldNumber = 6;
 private pbc::PopsicleList<Int32> starlevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> starlevelList {
 get { return pbc::Lists.AsReadOnly(starlevel_); }
 }
 
 public int starlevelCount {
 get { return starlevel_.Count; }
 }
 
public Int32 GetStarlevel(int index) {
 return starlevel_[index];
 }
 public void AddStarlevel(Int32 value) {
 starlevel_.Add(value);
 }

public const int dynamicdata1FieldNumber = 7;
 private pbc::PopsicleList<Int32> dynamicdata1_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata1List {
 get { return pbc::Lists.AsReadOnly(dynamicdata1_); }
 }
 
 public int dynamicdata1Count {
 get { return dynamicdata1_.Count; }
 }
 
public Int32 GetDynamicdata1(int index) {
 return dynamicdata1_[index];
 }
 public void AddDynamicdata1(Int32 value) {
 dynamicdata1_.Add(value);
 }

public const int dynamicdata2FieldNumber = 8;
 private pbc::PopsicleList<Int32> dynamicdata2_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata2List {
 get { return pbc::Lists.AsReadOnly(dynamicdata2_); }
 }
 
 public int dynamicdata2Count {
 get { return dynamicdata2_.Count; }
 }
 
public Int32 GetDynamicdata2(int index) {
 return dynamicdata2_[index];
 }
 public void AddDynamicdata2(Int32 value) {
 dynamicdata2_.Add(value);
 }

public const int dynamicdata3FieldNumber = 9;
 private pbc::PopsicleList<Int32> dynamicdata3_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata3List {
 get { return pbc::Lists.AsReadOnly(dynamicdata3_); }
 }
 
 public int dynamicdata3Count {
 get { return dynamicdata3_.Count; }
 }
 
public Int32 GetDynamicdata3(int index) {
 return dynamicdata3_[index];
 }
 public void AddDynamicdata3(Int32 value) {
 dynamicdata3_.Add(value);
 }

public const int dynamicdata4FieldNumber = 10;
 private pbc::PopsicleList<Int32> dynamicdata4_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata4List {
 get { return pbc::Lists.AsReadOnly(dynamicdata4_); }
 }
 
 public int dynamicdata4Count {
 get { return dynamicdata4_.Count; }
 }
 
public Int32 GetDynamicdata4(int index) {
 return dynamicdata4_[index];
 }
 public void AddDynamicdata4(Int32 value) {
 dynamicdata4_.Add(value);
 }

public const int RemainTimeFieldNumber = 11;
 private pbc::PopsicleList<Int32> RemainTime_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> RemainTimeList {
 get { return pbc::Lists.AsReadOnly(RemainTime_); }
 }
 
 public int RemainTimeCount {
 get { return RemainTime_.Count; }
 }
 
public Int32 GetRemainTime(int index) {
 return RemainTime_[index];
 }
 public void AddRemainTime(Int32 value) {
 RemainTime_.Add(value);
 }

public const int enchanceexpFieldNumber = 12;
 private pbc::PopsicleList<Int32> enchanceexp_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> enchanceexpList {
 get { return pbc::Lists.AsReadOnly(enchanceexp_); }
 }
 
 public int enchanceexpCount {
 get { return enchanceexp_.Count; }
 }
 
public Int32 GetEnchanceexp(int index) {
 return enchanceexp_[index];
 }
 public void AddEnchanceexp(Int32 value) {
 enchanceexp_.Add(value);
 }

public const int enchancetotalexpFieldNumber = 13;
 private pbc::PopsicleList<Int64> enchancetotalexp_ = new pbc::PopsicleList<Int64>();
 public scg::IList<Int64> enchancetotalexpList {
 get { return pbc::Lists.AsReadOnly(enchancetotalexp_); }
 }
 
 public int enchancetotalexpCount {
 get { return enchancetotalexp_.Count; }
 }
 
public Int64 GetEnchancetotalexp(int index) {
 return enchancetotalexp_[index];
 }
 public void AddEnchancetotalexp(Int64 value) {
 enchancetotalexp_.Add(value);
 }

public const int startimesFieldNumber = 14;
 private pbc::PopsicleList<Int32> startimes_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> startimesList {
 get { return pbc::Lists.AsReadOnly(startimes_); }
 }
 
 public int startimesCount {
 get { return startimes_.Count; }
 }
 
public Int32 GetStartimes(int index) {
 return startimes_[index];
 }
 public void AddStartimes(Int32 value) {
 startimes_.Add(value);
 }

public const int totalpriceFieldNumber = 15;
 private pbc::PopsicleList<Int32> totalprice_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> totalpriceList {
 get { return pbc::Lists.AsReadOnly(totalprice_); }
 }
 
 public int totalpriceCount {
 get { return totalprice_.Count; }
 }
 
public Int32 GetTotalprice(int index) {
 return totalprice_[index];
 }
 public void AddTotalprice(Int32 value) {
 totalprice_.Add(value);
 }

public const int curpageFieldNumber = 16;
 private bool hasCurpage;
 private Int32 curpage_ = 0;
 public bool HasCurpage {
 get { return hasCurpage; }
 }
 public Int32 Curpage {
 get { return curpage_; }
 set { SetCurpage(value); }
 }
 public void SetCurpage(Int32 value) { 
 hasCurpage = true;
 curpage_ = value;
 }

public const int cursalecountFieldNumber = 17;
 private bool hasCursalecount;
 private Int32 cursalecount_ = 0;
 public bool HasCursalecount {
 get { return hasCursalecount; }
 }
 public Int32 Cursalecount {
 get { return cursalecount_; }
 set { SetCursalecount(value); }
 }
 public void SetCursalecount(Int32 value) { 
 hasCursalecount = true;
 cursalecount_ = value;
 }

public const int maxsalecountFieldNumber = 18;
 private bool hasMaxsalecount;
 private Int32 maxsalecount_ = 0;
 public bool HasMaxsalecount {
 get { return hasMaxsalecount; }
 }
 public Int32 Maxsalecount {
 get { return maxsalecount_; }
 set { SetMaxsalecount(value); }
 }
 public void SetMaxsalecount(Int32 value) { 
 hasMaxsalecount = true;
 maxsalecount_ = value;
 }

public const int dynamicdata5FieldNumber = 19;
 private pbc::PopsicleList<Int32> dynamicdata5_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata5List {
 get { return pbc::Lists.AsReadOnly(dynamicdata5_); }
 }
 
 public int dynamicdata5Count {
 get { return dynamicdata5_.Count; }
 }
 
public Int32 GetDynamicdata5(int index) {
 return dynamicdata5_[index];
 }
 public void AddDynamicdata5(Int32 value) {
 dynamicdata5_.Add(value);
 }

public const int dynamicdata6FieldNumber = 20;
 private pbc::PopsicleList<Int32> dynamicdata6_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata6List {
 get { return pbc::Lists.AsReadOnly(dynamicdata6_); }
 }
 
 public int dynamicdata6Count {
 get { return dynamicdata6_.Count; }
 }
 
public Int32 GetDynamicdata6(int index) {
 return dynamicdata6_[index];
 }
 public void AddDynamicdata6(Int32 value) {
 dynamicdata6_.Add(value);
 }

public const int dynamicdata7FieldNumber = 21;
 private pbc::PopsicleList<Int32> dynamicdata7_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata7List {
 get { return pbc::Lists.AsReadOnly(dynamicdata7_); }
 }
 
 public int dynamicdata7Count {
 get { return dynamicdata7_.Count; }
 }
 
public Int32 GetDynamicdata7(int index) {
 return dynamicdata7_[index];
 }
 public void AddDynamicdata7(Int32 value) {
 dynamicdata7_.Add(value);
 }

public const int dynamicdata8FieldNumber = 22;
 private pbc::PopsicleList<Int32> dynamicdata8_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata8List {
 get { return pbc::Lists.AsReadOnly(dynamicdata8_); }
 }
 
 public int dynamicdata8Count {
 get { return dynamicdata8_.Count; }
 }
 
public Int32 GetDynamicdata8(int index) {
 return dynamicdata8_[index];
 }
 public void AddDynamicdata8(Int32 value) {
 dynamicdata8_.Add(value);
 }

public const int attrfactorFieldNumber = 23;
 private pbc::PopsicleList<Int32> attrfactor_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> attrfactorList {
 get { return pbc::Lists.AsReadOnly(attrfactor_); }
 }
 
 public int attrfactorCount {
 get { return attrfactor_.Count; }
 }
 
public Int32 GetAttrfactor(int index) {
 return attrfactor_[index];
 }
 public void AddAttrfactor(Int32 value) {
 attrfactor_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<dataidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dataidList[i]);
}
size += dataSize;
size += 1 * dataid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<bindflagList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(bindflagList[i]);
}
size += dataSize;
size += 1 * bindflag_.Count;
}
{
int dataSize = 0;
for(int i=0; i<stackcountList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(stackcountList[i]);
}
size += dataSize;
size += 1 * stackcount_.Count;
}
{
int dataSize = 0;
for(int i=0; i<enchancelevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(enchancelevelList[i]);
}
size += dataSize;
size += 1 * enchancelevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<starlevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(starlevelList[i]);
}
size += dataSize;
size += 1 * starlevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata1List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata1List[i]);
}
size += dataSize;
size += 1 * dynamicdata1_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata2List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata2List[i]);
}
size += dataSize;
size += 1 * dynamicdata2_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata3List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata3List[i]);
}
size += dataSize;
size += 1 * dynamicdata3_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata4List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata4List[i]);
}
size += dataSize;
size += 1 * dynamicdata4_.Count;
}
{
int dataSize = 0;
for(int i=0; i<RemainTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(RemainTimeList[i]);
}
size += dataSize;
size += 1 * RemainTime_.Count;
}
{
int dataSize = 0;
for(int i=0; i<enchanceexpList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(enchanceexpList[i]);
}
size += dataSize;
size += 1 * enchanceexp_.Count;
}
{
int dataSize = 0;
for(int i=0; i<enchancetotalexpList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt64SizeNoTag(enchancetotalexpList[i]);
}
size += dataSize;
size += 1 * enchancetotalexp_.Count;
}
{
int dataSize = 0;
for(int i=0; i<startimesList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(startimesList[i]);
}
size += dataSize;
size += 1 * startimes_.Count;
}
{
int dataSize = 0;
for(int i=0; i<totalpriceList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(totalpriceList[i]);
}
size += dataSize;
size += 1 * totalprice_.Count;
}
 if (HasCurpage) {
size += pb::CodedOutputStream.ComputeInt32Size(16, Curpage);
}
 if (HasCursalecount) {
size += pb::CodedOutputStream.ComputeInt32Size(17, Cursalecount);
}
 if (HasMaxsalecount) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Maxsalecount);
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata5List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata5List[i]);
}
size += dataSize;
size += 1 * dynamicdata5_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata6List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata6List[i]);
}
size += dataSize;
size += 1 * dynamicdata6_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata7List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata7List[i]);
}
size += dataSize;
size += 1 * dynamicdata7_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata8List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata8List[i]);
}
size += dataSize;
size += 1 * dynamicdata8_.Count;
}
{
int dataSize = 0;
for(int i=0; i<attrfactorList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(attrfactorList[i]);
}
size += dataSize;
size += 1 * attrfactor_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (dataid_.Count > 0) {
for(int i=0; i<dataid_.Count; ++i){
output.WriteInt32(1,dataid_[i]);
}
}

}
{
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(2,guid_[i]);
}
}

}
{
if (bindflag_.Count > 0) {
for(int i=0; i<bindflag_.Count; ++i){
output.WriteInt32(3,bindflag_[i]);
}
}

}
{
if (stackcount_.Count > 0) {
for(int i=0; i<stackcount_.Count; ++i){
output.WriteInt32(4,stackcount_[i]);
}
}

}
{
if (enchancelevel_.Count > 0) {
for(int i=0; i<enchancelevel_.Count; ++i){
output.WriteInt32(5,enchancelevel_[i]);
}
}

}
{
if (starlevel_.Count > 0) {
for(int i=0; i<starlevel_.Count; ++i){
output.WriteInt32(6,starlevel_[i]);
}
}

}
{
if (dynamicdata1_.Count > 0) {
for(int i=0; i<dynamicdata1_.Count; ++i){
output.WriteInt32(7,dynamicdata1_[i]);
}
}

}
{
if (dynamicdata2_.Count > 0) {
for(int i=0; i<dynamicdata2_.Count; ++i){
output.WriteInt32(8,dynamicdata2_[i]);
}
}

}
{
if (dynamicdata3_.Count > 0) {
for(int i=0; i<dynamicdata3_.Count; ++i){
output.WriteInt32(9,dynamicdata3_[i]);
}
}

}
{
if (dynamicdata4_.Count > 0) {
for(int i=0; i<dynamicdata4_.Count; ++i){
output.WriteInt32(10,dynamicdata4_[i]);
}
}

}
{
if (RemainTime_.Count > 0) {
for(int i=0; i<RemainTime_.Count; ++i){
output.WriteInt32(11,RemainTime_[i]);
}
}

}
{
if (enchanceexp_.Count > 0) {
for(int i=0; i<enchanceexp_.Count; ++i){
output.WriteInt32(12,enchanceexp_[i]);
}
}

}
{
if (enchancetotalexp_.Count > 0) {
for(int i=0; i<enchancetotalexp_.Count; ++i){
output.WriteInt64(13,enchancetotalexp_[i]);
}
}

}
{
if (startimes_.Count > 0) {
for(int i=0; i<startimes_.Count; ++i){
output.WriteInt32(14,startimes_[i]);
}
}

}
{
if (totalprice_.Count > 0) {
for(int i=0; i<totalprice_.Count; ++i){
output.WriteInt32(15,totalprice_[i]);
}
}

}
 
if (HasCurpage) {
output.WriteInt32(16, Curpage);
}
 
if (HasCursalecount) {
output.WriteInt32(17, Cursalecount);
}
 
if (HasMaxsalecount) {
output.WriteInt32(18, Maxsalecount);
}
{
if (dynamicdata5_.Count > 0) {
for(int i=0; i<dynamicdata5_.Count; ++i){
output.WriteInt32(19,dynamicdata5_[i]);
}
}

}
{
if (dynamicdata6_.Count > 0) {
for(int i=0; i<dynamicdata6_.Count; ++i){
output.WriteInt32(20,dynamicdata6_[i]);
}
}

}
{
if (dynamicdata7_.Count > 0) {
for(int i=0; i<dynamicdata7_.Count; ++i){
output.WriteInt32(21,dynamicdata7_[i]);
}
}

}
{
if (dynamicdata8_.Count > 0) {
for(int i=0; i<dynamicdata8_.Count; ++i){
output.WriteInt32(22,dynamicdata8_[i]);
}
}

}
{
if (attrfactor_.Count > 0) {
for(int i=0; i<attrfactor_.Count; ++i){
output.WriteInt32(23,attrfactor_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_MYCONSIGNSALEITEM _inst = (GC_RET_MYCONSIGNSALEITEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddDataid(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  24: {
 _inst.AddBindflag(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddStackcount(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddEnchancelevel(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddStarlevel(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddDynamicdata1(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddDynamicdata2(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddDynamicdata3(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddDynamicdata4(input.ReadInt32());
break;
}
   case  88: {
 _inst.AddRemainTime(input.ReadInt32());
break;
}
   case  96: {
 _inst.AddEnchanceexp(input.ReadInt32());
break;
}
   case  104: {
 _inst.AddEnchancetotalexp(input.ReadInt64());
break;
}
   case  112: {
 _inst.AddStartimes(input.ReadInt32());
break;
}
   case  120: {
 _inst.AddTotalprice(input.ReadInt32());
break;
}
   case  128: {
 _inst.Curpage = input.ReadInt32();
break;
}
   case  136: {
 _inst.Cursalecount = input.ReadInt32();
break;
}
   case  144: {
 _inst.Maxsalecount = input.ReadInt32();
break;
}
   case  152: {
 _inst.AddDynamicdata5(input.ReadInt32());
break;
}
   case  160: {
 _inst.AddDynamicdata6(input.ReadInt32());
break;
}
   case  168: {
 _inst.AddDynamicdata7(input.ReadInt32());
break;
}
   case  176: {
 _inst.AddDynamicdata8(input.ReadInt32());
break;
}
   case  184: {
 _inst.AddAttrfactor(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurpage) return false;
 if (!hasCursalecount) return false;
 if (!hasMaxsalecount) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_CONSIGNSALEITEMINFO : PacketDistributed
{

public const int searchclassFieldNumber = 1;
 private bool hasSearchclass;
 private Int32 searchclass_ = 0;
 public bool HasSearchclass {
 get { return hasSearchclass; }
 }
 public Int32 Searchclass {
 get { return searchclass_; }
 set { SetSearchclass(value); }
 }
 public void SetSearchclass(Int32 value) { 
 hasSearchclass = true;
 searchclass_ = value;
 }

public const int searchsubclassFieldNumber = 2;
 private bool hasSearchsubclass;
 private Int32 searchsubclass_ = 0;
 public bool HasSearchsubclass {
 get { return hasSearchsubclass; }
 }
 public Int32 Searchsubclass {
 get { return searchsubclass_; }
 set { SetSearchsubclass(value); }
 }
 public void SetSearchsubclass(Int32 value) { 
 hasSearchsubclass = true;
 searchsubclass_ = value;
 }

public const int searchqualityFieldNumber = 3;
 private bool hasSearchquality;
 private Int32 searchquality_ = 0;
 public bool HasSearchquality {
 get { return hasSearchquality; }
 }
 public Int32 Searchquality {
 get { return searchquality_; }
 set { SetSearchquality(value); }
 }
 public void SetSearchquality(Int32 value) { 
 hasSearchquality = true;
 searchquality_ = value;
 }

public const int sortclassFieldNumber = 4;
 private bool hasSortclass;
 private Int32 sortclass_ = 0;
 public bool HasSortclass {
 get { return hasSortclass; }
 }
 public Int32 Sortclass {
 get { return sortclass_; }
 set { SetSortclass(value); }
 }
 public void SetSortclass(Int32 value) { 
 hasSortclass = true;
 sortclass_ = value;
 }

public const int sorttypeFieldNumber = 5;
 private bool hasSorttype;
 private Int32 sorttype_ = 0;
 public bool HasSorttype {
 get { return hasSorttype; }
 }
 public Int32 Sorttype {
 get { return sorttype_; }
 set { SetSorttype(value); }
 }
 public void SetSorttype(Int32 value) { 
 hasSorttype = true;
 sorttype_ = value;
 }

public const int keywordFieldNumber = 6;
 private bool hasKeyword;
 private string keyword_ = "";
 public bool HasKeyword {
 get { return hasKeyword; }
 }
 public string Keyword {
 get { return keyword_; }
 set { SetKeyword(value); }
 }
 public void SetKeyword(string value) { 
 hasKeyword = true;
 keyword_ = value;
 }

public const int pageFieldNumber = 7;
 private bool hasPage;
 private Int32 page_ = 0;
 public bool HasPage {
 get { return hasPage; }
 }
 public Int32 Page {
 get { return page_; }
 set { SetPage(value); }
 }
 public void SetPage(Int32 value) { 
 hasPage = true;
 page_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSearchclass) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Searchclass);
}
 if (HasSearchsubclass) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Searchsubclass);
}
 if (HasSearchquality) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Searchquality);
}
 if (HasSortclass) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Sortclass);
}
 if (HasSorttype) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Sorttype);
}
 if (HasKeyword) {
size += pb::CodedOutputStream.ComputeStringSize(6, Keyword);
}
 if (HasPage) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Page);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSearchclass) {
output.WriteInt32(1, Searchclass);
}
 
if (HasSearchsubclass) {
output.WriteInt32(2, Searchsubclass);
}
 
if (HasSearchquality) {
output.WriteInt32(3, Searchquality);
}
 
if (HasSortclass) {
output.WriteInt32(4, Sortclass);
}
 
if (HasSorttype) {
output.WriteInt32(5, Sorttype);
}
 
if (HasKeyword) {
output.WriteString(6, Keyword);
}
 
if (HasPage) {
output.WriteInt32(7, Page);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_CONSIGNSALEITEMINFO _inst = (CG_ASK_CONSIGNSALEITEMINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Searchclass = input.ReadInt32();
break;
}
   case  16: {
 _inst.Searchsubclass = input.ReadInt32();
break;
}
   case  24: {
 _inst.Searchquality = input.ReadInt32();
break;
}
   case  32: {
 _inst.Sortclass = input.ReadInt32();
break;
}
   case  40: {
 _inst.Sorttype = input.ReadInt32();
break;
}
   case  50: {
 _inst.Keyword = input.ReadString();
break;
}
   case  56: {
 _inst.Page = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSearchclass) return false;
 if (!hasSearchsubclass) return false;
 if (!hasSearchquality) return false;
 if (!hasSortclass) return false;
 if (!hasSorttype) return false;
 if (!hasKeyword) return false;
 if (!hasPage) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_CONSIGNSALEITEMINFO : PacketDistributed
{

public const int dataidFieldNumber = 1;
 private pbc::PopsicleList<Int32> dataid_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dataidList {
 get { return pbc::Lists.AsReadOnly(dataid_); }
 }
 
 public int dataidCount {
 get { return dataid_.Count; }
 }
 
public Int32 GetDataid(int index) {
 return dataid_[index];
 }
 public void AddDataid(Int32 value) {
 dataid_.Add(value);
 }

public const int guidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int bindflagFieldNumber = 3;
 private pbc::PopsicleList<Int32> bindflag_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> bindflagList {
 get { return pbc::Lists.AsReadOnly(bindflag_); }
 }
 
 public int bindflagCount {
 get { return bindflag_.Count; }
 }
 
public Int32 GetBindflag(int index) {
 return bindflag_[index];
 }
 public void AddBindflag(Int32 value) {
 bindflag_.Add(value);
 }

public const int stackcountFieldNumber = 4;
 private pbc::PopsicleList<Int32> stackcount_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> stackcountList {
 get { return pbc::Lists.AsReadOnly(stackcount_); }
 }
 
 public int stackcountCount {
 get { return stackcount_.Count; }
 }
 
public Int32 GetStackcount(int index) {
 return stackcount_[index];
 }
 public void AddStackcount(Int32 value) {
 stackcount_.Add(value);
 }

public const int enchancelevelFieldNumber = 5;
 private pbc::PopsicleList<Int32> enchancelevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> enchancelevelList {
 get { return pbc::Lists.AsReadOnly(enchancelevel_); }
 }
 
 public int enchancelevelCount {
 get { return enchancelevel_.Count; }
 }
 
public Int32 GetEnchancelevel(int index) {
 return enchancelevel_[index];
 }
 public void AddEnchancelevel(Int32 value) {
 enchancelevel_.Add(value);
 }

public const int starlevelFieldNumber = 6;
 private pbc::PopsicleList<Int32> starlevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> starlevelList {
 get { return pbc::Lists.AsReadOnly(starlevel_); }
 }
 
 public int starlevelCount {
 get { return starlevel_.Count; }
 }
 
public Int32 GetStarlevel(int index) {
 return starlevel_[index];
 }
 public void AddStarlevel(Int32 value) {
 starlevel_.Add(value);
 }

public const int dynamicdata1FieldNumber = 7;
 private pbc::PopsicleList<Int32> dynamicdata1_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata1List {
 get { return pbc::Lists.AsReadOnly(dynamicdata1_); }
 }
 
 public int dynamicdata1Count {
 get { return dynamicdata1_.Count; }
 }
 
public Int32 GetDynamicdata1(int index) {
 return dynamicdata1_[index];
 }
 public void AddDynamicdata1(Int32 value) {
 dynamicdata1_.Add(value);
 }

public const int dynamicdata2FieldNumber = 8;
 private pbc::PopsicleList<Int32> dynamicdata2_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata2List {
 get { return pbc::Lists.AsReadOnly(dynamicdata2_); }
 }
 
 public int dynamicdata2Count {
 get { return dynamicdata2_.Count; }
 }
 
public Int32 GetDynamicdata2(int index) {
 return dynamicdata2_[index];
 }
 public void AddDynamicdata2(Int32 value) {
 dynamicdata2_.Add(value);
 }

public const int dynamicdata3FieldNumber = 9;
 private pbc::PopsicleList<Int32> dynamicdata3_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata3List {
 get { return pbc::Lists.AsReadOnly(dynamicdata3_); }
 }
 
 public int dynamicdata3Count {
 get { return dynamicdata3_.Count; }
 }
 
public Int32 GetDynamicdata3(int index) {
 return dynamicdata3_[index];
 }
 public void AddDynamicdata3(Int32 value) {
 dynamicdata3_.Add(value);
 }

public const int dynamicdata4FieldNumber = 10;
 private pbc::PopsicleList<Int32> dynamicdata4_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata4List {
 get { return pbc::Lists.AsReadOnly(dynamicdata4_); }
 }
 
 public int dynamicdata4Count {
 get { return dynamicdata4_.Count; }
 }
 
public Int32 GetDynamicdata4(int index) {
 return dynamicdata4_[index];
 }
 public void AddDynamicdata4(Int32 value) {
 dynamicdata4_.Add(value);
 }

public const int enchanceexpFieldNumber = 11;
 private pbc::PopsicleList<Int32> enchanceexp_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> enchanceexpList {
 get { return pbc::Lists.AsReadOnly(enchanceexp_); }
 }
 
 public int enchanceexpCount {
 get { return enchanceexp_.Count; }
 }
 
public Int32 GetEnchanceexp(int index) {
 return enchanceexp_[index];
 }
 public void AddEnchanceexp(Int32 value) {
 enchanceexp_.Add(value);
 }

public const int enchancetotalexpFieldNumber = 12;
 private pbc::PopsicleList<Int64> enchancetotalexp_ = new pbc::PopsicleList<Int64>();
 public scg::IList<Int64> enchancetotalexpList {
 get { return pbc::Lists.AsReadOnly(enchancetotalexp_); }
 }
 
 public int enchancetotalexpCount {
 get { return enchancetotalexp_.Count; }
 }
 
public Int64 GetEnchancetotalexp(int index) {
 return enchancetotalexp_[index];
 }
 public void AddEnchancetotalexp(Int64 value) {
 enchancetotalexp_.Add(value);
 }

public const int startimesFieldNumber = 13;
 private pbc::PopsicleList<Int32> startimes_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> startimesList {
 get { return pbc::Lists.AsReadOnly(startimes_); }
 }
 
 public int startimesCount {
 get { return startimes_.Count; }
 }
 
public Int32 GetStartimes(int index) {
 return startimes_[index];
 }
 public void AddStartimes(Int32 value) {
 startimes_.Add(value);
 }

public const int totalpriceFieldNumber = 14;
 private pbc::PopsicleList<Int32> totalprice_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> totalpriceList {
 get { return pbc::Lists.AsReadOnly(totalprice_); }
 }
 
 public int totalpriceCount {
 get { return totalprice_.Count; }
 }
 
public Int32 GetTotalprice(int index) {
 return totalprice_[index];
 }
 public void AddTotalprice(Int32 value) {
 totalprice_.Add(value);
 }

public const int curpageFieldNumber = 15;
 private bool hasCurpage;
 private Int32 curpage_ = 0;
 public bool HasCurpage {
 get { return hasCurpage; }
 }
 public Int32 Curpage {
 get { return curpage_; }
 set { SetCurpage(value); }
 }
 public void SetCurpage(Int32 value) { 
 hasCurpage = true;
 curpage_ = value;
 }

public const int ownernameFieldNumber = 16;
 private pbc::PopsicleList<string> ownername_ = new pbc::PopsicleList<string>();
 public scg::IList<string> ownernameList {
 get { return pbc::Lists.AsReadOnly(ownername_); }
 }
 
 public int ownernameCount {
 get { return ownername_.Count; }
 }
 
public string GetOwnername(int index) {
 return ownername_[index];
 }
 public void AddOwnername(string value) {
 ownername_.Add(value);
 }

public const int dynamicdata5FieldNumber = 17;
 private pbc::PopsicleList<Int32> dynamicdata5_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata5List {
 get { return pbc::Lists.AsReadOnly(dynamicdata5_); }
 }
 
 public int dynamicdata5Count {
 get { return dynamicdata5_.Count; }
 }
 
public Int32 GetDynamicdata5(int index) {
 return dynamicdata5_[index];
 }
 public void AddDynamicdata5(Int32 value) {
 dynamicdata5_.Add(value);
 }

public const int dynamicdata6FieldNumber = 18;
 private pbc::PopsicleList<Int32> dynamicdata6_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata6List {
 get { return pbc::Lists.AsReadOnly(dynamicdata6_); }
 }
 
 public int dynamicdata6Count {
 get { return dynamicdata6_.Count; }
 }
 
public Int32 GetDynamicdata6(int index) {
 return dynamicdata6_[index];
 }
 public void AddDynamicdata6(Int32 value) {
 dynamicdata6_.Add(value);
 }

public const int dynamicdata7FieldNumber = 19;
 private pbc::PopsicleList<Int32> dynamicdata7_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata7List {
 get { return pbc::Lists.AsReadOnly(dynamicdata7_); }
 }
 
 public int dynamicdata7Count {
 get { return dynamicdata7_.Count; }
 }
 
public Int32 GetDynamicdata7(int index) {
 return dynamicdata7_[index];
 }
 public void AddDynamicdata7(Int32 value) {
 dynamicdata7_.Add(value);
 }

public const int dynamicdata8FieldNumber = 20;
 private pbc::PopsicleList<Int32> dynamicdata8_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> dynamicdata8List {
 get { return pbc::Lists.AsReadOnly(dynamicdata8_); }
 }
 
 public int dynamicdata8Count {
 get { return dynamicdata8_.Count; }
 }
 
public Int32 GetDynamicdata8(int index) {
 return dynamicdata8_[index];
 }
 public void AddDynamicdata8(Int32 value) {
 dynamicdata8_.Add(value);
 }

public const int attrfactorFieldNumber = 21;
 private pbc::PopsicleList<Int32> attrfactor_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> attrfactorList {
 get { return pbc::Lists.AsReadOnly(attrfactor_); }
 }
 
 public int attrfactorCount {
 get { return attrfactor_.Count; }
 }
 
public Int32 GetAttrfactor(int index) {
 return attrfactor_[index];
 }
 public void AddAttrfactor(Int32 value) {
 attrfactor_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<dataidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dataidList[i]);
}
size += dataSize;
size += 1 * dataid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guidList[i]);
}
size += dataSize;
size += 1 * guid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<bindflagList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(bindflagList[i]);
}
size += dataSize;
size += 1 * bindflag_.Count;
}
{
int dataSize = 0;
for(int i=0; i<stackcountList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(stackcountList[i]);
}
size += dataSize;
size += 1 * stackcount_.Count;
}
{
int dataSize = 0;
for(int i=0; i<enchancelevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(enchancelevelList[i]);
}
size += dataSize;
size += 1 * enchancelevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<starlevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(starlevelList[i]);
}
size += dataSize;
size += 1 * starlevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata1List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata1List[i]);
}
size += dataSize;
size += 1 * dynamicdata1_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata2List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata2List[i]);
}
size += dataSize;
size += 1 * dynamicdata2_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata3List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata3List[i]);
}
size += dataSize;
size += 1 * dynamicdata3_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata4List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata4List[i]);
}
size += dataSize;
size += 1 * dynamicdata4_.Count;
}
{
int dataSize = 0;
for(int i=0; i<enchanceexpList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(enchanceexpList[i]);
}
size += dataSize;
size += 1 * enchanceexp_.Count;
}
{
int dataSize = 0;
for(int i=0; i<enchancetotalexpList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt64SizeNoTag(enchancetotalexpList[i]);
}
size += dataSize;
size += 1 * enchancetotalexp_.Count;
}
{
int dataSize = 0;
for(int i=0; i<startimesList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(startimesList[i]);
}
size += dataSize;
size += 1 * startimes_.Count;
}
{
int dataSize = 0;
for(int i=0; i<totalpriceList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(totalpriceList[i]);
}
size += dataSize;
size += 1 * totalprice_.Count;
}
 if (HasCurpage) {
size += pb::CodedOutputStream.ComputeInt32Size(15, Curpage);
}
{
int dataSize = 0;
for(int i=0; i<ownernameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(ownernameList[i]);
}
size += dataSize;
size += 1 * ownername_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata5List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata5List[i]);
}
size += dataSize;
size += 1 * dynamicdata5_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata6List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata6List[i]);
}
size += dataSize;
size += 1 * dynamicdata6_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata7List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata7List[i]);
}
size += dataSize;
size += 1 * dynamicdata7_.Count;
}
{
int dataSize = 0;
for(int i=0; i<dynamicdata8List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(dynamicdata8List[i]);
}
size += dataSize;
size += 1 * dynamicdata8_.Count;
}
{
int dataSize = 0;
for(int i=0; i<attrfactorList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(attrfactorList[i]);
}
size += dataSize;
size += 1 * attrfactor_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (dataid_.Count > 0) {
for(int i=0; i<dataid_.Count; ++i){
output.WriteInt32(1,dataid_[i]);
}
}

}
{
if (guid_.Count > 0) {
for(int i=0; i<guid_.Count; ++i){
output.WriteUInt64(2,guid_[i]);
}
}

}
{
if (bindflag_.Count > 0) {
for(int i=0; i<bindflag_.Count; ++i){
output.WriteInt32(3,bindflag_[i]);
}
}

}
{
if (stackcount_.Count > 0) {
for(int i=0; i<stackcount_.Count; ++i){
output.WriteInt32(4,stackcount_[i]);
}
}

}
{
if (enchancelevel_.Count > 0) {
for(int i=0; i<enchancelevel_.Count; ++i){
output.WriteInt32(5,enchancelevel_[i]);
}
}

}
{
if (starlevel_.Count > 0) {
for(int i=0; i<starlevel_.Count; ++i){
output.WriteInt32(6,starlevel_[i]);
}
}

}
{
if (dynamicdata1_.Count > 0) {
for(int i=0; i<dynamicdata1_.Count; ++i){
output.WriteInt32(7,dynamicdata1_[i]);
}
}

}
{
if (dynamicdata2_.Count > 0) {
for(int i=0; i<dynamicdata2_.Count; ++i){
output.WriteInt32(8,dynamicdata2_[i]);
}
}

}
{
if (dynamicdata3_.Count > 0) {
for(int i=0; i<dynamicdata3_.Count; ++i){
output.WriteInt32(9,dynamicdata3_[i]);
}
}

}
{
if (dynamicdata4_.Count > 0) {
for(int i=0; i<dynamicdata4_.Count; ++i){
output.WriteInt32(10,dynamicdata4_[i]);
}
}

}
{
if (enchanceexp_.Count > 0) {
for(int i=0; i<enchanceexp_.Count; ++i){
output.WriteInt32(11,enchanceexp_[i]);
}
}

}
{
if (enchancetotalexp_.Count > 0) {
for(int i=0; i<enchancetotalexp_.Count; ++i){
output.WriteInt64(12,enchancetotalexp_[i]);
}
}

}
{
if (startimes_.Count > 0) {
for(int i=0; i<startimes_.Count; ++i){
output.WriteInt32(13,startimes_[i]);
}
}

}
{
if (totalprice_.Count > 0) {
for(int i=0; i<totalprice_.Count; ++i){
output.WriteInt32(14,totalprice_[i]);
}
}

}
 
if (HasCurpage) {
output.WriteInt32(15, Curpage);
}
{
if (ownername_.Count > 0) {
for(int i=0; i<ownername_.Count; ++i){
output.WriteString(16,ownername_[i]);
}
}

}
{
if (dynamicdata5_.Count > 0) {
for(int i=0; i<dynamicdata5_.Count; ++i){
output.WriteInt32(17,dynamicdata5_[i]);
}
}

}
{
if (dynamicdata6_.Count > 0) {
for(int i=0; i<dynamicdata6_.Count; ++i){
output.WriteInt32(18,dynamicdata6_[i]);
}
}

}
{
if (dynamicdata7_.Count > 0) {
for(int i=0; i<dynamicdata7_.Count; ++i){
output.WriteInt32(19,dynamicdata7_[i]);
}
}

}
{
if (dynamicdata8_.Count > 0) {
for(int i=0; i<dynamicdata8_.Count; ++i){
output.WriteInt32(20,dynamicdata8_[i]);
}
}

}
{
if (attrfactor_.Count > 0) {
for(int i=0; i<attrfactor_.Count; ++i){
output.WriteInt32(21,attrfactor_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_CONSIGNSALEITEMINFO _inst = (GC_RET_CONSIGNSALEITEMINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddDataid(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddGuid(input.ReadUInt64());
break;
}
   case  24: {
 _inst.AddBindflag(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddStackcount(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddEnchancelevel(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddStarlevel(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddDynamicdata1(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddDynamicdata2(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddDynamicdata3(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddDynamicdata4(input.ReadInt32());
break;
}
   case  88: {
 _inst.AddEnchanceexp(input.ReadInt32());
break;
}
   case  96: {
 _inst.AddEnchancetotalexp(input.ReadInt64());
break;
}
   case  104: {
 _inst.AddStartimes(input.ReadInt32());
break;
}
   case  112: {
 _inst.AddTotalprice(input.ReadInt32());
break;
}
   case  120: {
 _inst.Curpage = input.ReadInt32();
break;
}
   case  130: {
 _inst.AddOwnername(input.ReadString());
break;
}
   case  136: {
 _inst.AddDynamicdata5(input.ReadInt32());
break;
}
   case  144: {
 _inst.AddDynamicdata6(input.ReadInt32());
break;
}
   case  152: {
 _inst.AddDynamicdata7(input.ReadInt32());
break;
}
   case  160: {
 _inst.AddDynamicdata8(input.ReadInt32());
break;
}
   case  168: {
 _inst.AddAttrfactor(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurpage) return false;
 return true;
 }

}


[Serializable]
public class CG_BUY_CONSIGNSALEITEMINFO : PacketDistributed
{

public const int searchclassFieldNumber = 1;
 private bool hasSearchclass;
 private Int32 searchclass_ = 0;
 public bool HasSearchclass {
 get { return hasSearchclass; }
 }
 public Int32 Searchclass {
 get { return searchclass_; }
 set { SetSearchclass(value); }
 }
 public void SetSearchclass(Int32 value) { 
 hasSearchclass = true;
 searchclass_ = value;
 }

public const int searchsubclassFieldNumber = 2;
 private bool hasSearchsubclass;
 private Int32 searchsubclass_ = 0;
 public bool HasSearchsubclass {
 get { return hasSearchsubclass; }
 }
 public Int32 Searchsubclass {
 get { return searchsubclass_; }
 set { SetSearchsubclass(value); }
 }
 public void SetSearchsubclass(Int32 value) { 
 hasSearchsubclass = true;
 searchsubclass_ = value;
 }

public const int searchqualityFieldNumber = 3;
 private bool hasSearchquality;
 private Int32 searchquality_ = 0;
 public bool HasSearchquality {
 get { return hasSearchquality; }
 }
 public Int32 Searchquality {
 get { return searchquality_; }
 set { SetSearchquality(value); }
 }
 public void SetSearchquality(Int32 value) { 
 hasSearchquality = true;
 searchquality_ = value;
 }

public const int sortclassFieldNumber = 4;
 private bool hasSortclass;
 private Int32 sortclass_ = 0;
 public bool HasSortclass {
 get { return hasSortclass; }
 }
 public Int32 Sortclass {
 get { return sortclass_; }
 set { SetSortclass(value); }
 }
 public void SetSortclass(Int32 value) { 
 hasSortclass = true;
 sortclass_ = value;
 }

public const int sorttypeFieldNumber = 5;
 private bool hasSorttype;
 private Int32 sorttype_ = 0;
 public bool HasSorttype {
 get { return hasSorttype; }
 }
 public Int32 Sorttype {
 get { return sorttype_; }
 set { SetSorttype(value); }
 }
 public void SetSorttype(Int32 value) { 
 hasSorttype = true;
 sorttype_ = value;
 }

public const int keywordFieldNumber = 6;
 private bool hasKeyword;
 private string keyword_ = "";
 public bool HasKeyword {
 get { return hasKeyword; }
 }
 public string Keyword {
 get { return keyword_; }
 set { SetKeyword(value); }
 }
 public void SetKeyword(string value) { 
 hasKeyword = true;
 keyword_ = value;
 }

public const int pageFieldNumber = 7;
 private bool hasPage;
 private Int32 page_ = 0;
 public bool HasPage {
 get { return hasPage; }
 }
 public Int32 Page {
 get { return page_; }
 set { SetPage(value); }
 }
 public void SetPage(Int32 value) { 
 hasPage = true;
 page_ = value;
 }

public const int itemguidFieldNumber = 8;
 private bool hasItemguid;
 private UInt64 itemguid_ = 0;
 public bool HasItemguid {
 get { return hasItemguid; }
 }
 public UInt64 Itemguid {
 get { return itemguid_; }
 set { SetItemguid(value); }
 }
 public void SetItemguid(UInt64 value) { 
 hasItemguid = true;
 itemguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSearchclass) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Searchclass);
}
 if (HasSearchsubclass) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Searchsubclass);
}
 if (HasSearchquality) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Searchquality);
}
 if (HasSortclass) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Sortclass);
}
 if (HasSorttype) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Sorttype);
}
 if (HasKeyword) {
size += pb::CodedOutputStream.ComputeStringSize(6, Keyword);
}
 if (HasPage) {
size += pb::CodedOutputStream.ComputeInt32Size(7, Page);
}
 if (HasItemguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(8, Itemguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSearchclass) {
output.WriteInt32(1, Searchclass);
}
 
if (HasSearchsubclass) {
output.WriteInt32(2, Searchsubclass);
}
 
if (HasSearchquality) {
output.WriteInt32(3, Searchquality);
}
 
if (HasSortclass) {
output.WriteInt32(4, Sortclass);
}
 
if (HasSorttype) {
output.WriteInt32(5, Sorttype);
}
 
if (HasKeyword) {
output.WriteString(6, Keyword);
}
 
if (HasPage) {
output.WriteInt32(7, Page);
}
 
if (HasItemguid) {
output.WriteUInt64(8, Itemguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BUY_CONSIGNSALEITEMINFO _inst = (CG_BUY_CONSIGNSALEITEMINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Searchclass = input.ReadInt32();
break;
}
   case  16: {
 _inst.Searchsubclass = input.ReadInt32();
break;
}
   case  24: {
 _inst.Searchquality = input.ReadInt32();
break;
}
   case  32: {
 _inst.Sortclass = input.ReadInt32();
break;
}
   case  40: {
 _inst.Sorttype = input.ReadInt32();
break;
}
   case  50: {
 _inst.Keyword = input.ReadString();
break;
}
   case  56: {
 _inst.Page = input.ReadInt32();
break;
}
   case  64: {
 _inst.Itemguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSearchclass) return false;
 if (!hasSearchsubclass) return false;
 if (!hasSearchquality) return false;
 if (!hasSortclass) return false;
 if (!hasSorttype) return false;
 if (!hasKeyword) return false;
 if (!hasPage) return false;
 if (!hasItemguid) return false;
 return true;
 }

}


[Serializable]
public class GC_SYNC_COMMONDATA : PacketDistributed
{

public const int nIndexFieldNumber = 1;
 private pbc::PopsicleList<Int32> nIndex_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> nIndexList {
 get { return pbc::Lists.AsReadOnly(nIndex_); }
 }
 
 public int nIndexCount {
 get { return nIndex_.Count; }
 }
 
public Int32 GetNIndex(int index) {
 return nIndex_[index];
 }
 public void AddNIndex(Int32 value) {
 nIndex_.Add(value);
 }

public const int nValueFieldNumber = 2;
 private pbc::PopsicleList<Int32> nValue_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> nValueList {
 get { return pbc::Lists.AsReadOnly(nValue_); }
 }
 
 public int nValueCount {
 get { return nValue_.Count; }
 }
 
public Int32 GetNValue(int index) {
 return nValue_[index];
 }
 public void AddNValue(Int32 value) {
 nValue_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<nIndexList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(nIndexList[i]);
}
size += dataSize;
size += 1 * nIndex_.Count;
}
{
int dataSize = 0;
for(int i=0; i<nValueList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(nValueList[i]);
}
size += dataSize;
size += 1 * nValue_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (nIndex_.Count > 0) {
for(int i=0; i<nIndex_.Count; ++i){
output.WriteInt32(1,nIndex_[i]);
}
}

}
{
if (nValue_.Count > 0) {
for(int i=0; i<nValue_.Count; ++i){
output.WriteInt32(2,nValue_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_COMMONDATA _inst = (GC_SYNC_COMMONDATA) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddNIndex(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddNValue(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_SYNC_COMMONFLAG : PacketDistributed
{

public const int nIndexFieldNumber = 1;
 private pbc::PopsicleList<Int32> nIndex_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> nIndexList {
 get { return pbc::Lists.AsReadOnly(nIndex_); }
 }
 
 public int nIndexCount {
 get { return nIndex_.Count; }
 }
 
public Int32 GetNIndex(int index) {
 return nIndex_[index];
 }
 public void AddNIndex(Int32 value) {
 nIndex_.Add(value);
 }

public const int nValueFieldNumber = 2;
 private pbc::PopsicleList<Int32> nValue_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> nValueList {
 get { return pbc::Lists.AsReadOnly(nValue_); }
 }
 
 public int nValueCount {
 get { return nValue_.Count; }
 }
 
public Int32 GetNValue(int index) {
 return nValue_[index];
 }
 public void AddNValue(Int32 value) {
 nValue_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<nIndexList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(nIndexList[i]);
}
size += dataSize;
size += 1 * nIndex_.Count;
}
{
int dataSize = 0;
for(int i=0; i<nValueList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(nValueList[i]);
}
size += dataSize;
size += 1 * nValue_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (nIndex_.Count > 0) {
for(int i=0; i<nIndex_.Count; ++i){
output.WriteInt32(1,nIndex_[i]);
}
}

}
{
if (nValue_.Count > 0) {
for(int i=0; i<nValue_.Count; ++i){
output.WriteInt32(2,nValue_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_COMMONFLAG _inst = (GC_SYNC_COMMONFLAG) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddNIndex(input.ReadInt32());
break;
}
   case  16: {
 _inst.AddNValue(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_ASK_SETCOMMONFLAG : PacketDistributed
{

public const int nBitsFieldNumber = 1;
 private bool hasNBits;
 private Int32 nBits_ = 0;
 public bool HasNBits {
 get { return hasNBits; }
 }
 public Int32 NBits {
 get { return nBits_; }
 set { SetNBits(value); }
 }
 public void SetNBits(Int32 value) { 
 hasNBits = true;
 nBits_ = value;
 }

public const int nFlagFieldNumber = 2;
 private bool hasNFlag;
 private Int32 nFlag_ = 0;
 public bool HasNFlag {
 get { return hasNFlag; }
 }
 public Int32 NFlag {
 get { return nFlag_; }
 set { SetNFlag(value); }
 }
 public void SetNFlag(Int32 value) { 
 hasNFlag = true;
 nFlag_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNBits) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NBits);
}
 if (HasNFlag) {
size += pb::CodedOutputStream.ComputeInt32Size(2, NFlag);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNBits) {
output.WriteInt32(1, NBits);
}
 
if (HasNFlag) {
output.WriteInt32(2, NFlag);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_SETCOMMONFLAG _inst = (CG_ASK_SETCOMMONFLAG) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NBits = input.ReadInt32();
break;
}
   case  16: {
 _inst.NFlag = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNBits) return false;
 if (!hasNFlag) return false;
 return true;
 }

}


[Serializable]
public class GC_ASK_COMMONFLAG_RET : PacketDistributed
{

public const int nBitsFieldNumber = 1;
 private bool hasNBits;
 private Int32 nBits_ = 0;
 public bool HasNBits {
 get { return hasNBits; }
 }
 public Int32 NBits {
 get { return nBits_; }
 set { SetNBits(value); }
 }
 public void SetNBits(Int32 value) { 
 hasNBits = true;
 nBits_ = value;
 }

public const int nFlagFieldNumber = 2;
 private bool hasNFlag;
 private Int32 nFlag_ = 0;
 public bool HasNFlag {
 get { return hasNFlag; }
 }
 public Int32 NFlag {
 get { return nFlag_; }
 set { SetNFlag(value); }
 }
 public void SetNFlag(Int32 value) { 
 hasNFlag = true;
 nFlag_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNBits) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NBits);
}
 if (HasNFlag) {
size += pb::CodedOutputStream.ComputeInt32Size(2, NFlag);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNBits) {
output.WriteInt32(1, NBits);
}
 
if (HasNFlag) {
output.WriteInt32(2, NFlag);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_ASK_COMMONFLAG_RET _inst = (GC_ASK_COMMONFLAG_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NBits = input.ReadInt32();
break;
}
   case  16: {
 _inst.NFlag = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNBits) return false;
 if (!hasNFlag) return false;
 return true;
 }

}


[Serializable]
public class CG_DAILYLUCKYDRAW_DRAW : PacketDistributed
{

public const int drawtypeFieldNumber = 1;
 private bool hasDrawtype;
 private Int32 drawtype_ = 0;
 public bool HasDrawtype {
 get { return hasDrawtype; }
 }
 public Int32 Drawtype {
 get { return drawtype_; }
 set { SetDrawtype(value); }
 }
 public void SetDrawtype(Int32 value) { 
 hasDrawtype = true;
 drawtype_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasDrawtype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Drawtype);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasDrawtype) {
output.WriteInt32(1, Drawtype);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_DAILYLUCKYDRAW_DRAW _inst = (CG_DAILYLUCKYDRAW_DRAW) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Drawtype = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasDrawtype) return false;
 return true;
 }

}


[Serializable]
public class GC_DAILYLUCKYDRAW_GAINBONUS : PacketDistributed
{

public const int drawtypeFieldNumber = 1;
 private bool hasDrawtype;
 private Int32 drawtype_ = 0;
 public bool HasDrawtype {
 get { return hasDrawtype; }
 }
 public Int32 Drawtype {
 get { return drawtype_; }
 set { SetDrawtype(value); }
 }
 public void SetDrawtype(Int32 value) { 
 hasDrawtype = true;
 drawtype_ = value;
 }

public const int gainbonusidFieldNumber = 2;
 private pbc::PopsicleList<Int32> gainbonusid_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> gainbonusidList {
 get { return pbc::Lists.AsReadOnly(gainbonusid_); }
 }
 
 public int gainbonusidCount {
 get { return gainbonusid_.Count; }
 }
 
public Int32 GetGainbonusid(int index) {
 return gainbonusid_[index];
 }
 public void AddGainbonusid(Int32 value) {
 gainbonusid_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasDrawtype) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Drawtype);
}
{
int dataSize = 0;
for(int i=0; i<gainbonusidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(gainbonusidList[i]);
}
size += dataSize;
size += 1 * gainbonusid_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasDrawtype) {
output.WriteInt32(1, Drawtype);
}
{
if (gainbonusid_.Count > 0) {
for(int i=0; i<gainbonusid_.Count; ++i){
output.WriteInt32(2,gainbonusid_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DAILYLUCKYDRAW_GAINBONUS _inst = (GC_DAILYLUCKYDRAW_GAINBONUS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Drawtype = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddGainbonusid(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasDrawtype) return false;
 return true;
 }

}


[Serializable]
public class GC_DAILYLUCKYDRAW_UPDATE : PacketDistributed
{

public const int drawfreetimesFieldNumber = 1;
 private bool hasDrawfreetimes;
 private Int32 drawfreetimes_ = 0;
 public bool HasDrawfreetimes {
 get { return hasDrawfreetimes; }
 }
 public Int32 Drawfreetimes {
 get { return drawfreetimes_; }
 set { SetDrawfreetimes(value); }
 }
 public void SetDrawfreetimes(Int32 value) { 
 hasDrawfreetimes = true;
 drawfreetimes_ = value;
 }

public const int drawfreecdtimeFieldNumber = 2;
 private bool hasDrawfreecdtime;
 private Int32 drawfreecdtime_ = 0;
 public bool HasDrawfreecdtime {
 get { return hasDrawfreecdtime; }
 }
 public Int32 Drawfreecdtime {
 get { return drawfreecdtime_; }
 set { SetDrawfreecdtime(value); }
 }
 public void SetDrawfreecdtime(Int32 value) { 
 hasDrawfreecdtime = true;
 drawfreecdtime_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasDrawfreetimes) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Drawfreetimes);
}
 if (HasDrawfreecdtime) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Drawfreecdtime);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasDrawfreetimes) {
output.WriteInt32(1, Drawfreetimes);
}
 
if (HasDrawfreecdtime) {
output.WriteInt32(2, Drawfreecdtime);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DAILYLUCKYDRAW_UPDATE _inst = (GC_DAILYLUCKYDRAW_UPDATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Drawfreetimes = input.ReadInt32();
break;
}
   case  16: {
 _inst.Drawfreecdtime = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class GC_DAILYLUCKYDRAW_FAIL : PacketDistributed
{
public enum FAILTYPE 
 { 
  TYPE_FREETIME = 0,   // �������� 
  TYPE_MONEY    = 1,   // ��Ǯ���� 
  TYPE_CD       = 2,      //��ȴʱ���� 
  TYPE_LEVEL    = 3,      //�ȼ����� 
 }
public const int failreasonFieldNumber = 1;
 private bool hasFailreason;
 private Int32 failreason_ = 0;
 public bool HasFailreason {
 get { return hasFailreason; }
 }
 public Int32 Failreason {
 get { return failreason_; }
 set { SetFailreason(value); }
 }
 public void SetFailreason(Int32 value) { 
 hasFailreason = true;
 failreason_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFailreason) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Failreason);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFailreason) {
output.WriteInt32(1, Failreason);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DAILYLUCKYDRAW_FAIL _inst = (GC_DAILYLUCKYDRAW_FAIL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Failreason = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFailreason) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATE_GEM_INFO : PacketDistributed
{

public const int gemidFieldNumber = 1;
 private pbc::PopsicleList<Int32> gemid_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> gemidList {
 get { return pbc::Lists.AsReadOnly(gemid_); }
 }
 
 public int gemidCount {
 get { return gemid_.Count; }
 }
 
public Int32 GetGemid(int index) {
 return gemid_[index];
 }
 public void AddGemid(Int32 value) {
 gemid_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<gemidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(gemidList[i]);
}
size += dataSize;
size += 1 * gemid_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (gemid_.Count > 0) {
for(int i=0; i<gemid_.Count; ++i){
output.WriteInt32(1,gemid_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_GEM_INFO _inst = (GC_UPDATE_GEM_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddGemid(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_PUT_GEM : PacketDistributed
{

public const int itemguidFieldNumber = 1;
 private bool hasItemguid;
 private UInt64 itemguid_ = 0;
 public bool HasItemguid {
 get { return hasItemguid; }
 }
 public UInt64 Itemguid {
 get { return itemguid_; }
 set { SetItemguid(value); }
 }
 public void SetItemguid(UInt64 value) { 
 hasItemguid = true;
 itemguid_ = value;
 }

public const int equipslotFieldNumber = 2;
 private bool hasEquipslot;
 private Int32 equipslot_ = 0;
 public bool HasEquipslot {
 get { return hasEquipslot; }
 }
 public Int32 Equipslot {
 get { return equipslot_; }
 set { SetEquipslot(value); }
 }
 public void SetEquipslot(Int32 value) { 
 hasEquipslot = true;
 equipslot_ = value;
 }

public const int indexFieldNumber = 3;
 private bool hasIndex;
 private Int32 index_ = 0;
 public bool HasIndex {
 get { return hasIndex; }
 }
 public Int32 Index {
 get { return index_; }
 set { SetIndex(value); }
 }
 public void SetIndex(Int32 value) { 
 hasIndex = true;
 index_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasItemguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Itemguid);
}
 if (HasEquipslot) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Equipslot);
}
 if (HasIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Index);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasItemguid) {
output.WriteUInt64(1, Itemguid);
}
 
if (HasEquipslot) {
output.WriteInt32(2, Equipslot);
}
 
if (HasIndex) {
output.WriteInt32(3, Index);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_PUT_GEM _inst = (CG_PUT_GEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Itemguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.Equipslot = input.ReadInt32();
break;
}
   case  24: {
 _inst.Index = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasItemguid) return false;
 if (!hasEquipslot) return false;
 if (!hasIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_PUT_GEM_RET : PacketDistributed
{

public const int equipslotFieldNumber = 1;
 private bool hasEquipslot;
 private Int32 equipslot_ = 0;
 public bool HasEquipslot {
 get { return hasEquipslot; }
 }
 public Int32 Equipslot {
 get { return equipslot_; }
 set { SetEquipslot(value); }
 }
 public void SetEquipslot(Int32 value) { 
 hasEquipslot = true;
 equipslot_ = value;
 }

public const int indexFieldNumber = 2;
 private bool hasIndex;
 private Int32 index_ = 0;
 public bool HasIndex {
 get { return hasIndex; }
 }
 public Int32 Index {
 get { return index_; }
 set { SetIndex(value); }
 }
 public void SetIndex(Int32 value) { 
 hasIndex = true;
 index_ = value;
 }

public const int dataidFieldNumber = 3;
 private bool hasDataid;
 private Int32 dataid_ = 0;
 public bool HasDataid {
 get { return hasDataid; }
 }
 public Int32 Dataid {
 get { return dataid_; }
 set { SetDataid(value); }
 }
 public void SetDataid(Int32 value) { 
 hasDataid = true;
 dataid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasEquipslot) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Equipslot);
}
 if (HasIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Index);
}
 if (HasDataid) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Dataid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasEquipslot) {
output.WriteInt32(1, Equipslot);
}
 
if (HasIndex) {
output.WriteInt32(2, Index);
}
 
if (HasDataid) {
output.WriteInt32(3, Dataid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_PUT_GEM_RET _inst = (GC_PUT_GEM_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Equipslot = input.ReadInt32();
break;
}
   case  16: {
 _inst.Index = input.ReadInt32();
break;
}
   case  24: {
 _inst.Dataid = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasEquipslot) return false;
 if (!hasIndex) return false;
 if (!hasDataid) return false;
 return true;
 }

}


[Serializable]
public class CG_TAKE_GEM : PacketDistributed
{

public const int equipslotFieldNumber = 1;
 private bool hasEquipslot;
 private Int32 equipslot_ = 0;
 public bool HasEquipslot {
 get { return hasEquipslot; }
 }
 public Int32 Equipslot {
 get { return equipslot_; }
 set { SetEquipslot(value); }
 }
 public void SetEquipslot(Int32 value) { 
 hasEquipslot = true;
 equipslot_ = value;
 }

public const int indexFieldNumber = 2;
 private bool hasIndex;
 private Int32 index_ = 0;
 public bool HasIndex {
 get { return hasIndex; }
 }
 public Int32 Index {
 get { return index_; }
 set { SetIndex(value); }
 }
 public void SetIndex(Int32 value) { 
 hasIndex = true;
 index_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasEquipslot) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Equipslot);
}
 if (HasIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Index);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasEquipslot) {
output.WriteInt32(1, Equipslot);
}
 
if (HasIndex) {
output.WriteInt32(2, Index);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_TAKE_GEM _inst = (CG_TAKE_GEM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Equipslot = input.ReadInt32();
break;
}
   case  16: {
 _inst.Index = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasEquipslot) return false;
 if (!hasIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_TAKE_GEM_RET : PacketDistributed
{

public const int equipslotFieldNumber = 1;
 private bool hasEquipslot;
 private Int32 equipslot_ = 0;
 public bool HasEquipslot {
 get { return hasEquipslot; }
 }
 public Int32 Equipslot {
 get { return equipslot_; }
 set { SetEquipslot(value); }
 }
 public void SetEquipslot(Int32 value) { 
 hasEquipslot = true;
 equipslot_ = value;
 }

public const int indexFieldNumber = 2;
 private bool hasIndex;
 private Int32 index_ = 0;
 public bool HasIndex {
 get { return hasIndex; }
 }
 public Int32 Index {
 get { return index_; }
 set { SetIndex(value); }
 }
 public void SetIndex(Int32 value) { 
 hasIndex = true;
 index_ = value;
 }

public const int dataidFieldNumber = 3;
 private bool hasDataid;
 private Int32 dataid_ = 0;
 public bool HasDataid {
 get { return hasDataid; }
 }
 public Int32 Dataid {
 get { return dataid_; }
 set { SetDataid(value); }
 }
 public void SetDataid(Int32 value) { 
 hasDataid = true;
 dataid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasEquipslot) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Equipslot);
}
 if (HasIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Index);
}
 if (HasDataid) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Dataid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasEquipslot) {
output.WriteInt32(1, Equipslot);
}
 
if (HasIndex) {
output.WriteInt32(2, Index);
}
 
if (HasDataid) {
output.WriteInt32(3, Dataid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_TAKE_GEM_RET _inst = (GC_TAKE_GEM_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Equipslot = input.ReadInt32();
break;
}
   case  16: {
 _inst.Index = input.ReadInt32();
break;
}
   case  24: {
 _inst.Dataid = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasEquipslot) return false;
 if (!hasIndex) return false;
 if (!hasDataid) return false;
 return true;
 }

}


[Serializable]
public class GC_SYNC_ACTIVENESS : PacketDistributed
{

public const int activenessFieldNumber = 1;
 private bool hasActiveness;
 private Int32 activeness_ = 0;
 public bool HasActiveness {
 get { return hasActiveness; }
 }
 public Int32 Activeness {
 get { return activeness_; }
 set { SetActiveness(value); }
 }
 public void SetActiveness(Int32 value) { 
 hasActiveness = true;
 activeness_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasActiveness) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Activeness);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasActiveness) {
output.WriteInt32(1, Activeness);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_ACTIVENESS _inst = (GC_SYNC_ACTIVENESS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Activeness = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasActiveness) return false;
 return true;
 }

}


[Serializable]
public class CG_BUY_FASHION : PacketDistributed
{

public const int FashionIDFieldNumber = 1;
 private bool hasFashionID;
 private Int32 FashionID_ = 0;
 public bool HasFashionID {
 get { return hasFashionID; }
 }
 public Int32 FashionID {
 get { return FashionID_; }
 set { SetFashionID(value); }
 }
 public void SetFashionID(Int32 value) { 
 hasFashionID = true;
 FashionID_ = value;
 }
public enum BUYTYPE 
 { 
  TYPE_WEEK = 0,   // 7�� 
  TYPE_MONTH = 1,   // 30�� 
  TYPE_FOREVER = 2,  // ���� 
 }
public const int BuyTypeFieldNumber = 2;
 private bool hasBuyType;
 private Int32 BuyType_ = 0;
 public bool HasBuyType {
 get { return hasBuyType; }
 }
 public Int32 BuyType {
 get { return BuyType_; }
 set { SetBuyType(value); }
 }
 public void SetBuyType(Int32 value) { 
 hasBuyType = true;
 BuyType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFashionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, FashionID);
}
 if (HasBuyType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, BuyType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFashionID) {
output.WriteInt32(1, FashionID);
}
 
if (HasBuyType) {
output.WriteInt32(2, BuyType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BUY_FASHION _inst = (CG_BUY_FASHION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.FashionID = input.ReadInt32();
break;
}
   case  16: {
 _inst.BuyType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFashionID) return false;
 if (!hasBuyType) return false;
 return true;
 }

}


[Serializable]
public class GC_SEND_FASHIONINFO : PacketDistributed
{

public const int FashionIDFieldNumber = 1;
 private bool hasFashionID;
 private Int32 FashionID_ = 0;
 public bool HasFashionID {
 get { return hasFashionID; }
 }
 public Int32 FashionID {
 get { return FashionID_; }
 set { SetFashionID(value); }
 }
 public void SetFashionID(Int32 value) { 
 hasFashionID = true;
 FashionID_ = value;
 }

public const int DeadlineFieldNumber = 2;
 private bool hasDeadline;
 private Int32 Deadline_ = 0;
 public bool HasDeadline {
 get { return hasDeadline; }
 }
 public Int32 Deadline {
 get { return Deadline_; }
 set { SetDeadline(value); }
 }
 public void SetDeadline(Int32 value) { 
 hasDeadline = true;
 Deadline_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFashionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, FashionID);
}
 if (HasDeadline) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Deadline);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFashionID) {
output.WriteInt32(1, FashionID);
}
 
if (HasDeadline) {
output.WriteInt32(2, Deadline);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SEND_FASHIONINFO _inst = (GC_SEND_FASHIONINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.FashionID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Deadline = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFashionID) return false;
 if (!hasDeadline) return false;
 return true;
 }

}


[Serializable]
public class GC_SYNC_FASHION : PacketDistributed
{

public const int DeadlineFieldNumber = 1;
 private pbc::PopsicleList<Int32> Deadline_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> DeadlineList {
 get { return pbc::Lists.AsReadOnly(Deadline_); }
 }
 
 public int DeadlineCount {
 get { return Deadline_.Count; }
 }
 
public Int32 GetDeadline(int index) {
 return Deadline_[index];
 }
 public void AddDeadline(Int32 value) {
 Deadline_.Add(value);
 }

public const int CurFashionIDFieldNumber = 2;
 private bool hasCurFashionID;
 private Int32 CurFashionID_ = 0;
 public bool HasCurFashionID {
 get { return hasCurFashionID; }
 }
 public Int32 CurFashionID {
 get { return CurFashionID_; }
 set { SetCurFashionID(value); }
 }
 public void SetCurFashionID(Int32 value) { 
 hasCurFashionID = true;
 CurFashionID_ = value;
 }

public const int IsShowFashionFieldNumber = 3;
 private bool hasIsShowFashion;
 private Int32 IsShowFashion_ = 0;
 public bool HasIsShowFashion {
 get { return hasIsShowFashion; }
 }
 public Int32 IsShowFashion {
 get { return IsShowFashion_; }
 set { SetIsShowFashion(value); }
 }
 public void SetIsShowFashion(Int32 value) { 
 hasIsShowFashion = true;
 IsShowFashion_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<DeadlineList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(DeadlineList[i]);
}
size += dataSize;
size += 1 * Deadline_.Count;
}
 if (HasCurFashionID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, CurFashionID);
}
 if (HasIsShowFashion) {
size += pb::CodedOutputStream.ComputeInt32Size(3, IsShowFashion);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (Deadline_.Count > 0) {
for(int i=0; i<Deadline_.Count; ++i){
output.WriteInt32(1,Deadline_[i]);
}
}

}
 
if (HasCurFashionID) {
output.WriteInt32(2, CurFashionID);
}
 
if (HasIsShowFashion) {
output.WriteInt32(3, IsShowFashion);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SYNC_FASHION _inst = (GC_SYNC_FASHION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddDeadline(input.ReadInt32());
break;
}
   case  16: {
 _inst.CurFashionID = input.ReadInt32();
break;
}
   case  24: {
 _inst.IsShowFashion = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurFashionID) return false;
 if (!hasIsShowFashion) return false;
 return true;
 }

}


[Serializable]
public class CG_WEAR_FASHION : PacketDistributed
{

public const int FashionIDFieldNumber = 1;
 private bool hasFashionID;
 private Int32 FashionID_ = 0;
 public bool HasFashionID {
 get { return hasFashionID; }
 }
 public Int32 FashionID {
 get { return FashionID_; }
 set { SetFashionID(value); }
 }
 public void SetFashionID(Int32 value) { 
 hasFashionID = true;
 FashionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFashionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, FashionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFashionID) {
output.WriteInt32(1, FashionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_WEAR_FASHION _inst = (CG_WEAR_FASHION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.FashionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFashionID) return false;
 return true;
 }

}


[Serializable]
public class CG_TAKEOFF_FASHION : PacketDistributed
{

public const int FashionIDFieldNumber = 1;
 private bool hasFashionID;
 private Int32 FashionID_ = 0;
 public bool HasFashionID {
 get { return hasFashionID; }
 }
 public Int32 FashionID {
 get { return FashionID_; }
 set { SetFashionID(value); }
 }
 public void SetFashionID(Int32 value) { 
 hasFashionID = true;
 FashionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFashionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, FashionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFashionID) {
output.WriteInt32(1, FashionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_TAKEOFF_FASHION _inst = (CG_TAKEOFF_FASHION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.FashionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFashionID) return false;
 return true;
 }

}


[Serializable]
public class GC_SEND_CURFASHION : PacketDistributed
{

public const int CurFashionIDFieldNumber = 1;
 private bool hasCurFashionID;
 private Int32 CurFashionID_ = 0;
 public bool HasCurFashionID {
 get { return hasCurFashionID; }
 }
 public Int32 CurFashionID {
 get { return CurFashionID_; }
 set { SetCurFashionID(value); }
 }
 public void SetCurFashionID(Int32 value) { 
 hasCurFashionID = true;
 CurFashionID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasCurFashionID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, CurFashionID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasCurFashionID) {
output.WriteInt32(1, CurFashionID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_SEND_CURFASHION _inst = (GC_SEND_CURFASHION) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.CurFashionID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCurFashionID) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_TEAMPLATFORMINFO : PacketDistributed
{

public const int sceneClassIDFieldNumber = 1;
 private bool hasSceneClassID;
 private Int32 sceneClassID_ = 0;
 public bool HasSceneClassID {
 get { return hasSceneClassID; }
 }
 public Int32 SceneClassID {
 get { return sceneClassID_; }
 set { SetSceneClassID(value); }
 }
 public void SetSceneClassID(Int32 value) { 
 hasSceneClassID = true;
 sceneClassID_ = value;
 }

public const int difficultyFieldNumber = 2;
 private bool hasDifficulty;
 private Int32 difficulty_ = 0;
 public bool HasDifficulty {
 get { return hasDifficulty; }
 }
 public Int32 Difficulty {
 get { return difficulty_; }
 set { SetDifficulty(value); }
 }
 public void SetDifficulty(Int32 value) { 
 hasDifficulty = true;
 difficulty_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneClassID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SceneClassID);
}
 if (HasDifficulty) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Difficulty);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneClassID) {
output.WriteInt32(1, SceneClassID);
}
 
if (HasDifficulty) {
output.WriteInt32(2, Difficulty);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_TEAMPLATFORMINFO _inst = (CG_ASK_TEAMPLATFORMINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SceneClassID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Difficulty = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneClassID) return false;
 if (!hasDifficulty) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_TEAMPLATFORMINFO : PacketDistributed
{

public const int playerGuidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> playerGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> playerGuidList {
 get { return pbc::Lists.AsReadOnly(playerGuid_); }
 }
 
 public int playerGuidCount {
 get { return playerGuid_.Count; }
 }
 
public UInt64 GetPlayerGuid(int index) {
 return playerGuid_[index];
 }
 public void AddPlayerGuid(UInt64 value) {
 playerGuid_.Add(value);
 }

public const int playerNameFieldNumber = 2;
 private pbc::PopsicleList<string> playerName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> playerNameList {
 get { return pbc::Lists.AsReadOnly(playerName_); }
 }
 
 public int playerNameCount {
 get { return playerName_.Count; }
 }
 
public string GetPlayerName(int index) {
 return playerName_[index];
 }
 public void AddPlayerName(string value) {
 playerName_.Add(value);
 }

public const int playerLevelFieldNumber = 3;
 private pbc::PopsicleList<Int32> playerLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> playerLevelList {
 get { return pbc::Lists.AsReadOnly(playerLevel_); }
 }
 
 public int playerLevelCount {
 get { return playerLevel_.Count; }
 }
 
public Int32 GetPlayerLevel(int index) {
 return playerLevel_[index];
 }
 public void AddPlayerLevel(Int32 value) {
 playerLevel_.Add(value);
 }

public const int playerProfFieldNumber = 4;
 private pbc::PopsicleList<Int32> playerProf_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> playerProfList {
 get { return pbc::Lists.AsReadOnly(playerProf_); }
 }
 
 public int playerProfCount {
 get { return playerProf_.Count; }
 }
 
public Int32 GetPlayerProf(int index) {
 return playerProf_[index];
 }
 public void AddPlayerProf(Int32 value) {
 playerProf_.Add(value);
 }

public const int playerCombatFieldNumber = 5;
 private pbc::PopsicleList<Int32> playerCombat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> playerCombatList {
 get { return pbc::Lists.AsReadOnly(playerCombat_); }
 }
 
 public int playerCombatCount {
 get { return playerCombat_.Count; }
 }
 
public Int32 GetPlayerCombat(int index) {
 return playerCombat_[index];
 }
 public void AddPlayerCombat(Int32 value) {
 playerCombat_.Add(value);
 }

public const int teamIDFieldNumber = 6;
 private pbc::PopsicleList<Int32> teamID_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> teamIDList {
 get { return pbc::Lists.AsReadOnly(teamID_); }
 }
 
 public int teamIDCount {
 get { return teamID_.Count; }
 }
 
public Int32 GetTeamID(int index) {
 return teamID_[index];
 }
 public void AddTeamID(Int32 value) {
 teamID_.Add(value);
 }

public const int memberGuidFieldNumber = 7;
 private pbc::PopsicleList<UInt64> memberGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> memberGuidList {
 get { return pbc::Lists.AsReadOnly(memberGuid_); }
 }
 
 public int memberGuidCount {
 get { return memberGuid_.Count; }
 }
 
public UInt64 GetMemberGuid(int index) {
 return memberGuid_[index];
 }
 public void AddMemberGuid(UInt64 value) {
 memberGuid_.Add(value);
 }

public const int memberNameFieldNumber = 8;
 private pbc::PopsicleList<string> memberName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> memberNameList {
 get { return pbc::Lists.AsReadOnly(memberName_); }
 }
 
 public int memberNameCount {
 get { return memberName_.Count; }
 }
 
public string GetMemberName(int index) {
 return memberName_[index];
 }
 public void AddMemberName(string value) {
 memberName_.Add(value);
 }

public const int memberLevelFieldNumber = 9;
 private pbc::PopsicleList<Int32> memberLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberLevelList {
 get { return pbc::Lists.AsReadOnly(memberLevel_); }
 }
 
 public int memberLevelCount {
 get { return memberLevel_.Count; }
 }
 
public Int32 GetMemberLevel(int index) {
 return memberLevel_[index];
 }
 public void AddMemberLevel(Int32 value) {
 memberLevel_.Add(value);
 }

public const int memberProfFieldNumber = 10;
 private pbc::PopsicleList<Int32> memberProf_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberProfList {
 get { return pbc::Lists.AsReadOnly(memberProf_); }
 }
 
 public int memberProfCount {
 get { return memberProf_.Count; }
 }
 
public Int32 GetMemberProf(int index) {
 return memberProf_[index];
 }
 public void AddMemberProf(Int32 value) {
 memberProf_.Add(value);
 }

public const int memberCombatFieldNumber = 11;
 private pbc::PopsicleList<Int32> memberCombat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberCombatList {
 get { return pbc::Lists.AsReadOnly(memberCombat_); }
 }
 
 public int memberCombatCount {
 get { return memberCombat_.Count; }
 }
 
public Int32 GetMemberCombat(int index) {
 return memberCombat_[index];
 }
 public void AddMemberCombat(Int32 value) {
 memberCombat_.Add(value);
 }

public const int countFieldNumber = 12;
 private bool hasCount;
 private Int32 count_ = 0;
 public bool HasCount {
 get { return hasCount; }
 }
 public Int32 Count {
 get { return count_; }
 set { SetCount(value); }
 }
 public void SetCount(Int32 value) { 
 hasCount = true;
 count_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<playerGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(playerGuidList[i]);
}
size += dataSize;
size += 1 * playerGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<playerNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(playerNameList[i]);
}
size += dataSize;
size += 1 * playerName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<playerLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(playerLevelList[i]);
}
size += dataSize;
size += 1 * playerLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<playerProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(playerProfList[i]);
}
size += dataSize;
size += 1 * playerProf_.Count;
}
{
int dataSize = 0;
for(int i=0; i<playerCombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(playerCombatList[i]);
}
size += dataSize;
size += 1 * playerCombat_.Count;
}
{
int dataSize = 0;
for(int i=0; i<teamIDList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(teamIDList[i]);
}
size += dataSize;
size += 1 * teamID_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(memberGuidList[i]);
}
size += dataSize;
size += 1 * memberGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(memberNameList[i]);
}
size += dataSize;
size += 1 * memberName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberLevelList[i]);
}
size += dataSize;
size += 1 * memberLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberProfList[i]);
}
size += dataSize;
size += 1 * memberProf_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberCombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberCombatList[i]);
}
size += dataSize;
size += 1 * memberCombat_.Count;
}
 if (HasCount) {
size += pb::CodedOutputStream.ComputeInt32Size(12, Count);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (playerGuid_.Count > 0) {
for(int i=0; i<playerGuid_.Count; ++i){
output.WriteUInt64(1,playerGuid_[i]);
}
}

}
{
if (playerName_.Count > 0) {
for(int i=0; i<playerName_.Count; ++i){
output.WriteString(2,playerName_[i]);
}
}

}
{
if (playerLevel_.Count > 0) {
for(int i=0; i<playerLevel_.Count; ++i){
output.WriteInt32(3,playerLevel_[i]);
}
}

}
{
if (playerProf_.Count > 0) {
for(int i=0; i<playerProf_.Count; ++i){
output.WriteInt32(4,playerProf_[i]);
}
}

}
{
if (playerCombat_.Count > 0) {
for(int i=0; i<playerCombat_.Count; ++i){
output.WriteInt32(5,playerCombat_[i]);
}
}

}
{
if (teamID_.Count > 0) {
for(int i=0; i<teamID_.Count; ++i){
output.WriteInt32(6,teamID_[i]);
}
}

}
{
if (memberGuid_.Count > 0) {
for(int i=0; i<memberGuid_.Count; ++i){
output.WriteUInt64(7,memberGuid_[i]);
}
}

}
{
if (memberName_.Count > 0) {
for(int i=0; i<memberName_.Count; ++i){
output.WriteString(8,memberName_[i]);
}
}

}
{
if (memberLevel_.Count > 0) {
for(int i=0; i<memberLevel_.Count; ++i){
output.WriteInt32(9,memberLevel_[i]);
}
}

}
{
if (memberProf_.Count > 0) {
for(int i=0; i<memberProf_.Count; ++i){
output.WriteInt32(10,memberProf_[i]);
}
}

}
{
if (memberCombat_.Count > 0) {
for(int i=0; i<memberCombat_.Count; ++i){
output.WriteInt32(11,memberCombat_[i]);
}
}

}
 
if (HasCount) {
output.WriteInt32(12, Count);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_TEAMPLATFORMINFO _inst = (GC_RET_TEAMPLATFORMINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddPlayerGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddPlayerName(input.ReadString());
break;
}
   case  24: {
 _inst.AddPlayerLevel(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddPlayerProf(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddPlayerCombat(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddTeamID(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddMemberGuid(input.ReadUInt64());
break;
}
   case  66: {
 _inst.AddMemberName(input.ReadString());
break;
}
   case  72: {
 _inst.AddMemberLevel(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddMemberProf(input.ReadInt32());
break;
}
   case  88: {
 _inst.AddMemberCombat(input.ReadInt32());
break;
}
   case  96: {
 _inst.Count = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasCount) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_AUTOTEAM : PacketDistributed
{

public const int sceneClassIDFieldNumber = 1;
 private bool hasSceneClassID;
 private Int32 sceneClassID_ = 0;
 public bool HasSceneClassID {
 get { return hasSceneClassID; }
 }
 public Int32 SceneClassID {
 get { return sceneClassID_; }
 set { SetSceneClassID(value); }
 }
 public void SetSceneClassID(Int32 value) { 
 hasSceneClassID = true;
 sceneClassID_ = value;
 }

public const int difficultyFieldNumber = 2;
 private bool hasDifficulty;
 private Int32 difficulty_ = 0;
 public bool HasDifficulty {
 get { return hasDifficulty; }
 }
 public Int32 Difficulty {
 get { return difficulty_; }
 set { SetDifficulty(value); }
 }
 public void SetDifficulty(Int32 value) { 
 hasDifficulty = true;
 difficulty_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSceneClassID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SceneClassID);
}
 if (HasDifficulty) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Difficulty);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSceneClassID) {
output.WriteInt32(1, SceneClassID);
}
 
if (HasDifficulty) {
output.WriteInt32(2, Difficulty);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_AUTOTEAM _inst = (CG_ASK_AUTOTEAM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SceneClassID = input.ReadInt32();
break;
}
   case  16: {
 _inst.Difficulty = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSceneClassID) return false;
 if (!hasDifficulty) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_AUTOTEAM : PacketDistributed
{
public enum RESULTTYPE 
 { 
  TYPE_NORMAL = 0,  // ���� 
  TYPE_WAIT = 1,   // �ȴ� 
  TYPE_FINISH = 2,  // �ɹ� 
 }
public const int resultFieldNumber = 1;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

public const int sceneidFieldNumber = 2;
 private bool hasSceneid;
 private Int32 sceneid_ = 0;
 public bool HasSceneid {
 get { return hasSceneid; }
 }
 public Int32 Sceneid {
 get { return sceneid_; }
 set { SetSceneid(value); }
 }
 public void SetSceneid(Int32 value) { 
 hasSceneid = true;
 sceneid_ = value;
 }

public const int difficultFieldNumber = 3;
 private bool hasDifficult;
 private Int32 difficult_ = 0;
 public bool HasDifficult {
 get { return hasDifficult; }
 }
 public Int32 Difficult {
 get { return difficult_; }
 set { SetDifficult(value); }
 }
 public void SetDifficult(Int32 value) { 
 hasDifficult = true;
 difficult_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 if (HasSceneid) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Sceneid);
}
 if (HasDifficult) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Difficult);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 
if (HasSceneid) {
output.WriteInt32(2, Sceneid);
}
 
if (HasDifficult) {
output.WriteInt32(3, Difficult);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_RET_AUTOTEAM _inst = (GC_RET_AUTOTEAM) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.Sceneid = input.ReadInt32();
break;
}
   case  24: {
 _inst.Difficult = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 return true;
 }

}


[Serializable]
public class CG_FELLOW_STAR : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int materialguidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> materialguid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> materialguidList {
 get { return pbc::Lists.AsReadOnly(materialguid_); }
 }
 
 public int materialguidCount {
 get { return materialguid_.Count; }
 }
 
public UInt64 GetMaterialguid(int index) {
 return materialguid_[index];
 }
 public void AddMaterialguid(UInt64 value) {
 materialguid_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
{
int dataSize = 0;
for(int i=0; i<materialguidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(materialguidList[i]);
}
size += dataSize;
size += 1 * materialguid_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
{
if (materialguid_.Count > 0) {
for(int i=0; i<materialguid_.Count; ++i){
output.WriteUInt64(2,materialguid_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_FELLOW_STAR _inst = (CG_FELLOW_STAR) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.AddMaterialguid(input.ReadUInt64());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 return true;
 }

}


[Serializable]
public class GC_FELLOW_STAR_RET : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int resultFieldNumber = 2;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
 if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Result);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
 
if (HasResult) {
output.WriteInt32(2, Result);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_FELLOW_STAR_RET _inst = (GC_FELLOW_STAR_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.Result = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 if (!hasResult) return false;
 return true;
 }

}


[Serializable]
public class CG_FELLOW_ENCHANCE : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int materialguidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> materialguid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> materialguidList {
 get { return pbc::Lists.AsReadOnly(materialguid_); }
 }
 
 public int materialguidCount {
 get { return materialguid_.Count; }
 }
 
public UInt64 GetMaterialguid(int index) {
 return materialguid_[index];
 }
 public void AddMaterialguid(UInt64 value) {
 materialguid_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
{
int dataSize = 0;
for(int i=0; i<materialguidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(materialguidList[i]);
}
size += dataSize;
size += 1 * materialguid_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
{
if (materialguid_.Count > 0) {
for(int i=0; i<materialguid_.Count; ++i){
output.WriteUInt64(2,materialguid_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_FELLOW_ENCHANCE _inst = (CG_FELLOW_ENCHANCE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.AddMaterialguid(input.ReadUInt64());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 return true;
 }

}


[Serializable]
public class GC_FELLOW_ENCHANCE_RET : PacketDistributed
{

public const int resultFieldNumber = 1;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

public const int mainguidFieldNumber = 2;
 private bool hasMainguid;
 private UInt64 mainguid_ = 0;
 public bool HasMainguid {
 get { return hasMainguid; }
 }
 public UInt64 Mainguid {
 get { return mainguid_; }
 set { SetMainguid(value); }
 }
 public void SetMainguid(UInt64 value) { 
 hasMainguid = true;
 mainguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 if (HasMainguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Mainguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 
if (HasMainguid) {
output.WriteUInt64(2, Mainguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_FELLOW_ENCHANCE_RET _inst = (GC_FELLOW_ENCHANCE_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.Mainguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 if (!hasMainguid) return false;
 return true;
 }

}


[Serializable]
public class CG_FELLOW_APPLY_POINT : PacketDistributed
{

public const int attackaddFieldNumber = 1;
 private bool hasAttackadd;
 private Int32 attackadd_ = 0;
 public bool HasAttackadd {
 get { return hasAttackadd; }
 }
 public Int32 Attackadd {
 get { return attackadd_; }
 set { SetAttackadd(value); }
 }
 public void SetAttackadd(Int32 value) { 
 hasAttackadd = true;
 attackadd_ = value;
 }

public const int hitaddFieldNumber = 2;
 private bool hasHitadd;
 private Int32 hitadd_ = 0;
 public bool HasHitadd {
 get { return hasHitadd; }
 }
 public Int32 Hitadd {
 get { return hitadd_; }
 set { SetHitadd(value); }
 }
 public void SetHitadd(Int32 value) { 
 hasHitadd = true;
 hitadd_ = value;
 }

public const int criticaladdFieldNumber = 3;
 private bool hasCriticaladd;
 private Int32 criticaladd_ = 0;
 public bool HasCriticaladd {
 get { return hasCriticaladd; }
 }
 public Int32 Criticaladd {
 get { return criticaladd_; }
 set { SetCriticaladd(value); }
 }
 public void SetCriticaladd(Int32 value) { 
 hasCriticaladd = true;
 criticaladd_ = value;
 }

public const int guardaddFieldNumber = 4;
 private bool hasGuardadd;
 private Int32 guardadd_ = 0;
 public bool HasGuardadd {
 get { return hasGuardadd; }
 }
 public Int32 Guardadd {
 get { return guardadd_; }
 set { SetGuardadd(value); }
 }
 public void SetGuardadd(Int32 value) { 
 hasGuardadd = true;
 guardadd_ = value;
 }

public const int blessaddFieldNumber = 5;
 private bool hasBlessadd;
 private Int32 blessadd_ = 0;
 public bool HasBlessadd {
 get { return hasBlessadd; }
 }
 public Int32 Blessadd {
 get { return blessadd_; }
 set { SetBlessadd(value); }
 }
 public void SetBlessadd(Int32 value) { 
 hasBlessadd = true;
 blessadd_ = value;
 }

public const int fellowguidFieldNumber = 6;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasAttackadd) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Attackadd);
}
 if (HasHitadd) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Hitadd);
}
 if (HasCriticaladd) {
size += pb::CodedOutputStream.ComputeInt32Size(3, Criticaladd);
}
 if (HasGuardadd) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Guardadd);
}
 if (HasBlessadd) {
size += pb::CodedOutputStream.ComputeInt32Size(5, Blessadd);
}
 if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(6, Fellowguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasAttackadd) {
output.WriteInt32(1, Attackadd);
}
 
if (HasHitadd) {
output.WriteInt32(2, Hitadd);
}
 
if (HasCriticaladd) {
output.WriteInt32(3, Criticaladd);
}
 
if (HasGuardadd) {
output.WriteInt32(4, Guardadd);
}
 
if (HasBlessadd) {
output.WriteInt32(5, Blessadd);
}
 
if (HasFellowguid) {
output.WriteUInt64(6, Fellowguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_FELLOW_APPLY_POINT _inst = (CG_FELLOW_APPLY_POINT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Attackadd = input.ReadInt32();
break;
}
   case  16: {
 _inst.Hitadd = input.ReadInt32();
break;
}
   case  24: {
 _inst.Criticaladd = input.ReadInt32();
break;
}
   case  32: {
 _inst.Guardadd = input.ReadInt32();
break;
}
   case  40: {
 _inst.Blessadd = input.ReadInt32();
break;
}
   case  48: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasAttackadd) return false;
 if (!hasHitadd) return false;
 if (!hasCriticaladd) return false;
 if (!hasGuardadd) return false;
 if (!hasBlessadd) return false;
 if (!hasFellowguid) return false;
 return true;
 }

}


[Serializable]
public class GC_FELLOW_APPLY_POINT_RET : PacketDistributed
{

public const int resultFieldNumber = 1;
 private bool hasResult;
 private Int32 result_ = 0;
 public bool HasResult {
 get { return hasResult; }
 }
 public Int32 Result {
 get { return result_; }
 set { SetResult(value); }
 }
 public void SetResult(Int32 value) { 
 hasResult = true;
 result_ = value;
 }

public const int fellowguidFieldNumber = 2;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasResult) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Result);
}
 if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(2, Fellowguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasResult) {
output.WriteInt32(1, Result);
}
 
if (HasFellowguid) {
output.WriteUInt64(2, Fellowguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_FELLOW_APPLY_POINT_RET _inst = (GC_FELLOW_APPLY_POINT_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Result = input.ReadInt32();
break;
}
   case  16: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasResult) return false;
 if (!hasFellowguid) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_REQ_LIST : PacketDistributed
{

public const int requesterFieldNumber = 1;
 private bool hasRequester;
 private UInt64 requester_ = 0;
 public bool HasRequester {
 get { return hasRequester; }
 }
 public UInt64 Requester {
 get { return requester_; }
 set { SetRequester(value); }
 }
 public void SetRequester(UInt64 value) { 
 hasRequester = true;
 requester_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequester) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Requester);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequester) {
output.WriteUInt64(1, Requester);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_REQ_LIST _inst = (CG_GUILD_REQ_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Requester = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequester) return false;
 return true;
 }

}


[Serializable]
public class GC_GUILD_RET_LIST : PacketDistributed
{

public const int preserveGuildGuidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> preserveGuildGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> preserveGuildGuidList {
 get { return pbc::Lists.AsReadOnly(preserveGuildGuid_); }
 }
 
 public int preserveGuildGuidCount {
 get { return preserveGuildGuid_.Count; }
 }
 
public UInt64 GetPreserveGuildGuid(int index) {
 return preserveGuildGuid_[index];
 }
 public void AddPreserveGuildGuid(UInt64 value) {
 preserveGuildGuid_.Add(value);
 }

public const int guildGuidFieldNumber = 2;
 private pbc::PopsicleList<UInt64> guildGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guildGuidList {
 get { return pbc::Lists.AsReadOnly(guildGuid_); }
 }
 
 public int guildGuidCount {
 get { return guildGuid_.Count; }
 }
 
public UInt64 GetGuildGuid(int index) {
 return guildGuid_[index];
 }
 public void AddGuildGuid(UInt64 value) {
 guildGuid_.Add(value);
 }

public const int guildNameFieldNumber = 3;
 private pbc::PopsicleList<string> guildName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> guildNameList {
 get { return pbc::Lists.AsReadOnly(guildName_); }
 }
 
 public int guildNameCount {
 get { return guildName_.Count; }
 }
 
public string GetGuildName(int index) {
 return guildName_[index];
 }
 public void AddGuildName(string value) {
 guildName_.Add(value);
 }

public const int guildChiefNameFieldNumber = 4;
 private pbc::PopsicleList<string> guildChiefName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> guildChiefNameList {
 get { return pbc::Lists.AsReadOnly(guildChiefName_); }
 }
 
 public int guildChiefNameCount {
 get { return guildChiefName_.Count; }
 }
 
public string GetGuildChiefName(int index) {
 return guildChiefName_[index];
 }
 public void AddGuildChiefName(string value) {
 guildChiefName_.Add(value);
 }

public const int guildLevelFieldNumber = 5;
 private pbc::PopsicleList<Int32> guildLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> guildLevelList {
 get { return pbc::Lists.AsReadOnly(guildLevel_); }
 }
 
 public int guildLevelCount {
 get { return guildLevel_.Count; }
 }
 
public Int32 GetGuildLevel(int index) {
 return guildLevel_[index];
 }
 public void AddGuildLevel(Int32 value) {
 guildLevel_.Add(value);
 }

public const int guildMemberNumFieldNumber = 6;
 private pbc::PopsicleList<Int32> guildMemberNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> guildMemberNumList {
 get { return pbc::Lists.AsReadOnly(guildMemberNum_); }
 }
 
 public int guildMemberNumCount {
 get { return guildMemberNum_.Count; }
 }
 
public Int32 GetGuildMemberNum(int index) {
 return guildMemberNum_[index];
 }
 public void AddGuildMemberNum(Int32 value) {
 guildMemberNum_.Add(value);
 }

public const int guildCombatFieldNumber = 7;
 private pbc::PopsicleList<Int32> guildCombat_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> guildCombatList {
 get { return pbc::Lists.AsReadOnly(guildCombat_); }
 }
 
 public int guildCombatCount {
 get { return guildCombat_.Count; }
 }
 
public Int32 GetGuildCombat(int index) {
 return guildCombat_[index];
 }
 public void AddGuildCombat(Int32 value) {
 guildCombat_.Add(value);
 }

public const int isEnemyGuildFieldNumber = 8;
 private pbc::PopsicleList<Int32> isEnemyGuild_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> isEnemyGuildList {
 get { return pbc::Lists.AsReadOnly(isEnemyGuild_); }
 }
 
 public int isEnemyGuildCount {
 get { return isEnemyGuild_.Count; }
 }
 
public Int32 GetIsEnemyGuild(int index) {
 return isEnemyGuild_[index];
 }
 public void AddIsEnemyGuild(Int32 value) {
 isEnemyGuild_.Add(value);
 }

public const int guildApplyNumFieldNumber = 9;
 private pbc::PopsicleList<Int32> guildApplyNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> guildApplyNumList {
 get { return pbc::Lists.AsReadOnly(guildApplyNum_); }
 }
 
 public int guildApplyNumCount {
 get { return guildApplyNum_.Count; }
 }
 
public Int32 GetGuildApplyNum(int index) {
 return guildApplyNum_[index];
 }
 public void AddGuildApplyNum(Int32 value) {
 guildApplyNum_.Add(value);
 }

public const int guildApplyMaxNumFieldNumber = 10;
 private pbc::PopsicleList<Int32> guildApplyMaxNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> guildApplyMaxNumList {
 get { return pbc::Lists.AsReadOnly(guildApplyMaxNum_); }
 }
 
 public int guildApplyMaxNumCount {
 get { return guildApplyMaxNum_.Count; }
 }
 
public Int32 GetGuildApplyMaxNum(int index) {
 return guildApplyMaxNum_[index];
 }
 public void AddGuildApplyMaxNum(Int32 value) {
 guildApplyMaxNum_.Add(value);
 }

public const int GuildDeclarationFieldNumber = 11;
 private pbc::PopsicleList<string> GuildDeclaration_ = new pbc::PopsicleList<string>();
 public scg::IList<string> GuildDeclarationList {
 get { return pbc::Lists.AsReadOnly(GuildDeclaration_); }
 }
 
 public int GuildDeclarationCount {
 get { return GuildDeclaration_.Count; }
 }
 
public string GetGuildDeclaration(int index) {
 return GuildDeclaration_[index];
 }
 public void AddGuildDeclaration(string value) {
 GuildDeclaration_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<preserveGuildGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(preserveGuildGuidList[i]);
}
size += dataSize;
size += 1 * preserveGuildGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(guildGuidList[i]);
}
size += dataSize;
size += 1 * guildGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(guildNameList[i]);
}
size += dataSize;
size += 1 * guildName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildChiefNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(guildChiefNameList[i]);
}
size += dataSize;
size += 1 * guildChiefName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(guildLevelList[i]);
}
size += dataSize;
size += 1 * guildLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildMemberNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(guildMemberNumList[i]);
}
size += dataSize;
size += 1 * guildMemberNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildCombatList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(guildCombatList[i]);
}
size += dataSize;
size += 1 * guildCombat_.Count;
}
{
int dataSize = 0;
for(int i=0; i<isEnemyGuildList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(isEnemyGuildList[i]);
}
size += dataSize;
size += 1 * isEnemyGuild_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildApplyNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(guildApplyNumList[i]);
}
size += dataSize;
size += 1 * guildApplyNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<guildApplyMaxNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(guildApplyMaxNumList[i]);
}
size += dataSize;
size += 1 * guildApplyMaxNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<GuildDeclarationList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(GuildDeclarationList[i]);
}
size += dataSize;
size += 1 * GuildDeclaration_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (preserveGuildGuid_.Count > 0) {
for(int i=0; i<preserveGuildGuid_.Count; ++i){
output.WriteUInt64(1,preserveGuildGuid_[i]);
}
}

}
{
if (guildGuid_.Count > 0) {
for(int i=0; i<guildGuid_.Count; ++i){
output.WriteUInt64(2,guildGuid_[i]);
}
}

}
{
if (guildName_.Count > 0) {
for(int i=0; i<guildName_.Count; ++i){
output.WriteString(3,guildName_[i]);
}
}

}
{
if (guildChiefName_.Count > 0) {
for(int i=0; i<guildChiefName_.Count; ++i){
output.WriteString(4,guildChiefName_[i]);
}
}

}
{
if (guildLevel_.Count > 0) {
for(int i=0; i<guildLevel_.Count; ++i){
output.WriteInt32(5,guildLevel_[i]);
}
}

}
{
if (guildMemberNum_.Count > 0) {
for(int i=0; i<guildMemberNum_.Count; ++i){
output.WriteInt32(6,guildMemberNum_[i]);
}
}

}
{
if (guildCombat_.Count > 0) {
for(int i=0; i<guildCombat_.Count; ++i){
output.WriteInt32(7,guildCombat_[i]);
}
}

}
{
if (isEnemyGuild_.Count > 0) {
for(int i=0; i<isEnemyGuild_.Count; ++i){
output.WriteInt32(8,isEnemyGuild_[i]);
}
}

}
{
if (guildApplyNum_.Count > 0) {
for(int i=0; i<guildApplyNum_.Count; ++i){
output.WriteInt32(9,guildApplyNum_[i]);
}
}

}
{
if (guildApplyMaxNum_.Count > 0) {
for(int i=0; i<guildApplyMaxNum_.Count; ++i){
output.WriteInt32(10,guildApplyMaxNum_[i]);
}
}

}
{
if (GuildDeclaration_.Count > 0) {
for(int i=0; i<GuildDeclaration_.Count; ++i){
output.WriteString(11,GuildDeclaration_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_GUILD_RET_LIST _inst = (GC_GUILD_RET_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddPreserveGuildGuid(input.ReadUInt64());
break;
}
   case  16: {
 _inst.AddGuildGuid(input.ReadUInt64());
break;
}
   case  26: {
 _inst.AddGuildName(input.ReadString());
break;
}
   case  34: {
 _inst.AddGuildChiefName(input.ReadString());
break;
}
   case  40: {
 _inst.AddGuildLevel(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddGuildMemberNum(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddGuildCombat(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddIsEnemyGuild(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddGuildApplyNum(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddGuildApplyMaxNum(input.ReadInt32());
break;
}
   case  90: {
 _inst.AddGuildDeclaration(input.ReadString());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_GUILD_REQ_INFO : PacketDistributed
{

public const int requesterFieldNumber = 1;
 private bool hasRequester;
 private UInt64 requester_ = 0;
 public bool HasRequester {
 get { return hasRequester; }
 }
 public UInt64 Requester {
 get { return requester_; }
 set { SetRequester(value); }
 }
 public void SetRequester(UInt64 value) { 
 hasRequester = true;
 requester_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequester) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Requester);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequester) {
output.WriteUInt64(1, Requester);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_REQ_INFO _inst = (CG_GUILD_REQ_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Requester = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequester) return false;
 return true;
 }

}


[Serializable]
public class GC_GUILD_RET_INFO : PacketDistributed
{

public const int guildGuidFieldNumber = 1;
 private bool hasGuildGuid;
 private UInt64 guildGuid_ = 0;
 public bool HasGuildGuid {
 get { return hasGuildGuid; }
 }
 public UInt64 GuildGuid {
 get { return guildGuid_; }
 set { SetGuildGuid(value); }
 }
 public void SetGuildGuid(UInt64 value) { 
 hasGuildGuid = true;
 guildGuid_ = value;
 }

public const int guildNameFieldNumber = 2;
 private bool hasGuildName;
 private string guildName_ = "";
 public bool HasGuildName {
 get { return hasGuildName; }
 }
 public string GuildName {
 get { return guildName_; }
 set { SetGuildName(value); }
 }
 public void SetGuildName(string value) { 
 hasGuildName = true;
 guildName_ = value;
 }

public const int guildChiefGuidFieldNumber = 3;
 private bool hasGuildChiefGuid;
 private UInt64 guildChiefGuid_ = 0;
 public bool HasGuildChiefGuid {
 get { return hasGuildChiefGuid; }
 }
 public UInt64 GuildChiefGuid {
 get { return guildChiefGuid_; }
 set { SetGuildChiefGuid(value); }
 }
 public void SetGuildChiefGuid(UInt64 value) { 
 hasGuildChiefGuid = true;
 guildChiefGuid_ = value;
 }

public const int guildLevelFieldNumber = 4;
 private bool hasGuildLevel;
 private Int32 guildLevel_ = 0;
 public bool HasGuildLevel {
 get { return hasGuildLevel; }
 }
 public Int32 GuildLevel {
 get { return guildLevel_; }
 set { SetGuildLevel(value); }
 }
 public void SetGuildLevel(Int32 value) { 
 hasGuildLevel = true;
 guildLevel_ = value;
 }

public const int guildExpFieldNumber = 5;
 private bool hasGuildExp;
 private Int32 guildExp_ = 0;
 public bool HasGuildExp {
 get { return hasGuildExp; }
 }
 public Int32 GuildExp {
 get { return guildExp_; }
 set { SetGuildExp(value); }
 }
 public void SetGuildExp(Int32 value) { 
 hasGuildExp = true;
 guildExp_ = value;
 }

public const int guildNoticeFieldNumber = 6;
 private bool hasGuildNotice;
 private string guildNotice_ = "";
 public bool HasGuildNotice {
 get { return hasGuildNotice; }
 }
 public string GuildNotice {
 get { return guildNotice_; }
 set { SetGuildNotice(value); }
 }
 public void SetGuildNotice(string value) { 
 hasGuildNotice = true;
 guildNotice_ = value;
 }

public const int memberGuidFieldNumber = 7;
 private pbc::PopsicleList<UInt64> memberGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> memberGuidList {
 get { return pbc::Lists.AsReadOnly(memberGuid_); }
 }
 
 public int memberGuidCount {
 get { return memberGuid_.Count; }
 }
 
public UInt64 GetMemberGuid(int index) {
 return memberGuid_[index];
 }
 public void AddMemberGuid(UInt64 value) {
 memberGuid_.Add(value);
 }

public const int memberNameFieldNumber = 8;
 private pbc::PopsicleList<string> memberName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> memberNameList {
 get { return pbc::Lists.AsReadOnly(memberName_); }
 }
 
 public int memberNameCount {
 get { return memberName_.Count; }
 }
 
public string GetMemberName(int index) {
 return memberName_[index];
 }
 public void AddMemberName(string value) {
 memberName_.Add(value);
 }

public const int memberVIPFieldNumber = 9;
 private pbc::PopsicleList<Int32> memberVIP_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberVIPList {
 get { return pbc::Lists.AsReadOnly(memberVIP_); }
 }
 
 public int memberVIPCount {
 get { return memberVIP_.Count; }
 }
 
public Int32 GetMemberVIP(int index) {
 return memberVIP_[index];
 }
 public void AddMemberVIP(Int32 value) {
 memberVIP_.Add(value);
 }

public const int memberProfFieldNumber = 10;
 private pbc::PopsicleList<Int32> memberProf_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberProfList {
 get { return pbc::Lists.AsReadOnly(memberProf_); }
 }
 
 public int memberProfCount {
 get { return memberProf_.Count; }
 }
 
public Int32 GetMemberProf(int index) {
 return memberProf_[index];
 }
 public void AddMemberProf(Int32 value) {
 memberProf_.Add(value);
 }

public const int memberLevelFieldNumber = 11;
 private pbc::PopsicleList<Int32> memberLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberLevelList {
 get { return pbc::Lists.AsReadOnly(memberLevel_); }
 }
 
 public int memberLevelCount {
 get { return memberLevel_.Count; }
 }
 
public Int32 GetMemberLevel(int index) {
 return memberLevel_[index];
 }
 public void AddMemberLevel(Int32 value) {
 memberLevel_.Add(value);
 }

public const int memberContirbuteFieldNumber = 12;
 private pbc::PopsicleList<Int32> memberContirbute_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberContirbuteList {
 get { return pbc::Lists.AsReadOnly(memberContirbute_); }
 }
 
 public int memberContirbuteCount {
 get { return memberContirbute_.Count; }
 }
 
public Int32 GetMemberContirbute(int index) {
 return memberContirbute_[index];
 }
 public void AddMemberContirbute(Int32 value) {
 memberContirbute_.Add(value);
 }

public const int memberLastLogoutFieldNumber = 13;
 private pbc::PopsicleList<Int32> memberLastLogout_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberLastLogoutList {
 get { return pbc::Lists.AsReadOnly(memberLastLogout_); }
 }
 
 public int memberLastLogoutCount {
 get { return memberLastLogout_.Count; }
 }
 
public Int32 GetMemberLastLogout(int index) {
 return memberLastLogout_[index];
 }
 public void AddMemberLastLogout(Int32 value) {
 memberLastLogout_.Add(value);
 }

public const int memberStateFieldNumber = 14;
 private pbc::PopsicleList<Int32> memberState_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberStateList {
 get { return pbc::Lists.AsReadOnly(memberState_); }
 }
 
 public int memberStateCount {
 get { return memberState_.Count; }
 }
 
public Int32 GetMemberState(int index) {
 return memberState_[index];
 }
 public void AddMemberState(Int32 value) {
 memberState_.Add(value);
 }

public const int memberJobFieldNumber = 15;
 private pbc::PopsicleList<Int32> memberJob_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberJobList {
 get { return pbc::Lists.AsReadOnly(memberJob_); }
 }
 
 public int memberJobCount {
 get { return memberJob_.Count; }
 }
 
public Int32 GetMemberJob(int index) {
 return memberJob_[index];
 }
 public void AddMemberJob(Int32 value) {
 memberJob_.Add(value);
 }

public const int combatvalFieldNumber = 16;
 private pbc::PopsicleList<Int32> combatval_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> combatvalList {
 get { return pbc::Lists.AsReadOnly(combatval_); }
 }
 
 public int combatvalCount {
 get { return combatval_.Count; }
 }
 
public Int32 GetCombatval(int index) {
 return combatval_[index];
 }
 public void AddCombatval(Int32 value) {
 combatval_.Add(value);
 }

public const int pscanacpttimesFieldNumber = 17;
 private bool hasPscanacpttimes;
 private Int32 pscanacpttimes_ = 0;
 public bool HasPscanacpttimes {
 get { return hasPscanacpttimes; }
 }
 public Int32 Pscanacpttimes {
 get { return pscanacpttimes_; }
 set { SetPscanacpttimes(value); }
 }
 public void SetPscanacpttimes(Int32 value) { 
 hasPscanacpttimes = true;
 pscanacpttimes_ = value;
 }

public const int GuildHistoryTypeFieldNumber = 18;
 private pbc::PopsicleList<Int32> GuildHistoryType_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> GuildHistoryTypeList {
 get { return pbc::Lists.AsReadOnly(GuildHistoryType_); }
 }
 
 public int GuildHistoryTypeCount {
 get { return GuildHistoryType_.Count; }
 }
 
public Int32 GetGuildHistoryType(int index) {
 return GuildHistoryType_[index];
 }
 public void AddGuildHistoryType(Int32 value) {
 GuildHistoryType_.Add(value);
 }

public const int GuildHistoryTimeFieldNumber = 19;
 private pbc::PopsicleList<Int32> GuildHistoryTime_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> GuildHistoryTimeList {
 get { return pbc::Lists.AsReadOnly(GuildHistoryTime_); }
 }
 
 public int GuildHistoryTimeCount {
 get { return GuildHistoryTime_.Count; }
 }
 
public Int32 GetGuildHistoryTime(int index) {
 return GuildHistoryTime_[index];
 }
 public void AddGuildHistoryTime(Int32 value) {
 GuildHistoryTime_.Add(value);
 }

public const int GuildHistoryTextFieldNumber = 20;
 private pbc::PopsicleList<string> GuildHistoryText_ = new pbc::PopsicleList<string>();
 public scg::IList<string> GuildHistoryTextList {
 get { return pbc::Lists.AsReadOnly(GuildHistoryText_); }
 }
 
 public int GuildHistoryTextCount {
 get { return GuildHistoryText_.Count; }
 }
 
public string GetGuildHistoryText(int index) {
 return GuildHistoryText_[index];
 }
 public void AddGuildHistoryText(string value) {
 GuildHistoryText_.Add(value);
 }

public const int ViceChiefRoutineFieldNumber = 21;
 private pbc::PopsicleList<Int32> ViceChiefRoutine_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ViceChiefRoutineList {
 get { return pbc::Lists.AsReadOnly(ViceChiefRoutine_); }
 }
 
 public int ViceChiefRoutineCount {
 get { return ViceChiefRoutine_.Count; }
 }
 
public Int32 GetViceChiefRoutine(int index) {
 return ViceChiefRoutine_[index];
 }
 public void AddViceChiefRoutine(Int32 value) {
 ViceChiefRoutine_.Add(value);
 }

public const int ElderRoutineFieldNumber = 22;
 private pbc::PopsicleList<Int32> ElderRoutine_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> ElderRoutineList {
 get { return pbc::Lists.AsReadOnly(ElderRoutine_); }
 }
 
 public int ElderRoutineCount {
 get { return ElderRoutine_.Count; }
 }
 
public Int32 GetElderRoutine(int index) {
 return ElderRoutine_[index];
 }
 public void AddElderRoutine(Int32 value) {
 ElderRoutine_.Add(value);
 }

public const int GuildJobNameFieldNumber = 23;
 private pbc::PopsicleList<string> GuildJobName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> GuildJobNameList {
 get { return pbc::Lists.AsReadOnly(GuildJobName_); }
 }
 
 public int GuildJobNameCount {
 get { return GuildJobName_.Count; }
 }
 
public string GetGuildJobName(int index) {
 return GuildJobName_[index];
 }
 public void AddGuildJobName(string value) {
 GuildJobName_.Add(value);
 }

public const int LastWeekContriFieldNumber = 24;
 private bool hasLastWeekContri;
 private Int32 LastWeekContri_ = 0;
 public bool HasLastWeekContri {
 get { return hasLastWeekContri; }
 }
 public Int32 LastWeekContri {
 get { return LastWeekContri_; }
 set { SetLastWeekContri(value); }
 }
 public void SetLastWeekContri(Int32 value) { 
 hasLastWeekContri = true;
 LastWeekContri_ = value;
 }

public const int NeedReserveFieldNumber = 25;
 private bool hasNeedReserve;
 private Int32 NeedReserve_ = 0;
 public bool HasNeedReserve {
 get { return hasNeedReserve; }
 }
 public Int32 NeedReserve {
 get { return NeedReserve_; }
 set { SetNeedReserve(value); }
 }
 public void SetNeedReserve(Int32 value) { 
 hasNeedReserve = true;
 NeedReserve_ = value;
 }

public const int GuildDeclarationFieldNumber = 26;
 private bool hasGuildDeclaration;
 private string GuildDeclaration_ = "";
 public bool HasGuildDeclaration {
 get { return hasGuildDeclaration; }
 }
 public string GuildDeclaration {
 get { return GuildDeclaration_; }
 set { SetGuildDeclaration(value); }
 }
 public void SetGuildDeclaration(string value) { 
 hasGuildDeclaration = true;
 GuildDeclaration_ = value;
 }

public const int HideAndSeekWeekFieldNumber = 27;
 private bool hasHideAndSeekWeek;
 private Int32 HideAndSeekWeek_ = 0;
 public bool HasHideAndSeekWeek {
 get { return hasHideAndSeekWeek; }
 }
 public Int32 HideAndSeekWeek {
 get { return HideAndSeekWeek_; }
 set { SetHideAndSeekWeek(value); }
 }
 public void SetHideAndSeekWeek(Int32 value) { 
 hasHideAndSeekWeek = true;
 HideAndSeekWeek_ = value;
 }

public const int SceneNpcIdFieldNumber = 28;
 private pbc::PopsicleList<Int32> SceneNpcId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> SceneNpcIdList {
 get { return pbc::Lists.AsReadOnly(SceneNpcId_); }
 }
 
 public int SceneNpcIdCount {
 get { return SceneNpcId_.Count; }
 }
 
public Int32 GetSceneNpcId(int index) {
 return SceneNpcId_[index];
 }
 public void AddSceneNpcId(Int32 value) {
 SceneNpcId_.Add(value);
 }

public const int SceneNpcFindFieldNumber = 29;
 private pbc::PopsicleList<Int32> SceneNpcFind_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> SceneNpcFindList {
 get { return pbc::Lists.AsReadOnly(SceneNpcFind_); }
 }
 
 public int SceneNpcFindCount {
 get { return SceneNpcFind_.Count; }
 }
 
public Int32 GetSceneNpcFind(int index) {
 return SceneNpcFind_[index];
 }
 public void AddSceneNpcFind(Int32 value) {
 SceneNpcFind_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuildGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, GuildGuid);
}
 if (HasGuildName) {
size += pb::CodedOutputStream.ComputeStringSize(2, GuildName);
}
 if (HasGuildChiefGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, GuildChiefGuid);
}
 if (HasGuildLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(4, GuildLevel);
}
 if (HasGuildExp) {
size += pb::CodedOutputStream.ComputeInt32Size(5, GuildExp);
}
 if (HasGuildNotice) {
size += pb::CodedOutputStream.ComputeStringSize(6, GuildNotice);
}
{
int dataSize = 0;
for(int i=0; i<memberGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(memberGuidList[i]);
}
size += dataSize;
size += 1 * memberGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(memberNameList[i]);
}
size += dataSize;
size += 1 * memberName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberVIPList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberVIPList[i]);
}
size += dataSize;
size += 1 * memberVIP_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberProfList[i]);
}
size += dataSize;
size += 1 * memberProf_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberLevelList[i]);
}
size += dataSize;
size += 1 * memberLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberContirbuteList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberContirbuteList[i]);
}
size += dataSize;
size += 1 * memberContirbute_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberLastLogoutList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberLastLogoutList[i]);
}
size += dataSize;
size += 1 * memberLastLogout_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberStateList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberStateList[i]);
}
size += dataSize;
size += 1 * memberState_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberJobList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberJobList[i]);
}
size += dataSize;
size += 1 * memberJob_.Count;
}
{
int dataSize = 0;
for(int i=0; i<combatvalList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(combatvalList[i]);
}
size += dataSize;
size += 1 * combatval_.Count;
}
 if (HasPscanacpttimes) {
size += pb::CodedOutputStream.ComputeInt32Size(17, Pscanacpttimes);
}
{
int dataSize = 0;
for(int i=0; i<GuildHistoryTypeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(GuildHistoryTypeList[i]);
}
size += dataSize;
size += 1 * GuildHistoryType_.Count;
}
{
int dataSize = 0;
for(int i=0; i<GuildHistoryTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(GuildHistoryTimeList[i]);
}
size += dataSize;
size += 1 * GuildHistoryTime_.Count;
}
{
int dataSize = 0;
for(int i=0; i<GuildHistoryTextList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(GuildHistoryTextList[i]);
}
size += dataSize;
size += 1 * GuildHistoryText_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ViceChiefRoutineList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ViceChiefRoutineList[i]);
}
size += dataSize;
size += 1 * ViceChiefRoutine_.Count;
}
{
int dataSize = 0;
for(int i=0; i<ElderRoutineList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(ElderRoutineList[i]);
}
size += dataSize;
size += 1 * ElderRoutine_.Count;
}
{
int dataSize = 0;
for(int i=0; i<GuildJobNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(GuildJobNameList[i]);
}
size += dataSize;
size += 1 * GuildJobName_.Count;
}
 if (HasLastWeekContri) {
size += pb::CodedOutputStream.ComputeInt32Size(24, LastWeekContri);
}
 if (HasNeedReserve) {
size += pb::CodedOutputStream.ComputeInt32Size(25, NeedReserve);
}
 if (HasGuildDeclaration) {
size += pb::CodedOutputStream.ComputeStringSize(26, GuildDeclaration);
}
 if (HasHideAndSeekWeek) {
size += pb::CodedOutputStream.ComputeInt32Size(27, HideAndSeekWeek);
}
{
int dataSize = 0;
for(int i=0; i<SceneNpcIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(SceneNpcIdList[i]);
}
size += dataSize;
size += 1 * SceneNpcId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<SceneNpcFindList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(SceneNpcFindList[i]);
}
size += dataSize;
size += 1 * SceneNpcFind_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuildGuid) {
output.WriteUInt64(1, GuildGuid);
}
 
if (HasGuildName) {
output.WriteString(2, GuildName);
}
 
if (HasGuildChiefGuid) {
output.WriteUInt64(3, GuildChiefGuid);
}
 
if (HasGuildLevel) {
output.WriteInt32(4, GuildLevel);
}
 
if (HasGuildExp) {
output.WriteInt32(5, GuildExp);
}
 
if (HasGuildNotice) {
output.WriteString(6, GuildNotice);
}
{
if (memberGuid_.Count > 0) {
for(int i=0; i<memberGuid_.Count; ++i){
output.WriteUInt64(7,memberGuid_[i]);
}
}

}
{
if (memberName_.Count > 0) {
for(int i=0; i<memberName_.Count; ++i){
output.WriteString(8,memberName_[i]);
}
}

}
{
if (memberVIP_.Count > 0) {
for(int i=0; i<memberVIP_.Count; ++i){
output.WriteInt32(9,memberVIP_[i]);
}
}

}
{
if (memberProf_.Count > 0) {
for(int i=0; i<memberProf_.Count; ++i){
output.WriteInt32(10,memberProf_[i]);
}
}

}
{
if (memberLevel_.Count > 0) {
for(int i=0; i<memberLevel_.Count; ++i){
output.WriteInt32(11,memberLevel_[i]);
}
}

}
{
if (memberContirbute_.Count > 0) {
for(int i=0; i<memberContirbute_.Count; ++i){
output.WriteInt32(12,memberContirbute_[i]);
}
}

}
{
if (memberLastLogout_.Count > 0) {
for(int i=0; i<memberLastLogout_.Count; ++i){
output.WriteInt32(13,memberLastLogout_[i]);
}
}

}
{
if (memberState_.Count > 0) {
for(int i=0; i<memberState_.Count; ++i){
output.WriteInt32(14,memberState_[i]);
}
}

}
{
if (memberJob_.Count > 0) {
for(int i=0; i<memberJob_.Count; ++i){
output.WriteInt32(15,memberJob_[i]);
}
}

}
{
if (combatval_.Count > 0) {
for(int i=0; i<combatval_.Count; ++i){
output.WriteInt32(16,combatval_[i]);
}
}

}
 
if (HasPscanacpttimes) {
output.WriteInt32(17, Pscanacpttimes);
}
{
if (GuildHistoryType_.Count > 0) {
for(int i=0; i<GuildHistoryType_.Count; ++i){
output.WriteInt32(18,GuildHistoryType_[i]);
}
}

}
{
if (GuildHistoryTime_.Count > 0) {
for(int i=0; i<GuildHistoryTime_.Count; ++i){
output.WriteInt32(19,GuildHistoryTime_[i]);
}
}

}
{
if (GuildHistoryText_.Count > 0) {
for(int i=0; i<GuildHistoryText_.Count; ++i){
output.WriteString(20,GuildHistoryText_[i]);
}
}

}
{
if (ViceChiefRoutine_.Count > 0) {
for(int i=0; i<ViceChiefRoutine_.Count; ++i){
output.WriteInt32(21,ViceChiefRoutine_[i]);
}
}

}
{
if (ElderRoutine_.Count > 0) {
for(int i=0; i<ElderRoutine_.Count; ++i){
output.WriteInt32(22,ElderRoutine_[i]);
}
}

}
{
if (GuildJobName_.Count > 0) {
for(int i=0; i<GuildJobName_.Count; ++i){
output.WriteString(23,GuildJobName_[i]);
}
}

}
 
if (HasLastWeekContri) {
output.WriteInt32(24, LastWeekContri);
}
 
if (HasNeedReserve) {
output.WriteInt32(25, NeedReserve);
}
 
if (HasGuildDeclaration) {
output.WriteString(26, GuildDeclaration);
}
 
if (HasHideAndSeekWeek) {
output.WriteInt32(27, HideAndSeekWeek);
}
{
if (SceneNpcId_.Count > 0) {
for(int i=0; i<SceneNpcId_.Count; ++i){
output.WriteInt32(28,SceneNpcId_[i]);
}
}

}
{
if (SceneNpcFind_.Count > 0) {
for(int i=0; i<SceneNpcFind_.Count; ++i){
output.WriteInt32(29,SceneNpcFind_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_GUILD_RET_INFO _inst = (GC_GUILD_RET_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GuildGuid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.GuildName = input.ReadString();
break;
}
   case  24: {
 _inst.GuildChiefGuid = input.ReadUInt64();
break;
}
   case  32: {
 _inst.GuildLevel = input.ReadInt32();
break;
}
   case  40: {
 _inst.GuildExp = input.ReadInt32();
break;
}
   case  50: {
 _inst.GuildNotice = input.ReadString();
break;
}
   case  56: {
 _inst.AddMemberGuid(input.ReadUInt64());
break;
}
   case  66: {
 _inst.AddMemberName(input.ReadString());
break;
}
   case  72: {
 _inst.AddMemberVIP(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddMemberProf(input.ReadInt32());
break;
}
   case  88: {
 _inst.AddMemberLevel(input.ReadInt32());
break;
}
   case  96: {
 _inst.AddMemberContirbute(input.ReadInt32());
break;
}
   case  104: {
 _inst.AddMemberLastLogout(input.ReadInt32());
break;
}
   case  112: {
 _inst.AddMemberState(input.ReadInt32());
break;
}
   case  120: {
 _inst.AddMemberJob(input.ReadInt32());
break;
}
   case  128: {
 _inst.AddCombatval(input.ReadInt32());
break;
}
   case  136: {
 _inst.Pscanacpttimes = input.ReadInt32();
break;
}
   case  144: {
 _inst.AddGuildHistoryType(input.ReadInt32());
break;
}
   case  152: {
 _inst.AddGuildHistoryTime(input.ReadInt32());
break;
}
   case  162: {
 _inst.AddGuildHistoryText(input.ReadString());
break;
}
   case  168: {
 _inst.AddViceChiefRoutine(input.ReadInt32());
break;
}
   case  176: {
 _inst.AddElderRoutine(input.ReadInt32());
break;
}
   case  186: {
 _inst.AddGuildJobName(input.ReadString());
break;
}
   case  192: {
 _inst.LastWeekContri = input.ReadInt32();
break;
}
   case  200: {
 _inst.NeedReserve = input.ReadInt32();
break;
}
   case  210: {
 _inst.GuildDeclaration = input.ReadString();
break;
}
   case  216: {
 _inst.HideAndSeekWeek = input.ReadInt32();
break;
}
   case  224: {
 _inst.AddSceneNpcId(input.ReadInt32());
break;
}
   case  232: {
 _inst.AddSceneNpcFind(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuildGuid) return false;
 if (!hasGuildName) return false;
 if (!hasGuildChiefGuid) return false;
 if (!hasGuildLevel) return false;
 if (!hasGuildExp) return false;
 if (!hasGuildNotice) return false;
 if (!hasLastWeekContri) return false;
 if (!hasNeedReserve) return false;
 if (!hasGuildDeclaration) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_REQ_CHANGE_NOTICE : PacketDistributed
{

public const int guildNoticeFieldNumber = 1;
 private bool hasGuildNotice;
 private string guildNotice_ = "";
 public bool HasGuildNotice {
 get { return hasGuildNotice; }
 }
 public string GuildNotice {
 get { return guildNotice_; }
 set { SetGuildNotice(value); }
 }
 public void SetGuildNotice(string value) { 
 hasGuildNotice = true;
 guildNotice_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuildNotice) {
size += pb::CodedOutputStream.ComputeStringSize(1, GuildNotice);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuildNotice) {
output.WriteString(1, GuildNotice);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_REQ_CHANGE_NOTICE _inst = (CG_GUILD_REQ_CHANGE_NOTICE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.GuildNotice = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuildNotice) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_CREATE : PacketDistributed
{

public const int guildNameFieldNumber = 1;
 private bool hasGuildName;
 private string guildName_ = "";
 public bool HasGuildName {
 get { return hasGuildName; }
 }
 public string GuildName {
 get { return guildName_; }
 set { SetGuildName(value); }
 }
 public void SetGuildName(string value) { 
 hasGuildName = true;
 guildName_ = value;
 }

public const int GuildDeclarationFieldNumber = 2;
 private bool hasGuildDeclaration;
 private string GuildDeclaration_ = "";
 public bool HasGuildDeclaration {
 get { return hasGuildDeclaration; }
 }
 public string GuildDeclaration {
 get { return GuildDeclaration_; }
 set { SetGuildDeclaration(value); }
 }
 public void SetGuildDeclaration(string value) { 
 hasGuildDeclaration = true;
 GuildDeclaration_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuildName) {
size += pb::CodedOutputStream.ComputeStringSize(1, GuildName);
}
 if (HasGuildDeclaration) {
size += pb::CodedOutputStream.ComputeStringSize(2, GuildDeclaration);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuildName) {
output.WriteString(1, GuildName);
}
 
if (HasGuildDeclaration) {
output.WriteString(2, GuildDeclaration);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_CREATE _inst = (CG_GUILD_CREATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.GuildName = input.ReadString();
break;
}
   case  18: {
 _inst.GuildDeclaration = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuildName) return false;
 return true;
 }

}


[Serializable]
public class GC_GUILD_CREATE : PacketDistributed
{

public const int guildGuidFieldNumber = 1;
 private bool hasGuildGuid;
 private UInt64 guildGuid_ = 0;
 public bool HasGuildGuid {
 get { return hasGuildGuid; }
 }
 public UInt64 GuildGuid {
 get { return guildGuid_; }
 set { SetGuildGuid(value); }
 }
 public void SetGuildGuid(UInt64 value) { 
 hasGuildGuid = true;
 guildGuid_ = value;
 }

public const int guildNameFieldNumber = 2;
 private bool hasGuildName;
 private string guildName_ = "";
 public bool HasGuildName {
 get { return hasGuildName; }
 }
 public string GuildName {
 get { return guildName_; }
 set { SetGuildName(value); }
 }
 public void SetGuildName(string value) { 
 hasGuildName = true;
 guildName_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuildGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, GuildGuid);
}
 if (HasGuildName) {
size += pb::CodedOutputStream.ComputeStringSize(2, GuildName);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuildGuid) {
output.WriteUInt64(1, GuildGuid);
}
 
if (HasGuildName) {
output.WriteString(2, GuildName);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_GUILD_CREATE _inst = (GC_GUILD_CREATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GuildGuid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.GuildName = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuildGuid) return false;
 if (!hasGuildName) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_JOIN : PacketDistributed
{

public const int guildGuidFieldNumber = 1;
 private bool hasGuildGuid;
 private UInt64 guildGuid_ = 0;
 public bool HasGuildGuid {
 get { return hasGuildGuid; }
 }
 public UInt64 GuildGuid {
 get { return guildGuid_; }
 set { SetGuildGuid(value); }
 }
 public void SetGuildGuid(UInt64 value) { 
 hasGuildGuid = true;
 guildGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuildGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, GuildGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuildGuid) {
output.WriteUInt64(1, GuildGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_JOIN _inst = (CG_GUILD_JOIN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GuildGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuildGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_GUILD_JOIN : PacketDistributed
{

public const int guildGuidFieldNumber = 1;
 private bool hasGuildGuid;
 private UInt64 guildGuid_ = 0;
 public bool HasGuildGuid {
 get { return hasGuildGuid; }
 }
 public UInt64 GuildGuid {
 get { return guildGuid_; }
 set { SetGuildGuid(value); }
 }
 public void SetGuildGuid(UInt64 value) { 
 hasGuildGuid = true;
 guildGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuildGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, GuildGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuildGuid) {
output.WriteUInt64(1, GuildGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_GUILD_JOIN _inst = (GC_GUILD_JOIN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GuildGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuildGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_LEAVE : PacketDistributed
{

public const int requesterFieldNumber = 1;
 private bool hasRequester;
 private UInt64 requester_ = 0;
 public bool HasRequester {
 get { return hasRequester; }
 }
 public UInt64 Requester {
 get { return requester_; }
 set { SetRequester(value); }
 }
 public void SetRequester(UInt64 value) { 
 hasRequester = true;
 requester_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequester) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Requester);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequester) {
output.WriteUInt64(1, Requester);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_LEAVE _inst = (CG_GUILD_LEAVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Requester = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequester) return false;
 return true;
 }

}


[Serializable]
public class GC_GUILD_LEAVE : PacketDistributed
{

public const int guildGuidFieldNumber = 1;
 private bool hasGuildGuid;
 private UInt64 guildGuid_ = 0;
 public bool HasGuildGuid {
 get { return hasGuildGuid; }
 }
 public UInt64 GuildGuid {
 get { return guildGuid_; }
 set { SetGuildGuid(value); }
 }
 public void SetGuildGuid(UInt64 value) { 
 hasGuildGuid = true;
 guildGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGuildGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, GuildGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGuildGuid) {
output.WriteUInt64(1, GuildGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_GUILD_LEAVE _inst = (GC_GUILD_LEAVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GuildGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGuildGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_KICK : PacketDistributed
{

public const int kickedFieldNumber = 1;
 private bool hasKicked;
 private UInt64 kicked_ = 0;
 public bool HasKicked {
 get { return hasKicked; }
 }
 public UInt64 Kicked {
 get { return kicked_; }
 set { SetKicked(value); }
 }
 public void SetKicked(UInt64 value) { 
 hasKicked = true;
 kicked_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasKicked) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Kicked);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasKicked) {
output.WriteUInt64(1, Kicked);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_KICK _inst = (CG_GUILD_KICK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Kicked = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasKicked) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_JOB_CHANGE : PacketDistributed
{

public const int approverFieldNumber = 1;
 private pbc::PopsicleList<UInt64> approver_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> approverList {
 get { return pbc::Lists.AsReadOnly(approver_); }
 }
 
 public int approverCount {
 get { return approver_.Count; }
 }
 
public UInt64 GetApprover(int index) {
 return approver_[index];
 }
 public void AddApprover(UInt64 value) {
 approver_.Add(value);
 }

public const int jobIDFieldNumber = 2;
 private bool hasJobID;
 private Int32 jobID_ = 0;
 public bool HasJobID {
 get { return hasJobID; }
 }
 public Int32 JobID {
 get { return jobID_; }
 set { SetJobID(value); }
 }
 public void SetJobID(Int32 value) { 
 hasJobID = true;
 jobID_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<approverList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(approverList[i]);
}
size += dataSize;
size += 1 * approver_.Count;
}
 if (HasJobID) {
size += pb::CodedOutputStream.ComputeInt32Size(2, JobID);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (approver_.Count > 0) {
for(int i=0; i<approver_.Count; ++i){
output.WriteUInt64(1,approver_[i]);
}
}

}
 
if (HasJobID) {
output.WriteInt32(2, JobID);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_JOB_CHANGE _inst = (CG_GUILD_JOB_CHANGE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddApprover(input.ReadUInt64());
break;
}
   case  16: {
 _inst.JobID = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasJobID) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_APPROVE_RESERVE : PacketDistributed
{

public const int approverFieldNumber = 1;
 private bool hasApprover;
 private UInt64 approver_ = 0;
 public bool HasApprover {
 get { return hasApprover; }
 }
 public UInt64 Approver {
 get { return approver_; }
 set { SetApprover(value); }
 }
 public void SetApprover(UInt64 value) { 
 hasApprover = true;
 approver_ = value;
 }

public const int isAgreeFieldNumber = 2;
 private bool hasIsAgree;
 private Int32 isAgree_ = 0;
 public bool HasIsAgree {
 get { return hasIsAgree; }
 }
 public Int32 IsAgree {
 get { return isAgree_; }
 set { SetIsAgree(value); }
 }
 public void SetIsAgree(Int32 value) { 
 hasIsAgree = true;
 isAgree_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasApprover) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Approver);
}
 if (HasIsAgree) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsAgree);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasApprover) {
output.WriteUInt64(1, Approver);
}
 
if (HasIsAgree) {
output.WriteInt32(2, IsAgree);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_APPROVE_RESERVE _inst = (CG_GUILD_APPROVE_RESERVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Approver = input.ReadUInt64();
break;
}
   case  16: {
 _inst.IsAgree = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasApprover) return false;
 if (!hasIsAgree) return false;
 return true;
 }

}


[Serializable]
public class CG_GUILD_REQ_LEVELUP : PacketDistributed
{

public const int levelFieldNumber = 1;
 private bool hasLevel;
 private Int32 level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 level_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Level);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasLevel) {
output.WriteInt32(1, Level);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_GUILD_REQ_LEVELUP _inst = (CG_GUILD_REQ_LEVELUP) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Level = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasLevel) return false;
 return true;
 }

}


[Serializable]
public class GC_GUILD_RET_LEVELUP : PacketDistributed
{

public const int levelFieldNumber = 1;
 private bool hasLevel;
 private Int32 level_ = 0;
 public bool HasLevel {
 get { return hasLevel; }
 }
 public Int32 Level {
 get { return level_; }
 set { SetLevel(value); }
 }
 public void SetLevel(Int32 value) { 
 hasLevel = true;
 level_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasLevel) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Level);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasLevel) {
output.WriteInt32(1, Level);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_GUILD_RET_LEVELUP _inst = (GC_GUILD_RET_LEVELUP) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Level = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasLevel) return false;
 return true;
 }

}


[Serializable]
public class GC_DYNAMICOBSTACLE_OPT : PacketDistributed
{

public const int indexFieldNumber = 1;
 private bool hasIndex;
 private Int32 index_ = 0;
 public bool HasIndex {
 get { return hasIndex; }
 }
 public Int32 Index {
 get { return index_; }
 set { SetIndex(value); }
 }
 public void SetIndex(Int32 value) { 
 hasIndex = true;
 index_ = value;
 }

public const int flagFieldNumber = 2;
 private bool hasFlag;
 private Int32 flag_ = 0;
 public bool HasFlag {
 get { return hasFlag; }
 }
 public Int32 Flag {
 get { return flag_; }
 set { SetFlag(value); }
 }
 public void SetFlag(Int32 value) { 
 hasFlag = true;
 flag_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(1, Index);
}
 if (HasFlag) {
size += pb::CodedOutputStream.ComputeInt32Size(2, Flag);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasIndex) {
output.WriteInt32(1, Index);
}
 
if (HasFlag) {
output.WriteInt32(2, Flag);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_DYNAMICOBSTACLE_OPT _inst = (GC_DYNAMICOBSTACLE_OPT) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Index = input.ReadInt32();
break;
}
   case  16: {
 _inst.Flag = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasIndex) return false;
 if (!hasFlag) return false;
 return true;
 }

}


[Serializable]
public class CG_FELLOW_CHANGE_NAME : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

public const int nameFieldNumber = 2;
 private bool hasName;
 private string name_ = "";
 public bool HasName {
 get { return hasName; }
 }
 public string Name {
 get { return name_; }
 set { SetName(value); }
 }
 public void SetName(string value) { 
 hasName = true;
 name_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
 if (HasName) {
size += pb::CodedOutputStream.ComputeStringSize(2, Name);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
 
if (HasName) {
output.WriteString(2, Name);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_FELLOW_CHANGE_NAME _inst = (CG_FELLOW_CHANGE_NAME) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.Name = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 if (!hasName) return false;
 return true;
 }

}


[Serializable]
public class GC_FELLOW_CHANGE_NAME_RET : PacketDistributed
{

public const int fellowguidFieldNumber = 1;
 private bool hasFellowguid;
 private UInt64 fellowguid_ = 0;
 public bool HasFellowguid {
 get { return hasFellowguid; }
 }
 public UInt64 Fellowguid {
 get { return fellowguid_; }
 set { SetFellowguid(value); }
 }
 public void SetFellowguid(UInt64 value) { 
 hasFellowguid = true;
 fellowguid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasFellowguid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Fellowguid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasFellowguid) {
output.WriteUInt64(1, Fellowguid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_FELLOW_CHANGE_NAME_RET _inst = (GC_FELLOW_CHANGE_NAME_RET) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Fellowguid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasFellowguid) return false;
 return true;
 }

}


[Serializable]
public class CG_BUY_YUANBAOGOODS : PacketDistributed
{

public const int GoodIDFieldNumber = 1;
 private bool hasGoodID;
 private Int32 GoodID_ = 0;
 public bool HasGoodID {
 get { return hasGoodID; }
 }
 public Int32 GoodID {
 get { return GoodID_; }
 set { SetGoodID(value); }
 }
 public void SetGoodID(Int32 value) { 
 hasGoodID = true;
 GoodID_ = value;
 }

public const int BuyNumFieldNumber = 2;
 private bool hasBuyNum;
 private Int32 BuyNum_ = 0;
 public bool HasBuyNum {
 get { return hasBuyNum; }
 }
 public Int32 BuyNum {
 get { return BuyNum_; }
 set { SetBuyNum(value); }
 }
 public void SetBuyNum(Int32 value) { 
 hasBuyNum = true;
 BuyNum_ = value;
 }

public const int IsUseBindFieldNumber = 3;
 private bool hasIsUseBind;
 private Int32 IsUseBind_ = 0;
 public bool HasIsUseBind {
 get { return hasIsUseBind; }
 }
 public Int32 IsUseBind {
 get { return IsUseBind_; }
 set { SetIsUseBind(value); }
 }
 public void SetIsUseBind(Int32 value) { 
 hasIsUseBind = true;
 IsUseBind_ = value;
 }
public enum DEADLINE_TYPE 
 { 
  TYPE_WEEK     = 0, 
  TYPE_MONTH   = 1, 
  TYPE_FOREVER  = 2, 
 }
public const int DeadlineFieldNumber = 4;
 private bool hasDeadline;
 private Int32 Deadline_ = 0;
 public bool HasDeadline {
 get { return hasDeadline; }
 }
 public Int32 Deadline {
 get { return Deadline_; }
 set { SetDeadline(value); }
 }
 public void SetDeadline(Int32 value) { 
 hasDeadline = true;
 Deadline_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGoodID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, GoodID);
}
 if (HasBuyNum) {
size += pb::CodedOutputStream.ComputeInt32Size(2, BuyNum);
}
 if (HasIsUseBind) {
size += pb::CodedOutputStream.ComputeInt32Size(3, IsUseBind);
}
 if (HasDeadline) {
size += pb::CodedOutputStream.ComputeInt32Size(4, Deadline);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGoodID) {
output.WriteInt32(1, GoodID);
}
 
if (HasBuyNum) {
output.WriteInt32(2, BuyNum);
}
 
if (HasIsUseBind) {
output.WriteInt32(3, IsUseBind);
}
 
if (HasDeadline) {
output.WriteInt32(4, Deadline);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BUY_YUANBAOGOODS _inst = (CG_BUY_YUANBAOGOODS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GoodID = input.ReadInt32();
break;
}
   case  16: {
 _inst.BuyNum = input.ReadInt32();
break;
}
   case  24: {
 _inst.IsUseBind = input.ReadInt32();
break;
}
   case  32: {
 _inst.Deadline = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGoodID) return false;
 if (!hasBuyNum) return false;
 if (!hasIsUseBind) return false;
 if (!hasDeadline) return false;
 return true;
 }

}


[Serializable]
public class CG_BUY_GUILDGOODS : PacketDistributed
{

public const int GoodIDFieldNumber = 1;
 private bool hasGoodID;
 private Int32 GoodID_ = 0;
 public bool HasGoodID {
 get { return hasGoodID; }
 }
 public Int32 GoodID {
 get { return GoodID_; }
 set { SetGoodID(value); }
 }
 public void SetGoodID(Int32 value) { 
 hasGoodID = true;
 GoodID_ = value;
 }

public const int BuyNumFieldNumber = 2;
 private bool hasBuyNum;
 private Int32 BuyNum_ = 0;
 public bool HasBuyNum {
 get { return hasBuyNum; }
 }
 public Int32 BuyNum {
 get { return BuyNum_; }
 set { SetBuyNum(value); }
 }
 public void SetBuyNum(Int32 value) { 
 hasBuyNum = true;
 BuyNum_ = value;
 }

public const int GoodIndexFieldNumber = 3;
 private bool hasGoodIndex;
 private Int32 GoodIndex_ = 0;
 public bool HasGoodIndex {
 get { return hasGoodIndex; }
 }
 public Int32 GoodIndex {
 get { return GoodIndex_; }
 set { SetGoodIndex(value); }
 }
 public void SetGoodIndex(Int32 value) { 
 hasGoodIndex = true;
 GoodIndex_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasGoodID) {
size += pb::CodedOutputStream.ComputeInt32Size(1, GoodID);
}
 if (HasBuyNum) {
size += pb::CodedOutputStream.ComputeInt32Size(2, BuyNum);
}
 if (HasGoodIndex) {
size += pb::CodedOutputStream.ComputeInt32Size(3, GoodIndex);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasGoodID) {
output.WriteInt32(1, GoodID);
}
 
if (HasBuyNum) {
output.WriteInt32(2, BuyNum);
}
 
if (HasGoodIndex) {
output.WriteInt32(3, GoodIndex);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_BUY_GUILDGOODS _inst = (CG_BUY_GUILDGOODS) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.GoodID = input.ReadInt32();
break;
}
   case  16: {
 _inst.BuyNum = input.ReadInt32();
break;
}
   case  24: {
 _inst.GoodIndex = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasGoodID) return false;
 if (!hasBuyNum) return false;
 if (!hasGoodIndex) return false;
 return true;
 }

}


[Serializable]
public class GC_UPDATE_NEEDIMPACTINFO : PacketDistributed
{

public const int objIdFieldNumber = 1;
 private bool hasObjId;
 private Int32 objId_ = 0;
 public bool HasObjId {
 get { return hasObjId; }
 }
 public Int32 ObjId {
 get { return objId_; }
 set { SetObjId(value); }
 }
 public void SetObjId(Int32 value) { 
 hasObjId = true;
 objId_ = value;
 }

public const int impactIdFieldNumber = 2;
 private pbc::PopsicleList<Int32> impactId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> impactIdList {
 get { return pbc::Lists.AsReadOnly(impactId_); }
 }
 
 public int impactIdCount {
 get { return impactId_.Count; }
 }
 
public Int32 GetImpactId(int index) {
 return impactId_[index];
 }
 public void AddImpactId(Int32 value) {
 impactId_.Add(value);
 }

public const int impactLogicIdFieldNumber = 3;
 private pbc::PopsicleList<Int32> impactLogicId_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> impactLogicIdList {
 get { return pbc::Lists.AsReadOnly(impactLogicId_); }
 }
 
 public int impactLogicIdCount {
 get { return impactLogicId_.Count; }
 }
 
public Int32 GetImpactLogicId(int index) {
 return impactLogicId_[index];
 }
 public void AddImpactLogicId(Int32 value) {
 impactLogicId_.Add(value);
 }

public const int isForeverFieldNumber = 4;
 private pbc::PopsicleList<Int32> isForever_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> isForeverList {
 get { return pbc::Lists.AsReadOnly(isForever_); }
 }
 
 public int isForeverCount {
 get { return isForever_.Count; }
 }
 
public Int32 GetIsForever(int index) {
 return isForever_[index];
 }
 public void AddIsForever(Int32 value) {
 isForever_.Add(value);
 }

public const int remainTimeFieldNumber = 5;
 private pbc::PopsicleList<Int32> remainTime_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> remainTimeList {
 get { return pbc::Lists.AsReadOnly(remainTime_); }
 }
 
 public int remainTimeCount {
 get { return remainTime_.Count; }
 }
 
public Int32 GetRemainTime(int index) {
 return remainTime_[index];
 }
 public void AddRemainTime(Int32 value) {
 remainTime_.Add(value);
 }

public const int isAddFieldNumber = 6;
 private pbc::PopsicleList<Int32> isAdd_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> isAddList {
 get { return pbc::Lists.AsReadOnly(isAdd_); }
 }
 
 public int isAddCount {
 get { return isAdd_.Count; }
 }
 
public Int32 GetIsAdd(int index) {
 return isAdd_[index];
 }
 public void AddIsAdd(Int32 value) {
 isAdd_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasObjId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, ObjId);
}
{
int dataSize = 0;
for(int i=0; i<impactIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(impactIdList[i]);
}
size += dataSize;
size += 1 * impactId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<impactLogicIdList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(impactLogicIdList[i]);
}
size += dataSize;
size += 1 * impactLogicId_.Count;
}
{
int dataSize = 0;
for(int i=0; i<isForeverList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(isForeverList[i]);
}
size += dataSize;
size += 1 * isForever_.Count;
}
{
int dataSize = 0;
for(int i=0; i<remainTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(remainTimeList[i]);
}
size += dataSize;
size += 1 * remainTime_.Count;
}
{
int dataSize = 0;
for(int i=0; i<isAddList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(isAddList[i]);
}
size += dataSize;
size += 1 * isAdd_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasObjId) {
output.WriteInt32(1, ObjId);
}
{
if (impactId_.Count > 0) {
for(int i=0; i<impactId_.Count; ++i){
output.WriteInt32(2,impactId_[i]);
}
}

}
{
if (impactLogicId_.Count > 0) {
for(int i=0; i<impactLogicId_.Count; ++i){
output.WriteInt32(3,impactLogicId_[i]);
}
}

}
{
if (isForever_.Count > 0) {
for(int i=0; i<isForever_.Count; ++i){
output.WriteInt32(4,isForever_[i]);
}
}

}
{
if (remainTime_.Count > 0) {
for(int i=0; i<remainTime_.Count; ++i){
output.WriteInt32(5,remainTime_[i]);
}
}

}
{
if (isAdd_.Count > 0) {
for(int i=0; i<isAdd_.Count; ++i){
output.WriteInt32(6,isAdd_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_UPDATE_NEEDIMPACTINFO _inst = (GC_UPDATE_NEEDIMPACTINFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ObjId = input.ReadInt32();
break;
}
   case  16: {
 _inst.AddImpactId(input.ReadInt32());
break;
}
   case  24: {
 _inst.AddImpactLogicId(input.ReadInt32());
break;
}
   case  32: {
 _inst.AddIsForever(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddRemainTime(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddIsAdd(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasObjId) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_REQ_LIST : PacketDistributed
{

public const int requesterFieldNumber = 1;
 private bool hasRequester;
 private UInt64 requester_ = 0;
 public bool HasRequester {
 get { return hasRequester; }
 }
 public UInt64 Requester {
 get { return requester_; }
 set { SetRequester(value); }
 }
 public void SetRequester(UInt64 value) { 
 hasRequester = true;
 requester_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequester) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Requester);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequester) {
output.WriteUInt64(1, Requester);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_REQ_LIST _inst = (CG_MASTER_REQ_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Requester = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequester) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_RET_LIST : PacketDistributed
{

public const int masterGuidFieldNumber = 1;
 private pbc::PopsicleList<UInt64> masterGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> masterGuidList {
 get { return pbc::Lists.AsReadOnly(masterGuid_); }
 }
 
 public int masterGuidCount {
 get { return masterGuid_.Count; }
 }
 
public UInt64 GetMasterGuid(int index) {
 return masterGuid_[index];
 }
 public void AddMasterGuid(UInt64 value) {
 masterGuid_.Add(value);
 }

public const int masterNameFieldNumber = 2;
 private pbc::PopsicleList<string> masterName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> masterNameList {
 get { return pbc::Lists.AsReadOnly(masterName_); }
 }
 
 public int masterNameCount {
 get { return masterName_.Count; }
 }
 
public string GetMasterName(int index) {
 return masterName_[index];
 }
 public void AddMasterName(string value) {
 masterName_.Add(value);
 }

public const int masterChiefNameFieldNumber = 3;
 private pbc::PopsicleList<string> masterChiefName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> masterChiefNameList {
 get { return pbc::Lists.AsReadOnly(masterChiefName_); }
 }
 
 public int masterChiefNameCount {
 get { return masterChiefName_.Count; }
 }
 
public string GetMasterChiefName(int index) {
 return masterChiefName_[index];
 }
 public void AddMasterChiefName(string value) {
 masterChiefName_.Add(value);
 }

public const int memberNumFieldNumber = 4;
 private pbc::PopsicleList<Int32> memberNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberNumList {
 get { return pbc::Lists.AsReadOnly(memberNum_); }
 }
 
 public int memberNumCount {
 get { return memberNum_.Count; }
 }
 
public Int32 GetMemberNum(int index) {
 return memberNum_[index];
 }
 public void AddMemberNum(Int32 value) {
 memberNum_.Add(value);
 }

public const int masterTorchFieldNumber = 5;
 private pbc::PopsicleList<Int32> masterTorch_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> masterTorchList {
 get { return pbc::Lists.AsReadOnly(masterTorch_); }
 }
 
 public int masterTorchCount {
 get { return masterTorch_.Count; }
 }
 
public Int32 GetMasterTorch(int index) {
 return masterTorch_[index];
 }
 public void AddMasterTorch(Int32 value) {
 masterTorch_.Add(value);
 }

public const int createTimeFieldNumber = 6;
 private pbc::PopsicleList<Int32> createTime_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> createTimeList {
 get { return pbc::Lists.AsReadOnly(createTime_); }
 }
 
 public int createTimeCount {
 get { return createTime_.Count; }
 }
 
public Int32 GetCreateTime(int index) {
 return createTime_[index];
 }
 public void AddCreateTime(Int32 value) {
 createTime_.Add(value);
 }

public const int skillID1FieldNumber = 7;
 private pbc::PopsicleList<Int32> skillID1_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillID1List {
 get { return pbc::Lists.AsReadOnly(skillID1_); }
 }
 
 public int skillID1Count {
 get { return skillID1_.Count; }
 }
 
public Int32 GetSkillID1(int index) {
 return skillID1_[index];
 }
 public void AddSkillID1(Int32 value) {
 skillID1_.Add(value);
 }

public const int skillID2FieldNumber = 8;
 private pbc::PopsicleList<Int32> skillID2_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillID2List {
 get { return pbc::Lists.AsReadOnly(skillID2_); }
 }
 
 public int skillID2Count {
 get { return skillID2_.Count; }
 }
 
public Int32 GetSkillID2(int index) {
 return skillID2_[index];
 }
 public void AddSkillID2(Int32 value) {
 skillID2_.Add(value);
 }

public const int skillID3FieldNumber = 9;
 private pbc::PopsicleList<Int32> skillID3_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillID3List {
 get { return pbc::Lists.AsReadOnly(skillID3_); }
 }
 
 public int skillID3Count {
 get { return skillID3_.Count; }
 }
 
public Int32 GetSkillID3(int index) {
 return skillID3_[index];
 }
 public void AddSkillID3(Int32 value) {
 skillID3_.Add(value);
 }

public const int skillID4FieldNumber = 10;
 private pbc::PopsicleList<Int32> skillID4_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> skillID4List {
 get { return pbc::Lists.AsReadOnly(skillID4_); }
 }
 
 public int skillID4Count {
 get { return skillID4_.Count; }
 }
 
public Int32 GetSkillID4(int index) {
 return skillID4_[index];
 }
 public void AddSkillID4(Int32 value) {
 skillID4_.Add(value);
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
 {
int dataSize = 0;
for(int i=0; i<masterGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(masterGuidList[i]);
}
size += dataSize;
size += 1 * masterGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<masterNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(masterNameList[i]);
}
size += dataSize;
size += 1 * masterName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<masterChiefNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(masterChiefNameList[i]);
}
size += dataSize;
size += 1 * masterChiefName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberNumList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberNumList[i]);
}
size += dataSize;
size += 1 * memberNum_.Count;
}
{
int dataSize = 0;
for(int i=0; i<masterTorchList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(masterTorchList[i]);
}
size += dataSize;
size += 1 * masterTorch_.Count;
}
{
int dataSize = 0;
for(int i=0; i<createTimeList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(createTimeList[i]);
}
size += dataSize;
size += 1 * createTime_.Count;
}
{
int dataSize = 0;
for(int i=0; i<skillID1List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillID1List[i]);
}
size += dataSize;
size += 1 * skillID1_.Count;
}
{
int dataSize = 0;
for(int i=0; i<skillID2List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillID2List[i]);
}
size += dataSize;
size += 1 * skillID2_.Count;
}
{
int dataSize = 0;
for(int i=0; i<skillID3List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillID3List[i]);
}
size += dataSize;
size += 1 * skillID3_.Count;
}
{
int dataSize = 0;
for(int i=0; i<skillID4List.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(skillID4List[i]);
}
size += dataSize;
size += 1 * skillID4_.Count;
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
 {
if (masterGuid_.Count > 0) {
for(int i=0; i<masterGuid_.Count; ++i){
output.WriteUInt64(1,masterGuid_[i]);
}
}

}
{
if (masterName_.Count > 0) {
for(int i=0; i<masterName_.Count; ++i){
output.WriteString(2,masterName_[i]);
}
}

}
{
if (masterChiefName_.Count > 0) {
for(int i=0; i<masterChiefName_.Count; ++i){
output.WriteString(3,masterChiefName_[i]);
}
}

}
{
if (memberNum_.Count > 0) {
for(int i=0; i<memberNum_.Count; ++i){
output.WriteInt32(4,memberNum_[i]);
}
}

}
{
if (masterTorch_.Count > 0) {
for(int i=0; i<masterTorch_.Count; ++i){
output.WriteInt32(5,masterTorch_[i]);
}
}

}
{
if (createTime_.Count > 0) {
for(int i=0; i<createTime_.Count; ++i){
output.WriteInt32(6,createTime_[i]);
}
}

}
{
if (skillID1_.Count > 0) {
for(int i=0; i<skillID1_.Count; ++i){
output.WriteInt32(7,skillID1_[i]);
}
}

}
{
if (skillID2_.Count > 0) {
for(int i=0; i<skillID2_.Count; ++i){
output.WriteInt32(8,skillID2_[i]);
}
}

}
{
if (skillID3_.Count > 0) {
for(int i=0; i<skillID3_.Count; ++i){
output.WriteInt32(9,skillID3_[i]);
}
}

}
{
if (skillID4_.Count > 0) {
for(int i=0; i<skillID4_.Count; ++i){
output.WriteInt32(10,skillID4_[i]);
}
}

}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_RET_LIST _inst = (GC_MASTER_RET_LIST) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.AddMasterGuid(input.ReadUInt64());
break;
}
   case  18: {
 _inst.AddMasterName(input.ReadString());
break;
}
   case  26: {
 _inst.AddMasterChiefName(input.ReadString());
break;
}
   case  32: {
 _inst.AddMemberNum(input.ReadInt32());
break;
}
   case  40: {
 _inst.AddMasterTorch(input.ReadInt32());
break;
}
   case  48: {
 _inst.AddCreateTime(input.ReadInt32());
break;
}
   case  56: {
 _inst.AddSkillID1(input.ReadInt32());
break;
}
   case  64: {
 _inst.AddSkillID2(input.ReadInt32());
break;
}
   case  72: {
 _inst.AddSkillID3(input.ReadInt32());
break;
}
   case  80: {
 _inst.AddSkillID4(input.ReadInt32());
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  return true;
 }

}


[Serializable]
public class CG_MASTER_REQ_INFO : PacketDistributed
{

public const int requesterFieldNumber = 1;
 private bool hasRequester;
 private UInt64 requester_ = 0;
 public bool HasRequester {
 get { return hasRequester; }
 }
 public UInt64 Requester {
 get { return requester_; }
 set { SetRequester(value); }
 }
 public void SetRequester(UInt64 value) { 
 hasRequester = true;
 requester_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequester) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Requester);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequester) {
output.WriteUInt64(1, Requester);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_REQ_INFO _inst = (CG_MASTER_REQ_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Requester = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequester) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_RET_INFO : PacketDistributed
{

public const int masterGuidFieldNumber = 1;
 private bool hasMasterGuid;
 private UInt64 masterGuid_ = 0;
 public bool HasMasterGuid {
 get { return hasMasterGuid; }
 }
 public UInt64 MasterGuid {
 get { return masterGuid_; }
 set { SetMasterGuid(value); }
 }
 public void SetMasterGuid(UInt64 value) { 
 hasMasterGuid = true;
 masterGuid_ = value;
 }

public const int masterNameFieldNumber = 2;
 private bool hasMasterName;
 private string masterName_ = "";
 public bool HasMasterName {
 get { return hasMasterName; }
 }
 public string MasterName {
 get { return masterName_; }
 set { SetMasterName(value); }
 }
 public void SetMasterName(string value) { 
 hasMasterName = true;
 masterName_ = value;
 }

public const int masterChiefGuidFieldNumber = 3;
 private bool hasMasterChiefGuid;
 private UInt64 masterChiefGuid_ = 0;
 public bool HasMasterChiefGuid {
 get { return hasMasterChiefGuid; }
 }
 public UInt64 MasterChiefGuid {
 get { return masterChiefGuid_; }
 set { SetMasterChiefGuid(value); }
 }
 public void SetMasterChiefGuid(UInt64 value) { 
 hasMasterChiefGuid = true;
 masterChiefGuid_ = value;
 }

public const int masterNoticeFieldNumber = 4;
 private bool hasMasterNotice;
 private string masterNotice_ = "";
 public bool HasMasterNotice {
 get { return hasMasterNotice; }
 }
 public string MasterNotice {
 get { return masterNotice_; }
 set { SetMasterNotice(value); }
 }
 public void SetMasterNotice(string value) { 
 hasMasterNotice = true;
 masterNotice_ = value;
 }

public const int createTimeFieldNumber = 5;
 private bool hasCreateTime;
 private Int32 createTime_ = 0;
 public bool HasCreateTime {
 get { return hasCreateTime; }
 }
 public Int32 CreateTime {
 get { return createTime_; }
 set { SetCreateTime(value); }
 }
 public void SetCreateTime(Int32 value) { 
 hasCreateTime = true;
 createTime_ = value;
 }

public const int memberNumFieldNumber = 6;
 private bool hasMemberNum;
 private Int32 memberNum_ = 0;
 public bool HasMemberNum {
 get { return hasMemberNum; }
 }
 public Int32 MemberNum {
 get { return memberNum_; }
 set { SetMemberNum(value); }
 }
 public void SetMemberNum(Int32 value) { 
 hasMemberNum = true;
 memberNum_ = value;
 }

public const int masterTorchFieldNumber = 7;
 private bool hasMasterTorch;
 private Int32 masterTorch_ = 0;
 public bool HasMasterTorch {
 get { return hasMasterTorch; }
 }
 public Int32 MasterTorch {
 get { return masterTorch_; }
 set { SetMasterTorch(value); }
 }
 public void SetMasterTorch(Int32 value) { 
 hasMasterTorch = true;
 masterTorch_ = value;
 }

public const int memberGuidFieldNumber = 8;
 private pbc::PopsicleList<UInt64> memberGuid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> memberGuidList {
 get { return pbc::Lists.AsReadOnly(memberGuid_); }
 }
 
 public int memberGuidCount {
 get { return memberGuid_.Count; }
 }
 
public UInt64 GetMemberGuid(int index) {
 return memberGuid_[index];
 }
 public void AddMemberGuid(UInt64 value) {
 memberGuid_.Add(value);
 }

public const int memberNameFieldNumber = 9;
 private pbc::PopsicleList<string> memberName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> memberNameList {
 get { return pbc::Lists.AsReadOnly(memberName_); }
 }
 
 public int memberNameCount {
 get { return memberName_.Count; }
 }
 
public string GetMemberName(int index) {
 return memberName_[index];
 }
 public void AddMemberName(string value) {
 memberName_.Add(value);
 }

public const int memberGuildNameFieldNumber = 10;
 private pbc::PopsicleList<string> memberGuildName_ = new pbc::PopsicleList<string>();
 public scg::IList<string> memberGuildNameList {
 get { return pbc::Lists.AsReadOnly(memberGuildName_); }
 }
 
 public int memberGuildNameCount {
 get { return memberGuildName_.Count; }
 }
 
public string GetMemberGuildName(int index) {
 return memberGuildName_[index];
 }
 public void AddMemberGuildName(string value) {
 memberGuildName_.Add(value);
 }

public const int memberVIPFieldNumber = 11;
 private pbc::PopsicleList<Int32> memberVIP_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberVIPList {
 get { return pbc::Lists.AsReadOnly(memberVIP_); }
 }
 
 public int memberVIPCount {
 get { return memberVIP_.Count; }
 }
 
public Int32 GetMemberVIP(int index) {
 return memberVIP_[index];
 }
 public void AddMemberVIP(Int32 value) {
 memberVIP_.Add(value);
 }

public const int memberProfFieldNumber = 12;
 private pbc::PopsicleList<Int32> memberProf_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberProfList {
 get { return pbc::Lists.AsReadOnly(memberProf_); }
 }
 
 public int memberProfCount {
 get { return memberProf_.Count; }
 }
 
public Int32 GetMemberProf(int index) {
 return memberProf_[index];
 }
 public void AddMemberProf(Int32 value) {
 memberProf_.Add(value);
 }

public const int memberLevelFieldNumber = 13;
 private pbc::PopsicleList<Int32> memberLevel_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberLevelList {
 get { return pbc::Lists.AsReadOnly(memberLevel_); }
 }
 
 public int memberLevelCount {
 get { return memberLevel_.Count; }
 }
 
public Int32 GetMemberLevel(int index) {
 return memberLevel_[index];
 }
 public void AddMemberLevel(Int32 value) {
 memberLevel_.Add(value);
 }

public const int memberCombatValueFieldNumber = 14;
 private pbc::PopsicleList<Int32> memberCombatValue_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberCombatValueList {
 get { return pbc::Lists.AsReadOnly(memberCombatValue_); }
 }
 
 public int memberCombatValueCount {
 get { return memberCombatValue_.Count; }
 }
 
public Int32 GetMemberCombatValue(int index) {
 return memberCombatValue_[index];
 }
 public void AddMemberCombatValue(Int32 value) {
 memberCombatValue_.Add(value);
 }

public const int memberTorchFieldNumber = 15;
 private pbc::PopsicleList<Int32> memberTorch_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberTorchList {
 get { return pbc::Lists.AsReadOnly(memberTorch_); }
 }
 
 public int memberTorchCount {
 get { return memberTorch_.Count; }
 }
 
public Int32 GetMemberTorch(int index) {
 return memberTorch_[index];
 }
 public void AddMemberTorch(Int32 value) {
 memberTorch_.Add(value);
 }

public const int memberLastLoginFieldNumber = 16;
 private pbc::PopsicleList<Int32> memberLastLogin_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberLastLoginList {
 get { return pbc::Lists.AsReadOnly(memberLastLogin_); }
 }
 
 public int memberLastLoginCount {
 get { return memberLastLogin_.Count; }
 }
 
public Int32 GetMemberLastLogin(int index) {
 return memberLastLogin_[index];
 }
 public void AddMemberLastLogin(Int32 value) {
 memberLastLogin_.Add(value);
 }

public const int memberStateFieldNumber = 17;
 private pbc::PopsicleList<Int32> memberState_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberStateList {
 get { return pbc::Lists.AsReadOnly(memberState_); }
 }
 
 public int memberStateCount {
 get { return memberState_.Count; }
 }
 
public Int32 GetMemberState(int index) {
 return memberState_[index];
 }
 public void AddMemberState(Int32 value) {
 memberState_.Add(value);
 }

public const int masterskill1FieldNumber = 18;
 private bool hasMasterskill1;
 private Int32 masterskill1_ = 0;
 public bool HasMasterskill1 {
 get { return hasMasterskill1; }
 }
 public Int32 Masterskill1 {
 get { return masterskill1_; }
 set { SetMasterskill1(value); }
 }
 public void SetMasterskill1(Int32 value) { 
 hasMasterskill1 = true;
 masterskill1_ = value;
 }

public const int masterskill2FieldNumber = 19;
 private bool hasMasterskill2;
 private Int32 masterskill2_ = 0;
 public bool HasMasterskill2 {
 get { return hasMasterskill2; }
 }
 public Int32 Masterskill2 {
 get { return masterskill2_; }
 set { SetMasterskill2(value); }
 }
 public void SetMasterskill2(Int32 value) { 
 hasMasterskill2 = true;
 masterskill2_ = value;
 }

public const int masterskill3FieldNumber = 20;
 private bool hasMasterskill3;
 private Int32 masterskill3_ = 0;
 public bool HasMasterskill3 {
 get { return hasMasterskill3; }
 }
 public Int32 Masterskill3 {
 get { return masterskill3_; }
 set { SetMasterskill3(value); }
 }
 public void SetMasterskill3(Int32 value) { 
 hasMasterskill3 = true;
 masterskill3_ = value;
 }

public const int masterskill4FieldNumber = 21;
 private bool hasMasterskill4;
 private Int32 masterskill4_ = 0;
 public bool HasMasterskill4 {
 get { return hasMasterskill4; }
 }
 public Int32 Masterskill4 {
 get { return masterskill4_; }
 set { SetMasterskill4(value); }
 }
 public void SetMasterskill4(Int32 value) { 
 hasMasterskill4 = true;
 masterskill4_ = value;
 }

public const int masterskillname1FieldNumber = 22;
 private bool hasMasterskillname1;
 private string masterskillname1_ = "";
 public bool HasMasterskillname1 {
 get { return hasMasterskillname1; }
 }
 public string Masterskillname1 {
 get { return masterskillname1_; }
 set { SetMasterskillname1(value); }
 }
 public void SetMasterskillname1(string value) { 
 hasMasterskillname1 = true;
 masterskillname1_ = value;
 }

public const int masterskillname2FieldNumber = 23;
 private bool hasMasterskillname2;
 private string masterskillname2_ = "";
 public bool HasMasterskillname2 {
 get { return hasMasterskillname2; }
 }
 public string Masterskillname2 {
 get { return masterskillname2_; }
 set { SetMasterskillname2(value); }
 }
 public void SetMasterskillname2(string value) { 
 hasMasterskillname2 = true;
 masterskillname2_ = value;
 }

public const int masterskillname3FieldNumber = 24;
 private bool hasMasterskillname3;
 private string masterskillname3_ = "";
 public bool HasMasterskillname3 {
 get { return hasMasterskillname3; }
 }
 public string Masterskillname3 {
 get { return masterskillname3_; }
 set { SetMasterskillname3(value); }
 }
 public void SetMasterskillname3(string value) { 
 hasMasterskillname3 = true;
 masterskillname3_ = value;
 }

public const int masterskillname4FieldNumber = 25;
 private bool hasMasterskillname4;
 private string masterskillname4_ = "";
 public bool HasMasterskillname4 {
 get { return hasMasterskillname4; }
 }
 public string Masterskillname4 {
 get { return masterskillname4_; }
 set { SetMasterskillname4(value); }
 }
 public void SetMasterskillname4(string value) { 
 hasMasterskillname4 = true;
 masterskillname4_ = value;
 }

public const int memberIsReserveFieldNumber = 26;
 private pbc::PopsicleList<Int32> memberIsReserve_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> memberIsReserveList {
 get { return pbc::Lists.AsReadOnly(memberIsReserve_); }
 }
 
 public int memberIsReserveCount {
 get { return memberIsReserve_.Count; }
 }
 
public Int32 GetMemberIsReserve(int index) {
 return memberIsReserve_[index];
 }
 public void AddMemberIsReserve(Int32 value) {
 memberIsReserve_.Add(value);
 }

public const int masterskill5FieldNumber = 27;
 private bool hasMasterskill5;
 private Int32 masterskill5_ = 0;
 public bool HasMasterskill5 {
 get { return hasMasterskill5; }
 }
 public Int32 Masterskill5 {
 get { return masterskill5_; }
 set { SetMasterskill5(value); }
 }
 public void SetMasterskill5(Int32 value) { 
 hasMasterskill5 = true;
 masterskill5_ = value;
 }

public const int masterskill6FieldNumber = 28;
 private bool hasMasterskill6;
 private Int32 masterskill6_ = 0;
 public bool HasMasterskill6 {
 get { return hasMasterskill6; }
 }
 public Int32 Masterskill6 {
 get { return masterskill6_; }
 set { SetMasterskill6(value); }
 }
 public void SetMasterskill6(Int32 value) { 
 hasMasterskill6 = true;
 masterskill6_ = value;
 }

public const int masterskillname5FieldNumber = 29;
 private bool hasMasterskillname5;
 private string masterskillname5_ = "";
 public bool HasMasterskillname5 {
 get { return hasMasterskillname5; }
 }
 public string Masterskillname5 {
 get { return masterskillname5_; }
 set { SetMasterskillname5(value); }
 }
 public void SetMasterskillname5(string value) { 
 hasMasterskillname5 = true;
 masterskillname5_ = value;
 }

public const int masterskillname6FieldNumber = 30;
 private bool hasMasterskillname6;
 private string masterskillname6_ = "";
 public bool HasMasterskillname6 {
 get { return hasMasterskillname6; }
 }
 public string Masterskillname6 {
 get { return masterskillname6_; }
 set { SetMasterskillname6(value); }
 }
 public void SetMasterskillname6(string value) { 
 hasMasterskillname6 = true;
 masterskillname6_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMasterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, MasterGuid);
}
 if (HasMasterName) {
size += pb::CodedOutputStream.ComputeStringSize(2, MasterName);
}
 if (HasMasterChiefGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(3, MasterChiefGuid);
}
 if (HasMasterNotice) {
size += pb::CodedOutputStream.ComputeStringSize(4, MasterNotice);
}
 if (HasCreateTime) {
size += pb::CodedOutputStream.ComputeInt32Size(5, CreateTime);
}
 if (HasMemberNum) {
size += pb::CodedOutputStream.ComputeInt32Size(6, MemberNum);
}
 if (HasMasterTorch) {
size += pb::CodedOutputStream.ComputeInt32Size(7, MasterTorch);
}
{
int dataSize = 0;
for(int i=0; i<memberGuidList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeUInt64SizeNoTag(memberGuidList[i]);
}
size += dataSize;
size += 1 * memberGuid_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(memberNameList[i]);
}
size += dataSize;
size += 1 * memberName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberGuildNameList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeStringSizeNoTag(memberGuildNameList[i]);
}
size += dataSize;
size += 1 * memberGuildName_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberVIPList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberVIPList[i]);
}
size += dataSize;
size += 1 * memberVIP_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberProfList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberProfList[i]);
}
size += dataSize;
size += 1 * memberProf_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberLevelList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberLevelList[i]);
}
size += dataSize;
size += 1 * memberLevel_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberCombatValueList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberCombatValueList[i]);
}
size += dataSize;
size += 1 * memberCombatValue_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberTorchList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberTorchList[i]);
}
size += dataSize;
size += 1 * memberTorch_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberLastLoginList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberLastLoginList[i]);
}
size += dataSize;
size += 1 * memberLastLogin_.Count;
}
{
int dataSize = 0;
for(int i=0; i<memberStateList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberStateList[i]);
}
size += dataSize;
size += 1 * memberState_.Count;
}
 if (HasMasterskill1) {
size += pb::CodedOutputStream.ComputeInt32Size(18, Masterskill1);
}
 if (HasMasterskill2) {
size += pb::CodedOutputStream.ComputeInt32Size(19, Masterskill2);
}
 if (HasMasterskill3) {
size += pb::CodedOutputStream.ComputeInt32Size(20, Masterskill3);
}
 if (HasMasterskill4) {
size += pb::CodedOutputStream.ComputeInt32Size(21, Masterskill4);
}
 if (HasMasterskillname1) {
size += pb::CodedOutputStream.ComputeStringSize(22, Masterskillname1);
}
 if (HasMasterskillname2) {
size += pb::CodedOutputStream.ComputeStringSize(23, Masterskillname2);
}
 if (HasMasterskillname3) {
size += pb::CodedOutputStream.ComputeStringSize(24, Masterskillname3);
}
 if (HasMasterskillname4) {
size += pb::CodedOutputStream.ComputeStringSize(25, Masterskillname4);
}
{
int dataSize = 0;
for(int i=0; i<memberIsReserveList.Count; ++i){
dataSize += pb::CodedOutputStream.ComputeInt32SizeNoTag(memberIsReserveList[i]);
}
size += dataSize;
size += 1 * memberIsReserve_.Count;
}
 if (HasMasterskill5) {
size += pb::CodedOutputStream.ComputeInt32Size(27, Masterskill5);
}
 if (HasMasterskill6) {
size += pb::CodedOutputStream.ComputeInt32Size(28, Masterskill6);
}
 if (HasMasterskillname5) {
size += pb::CodedOutputStream.ComputeStringSize(29, Masterskillname5);
}
 if (HasMasterskillname6) {
size += pb::CodedOutputStream.ComputeStringSize(30, Masterskillname6);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMasterGuid) {
output.WriteUInt64(1, MasterGuid);
}
 
if (HasMasterName) {
output.WriteString(2, MasterName);
}
 
if (HasMasterChiefGuid) {
output.WriteUInt64(3, MasterChiefGuid);
}
 
if (HasMasterNotice) {
output.WriteString(4, MasterNotice);
}
 
if (HasCreateTime) {
output.WriteInt32(5, CreateTime);
}
 
if (HasMemberNum) {
output.WriteInt32(6, MemberNum);
}
 
if (HasMasterTorch) {
output.WriteInt32(7, MasterTorch);
}
{
if (memberGuid_.Count > 0) {
for(int i=0; i<memberGuid_.Count; ++i){
output.WriteUInt64(8,memberGuid_[i]);
}
}

}
{
if (memberName_.Count > 0) {
for(int i=0; i<memberName_.Count; ++i){
output.WriteString(9,memberName_[i]);
}
}

}
{
if (memberGuildName_.Count > 0) {
for(int i=0; i<memberGuildName_.Count; ++i){
output.WriteString(10,memberGuildName_[i]);
}
}

}
{
if (memberVIP_.Count > 0) {
for(int i=0; i<memberVIP_.Count; ++i){
output.WriteInt32(11,memberVIP_[i]);
}
}

}
{
if (memberProf_.Count > 0) {
for(int i=0; i<memberProf_.Count; ++i){
output.WriteInt32(12,memberProf_[i]);
}
}

}
{
if (memberLevel_.Count > 0) {
for(int i=0; i<memberLevel_.Count; ++i){
output.WriteInt32(13,memberLevel_[i]);
}
}

}
{
if (memberCombatValue_.Count > 0) {
for(int i=0; i<memberCombatValue_.Count; ++i){
output.WriteInt32(14,memberCombatValue_[i]);
}
}

}
{
if (memberTorch_.Count > 0) {
for(int i=0; i<memberTorch_.Count; ++i){
output.WriteInt32(15,memberTorch_[i]);
}
}

}
{
if (memberLastLogin_.Count > 0) {
for(int i=0; i<memberLastLogin_.Count; ++i){
output.WriteInt32(16,memberLastLogin_[i]);
}
}

}
{
if (memberState_.Count > 0) {
for(int i=0; i<memberState_.Count; ++i){
output.WriteInt32(17,memberState_[i]);
}
}

}
 
if (HasMasterskill1) {
output.WriteInt32(18, Masterskill1);
}
 
if (HasMasterskill2) {
output.WriteInt32(19, Masterskill2);
}
 
if (HasMasterskill3) {
output.WriteInt32(20, Masterskill3);
}
 
if (HasMasterskill4) {
output.WriteInt32(21, Masterskill4);
}
 
if (HasMasterskillname1) {
output.WriteString(22, Masterskillname1);
}
 
if (HasMasterskillname2) {
output.WriteString(23, Masterskillname2);
}
 
if (HasMasterskillname3) {
output.WriteString(24, Masterskillname3);
}
 
if (HasMasterskillname4) {
output.WriteString(25, Masterskillname4);
}
{
if (memberIsReserve_.Count > 0) {
for(int i=0; i<memberIsReserve_.Count; ++i){
output.WriteInt32(26,memberIsReserve_[i]);
}
}

}
 
if (HasMasterskill5) {
output.WriteInt32(27, Masterskill5);
}
 
if (HasMasterskill6) {
output.WriteInt32(28, Masterskill6);
}
 
if (HasMasterskillname5) {
output.WriteString(29, Masterskillname5);
}
 
if (HasMasterskillname6) {
output.WriteString(30, Masterskillname6);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_RET_INFO _inst = (GC_MASTER_RET_INFO) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MasterGuid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.MasterName = input.ReadString();
break;
}
   case  24: {
 _inst.MasterChiefGuid = input.ReadUInt64();
break;
}
   case  34: {
 _inst.MasterNotice = input.ReadString();
break;
}
   case  40: {
 _inst.CreateTime = input.ReadInt32();
break;
}
   case  48: {
 _inst.MemberNum = input.ReadInt32();
break;
}
   case  56: {
 _inst.MasterTorch = input.ReadInt32();
break;
}
   case  64: {
 _inst.AddMemberGuid(input.ReadUInt64());
break;
}
   case  74: {
 _inst.AddMemberName(input.ReadString());
break;
}
   case  82: {
 _inst.AddMemberGuildName(input.ReadString());
break;
}
   case  88: {
 _inst.AddMemberVIP(input.ReadInt32());
break;
}
   case  96: {
 _inst.AddMemberProf(input.ReadInt32());
break;
}
   case  104: {
 _inst.AddMemberLevel(input.ReadInt32());
break;
}
   case  112: {
 _inst.AddMemberCombatValue(input.ReadInt32());
break;
}
   case  120: {
 _inst.AddMemberTorch(input.ReadInt32());
break;
}
   case  128: {
 _inst.AddMemberLastLogin(input.ReadInt32());
break;
}
   case  136: {
 _inst.AddMemberState(input.ReadInt32());
break;
}
   case  144: {
 _inst.Masterskill1 = input.ReadInt32();
break;
}
   case  152: {
 _inst.Masterskill2 = input.ReadInt32();
break;
}
   case  160: {
 _inst.Masterskill3 = input.ReadInt32();
break;
}
   case  168: {
 _inst.Masterskill4 = input.ReadInt32();
break;
}
   case  178: {
 _inst.Masterskillname1 = input.ReadString();
break;
}
   case  186: {
 _inst.Masterskillname2 = input.ReadString();
break;
}
   case  194: {
 _inst.Masterskillname3 = input.ReadString();
break;
}
   case  202: {
 _inst.Masterskillname4 = input.ReadString();
break;
}
   case  208: {
 _inst.AddMemberIsReserve(input.ReadInt32());
break;
}
   case  216: {
 _inst.Masterskill5 = input.ReadInt32();
break;
}
   case  224: {
 _inst.Masterskill6 = input.ReadInt32();
break;
}
   case  234: {
 _inst.Masterskillname5 = input.ReadString();
break;
}
   case  242: {
 _inst.Masterskillname6 = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMasterGuid) return false;
 if (!hasMasterName) return false;
 if (!hasMasterChiefGuid) return false;
 if (!hasMasterNotice) return false;
 if (!hasCreateTime) return false;
 if (!hasMemberNum) return false;
 if (!hasMasterTorch) return false;
 if (!hasMasterskill1) return false;
 if (!hasMasterskill2) return false;
 if (!hasMasterskill3) return false;
 if (!hasMasterskill4) return false;
 if (!hasMasterskillname1) return false;
 if (!hasMasterskillname2) return false;
 if (!hasMasterskillname3) return false;
 if (!hasMasterskillname4) return false;
 if (!hasMasterskill5) return false;
 if (!hasMasterskill6) return false;
 if (!hasMasterskillname5) return false;
 if (!hasMasterskillname6) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_REQ_CHANGE_NOTICE : PacketDistributed
{

public const int masterNoticeFieldNumber = 1;
 private bool hasMasterNotice;
 private string masterNotice_ = "";
 public bool HasMasterNotice {
 get { return hasMasterNotice; }
 }
 public string MasterNotice {
 get { return masterNotice_; }
 set { SetMasterNotice(value); }
 }
 public void SetMasterNotice(string value) { 
 hasMasterNotice = true;
 masterNotice_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMasterNotice) {
size += pb::CodedOutputStream.ComputeStringSize(1, MasterNotice);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMasterNotice) {
output.WriteString(1, MasterNotice);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_REQ_CHANGE_NOTICE _inst = (CG_MASTER_REQ_CHANGE_NOTICE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.MasterNotice = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMasterNotice) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_CREATE : PacketDistributed
{

public const int masterNameFieldNumber = 1;
 private bool hasMasterName;
 private string masterName_ = "";
 public bool HasMasterName {
 get { return hasMasterName; }
 }
 public string MasterName {
 get { return masterName_; }
 set { SetMasterName(value); }
 }
 public void SetMasterName(string value) { 
 hasMasterName = true;
 masterName_ = value;
 }

public const int masterNoticeFieldNumber = 2;
 private bool hasMasterNotice;
 private string masterNotice_ = "";
 public bool HasMasterNotice {
 get { return hasMasterNotice; }
 }
 public string MasterNotice {
 get { return masterNotice_; }
 set { SetMasterNotice(value); }
 }
 public void SetMasterNotice(string value) { 
 hasMasterNotice = true;
 masterNotice_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMasterName) {
size += pb::CodedOutputStream.ComputeStringSize(1, MasterName);
}
 if (HasMasterNotice) {
size += pb::CodedOutputStream.ComputeStringSize(2, MasterNotice);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMasterName) {
output.WriteString(1, MasterName);
}
 
if (HasMasterNotice) {
output.WriteString(2, MasterNotice);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_CREATE _inst = (CG_MASTER_CREATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  10: {
 _inst.MasterName = input.ReadString();
break;
}
   case  18: {
 _inst.MasterNotice = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMasterName) return false;
 if (!hasMasterNotice) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_CREATE : PacketDistributed
{

public const int masterGuidFieldNumber = 1;
 private bool hasMasterGuid;
 private UInt64 masterGuid_ = 0;
 public bool HasMasterGuid {
 get { return hasMasterGuid; }
 }
 public UInt64 MasterGuid {
 get { return masterGuid_; }
 set { SetMasterGuid(value); }
 }
 public void SetMasterGuid(UInt64 value) { 
 hasMasterGuid = true;
 masterGuid_ = value;
 }

public const int masterNameFieldNumber = 2;
 private bool hasMasterName;
 private string masterName_ = "";
 public bool HasMasterName {
 get { return hasMasterName; }
 }
 public string MasterName {
 get { return masterName_; }
 set { SetMasterName(value); }
 }
 public void SetMasterName(string value) { 
 hasMasterName = true;
 masterName_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMasterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, MasterGuid);
}
 if (HasMasterName) {
size += pb::CodedOutputStream.ComputeStringSize(2, MasterName);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMasterGuid) {
output.WriteUInt64(1, MasterGuid);
}
 
if (HasMasterName) {
output.WriteString(2, MasterName);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_CREATE _inst = (GC_MASTER_CREATE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MasterGuid = input.ReadUInt64();
break;
}
   case  18: {
 _inst.MasterName = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMasterGuid) return false;
 if (!hasMasterName) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_JOIN : PacketDistributed
{

public const int masterGuidFieldNumber = 1;
 private bool hasMasterGuid;
 private UInt64 masterGuid_ = 0;
 public bool HasMasterGuid {
 get { return hasMasterGuid; }
 }
 public UInt64 MasterGuid {
 get { return masterGuid_; }
 set { SetMasterGuid(value); }
 }
 public void SetMasterGuid(UInt64 value) { 
 hasMasterGuid = true;
 masterGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMasterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, MasterGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMasterGuid) {
output.WriteUInt64(1, MasterGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_JOIN _inst = (CG_MASTER_JOIN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MasterGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMasterGuid) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_JOIN : PacketDistributed
{

public const int masterGuidFieldNumber = 1;
 private bool hasMasterGuid;
 private UInt64 masterGuid_ = 0;
 public bool HasMasterGuid {
 get { return hasMasterGuid; }
 }
 public UInt64 MasterGuid {
 get { return masterGuid_; }
 set { SetMasterGuid(value); }
 }
 public void SetMasterGuid(UInt64 value) { 
 hasMasterGuid = true;
 masterGuid_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMasterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, MasterGuid);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMasterGuid) {
output.WriteUInt64(1, MasterGuid);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_JOIN _inst = (GC_MASTER_JOIN) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MasterGuid = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMasterGuid) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_LEAVE : PacketDistributed
{

public const int requesterFieldNumber = 1;
 private bool hasRequester;
 private UInt64 requester_ = 0;
 public bool HasRequester {
 get { return hasRequester; }
 }
 public UInt64 Requester {
 get { return requester_; }
 set { SetRequester(value); }
 }
 public void SetRequester(UInt64 value) { 
 hasRequester = true;
 requester_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasRequester) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Requester);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasRequester) {
output.WriteUInt64(1, Requester);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_LEAVE _inst = (CG_MASTER_LEAVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Requester = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasRequester) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_LEAVE : PacketDistributed
{

public const int masterGuidFieldNumber = 1;
 private bool hasMasterGuid;
 private UInt64 masterGuid_ = 0;
 public bool HasMasterGuid {
 get { return hasMasterGuid; }
 }
 public UInt64 MasterGuid {
 get { return masterGuid_; }
 set { SetMasterGuid(value); }
 }
 public void SetMasterGuid(UInt64 value) { 
 hasMasterGuid = true;
 masterGuid_ = value;
 }

public const int levelTypeFieldNumber = 2;
 private bool hasLevelType;
 private Int32 levelType_ = 0;
 public bool HasLevelType {
 get { return hasLevelType; }
 }
 public Int32 LevelType {
 get { return levelType_; }
 set { SetLevelType(value); }
 }
 public void SetLevelType(Int32 value) { 
 hasLevelType = true;
 levelType_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasMasterGuid) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, MasterGuid);
}
 if (HasLevelType) {
size += pb::CodedOutputStream.ComputeInt32Size(2, LevelType);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasMasterGuid) {
output.WriteUInt64(1, MasterGuid);
}
 
if (HasLevelType) {
output.WriteInt32(2, LevelType);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_LEAVE _inst = (GC_MASTER_LEAVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.MasterGuid = input.ReadUInt64();
break;
}
   case  16: {
 _inst.LevelType = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasMasterGuid) return false;
 if (!hasLevelType) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_KICK : PacketDistributed
{

public const int kickedFieldNumber = 1;
 private bool hasKicked;
 private UInt64 kicked_ = 0;
 public bool HasKicked {
 get { return hasKicked; }
 }
 public UInt64 Kicked {
 get { return kicked_; }
 set { SetKicked(value); }
 }
 public void SetKicked(UInt64 value) { 
 hasKicked = true;
 kicked_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasKicked) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Kicked);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasKicked) {
output.WriteUInt64(1, Kicked);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_KICK _inst = (CG_MASTER_KICK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Kicked = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasKicked) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_KICK : PacketDistributed
{

public const int kickedFieldNumber = 1;
 private bool hasKicked;
 private UInt64 kicked_ = 0;
 public bool HasKicked {
 get { return hasKicked; }
 }
 public UInt64 Kicked {
 get { return kicked_; }
 set { SetKicked(value); }
 }
 public void SetKicked(UInt64 value) { 
 hasKicked = true;
 kicked_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasKicked) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, Kicked);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasKicked) {
output.WriteUInt64(1, Kicked);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_KICK _inst = (GC_MASTER_KICK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.Kicked = input.ReadUInt64();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasKicked) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_APPROVE_RESERVE : PacketDistributed
{

public const int reserveMemberFieldNumber = 1;
 private bool hasReserveMember;
 private UInt64 reserveMember_ = 0;
 public bool HasReserveMember {
 get { return hasReserveMember; }
 }
 public UInt64 ReserveMember {
 get { return reserveMember_; }
 set { SetReserveMember(value); }
 }
 public void SetReserveMember(UInt64 value) { 
 hasReserveMember = true;
 reserveMember_ = value;
 }

public const int isAgreeFieldNumber = 2;
 private bool hasIsAgree;
 private Int32 isAgree_ = 0;
 public bool HasIsAgree {
 get { return hasIsAgree; }
 }
 public Int32 IsAgree {
 get { return isAgree_; }
 set { SetIsAgree(value); }
 }
 public void SetIsAgree(Int32 value) { 
 hasIsAgree = true;
 isAgree_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasReserveMember) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, ReserveMember);
}
 if (HasIsAgree) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsAgree);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasReserveMember) {
output.WriteUInt64(1, ReserveMember);
}
 
if (HasIsAgree) {
output.WriteInt32(2, IsAgree);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_APPROVE_RESERVE _inst = (CG_MASTER_APPROVE_RESERVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ReserveMember = input.ReadUInt64();
break;
}
   case  16: {
 _inst.IsAgree = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasReserveMember) return false;
 if (!hasIsAgree) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_APPROVE_RESERVE : PacketDistributed
{

public const int reserveMemberFieldNumber = 1;
 private bool hasReserveMember;
 private UInt64 reserveMember_ = 0;
 public bool HasReserveMember {
 get { return hasReserveMember; }
 }
 public UInt64 ReserveMember {
 get { return reserveMember_; }
 set { SetReserveMember(value); }
 }
 public void SetReserveMember(UInt64 value) { 
 hasReserveMember = true;
 reserveMember_ = value;
 }

public const int isAgreeFieldNumber = 2;
 private bool hasIsAgree;
 private Int32 isAgree_ = 0;
 public bool HasIsAgree {
 get { return hasIsAgree; }
 }
 public Int32 IsAgree {
 get { return isAgree_; }
 set { SetIsAgree(value); }
 }
 public void SetIsAgree(Int32 value) { 
 hasIsAgree = true;
 isAgree_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasReserveMember) {
size += pb::CodedOutputStream.ComputeUInt64Size(1, ReserveMember);
}
 if (HasIsAgree) {
size += pb::CodedOutputStream.ComputeInt32Size(2, IsAgree);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasReserveMember) {
output.WriteUInt64(1, ReserveMember);
}
 
if (HasIsAgree) {
output.WriteInt32(2, IsAgree);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_APPROVE_RESERVE _inst = (GC_MASTER_APPROVE_RESERVE) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.ReserveMember = input.ReadUInt64();
break;
}
   case  16: {
 _inst.IsAgree = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasReserveMember) return false;
 if (!hasIsAgree) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_ACTIVE_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

public const int skillNameFieldNumber = 2;
 private bool hasSkillName;
 private string skillName_ = "";
 public bool HasSkillName {
 get { return hasSkillName; }
 }
 public string SkillName {
 get { return skillName_; }
 set { SetSkillName(value); }
 }
 public void SetSkillName(string value) { 
 hasSkillName = true;
 skillName_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 if (HasSkillName) {
size += pb::CodedOutputStream.ComputeStringSize(2, SkillName);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 
if (HasSkillName) {
output.WriteString(2, SkillName);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_ACTIVE_SKILL _inst = (CG_MASTER_ACTIVE_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}
   case  18: {
 _inst.SkillName = input.ReadString();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 if (!hasSkillName) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_LEARN_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_LEARN_SKILL _inst = (GC_MASTER_LEARN_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_FORGET_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_FORGET_SKILL _inst = (CG_MASTER_FORGET_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_FORGET_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_FORGET_SKILL _inst = (GC_MASTER_FORGET_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class CG_MASTER_LEARN_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_MASTER_LEARN_SKILL _inst = (CG_MASTER_LEARN_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class GC_MASTER_ACTIVE_SKILL : PacketDistributed
{

public const int skillIdFieldNumber = 1;
 private bool hasSkillId;
 private Int32 skillId_ = 0;
 public bool HasSkillId {
 get { return hasSkillId; }
 }
 public Int32 SkillId {
 get { return skillId_; }
 set { SetSkillId(value); }
 }
 public void SetSkillId(Int32 value) { 
 hasSkillId = true;
 skillId_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasSkillId) {
size += pb::CodedOutputStream.ComputeInt32Size(1, SkillId);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasSkillId) {
output.WriteInt32(1, SkillId);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 GC_MASTER_ACTIVE_SKILL _inst = (GC_MASTER_ACTIVE_SKILL) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.SkillId = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasSkillId) return false;
 return true;
 }

}


[Serializable]
public class CG_ASK_RANK : PacketDistributed
{

public const int nTypeFieldNumber = 1;
 private bool hasNType;
 private Int32 nType_ = 0;
 public bool HasNType {
 get { return hasNType; }
 }
 public Int32 NType {
 get { return nType_; }
 set { SetNType(value); }
 }
 public void SetNType(Int32 value) { 
 hasNType = true;
 nType_ = value;
 }

public const int nPageFieldNumber = 2;
 private bool hasNPage;
 private Int32 nPage_ = 0;
 public bool HasNPage {
 get { return hasNPage; }
 }
 public Int32 NPage {
 get { return nPage_; }
 set { SetNPage(value); }
 }
 public void SetNPage(Int32 value) { 
 hasNPage = true;
 nPage_ = value;
 }

 private int memoizedSerializedSize = -1;
 public override int SerializedSize()
 {
 int size = memoizedSerializedSize;
 if (size != -1) return size;
 size = 0;
  if (HasNType) {
size += pb::CodedOutputStream.ComputeInt32Size(1, NType);
}
 if (HasNPage) {
size += pb::CodedOutputStream.ComputeInt32Size(2, NPage);
}
 memoizedSerializedSize = size;
 return size;
 }

public override void WriteTo(pb::CodedOutputStream output)
 {
 int size = SerializedSize();
  
if (HasNType) {
output.WriteInt32(1, NType);
}
 
if (HasNPage) {
output.WriteInt32(2, NPage);
}
 }
public override PacketDistributed MergeFrom(pb::CodedInputStream input,PacketDistributed _base) {
 CG_ASK_RANK _inst = (CG_ASK_RANK) _base;
 while (true) {
 uint tag = input.ReadTag();
 switch (tag) {
 case 0:
 {
 return _inst;
 }
    case  8: {
 _inst.NType = input.ReadInt32();
break;
}
   case  16: {
 _inst.NPage = input.ReadInt32();
break;
}

 }
 }
 return _inst;
 }
//end merged
public override bool IsInitialized() {
  if (!hasNType) return false;
 if (!hasNPage) return false;
 return true;
 }

}


[Serializable]
public class GC_RET_RANK : PacketDistributed
{

public const int typeFieldNumber = 1;
 private bool hasType;
 private Int32 type_ = 0;
 public bool HasType {
 get { return hasType; }
 }
 public Int32 Type {
 get { return type_; }
 set { SetType(value); }
 }
 public void SetType(Int32 value) { 
 hasType = true;
 type_ = value;
 }

public const int merankFieldNumber = 2;
 private bool hasMerank;
 private Int32 merank_ = 0;
 public bool HasMerank {
 get { return hasMerank; }
 }
 public Int32 Merank {
 get { return merank_; }
 set { SetMerank(value); }
 }
 public void SetMerank(Int32 value) { 
 hasMerank = true;
 merank_ = value;
 }

public const int guidFieldNumber = 3;
 private pbc::PopsicleList<UInt64> guid_ = new pbc::PopsicleList<UInt64>();
 public scg::IList<UInt64> guidList {
 get { return pbc::Lists.AsReadOnly(guid_); }
 }
 
 public int guidCount {
 get { return guid_.Count; }
 }
 
public UInt64 GetGuid(int index) {
 return guid_[index];
 }
 public void AddGuid(UInt64 value) {
 guid_.Add(value);
 }

public const int nameFieldNumber = 4;
 private pbc::PopsicleList<string> name_ = new pbc::PopsicleList<string>();
 public scg::IList<string> nameList {
 get { return pbc::Lists.AsReadOnly(name_); }
 }
 
 public int nameCount {
 get { return name_.Count; }
 }
 
public string GetName(int index) {
 return name_[index];
 }
 public void AddName(string value) {
 name_.Add(value);
 }

public const int levelFieldNumber = 5;
 private pbc::PopsicleList<Int32> level_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> levelList {
 get { return pbc::Lists.AsReadOnly(level_); }
 }
 
 public int levelCount {
 get { return level_.Count; }
 }
 
public Int32 GetLevel(int index) {
 return level_[index];
 }
 public void AddLevel(Int32 value) {
 level_.Add(value);
 }

public const int proFieldNumber = 6;
 private pbc::PopsicleList<Int32> pro_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> proList {
 get { return pbc::Lists.AsReadOnly(pro_); }
 }
 
 public int proCount {
 get { return pro_.Count; }
 }
 
public Int32 GetPro(int index) {
 return pro_[index];
 }
 public void AddPro(Int32 value) {
 pro_.Add(value);
 }

public const int tierFieldNumber = 7;
 private pbc::PopsicleList<Int32> tier_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> tierList {
 get { return pbc::Lists.AsReadOnly(tier_); }
 }
 
 public int tierCount {
 get { return tier_.Count; }
 }
 
public Int32 GetTier(int index) {
 return tier_[index];
 }
 public void AddTier(Int32 value) {
 tier_.Add(value);
 }

public const int timeFieldNumber = 8;
 private pbc::PopsicleList<Int32> time_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> timeList {
 get { return pbc::Lists.AsReadOnly(time_); }
 }
 
 public int timeCount {
 get { return time_.Count; }
 }
 
public Int32 GetTime(int index) {
 return time_[index];
 }
 public void AddTime(Int32 value) {
 time_.Add(value);
 }

public const int guildSortNumFieldNumber = 9;
 private pbc::PopsicleList<Int32> guildSortNum_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> guildSortNumList {
 get { return pbc::Lists.AsReadOnly(guildSortNum_); }
 }
 
 public int guildSortNumCount {
 get { return guildSortNum_.Count; }
 }
 
public Int32 GetGuildSortNum(int index) {
 return guildSortNum_[index];
 }
 public void AddGuildSortNum(Int32 value) {
 guildSortNum_.Add(value);
 }

public const int guildScoreFieldNumber = 10;
 private pbc::PopsicleList<Int32> guildScore_ = new pbc::PopsicleList<Int32>();
 public scg::IList<Int32> guildScoreList {
 get { return pbc::Lists.AsReadOnly(guildScore_); }
 }
 
 public int guildScoreCount {
 get { return guildScore_.Count; }
 }
 
public Int32 GetGuildScore(int index) {
 return guildScore_[index];
 }
 public void AddGuildScore(Int32 value) {
 guildScore_.Add(value);
 }

public const int guilidNameFieldNumber = 11;
 public scg::IList<string> guilidNameList {
 }
 
 }
 
 }
 }

 }
 