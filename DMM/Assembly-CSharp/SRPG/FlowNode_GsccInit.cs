// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GsccInit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013FF")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GscSystem/GsccInit", 32741)]
  [FlowNode.Pin(100, "Start Online", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1001, "Different Assets", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(101, "Start Offline", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(14, "直接起動している", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(10, "Success Online", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Success Offline", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Reset to Title", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(13, "バージョンが古い", FlowNode.PinTypes.Output, 13)]
  public class FlowNode_GsccInit : FlowNode
  {
    [Token(Token = "0x60053A7")]
    [Address(RVA = "0x1282D10", Offset = "0x1281B10", VA = "0x11282D10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053A8")]
    [Address(RVA = "0x1283300", Offset = "0x1282100", VA = "0x11283300")]
    private void Update()
    {
    }

    [Token(Token = "0x60053A9")]
    [Address(RVA = "0x1283160", Offset = "0x1281F60", VA = "0x11283160")]
    private void Success()
    {
    }

    [Token(Token = "0x60053AA")]
    [Address(RVA = "0x1282F80", Offset = "0x1281D80", VA = "0x11282F80")]
    public static bool SettingAssets(string version, string version_ex) => new bool();

    [Token(Token = "0x60053AB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GsccInit()
    {
    }
  }
}
