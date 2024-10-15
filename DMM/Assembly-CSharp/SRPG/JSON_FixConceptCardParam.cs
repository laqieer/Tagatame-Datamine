// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FixConceptCardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A68")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FixConceptCardParam
  {
    [Token(Token = "0x400616A")]
    [FieldOffset(Offset = "0x8")]
    public int extra_rarity_need_point;
    [Token(Token = "0x400616B")]
    [FieldOffset(Offset = "0xC")]
    public int extra_rarity_cost;
    [Token(Token = "0x400616C")]
    [FieldOffset(Offset = "0x10")]
    public int common_extra_rarity_pt;
    [Token(Token = "0x400616D")]
    [FieldOffset(Offset = "0x14")]
    public int[] slot2_dec_rate_extra;

    [Token(Token = "0x6006C8D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FixConceptCardParam()
    {
    }
  }
}
