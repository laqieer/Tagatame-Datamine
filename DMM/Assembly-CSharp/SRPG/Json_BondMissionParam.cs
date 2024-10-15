// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BondMissionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019B2")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BondMissionParam
  {
    [Token(Token = "0x4005E68")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005E69")]
    [FieldOffset(Offset = "0xC")]
    public string condition_str;
    [Token(Token = "0x4005E6A")]
    [FieldOffset(Offset = "0x10")]
    public int condition_num;
    [Token(Token = "0x4005E6B")]
    [FieldOffset(Offset = "0x14")]
    public string explanation;
    [Token(Token = "0x4005E6C")]
    [FieldOffset(Offset = "0x18")]
    public Json_BondMissionRewardParam[] rewards;

    [Token(Token = "0x60068D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BondMissionParam()
    {
    }
  }
}
