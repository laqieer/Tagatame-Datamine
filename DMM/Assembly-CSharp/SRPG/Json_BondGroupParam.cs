// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BondGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019AD")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BondGroupParam
  {
    [Token(Token = "0x4005E51")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005E52")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4005E53")]
    [FieldOffset(Offset = "0x10")]
    public string group_name;
    [Token(Token = "0x4005E54")]
    [FieldOffset(Offset = "0x14")]
    public string banner_image;
    [Token(Token = "0x4005E55")]
    [FieldOffset(Offset = "0x18")]
    public string bg_image;
    [Token(Token = "0x4005E56")]
    [FieldOffset(Offset = "0x1C")]
    public string begin_at;
    [Token(Token = "0x4005E57")]
    [FieldOffset(Offset = "0x20")]
    public string end_at;
    [Token(Token = "0x4005E58")]
    [FieldOffset(Offset = "0x24")]
    public string modified_at;

    [Token(Token = "0x60068B5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BondGroupParam()
    {
    }
  }
}
