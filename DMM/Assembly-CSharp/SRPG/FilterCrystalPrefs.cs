// Decompiled with JetBrains decompiler
// Type: SRPG.FilterCrystalPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A8A")]
  public class FilterCrystalPrefs
  {
    [Token(Token = "0x4006231")]
    [FieldOffset(Offset = "0x0")]
    private static FilterCrystalPrefs cache;
    [Token(Token = "0x4006232")]
    [FieldOffset(Offset = "0x4")]
    private static bool is_use_cache;
    [Token(Token = "0x4006233")]
    [FieldOffset(Offset = "0x8")]
    private FilterUtility.FilterPrefs prefs_data;

    [Token(Token = "0x6006D15")]
    [Address(RVA = "0x358880", Offset = "0x357680", VA = "0x10358880")]
    public bool GetValue(string majorKey, string minorKey) => new bool();

    [Token(Token = "0x6006D16")]
    [Address(RVA = "0x358AF0", Offset = "0x3578F0", VA = "0x10358AF0")]
    public void SetValue(string majorKey, string minorKey, bool value)
    {
    }

    [Token(Token = "0x6006D17")]
    [Address(RVA = "0x358680", Offset = "0x357480", VA = "0x10358680")]
    public void AllOff(string majorKey)
    {
    }

    [Token(Token = "0x6006D18")]
    [Address(RVA = "0x358980", Offset = "0x357780", VA = "0x10358980")]
    public bool IsDisableFilterAll() => new bool();

    [Token(Token = "0x6006D19")]
    [Address(RVA = "0x3589B0", Offset = "0x3577B0", VA = "0x103589B0")]
    public bool IsDisableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x6006D1A")]
    [Address(RVA = "0x3589E0", Offset = "0x3577E0", VA = "0x103589E0")]
    public bool IsEnableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x6006D1B")]
    [Address(RVA = "0x3586B0", Offset = "0x3574B0", VA = "0x103586B0")]
    public List<bool> CreateFlagList() => (List<bool>) null;

    [Token(Token = "0x6006D1C")]
    [Address(RVA = "0x3588B0", Offset = "0x3576B0", VA = "0x103588B0")]
    public bool IsDiff(List<bool> target) => new bool();

    [Token(Token = "0x6006D1D")]
    [Address(RVA = "0x358A10", Offset = "0x357810", VA = "0x10358A10")]
    public static FilterCrystalPrefs Load() => (FilterCrystalPrefs) null;

    [Token(Token = "0x6006D1E")]
    [Address(RVA = "0x3587E0", Offset = "0x3575E0", VA = "0x103587E0")]
    public static FilterUtility.FilterPrefs GetFilterPrefs() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x6006D1F")]
    [Address(RVA = "0x358AA0", Offset = "0x3578A0", VA = "0x10358AA0")]
    public static void Save(FilterCrystalPrefs data, bool allOnIsAllOff)
    {
    }

    [Token(Token = "0x6006D20")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterCrystalPrefs()
    {
    }
  }
}
