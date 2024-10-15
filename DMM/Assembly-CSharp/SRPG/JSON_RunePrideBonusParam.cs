// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePrideBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CF1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePrideBonusParam
  {
    [Token(Token = "0x4007165")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007166")]
    [FieldOffset(Offset = "0xC")]
    public string unit_group;
    [Token(Token = "0x4007167")]
    [FieldOffset(Offset = "0x10")]
    public int star_num;
    [Token(Token = "0x4007168")]
    [FieldOffset(Offset = "0x14")]
    public string bonus_id;
    [Token(Token = "0x4007169")]
    [FieldOffset(Offset = "0x18")]
    public string potential_id;

    [Token(Token = "0x60076D9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePrideBonusParam()
    {
    }
  }
}
