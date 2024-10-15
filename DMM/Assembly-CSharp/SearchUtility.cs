// Decompiled with JetBrains decompiler
// Type: SearchUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000149")]
public static class SearchUtility
{
  [Token(Token = "0x4000655")]
  [FieldOffset(Offset = "0x0")]
  private static char[] SEARCH_SPLIT_STRING;

  [Token(Token = "0x6000808")]
  [Address(RVA = "0xE52710", Offset = "0xE51510", VA = "0x10E52710")]
  private static List<string> GetSearchStringList(string input) => (List<string>) null;

  [Token(Token = "0x6000809")]
  [Address(RVA = "0xE527B0", Offset = "0xE515B0", VA = "0x10E527B0")]
  private static bool IsAndMatchSearchWord(string target, List<string> searchWordList)
  {
    return new bool();
  }

  [Token(Token = "0x600080A")]
  [Address(RVA = "0xE52920", Offset = "0xE51720", VA = "0x10E52920")]
  private static bool IsOrMatchSearchWord(string target, List<string> searchWordList) => new bool();

  [Token(Token = "0x600080B")]
  private static List<T> GetAndSearchList<T>(string input, Dictionary<T, List<string>> targetList)
  {
    return (List<T>) null;
  }

  [Token(Token = "0x600080C")]
  private static List<T> GetOrSearchList<T>(string input, Dictionary<T, List<string>> targetList)
  {
    return (List<T>) null;
  }

  [Token(Token = "0x600080D")]
  [Address(RVA = "0xE53080", Offset = "0xE51E80", VA = "0x10E53080")]
  public static List<ArtifactParam> SearchArtifactParam(
    string input,
    List<ArtifactParam> artifactList,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (List<ArtifactParam>) null;
  }

  [Token(Token = "0x600080E")]
  [Address(RVA = "0xE52A90", Offset = "0xE51890", VA = "0x10E52A90")]
  public static List<ArtifactData> SearchArtifactData(
    string input,
    List<ArtifactData> artifactList,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (List<ArtifactData>) null;
  }

  [Token(Token = "0x600080F")]
  [Address(RVA = "0xE53BE0", Offset = "0xE529E0", VA = "0x10E53BE0")]
  public static List<ConceptCardParam> SearchConceptCardParam(
    string input,
    List<ConceptCardParam> conceptcardList,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (List<ConceptCardParam>) null;
  }

  [Token(Token = "0x6000810")]
  [Address(RVA = "0xE535E0", Offset = "0xE523E0", VA = "0x10E535E0")]
  public static List<ConceptCardData> SearchConceptCardData(
    string input,
    List<ConceptCardData> conceptcardList,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (List<ConceptCardData>) null;
  }

  [Token(Token = "0x6000811")]
  [Address(RVA = "0xE54140", Offset = "0xE52F40", VA = "0x10E54140")]
  public static List<CrystalData> SearchCrystalData(
    string input,
    List<CrystalData> _crystal_data_list,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (List<CrystalData>) null;
  }

  [Token(Token = "0x6000812")]
  [Address(RVA = "0xE54D10", Offset = "0xE53B10", VA = "0x10E54D10")]
  public static List<UnitListWindow.Data> SearchUnitData(
    string input,
    List<UnitListWindow.Data> _unit_data_list,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (List<UnitListWindow.Data>) null;
  }

  [Token(Token = "0x6000813")]
  [Address(RVA = "0xE55330", Offset = "0xE54130", VA = "0x10E55330")]
  public static UnitParam[] SearchUnitParam(
    string input,
    UnitParam[] _unit_list,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (UnitParam[]) null;
  }

  [Token(Token = "0x6000814")]
  [Address(RVA = "0xE54750", Offset = "0xE53550", VA = "0x10E54750")]
  public static ItemSelectListItemData[] SearchItemSelectListItemDatas(
    string input,
    ItemSelectListItemData[] _item_list,
    SearchUtility.CONDITIONS Conditions = SearchUtility.CONDITIONS.AND)
  {
    return (ItemSelectListItemData[]) null;
  }

  [Token(Token = "0x6000815")]
  [Address(RVA = "0xE55850", Offset = "0xE54650", VA = "0x10E55850")]
  static SearchUtility()
  {
  }

  [Token(Token = "0x200014A")]
  public enum CONDITIONS
  {
    [Token(Token = "0x4000657")] AND,
    [Token(Token = "0x4000658")] OR,
  }
}
