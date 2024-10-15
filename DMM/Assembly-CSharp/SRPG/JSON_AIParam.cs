// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DCE")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AIParam
  {
    [Token(Token = "0x40076EB")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40076EC")]
    [FieldOffset(Offset = "0xC")]
    public int role;
    [Token(Token = "0x40076ED")]
    [FieldOffset(Offset = "0x10")]
    public int prm;
    [Token(Token = "0x40076EE")]
    [FieldOffset(Offset = "0x14")]
    public int prmprio;
    [Token(Token = "0x40076EF")]
    [FieldOffset(Offset = "0x18")]
    public int notprio;
    [Token(Token = "0x40076F0")]
    [FieldOffset(Offset = "0x1C")]
    public int best;
    [Token(Token = "0x40076F1")]
    [FieldOffset(Offset = "0x20")]
    public int sneak;
    [Token(Token = "0x40076F2")]
    [FieldOffset(Offset = "0x24")]
    public int notmov;
    [Token(Token = "0x40076F3")]
    [FieldOffset(Offset = "0x28")]
    public int notact;
    [Token(Token = "0x40076F4")]
    [FieldOffset(Offset = "0x2C")]
    public int notskl;
    [Token(Token = "0x40076F5")]
    [FieldOffset(Offset = "0x30")]
    public int notavo;
    [Token(Token = "0x40076F6")]
    [FieldOffset(Offset = "0x34")]
    public int notmpd;
    [Token(Token = "0x40076F7")]
    [FieldOffset(Offset = "0x38")]
    public int sos;
    [Token(Token = "0x40076F8")]
    [FieldOffset(Offset = "0x3C")]
    public int heal;
    [Token(Token = "0x40076F9")]
    [FieldOffset(Offset = "0x40")]
    public int gems;
    [Token(Token = "0x40076FA")]
    [FieldOffset(Offset = "0x44")]
    public int notsup_hp;
    [Token(Token = "0x40076FB")]
    [FieldOffset(Offset = "0x48")]
    public int notsup_num;
    [Token(Token = "0x40076FC")]
    [FieldOffset(Offset = "0x4C")]
    public int[] skill;
    [Token(Token = "0x40076FD")]
    [FieldOffset(Offset = "0x50")]
    public int csff;
    [Token(Token = "0x40076FE")]
    [FieldOffset(Offset = "0x54")]
    public int[] skil_prio;
    [Token(Token = "0x40076FF")]
    [FieldOffset(Offset = "0x58")]
    public int[] buff_prio;
    [Token(Token = "0x4007700")]
    [FieldOffset(Offset = "0x5C")]
    public int buff_self;
    [Token(Token = "0x4007701")]
    [FieldOffset(Offset = "0x60")]
    public int buff_border;
    [Token(Token = "0x4007702")]
    [FieldOffset(Offset = "0x64")]
    public int[] cond_prio;
    [Token(Token = "0x4007703")]
    [FieldOffset(Offset = "0x68")]
    public int cond_border;
    [Token(Token = "0x4007704")]
    [FieldOffset(Offset = "0x6C")]
    public int safe_border;
    [Token(Token = "0x4007705")]
    [FieldOffset(Offset = "0x70")]
    public int gosa_border;
    [Token(Token = "0x4007706")]
    [FieldOffset(Offset = "0x74")]
    public int use_old_sort;

    [Token(Token = "0x60079E0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AIParam()
    {
    }
  }
}
