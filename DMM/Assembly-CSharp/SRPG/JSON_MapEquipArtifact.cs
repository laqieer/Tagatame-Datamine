// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapEquipArtifact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C15")]
  [Serializable]
  public class JSON_MapEquipArtifact
  {
    [Token(Token = "0x4001F58")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4001F59")]
    [FieldOffset(Offset = "0xC")]
    public int level;
    [Token(Token = "0x4001F5A")]
    [FieldOffset(Offset = "0x10")]
    public int rare;
    [Token(Token = "0x4001F5B")]
    [FieldOffset(Offset = "0x14")]
    public JSON_MapEquipAbility[] abils;

    [Token(Token = "0x6003026")]
    [Address(RVA = "0xFE49B0", Offset = "0xFE37B0", VA = "0x10FE49B0")]
    public JSON_MapEquipArtifact()
    {
    }
  }
}
