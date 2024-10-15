// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRankingTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002830")]
  public class PointQuestRankingTab : ContentNode
  {
    [Token(Token = "0x400BF8B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400BF8C")]
    [FieldOffset(Offset = "0x34")]
    private PointQuestRankingTabModel mModel;

    [Token(Token = "0x170018DF")]
    public PointQuestRankingTabModel Model
    {
      [Token(Token = "0x600B562"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (PointQuestRankingTabModel) null;
      }
    }

    [Token(Token = "0x600B563")]
    [Address(RVA = "0x7BCB30", Offset = "0x7BB930", VA = "0x107BCB30")]
    public void Initialize(
      PointQuestRankingTab.RankingDrawType drawType,
      PointQuestRankingTab.RankingRangeType rangeType,
      ChapterParam chapter)
    {
    }

    [Token(Token = "0x600B564")]
    [Address(RVA = "0x7BCC70", Offset = "0x7BBA70", VA = "0x107BCC70")]
    public void SetModel(PointQuestRankingTabModel model)
    {
    }

    [Token(Token = "0x600B565")]
    [Address(RVA = "0x7BCC90", Offset = "0x7BBA90", VA = "0x107BCC90")]
    public void SetToggleFlag(bool isFlag)
    {
    }

    [Token(Token = "0x600B566")]
    [Address(RVA = "0x7BCBF0", Offset = "0x7BB9F0", VA = "0x107BCBF0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B567")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public PointQuestRankingTab()
    {
    }

    [Token(Token = "0x2002831")]
    public enum RankingDrawType
    {
      [Token(Token = "0x400BF8E")] Person,
      [Token(Token = "0x400BF8F")] Port,
    }

    [Token(Token = "0x2002832")]
    public enum RankingRangeType
    {
      [Token(Token = "0x400BF91")] All,
      [Token(Token = "0x400BF92")] Port,
    }
  }
}
