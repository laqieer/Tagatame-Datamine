// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GachaSimpleAnimFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013F0")]
  [FlowNode.Pin(1, "簡易演出フラグをOFF", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "簡易演出フラグ更新終了", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(10, "簡易演出フラグ状態確認", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "簡易演出フラグがON", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "簡易演出フラグがOFF", FlowNode.PinTypes.Output, 12)]
  [FlowNode.NodeType("System/Gacha/SimpleAnimFlag", 32741)]
  [FlowNode.Pin(0, "簡易演出フラグをON", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_GachaSimpleAnimFlag : FlowNode
  {
    [Token(Token = "0x40049E0")]
    private const int PIN_IN_SET_SIMPLE_ANIM_ON = 0;
    [Token(Token = "0x40049E1")]
    private const int PIN_IN_SET_SIMPLE_ANIM_OFF = 1;
    [Token(Token = "0x40049E2")]
    private const int PIN_OT_SET_SIMPLE_ANIM = 2;
    [Token(Token = "0x40049E3")]
    private const int PIN_IN_IS_SIMPLE_ANIM = 10;
    [Token(Token = "0x40049E4")]
    private const int PIN_OT_IS_SIMPLE_ANIM_ON = 11;
    [Token(Token = "0x40049E5")]
    private const int PIN_OT_IS_SIMPLE_ANIM_OFF = 12;
    [Token(Token = "0x40049E6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GachaResultThumbnailWindow m_Window;

    [Token(Token = "0x6005381")]
    [Address(RVA = "0x12811F0", Offset = "0x127FFF0", VA = "0x112811F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005382")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GachaSimpleAnimFlag()
    {
    }
  }
}
