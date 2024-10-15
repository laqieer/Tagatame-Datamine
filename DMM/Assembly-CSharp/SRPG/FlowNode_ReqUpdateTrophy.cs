// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUpdateTrophy
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
  [Token(Token = "0x20015E4")]
  [FlowNode.NodeType("Trophy/ReqUpdateTrophy", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqUpdateTrophy : FlowNode_Network
  {
    [Token(Token = "0x4004F80")]
    [FieldOffset(Offset = "0x20")]
    private List<TrophyParam> mTrophyParam;
    [Token(Token = "0x4004F81")]
    [FieldOffset(Offset = "0x24")]
    private int mLevelOld;
    [Token(Token = "0x4004F82")]
    [FieldOffset(Offset = "0x28")]
    private int mUnitCountsOld;
    [Token(Token = "0x4004F83")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject RewardWindow;
    [Token(Token = "0x4004F84")]
    [FieldOffset(Offset = "0x30")]
    public string ReviewURL_Android;
    [Token(Token = "0x4004F85")]
    [FieldOffset(Offset = "0x34")]
    public string ReviewURL_iOS;
    [Token(Token = "0x4004F86")]
    [FieldOffset(Offset = "0x38")]
    public string ReviewURL_Generic;
    [Token(Token = "0x4004F87")]
    [FieldOffset(Offset = "0x3C")]
    public string ReviewURL_Twitter;

    [Token(Token = "0x60059F4")]
    [Address(RVA = "0x12E7AE0", Offset = "0x12E68E0", VA = "0x112E7AE0")]
    private void OnOverItemAmount()
    {
    }

    [Token(Token = "0x60059F5")]
    [Address(RVA = "0x12E7620", Offset = "0x12E6420", VA = "0x112E7620", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059F6")]
    [Address(RVA = "0x12E8080", Offset = "0x12E6E80", VA = "0x112E8080")]
    private void Success()
    {
    }

    [Token(Token = "0x60059F7")]
    [Address(RVA = "0x12E7BD0", Offset = "0x12E69D0", VA = "0x112E7BD0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059F8")]
    [Address(RVA = "0x12E7380", Offset = "0x12E6180", VA = "0x112E7380")]
    public static void Deserialize(Json_TrophyConceptCards json)
    {
    }

    [Token(Token = "0x60059F9")]
    [Address(RVA = "0x12E8C60", Offset = "0x12E7A60", VA = "0x112E8C60")]
    public FlowNode_ReqUpdateTrophy()
    {
    }

    [Token(Token = "0x20015E5")]
    [MessagePackObject(true)]
    public class MP_TrophyPlayerDataAllResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x4004F88")]
      [FieldOffset(Offset = "0x28")]
      public Json_TrophyPlayerDataAll body;

      [Token(Token = "0x60059FC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_TrophyPlayerDataAllResponse()
      {
      }
    }
  }
}
