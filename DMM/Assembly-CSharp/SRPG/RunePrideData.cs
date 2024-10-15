// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011D0")]
  [MessagePackObject(true)]
  public class RunePrideData
  {
    [Token(Token = "0x40040B9")]
    [FieldOffset(Offset = "0x8")]
    private List<RunePrideReleasePanel> panels;
    [Token(Token = "0x40040BA")]
    [FieldOffset(Offset = "0xC")]
    private List<RunePrideReleasePotential> potentials;

    [Token(Token = "0x1700084F")]
    public List<RunePrideReleasePanel> Panels
    {
      [Token(Token = "0x6004B53"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<RunePrideReleasePanel>) null;
      }
    }

    [Token(Token = "0x17000850")]
    public List<RunePrideReleasePotential> Potentials
    {
      [Token(Token = "0x6004B54"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RunePrideReleasePotential>) null;
      }
    }

    [Token(Token = "0x6004B55")]
    [Address(RVA = "0x1202B90", Offset = "0x1201990", VA = "0x11202B90")]
    public JSON_RunePride Serialize() => (JSON_RunePride) null;

    [Token(Token = "0x6004B56")]
    [Address(RVA = "0x1200F30", Offset = "0x11FFD30", VA = "0x11200F30")]
    public void Deserialize(JSON_RunePride json)
    {
    }

    [Token(Token = "0x6004B57")]
    [Address(RVA = "0x1200AD0", Offset = "0x11FF8D0", VA = "0x11200AD0")]
    private void DeserializePanels(JSON_RunePrideReleasePanel[] jsonPanels)
    {
    }

    [Token(Token = "0x6004B58")]
    [Address(RVA = "0x1200CE0", Offset = "0x11FFAE0", VA = "0x11200CE0")]
    private void DeserializePotentials(JSON_RunePrideReleasePotential[] jsonPotentials)
    {
    }

    [Token(Token = "0x6004B59")]
    [Address(RVA = "0x1200780", Offset = "0x11FF580", VA = "0x11200780")]
    public static List<BaseParameterData> CompileParameter(List<BaseParameterData> _list)
    {
      return (List<BaseParameterData>) null;
    }

    [Token(Token = "0x6004B5A")]
    [Address(RVA = "0x12016C0", Offset = "0x12004C0", VA = "0x112016C0")]
    public static List<BaseParameterData> GetUpParameterAll(UnitData unit)
    {
      return (List<BaseParameterData>) null;
    }

    [Token(Token = "0x6004B5B")]
    [Address(RVA = "0x1201DB0", Offset = "0x1200BB0", VA = "0x11201DB0")]
    public static void GetUpParameterByUnitData(
      UnitData unit,
      ref List<BaseParameterData> param_add,
      ref List<BaseParameterData> param_scale)
    {
    }

    [Token(Token = "0x6004B5C")]
    [Address(RVA = "0x1201820", Offset = "0x1200620", VA = "0x11201820")]
    public static List<BaseParameterData> GetUpParameterByPanel(
      List<RunePrideReleasePanel> releasePanels)
    {
      return (List<BaseParameterData>) null;
    }

    [Token(Token = "0x6004B5D")]
    [Address(RVA = "0x1201C50", Offset = "0x1200A50", VA = "0x11201C50")]
    public static void GetUpParameterByReleasePotential(
      List<RunePrideReleasePotential> potentials,
      ref List<BaseParameterData> param_add,
      ref List<BaseParameterData> param_scale)
    {
    }

    [Token(Token = "0x6004B5E")]
    [Address(RVA = "0x1201010", Offset = "0x11FFE10", VA = "0x11201010")]
    private static void GetBaseParamByCalcType(
      ref List<BaseParameterData> _parameterList,
      List<RunePridePotentialSlotData> _slotData,
      SkillParamCalcTypes _calcType)
    {
    }

    [Token(Token = "0x6004B5F")]
    [Address(RVA = "0x1201250", Offset = "0x1200050", VA = "0x11201250")]
    private static void GetSubParamByCalcType(
      ref List<BaseParameterData> _parameterList,
      List<RunePridePotentialSlotData> _slotData,
      SkillParamCalcTypes _calcType)
    {
    }

    [Token(Token = "0x6004B60")]
    [Address(RVA = "0x12021D0", Offset = "0x1200FD0", VA = "0x112021D0")]
    public static List<RunePridePotentialStatusLotteryData> MergeSameType(
      List<RunePridePotentialStatusLotteryData> lottery_list)
    {
      return (List<RunePridePotentialStatusLotteryData>) null;
    }

    [Token(Token = "0x6004B61")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideData()
    {
    }
  }
}
