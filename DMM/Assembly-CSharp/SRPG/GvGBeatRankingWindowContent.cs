// Decompiled with JetBrains decompiler
// Type: SRPG.GvGBeatRankingWindowContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025A1")]
  [AddComponentMenu("UI/GvG/GvGBeatRankingWindowContent")]
  public class GvGBeatRankingWindowContent : MonoBehaviour, IPagination
  {
    [Token(Token = "0x400AEB4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRankImage;
    [Token(Token = "0x400AEB5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400AEB6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ImageArray mRoleImage;
    [Token(Token = "0x400AEB7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mNameText;
    [Token(Token = "0x400AEB8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mLevelText;
    [Token(Token = "0x400AEB9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mUnit;
    [Token(Token = "0x400AEBA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mBeat;
    [Token(Token = "0x400AEBB")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [SerializeField]
    private Button PageNextButton;
    [Token(Token = "0x400AEBC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button PagePrevButton;
    [Token(Token = "0x400AEBD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text PageCurrentText;
    [Token(Token = "0x400AEBE")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text PageTotalText;
    [Token(Token = "0x400AEBF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ScrollRect BeatRankingScrollRect;
    [Token(Token = "0x400AEC1")]
    [FieldOffset(Offset = "0x40")]
    private int mTotalRankingPage;
    [Token(Token = "0x400AEC2")]
    private const int DEFAULT_RANKING_NOTEXT = 3;

    [Token(Token = "0x1700176D")]
    public int mRankingPage
    {
      [Token(Token = "0x600A741"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
      [Token(Token = "0x600A742"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] private set
      {
      }
    }

    [Token(Token = "0x600A743")]
    [Address(RVA = "0x691180", Offset = "0x68FF80", VA = "0x10691180")]
    public void Setup(GvGScoreRankingData beatData, int totalPage)
    {
    }

    [Token(Token = "0x600A744")]
    [Address(RVA = "0x690F60", Offset = "0x68FD60", VA = "0x10690F60")]
    private void RefreshPagination()
    {
    }

    [Token(Token = "0x600A745")]
    [Address(RVA = "0x690F20", Offset = "0x68FD20", VA = "0x10690F20", Slot = "4")]
    public void NextPage()
    {
    }

    [Token(Token = "0x600A746")]
    [Address(RVA = "0x690F40", Offset = "0x68FD40", VA = "0x10690F40", Slot = "5")]
    public void PrevPage()
    {
    }

    [Token(Token = "0x600A747")]
    [Address(RVA = "0x691500", Offset = "0x690300", VA = "0x10691500")]
    public GvGBeatRankingWindowContent()
    {
    }
  }
}
