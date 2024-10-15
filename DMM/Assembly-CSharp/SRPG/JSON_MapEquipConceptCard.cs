// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapEquipConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C16")]
  [Serializable]
  public class JSON_MapEquipConceptCard
  {
    [Token(Token = "0x4001F5C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001F5D")]
    [FieldOffset(Offset = "0xC")]
    public int level;
    [Token(Token = "0x4001F5E")]
    [FieldOffset(Offset = "0x10")]
    public int plus;
    [Token(Token = "0x4001F5F")]
    [FieldOffset(Offset = "0x14")]
    public int extra;
    [Token(Token = "0x4001F60")]
    [FieldOffset(Offset = "0x18")]
    public int index;
    [Token(Token = "0x4001F61")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_MapEquipAbility[] abils;

    [Token(Token = "0x6003027")]
    [Address(RVA = "0xFE4A00", Offset = "0xFE3800", VA = "0x10FE4A00")]
    public JSON_MapEquipConceptCard()
    {
    }
  }
}
