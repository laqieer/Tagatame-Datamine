// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026DA")]
  [AddComponentMenu("UI/LimitedShopWindow")]
  [FlowNode.Pin(10, "換金", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "退店", FlowNode.PinTypes.Output, 11)]
  public class LimitedShopWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B6AB")]
    [FieldOffset(Offset = "0xC")]
    public RawImage ImgBackGround;
    [Token(Token = "0x400B6AC")]
    [FieldOffset(Offset = "0x10")]
    public RawImage ImgNPC;
    [Token(Token = "0x400B6AD")]
    [FieldOffset(Offset = "0x14")]
    [Space(16f)]
    public ImageArray NamePlateImages;
    [Token(Token = "0x400B6AE")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ImgPathPrefix;

    [Token(Token = "0x600ADFB")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600ADFC")]
    [Address(RVA = "0x71FE50", Offset = "0x71EC50", VA = "0x1071FE50")]
    private void Start()
    {
    }

    [Token(Token = "0x600ADFD")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ADFE")]
    [Address(RVA = "0x71FCE0", Offset = "0x71EAE0", VA = "0x1071FCE0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600ADFF")]
    [Address(RVA = "0x5E30A0", Offset = "0x5E1EA0", VA = "0x105E30A0")]
    private bool OnGoOutShop() => new bool();

    [Token(Token = "0x600AE00")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LimitedShopWindow()
    {
    }

    [Token(Token = "0x600AE01")]
    [Address(RVA = "0x720020", Offset = "0x71EE20", VA = "0x10720020")]
    static LimitedShopWindow()
    {
    }
  }
}
