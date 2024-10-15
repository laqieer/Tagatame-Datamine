// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultPieceDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002444")]
  [FlowNode.Pin(2, "Refreshed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(100, "Close", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GachaResultPieceDetail")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class GachaResultPieceDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A456")]
    [FieldOffset(Offset = "0xC")]
    private readonly int OUT_CLOSE_DETAIL;
    [Token(Token = "0x400A457")]
    [FieldOffset(Offset = "0x10")]
    public GameObject PieceInfo;
    [Token(Token = "0x400A458")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Bg;
    [Token(Token = "0x400A459")]
    [FieldOffset(Offset = "0x18")]
    private ItemData mCurrentPiece;
    [Token(Token = "0x400A45A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button BackBtn;

    [Token(Token = "0x6009E36")]
    [Address(RVA = "0x60BC30", Offset = "0x60AA30", VA = "0x1060BC30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009E37")]
    [Address(RVA = "0x60BF00", Offset = "0x60AD00", VA = "0x1060BF00")]
    private void Start()
    {
    }

    [Token(Token = "0x6009E38")]
    [Address(RVA = "0x60BC50", Offset = "0x60AA50", VA = "0x1060BC50")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009E39")]
    [Address(RVA = "0x60A890", Offset = "0x609690", VA = "0x1060A890")]
    private void OnCloseDetail()
    {
    }

    [Token(Token = "0x6009E3A")]
    [Address(RVA = "0x60BE30", Offset = "0x60AC30", VA = "0x1060BE30")]
    public void Setup(int _index)
    {
    }

    [Token(Token = "0x6009E3B")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void Setup(ItemData _data)
    {
    }

    [Token(Token = "0x6009E3C")]
    [Address(RVA = "0x60BD80", Offset = "0x60AB80", VA = "0x1060BD80")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009E3D")]
    [Address(RVA = "0x60AD20", Offset = "0x609B20", VA = "0x1060AD20")]
    public GachaResultPieceDetail()
    {
    }
  }
}
