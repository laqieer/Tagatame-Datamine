// Decompiled with JetBrains decompiler
// Type: SRPG.FilterConceptCardPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D34")]
  public class FilterConceptCardPrefs
  {
    [Token(Token = "0x40072A2")]
    [FieldOffset(Offset = "0x0")]
    private static FilterConceptCardPrefs cache;
    [Token(Token = "0x40072A3")]
    [FieldOffset(Offset = "0x4")]
    private static bool is_use_cache;
    [Token(Token = "0x40072A4")]
    [FieldOffset(Offset = "0x8")]
    private static FilterConceptCardPrefs cacheExtraRarity;
    [Token(Token = "0x40072A5")]
    [FieldOffset(Offset = "0xC")]
    private static bool is_use_cache_extra_rarity;
    [Token(Token = "0x40072A6")]
    [FieldOffset(Offset = "0x8")]
    private FilterUtility.FilterPrefs prefs_data;

    [Token(Token = "0x60077B3")]
    [Address(RVA = "0x358880", Offset = "0x357680", VA = "0x10358880")]
    public bool GetValue(string majorKey, string minorKey) => new bool();

    [Token(Token = "0x60077B4")]
    [Address(RVA = "0x358AF0", Offset = "0x3578F0", VA = "0x10358AF0")]
    public void SetValue(string majorKey, string minorKey, bool value)
    {
    }

    [Token(Token = "0x60077B5")]
    [Address(RVA = "0x358680", Offset = "0x357480", VA = "0x10358680")]
    public void AllOff(string majorKey)
    {
    }

    [Token(Token = "0x60077B6")]
    [Address(RVA = "0x358980", Offset = "0x357780", VA = "0x10358980")]
    public bool IsDisableFilterAll() => new bool();

    [Token(Token = "0x60077B7")]
    [Address(RVA = "0x3589B0", Offset = "0x3577B0", VA = "0x103589B0")]
    public bool IsDisableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x60077B8")]
    [Address(RVA = "0x3589E0", Offset = "0x3577E0", VA = "0x103589E0")]
    public bool IsEnableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x60077B9")]
    [Address(RVA = "0x390540", Offset = "0x38F340", VA = "0x10390540")]
    public List<bool> CreateFlagList() => (List<bool>) null;

    [Token(Token = "0x60077BA")]
    [Address(RVA = "0x390670", Offset = "0x38F470", VA = "0x10390670")]
    public bool IsDiff(List<bool> target) => new bool();

    [Token(Token = "0x60077BB")]
    [Address(RVA = "0x3907E0", Offset = "0x38F5E0", VA = "0x103907E0")]
    public static FilterConceptCardPrefs Load() => (FilterConceptCardPrefs) null;

    [Token(Token = "0x60077BC")]
    [Address(RVA = "0x390740", Offset = "0x38F540", VA = "0x10390740")]
    public static FilterConceptCardPrefs Load_ExtraRarity() => (FilterConceptCardPrefs) null;

    [Token(Token = "0x60077BD")]
    [Address(RVA = "0x390870", Offset = "0x38F670", VA = "0x10390870")]
    public static void Save(FilterConceptCardPrefs data)
    {
    }

    [Token(Token = "0x60077BE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterConceptCardPrefs()
    {
    }
  }
}
