// Decompiled with JetBrains decompiler
// Type: SRPG.ItemGetUnlockWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002657")]
  [FlowNode.Pin(101, "Selected Quest", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/ItemGetUnlockWindow")]
  [FlowNode.Pin(100, "Unlock", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class ItemGetUnlockWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B346")]
    [FieldOffset(Offset = "0xC")]
    private ItemParam UnlockItem;

    [Token(Token = "0x600AB2F")]
    [Address(RVA = "0x6E5B50", Offset = "0x6E4950", VA = "0x106E5B50")]
    private void Start()
    {
    }

    [Token(Token = "0x600AB30")]
    [Address(RVA = "0x6E59C0", Offset = "0x6E47C0", VA = "0x106E59C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AB31")]
    [Address(RVA = "0x6E59E0", Offset = "0x6E47E0", VA = "0x106E59E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AB32")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ItemGetUnlockWindow()
    {
    }
  }
}
