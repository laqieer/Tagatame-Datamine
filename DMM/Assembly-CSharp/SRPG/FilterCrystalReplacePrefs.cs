// Decompiled with JetBrains decompiler
// Type: SRPG.FilterCrystalReplacePrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A95")]
  public class FilterCrystalReplacePrefs
  {
    [Token(Token = "0x400627B")]
    [FieldOffset(Offset = "0x0")]
    private static FilterCrystalReplacePrefs cache;
    [Token(Token = "0x400627C")]
    [FieldOffset(Offset = "0x4")]
    private static bool is_use_cache;
    [Token(Token = "0x400627D")]
    [FieldOffset(Offset = "0x8")]
    private FilterUtility.FilterPrefs prefs_data;

    [Token(Token = "0x6006D75")]
    [Address(RVA = "0x358880", Offset = "0x357680", VA = "0x10358880")]
    public bool GetValue(string majorKey, string minorKey) => new bool();

    [Token(Token = "0x6006D76")]
    [Address(RVA = "0x358AF0", Offset = "0x3578F0", VA = "0x10358AF0")]
    public void SetValue(string majorKey, string minorKey, bool value)
    {
    }

    [Token(Token = "0x6006D77")]
    [Address(RVA = "0x358680", Offset = "0x357480", VA = "0x10358680")]
    public void AllOff(string majorKey)
    {
    }

    [Token(Token = "0x6006D78")]
    [Address(RVA = "0x358980", Offset = "0x357780", VA = "0x10358980")]
    public bool IsDisableFilterAll() => new bool();

    [Token(Token = "0x6006D79")]
    [Address(RVA = "0x3589B0", Offset = "0x3577B0", VA = "0x103589B0")]
    public bool IsDisableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x6006D7A")]
    [Address(RVA = "0x3589E0", Offset = "0x3577E0", VA = "0x103589E0")]
    public bool IsEnableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x6006D7B")]
    [Address(RVA = "0x3629B0", Offset = "0x3617B0", VA = "0x103629B0")]
    public List<bool> CreateFlagList() => (List<bool>) null;

    [Token(Token = "0x6006D7C")]
    [Address(RVA = "0x362B80", Offset = "0x361980", VA = "0x10362B80")]
    public bool IsDiff(List<bool> target) => new bool();

    [Token(Token = "0x6006D7D")]
    [Address(RVA = "0x362C50", Offset = "0x361A50", VA = "0x10362C50")]
    public static FilterCrystalReplacePrefs Load() => (FilterCrystalReplacePrefs) null;

    [Token(Token = "0x6006D7E")]
    [Address(RVA = "0x362AE0", Offset = "0x3618E0", VA = "0x10362AE0")]
    public static FilterUtility.FilterPrefs GetFilterPrefs() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x6006D7F")]
    [Address(RVA = "0x362CE0", Offset = "0x361AE0", VA = "0x10362CE0")]
    public static void Save(FilterCrystalReplacePrefs data, bool allOnIsAllOff)
    {
    }

    [Token(Token = "0x6006D80")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterCrystalReplacePrefs()
    {
    }
  }
}
