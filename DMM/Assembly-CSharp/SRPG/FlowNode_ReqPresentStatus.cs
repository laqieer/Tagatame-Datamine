// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPresentStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001562")]
  [FlowNode.Pin(100, "送付ステータス取得", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(120, "送付ステータス取得失敗", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(110, "送付ステータス取得完了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.NodeType("System/WebApi/PresentStatus", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqPresentStatus : FlowNode_Network
  {
    [Token(Token = "0x4004DF1")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqPresentStatus.ApiBase m_Api;

    [Token(Token = "0x6005856")]
    [Address(RVA = "0x12D6990", Offset = "0x12D5790", VA = "0x112D6990", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005857")]
    [Address(RVA = "0x12D5D50", Offset = "0x12D4B50", VA = "0x112D5D50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005858")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPresentStatus()
    {
    }

    [Token(Token = "0x2001563")]
    public class ApiBase
    {
      [Token(Token = "0x4004DF2")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqPresentStatus m_Node;
      [Token(Token = "0x4004DF3")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000966")]
      public virtual string url
      {
        [Token(Token = "0x6005859"), Address(RVA = "0x12C9AB0", Offset = "0x12C88B0", VA = "0x112C9AB0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000967")]
      public virtual string req
      {
        [Token(Token = "0x600585A"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600585B")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqPresentStatus node)
      {
      }

      [Token(Token = "0x600585C")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x600585D")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x600585E")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x600585F")]
      [Address(RVA = "0x12C9710", Offset = "0x12C8510", VA = "0x112C9710", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x2001564")]
    public class Api_PresentListStatus : FlowNode_ReqPresentStatus.ApiBase
    {
      [Token(Token = "0x17000968")]
      public override string url
      {
        [Token(Token = "0x6005860"), Address(RVA = "0x12CBE60", Offset = "0x12CAC60", VA = "0x112CBE60", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005861")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_PresentListStatus(FlowNode_ReqPresentStatus node)
      {
      }

      [Token(Token = "0x6005862")]
      [Address(RVA = "0x12C9D20", Offset = "0x12C8B20", VA = "0x112C9D20", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005863")]
      [Address(RVA = "0x12CBDE0", Offset = "0x12CABE0", VA = "0x112CBDE0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005864")]
      [Address(RVA = "0x12CBB60", Offset = "0x12CA960", VA = "0x112CBB60", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x2001565")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DF4")]
        [FieldOffset(Offset = "0x8")]
        public string result;

        [Token(Token = "0x6005865")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
