// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusRankNPCPartyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C98")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusRankNPCPartyParam
  {
    [Token(Token = "0x4007052")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4007053")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007054")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x4007055")]
    [FieldOffset(Offset = "0x14")]
    public int rankmatch_class;
    [Token(Token = "0x4007056")]
    [FieldOffset(Offset = "0x18")]
    public int view_point;
    [Token(Token = "0x4007057")]
    [FieldOffset(Offset = "0x1C")]
    public int point_min;
    [Token(Token = "0x4007058")]
    [FieldOffset(Offset = "0x20")]
    public int point_max;
    [Token(Token = "0x4007059")]
    [FieldOffset(Offset = "0x24")]
    public int unit1_id;
    [Token(Token = "0x400705A")]
    [FieldOffset(Offset = "0x28")]
    public int unit2_id;
    [Token(Token = "0x400705B")]
    [FieldOffset(Offset = "0x2C")]
    public int unit3_id;
    [Token(Token = "0x400705C")]
    [FieldOffset(Offset = "0x30")]
    public int is_conceptcard_ls;
    [Token(Token = "0x400705D")]
    [FieldOffset(Offset = "0x34")]
    public string award_id;

    [Token(Token = "0x60075C7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusRankNPCPartyParam()
    {
    }
  }
}
