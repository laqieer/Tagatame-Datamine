// Decompiled with JetBrains decompiler
// Type: SRPG.UnitKakuseiWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C69")]
  [FlowNode.Pin(0, "表示を更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/UnitKakuseiWindow")]
  [FlowNode.Pin(100, "ユニットが覚醒した", FlowNode.PinTypes.Output, 100)]
  public class UnitKakuseiWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DBE1")]
    [FieldOffset(Offset = "0xC")]
    public UnitKakuseiWindow.KakuseiWindowEvent OnKakuseiAccept;
    [Token(Token = "0x400DBE2")]
    [FieldOffset(Offset = "0x10")]
    public UnitData Unit;
    [Token(Token = "0x400DBE3")]
    [FieldOffset(Offset = "0x14")]
    public JobParam UnlockJobParam;
    [Token(Token = "0x400DBE4")]
    [FieldOffset(Offset = "0x18")]
    public Button KakuseiButton;
    [Token(Token = "0x400DBE5")]
    [FieldOffset(Offset = "0x1C")]
    public Text KakeraMsg;
    [Token(Token = "0x400DBE6")]
    [FieldOffset(Offset = "0x20")]
    public Text KakeraCharaMsg;
    [Token(Token = "0x400DBE7")]
    [FieldOffset(Offset = "0x24")]
    public Text KakeraElementMsg;
    [Token(Token = "0x400DBE8")]
    [FieldOffset(Offset = "0x28")]
    public Text KakeraCommonMsg;
    [Token(Token = "0x400DBE9")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject JobUnlock;
    [Token(Token = "0x400DBEA")]
    [FieldOffset(Offset = "0x30")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400DBEB")]
    [FieldOffset(Offset = "0x34")]
    private ItemParam mElementKakera;
    [Token(Token = "0x400DBEC")]
    [FieldOffset(Offset = "0x38")]
    private ItemParam mCommonKakera;

    [Token(Token = "0x600CDC5")]
    [Address(RVA = "0x9890A0", Offset = "0x987EA0", VA = "0x109890A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CDC6")]
    [Address(RVA = "0x989B20", Offset = "0x988920", VA = "0x10989B20")]
    private void Start()
    {
    }

    [Token(Token = "0x600CDC7")]
    [Address(RVA = "0x9890C0", Offset = "0x987EC0", VA = "0x109890C0")]
    private void OnKakuseiClick()
    {
    }

    [Token(Token = "0x600CDC8")]
    [Address(RVA = "0x988F60", Offset = "0x987D60", VA = "0x10988F60")]
    private void AcceptElementKakera(GameObject go)
    {
    }

    [Token(Token = "0x600CDC9")]
    [Address(RVA = "0x988EE0", Offset = "0x987CE0", VA = "0x10988EE0")]
    private void AcceptCommonKakera(GameObject go)
    {
    }

    [Token(Token = "0x600CDCA")]
    [Address(RVA = "0x988EE0", Offset = "0x987CE0", VA = "0x10988EE0")]
    private void KakuseiAccept()
    {
    }

    [Token(Token = "0x600CDCB")]
    [Address(RVA = "0x9892B0", Offset = "0x9880B0", VA = "0x109892B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600CDCC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitKakuseiWindow()
    {
    }

    [Token(Token = "0x2002C6A")]
    public delegate void KakuseiWindowEvent();
  }
}
