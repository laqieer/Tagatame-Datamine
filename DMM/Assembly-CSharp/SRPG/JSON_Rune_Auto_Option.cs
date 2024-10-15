// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_Rune_Auto_Option
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011C0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_Rune_Auto_Option
  {
    [Token(Token = "0x400407E")]
    [FieldOffset(Offset = "0x8")]
    public int rare;
    [Token(Token = "0x400407F")]
    [FieldOffset(Offset = "0xC")]
    public int[] seteff_type;
    [Token(Token = "0x4004080")]
    [FieldOffset(Offset = "0x10")]
    public JSON_Rune_Auto_Base_Status[] base_status;

    [Token(Token = "0x6004B3A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_Rune_Auto_Option()
    {
    }
  }
}
