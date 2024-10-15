// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SummonCoinConvertWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001643")]
  [FlowNode.NodeType("UI/SummonCoinConvertWindow")]
  [AddComponentMenu("")]
  public class FlowNode_SummonCoinConvertWindow : FlowNode_GUI
  {
    [Token(Token = "0x40050DD")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GachaCoinChangeWindow.CoinType coinType;

    [Token(Token = "0x6005B86")]
    [Address(RVA = "0x130ED70", Offset = "0x130DB70", VA = "0x1130ED70", Slot = "17")]
    protected override void OnCreatePinActive()
    {
    }

    [Token(Token = "0x6005B87")]
    [Address(RVA = "0x126B2F0", Offset = "0x126A0F0", VA = "0x1126B2F0")]
    public FlowNode_SummonCoinConvertWindow()
    {
    }
  }
}
