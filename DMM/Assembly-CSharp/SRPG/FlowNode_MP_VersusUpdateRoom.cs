// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusUpdateRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F5")]
  [FlowNode.Pin(2, "Reflesh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "Finish", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "AudienceOn", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "AudienceOff", FlowNode.PinTypes.Input, 12)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/Versus/UpdateRoomParam", 32741)]
  [FlowNode.Pin(1, "Update", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_VersusUpdateRoom : FlowNode
  {
    [Token(Token = "0x4005648")]
    private const int PIN_IN_UPDATE = 1;
    [Token(Token = "0x4005649")]
    private const int PIN_IN_REFRESH = 2;
    [Token(Token = "0x400564A")]
    private const int PIN_IN_AUDIENCE_ON = 11;
    [Token(Token = "0x400564B")]
    private const int PIN_IN_AUDIENCE_OFF = 12;
    [Token(Token = "0x400564C")]
    private const int PIN_OUT_FINISH = 101;

    [Token(Token = "0x60060E6")]
    [Address(RVA = "0x135AE00", Offset = "0x1359C00", VA = "0x1135AE00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060E7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusUpdateRoom()
    {
    }
  }
}
