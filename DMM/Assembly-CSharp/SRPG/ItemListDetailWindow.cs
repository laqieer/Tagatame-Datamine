// Decompiled with JetBrains decompiler
// Type: SRPG.ItemListDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200265D")]
  [FlowNode.Pin(1, "Reload", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/ItemListDetailWindow")]
  public class ItemListDetailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B369")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mItemLimitedText;

    [Token(Token = "0x600AB55")]
    [Address(RVA = "0x6E73D0", Offset = "0x6E61D0", VA = "0x106E73D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AB56")]
    [Address(RVA = "0x6E7590", Offset = "0x6E6390", VA = "0x106E7590")]
    private void Start()
    {
    }

    [Token(Token = "0x600AB57")]
    [Address(RVA = "0x6E73F0", Offset = "0x6E61F0", VA = "0x106E73F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AB58")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ItemListDetailWindow()
    {
    }
  }
}
