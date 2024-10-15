// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueRankEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025DB")]
  [FlowNode.Pin(1, "start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "RankUp", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "RankDown", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(100, "強制終了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GvG/GvGLeagueRankEffect")]
  public class GvGLeagueRankEffect : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AFB5")]
    public const int PIN_INPUT_START = 1;
    [Token(Token = "0x400AFB6")]
    public const int PIN_OUTPUT_RANKUP = 10;
    [Token(Token = "0x400AFB7")]
    public const int PIN_OUTPUT_RANKDOWN = 11;
    [Token(Token = "0x400AFB8")]
    public const int PIN_OUTPUT_FINISH = 100;
    [Token(Token = "0x400AFB9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRankUpRoot;
    [Token(Token = "0x400AFBA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRankDownRoot;
    [Token(Token = "0x400AFBB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRankDownFrom;
    [Token(Token = "0x400AFBC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRankDownTo;
    [Token(Token = "0x400AFBD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRankUpIcon;
    [Token(Token = "0x400AFBE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRankUpText;
    [Token(Token = "0x400AFBF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRankUpMsg;

    [Token(Token = "0x600A84D")]
    [Address(RVA = "0x6B69F0", Offset = "0x6B57F0", VA = "0x106B69F0")]
    public void Initialize(bool isRankUp)
    {
    }

    [Token(Token = "0x600A84E")]
    [Address(RVA = "0x6B68C0", Offset = "0x6B56C0", VA = "0x106B68C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A84F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGLeagueRankEffect()
    {
    }
  }
}
