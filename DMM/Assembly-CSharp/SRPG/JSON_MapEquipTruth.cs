// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapEquipTruth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C18")]
  [Serializable]
  public class JSON_MapEquipTruth
  {
    [Token(Token = "0x4001F64")]
    [FieldOffset(Offset = "0x8")]
    public int level;
    [Token(Token = "0x4001F65")]
    [FieldOffset(Offset = "0xC")]
    public JSON_MapEquipAbility[] abils;

    [Token(Token = "0x6003029")]
    [Address(RVA = "0xFE4AA0", Offset = "0xFE38A0", VA = "0x10FE4AA0")]
    public JSON_MapEquipTruth()
    {
    }
  }
}
