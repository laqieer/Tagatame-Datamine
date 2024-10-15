// Decompiled with JetBrains decompiler
// Type: SRPG.QuestArchiveListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200286B")]
  [AddComponentMenu("UI/QuestArchiveListItem")]
  public class QuestArchiveListItem : MonoBehaviour
  {
    [Token(Token = "0x400C11D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BannerObject;
    [Token(Token = "0x400C11E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button DetailsButton;
    [Token(Token = "0x400C11F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject DetailsTemplate;
    [Token(Token = "0x400C120")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Lock;
    [Token(Token = "0x400C121")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text QuestName;
    [Token(Token = "0x400C122")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject TimeRemaining;
    [Token(Token = "0x400C123")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private UnitIcon Unit1Icon;
    [Token(Token = "0x400C124")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UnitIcon Unit2Icon;
    [Token(Token = "0x400C125")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ItemIcon ItemIcon;
    [Token(Token = "0x400C126")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ArtifactIcon ArtifactIcon;
    [Token(Token = "0x400C127")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private ConceptCardIcon ConceptCardIcon;
    [Token(Token = "0x400C128")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public Button OpenButton;
    [Token(Token = "0x400C129")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public Button ChallengeButton;
    [Token(Token = "0x400C12A")]
    [FieldOffset(Offset = "0x40")]
    private ArchiveParam mArchiveParam;
    [Token(Token = "0x400C12B")]
    [FieldOffset(Offset = "0x44")]
    private OpenedQuestArchive mOpenedQuestArchive;
    [Token(Token = "0x400C12C")]
    [FieldOffset(Offset = "0x48")]
    private ChapterParam mChapterParam;
    [Token(Token = "0x400C12D")]
    [FieldOffset(Offset = "0x4C")]
    private UnitParam mUnit1Param;
    [Token(Token = "0x400C12E")]
    [FieldOffset(Offset = "0x50")]
    private UnitParam mUnit2Param;
    [Token(Token = "0x400C12F")]
    [FieldOffset(Offset = "0x58")]
    private long mEndTime;
    [Token(Token = "0x400C130")]
    [FieldOffset(Offset = "0x60")]
    private float mRefreshInterval;
    [Token(Token = "0x400C131")]
    [FieldOffset(Offset = "0x64")]
    private GameManager gm;

    [Token(Token = "0x600B6A7")]
    [Address(RVA = "0x7D1110", Offset = "0x7CFF10", VA = "0x107D1110")]
    public void SetupParams(
      ArchiveParam archiveParam,
      OpenedQuestArchive openedQuestArchive,
      ChapterParam chapterParam,
      UnitParam unit1Param,
      UnitParam unit2Param)
    {
    }

    [Token(Token = "0x600B6A8")]
    [Address(RVA = "0x7D11B0", Offset = "0x7CFFB0", VA = "0x107D11B0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B6A9")]
    [Address(RVA = "0x7D0590", Offset = "0x7CF390", VA = "0x107D0590")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B6AA")]
    [Address(RVA = "0x7D0170", Offset = "0x7CEF70", VA = "0x107D0170")]
    private void RefreshUIState()
    {
    }

    [Token(Token = "0x600B6AB")]
    [Address(RVA = "0x7D1200", Offset = "0x7D0000", VA = "0x107D1200")]
    public QuestArchiveListItem()
    {
    }
  }
}
