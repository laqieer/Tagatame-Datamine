// Decompiled with JetBrains decompiler
// Type: SRPG.PortRankingView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200290A")]
  [FlowNode.Pin(100, "ポート情報を取得", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/CombatPower/PortRankingView")]
  public class PortRankingView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400C5B3")]
    private const int PIN_OUTPUT_OPEN_PORT_INFO = 100;
    [Token(Token = "0x400C5B4")]
    private const string PORT_MODEL_INFO = "PORT_MODEL_INFO";
    [Token(Token = "0x400C5B5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;

    [Token(Token = "0x600B9CF")]
    [Address(RVA = "0x8058B0", Offset = "0x8046B0", VA = "0x108058B0")]
    public void SetUp(PortRankingModel _model)
    {
    }

    [Token(Token = "0x600B9D0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600B9D1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B9D2")]
    [Address(RVA = "0x805780", Offset = "0x804580", VA = "0x10805780")]
    public void OnClickPortDetail()
    {
    }

    [Token(Token = "0x600B9D3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PortRankingView()
    {
    }
  }
}
