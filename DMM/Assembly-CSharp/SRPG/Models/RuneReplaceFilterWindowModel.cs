// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneReplaceFilterWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200339C")]
  public class RuneReplaceFilterWindowModel
  {
    [Token(Token = "0x400F444")]
    [FieldOffset(Offset = "0x8")]
    private FilterRuneReplacePrefs mCurrentFilterPrefs;
    [Token(Token = "0x400F445")]
    [FieldOffset(Offset = "0xC")]
    private string mCurrentTabName;
    [Token(Token = "0x400F446")]
    [FieldOffset(Offset = "0x10")]
    private List<FilterRuneParam> mFilterParams;
    [Token(Token = "0x400F447")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<eRuneFilterTypes, string> mCategoryKey;
    [Token(Token = "0x400F448")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, RuneReplaceFilterTabModel> mTabModelDic;
    [Token(Token = "0x400F449")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<string, RuneReplaceFilterCategoryModel> mCategoryModelDic;
    [Token(Token = "0x400F44A")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, List<string>> mTabForCategoryKeyDic;

    [Token(Token = "0x17002026")]
    public FilterRuneReplacePrefs CurrentFilterPrefs
    {
      [Token(Token = "0x600E61E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (FilterRuneReplacePrefs) null;
      }
    }

    [Token(Token = "0x17002027")]
    public string CurrentTabName
    {
      [Token(Token = "0x600E61F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002028")]
    public Dictionary<string, RuneReplaceFilterTabModel> TabModelDic
    {
      [Token(Token = "0x600E620"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Dictionary<string, RuneReplaceFilterTabModel>) null;
      }
    }

    [Token(Token = "0x17002029")]
    public Dictionary<string, RuneReplaceFilterCategoryModel> CategoryModelDic
    {
      [Token(Token = "0x600E621"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (Dictionary<string, RuneReplaceFilterCategoryModel>) null;
      }
    }

    [Token(Token = "0x1700202A")]
    public Dictionary<string, List<string>> TabForCategoryDic
    {
      [Token(Token = "0x600E622"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (Dictionary<string, List<string>>) null;
      }
    }

    [Token(Token = "0x600E623")]
    [Address(RVA = "0xAC8B90", Offset = "0xAC7990", VA = "0x10AC8B90")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E624")]
    [Address(RVA = "0xAC93A0", Offset = "0xAC81A0", VA = "0x10AC93A0")]
    public void SetParams()
    {
    }

    [Token(Token = "0x600E625")]
    [Address(RVA = "0xAC8860", Offset = "0xAC7660", VA = "0x10AC8860")]
    private void Add(FilterRuneParam param)
    {
    }

    [Token(Token = "0x600E626")]
    [Address(RVA = "0xAC9A00", Offset = "0xAC8800", VA = "0x10AC9A00")]
    public void SetTabModelDictionary()
    {
    }

    [Token(Token = "0x600E627")]
    [Address(RVA = "0xAC9830", Offset = "0xAC8630", VA = "0x10AC9830")]
    public void SetTabForCategoryKeyDictionary()
    {
    }

    [Token(Token = "0x600E628")]
    [Address(RVA = "0xAC9080", Offset = "0xAC7E80", VA = "0x10AC9080")]
    public bool SavePrefs() => new bool();

    [Token(Token = "0x600E629")]
    [Address(RVA = "0xAC89C0", Offset = "0xAC77C0", VA = "0x10AC89C0")]
    public RuneReplaceFilterCategoryModel GetCategoryModel(string inameKey)
    {
      return (RuneReplaceFilterCategoryModel) null;
    }

    [Token(Token = "0x600E62A")]
    [Address(RVA = "0xAC8A20", Offset = "0xAC7820", VA = "0x10AC8A20")]
    public RuneReplaceFilterCategoryModel GetCategoryModel(eRuneFilterTypes type)
    {
      return (RuneReplaceFilterCategoryModel) null;
    }

    [Token(Token = "0x600E62B")]
    [Address(RVA = "0xAC8A90", Offset = "0xAC7890", VA = "0x10AC8A90")]
    public bool GetCategoryVisible(string inameKey) => new bool();

    [Token(Token = "0x600E62C")]
    [Address(RVA = "0xAC8BC0", Offset = "0xAC79C0", VA = "0x10AC8BC0")]
    public bool IsVisible(string inameKey) => new bool();

    [Token(Token = "0x600E62D")]
    [Address(RVA = "0xAC8C40", Offset = "0xAC7A40", VA = "0x10AC8C40")]
    public bool IsVisible(eRuneFilterTypes type) => new bool();

    [Token(Token = "0x600E62E")]
    [Address(RVA = "0xAC8B10", Offset = "0xAC7910", VA = "0x10AC8B10")]
    public string GetInameKey(eRuneFilterTypes type) => (string) null;

    [Token(Token = "0x600E62F")]
    [Address(RVA = "0xAC9330", Offset = "0xAC8130", VA = "0x10AC9330")]
    public void SetCurrentTab(string tabName)
    {
    }

    [Token(Token = "0x600E630")]
    [Address(RVA = "0x70A180", Offset = "0x708F80", VA = "0x1070A180")]
    public bool IsCurrentTab(string tabName) => new bool();

    [Token(Token = "0x600E631")]
    [Address(RVA = "0xAC8CD0", Offset = "0xAC7AD0", VA = "0x10AC8CD0")]
    public bool SavePrefs(
      Dictionary<string, RuneReplaceFilterCategory> categoryDic)
    {
      return new bool();
    }

    [Token(Token = "0x600E632")]
    [Address(RVA = "0xAC9D00", Offset = "0xAC8B00", VA = "0x10AC9D00")]
    public RuneReplaceFilterWindowModel()
    {
    }
  }
}
