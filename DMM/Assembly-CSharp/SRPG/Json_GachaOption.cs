// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AF8")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_GachaOption
  {
    [Token(Token = "0x40066A9")]
    [FieldOffset(Offset = "0x8")]
    public int is_skip_animation;
    [Token(Token = "0x40066AA")]
    [FieldOffset(Offset = "0xC")]
    public int auto_disassembly_rare2;
    [Token(Token = "0x40066AB")]
    [FieldOffset(Offset = "0x10")]
    public int auto_disassembly_rare3;

    [Token(Token = "0x6006F4C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GachaOption()
    {
    }
  }
}
