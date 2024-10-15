// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalFilterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A86")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalFilterParam
  {
    [Token(Token = "0x400621A")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400621B")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x400621C")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x400621D")]
    [FieldOffset(Offset = "0x14")]
    public int category;
    [Token(Token = "0x400621E")]
    [FieldOffset(Offset = "0x18")]
    public JSON_CrystalFilterCondParam[] cnds;

    [Token(Token = "0x6006CF5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalFilterParam()
    {
    }
  }
}
