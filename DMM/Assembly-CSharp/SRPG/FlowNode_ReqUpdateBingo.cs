// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUpdateBingo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015DF")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "開催期間外の報酬受け取り", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqBingo/ReqUpdateBingo", 32741)]
  public class FlowNode_ReqUpdateBingo : FlowNode_Network
  {
    [Token(Token = "0x4004F71")]
    public const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004F72")]
    public const int PIN_IN_SUCCESS = 1;
    [Token(Token = "0x4004F73")]
    public const int PIN_IN_OUT_RANGE_GET_REWARD = 100;
    [Token(Token = "0x4004F74")]
    [FieldOffset(Offset = "0x20")]
    protected List<TrophyParam> mTrophyParam;
    [Token(Token = "0x4004F75")]
    [FieldOffset(Offset = "0x24")]
    protected int mLevelOld;
    [Token(Token = "0x4004F76")]
    [FieldOffset(Offset = "0x28")]
    public GameObject RewardWindow;
    [Token(Token = "0x4004F77")]
    [FieldOffset(Offset = "0x2C")]
    public string ReviewURL_Android;
    [Token(Token = "0x4004F78")]
    [FieldOffset(Offset = "0x30")]
    public string ReviewURL_iOS;
    [Token(Token = "0x4004F79")]
    [FieldOffset(Offset = "0x34")]
    public string ReviewURL_Generic;
    [Token(Token = "0x4004F7A")]
    [FieldOffset(Offset = "0x38")]
    public string ReviewURL_Twitter;

    [Token(Token = "0x60059E2")]
    [Address(RVA = "0x12E5E80", Offset = "0x12E4C80", VA = "0x112E5E80")]
    private void OnOverItemAmount()
    {
    }

    [Token(Token = "0x60059E3")]
    [Address(RVA = "0x12E59E0", Offset = "0x12E47E0", VA = "0x112E59E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059E4")]
    [Address(RVA = "0x12E63C0", Offset = "0x12E51C0", VA = "0x112E63C0")]
    protected void Success()
    {
    }

    [Token(Token = "0x60059E5")]
    [Address(RVA = "0x12E5F80", Offset = "0x12E4D80", VA = "0x112E5F80", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059E6")]
    [Address(RVA = "0x305F60", Offset = "0x304D60", VA = "0x10305F60")]
    private void OnErrorDialogClosed(GameObject dialog)
    {
    }

    [Token(Token = "0x60059E7")]
    [Address(RVA = "0x12E7060", Offset = "0x12E5E60", VA = "0x112E7060")]
    public FlowNode_ReqUpdateBingo()
    {
    }

    [Token(Token = "0x20015E0")]
    [MessagePackObject(true)]
    public class MP_UpdateBingoResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004F7B")]
      [FieldOffset(Offset = "0x28")]
      public Json_PlayerDataAll body;

      [Token(Token = "0x60059EA")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_UpdateBingoResponse()
      {
      }
    }
  }
}
