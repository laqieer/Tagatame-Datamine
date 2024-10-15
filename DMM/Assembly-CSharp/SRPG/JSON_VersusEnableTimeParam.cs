// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusEnableTimeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EBC")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusEnableTimeParam
  {
    [Token(Token = "0x40080F2")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40080F3")]
    [FieldOffset(Offset = "0xC")]
    public int mode;
    [Token(Token = "0x40080F4")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x40080F5")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x40080F6")]
    [FieldOffset(Offset = "0x18")]
    public int draft_id;
    [Token(Token = "0x40080F7")]
    [FieldOffset(Offset = "0x1C")]
    public int draft_type;
    [Token(Token = "0x40080F8")]
    [FieldOffset(Offset = "0x20")]
    public int[] friend_draft_ids;
    [Token(Token = "0x40080F9")]
    [FieldOffset(Offset = "0x24")]
    public JSON_VersusEnableTimeScheduleParam[] schedule;
    [Token(Token = "0x40080FA")]
    [FieldOffset(Offset = "0x28")]
    public int draft_lock_num;
    [Token(Token = "0x40080FB")]
    [FieldOffset(Offset = "0x2C")]
    public string tagatame_cup_iname;

    [Token(Token = "0x6007DE3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusEnableTimeParam()
    {
    }
  }
}
