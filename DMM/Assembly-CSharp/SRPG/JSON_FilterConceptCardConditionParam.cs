// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FilterConceptCardConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D31")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FilterConceptCardConditionParam
  {
    [Token(Token = "0x4007290")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x4007291")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007292")]
    [FieldOffset(Offset = "0x10")]
    public int rarity;
    [Token(Token = "0x4007293")]
    [FieldOffset(Offset = "0x14")]
    public int birth;
    [Token(Token = "0x4007294")]
    [FieldOffset(Offset = "0x18")]
    public string card_group;
    [Token(Token = "0x4007295")]
    [FieldOffset(Offset = "0x1C")]
    public int extra_rarity;

    [Token(Token = "0x60077AB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FilterConceptCardConditionParam()
    {
    }
  }
}
