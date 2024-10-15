// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckCrystalEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200132A")]
  [FlowNode.Pin(1, "CreateTips", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(20, "DISABLE", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(10, "ENABLE", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Check", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("FlowNode_CheckCrystalEnable", 13618982)]
  public class FlowNode_CheckCrystalEnable : FlowNode
  {
    [Token(Token = "0x400470F")]
    private const int PIN_IN_CHECK = 0;
    [Token(Token = "0x4004710")]
    private const int PIN_IN_CREATE_TOOL_TIP = 1;
    [Token(Token = "0x4004711")]
    private const int PIN_OUT_ENABLE = 10;
    [Token(Token = "0x4004712")]
    private const int PIN_OUT_DISABLE = 20;
    [Token(Token = "0x4004713")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform TargetRect;
    [Token(Token = "0x4004714")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string SysTextKey;
    [Token(Token = "0x4004715")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float SetPosX;
    [Token(Token = "0x4004716")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private float SetPosY;
    [Token(Token = "0x4004717")]
    private const string CRYSTAL_UNLOCK_TOOL_TIP = "UI/Crystal/CrystalUnlockTooltip";

    [Token(Token = "0x60050C6")]
    [Address(RVA = "0x124F1B0", Offset = "0x124DFB0", VA = "0x1124F1B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60050C7")]
    [Address(RVA = "0x124F020", Offset = "0x124DE20", VA = "0x1124F020")]
    public void CreateCrystalDisablePop()
    {
    }

    [Token(Token = "0x60050C8")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckCrystalEnable()
    {
    }
  }
}
