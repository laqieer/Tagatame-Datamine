// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryFilterWindow
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
  [Token(Token = "0x20024C1")]
  [FlowNode.Pin(100, "Close", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(3, "Disable All Toggle", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Enable All Toggle", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Save Setting", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/GalleryFilterWindow")]
  public class GalleryFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A7B7")]
    private const int SAVE_SETTING = 1;
    [Token(Token = "0x400A7B8")]
    private const int ENABLE_ALL_TOGGLE = 2;
    [Token(Token = "0x400A7B9")]
    private const int DISABLE_ALL_TOGGLE = 3;
    [Token(Token = "0x400A7BA")]
    private const int OUTPUT_CLOSE = 100;
    [Token(Token = "0x400A7BB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle[] mToggles;
    [Token(Token = "0x400A7BC")]
    [FieldOffset(Offset = "0x10")]
    private GallerySettings mSettings;
    [Token(Token = "0x400A7BD")]
    [FieldOffset(Offset = "0x14")]
    private List<int> mRareFiltters;

    [Token(Token = "0x600A13A")]
    [Address(RVA = "0x633420", Offset = "0x632220", VA = "0x10633420", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A13B")]
    [Address(RVA = "0x633530", Offset = "0x632330", VA = "0x10633530")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A13C")]
    [Address(RVA = "0x633AA0", Offset = "0x6328A0", VA = "0x10633AA0")]
    public GalleryFilterWindow()
    {
    }
  }
}
