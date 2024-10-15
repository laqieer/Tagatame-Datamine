// Decompiled with JetBrains decompiler
// Type: SRPG.GuildAttendRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B26")]
  public class GuildAttendRewardParam
  {
    [Token(Token = "0x4006776")]
    [FieldOffset(Offset = "0x8")]
    private string mID;
    [Token(Token = "0x4006777")]
    [FieldOffset(Offset = "0xC")]
    private GuildAttendReward[] mRewards;

    [Token(Token = "0x17000D14")]
    public string id
    {
      [Token(Token = "0x6006FED"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D15")]
    public GuildAttendReward[] rewards
    {
      [Token(Token = "0x6006FEE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GuildAttendReward[]) null;
      }
    }

    [Token(Token = "0x6006FEF")]
    [Address(RVA = "0x36E8C0", Offset = "0x36D6C0", VA = "0x1036E8C0")]
    public static bool Deserialize(
      ref List<GuildAttendRewardParam> param,
      JSON_GuildAttendRewardParam[] json)
    {
      return new bool();
    }

    [Token(Token = "0x6006FF0")]
    [Address(RVA = "0x36E750", Offset = "0x36D550", VA = "0x1036E750")]
    public void Deserialize(JSON_GuildAttendRewardParam json)
    {
    }

    [Token(Token = "0x6006FF1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildAttendRewardParam()
    {
    }
  }
}
