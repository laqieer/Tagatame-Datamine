// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestEventParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C01")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PointQuestEventParam
  {
    [Token(Token = "0x4006C69")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006C6A")]
    [FieldOffset(Offset = "0xC")]
    public int priority;
    [Token(Token = "0x4006C6B")]
    [FieldOffset(Offset = "0x10")]
    public string shop_iname;
    [Token(Token = "0x4006C6C")]
    [FieldOffset(Offset = "0x14")]
    public int total_point_limit;
    [Token(Token = "0x4006C6D")]
    [FieldOffset(Offset = "0x18")]
    public string total_reward_iname;
    [Token(Token = "0x4006C6E")]
    [FieldOffset(Offset = "0x1C")]
    public int guild_total_point_limit;
    [Token(Token = "0x4006C6F")]
    [FieldOffset(Offset = "0x20")]
    public string guild_total_reward_iname;
    [Token(Token = "0x4006C70")]
    [FieldOffset(Offset = "0x24")]
    public string ranking_reward_iname;
    [Token(Token = "0x4006C71")]
    [FieldOffset(Offset = "0x28")]
    public string ranking_end_at;
    [Token(Token = "0x4006C72")]
    [FieldOffset(Offset = "0x2C")]
    public string reward_begin_at;
    [Token(Token = "0x4006C73")]
    [FieldOffset(Offset = "0x30")]
    public string guild_ranking_reward_iname;
    [Token(Token = "0x4006C74")]
    [FieldOffset(Offset = "0x34")]
    public int guild_reward_add_point;
    [Token(Token = "0x4006C75")]
    [FieldOffset(Offset = "0x38")]
    public string webview_url;
    [Token(Token = "0x4006C76")]
    [FieldOffset(Offset = "0x3C")]
    public string webview_title;
    [Token(Token = "0x4006C77")]
    [FieldOffset(Offset = "0x40")]
    public string bg_path;
    [Token(Token = "0x4006C78")]
    [FieldOffset(Offset = "0x44")]
    public string banner_path;
    [Token(Token = "0x4006C79")]
    [FieldOffset(Offset = "0x48")]
    public JSON_PointQuestEventBonuses[] bonuses;
    [Token(Token = "0x4006C7A")]
    [FieldOffset(Offset = "0x4C")]
    public string news_begin_at;
    [Token(Token = "0x4006C7B")]
    [FieldOffset(Offset = "0x50")]
    public string news_end_at;
    [Token(Token = "0x4006C7C")]
    [FieldOffset(Offset = "0x54")]
    public int news_show_type;
    [Token(Token = "0x4006C7D")]
    [FieldOffset(Offset = "0x58")]
    public string pulldown_name;

    [Token(Token = "0x600734F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestEventParam()
    {
    }
  }
}
