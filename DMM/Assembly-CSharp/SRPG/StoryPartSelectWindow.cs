// Decompiled with JetBrains decompiler
// Type: SRPG.StoryPartSelectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B08")]
  [FlowNode.Pin(30, "2部を選択", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(40, "幕間を選択", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(100, "1部を表示", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "2部を表示", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "幕間を表示", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(129, "アンロック演出開始", FlowNode.PinTypes.Output, 129)]
  [FlowNode.Pin(130, "アンロック演出終了", FlowNode.PinTypes.Output, 130)]
  [AddComponentMenu("UI/StoryPartSelectWindow")]
  [FlowNode.Pin(20, "1部を選択", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  public class StoryPartSelectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D1F9")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400D1FA")]
    private const int PIN_INPUT_SELECT_PART1 = 20;
    [Token(Token = "0x400D1FB")]
    private const int PIN_INPUT_SELECT_PART2 = 30;
    [Token(Token = "0x400D1FC")]
    private const int PIN_INPUT_SELECT_MAKUAI = 40;
    [Token(Token = "0x400D1FD")]
    private const int PIN_OUTPUT_SELECT_PART1 = 100;
    [Token(Token = "0x400D1FE")]
    private const int PIN_OUTPUT_SELECT_PART2 = 110;
    [Token(Token = "0x400D1FF")]
    private const int PIN_OUTPUT_SELECT_MAKUAI = 120;
    [Token(Token = "0x400D200")]
    private const int PIN_OUTPUT_UNLOCK_ANIMATION_START = 129;
    [Token(Token = "0x400D201")]
    private const int PIN_OUTPUT_UNLOCK_ANIMATION_END = 130;
    [Token(Token = "0x400D202")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private StoryPartIcon mPartIcon_1;
    [Token(Token = "0x400D203")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private StoryPartIcon mPartIcon_2;
    [Token(Token = "0x400D204")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private StoryPartIcon mPartIcon_Makuai;
    [Token(Token = "0x400D205")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mCloseButton;
    [Token(Token = "0x400D206")]
    [FieldOffset(Offset = "0x1C")]
    private Dictionary<eStoryPart, bool> mUnlockStates;
    [Token(Token = "0x400D207")]
    [FieldOffset(Offset = "0x20")]
    private eStoryPart mNeedPlayUnlockAnim;

    [Token(Token = "0x600C4F5")]
    [Address(RVA = "0x8D8AB0", Offset = "0x8D78B0", VA = "0x108D8AB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C4F6")]
    [Address(RVA = "0x8D8B20", Offset = "0x8D7920", VA = "0x108D8B20")]
    private void Init()
    {
    }

    [Token(Token = "0x600C4F7")]
    [Address(RVA = "0x8D8F00", Offset = "0x8D7D00", VA = "0x108D8F00")]
    private void OnClickPartButton(eStoryPart part)
    {
    }

    [Token(Token = "0x600C4F8")]
    [Address(RVA = "0x8D9120", Offset = "0x8D7F20", VA = "0x108D9120")]
    private void OnEndUnlockAnimation()
    {
    }

    [Token(Token = "0x600C4F9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StoryPartSelectWindow()
    {
    }
  }
}
