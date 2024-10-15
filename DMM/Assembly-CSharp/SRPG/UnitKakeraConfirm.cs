// Decompiled with JetBrains decompiler
// Type: SRPG.UnitKakeraConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C5E")]
  [FlowNode.Pin(1, "Decide", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Decided", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/UnitKakeraConfirm")]
  public class UnitKakeraConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DBA1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400DBA2")]
    [FieldOffset(Offset = "0x10")]
    private UnitKakeraConfirm.OnDecide mOnDecide;

    [Token(Token = "0x600CD8C")]
    [Address(RVA = "0x982F00", Offset = "0x981D00", VA = "0x10982F00")]
    public void Setup(UnitKakeraConfirm.OnDecide onDecide, ItemData[] items)
    {
    }

    [Token(Token = "0x600CD8D")]
    [Address(RVA = "0x982EC0", Offset = "0x981CC0", VA = "0x10982EC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CD8E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitKakeraConfirm()
    {
    }

    [Token(Token = "0x2002C5F")]
    public delegate void OnDecide();
  }
}
