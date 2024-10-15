// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNodeListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025FE")]
  [AddComponentMenu("UI/GvG/GvGNodeListWindow")]
  [FlowNode.Pin(100, "Select Defense", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "Occupy List", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "Attack List", FlowNode.PinTypes.Input, 10)]
  public class GvGNodeListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B0C2")]
    public const int PIN_INPUT_ATTACK = 10;
    [Token(Token = "0x400B0C3")]
    public const int PIN_INPUT_OCCUPY = 11;
    [Token(Token = "0x400B0C4")]
    public const int PIN_INPUT_SELECTDEFENSE = 100;
    [Token(Token = "0x400B0C5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GvGNodeListWindowContent nodeTemplate;
    [Token(Token = "0x400B0C6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mTitleOffense;
    [Token(Token = "0x400B0C7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mTitleDefense;
    [Token(Token = "0x400B0C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray mWindowColor;
    [Token(Token = "0x400B0C9")]
    [FieldOffset(Offset = "0x1C")]
    private GvGNodeListWindow.GVG_OFFENSENODE_TYPE mType;

    [Token(Token = "0x600A946")]
    [Address(RVA = "0x6C6A20", Offset = "0x6C5820", VA = "0x106C6A20")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A947")]
    [Address(RVA = "0x6C69E0", Offset = "0x6C57E0", VA = "0x106C69E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A948")]
    [Address(RVA = "0x6C6F00", Offset = "0x6C5D00", VA = "0x106C6F00")]
    public void onNodeDetail(GameObject obj)
    {
    }

    [Token(Token = "0x600A949")]
    [Address(RVA = "0x6C6E50", Offset = "0x6C5C50", VA = "0x106C6E50")]
    public void onNodeDefenseSetting(GameObject obj)
    {
    }

    [Token(Token = "0x600A94A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGNodeListWindow()
    {
    }

    [Token(Token = "0x20025FF")]
    private enum GVG_OFFENSENODE_TYPE
    {
      [Token(Token = "0x400B0CB")] Attack,
      [Token(Token = "0x400B0CC")] OccupySelf,
    }
  }
}
