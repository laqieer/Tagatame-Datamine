// Decompiled with JetBrains decompiler
// Type: SRPG.ItemConvertWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002656")]
  [AddComponentMenu("UI/ItemConvertWindow")]
  [FlowNode.Pin(2, "Output", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 0)]
  public class ItemConvertWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B341")]
    [FieldOffset(Offset = "0xC")]
    public Transform ItemLayout;
    [Token(Token = "0x400B342")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400B343")]
    [FieldOffset(Offset = "0x14")]
    public Text ConvertItemName;
    [Token(Token = "0x400B344")]
    [FieldOffset(Offset = "0x18")]
    public Text ConvertItemNum;
    [Token(Token = "0x400B345")]
    [FieldOffset(Offset = "0x1C")]
    public Text ConvertResult;

    [Token(Token = "0x600AB2B")]
    [Address(RVA = "0x6E53F0", Offset = "0x6E41F0", VA = "0x106E53F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AB2C")]
    [Address(RVA = "0x6E5840", Offset = "0x6E4640", VA = "0x106E5840")]
    private void Start()
    {
    }

    [Token(Token = "0x600AB2D")]
    [Address(RVA = "0x6E5420", Offset = "0x6E4220", VA = "0x106E5420")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AB2E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ItemConvertWindow()
    {
    }
  }
}
