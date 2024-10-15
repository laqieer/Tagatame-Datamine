// Decompiled with JetBrains decompiler
// Type: SRPG.ShopSellConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AA6")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/ShopSellConfirmWindow")]
  public class ShopSellConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CFE2")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400CFE3")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400CFE4")]
    [FieldOffset(Offset = "0x14")]
    public Text TxtCaution;
    [Token(Token = "0x400CFE5")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mSellItems;

    [Token(Token = "0x600C2BC")]
    [Address(RVA = "0x8B0C60", Offset = "0x8AFA60", VA = "0x108B0C60")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C2BD")]
    [Address(RVA = "0x8B1070", Offset = "0x8AFE70", VA = "0x108B1070")]
    private void Start()
    {
    }

    [Token(Token = "0x600C2BE")]
    [Address(RVA = "0x8B0C40", Offset = "0x8AFA40", VA = "0x108B0C40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C2BF")]
    [Address(RVA = "0x8B0CF0", Offset = "0x8AFAF0", VA = "0x108B0CF0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C2C0")]
    [Address(RVA = "0x8B1080", Offset = "0x8AFE80", VA = "0x108B1080")]
    public ShopSellConfirmWindow()
    {
    }
  }
}
