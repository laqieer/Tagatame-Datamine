// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestCampaignChildParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C2B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_QuestCampaignChildParam
  {
    [Token(Token = "0x4006D39")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006D3A")]
    [FieldOffset(Offset = "0xC")]
    public int scope;
    [Token(Token = "0x4006D3B")]
    [FieldOffset(Offset = "0x10")]
    public int quest_type;
    [Token(Token = "0x4006D3C")]
    [FieldOffset(Offset = "0x14")]
    public int quest_mode;
    [Token(Token = "0x4006D3D")]
    [FieldOffset(Offset = "0x18")]
    public string quest_id;
    [Token(Token = "0x4006D3E")]
    [FieldOffset(Offset = "0x1C")]
    public string unit;
    [Token(Token = "0x4006D3F")]
    [FieldOffset(Offset = "0x20")]
    public int drop_rate;
    [Token(Token = "0x4006D40")]
    [FieldOffset(Offset = "0x24")]
    public int drop_num;
    [Token(Token = "0x4006D41")]
    [FieldOffset(Offset = "0x28")]
    public int exp_player;
    [Token(Token = "0x4006D42")]
    [FieldOffset(Offset = "0x2C")]
    public int exp_unit;
    [Token(Token = "0x4006D43")]
    [FieldOffset(Offset = "0x30")]
    public int ap_rate;
    [Token(Token = "0x4006D44")]
    [FieldOffset(Offset = "0x34")]
    public int rental_fav_rate;

    [Token(Token = "0x60073E9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestCampaignChildParam()
    {
    }
  }
}
