// Decompiled with JetBrains decompiler
// Type: SRPG.DuelBonusUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ABD")]
  public class DuelBonusUnit
  {
    [Token(Token = "0x400631F")]
    [FieldOffset(Offset = "0x8")]
    private int mRate;
    [Token(Token = "0x4006320")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mUnits;

    [Token(Token = "0x17000C61")]
    public int Rate
    {
      [Token(Token = "0x6006E30"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C62")]
    public List<string> Units
    {
      [Token(Token = "0x6006E31"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6006E32")]
    [Address(RVA = "0x35EA30", Offset = "0x35D830", VA = "0x1035EA30")]
    public bool Deserialize(JSON_DuelBonusUnit json) => new bool();

    [Token(Token = "0x6006E33")]
    [Address(RVA = "0x35EB30", Offset = "0x35D930", VA = "0x1035EB30")]
    public DuelBonusUnit()
    {
    }
  }
}
