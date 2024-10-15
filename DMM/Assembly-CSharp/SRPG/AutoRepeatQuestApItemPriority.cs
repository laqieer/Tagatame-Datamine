// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRepeatQuestApItemPriority
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
  [Token(Token = "0x200205F")]
  [AddComponentMenu("UI/AutoRepeatQuest/AutoRepeatQuestApItemPriority")]
  [FlowNode.Pin(100, "設定反映OK", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "設定反映NG", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "設定反映チェック", FlowNode.PinTypes.Input, 20)]
  public class AutoRepeatQuestApItemPriority : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008B21")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4008B22")]
    private const int PIN_INPUT_APPLY_CHECK = 20;
    [Token(Token = "0x4008B23")]
    private const int PIN_OUTPUT_APPLY_CHECK_OK = 100;
    [Token(Token = "0x4008B24")]
    private const int PIN_OUTPUT_APPLY_CHECK_NG = 110;
    [Token(Token = "0x4008B25")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mApItemTemplate;
    [Token(Token = "0x4008B26")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mDecideButton;
    [Token(Token = "0x4008B27")]
    [FieldOffset(Offset = "0x14")]
    private List<AutoRepeatQuestApItemContent> mCreatedApItemContents;
    [Token(Token = "0x4008B28")]
    [FieldOffset(Offset = "0x18")]
    private List<AutoRepeatQuestApItemContent> mSelectedApItemContents;
    [Token(Token = "0x4008B29")]
    [FieldOffset(Offset = "0x0")]
    private static AutoRepeatQuestApItemPriority mInstance;

    [Token(Token = "0x17001313")]
    public static AutoRepeatQuestApItemPriority Instance
    {
      [Token(Token = "0x6008679"), Address(RVA = "0x47E120", Offset = "0x47CF20", VA = "0x1047E120")] get
      {
        return (AutoRepeatQuestApItemPriority) null;
      }
    }

    [Token(Token = "0x600867A")]
    [Address(RVA = "0x47D3B0", Offset = "0x47C1B0", VA = "0x1047D3B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600867B")]
    [Address(RVA = "0x47DE30", Offset = "0x47CC30", VA = "0x1047DE30")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600867C")]
    [Address(RVA = "0x47D340", Offset = "0x47C140", VA = "0x1047D340", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600867D")]
    [Address(RVA = "0x47D920", Offset = "0x47C720", VA = "0x1047D920")]
    private void Init()
    {
    }

    [Token(Token = "0x600867E")]
    [Address(RVA = "0x47DCF0", Offset = "0x47CAF0", VA = "0x1047DCF0")]
    private void LoadPlayerApItemPriority()
    {
    }

    [Token(Token = "0x600867F")]
    [Address(RVA = "0x47D450", Offset = "0x47C250", VA = "0x1047D450")]
    private void CreateApItemList()
    {
    }

    [Token(Token = "0x6008680")]
    [Address(RVA = "0x47D760", Offset = "0x47C560", VA = "0x1047D760")]
    public string[] GetApItemPriority() => (string[]) null;

    [Token(Token = "0x6008681")]
    [Address(RVA = "0x47DE70", Offset = "0x47CC70", VA = "0x1047DE70")]
    public void OnSelectToggle(AutoRepeatQuestApItemContent self)
    {
    }

    [Token(Token = "0x6008682")]
    [Address(RVA = "0x47DAD0", Offset = "0x47C8D0", VA = "0x1047DAD0")]
    private bool IsEnableSettings() => new bool();

    [Token(Token = "0x6008683")]
    [Address(RVA = "0x47DB10", Offset = "0x47C910", VA = "0x1047DB10")]
    private bool IsEnough_PriorityImageArray() => new bool();

    [Token(Token = "0x6008684")]
    [Address(RVA = "0x47E080", Offset = "0x47CE80", VA = "0x1047E080")]
    public AutoRepeatQuestApItemPriority()
    {
    }
  }
}
