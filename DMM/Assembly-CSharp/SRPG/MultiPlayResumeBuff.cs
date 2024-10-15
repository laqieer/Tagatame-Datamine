// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeBuff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D91")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayResumeBuff
  {
    [Token(Token = "0x400269F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40026A0")]
    [FieldOffset(Offset = "0xC")]
    public int turn;
    [Token(Token = "0x40026A1")]
    [FieldOffset(Offset = "0x10")]
    public int unitindex;
    [Token(Token = "0x40026A2")]
    [FieldOffset(Offset = "0x14")]
    public int checkunit;
    [Token(Token = "0x40026A3")]
    [FieldOffset(Offset = "0x18")]
    public int timing;
    [Token(Token = "0x40026A4")]
    [FieldOffset(Offset = "0x1C")]
    public bool passive;
    [Token(Token = "0x40026A5")]
    [FieldOffset(Offset = "0x20")]
    public int condition;
    [Token(Token = "0x40026A6")]
    [FieldOffset(Offset = "0x24")]
    public int type;
    [Token(Token = "0x40026A7")]
    [FieldOffset(Offset = "0x28")]
    public int vtp;
    [Token(Token = "0x40026A8")]
    [FieldOffset(Offset = "0x30")]
    public long calc;
    [Token(Token = "0x40026A9")]
    [FieldOffset(Offset = "0x38")]
    public int curse;
    [Token(Token = "0x40026AA")]
    [FieldOffset(Offset = "0x3C")]
    public int skilltarget;
    [Token(Token = "0x40026AB")]
    [FieldOffset(Offset = "0x40")]
    public string bc_id;
    [Token(Token = "0x40026AC")]
    [FieldOffset(Offset = "0x44")]
    public uint lid;
    [Token(Token = "0x40026AD")]
    [FieldOffset(Offset = "0x48")]
    public int ubc;
    [Token(Token = "0x40026AE")]
    [FieldOffset(Offset = "0x4C")]
    public string bss;
    [Token(Token = "0x40026AF")]
    [FieldOffset(Offset = "0x50")]
    public List<MultiPlayResumeBuff.ResistStatus> rsl;
    [Token(Token = "0x40026B0")]
    [FieldOffset(Offset = "0x54")]
    public int lad;
    [Token(Token = "0x40026B1")]
    [FieldOffset(Offset = "0x58")]
    public int dmg;
    [Token(Token = "0x40026B2")]
    [FieldOffset(Offset = "0x5C")]
    public int jwl;
    [Token(Token = "0x40026B3")]
    [FieldOffset(Offset = "0x60")]
    public int hct;
    [Token(Token = "0x40026B4")]
    [FieldOffset(Offset = "0x64")]
    public int mdg;
    [Token(Token = "0x40026B5")]
    [FieldOffset(Offset = "0x68")]
    public int jwm;

    [Token(Token = "0x600372E")]
    [Address(RVA = "0x10A25A0", Offset = "0x10A13A0", VA = "0x110A25A0")]
    public MultiPlayResumeBuff()
    {
    }

    [Token(Token = "0x2000D92")]
    [MessagePackObject(true)]
    [Serializable]
    public class ResistStatus
    {
      [Token(Token = "0x40026B6")]
      [FieldOffset(Offset = "0x8")]
      public int rst;
      [Token(Token = "0x40026B7")]
      [FieldOffset(Offset = "0xC")]
      public int rsv;

      [Token(Token = "0x600372F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResistStatus()
      {
      }
    }
  }
}
