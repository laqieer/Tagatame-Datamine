// Decompiled with JetBrains decompiler
// Type: SRPG.GimmickEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C0E")]
  public class GimmickEvent
  {
    [Token(Token = "0x4001F26")]
    [FieldOffset(Offset = "0x8")]
    public eGimmickEventType ev_type;
    [Token(Token = "0x4001F27")]
    [FieldOffset(Offset = "0xC")]
    public List<string> skills;
    [Token(Token = "0x4001F28")]
    [FieldOffset(Offset = "0x10")]
    public List<Unit> users;
    [Token(Token = "0x4001F29")]
    [FieldOffset(Offset = "0x14")]
    public List<Unit> targets;
    [Token(Token = "0x4001F2A")]
    [FieldOffset(Offset = "0x18")]
    public List<TrickData> td_targets;
    [Token(Token = "0x4001F2B")]
    [FieldOffset(Offset = "0x1C")]
    public string td_iname;
    [Token(Token = "0x4001F2C")]
    [FieldOffset(Offset = "0x20")]
    public string td_tag;
    [Token(Token = "0x4001F2D")]
    [FieldOffset(Offset = "0x24")]
    public GimmickEventCondition condition;
    [Token(Token = "0x4001F2E")]
    [FieldOffset(Offset = "0x28")]
    public int count;
    [Token(Token = "0x4001F2F")]
    [FieldOffset(Offset = "0x2C")]
    public bool IsCompleted;
    [Token(Token = "0x4001F30")]
    [FieldOffset(Offset = "0x2D")]
    public bool IsStarter;
    [Token(Token = "0x4001F31")]
    [FieldOffset(Offset = "0x30")]
    public Unit starter;

    [Token(Token = "0x600301F")]
    [Address(RVA = "0xFE4490", Offset = "0xFE3290", VA = "0x10FE4490")]
    public GimmickEvent()
    {
    }
  }
}
