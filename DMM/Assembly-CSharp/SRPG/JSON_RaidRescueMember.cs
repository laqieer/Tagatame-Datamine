// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidRescueMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010CE")]
  [Serializable]
  public class JSON_RaidRescueMember
  {
    [Token(Token = "0x4003C9B")]
    [FieldOffset(Offset = "0x8")]
    public string uid;
    [Token(Token = "0x4003C9C")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4003C9D")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x4003C9E")]
    [FieldOffset(Offset = "0x14")]
    public int member_type;
    [Token(Token = "0x4003C9F")]
    [FieldOffset(Offset = "0x18")]
    public Json_Unit unit;
    [Token(Token = "0x4003CA0")]
    [FieldOffset(Offset = "0x1C")]
    public string selected_award;
    [Token(Token = "0x4003CA1")]
    [FieldOffset(Offset = "0x20")]
    public int lastlogin;
    [Token(Token = "0x4003CA2")]
    [FieldOffset(Offset = "0x24")]
    public int area_id;
    [Token(Token = "0x4003CA3")]
    [FieldOffset(Offset = "0x28")]
    public int boss_id;
    [Token(Token = "0x4003CA4")]
    [FieldOffset(Offset = "0x2C")]
    public int round;
    [Token(Token = "0x4003CA5")]
    [FieldOffset(Offset = "0x30")]
    public int current_hp;
    [Token(Token = "0x4003CA6")]
    [FieldOffset(Offset = "0x38")]
    public long start_time;
    [Token(Token = "0x4003CA7")]
    [FieldOffset(Offset = "0x40")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x600471D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidRescueMember()
    {
    }
  }
}
