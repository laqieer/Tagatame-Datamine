// Decompiled with JetBrains decompiler
// Type: SRPG.FilterRuneReplacePrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D3B")]
  public class FilterRuneReplacePrefs
  {
    [Token(Token = "0x40072CF")]
    [FieldOffset(Offset = "0x0")]
    private static FilterRuneReplacePrefs cache;
    [Token(Token = "0x40072D0")]
    [FieldOffset(Offset = "0x4")]
    private static bool is_use_cache;
    [Token(Token = "0x40072D1")]
    [FieldOffset(Offset = "0x8")]
    private FilterUtility.FilterPrefs prefs_data;

    [Token(Token = "0x60077D4")]
    [Address(RVA = "0x358880", Offset = "0x357680", VA = "0x10358880")]
    public bool GetValue(string majorKey, string minorKey) => new bool();

    [Token(Token = "0x60077D5")]
    [Address(RVA = "0x358AF0", Offset = "0x3578F0", VA = "0x10358AF0")]
    public void SetValue(string majorKey, string minorKey, bool value)
    {
    }

    [Token(Token = "0x60077D6")]
    [Address(RVA = "0x358680", Offset = "0x357480", VA = "0x10358680")]
    public void AllOff(string majorKey)
    {
    }

    [Token(Token = "0x60077D7")]
    [Address(RVA = "0x358980", Offset = "0x357780", VA = "0x10358980")]
    public bool IsDisableFilterAll() => new bool();

    [Token(Token = "0x60077D8")]
    [Address(RVA = "0x3589B0", Offset = "0x3577B0", VA = "0x103589B0")]
    public bool IsDisableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x60077D9")]
    [Address(RVA = "0x3589E0", Offset = "0x3577E0", VA = "0x103589E0")]
    public bool IsEnableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x60077DA")]
    [Address(RVA = "0x391080", Offset = "0x38FE80", VA = "0x10391080")]
    public List<bool> CreateFlagList() => (List<bool>) null;

    [Token(Token = "0x60077DB")]
    [Address(RVA = "0x391250", Offset = "0x390050", VA = "0x10391250")]
    public bool IsDiff(List<bool> target) => new bool();

    [Token(Token = "0x60077DC")]
    [Address(RVA = "0x391320", Offset = "0x390120", VA = "0x10391320")]
    public static FilterRuneReplacePrefs Load() => (FilterRuneReplacePrefs) null;

    [Token(Token = "0x60077DD")]
    [Address(RVA = "0x3911B0", Offset = "0x38FFB0", VA = "0x103911B0")]
    public static FilterUtility.FilterPrefs GetFilterPrefs() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x60077DE")]
    [Address(RVA = "0x3913B0", Offset = "0x3901B0", VA = "0x103913B0")]
    public static void Save(FilterRuneReplacePrefs data)
    {
    }

    [Token(Token = "0x60077DF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterRuneReplacePrefs()
    {
    }
  }
}
