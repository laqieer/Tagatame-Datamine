// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RequestLimitedShopItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015CC")]
  [FlowNode.NodeType("System/Shop/RequestLimitedShopItems", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "Period", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(131, "ポートショップ：ギルド未所属", FlowNode.PinTypes.Output, 131)]
  [AddComponentMenu("")]
  public class FlowNode_RequestLimitedShopItems : FlowNode_Network
  {
    [Token(Token = "0x4004F49")]
    private const int PIN_OUT_PORTSHOP_GUILD_NOTJOINED = 131;
    [Token(Token = "0x4004F4A")]
    public const string ErrorWindowPrefabPath = "e/UI/NetworkErrorWindowEx";

    [Token(Token = "0x600599D")]
    [Address(RVA = "0x12EA200", Offset = "0x12E9000", VA = "0x112EA200", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600599E")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600599F")]
    [Address(RVA = "0x12EA7E0", Offset = "0x12E95E0", VA = "0x112EA7E0")]
    private void Period()
    {
    }

    [Token(Token = "0x60059A0")]
    [Address(RVA = "0x12EA340", Offset = "0x12E9140", VA = "0x112EA340")]
    private void OnPeriod()
    {
    }

    [Token(Token = "0x60059A1")]
    [Address(RVA = "0x12EA480", Offset = "0x12E9280", VA = "0x112EA480", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059A2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_RequestLimitedShopItems()
    {
    }
  }
}
