// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidTrainingBossStageInfo
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
  [Token(Token = "0x2002593")]
  [FlowNode.Pin(101, "Close Check", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1001, "Close", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1002, "Req and Close", FlowNode.PinTypes.Output, 1002)]
  [AddComponentMenu("UI/GuildRaid/Training/GuildRaidTrainingBossStageInfo")]
  [FlowNode.Pin(100, "Select Lap", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  public class GuildRaidTrainingBossStageInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AE50")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AE51")]
    public const int PIN_INPUT_SELECTLAP = 100;
    [Token(Token = "0x400AE52")]
    public const int PIN_INPUT_CHECK_CLOSE = 101;
    [Token(Token = "0x400AE53")]
    public const int PIN_OUTPUT_CLOSE = 1001;
    [Token(Token = "0x400AE54")]
    public const int PIN_OUTPUT_REQ_AND_CLOSE = 1002;
    [Token(Token = "0x400AE55")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mLapList;
    [Token(Token = "0x400AE56")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button mLapButtonTemp;
    [Token(Token = "0x400AE57")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mLapText;
    [Token(Token = "0x400AE58")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_ScrollRect mLapScroll;
    [Token(Token = "0x400AE59")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mCurrentHPText;
    [Token(Token = "0x400AE5A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mMaxHPText;
    [Token(Token = "0x400AE5B")]
    [FieldOffset(Offset = "0x24")]
    private ColorBlock mKeepButtonColor;
    [Token(Token = "0x400AE5C")]
    [FieldOffset(Offset = "0x7C")]
    private ColorBlock mChangeButtonColor;
    [Token(Token = "0x400AE5D")]
    private const int SCROLL_INITLAP = 1;
    [Token(Token = "0x400AE5E")]
    [FieldOffset(Offset = "0xD4")]
    private bool isListDraw;
    [Token(Token = "0x400AE5F")]
    [FieldOffset(Offset = "0xD8")]
    private List<Button> mListButton;

    [Token(Token = "0x600A6E7")]
    [Address(RVA = "0x68C8A0", Offset = "0x68B6A0", VA = "0x1068C8A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A6E8")]
    [Address(RVA = "0x68D1F0", Offset = "0x68BFF0", VA = "0x1068D1F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A6E9")]
    [Address(RVA = "0x68C770", Offset = "0x68B570", VA = "0x1068C770", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A6EA")]
    [Address(RVA = "0x68CA70", Offset = "0x68B870", VA = "0x1068CA70")]
    private void Init()
    {
    }

    [Token(Token = "0x600A6EB")]
    [Address(RVA = "0x68D5B0", Offset = "0x68C3B0", VA = "0x1068D5B0")]
    private void SetSelectLapButtonColor()
    {
    }

    [Token(Token = "0x600A6EC")]
    [Address(RVA = "0x68D310", Offset = "0x68C110", VA = "0x1068D310")]
    public void OnLapSelectButon(Button obj)
    {
    }

    [Token(Token = "0x600A6ED")]
    [Address(RVA = "0x68D9D0", Offset = "0x68C7D0", VA = "0x1068D9D0")]
    public GuildRaidTrainingBossStageInfo()
    {
    }
  }
}
