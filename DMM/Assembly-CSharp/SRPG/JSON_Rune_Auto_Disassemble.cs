// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_Rune_Auto_Disassemble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011BF")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_Rune_Auto_Disassemble
  {
    [Token(Token = "0x400407C")]
    [FieldOffset(Offset = "0x8")]
    public int is_auto_disassemble;
    [Token(Token = "0x400407D")]
    [FieldOffset(Offset = "0xC")]
    public JSON_Rune_Auto_Option[] option;

    [Token(Token = "0x6004B39")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_Rune_Auto_Disassemble()
    {
    }
  }
}
