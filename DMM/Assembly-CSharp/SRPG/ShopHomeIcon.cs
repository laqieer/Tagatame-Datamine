// Decompiled with JetBrains decompiler
// Type: SRPG.ShopHomeIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A9F")]
  [AddComponentMenu("UI/ShopHomeIcon")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  public class ShopHomeIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CFC0")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ShopIcon;
    [Token(Token = "0x400CFC1")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GuerrillaIcon;
    [Token(Token = "0x400CFC2")]
    [FieldOffset(Offset = "0x0")]
    private static ShopHomeIcon mInstance;

    [Token(Token = "0x170019F6")]
    public static ShopHomeIcon Instance
    {
      [Token(Token = "0x600C29F"), Address(RVA = "0x8AE100", Offset = "0x8ACF00", VA = "0x108AE100")] get
      {
        return (ShopHomeIcon) null;
      }
    }

    [Token(Token = "0x600C2A0")]
    [Address(RVA = "0x8ADF70", Offset = "0x8ACD70", VA = "0x108ADF70")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C2A1")]
    [Address(RVA = "0x8ADFB0", Offset = "0x8ACDB0", VA = "0x108ADFB0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C2A2")]
    [Address(RVA = "0x8AE0F0", Offset = "0x8ACEF0", VA = "0x108AE0F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C2A3")]
    [Address(RVA = "0x8AE000", Offset = "0x8ACE00", VA = "0x108AE000")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C2A4")]
    [Address(RVA = "0x8ADF50", Offset = "0x8ACD50", VA = "0x108ADF50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C2A5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopHomeIcon()
    {
    }
  }
}
