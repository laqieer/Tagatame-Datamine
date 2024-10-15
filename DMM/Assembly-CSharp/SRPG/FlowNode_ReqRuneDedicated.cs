// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRuneDedicated
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001837")]
  [AddComponentMenu("")]
  [FlowNode.Pin(22, "NotHaveRune", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(21, "NotEnoughCost", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Rune/Req/Dedicated", 32741)]
  public class FlowNode_ReqRuneDedicated : FlowNode_Network
  {
    [Token(Token = "0x40056DA")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40056DB")]
    protected const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x40056DC")]
    protected const int PIN_OUT_RUNE_NOT_ENOUGH_COST = 21;
    [Token(Token = "0x40056DD")]
    protected const int PIN_OUT_RUNE_NOT_HAVE_RUNE = 22;
    [Token(Token = "0x40056DE")]
    public const string KEY_DEDICATED_UNIT_ID = "KEY_DEDICATED_UNIT_ID";
    [Token(Token = "0x40056DF")]
    public const string KEY_DEDICATED_RUNE_ID = "KEY_DEDICATED_RUNE_ID";
    [Token(Token = "0x40056E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour svb;

    [Token(Token = "0x60061B7")]
    [Address(RVA = "0x13655C0", Offset = "0x13643C0", VA = "0x113655C0")]
    public ReqRuneDedicated.RequestParam CreateRequestParam(SerializeValueList valueList)
    {
      return (ReqRuneDedicated.RequestParam) null;
    }

    [Token(Token = "0x60061B8")]
    [Address(RVA = "0x13658C0", Offset = "0x13646C0", VA = "0x113658C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60061B9")]
    [Address(RVA = "0x13656D0", Offset = "0x13644D0", VA = "0x113656D0", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x60061BA")]
    [Address(RVA = "0x1365E60", Offset = "0x1364C60", VA = "0x11365E60")]
    private void Success()
    {
    }

    [Token(Token = "0x60061BB")]
    [Address(RVA = "0x1365940", Offset = "0x1364740", VA = "0x11365940", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60061BC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRuneDedicated()
    {
    }

    [Token(Token = "0x2001838")]
    [MessagePackObject(true)]
    public class MP_Response : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40056E1")]
      [FieldOffset(Offset = "0x28")]
      public ReqRuneDedicated.Response body;

      [Token(Token = "0x60061BF")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response()
      {
      }
    }
  }
}
