// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_Guild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F81")]
  [Serializable]
  public class JSON_Guild
  {
    [Token(Token = "0x400365E")]
    [FieldOffset(Offset = "0x8")]
    public long id;
    [Token(Token = "0x400365F")]
    [FieldOffset(Offset = "0x10")]
    public string created_uid;
    [Token(Token = "0x4003660")]
    [FieldOffset(Offset = "0x14")]
    public string name;
    [Token(Token = "0x4003661")]
    [FieldOffset(Offset = "0x18")]
    public string award_id;
    [Token(Token = "0x4003662")]
    [FieldOffset(Offset = "0x1C")]
    public string board;
    [Token(Token = "0x4003663")]
    [FieldOffset(Offset = "0x20")]
    public int count;
    [Token(Token = "0x4003664")]
    [FieldOffset(Offset = "0x24")]
    public int max_count;
    [Token(Token = "0x4003665")]
    [FieldOffset(Offset = "0x28")]
    public int submaster_count;
    [Token(Token = "0x4003666")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_GuildEntryCondition guild_subscription_condition;
    [Token(Token = "0x4003667")]
    [FieldOffset(Offset = "0x30")]
    public JSON_GuildMember[] guild_member;
    [Token(Token = "0x4003668")]
    [FieldOffset(Offset = "0x34")]
    public string[] have_awards;
    [Token(Token = "0x4003669")]
    [FieldOffset(Offset = "0x38")]
    public JSON_GuildFacilityData[] facilities;
    [Token(Token = "0x400366A")]
    [FieldOffset(Offset = "0x40")]
    public long created_at;
    [Token(Token = "0x400366B")]
    [FieldOffset(Offset = "0x48")]
    public int gvg_join_status;
    [Token(Token = "0x400366C")]
    [FieldOffset(Offset = "0x4C")]
    public int gvg_rate;
    [Token(Token = "0x400366D")]
    [FieldOffset(Offset = "0x50")]
    public int board_unread;

    [Token(Token = "0x6004054")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_Guild()
    {
    }
  }
}
