// Decompiled with JetBrains decompiler
// Type: SRPG.TutorialGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B97")]
  [FlowNode.Pin(0, "PlayAnim", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "PlayAnim", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "RedrawGacha", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "ShowResult", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "SelectRedraw", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "CancelRedraw", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(11, "RedrawGacha", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "ShowResult", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(13, "CancelRedraw", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(14, "Re PlayAnim", FlowNode.PinTypes.Output, 14)]
  [AddComponentMenu("UI/TutorialGacha")]
  public class TutorialGacha : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D5FB")]
    private const int PIN_IN_PLAY_ANIM = 0;
    [Token(Token = "0x400D5FC")]
    private const int PIN_IN_SHOW_RESULT = 1;
    [Token(Token = "0x400D5FD")]
    private const int PIN_IN_REDRAW_GACHA = 2;
    [Token(Token = "0x400D5FE")]
    private const int PIN_IN_SELECT_REDRAW = 3;
    [Token(Token = "0x400D5FF")]
    private const int PIN_IN_CANCEL_REDRAW = 4;
    [Token(Token = "0x400D600")]
    private const int PIN_OU_PLAY_ANIM = 10;
    [Token(Token = "0x400D601")]
    private const int PIN_OU_REDRAW_GACHA = 11;
    [Token(Token = "0x400D602")]
    private const int PIN_OU_SHOW_RESULT = 12;
    [Token(Token = "0x400D603")]
    private const int PIN_OU_CANCEL_REDRAW = 13;
    [Token(Token = "0x400D604")]
    private const int PIN_OU_RE_PLAY_ANIM = 14;
    [Token(Token = "0x400D605")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [StringIsResourcePath(typeof (GachaController))]
    public string GachaAnimPrefab;
    [Token(Token = "0x400D606")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    public string GachaResultPrefab;
    [Token(Token = "0x400D607")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform UIRoot;
    [Token(Token = "0x400D608")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] ResultOptionObject;
    [Token(Token = "0x400D609")]
    [FieldOffset(Offset = "0x1C")]
    private GachaController m_GachaController;
    [Token(Token = "0x400D60A")]
    [FieldOffset(Offset = "0x20")]
    private GameObject m_GachaResult;

    [Token(Token = "0x600C82B")]
    [Address(RVA = "0x90FFB0", Offset = "0x90EDB0", VA = "0x1090FFB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C82C")]
    [Address(RVA = "0x9102D0", Offset = "0x90F0D0", VA = "0x109102D0")]
    private IEnumerator PlayGachaAsync(int pinID) => (IEnumerator) null;

    [Token(Token = "0x600C82D")]
    [Address(RVA = "0x910340", Offset = "0x90F140", VA = "0x10910340")]
    private bool SetupDropData(UnitParam _unit) => new bool();

    [Token(Token = "0x600C82E")]
    [Address(RVA = "0x910500", Offset = "0x90F300", VA = "0x10910500")]
    private IEnumerator ShowGachaResult() => (IEnumerator) null;

    [Token(Token = "0x600C82F")]
    [Address(RVA = "0x910460", Offset = "0x90F260", VA = "0x10910460")]
    private void SetupOptionObject(bool _enable)
    {
    }

    [Token(Token = "0x600C830")]
    [Address(RVA = "0x9101C0", Offset = "0x90EFC0", VA = "0x109101C0")]
    private void DecideTutorialGacha()
    {
    }

    [Token(Token = "0x600C831")]
    [Address(RVA = "0x910570", Offset = "0x90F370", VA = "0x10910570")]
    public TutorialGacha()
    {
    }
  }
}
