// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CE0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneCost
  {
    [Token(Token = "0x4007131")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007132")]
    [FieldOffset(Offset = "0xC")]
    public string use_item;
    [Token(Token = "0x4007133")]
    [FieldOffset(Offset = "0x10")]
    public int use_item_num;
    [Token(Token = "0x4007134")]
    [FieldOffset(Offset = "0x14")]
    public int use_gold;
    [Token(Token = "0x4007135")]
    [FieldOffset(Offset = "0x18")]
    public int use_coin;

    [Token(Token = "0x60076A8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneCost()
    {
    }
  }
}
