// Decompiled with JetBrains decompiler
// Type: SRPG.GvGDefenseRankingWindowContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025CB")]
  [AddComponentMenu("UI/GvG/GvGDefenseRankingWindowContent")]
  public class GvGDefenseRankingWindowContent : MonoBehaviour, IPagination
  {
    [Token(Token = "0x400AF52")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRankImage;
    [Token(Token = "0x400AF53")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400AF54")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mRoleImage;
    [Token(Token = "0x400AF55")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mNameText;
    [Token(Token = "0x400AF56")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mLevelText;
    [Token(Token = "0x400AF57")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mUnit;
    [Token(Token = "0x400AF58")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mDefense;
    [Token(Token = "0x400AF59")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Space(10f)]
    private Button PageNextButton;
    [Token(Token = "0x400AF5A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button PagePrevButton;
    [Token(Token = "0x400AF5B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text PageCurrentText;
    [Token(Token = "0x400AF5C")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text PageTotalText;
    [Token(Token = "0x400AF5D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ScrollRect DefenseRankingScrollRect;
    [Token(Token = "0x400AF5F")]
    [FieldOffset(Offset = "0x40")]
    private int mTotalRankingPage;
    [Token(Token = "0x400AF60")]
    private const int DEFAULT_RANKING_NOTEXT = 3;

    [Token(Token = "0x170017A1")]
    public int mRankingPage
    {
      [Token(Token = "0x600A7E9"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7EA"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] private set
      {
      }
    }

    [Token(Token = "0x600A7EB")]
    [Address(RVA = "0x6B1FE0", Offset = "0x6B0DE0", VA = "0x106B1FE0")]
    public void Setup(GvGScoreRankingData DefenseData, int totalPage)
    {
    }

    [Token(Token = "0x600A7EC")]
    [Address(RVA = "0x6B1DC0", Offset = "0x6B0BC0", VA = "0x106B1DC0")]
    private void RefreshPagination()
    {
    }

    [Token(Token = "0x600A7ED")]
    [Address(RVA = "0x690F20", Offset = "0x68FD20", VA = "0x10690F20", Slot = "4")]
    public void NextPage()
    {
    }

    [Token(Token = "0x600A7EE")]
    [Address(RVA = "0x690F40", Offset = "0x68FD40", VA = "0x10690F40", Slot = "5")]
    public void PrevPage()
    {
    }

    [Token(Token = "0x600A7EF")]
    [Address(RVA = "0x691500", Offset = "0x690300", VA = "0x10691500")]
    public GvGDefenseRankingWindowContent()
    {
    }
  }
}
