// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ExecTutorialGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013DF")]
  [FlowNode.Pin(12, "Success(引き直し確定)", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(13, "Pending(保留中の召喚がある)", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Gacha/ExecTutorialGacha", 32741)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Request(チュートリアル引き直し確定)", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ExecTutorialGacha : FlowNode_Network
  {
    [Token(Token = "0x40049AA")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x40049AB")]
    private const int PIN_IN_DECISION = 1;
    [Token(Token = "0x40049AC")]
    private const int PIN_OT_SUCCESS = 10;
    [Token(Token = "0x40049AD")]
    private const int PIN_OT_FAILED = 11;
    [Token(Token = "0x40049AE")]
    private const int PIN_OT_SUCCESS_DECISION_REDRAW = 12;
    [Token(Token = "0x40049AF")]
    private const int PIN_OT_PENDING = 13;
    [Token(Token = "0x40049B0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string TutorialGachaID;

    [Token(Token = "0x1700091D")]
    private FlowNode_ExecTutorialGacha.ExecType API
    {
      [Token(Token = "0x6005337"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new FlowNode_ExecTutorialGacha.ExecType();
      }
      [Token(Token = "0x6005338"), Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")] set
      {
      }
    }

    [Token(Token = "0x6005339")]
    [Address(RVA = "0x127E1D0", Offset = "0x127CFD0", VA = "0x1127E1D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600533A")]
    [Address(RVA = "0x127E400", Offset = "0x127D200", VA = "0x1127E400", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600533B")]
    [Address(RVA = "0x127E140", Offset = "0x127CF40", VA = "0x1127E140")]
    private IEnumerator AsyncDownload(UnitParam _uparam) => (IEnumerator) null;

    [Token(Token = "0x600533C")]
    [Address(RVA = "0x127E890", Offset = "0x127D690", VA = "0x1127E890")]
    private void Success()
    {
    }

    [Token(Token = "0x600533D")]
    [Address(RVA = "0x127E1B0", Offset = "0x127CFB0", VA = "0x1127E1B0")]
    private void Failure()
    {
    }

    [Token(Token = "0x600533E")]
    [Address(RVA = "0x127E8C0", Offset = "0x127D6C0", VA = "0x1127E8C0")]
    public FlowNode_ExecTutorialGacha()
    {
    }

    [Token(Token = "0x20013E0")]
    private enum ExecType : byte
    {
      [Token(Token = "0x40049B3")] NONE,
      [Token(Token = "0x40049B4")] DEFAULT,
      [Token(Token = "0x40049B5")] DECISION,
    }
  }
}
