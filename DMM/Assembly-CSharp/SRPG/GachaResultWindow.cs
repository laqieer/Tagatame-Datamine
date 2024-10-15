// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002450")]
  [FlowNode.Pin(0, "Setup", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Refresh", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/GachaResultWindow")]
  public class GachaResultWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A512")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ThumbnailListWindow;
    [Token(Token = "0x400A513")]
    [FieldOffset(Offset = "0x10")]
    public Button BackButton;
    [Token(Token = "0x400A514")]
    [FieldOffset(Offset = "0x14")]
    private bool Initalized;
    [Token(Token = "0x400A515")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TwitterMessage Twitter_iOS;
    [Token(Token = "0x400A516")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private TwitterMessage Twitter_Android;

    [Token(Token = "0x6009EAE")]
    [Address(RVA = "0x6134C0", Offset = "0x6122C0", VA = "0x106134C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009EAF")]
    [Address(RVA = "0x613730", Offset = "0x612530", VA = "0x10613730")]
    private void Start()
    {
    }

    [Token(Token = "0x6009EB0")]
    [Address(RVA = "0x6134E0", Offset = "0x6122E0", VA = "0x106134E0")]
    private void OnCloseWindow(Button button)
    {
    }

    [Token(Token = "0x6009EB1")]
    [Address(RVA = "0x613520", Offset = "0x612320", VA = "0x10613520")]
    private void SetUp()
    {
    }

    [Token(Token = "0x6009EB2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaResultWindow()
    {
    }
  }
}
