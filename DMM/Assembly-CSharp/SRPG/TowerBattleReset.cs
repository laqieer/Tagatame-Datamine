// Decompiled with JetBrains decompiler
// Type: SRPG.TowerBattleReset
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
  [Token(Token = "0x2002B38")]
  [FlowNode.Pin(0, "初期化（実行）", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "初期化（終了）", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/TowerBattleReset")]
  public class TowerBattleReset : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D303")]
    private const int INPUT_INITIALIZE_BEGIN = 0;
    [Token(Token = "0x400D304")]
    private const int OUTPUT_INITIALIZE_END = 100;
    [Token(Token = "0x400D305")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject TollRecovery;
    [Token(Token = "0x400D306")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject FreeRecovery;
    [Token(Token = "0x400D307")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject HaveItemObject;
    [Token(Token = "0x400D308")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text HaveItemNum;
    [Token(Token = "0x400D309")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HeaderBar("▼ミッション表示エリアのタイトル")]
    private Text m_MissionListTitle;
    [Token(Token = "0x400D30A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text m_MissionListTitleNoItem;
    [Token(Token = "0x400D30B")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼ミッション表示リストの親")]
    [SerializeField]
    private RectTransform m_MissionListParent;
    [Token(Token = "0x400D30C")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼ミッション表示用テンプレート")]
    [SerializeField]
    private QuestMissionItem m_MissionItemTemplate;
    [Token(Token = "0x400D30D")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> m_MissionListItems;

    [Token(Token = "0x600C5CF")]
    [Address(RVA = "0x8E4CE0", Offset = "0x8E3AE0", VA = "0x108E4CE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C5D0")]
    [Address(RVA = "0x8E53D0", Offset = "0x8E41D0", VA = "0x108E53D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C5D1")]
    [Address(RVA = "0x8E52D0", Offset = "0x8E40D0", VA = "0x108E52D0")]
    private void InitializeMissionItems()
    {
    }

    [Token(Token = "0x600C5D2")]
    [Address(RVA = "0x8E4ED0", Offset = "0x8E3CD0", VA = "0x108E4ED0")]
    private void CreateResetMissionItems(QuestParam questParam)
    {
    }

    [Token(Token = "0x600C5D3")]
    [Address(RVA = "0x8E4DF0", Offset = "0x8E3BF0", VA = "0x108E4DF0")]
    private QuestMissionItem CreateMissionItem(QuestBonusObjective bonusObjective)
    {
      return (QuestMissionItem) null;
    }

    [Token(Token = "0x600C5D4")]
    [Address(RVA = "0x8E51D0", Offset = "0x8E3FD0", VA = "0x108E51D0")]
    private void DeleteMissionItems()
    {
    }

    [Token(Token = "0x600C5D5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerBattleReset()
    {
    }
  }
}
