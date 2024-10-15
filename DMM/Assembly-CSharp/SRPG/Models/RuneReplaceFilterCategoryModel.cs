// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneReplaceFilterCategoryModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200339A")]
  public class RuneReplaceFilterCategoryModel
  {
    [Token(Token = "0x400F43D")]
    [FieldOffset(Offset = "0x8")]
    private FilterRuneReplacePrefs mFilterPrefs;
    [Token(Token = "0x400F43E")]
    [FieldOffset(Offset = "0xC")]
    private FilterRuneParam mFilterParam;
    [Token(Token = "0x400F43F")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, RuneFilterToggleModel> mToggleModelDic;

    [Token(Token = "0x17002021")]
    public FilterRuneReplacePrefs FilterPrefs
    {
      [Token(Token = "0x600E60A"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
      [Token(Token = "0x600E60B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (FilterRuneReplacePrefs) null;
      }
    }

    [Token(Token = "0x17002022")]
    public FilterRuneParam FilterParam
    {
      [Token(Token = "0x600E60C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (FilterRuneParam) null;
      }
    }

    [Token(Token = "0x600E60D")]
    [Address(RVA = "0xAC8770", Offset = "0xAC7570", VA = "0x10AC8770")]
    public RuneReplaceFilterCategoryModel()
    {
    }

    [Token(Token = "0x600E60E")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public RuneReplaceFilterCategoryModel(FilterRuneReplacePrefs filterPrefs)
    {
    }

    [Token(Token = "0x600E60F")]
    [Address(RVA = "0xAC8720", Offset = "0xAC7520", VA = "0x10AC8720")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E610")]
    [Address(RVA = "0xAC8580", Offset = "0xAC7380", VA = "0x10AC8580")]
    public void Initialize(FilterRuneParam filterParam)
    {
    }

    [Token(Token = "0x600E611")]
    [Address(RVA = "0xAC84B0", Offset = "0xAC72B0", VA = "0x10AC84B0")]
    public string GetHeaderName() => (string) null;

    [Token(Token = "0x600E612")]
    [Address(RVA = "0xAC84F0", Offset = "0xAC72F0", VA = "0x10AC84F0")]
    public List<RuneFilterToggleModel> GetToggleModelList() => (List<RuneFilterToggleModel>) null;

    [Token(Token = "0x600E613")]
    [Address(RVA = "0xAC8740", Offset = "0xAC7540", VA = "0x10AC8740")]
    public bool IsVisible(string tabKey) => new bool();
  }
}
