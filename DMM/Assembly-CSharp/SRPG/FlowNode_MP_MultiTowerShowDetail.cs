// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_MultiTowerShowDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017AF")]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/MultiTower/ShowDetail", 32741)]
  [FlowNode.Pin(2, "Close", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  public class FlowNode_MP_MultiTowerShowDetail : FlowNode
  {
    [Token(Token = "0x4005554")]
    private const int PIN_INPUT_START = 1;
    [Token(Token = "0x4005555")]
    private const int PIN_INPUT_CLOSE = 2;
    [Token(Token = "0x4005556")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject detailObjectPrefab;
    [Token(Token = "0x4005557")]
    [FieldOffset(Offset = "0x1C")]
    private GameObject createdDetailObject;

    [Token(Token = "0x600600C")]
    [Address(RVA = "0x134D970", Offset = "0x134C770", VA = "0x1134D970", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600600D")]
    [Address(RVA = "0x134DA00", Offset = "0x134C800", VA = "0x1134DA00")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x600600E")]
    [Address(RVA = "0x134D8F0", Offset = "0x134C6F0", VA = "0x1134D8F0")]
    private void Close()
    {
    }

    [Token(Token = "0x600600F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_MultiTowerShowDetail()
    {
    }
  }
}
