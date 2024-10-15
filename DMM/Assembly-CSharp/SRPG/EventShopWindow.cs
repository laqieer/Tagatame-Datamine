// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopWindow
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
  [Token(Token = "0x200239A")]
  [FlowNode.Pin(10, "換金", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "退店", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("UI/EventShopWindow")]
  public class EventShopWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A08D")]
    [FieldOffset(Offset = "0xC")]
    public RawImage ImgBackGround;
    [Token(Token = "0x400A08E")]
    [FieldOffset(Offset = "0x10")]
    public RawImage ImgNPC;
    [Token(Token = "0x400A08F")]
    [FieldOffset(Offset = "0x14")]
    public Text TxtHaveCoin;
    [Token(Token = "0x400A090")]
    [FieldOffset(Offset = "0x18")]
    [Space(16f)]
    public ImageArray NamePlateImages;
    [Token(Token = "0x400A091")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ImgPathPrefix;
    [Token(Token = "0x400A092")]
    [FieldOffset(Offset = "0x1C")]
    private List<EventShopInfo> mEnableEventShopList;
    [Token(Token = "0x400A093")]
    [FieldOffset(Offset = "0x4")]
    private static EventShopWindow mInstance;

    [Token(Token = "0x17001563")]
    public List<EventShopInfo> EnableEventShopList
    {
      [Token(Token = "0x60099EA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<EventShopInfo>) null;
      }
    }

    [Token(Token = "0x17001564")]
    public static EventShopWindow Instance
    {
      [Token(Token = "0x60099EB"), Address(RVA = "0x5E34D0", Offset = "0x5E22D0", VA = "0x105E34D0")] get
      {
        return (EventShopWindow) null;
      }
    }

    [Token(Token = "0x60099EC")]
    [Address(RVA = "0x5E2E00", Offset = "0x5E1C00", VA = "0x105E2E00")]
    private void Awake()
    {
    }

    [Token(Token = "0x60099ED")]
    [Address(RVA = "0x5E3280", Offset = "0x5E2080", VA = "0x105E3280")]
    private void Start()
    {
    }

    [Token(Token = "0x60099EE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60099EF")]
    [Address(RVA = "0x5E2EF0", Offset = "0x5E1CF0", VA = "0x105E2EF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60099F0")]
    [Address(RVA = "0x5E30A0", Offset = "0x5E1EA0", VA = "0x105E30A0")]
    private bool OnGoOutShop() => new bool();

    [Token(Token = "0x60099F1")]
    [Address(RVA = "0x5E2D50", Offset = "0x5E1B50", VA = "0x105E2D50")]
    public void AddEnableEventShopList(JSON_ShopListArray json)
    {
    }

    [Token(Token = "0x60099F2")]
    [Address(RVA = "0x5E30C0", Offset = "0x5E1EC0", VA = "0x105E30C0")]
    public void SetEnableEventShopList(JSON_ShopListArray.Shops[] shops_array)
    {
    }

    [Token(Token = "0x60099F3")]
    [Address(RVA = "0x5E3460", Offset = "0x5E2260", VA = "0x105E3460")]
    public EventShopWindow()
    {
    }

    [Token(Token = "0x60099F4")]
    [Address(RVA = "0x5E3410", Offset = "0x5E2210", VA = "0x105E3410")]
    static EventShopWindow()
    {
    }
  }
}
