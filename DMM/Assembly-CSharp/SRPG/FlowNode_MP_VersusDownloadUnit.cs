// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusDownloadUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017EA")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/Versus/DownloadUnit", 32741)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "StartAudience", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Error", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Finish", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_MP_VersusDownloadUnit : FlowNode
  {
    [Token(Token = "0x4005620")]
    private const int PIN_IN_START = 0;
    [Token(Token = "0x4005621")]
    private const int PIN_IN_START_AUDIENCE = 1;
    [Token(Token = "0x4005622")]
    private const int PIN_OUT_FINISH = 100;
    [Token(Token = "0x4005623")]
    private const int PIN_OUT_ERROR = 101;

    [Token(Token = "0x60060CC")]
    [Address(RVA = "0x135A4E0", Offset = "0x13592E0", VA = "0x1135A4E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060CD")]
    [Address(RVA = "0x135A330", Offset = "0x1359130", VA = "0x1135A330")]
    private void AddAssets(PhotonPlayerData playerData)
    {
    }

    [Token(Token = "0x60060CE")]
    [Address(RVA = "0x135A470", Offset = "0x1359270", VA = "0x1135A470")]
    private IEnumerator AsyncDownload() => (IEnumerator) null;

    [Token(Token = "0x60060CF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusDownloadUnit()
    {
    }
  }
}
