// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PublicInfoBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001730")]
  [FlowNode.Pin(101, "バッジON", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "バッジフラグ確認", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Home/PublicInfoBadge", 32741)]
  [FlowNode.Pin(10, "BADGE FLAG SET ON", FlowNode.PinTypes.Input, 201)]
  [FlowNode.Pin(102, "バッジOFF", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(11, "BADGE FLAG SET OFF", FlowNode.PinTypes.Input, 202)]
  [AddComponentMenu("")]
  public class FlowNode_PublicInfoBadge : FlowNode
  {
    [Token(Token = "0x4005371")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x4005372")]
    private const int PIN_IN_BADGE_FLAG_ON = 10;
    [Token(Token = "0x4005373")]
    private const int PIN_IN_BADGE_FLAG_OFF = 11;
    [Token(Token = "0x4005374")]
    private const int PIN_OUT_BADGE_ON = 101;
    [Token(Token = "0x4005375")]
    private const int PIN_OUT_BADGE_OFF = 102;

    [Token(Token = "0x6005E5C")]
    [Address(RVA = "0x1319A70", Offset = "0x1318870", VA = "0x11319A70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005E5D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PublicInfoBadge()
    {
    }
  }
}
