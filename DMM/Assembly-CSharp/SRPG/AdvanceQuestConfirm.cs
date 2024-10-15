// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceQuestConfirm
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
  [Token(Token = "0x2001F57")]
  [AddComponentMenu("UI/Advance/AdvanceQuestConfirm")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  public class AdvanceQuestConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008402")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x4008403")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private QuestCampaignList CampaignPrefab;
    [Token(Token = "0x4008404")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject DetailInfoPrefab;
    [Token(Token = "0x4008405")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text Text_StaminaVal;
    [Token(Token = "0x4008406")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GameObject> mRefMissionStarLists;
    [Token(Token = "0x4008407")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private List<GameObject> mRefDifficultyObject;
    [Token(Token = "0x4008408")]
    [FieldOffset(Offset = "0x20")]
    private QuestParam mQuestParam;
    [Token(Token = "0x4008409")]
    [FieldOffset(Offset = "0x24")]
    private QuestCampaignData[] mCampaigns;

    [Token(Token = "0x6008089")]
    [Address(RVA = "0x40C8D0", Offset = "0x40B6D0", VA = "0x1040C8D0")]
    private bool Init() => new bool();

    [Token(Token = "0x600808A")]
    [Address(RVA = "0x40CBE0", Offset = "0x40B9E0", VA = "0x1040CBE0")]
    public void OnOpenItemDetail()
    {
    }

    [Token(Token = "0x600808B")]
    [Address(RVA = "0x40C880", Offset = "0x40B680", VA = "0x1040C880", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600808C")]
    [Address(RVA = "0x40CCD0", Offset = "0x40BAD0", VA = "0x1040CCD0")]
    public void SetMissionStar(QuestParam param)
    {
    }

    [Token(Token = "0x600808D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceQuestConfirm()
    {
    }
  }
}
