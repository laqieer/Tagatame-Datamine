// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckResonanceTobiraLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001833")]
  [FlowNode.Pin(1, "input", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "制限をかける", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "制限をかけない", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Resonance/CheckResonanceTobiraLevel", 32741)]
  public class FlowNode_CheckResonanceTobiraLevel : FlowNode
  {
    [Token(Token = "0x40056CA")]
    public const string KEY_CHECK_RESONANCE_TOBIRALEVEL_UNITDATA = "KEY_CHECK_RESONANCE_TOBIRALEVEL_UNITDATA";
    [Token(Token = "0x40056CB")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x40056CC")]
    private const int PIN_OUT_YSE = 10;
    [Token(Token = "0x40056CD")]
    private const int PIN_OUT_NO = 11;

    [Token(Token = "0x60061A7")]
    [Address(RVA = "0x1359410", Offset = "0x1358210", VA = "0x11359410", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x60061A8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckResonanceTobiraLevel()
    {
    }
  }
}
