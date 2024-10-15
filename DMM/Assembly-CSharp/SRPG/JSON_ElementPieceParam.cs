// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ElementPieceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC8")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ElementPieceParam
  {
    [Token(Token = "0x4006340")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006341")]
    [FieldOffset(Offset = "0xC")]
    public int element;
    [Token(Token = "0x4006342")]
    [FieldOffset(Offset = "0x10")]
    public int ele_plus;
    [Token(Token = "0x4006343")]
    [FieldOffset(Offset = "0x14")]
    public string cmn_piece;
    [Token(Token = "0x4006344")]
    [FieldOffset(Offset = "0x18")]
    public string ele_piece;

    [Token(Token = "0x6006E67")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ElementPieceParam()
    {
    }
  }
}
