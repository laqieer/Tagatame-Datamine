// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueRankingTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025E4")]
  [FlowNode.Pin(1, "表示更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/GvG/GvGLeagueRankingTop")]
  [FlowNode.Pin(100, "自身のリーグ情報取得", FlowNode.PinTypes.Output, 100)]
  public class GvGLeagueRankingTop : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AFF6")]
    private const int PIN_INPUT_INIT = 0;
    [Token(Token = "0x400AFF7")]
    private const int PIN_INPUT_REFRESH = 1;
    [Token(Token = "0x400AFF8")]
    private const int PIN_OUTPUT_REQUEST = 100;
    [Token(Token = "0x400AFF9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private FlowNode_ReqGvGLeague mRequestNode;

    [Token(Token = "0x600A879")]
    [Address(RVA = "0x6B7100", Offset = "0x6B5F00", VA = "0x106B7100", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A87A")]
    [Address(RVA = "0x6B7290", Offset = "0x6B6090", VA = "0x106B7290")]
    private void Init()
    {
    }

    [Token(Token = "0x600A87B")]
    [Address(RVA = "0x6B7320", Offset = "0x6B6120", VA = "0x106B7320")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A87C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGLeagueRankingTop()
    {
    }
  }
}
