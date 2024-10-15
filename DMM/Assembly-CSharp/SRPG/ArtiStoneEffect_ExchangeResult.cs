// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiStoneEffect_ExchangeResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FF2")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "決定", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(21, "閉じる", FlowNode.PinTypes.Output, 21)]
  public class ArtiStoneEffect_ExchangeResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40087EA")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x40087EB")]
    private const int PIN_INPUT_OK = 11;
    [Token(Token = "0x40087EC")]
    private const int PIN_OUTPUT_CLOSE = 21;
    [Token(Token = "0x40087ED")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x40087EE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40087EF")]
    [FieldOffset(Offset = "0x14")]
    private ArtiStoneEffect_ExchangeResultModel mModel;

    [Token(Token = "0x170012DF")]
    public ArtiStoneEffect_ExchangeResultModel Model
    {
      [Token(Token = "0x60083E2"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (ArtiStoneEffect_ExchangeResultModel) null;
      }
    }

    [Token(Token = "0x60083E3")]
    [Address(RVA = "0x447500", Offset = "0x446300", VA = "0x10447500", Slot = "4")]
    public void Activated(int pin)
    {
    }

    [Token(Token = "0x60083E4")]
    [Address(RVA = "0x447600", Offset = "0x446400", VA = "0x10447600")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60083E5")]
    [Address(RVA = "0x447540", Offset = "0x446340", VA = "0x10447540")]
    public void InitializeModel(ItemParam itemParam, int num)
    {
    }

    [Token(Token = "0x60083E6")]
    [Address(RVA = "0x447870", Offset = "0x446670", VA = "0x10447870")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60083E7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_ExchangeResult()
    {
    }
  }
}
