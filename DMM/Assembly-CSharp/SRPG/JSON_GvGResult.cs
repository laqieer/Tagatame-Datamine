// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025AA")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGResult
  {
    [Token(Token = "0x400AEE1")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x400AEE2")]
    [FieldOffset(Offset = "0xC")]
    public int point;
    [Token(Token = "0x400AEE3")]
    [FieldOffset(Offset = "0x10")]
    public int[] capture_nodes;

    [Token(Token = "0x600A753")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGResult()
    {
    }
  }
}
