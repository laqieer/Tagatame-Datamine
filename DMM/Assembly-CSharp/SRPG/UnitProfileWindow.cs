// Decompiled with JetBrains decompiler
// Type: SRPG.UnitProfileWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CE8")]
  [FlowNode.Pin(0, "表示更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/UnitProfileWindow")]
  public class UnitProfileWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DF46")]
    public const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x400DF47")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private string DebugUnitID;
    [Token(Token = "0x400DF48")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [FlexibleArray]
    private Text[] ProfileTexts;
    [Token(Token = "0x400DF49")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text Illustrator;
    [Token(Token = "0x400DF4A")]
    [FieldOffset(Offset = "0x18")]
    private string[] m_ProfileTextFormat;

    [Token(Token = "0x600D100")]
    [Address(RVA = "0x9BF900", Offset = "0x9BE700", VA = "0x109BF900", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D101")]
    [Address(RVA = "0x9BF920", Offset = "0x9BE720", VA = "0x109BF920")]
    private void InitializeProfileTextFormat()
    {
    }

    [Token(Token = "0x600D102")]
    [Address(RVA = "0x9BFE10", Offset = "0x9BEC10", VA = "0x109BFE10")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600D103")]
    [Address(RVA = "0x9BFC80", Offset = "0x9BEA80", VA = "0x109BFC80")]
    private void RefreshProfileText(UnitData unit)
    {
    }

    [Token(Token = "0x600D104")]
    [Address(RVA = "0x9BFB40", Offset = "0x9BE940", VA = "0x109BFB40")]
    private void RefreshIllustratorName(UnitData unit)
    {
    }

    [Token(Token = "0x600D105")]
    [Address(RVA = "0x9BFAC0", Offset = "0x9BE8C0", VA = "0x109BFAC0")]
    private void RefreshGameParameter(UnitData unit)
    {
    }

    [Token(Token = "0x600D106")]
    [Address(RVA = "0x9C0090", Offset = "0x9BEE90", VA = "0x109C0090")]
    public UnitProfileWindow()
    {
    }
  }
}
