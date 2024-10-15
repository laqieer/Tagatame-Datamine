// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AutoRuneDisassemblyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CC7")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AutoRuneDisassemblyParam
  {
    [Token(Token = "0x40070DB")]
    [FieldOffset(Offset = "0x8")]
    public int rarity;
    [Token(Token = "0x40070DC")]
    [FieldOffset(Offset = "0xC")]
    public string rarity_name;
    [Token(Token = "0x40070DD")]
    [FieldOffset(Offset = "0x10")]
    public string set_eff;
    [Token(Token = "0x40070DE")]
    [FieldOffset(Offset = "0x14")]
    public string rune_type;

    [Token(Token = "0x6007663")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AutoRuneDisassemblyParam()
    {
    }
  }
}
