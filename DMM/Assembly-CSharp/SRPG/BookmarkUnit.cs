// Decompiled with JetBrains decompiler
// Type: SRPG.BookmarkUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020ED")]
  public class BookmarkUnit : ContentNode
  {
    [Token(Token = "0x4008E50")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject AchievementBadge;
    [Token(Token = "0x4008E51")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject AchievementBadgeOverlay;
    [Token(Token = "0x4008E52")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject Overlay;
    [Token(Token = "0x4008E53")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject ExtraBadge;
    [Token(Token = "0x4008E54")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private QuestCampaignList CampaignBadge;
    [Token(Token = "0x4008E55")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_Button Button;
    [Token(Token = "0x4008E56")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text HavePieceNum;
    [Token(Token = "0x4008E57")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text Challenge;
    [Token(Token = "0x4008E58")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text Limit;
    [Token(Token = "0x4008E59")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Toggle ToggleBundleSkipTarget;
    [Token(Token = "0x4008E5A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ButtonEvent ToggleBundleSkipTargetEvent;
    [Token(Token = "0x4008E5B")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private QuestBookmarkWindow OwnerWindow;
    [Token(Token = "0x4008E5C")]
    [FieldOffset(Offset = "0x60")]
    public ItemParam mItemParam;
    [Token(Token = "0x4008E5D")]
    [FieldOffset(Offset = "0x64")]
    public UnitParam mUnitParam;
    [Token(Token = "0x4008E5E")]
    [FieldOffset(Offset = "0x68")]
    public QuestBookmarkWindow.ItemAndQuest mItemAndQuestParam;
    [Token(Token = "0x4008E5F")]
    [FieldOffset(Offset = "0x6C")]
    public bool isAvailable;
    [Token(Token = "0x4008E60")]
    [FieldOffset(Offset = "0x6D")]
    public bool isCheck;
    [Token(Token = "0x4008E61")]
    [FieldOffset(Offset = "0x6E")]
    public bool isCanSkip;
    [Token(Token = "0x4008E62")]
    [FieldOffset(Offset = "0x70")]
    private BookmarkUnitContentParam tgParam;
    [Token(Token = "0x4008E63")]
    [FieldOffset(Offset = "0x74")]
    private bool IsSetup;

    [Token(Token = "0x600897E")]
    [Address(RVA = "0x4A4160", Offset = "0x4A2F60", VA = "0x104A4160")]
    public bool Setup(
      BookmarkUnitContentParam tg,
      ItemParam iParams,
      UnitParam uParams,
      QuestBookmarkWindow.ItemAndQuest iaqParams,
      bool check,
      bool available,
      bool canSkip)
    {
      return new bool();
    }

    [Token(Token = "0x600897F")]
    [Address(RVA = "0x4A3E60", Offset = "0x4A2C60", VA = "0x104A3E60")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008980")]
    [Address(RVA = "0x4A3FD0", Offset = "0x4A2DD0", VA = "0x104A3FD0")]
    private void OnPressDownButton(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008981")]
    [Address(RVA = "0x4A4040", Offset = "0x4A2E40", VA = "0x104A4040")]
    private void OnToggleBundleSkipTarget(bool check)
    {
    }

    [Token(Token = "0x6008982")]
    [Address(RVA = "0x4A40D0", Offset = "0x4A2ED0", VA = "0x104A40D0")]
    public void SetCheckBox(bool check)
    {
    }

    [Token(Token = "0x6008983")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public BookmarkUnit()
    {
    }
  }
}
