// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002443")]
  [FlowNode.Pin(2, "Refreshed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(100, "Close", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GachaResultItemDetail")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class GachaResultItemDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A451")]
    [FieldOffset(Offset = "0xC")]
    private readonly int OUT_CLOSE_DETAIL;
    [Token(Token = "0x400A452")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemInfo;
    [Token(Token = "0x400A453")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Bg;
    [Token(Token = "0x400A454")]
    [FieldOffset(Offset = "0x18")]
    private ItemData mCurrentItem;
    [Token(Token = "0x400A455")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button CloseBtn;

    [Token(Token = "0x6009E2E")]
    [Address(RVA = "0x60B8B0", Offset = "0x60A6B0", VA = "0x1060B8B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009E2F")]
    [Address(RVA = "0x60BB80", Offset = "0x60A980", VA = "0x1060BB80")]
    private void Start()
    {
    }

    [Token(Token = "0x6009E30")]
    [Address(RVA = "0x60B8D0", Offset = "0x60A6D0", VA = "0x1060B8D0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009E31")]
    [Address(RVA = "0x60A890", Offset = "0x609690", VA = "0x1060A890")]
    private void OnCloseDetail()
    {
    }

    [Token(Token = "0x6009E32")]
    [Address(RVA = "0x60BAB0", Offset = "0x60A8B0", VA = "0x1060BAB0")]
    public void Setup(int _index)
    {
    }

    [Token(Token = "0x6009E33")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void Setup(ItemData _data)
    {
    }

    [Token(Token = "0x6009E34")]
    [Address(RVA = "0x60BA00", Offset = "0x60A800", VA = "0x1060BA00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009E35")]
    [Address(RVA = "0x60AD20", Offset = "0x609B20", VA = "0x1060AD20")]
    public GachaResultItemDetail()
    {
    }
  }
}
