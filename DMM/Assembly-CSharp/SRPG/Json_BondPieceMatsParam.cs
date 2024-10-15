// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BondPieceMatsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019B7")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BondPieceMatsParam
  {
    [Token(Token = "0x4005E7A")]
    [FieldOffset(Offset = "0x8")]
    public string unit_iname;
    [Token(Token = "0x4005E7B")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4005E7C")]
    [FieldOffset(Offset = "0x10")]
    public string sub_materials_iname;

    [Token(Token = "0x60068F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BondPieceMatsParam()
    {
    }
  }
}
