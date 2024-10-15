// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceBossExtraLockPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012C3")]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Out", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Advance/ボスロックポップ", 32741)]
  public class FlowNode_AdvanceBossExtraLockPopup : FlowNode
  {
    [Token(Token = "0x40045F3")]
    private const int PIN_IN = 1;
    [Token(Token = "0x40045F4")]
    private const int PIN_OUT = 11;
    [Token(Token = "0x40045F5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestDifficulties QuestDifficulty;
    [Token(Token = "0x40045F6")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool IsUnlockCondDisp;
    [Token(Token = "0x40045F7")]
    [FieldOffset(Offset = "0x1A")]
    private bool mIsRunning;

    [Token(Token = "0x6004F87")]
    [Address(RVA = "0x12488C0", Offset = "0x12476C0", VA = "0x112488C0", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6004F88")]
    [Address(RVA = "0x12488E0", Offset = "0x12476E0", VA = "0x112488E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004F89")]
    [Address(RVA = "0x1248960", Offset = "0x1247760", VA = "0x11248960")]
    private IEnumerator PopupMessageOpen() => (IEnumerator) null;

    [Token(Token = "0x6004F8A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AdvanceBossExtraLockPopup()
    {
    }
  }
}
