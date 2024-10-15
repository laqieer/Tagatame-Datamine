// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingEnergyLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B35")]
  public class GuildTrainingEnergyLimit
  {
    [Token(Token = "0x400679F")]
    [FieldOffset(Offset = "0x8")]
    private int mMemberNum;
    [Token(Token = "0x40067A0")]
    [FieldOffset(Offset = "0xC")]
    private int mEnergyTankLimit;

    [Token(Token = "0x17000D2A")]
    public int MemberNum
    {
      [Token(Token = "0x600701E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D2B")]
    public int EnergyTankLimit
    {
      [Token(Token = "0x600701F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007020")]
    [Address(RVA = "0x3722B0", Offset = "0x3710B0", VA = "0x103722B0")]
    public bool Deserialize(JSON_GuildTrainingEnergyLimit json) => new bool();

    [Token(Token = "0x6007021")]
    [Address(RVA = "0x3721B0", Offset = "0x370FB0", VA = "0x103721B0")]
    public static void Deserialize(
      ref List<GuildTrainingEnergyLimit> param,
      JSON_GuildTrainingEnergyLimit[] json)
    {
    }

    [Token(Token = "0x6007022")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrainingEnergyLimit()
    {
    }
  }
}
