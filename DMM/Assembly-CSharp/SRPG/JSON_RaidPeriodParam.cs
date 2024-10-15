// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidPeriodParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C7F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RaidPeriodParam : JSON_RaidMasterParam
  {
    [Token(Token = "0x4006FE8")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006FE9")]
    [FieldOffset(Offset = "0xC")]
    public int max_bp;
    [Token(Token = "0x4006FEA")]
    [FieldOffset(Offset = "0x10")]
    public string add_bp_time;
    [Token(Token = "0x4006FEB")]
    [FieldOffset(Offset = "0x14")]
    public int bp_by_coin;
    [Token(Token = "0x4006FEC")]
    [FieldOffset(Offset = "0x18")]
    public int rescue_member_max;
    [Token(Token = "0x4006FED")]
    [FieldOffset(Offset = "0x1C")]
    public string rescure_send_interval;
    [Token(Token = "0x4006FEE")]
    [FieldOffset(Offset = "0x20")]
    public int complete_reward_id;
    [Token(Token = "0x4006FEF")]
    [FieldOffset(Offset = "0x24")]
    public int round_buff_max;
    [Token(Token = "0x4006FF0")]
    [FieldOffset(Offset = "0x28")]
    public string begin_at;
    [Token(Token = "0x4006FF1")]
    [FieldOffset(Offset = "0x2C")]
    public string end_at;
    [Token(Token = "0x4006FF2")]
    [FieldOffset(Offset = "0x30")]
    public string reward_begin_at;
    [Token(Token = "0x4006FF3")]
    [FieldOffset(Offset = "0x34")]
    public string reward_end_at;

    [Token(Token = "0x6007582")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidPeriodParam()
    {
    }
  }
}
