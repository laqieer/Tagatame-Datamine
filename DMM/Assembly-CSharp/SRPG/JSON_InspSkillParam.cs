// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_InspSkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B9F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_InspSkillParam
  {
    [Token(Token = "0x4006953")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006954")]
    [FieldOffset(Offset = "0xC")]
    public string ability;
    [Token(Token = "0x4006955")]
    [FieldOffset(Offset = "0x10")]
    public int gen_id;
    [Token(Token = "0x4006956")]
    [FieldOffset(Offset = "0x14")]
    public string[] triggers;
    [Token(Token = "0x4006957")]
    [FieldOffset(Offset = "0x18")]
    public JSON_InspSkillDerivation[] derivation;
    [Token(Token = "0x4006958")]
    [FieldOffset(Offset = "0x1C")]
    public int ctr_min;
    [Token(Token = "0x4006959")]
    [FieldOffset(Offset = "0x20")]
    public int ctr_max;
    [Token(Token = "0x400695A")]
    [FieldOffset(Offset = "0x24")]
    public int enable_passive;

    [Token(Token = "0x600721C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_InspSkillParam()
    {
    }
  }
}
