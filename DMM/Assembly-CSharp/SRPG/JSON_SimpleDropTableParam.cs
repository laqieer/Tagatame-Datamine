// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SimpleDropTableParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D1D")]
  [Serializable]
  public class JSON_SimpleDropTableParam
  {
    [Token(Token = "0x4007232")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007233")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x4007234")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x4007235")]
    [FieldOffset(Offset = "0x14")]
    public string[] droplist;
    [Token(Token = "0x4007236")]
    [FieldOffset(Offset = "0x18")]
    public string[] dropcards;

    [Token(Token = "0x600777A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SimpleDropTableParam()
    {
    }
  }
}
