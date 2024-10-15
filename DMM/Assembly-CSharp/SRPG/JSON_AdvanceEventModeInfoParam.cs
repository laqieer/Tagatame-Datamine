// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdvanceEventModeInfoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001956")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdvanceEventModeInfoParam
  {
    [Token(Token = "0x4005C22")]
    [FieldOffset(Offset = "0x8")]
    public string star_id;
    [Token(Token = "0x4005C23")]
    [FieldOffset(Offset = "0xC")]
    public int liberation_qno;
    [Token(Token = "0x4005C24")]
    [FieldOffset(Offset = "0x10")]
    public string boss_unit_id;
    [Token(Token = "0x4005C25")]
    [FieldOffset(Offset = "0x14")]
    public int boss_hp;
    [Token(Token = "0x4005C26")]
    [FieldOffset(Offset = "0x18")]
    public string boss_ch_item_id;
    [Token(Token = "0x4005C27")]
    [FieldOffset(Offset = "0x1C")]
    public int boss_ch_item_num;
    [Token(Token = "0x4005C28")]
    [FieldOffset(Offset = "0x20")]
    public string boss_reward_id;
    [Token(Token = "0x4005C29")]
    [FieldOffset(Offset = "0x24")]
    public int mode_ui_index;
    [Token(Token = "0x4005C2A")]
    [FieldOffset(Offset = "0x28")]
    public string lap_boss_id;

    [Token(Token = "0x6006742")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdvanceEventModeInfoParam()
    {
    }
  }
}
