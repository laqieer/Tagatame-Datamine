// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalCalc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002281")]
  public static class CrystalCalc
  {
    [Token(Token = "0x600936E")]
    [Address(RVA = "0x565830", Offset = "0x564630", VA = "0x10565830")]
    private static bool SkipLimitParamter(ParamTypes type) => new bool();

    [Token(Token = "0x600936F")]
    [Address(RVA = "0x564830", Offset = "0x563630", VA = "0x10564830")]
    private static void ConvertStatusLimit(UnitData _unit_data, ref BaseStatus _status)
    {
    }

    [Token(Token = "0x6009370")]
    [Address(RVA = "0x565510", Offset = "0x564310", VA = "0x10565510")]
    public static void GetStatus(
      UnitData _unit_data,
      List<CrystalData> _list,
      ref BaseStatus _status,
      bool _isLimit = true)
    {
    }

    [Token(Token = "0x6009371")]
    [Address(RVA = "0x564E10", Offset = "0x563C10", VA = "0x10564E10")]
    public static void GetEquipStatus(
      UnitData _unit_data,
      CrystalData _crystal_data,
      ref BaseStatus _status)
    {
    }

    [Token(Token = "0x6009372")]
    [Address(RVA = "0x564FF0", Offset = "0x563DF0", VA = "0x10564FF0")]
    public static void GetSetBonusStatus(
      List<CrystalData> _list,
      EElement element,
      ref BaseStatus _status)
    {
    }

    [Token(Token = "0x6009373")]
    [Address(RVA = "0x5656C0", Offset = "0x5644C0", VA = "0x105656C0")]
    public static int GetTargetStatus(
      BaseStatus _status,
      ParamTypes _target_param,
      string _tag_name)
    {
      return new int();
    }

    [Token(Token = "0x6009374")]
    [Address(RVA = "0x564B20", Offset = "0x563920", VA = "0x10564B20")]
    public static int GetAllSumStatus(BaseStatus _status) => new int();
  }
}
