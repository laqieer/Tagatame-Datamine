// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TruthEquipmentRecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DB4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TruthEquipmentRecipeParam
  {
    [Token(Token = "0x4007650")]
    [FieldOffset(Offset = "0x8")]
    public string recipe_iname;
    [Token(Token = "0x4007651")]
    [FieldOffset(Offset = "0xC")]
    public int cost;
    [Token(Token = "0x4007652")]
    [FieldOffset(Offset = "0x10")]
    public JSON_TruthEquipmentRecipeMaterialParam[] mats;

    [Token(Token = "0x6007997")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TruthEquipmentRecipeParam()
    {
    }
  }
}
