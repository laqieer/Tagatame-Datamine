// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E84")]
  public class UnitGroupParam
  {
    [Token(Token = "0x4007E9C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007E9D")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007E9E")]
    [FieldOffset(Offset = "0x10")]
    public string[] units;

    [Token(Token = "0x6007D25")]
    [Address(RVA = "0x3F1080", Offset = "0x3EFE80", VA = "0x103F1080")]
    public bool Deserialize(JSON_UnitGroupParam json) => new bool();

    [Token(Token = "0x6007D26")]
    [Address(RVA = "0x3F1430", Offset = "0x3F0230", VA = "0x103F1430")]
    public bool IsInGroup(string unit_iname) => new bool();

    [Token(Token = "0x6007D27")]
    [Address(RVA = "0x3F1250", Offset = "0x3F0050", VA = "0x103F1250")]
    public string GetName() => (string) null;

    [Token(Token = "0x6007D28")]
    [Address(RVA = "0x3F10D0", Offset = "0x3EFED0", VA = "0x103F10D0")]
    public string GetGroupUnitAllNameText() => (string) null;

    [Token(Token = "0x6007D29")]
    [Address(RVA = "0x3F13D0", Offset = "0x3F01D0", VA = "0x103F13D0")]
    public static bool IsInGroup(UnitGroupParam[] group_param, string unit_iname) => new bool();

    [Token(Token = "0x6007D2A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitGroupParam()
    {
    }
  }
}
