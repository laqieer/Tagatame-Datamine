// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGScoreRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025AB")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGScoreRanking
  {
    [Token(Token = "0x400AEE4")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x400AEE5")]
    [FieldOffset(Offset = "0xC")]
    public int score;
    [Token(Token = "0x400AEE6")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x400AEE7")]
    [FieldOffset(Offset = "0x14")]
    public int level;
    [Token(Token = "0x400AEE8")]
    [FieldOffset(Offset = "0x18")]
    public string unit;
    [Token(Token = "0x400AEE9")]
    [FieldOffset(Offset = "0x1C")]
    public string skin;
    [Token(Token = "0x400AEEA")]
    [FieldOffset(Offset = "0x20")]
    public int role;
    [Token(Token = "0x400AEEB")]
    [FieldOffset(Offset = "0x24")]
    public int gid;

    [Token(Token = "0x600A754")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGScoreRanking()
    {
    }
  }
}
