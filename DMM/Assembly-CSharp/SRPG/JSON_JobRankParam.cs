// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_JobRankParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E0B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_JobRankParam
  {
    [Token(Token = "0x40079B2")]
    [FieldOffset(Offset = "0x8")]
    public int chcost;
    [Token(Token = "0x40079B3")]
    [FieldOffset(Offset = "0xC")]
    public string chitm1;
    [Token(Token = "0x40079B4")]
    [FieldOffset(Offset = "0x10")]
    public string chitm2;
    [Token(Token = "0x40079B5")]
    [FieldOffset(Offset = "0x14")]
    public string chitm3;
    [Token(Token = "0x40079B6")]
    [FieldOffset(Offset = "0x18")]
    public int chnum1;
    [Token(Token = "0x40079B7")]
    [FieldOffset(Offset = "0x1C")]
    public int chnum2;
    [Token(Token = "0x40079B8")]
    [FieldOffset(Offset = "0x20")]
    public int chnum3;
    [Token(Token = "0x40079B9")]
    [FieldOffset(Offset = "0x24")]
    public int cost;
    [Token(Token = "0x40079BA")]
    [FieldOffset(Offset = "0x28")]
    public string eqid1;
    [Token(Token = "0x40079BB")]
    [FieldOffset(Offset = "0x2C")]
    public string eqid2;
    [Token(Token = "0x40079BC")]
    [FieldOffset(Offset = "0x30")]
    public string eqid3;
    [Token(Token = "0x40079BD")]
    [FieldOffset(Offset = "0x34")]
    public string eqid4;
    [Token(Token = "0x40079BE")]
    [FieldOffset(Offset = "0x38")]
    public string eqid5;
    [Token(Token = "0x40079BF")]
    [FieldOffset(Offset = "0x3C")]
    public string eqid6;
    [Token(Token = "0x40079C0")]
    [FieldOffset(Offset = "0x40")]
    public string learn1;
    [Token(Token = "0x40079C1")]
    [FieldOffset(Offset = "0x44")]
    public string learn2;
    [Token(Token = "0x40079C2")]
    [FieldOffset(Offset = "0x48")]
    public string learn3;

    [Token(Token = "0x6007B57")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_JobRankParam()
    {
    }
  }
}
