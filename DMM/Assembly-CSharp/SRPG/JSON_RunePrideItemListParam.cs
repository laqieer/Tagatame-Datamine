// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePrideItemListParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CF8")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePrideItemListParam
  {
    [Token(Token = "0x4007182")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007183")]
    [FieldOffset(Offset = "0xC")]
    public int is_none;
    [Token(Token = "0x4007184")]
    [FieldOffset(Offset = "0x10")]
    public int need_piece;
    [Token(Token = "0x4007185")]
    [FieldOffset(Offset = "0x14")]
    public int is_sub_piece;
    [Token(Token = "0x4007186")]
    [FieldOffset(Offset = "0x18")]
    public int is_element_piece;
    [Token(Token = "0x4007187")]
    [FieldOffset(Offset = "0x1C")]
    public string[] sub_piece_inames;
    [Token(Token = "0x4007188")]
    [FieldOffset(Offset = "0x20")]
    public JSON_RunePrideItemData[] items;

    [Token(Token = "0x60076F2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePrideItemListParam()
    {
    }
  }
}
