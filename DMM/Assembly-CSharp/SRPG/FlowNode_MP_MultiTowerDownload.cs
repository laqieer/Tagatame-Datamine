// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_MultiTowerDownload
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017AC")]
  [FlowNode.NodeType("MultiPlay/MultiTower/Download", 32741)]
  [FlowNode.Pin(0, "Start Download", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_MP_MultiTowerDownload : FlowNode
  {
    [Token(Token = "0x4005549")]
    private const int PIN_IN_START = 0;
    [Token(Token = "0x400554A")]
    private const int PIN_OUT_SUCCESS = 1;

    [Token(Token = "0x6005FFB")]
    [Address(RVA = "0x134D740", Offset = "0x134C540", VA = "0x1134D740", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FFC")]
    [Address(RVA = "0x134D570", Offset = "0x134C370", VA = "0x1134D570")]
    private IEnumerator DownloadFloorParamAsync() => (IEnumerator) null;

    [Token(Token = "0x6005FFD")]
    [Address(RVA = "0x134D5E0", Offset = "0x134C3E0", VA = "0x1134D5E0")]
    public static void DownloadMapSets(List<MultiTowerFloorParam> floorParams)
    {
    }

    [Token(Token = "0x6005FFE")]
    [Address(RVA = "0x134D880", Offset = "0x134C680", VA = "0x1134D880")]
    private IEnumerator RequestDownloadFloors(List<MultiTowerFloorParam> floorParams)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6005FFF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_MultiTowerDownload()
    {
    }
  }
}
