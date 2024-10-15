// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentRecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DB6")]
  [MessagePackObject(true)]
  [Serializable]
  public class TruthEquipmentRecipeParam
  {
    [Token(Token = "0x1700106A")]
    public string RecipeIname
    {
      [Token(Token = "0x600799E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600799F"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700106B")]
    public int Cost
    {
      [Token(Token = "0x60079A0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60079A1"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700106C")]
    public TruthEquipmentRecipeMaterialParam[] Materials
    {
      [Token(Token = "0x60079A2"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (TruthEquipmentRecipeMaterialParam[]) null;
      }
      [Token(Token = "0x60079A3"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x60079A4")]
    [Address(RVA = "0x3C1AF0", Offset = "0x3C08F0", VA = "0x103C1AF0")]
    public void Deserialize(JSON_TruthEquipmentRecipeParam json)
    {
    }

    [Token(Token = "0x60079A5")]
    [Address(RVA = "0x3C1C70", Offset = "0x3C0A70", VA = "0x103C1C70")]
    public static void Deserialize(
      ref ParamDictionary<string, TruthEquipmentRecipeParam> dict,
      JSON_TruthEquipmentRecipeParam[] json)
    {
    }

    [Token(Token = "0x60079A6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentRecipeParam()
    {
    }
  }
}
