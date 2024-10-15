// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisBossExtraLockPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001686")]
  [FlowNode.NodeType("Genesis/ボスロックポップ", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Out", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_GenesisBossExtraLockPopup : FlowNode
  {
    [Token(Token = "0x40051E6")]
    private const int PIN_IN = 1;
    [Token(Token = "0x40051E7")]
    private const int PIN_OUT = 11;
    [Token(Token = "0x40051E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestDifficulties QuestDifficulty;
    [Token(Token = "0x40051E9")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private bool IsUnlockCondDisp;
    [Token(Token = "0x40051EA")]
    [FieldOffset(Offset = "0x1A")]
    private bool mIsRunning;

    [Token(Token = "0x6005C67")]
    [Address(RVA = "0x12488C0", Offset = "0x12476C0", VA = "0x112488C0", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6005C68")]
    [Address(RVA = "0x1306FC0", Offset = "0x1305DC0", VA = "0x11306FC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C69")]
    [Address(RVA = "0x1307040", Offset = "0x1305E40", VA = "0x11307040")]
    private IEnumerator PopupMessageOpen() => (IEnumerator) null;

    [Token(Token = "0x6005C6A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisBossExtraLockPopup()
    {
    }
  }
}
