// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListGuildTrainingCampaign
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C84")]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class UnitListGuildTrainingCampaign : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DC63")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400DC64")]
    private const int PIN_INPUT_UPDATE_VIEW = 2;
    [Token(Token = "0x400DC65")]
    [FieldOffset(Offset = "0xC")]
    private readonly string WINDOW_KEY;
    [Token(Token = "0x400DC66")]
    [FieldOffset(Offset = "0x10")]
    private readonly string UNLOCK_EXPANTION_CAMPAIGN_TEXT;
    [Token(Token = "0x400DC67")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x400DC68")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mCampaignTextGroup;
    [Token(Token = "0x400DC69")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mCampaignText;
    [Token(Token = "0x400DC6A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mLockCampaignTextGroup;
    [Token(Token = "0x400DC6B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mLockCampaignText;
    [Token(Token = "0x400DC6C")]
    [FieldOffset(Offset = "0x28")]
    private GuildTrainingWindow mWindow;

    [Token(Token = "0x600CE5D")]
    [Address(RVA = "0x994A30", Offset = "0x993830", VA = "0x10994A30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CE5E")]
    [Address(RVA = "0x994AF0", Offset = "0x9938F0", VA = "0x10994AF0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600CE5F")]
    [Address(RVA = "0x994B90", Offset = "0x993990", VA = "0x10994B90")]
    public void RefreshText()
    {
    }

    [Token(Token = "0x600CE60")]
    [Address(RVA = "0x994D00", Offset = "0x993B00", VA = "0x10994D00")]
    public UnitListGuildTrainingCampaign()
    {
    }
  }
}
