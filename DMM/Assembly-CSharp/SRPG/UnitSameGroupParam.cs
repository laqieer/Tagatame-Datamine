// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSameGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E9D")]
  public class UnitSameGroupParam
  {
    [Token(Token = "0x4007FFF")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4008000")]
    [FieldOffset(Offset = "0xC")]
    public string[] units;

    [Token(Token = "0x6007D90")]
    [Address(RVA = "0x3F6DB0", Offset = "0x3F5BB0", VA = "0x103F6DB0")]
    public static void Deserialize(
      ref List<UnitSameGroupParam> ref_params,
      JSON_UnitSameGroupParam[] json)
    {
    }

    [Token(Token = "0x6007D91")]
    [Address(RVA = "0x362350", Offset = "0x361150", VA = "0x10362350")]
    public bool Deserialize(JSON_UnitSameGroupParam json) => new bool();

    [Token(Token = "0x6007D92")]
    [Address(RVA = "0x3F7400", Offset = "0x3F6200", VA = "0x103F7400")]
    public bool IsInGroup(string unit_iname) => new bool();

    [Token(Token = "0x6007D93")]
    [Address(RVA = "0x3F73D0", Offset = "0x3F61D0", VA = "0x103F73D0")]
    public string GetName() => (string) null;

    [Token(Token = "0x6007D94")]
    [Address(RVA = "0x3F6F00", Offset = "0x3F5D00", VA = "0x103F6F00")]
    public string GetGroupUnitAllNameText() => (string) null;

    [Token(Token = "0x6007D95")]
    [Address(RVA = "0x3F7150", Offset = "0x3F5F50", VA = "0x103F7150")]
    public string GetGroupUnitOtherNameText(string unit_name) => (string) null;

    [Token(Token = "0x6007D96")]
    [Address(RVA = "0x3F13D0", Offset = "0x3F01D0", VA = "0x103F13D0")]
    public static bool IsInGroup(UnitGroupParam[] group_param, string unit_iname) => new bool();

    [Token(Token = "0x6007D97")]
    [Address(RVA = "0x3F76C0", Offset = "0x3F64C0", VA = "0x103F76C0")]
    public static List<UnitSameGroupParam> IsSameUnitInParty(UnitData[] units)
    {
      return (List<UnitSameGroupParam>) null;
    }

    [Token(Token = "0x6007D98")]
    [Address(RVA = "0x3F7950", Offset = "0x3F6750", VA = "0x103F7950")]
    public static bool IsSameUnitInParty(UnitData[] units, string unitID) => new bool();

    [Token(Token = "0x6007D99")]
    [Address(RVA = "0x3F74C0", Offset = "0x3F62C0", VA = "0x103F74C0")]
    public static UnitSameGroupParam IsSameUnitInParty(
      UnitData[] units,
      UnitData changed,
      UnitData selected)
    {
      return (UnitSameGroupParam) null;
    }

    [Token(Token = "0x6007D9A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitSameGroupParam()
    {
    }
  }
}
