// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqToolTipSetAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001871")]
  [FlowNode.NodeType("ToolTip/Req/SetAbility", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqToolTipSetAbility : FlowNode_Network
  {
    [Token(Token = "0x40057AD")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40057AE")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40057AF")]
    private const long EMPTY_UID = -1;
    [Token(Token = "0x40057B0")]
    private const long EMPTY_JID = -1;
    [Token(Token = "0x40057B1")]
    [FieldOffset(Offset = "0x20")]
    private SerializeValueList svl;

    [Token(Token = "0x6006282")]
    [Address(RVA = "0x30D600", Offset = "0x30C400", VA = "0x1030D600", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6006283")]
    [Address(RVA = "0x30DE50", Offset = "0x30CC50", VA = "0x1030DE50")]
    private void Success()
    {
    }

    [Token(Token = "0x6006284")]
    [Address(RVA = "0x30D870", Offset = "0x30C670", VA = "0x1030D870", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6006285")]
    [Address(RVA = "0x30DCE0", Offset = "0x30CAE0", VA = "0x1030DCE0")]
    private void Res_UpdateEquippedAbility_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x6006286")]
    [Address(RVA = "0x30DA60", Offset = "0x30C860", VA = "0x1030DA60")]
    private void Res_UpdateEquippedAbility_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x6006287")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqToolTipSetAbility()
    {
    }

    [Token(Token = "0x2001872")]
    [MessagePackObject(true)]
    public class MP_JobAbilityt_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40057B2")]
      [FieldOffset(Offset = "0x28")]
      public ReqJobAbility_OverWrite.Response body;

      [Token(Token = "0x6006288")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_JobAbilityt_OverWriteResponse()
      {
      }
    }
  }
}
