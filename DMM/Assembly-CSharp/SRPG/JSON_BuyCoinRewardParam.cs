// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BuyCoinRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A3D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BuyCoinRewardParam
  {
    [Token(Token = "0x400609B")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x400609C")]
    [FieldOffset(Offset = "0xC")]
    public int draw_type;
    [Token(Token = "0x400609D")]
    [FieldOffset(Offset = "0x10")]
    public string draw_iname;
    [Token(Token = "0x400609E")]
    [FieldOffset(Offset = "0x14")]
    public string gift_message;
    [Token(Token = "0x400609F")]
    [FieldOffset(Offset = "0x18")]
    public JSON_BuyCoinRewardItemParam[] rewards;

    [Token(Token = "0x6006BE5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BuyCoinRewardParam()
    {
    }
  }
}
