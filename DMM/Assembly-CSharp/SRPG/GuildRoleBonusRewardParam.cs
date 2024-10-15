// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRoleBonusRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B2E")]
  public class GuildRoleBonusRewardParam
  {
    [Token(Token = "0x400678E")]
    [FieldOffset(Offset = "0x8")]
    private string mID;
    [Token(Token = "0x400678F")]
    [FieldOffset(Offset = "0xC")]
    private GuildRoleBonusReward[] mRewards;

    [Token(Token = "0x17000D20")]
    public string id
    {
      [Token(Token = "0x6007007"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D21")]
    public GuildRoleBonusReward[] rewards
    {
      [Token(Token = "0x6007008"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GuildRoleBonusReward[]) null;
      }
    }

    [Token(Token = "0x6007009")]
    [Address(RVA = "0x3715D0", Offset = "0x3703D0", VA = "0x103715D0")]
    public static bool Deserialize(
      ref List<GuildRoleBonusRewardParam> param,
      JSON_GuildRoleBonusRewardParam[] json)
    {
      return new bool();
    }

    [Token(Token = "0x600700A")]
    [Address(RVA = "0x371840", Offset = "0x370640", VA = "0x10371840")]
    public void Deserialize(JSON_GuildRoleBonusRewardParam json)
    {
    }

    [Token(Token = "0x600700B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRoleBonusRewardParam()
    {
    }
  }
}
