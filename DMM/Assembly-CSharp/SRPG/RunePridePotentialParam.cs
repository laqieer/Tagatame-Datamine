// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePotentialParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D06")]
  [MessagePackObject(true)]
  public class RunePridePotentialParam
  {
    [Token(Token = "0x40071C4")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40071C5")]
    [FieldOffset(Offset = "0xC")]
    private string[] potentials;

    [Token(Token = "0x17000FAE")]
    public string Iname
    {
      [Token(Token = "0x6007732"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FAF")]
    public string[] Potentials
    {
      [Token(Token = "0x6007733"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x6007734")]
    [Address(RVA = "0x34E540", Offset = "0x34D340", VA = "0x1034E540")]
    public bool Deserialize(JSON_RunePridePotentialParam json) => new bool();

    [Token(Token = "0x6007735")]
    [Address(RVA = "0x39CB70", Offset = "0x39B970", VA = "0x1039CB70")]
    public static bool Deserialize(
      ref List<RunePridePotentialParam> paramList,
      JSON_RunePridePotentialParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007736")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePotentialParam()
    {
    }
  }
}
