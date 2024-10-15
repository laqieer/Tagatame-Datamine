// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidBossInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010CC")]
  [Serializable]
  public class JSON_RaidBossInfo
  {
    [Token(Token = "0x4003C8C")]
    [FieldOffset(Offset = "0x8")]
    public int no;
    [Token(Token = "0x4003C8D")]
    [FieldOffset(Offset = "0xC")]
    public int boss_id;
    [Token(Token = "0x4003C8E")]
    [FieldOffset(Offset = "0x10")]
    public int round;
    [Token(Token = "0x4003C8F")]
    [FieldOffset(Offset = "0x14")]
    public int current_hp;
    [Token(Token = "0x4003C90")]
    [FieldOffset(Offset = "0x18")]
    public long start_time;
    [Token(Token = "0x4003C91")]
    [FieldOffset(Offset = "0x20")]
    public int is_reward;
    [Token(Token = "0x4003C92")]
    [FieldOffset(Offset = "0x24")]
    public int is_timeover;
    [Token(Token = "0x4003C93")]
    [FieldOffset(Offset = "0x28")]
    public int is_rescue_damage_zero;
    [Token(Token = "0x4003C94")]
    [FieldOffset(Offset = "0x2C")]
    public int is_beat_resucue;

    [Token(Token = "0x600471B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidBossInfo()
    {
    }
  }
}
