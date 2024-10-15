// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingEnergyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B37")]
  public class GuildTrainingEnergyItem
  {
    [Token(Token = "0x40067A3")]
    [FieldOffset(Offset = "0x8")]
    private string mItemIname;
    [Token(Token = "0x40067A4")]
    [FieldOffset(Offset = "0xC")]
    private int mAddEnergyVal;

    [Token(Token = "0x17000D2C")]
    public string ItemIname
    {
      [Token(Token = "0x6007024"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D2D")]
    public int AddEnergyVal
    {
      [Token(Token = "0x6007025"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007026")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(JSON_GuildTrainingEnergyItem json) => new bool();

    [Token(Token = "0x6007027")]
    [Address(RVA = "0x372050", Offset = "0x370E50", VA = "0x10372050")]
    public static void Deserialize(
      ref List<GuildTrainingEnergyItem> param,
      JSON_GuildTrainingEnergyItem[] json)
    {
    }

    [Token(Token = "0x6007028")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrainingEnergyItem()
    {
    }
  }
}
