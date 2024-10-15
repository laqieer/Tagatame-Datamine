// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UnitViewType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200189A")]
  [AddComponentMenu("")]
  [FlowNode.Pin(104, "Output", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "2Dモードへ変更（変化なしでも反応）", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "3Dモードへ変更（変化なしでも反応）", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(3, "ユニット画像非表示", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(100, "3Dモードへ変化した", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(4, "前回のモードへ戻す", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(2, "ユニット画像表示", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(0, "3Dモードへ変更", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("UnitInventory/UnitViewType", 32741)]
  [FlowNode.Pin(101, "2Dモードへ変化した", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "2Dモードへ変更", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_UnitViewType : FlowNode
  {
    [Token(Token = "0x4005849")]
    private const int PIN_IN_SET_3D_VIEW_MODE = 0;
    [Token(Token = "0x400584A")]
    private const int PIN_IN_SET_2D_VIEW_MODE = 1;
    [Token(Token = "0x400584B")]
    private const int PIN_IN_SET_HIDE_UNIT_IMAGE_MODE = 2;
    [Token(Token = "0x400584C")]
    private const int PIN_IN_SET_SHOW_UNIT_IMAGE_MODE = 3;
    [Token(Token = "0x400584D")]
    private const int PIN_IN_SET_PREV_VIEW_MODE = 4;
    [Token(Token = "0x400584E")]
    private const int PIN_OUT_CHANGED_3D_VIEW_MODE = 100;
    [Token(Token = "0x400584F")]
    private const int PIN_OUT_CHANGED_2D_VIEW_MODE = 101;
    [Token(Token = "0x4005850")]
    private const int PIN_OUT_SET_3D_VIEW_MODE = 102;
    [Token(Token = "0x4005851")]
    private const int PIN_OUT_SET_2D_VIEW_MODE = 103;
    [Token(Token = "0x4005852")]
    private const int PIN_OUT_OUTPUT = 104;
    [Token(Token = "0x4005853")]
    [FieldOffset(Offset = "0x18")]
    private UnitEnhanceV3.eUnitViewType m_ViewMode;
    [Token(Token = "0x4005854")]
    [FieldOffset(Offset = "0x1C")]
    private UnitEnhanceV3.eUnitViewType m_PrevViewMode;
    [Token(Token = "0x4005855")]
    [FieldOffset(Offset = "0x20")]
    private bool m_UnitImageActive;
    [Token(Token = "0x4005856")]
    [FieldOffset(Offset = "0x21")]
    private bool m_PrevUnitImageActive;

    [Token(Token = "0x600630D")]
    [Address(RVA = "0x316410", Offset = "0x315210", VA = "0x10316410", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600630E")]
    [Address(RVA = "0x3165D0", Offset = "0x3153D0", VA = "0x103165D0")]
    private bool SetViewMode(UnitEnhanceV3.eUnitViewType viewMode) => new bool();

    [Token(Token = "0x600630F")]
    [Address(RVA = "0x316500", Offset = "0x315300", VA = "0x10316500")]
    private bool SetUnitImageActive(bool isActive) => new bool();

    [Token(Token = "0x6006310")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_UnitViewType()
    {
    }
  }
}
