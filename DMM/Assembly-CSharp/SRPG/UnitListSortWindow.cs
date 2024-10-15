// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListSortWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C9F")]
  public class UnitListSortWindow : FlowWindowBase
  {
    [Token(Token = "0x400DD02")]
    private const string SAVEKEY = "UNITLIST_SORT";
    [Token(Token = "0x400DD03")]
    private const string SAVEKEY_GUILDTRAINING = "UNITLIST_SORT_GUILD_TRAINING";
    [Token(Token = "0x400DD04")]
    private const string SAVEKEY_OLD = "UNITLIST";
    [Token(Token = "0x400DD05")]
    public const UnitListSortWindow.SelectType MASK_SECTION = (UnitListSortWindow.SelectType) 16777215;
    [Token(Token = "0x400DD06")]
    public const UnitListSortWindow.SelectType MASK_ALIGNMENT = (UnitListSortWindow.SelectType) 251658240;
    [Token(Token = "0x400DD07")]
    [FieldOffset(Offset = "0x30")]
    private UnitListSortWindow.SerializeParam m_Param;
    [Token(Token = "0x400DD08")]
    [FieldOffset(Offset = "0x34")]
    private SerializeValueList m_ValueList;
    [Token(Token = "0x400DD09")]
    [FieldOffset(Offset = "0x38")]
    private UnitListWindow m_Root;
    [Token(Token = "0x400DD0A")]
    [FieldOffset(Offset = "0x3C")]
    private UnitListSortWindow.Result m_Result;
    [Token(Token = "0x400DD0B")]
    [FieldOffset(Offset = "0x40")]
    private UnitListSortWindow.SelectType m_SelectTypeReg;
    [Token(Token = "0x400DD0C")]
    [FieldOffset(Offset = "0x44")]
    private UnitListSortWindow.SelectType m_SelectType;
    [Token(Token = "0x400DD0D")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<UnitListSortWindow.SelectType, Toggle> m_Toggles;

    [Token(Token = "0x17001B3B")]
    public override string name
    {
      [Token(Token = "0x600CF03"), Address(RVA = "0x9A6D50", Offset = "0x9A5B50", VA = "0x109A6D50", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CF04")]
    [Address(RVA = "0x9A6190", Offset = "0x9A4F90", VA = "0x109A6190", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x600CF05")]
    [Address(RVA = "0x9A54E0", Offset = "0x9A42E0", VA = "0x109A54E0")]
    private void CreateInstance()
    {
    }

    [Token(Token = "0x600CF06")]
    [Address(RVA = "0x9A4B80", Offset = "0x9A3980", VA = "0x109A4B80")]
    private void CacheToggleParam(GameObject toggle_parent_obj)
    {
    }

    [Token(Token = "0x600CF07")]
    [Address(RVA = "0x993820", Offset = "0x992620", VA = "0x10993820", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x600CF08")]
    [Address(RVA = "0x9A6C90", Offset = "0x9A5A90", VA = "0x109A6C90", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x600CF09")]
    [Address(RVA = "0x9A6010", Offset = "0x9A4E10", VA = "0x109A6010")]
    private void InitializeToggleContent()
    {
    }

    [Token(Token = "0x600CF0A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void ReleaseToggleContent()
    {
    }

    [Token(Token = "0x600CF0B")]
    [Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")]
    public void SetRoot(UnitListWindow root)
    {
    }

    [Token(Token = "0x600CF0C")]
    [Address(RVA = "0x9A6C70", Offset = "0x9A5A70", VA = "0x109A6C70")]
    private void SetSection(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x600CF0D")]
    [Address(RVA = "0x9A6B40", Offset = "0x9A5940", VA = "0x109A6B40")]
    private void ResetSection(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x600CF0E")]
    [Address(RVA = "0x9A5850", Offset = "0x9A4650", VA = "0x109A5850")]
    public UnitListSortWindow.SelectType GetSection() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x600CF0F")]
    [Address(RVA = "0x9A5840", Offset = "0x9A4640", VA = "0x109A5840")]
    public UnitListSortWindow.SelectType GetSectionReg() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x600CF10")]
    [Address(RVA = "0x9A6C50", Offset = "0x9A5A50", VA = "0x109A6C50")]
    private void SetAlignment(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x600CF11")]
    [Address(RVA = "0x9A6B20", Offset = "0x9A5920", VA = "0x109A6B20")]
    private void ResetAlignment(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x600CF12")]
    [Address(RVA = "0x9A56D0", Offset = "0x9A44D0", VA = "0x109A56D0")]
    public UnitListSortWindow.SelectType GetAlignment() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x600CF13")]
    [Address(RVA = "0x9A5070", Offset = "0x9A3E70", VA = "0x109A5070")]
    public void CalcUnit(List<UnitListWindow.Data> list)
    {
    }

    [Token(Token = "0x600CF14")]
    [Address(RVA = "0x9A63E0", Offset = "0x9A51E0", VA = "0x109A63E0")]
    public bool IsType(UnitListSortWindow.SelectType value) => new bool();

    [Token(Token = "0x600CF15")]
    [Address(RVA = "0x9A6400", Offset = "0x9A5200", VA = "0x109A6400")]
    public void LoadSelectType()
    {
    }

    [Token(Token = "0x600CF16")]
    [Address(RVA = "0x9A6B60", Offset = "0x9A5960", VA = "0x109A6B60")]
    public void SaveSelectType()
    {
    }

    [Token(Token = "0x600CF17")]
    [Address(RVA = "0x9A6910", Offset = "0x9A5710", VA = "0x109A6910", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x600CF18")]
    [Address(RVA = "0x9A5BC0", Offset = "0x9A49C0", VA = "0x109A5BC0")]
    public static long GetSortPriority(
      int main,
      int pri1,
      int pri2,
      int pri3,
      int pri4,
      int pri5)
    {
      return new long();
    }

    [Token(Token = "0x600CF19")]
    [Address(RVA = "0x9A5860", Offset = "0x9A4660", VA = "0x109A5860")]
    public static long GetSortPriority(
      UnitListWindow.Data data,
      UnitListSortWindow.SelectType type,
      UnitListSortWindow.SelectType alignment)
    {
      return new long();
    }

    [Token(Token = "0x600CF1A")]
    [Address(RVA = "0x9A5C10", Offset = "0x9A4A10", VA = "0x109A5C10")]
    public static int GetSortStatus(
      UnitListWindow.Data data,
      UnitListSortWindow.SelectType type,
      UnitListSortWindow.SelectType alignment)
    {
      return new int();
    }

    [Token(Token = "0x600CF1B")]
    [Address(RVA = "0x9A5400", Offset = "0x9A4200", VA = "0x109A5400")]
    public static UnitListSortWindow.SelectType ConvertSortMode(GameUtility.UnitSortModes oldMode)
    {
      return new UnitListSortWindow.SelectType();
    }

    [Token(Token = "0x600CF1C")]
    [Address(RVA = "0x9A52B0", Offset = "0x9A40B0", VA = "0x109A52B0")]
    public static UnitListSortWindow.SelectType ConvertReverse(bool isReverse)
    {
      return new UnitListSortWindow.SelectType();
    }

    [Token(Token = "0x600CF1D")]
    [Address(RVA = "0x9A52D0", Offset = "0x9A40D0", VA = "0x109A52D0")]
    public static GameUtility.UnitSortModes ConvertSelectType(
      UnitListSortWindow.SelectType selectType)
    {
      return new GameUtility.UnitSortModes();
    }

    [Token(Token = "0x600CF1E")]
    [Address(RVA = "0x9A56E0", Offset = "0x9A44E0", VA = "0x109A56E0")]
    public static Sprite GetIcon(UnitListSortWindow.SelectType selectType) => (Sprite) null;

    [Token(Token = "0x600CF1F")]
    [Address(RVA = "0x9A5F80", Offset = "0x9A4D80", VA = "0x109A5F80")]
    public static string GetText(UnitListSortWindow.SelectType selectType) => (string) null;

    [Token(Token = "0x600CF20")]
    [Address(RVA = "0x9A6CE0", Offset = "0x9A5AE0", VA = "0x109A6CE0")]
    public UnitListSortWindow()
    {
    }

    [Token(Token = "0x2002CA0")]
    public enum Result
    {
      [Token(Token = "0x400DD0F")] NONE,
      [Token(Token = "0x400DD10")] CONFIRM,
      [Token(Token = "0x400DD11")] CANCEL,
    }

    [Token(Token = "0x2002CA1")]
    public enum SelectType
    {
      [Token(Token = "0x400DD13")] NONE = 0,
      [Token(Token = "0x400DD14")] TIME = 1,
      [Token(Token = "0x400DD15")] RARITY = 2,
      [Token(Token = "0x400DD16")] LEVEL = 4,
      [Token(Token = "0x400DD17")] TOTAL = 8,
      [Token(Token = "0x400DD18")] ATK = 16, // 0x00000010
      [Token(Token = "0x400DD19")] DEF = 32, // 0x00000020
      [Token(Token = "0x400DD1A")] MAG = 64, // 0x00000040
      [Token(Token = "0x400DD1B")] MND = 128, // 0x00000080
      [Token(Token = "0x400DD1C")] HP = 256, // 0x00000100
      [Token(Token = "0x400DD1D")] SPD = 512, // 0x00000200
      [Token(Token = "0x400DD1E")] COMBINATION = 1024, // 0x00000400
      [Token(Token = "0x400DD1F")] JOBRANK = 2048, // 0x00000800
      [Token(Token = "0x400DD20")] AWAKE = 4096, // 0x00001000
      [Token(Token = "0x400DD21")] NAME = 8192, // 0x00002000
      [Token(Token = "0x400DD22")] DEX = 16384, // 0x00004000
      [Token(Token = "0x400DD23")] CRI = 32768, // 0x00008000
      [Token(Token = "0x400DD24")] LUK = 65536, // 0x00010000
      [Token(Token = "0x400DD25")] PIECE = 131072, // 0x00020000
      [Token(Token = "0x400DD26")] TOBIRA = 262144, // 0x00040000
      [Token(Token = "0x400DD27")] STATUS_AWAKE = 524288, // 0x00080000
      [Token(Token = "0x400DD28")] SYOJYUN = 16777216, // 0x01000000
      [Token(Token = "0x400DD29")] KOUJYUN = 33554432, // 0x02000000
    }

    [Token(Token = "0x2002CA2")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x17001B3C")]
      public override System.Type type
      {
        [Token(Token = "0x600CF21"), Address(RVA = "0x9A1410", Offset = "0x9A0210", VA = "0x109A1410", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x600CF22")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
