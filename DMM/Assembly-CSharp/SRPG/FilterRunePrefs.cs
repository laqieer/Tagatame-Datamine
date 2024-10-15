// Decompiled with JetBrains decompiler
// Type: SRPG.FilterRunePrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D3A")]
  public class FilterRunePrefs
  {
    [Token(Token = "0x40072CC")]
    [FieldOffset(Offset = "0x0")]
    private static FilterRunePrefs cache;
    [Token(Token = "0x40072CD")]
    [FieldOffset(Offset = "0x4")]
    private static bool is_use_cache;
    [Token(Token = "0x40072CE")]
    [FieldOffset(Offset = "0x8")]
    private FilterUtility.FilterPrefs prefs_data;

    [Token(Token = "0x60077C8")]
    [Address(RVA = "0x358880", Offset = "0x357680", VA = "0x10358880")]
    public bool GetValue(string majorKey, string minorKey) => new bool();

    [Token(Token = "0x60077C9")]
    [Address(RVA = "0x358AF0", Offset = "0x3578F0", VA = "0x10358AF0")]
    public void SetValue(string majorKey, string minorKey, bool value)
    {
    }

    [Token(Token = "0x60077CA")]
    [Address(RVA = "0x358680", Offset = "0x357480", VA = "0x10358680")]
    public void AllOff(string majorKey)
    {
    }

    [Token(Token = "0x60077CB")]
    [Address(RVA = "0x358980", Offset = "0x357780", VA = "0x10358980")]
    public bool IsDisableFilterAll() => new bool();

    [Token(Token = "0x60077CC")]
    [Address(RVA = "0x3589B0", Offset = "0x3577B0", VA = "0x103589B0")]
    public bool IsDisableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x60077CD")]
    [Address(RVA = "0x3589E0", Offset = "0x3577E0", VA = "0x103589E0")]
    public bool IsEnableFilterAll(string majorKey) => new bool();

    [Token(Token = "0x60077CE")]
    [Address(RVA = "0x390D00", Offset = "0x38FB00", VA = "0x10390D00")]
    public List<bool> CreateFlagList() => (List<bool>) null;

    [Token(Token = "0x60077CF")]
    [Address(RVA = "0x390ED0", Offset = "0x38FCD0", VA = "0x10390ED0")]
    public bool IsDiff(List<bool> target) => new bool();

    [Token(Token = "0x60077D0")]
    [Address(RVA = "0x390FA0", Offset = "0x38FDA0", VA = "0x10390FA0")]
    public static FilterRunePrefs Load() => (FilterRunePrefs) null;

    [Token(Token = "0x60077D1")]
    [Address(RVA = "0x390E30", Offset = "0x38FC30", VA = "0x10390E30")]
    public static FilterUtility.FilterPrefs GetFilterPrefs() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x60077D2")]
    [Address(RVA = "0x391030", Offset = "0x38FE30", VA = "0x10391030")]
    public static void Save(FilterRunePrefs data, bool allOnIsAllOff)
    {
    }

    [Token(Token = "0x60077D3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterRunePrefs()
    {
    }
  }
}
