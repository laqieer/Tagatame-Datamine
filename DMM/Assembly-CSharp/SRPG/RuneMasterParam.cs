// Decompiled with JetBrains decompiler
// Type: SRPG.RuneMasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CD1")]
  internal class RuneMasterParam
  {
    [Token(Token = "0x6007683")]
    [Address(RVA = "0x3999B0", Offset = "0x3987B0", VA = "0x103999B0")]
    public static bool Deserialize(
      JSON_RuneParam[] json,
      ref List<RuneParam> mRuneParam,
      ref Dictionary<string, RuneParam> mRuneParamDict)
    {
      return new bool();
    }

    [Token(Token = "0x6007684")]
    [Address(RVA = "0x399BB0", Offset = "0x3989B0", VA = "0x10399BB0")]
    public static bool Deserialize(
      JSON_RuneLotteryBaseState[] json,
      ref List<RuneLotteryBaseState> mRuneLotteryBaseState)
    {
      return new bool();
    }

    [Token(Token = "0x6007685")]
    [Address(RVA = "0x39A390", Offset = "0x399190", VA = "0x1039A390")]
    public static bool Deserialize(
      JSON_RuneLotteryEvoState[] json,
      ref List<RuneLotteryEvoState> mRuneLotteryEvoState)
    {
      return new bool();
    }

    [Token(Token = "0x6007686")]
    [Address(RVA = "0x39A4A0", Offset = "0x3992A0", VA = "0x1039A4A0")]
    public static bool Deserialize(
      JSON_RuneMaterial[] json,
      ref List<RuneMaterial> mRuneMaterial,
      MasterParam master)
    {
      return new bool();
    }

    [Token(Token = "0x6007687")]
    [Address(RVA = "0x399D90", Offset = "0x398B90", VA = "0x10399D90")]
    public static bool Deserialize(JSON_RuneCost[] json, ref List<RuneCost> mRuneCost)
    {
      return new bool();
    }

    [Token(Token = "0x6007688")]
    [Address(RVA = "0x399ED0", Offset = "0x398CD0", VA = "0x10399ED0")]
    public static bool Deserialize(JSON_RuneSetEff[] json, ref List<RuneSetEff> mRuneSetEff)
    {
      return new bool();
    }

    [Token(Token = "0x6007689")]
    [Address(RVA = "0x399750", Offset = "0x398550", VA = "0x10399750")]
    public static bool Deserialize(
      JSON_RuneLotteryEvoStatePack[] json,
      ref List<RuneLotteryEvoStatePack> mRuneLotteryEvoSlots)
    {
      return new bool();
    }

    [Token(Token = "0x600768A")]
    [Address(RVA = "0x399880", Offset = "0x398680", VA = "0x10399880")]
    public static bool Deserialize(
      JSON_RuneLotteryBaseStatePack[] json,
      ref List<RuneLotteryBaseStatePack> mRuneLotteryBaseSlots)
    {
      return new bool();
    }

    [Token(Token = "0x600768B")]
    [Address(RVA = "0x39A160", Offset = "0x398F60", VA = "0x1039A160")]
    public static bool Deserialize(
      JSON_RuneDedicatedCost[] json,
      ref List<RuneDedicatedCostParam> mRuneDedicatedCosts)
    {
      return new bool();
    }

    [Token(Token = "0x600768C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneMasterParam()
    {
    }
  }
}
