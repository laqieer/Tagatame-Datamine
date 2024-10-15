// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueRankingContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025E1")]
  [AddComponentMenu("UI/GvG/GvGLeagueRankingContent")]
  public class GvGLeagueRankingContent : ContentNode
  {
    [Token(Token = "0x400AFE8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int DRAW_STRING_UNDER_RANK;
    [Token(Token = "0x400AFE9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mOwnGuildBG;
    [Token(Token = "0x400AFEA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mOtherGuildBG;
    [Token(Token = "0x400AFEB")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private ImageArray mRankImages;
    [Token(Token = "0x400AFEC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400AFED")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mNameText;
    [Token(Token = "0x400AFEE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mLevelText;
    [Token(Token = "0x400AFEF")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mMasterText;
    [Token(Token = "0x400AFF0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text mLeagueRate;
    [Token(Token = "0x400AFF1")]
    [FieldOffset(Offset = "0x54")]
    private GvGLeagueViewGuild m_GvGLeagueViewGuild;

    [Token(Token = "0x600A86C")]
    [Address(RVA = "0x6B6CA0", Offset = "0x6B5AA0", VA = "0x106B6CA0")]
    public bool Setup(GvGLeagueViewGuild guild) => new bool();

    [Token(Token = "0x600A86D")]
    [Address(RVA = "0x6B6C40", Offset = "0x6B5A40", VA = "0x106B6C40")]
    public GvGLeagueParam GetGvGLeagueParam() => (GvGLeagueParam) null;

    [Token(Token = "0x600A86E")]
    [Address(RVA = "0x6B70E0", Offset = "0x6B5EE0", VA = "0x106B70E0")]
    public GvGLeagueRankingContent()
    {
    }

    [Token(Token = "0x20025E2")]
    public delegate void OnListItemClick(GvGLeagueViewGuild leagueData);

    [Token(Token = "0x20025E3")]
    public class ContentParm : ContentSource.Param
    {
      [Token(Token = "0x400AFF2")]
      [FieldOffset(Offset = "0x10")]
      public GvGLeagueViewGuild mGvGLeagueData;
      [Token(Token = "0x400AFF3")]
      [FieldOffset(Offset = "0x14")]
      public bool IsEmpty;
      [Token(Token = "0x400AFF4")]
      [FieldOffset(Offset = "0x18")]
      public GvGLeagueRankingContent.OnListItemClick onListItemClick;
      [Token(Token = "0x400AFF5")]
      [FieldOffset(Offset = "0x1C")]
      private GvGLeagueRankingContent mNode;

      [Token(Token = "0x600A873")]
      [Address(RVA = "0x6B1B40", Offset = "0x6B0940", VA = "0x106B1B40", Slot = "4")]
      public override void Initialize(ContentSource source)
      {
      }

      [Token(Token = "0x600A874")]
      [Address(RVA = "0x6B1C30", Offset = "0x6B0A30", VA = "0x106B1C30", Slot = "12")]
      public override void OnEnable(ContentNode node)
      {
      }

      [Token(Token = "0x600A875")]
      [Address(RVA = "0x6B1C00", Offset = "0x6B0A00", VA = "0x106B1C00", Slot = "13")]
      public override void OnDisable(ContentNode node)
      {
      }

      [Token(Token = "0x600A876")]
      [Address(RVA = "0x6B1BD0", Offset = "0x6B09D0", VA = "0x106B1BD0", Slot = "19")]
      public override void OnClick(ContentNode node)
      {
      }

      [Token(Token = "0x600A877")]
      [Address(RVA = "0x6B1D50", Offset = "0x6B0B50", VA = "0x106B1D50")]
      public void Refresh()
      {
      }

      [Token(Token = "0x600A878")]
      [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
      public ContentParm()
      {
      }
    }
  }
}
