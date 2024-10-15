// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SortArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D47")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SortArtifactParam
  {
    [Token(Token = "0x4007318")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007319")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x400731A")]
    [FieldOffset(Offset = "0x10")]
    public string item_name;
    [Token(Token = "0x400731B")]
    [FieldOffset(Offset = "0x14")]
    public string sub_item_name;
    [Token(Token = "0x400731C")]
    [FieldOffset(Offset = "0x18")]
    public JSON_SortArtifactCondParam[] cnds;

    [Token(Token = "0x60077F3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SortArtifactParam()
    {
    }
  }
}
