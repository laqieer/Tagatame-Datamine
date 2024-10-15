// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapEquipDtu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C1B")]
  [Serializable]
  public class JSON_MapEquipDtu
  {
    [Token(Token = "0x4001F68")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001F69")]
    [FieldOffset(Offset = "0xC")]
    public JSON_MapEquipAbility[] abils;
    [Token(Token = "0x4001F6A")]
    [FieldOffset(Offset = "0x10")]
    public JSON_AIActionTable acttbl;

    [Token(Token = "0x600302C")]
    [Address(RVA = "0xFE4A50", Offset = "0xFE3850", VA = "0x10FE4A50")]
    public JSON_MapEquipDtu()
    {
    }
  }
}
