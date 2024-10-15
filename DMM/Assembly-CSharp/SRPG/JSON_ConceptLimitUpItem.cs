// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ConceptLimitUpItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A7D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ConceptLimitUpItem
  {
    [Token(Token = "0x40061FA")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40061FB")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x40061FC")]
    [FieldOffset(Offset = "0x10")]
    public int all;
    [Token(Token = "0x40061FD")]
    [FieldOffset(Offset = "0x14")]
    public string[] cc_groups;
    [Token(Token = "0x40061FE")]
    [FieldOffset(Offset = "0x18")]
    public string[] cards;
    [Token(Token = "0x40061FF")]
    [FieldOffset(Offset = "0x1C")]
    public string[] ignore;

    [Token(Token = "0x6006CDA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ConceptLimitUpItem()
    {
    }
  }
}
