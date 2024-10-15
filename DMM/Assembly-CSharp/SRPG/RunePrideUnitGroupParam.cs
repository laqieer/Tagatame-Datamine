// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideUnitGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D10")]
  public class RunePrideUnitGroupParam
  {
    [Token(Token = "0x40071E8")]
    [FieldOffset(Offset = "0x8")]
    private string mId;
    [Token(Token = "0x40071E9")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mUnits;

    [Token(Token = "0x17000FC0")]
    public string Id
    {
      [Token(Token = "0x6007756"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FC1")]
    public List<string> Units
    {
      [Token(Token = "0x6007757"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6007758")]
    [Address(RVA = "0x39D3B0", Offset = "0x39C1B0", VA = "0x1039D3B0")]
    public bool Deserialize(JSON_RunePrideUnitGroupParam _json) => new bool();

    [Token(Token = "0x6007759")]
    [Address(RVA = "0x39D6C0", Offset = "0x39C4C0", VA = "0x1039D6C0")]
    public bool IsGroupUnit(string unit_iname) => new bool();

    [Token(Token = "0x600775A")]
    [Address(RVA = "0x39D4A0", Offset = "0x39C2A0", VA = "0x1039D4A0")]
    public static bool Deserialize(
      ref List<RunePrideUnitGroupParam> paramList,
      JSON_RunePrideUnitGroupParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600775B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideUnitGroupParam()
    {
    }
  }
}
