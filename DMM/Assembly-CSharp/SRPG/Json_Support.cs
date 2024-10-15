// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Support
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001019")]
  [Serializable]
  public class Json_Support
  {
    [Token(Token = "0x4003948")]
    [FieldOffset(Offset = "0x8")]
    public string fuid;
    [Token(Token = "0x4003949")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400394A")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x400394B")]
    [FieldOffset(Offset = "0x14")]
    public int cost;
    [Token(Token = "0x400394C")]
    [FieldOffset(Offset = "0x18")]
    public Json_Unit unit;
    [Token(Token = "0x400394D")]
    [FieldOffset(Offset = "0x1C")]
    public int isFriend;
    [Token(Token = "0x400394E")]
    [FieldOffset(Offset = "0x20")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x600427D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Support()
    {
    }
  }
}
