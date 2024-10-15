// Decompiled with JetBrains decompiler
// Type: SRPG.QuestListV2_MultiPlayCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028A6")]
  [FlowNode.Pin(1, "イベントクエストを表示", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("Multi/クエストカテゴリー一覧")]
  [FlowNode.Pin(0, "通常クエストを表示", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "GPSクエストを含めて表示", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "選択された", FlowNode.PinTypes.Output, 101)]
  public class QuestListV2_MultiPlayCategory : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C2A1")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x400C2A2")]
    [FieldOffset(Offset = "0x10")]
    [Description("詳細画面として使用するゲームオブジェクト")]
    public GameObject DetailTemplate;
    [Token(Token = "0x400C2A3")]
    [FieldOffset(Offset = "0x14")]
    private GameObject mDetailInfo;
    [Token(Token = "0x400C2A4")]
    [FieldOffset(Offset = "0x18")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400C2A5")]
    [FieldOffset(Offset = "0x1C")]
    [Header("スクロール位置を再計算する")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400C2A6")]
    [FieldOffset(Offset = "0x20")]
    private float OffsetContentHeight;

    [Token(Token = "0x600B7C1")]
    [Address(RVA = "0x7E5520", Offset = "0x7E4320", VA = "0x107E5520", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B7C2")]
    [Address(RVA = "0x7E5570", Offset = "0x7E4370", VA = "0x107E5570")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B7C3")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B7C4")]
    [Address(RVA = "0x7E6890", Offset = "0x7E5690", VA = "0x107E6890")]
    private void Refresh(
      bool isEvent,
      QuestListV2_MultiPlayCategory.DISPLAY_QUEST_TYPE type = QuestListV2_MultiPlayCategory.DISPLAY_QUEST_TYPE.Normal)
    {
    }

    [Token(Token = "0x600B7C5")]
    [Address(RVA = "0x7E5C60", Offset = "0x7E4A60", VA = "0x107E5C60")]
    private void RefreshItems(
      QuestListV2_MultiPlayCategory.DISPLAY_QUEST_TYPE dispMode)
    {
    }

    [Token(Token = "0x600B7C6")]
    [Address(RVA = "0x7E56A0", Offset = "0x7E44A0", VA = "0x107E56A0")]
    private void CalcScrollPos(
      List<QuestListV2_MultiPlayCategory.ChapterParamExtension> areaList)
    {
    }

    [Token(Token = "0x600B7C7")]
    [Address(RVA = "0x7E59B0", Offset = "0x7E47B0", VA = "0x107E59B0")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600B7C8")]
    [Address(RVA = "0x7E5830", Offset = "0x7E4630", VA = "0x107E5830")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B7C9")]
    [Address(RVA = "0x7E58D0", Offset = "0x7E46D0", VA = "0x107E58D0")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B7CA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestListV2_MultiPlayCategory()
    {
    }

    [Token(Token = "0x20028A7")]
    private enum DISPLAY_QUEST_TYPE
    {
      [Token(Token = "0x400C2A8")] Normal,
      [Token(Token = "0x400C2A9")] WithGps,
      [Token(Token = "0x400C2AA")] Max,
    }

    [Token(Token = "0x20028A8")]
    private class ChapterParamExtension
    {
      [Token(Token = "0x400C2AB")]
      [FieldOffset(Offset = "0x8")]
      public readonly ChapterParam m_ChapterParam;
      [Token(Token = "0x400C2AC")]
      [FieldOffset(Offset = "0xC")]
      public bool m_IsQuestArchiveOpen;

      [Token(Token = "0x17001912")]
      public bool IsQuestArchiveOpen
      {
        [Token(Token = "0x600B7CB"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
        {
          return new bool();
        }
        [Token(Token = "0x600B7CC"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
        {
        }
      }

      [Token(Token = "0x17001913")]
      public ChapterParam ChapterParam
      {
        [Token(Token = "0x600B7CD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (ChapterParam) null;
        }
      }

      [Token(Token = "0x600B7CE")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ChapterParamExtension(ChapterParam chapterParam)
      {
      }
    }
  }
}
