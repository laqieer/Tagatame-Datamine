// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneReplaceWindowElementTabModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200339D")]
  public class RuneReplaceWindowElementTabModel
  {
    [Token(Token = "0x400F44B")]
    [FieldOffset(Offset = "0x8")]
    private int mIndex;
    [Token(Token = "0x400F44C")]
    [FieldOffset(Offset = "0xC")]
    private int mAllNum;
    [Token(Token = "0x400F44D")]
    [FieldOffset(Offset = "0x10")]
    private RuneReplaceWindowElementTabModel.TabCategoryType mTabType;
    [Token(Token = "0x400F44E")]
    [FieldOffset(Offset = "0x14")]
    private EElement mEElement;

    [Token(Token = "0x600E633")]
    [Address(RVA = "0xAC9E10", Offset = "0xAC8C10", VA = "0x10AC9E10")]
    public void Initialize(
      RuneReplaceWindowElementTabModel.TabCategoryType type,
      EElement element)
    {
    }

    [Token(Token = "0x600E634")]
    [Address(RVA = "0xAC9D50", Offset = "0xAC8B50", VA = "0x10AC9D50")]
    public List<string> GetUnitList(List<string> unitList) => (List<string>) null;

    [Token(Token = "0x600E635")]
    [Address(RVA = "0xACA0C0", Offset = "0xAC8EC0", VA = "0x10ACA0C0")]
    private List<string> MatchIsFavorite(List<string> unitList) => (List<string>) null;

    [Token(Token = "0x600E636")]
    [Address(RVA = "0xAC9E40", Offset = "0xAC8C40", VA = "0x10AC9E40")]
    private List<string> MatchIsElement(List<string> unitList) => (List<string>) null;

    [Token(Token = "0x600E637")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneReplaceWindowElementTabModel()
    {
    }

    [Token(Token = "0x200339E")]
    public enum TabCategoryType
    {
      [Token(Token = "0x400F450")] ALL,
      [Token(Token = "0x400F451")] FAVORITE,
      [Token(Token = "0x400F452")] ELEMENT,
    }
  }
}
