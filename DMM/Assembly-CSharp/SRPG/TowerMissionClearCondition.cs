// Decompiled with JetBrains decompiler
// Type: SRPG.TowerMissionClearCondition
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
  [Token(Token = "0x2002B45")]
  [FlowNode.Pin(0, "表示内容更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/TowerMissionClearCondition")]
  public class TowerMissionClearCondition : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D390")]
    private const int INPUT_REFRESH_MISSION = 0;
    [Token(Token = "0x400D391")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼ウィンドウのタイトル")]
    [SerializeField]
    private Text TowerName;
    [Token(Token = "0x400D392")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TowerFloorNum;
    [Token(Token = "0x400D393")]
    [FieldOffset(Offset = "0x14")]
    [HeaderBar("▼吹き出し内のオブジェクト")]
    [SerializeField]
    private Text ClearConditionText01;
    [Token(Token = "0x400D394")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text ClearConditionText02;
    [Token(Token = "0x400D395")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageArray ClearConditionImage01;
    [Token(Token = "0x400D396")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageArray ClearConditionImage02;
    [Token(Token = "0x400D397")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [HeaderBar("▼ミッション表示エリアのタイトル")]
    private Text m_MissionListTitle;
    [Token(Token = "0x400D398")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text m_MissionListTitleNoItem;
    [Token(Token = "0x400D399")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼ミッション表示リストの親")]
    [SerializeField]
    private RectTransform m_MissionListParent;
    [Token(Token = "0x400D39A")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼ミッション表示用テンプレート")]
    [SerializeField]
    private QuestMissionItem m_MissionItemTemplate;
    [Token(Token = "0x400D39B")]
    [FieldOffset(Offset = "0x34")]
    private List<GameObject> m_MissionListItems;

    [Token(Token = "0x600C617")]
    [Address(RVA = "0x8EA430", Offset = "0x8E9230", VA = "0x108EA430")]
    private void Start()
    {
    }

    [Token(Token = "0x600C618")]
    [Address(RVA = "0x8E9FF0", Offset = "0x8E8DF0", VA = "0x108E9FF0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C619")]
    [Address(RVA = "0x8E9AF0", Offset = "0x8E88F0", VA = "0x108E9AF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C61A")]
    [Address(RVA = "0x8E9BF0", Offset = "0x8E89F0", VA = "0x108E9BF0")]
    private void CreateResetMissionItems(QuestParam questParam)
    {
    }

    [Token(Token = "0x600C61B")]
    [Address(RVA = "0x8E9B10", Offset = "0x8E8910", VA = "0x108E9B10")]
    private QuestMissionItem CreateMissionItem(QuestBonusObjective bonusObjective)
    {
      return (QuestMissionItem) null;
    }

    [Token(Token = "0x600C61C")]
    [Address(RVA = "0x8E9EF0", Offset = "0x8E8CF0", VA = "0x108E9EF0")]
    private void DeleteMissionItems()
    {
    }

    [Token(Token = "0x600C61D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerMissionClearCondition()
    {
    }
  }
}
