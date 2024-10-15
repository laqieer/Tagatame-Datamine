// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UpdatePlayerBuffs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F9")]
  [FlowNode.Pin(11, "Calc Finish", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(2, "Update PlayerBUffsの後のステータス更新も", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Finish", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("Player/UpdatePlayerBuffs", 32741)]
  [FlowNode.Pin(1, "Update PlayerBuffs", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_UpdatePlayerBuffs : FlowNode
  {
    [Token(Token = "0x4005655")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int CalcCount;
    [Token(Token = "0x4005656")]
    protected const int PIN_IN_UPDATE = 1;
    [Token(Token = "0x4005657")]
    protected const int PIN_IN_UPDATE_AND_STATUS = 2;
    [Token(Token = "0x4005658")]
    protected const int PIN_OUT_FINISH = 10;
    [Token(Token = "0x4005659")]
    protected const int PIN_OUT_CALCFINISH = 11;

    [Token(Token = "0x60060F1")]
    [Address(RVA = "0x136D9F0", Offset = "0x136C7F0", VA = "0x1136D9F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060F2")]
    [Address(RVA = "0x136DB10", Offset = "0x136C910", VA = "0x1136DB10")]
    private IEnumerator UnitCalc() => (IEnumerator) null;

    [Token(Token = "0x60060F3")]
    [Address(RVA = "0x1279E30", Offset = "0x1278C30", VA = "0x11279E30")]
    public FlowNode_UpdatePlayerBuffs()
    {
    }
  }
}
