// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DownloadTowerMapSets
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
  [Token(Token = "0x20013C7")]
  [FlowNode.Pin(0, "ダウンロード開始", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Tower/DownloadTowerMapSets", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_DownloadTowerMapSets : FlowNode
  {
    [Token(Token = "0x4004941")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int DownloadAssetNums;

    [Token(Token = "0x17000911")]
    public int DownloadAssetNum
    {
      [Token(Token = "0x60052C6"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60052C7")]
    [Address(RVA = "0x1279D50", Offset = "0x1278B50", VA = "0x11279D50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60052C8")]
    [Address(RVA = "0x1279BD0", Offset = "0x12789D0", VA = "0x11279BD0")]
    private IEnumerator DownloadFloorParams() => (IEnumerator) null;

    [Token(Token = "0x60052C9")]
    [Address(RVA = "0x1279B60", Offset = "0x1278960", VA = "0x11279B60")]
    private IEnumerator DownloadFloorParamAsync() => (IEnumerator) null;

    [Token(Token = "0x60052CA")]
    [Address(RVA = "0x1279C40", Offset = "0x1278A40", VA = "0x11279C40")]
    public static void DownloadMapSets(List<TowerFloorParam> floorParams)
    {
    }

    [Token(Token = "0x60052CB")]
    [Address(RVA = "0x1279E30", Offset = "0x1278C30", VA = "0x11279E30")]
    public FlowNode_DownloadTowerMapSets()
    {
    }
  }
}
