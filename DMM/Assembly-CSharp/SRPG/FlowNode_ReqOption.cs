// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001551")]
  [FlowNode.Pin(220, "オプション設定失敗", FlowNode.PinTypes.Output, 220)]
  [FlowNode.NodeType("System/WebApi/Option", 32741)]
  [FlowNode.Pin(200, "Set", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(210, "オプション設定完了", FlowNode.PinTypes.Output, 210)]
  [AddComponentMenu("")]
  public class FlowNode_ReqOption : FlowNode_Network
  {
    [Token(Token = "0x4004DD9")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqOption.ApiBase m_Api;

    [Token(Token = "0x6005816")]
    [Address(RVA = "0x12D5FD0", Offset = "0x12D4DD0", VA = "0x112D5FD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005817")]
    [Address(RVA = "0x12D5D50", Offset = "0x12D4B50", VA = "0x112D5D50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005818")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqOption()
    {
    }

    [Token(Token = "0x2001552")]
    public class ApiBase
    {
      [Token(Token = "0x4004DDA")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqOption m_Node;
      [Token(Token = "0x4004DDB")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x1700095C")]
      public virtual string url
      {
        [Token(Token = "0x6005819"), Address(RVA = "0x12C9A20", Offset = "0x12C8820", VA = "0x112C9A20", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700095D")]
      public virtual string req
      {
        [Token(Token = "0x600581A"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600581B")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqOption node)
      {
      }

      [Token(Token = "0x600581C")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x600581D")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x600581E")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x600581F")]
      [Address(RVA = "0x12C9890", Offset = "0x12C8690", VA = "0x112C9890", Slot = "9")]
      public virtual bool Start() => new bool();
    }

    [Token(Token = "0x2001553")]
    public class Api_OptionSet : FlowNode_ReqOption.ApiBase
    {
      [Token(Token = "0x4004DDC")]
      [FieldOffset(Offset = "0x10")]
      private bool m_Flag;
      [Token(Token = "0x4004DDD")]
      [FieldOffset(Offset = "0x14")]
      private string m_Comment;

      [Token(Token = "0x1700095E")]
      public override string url
      {
        [Token(Token = "0x6005820"), Address(RVA = "0x12CAB40", Offset = "0x12C9940", VA = "0x112CAB40", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700095F")]
      public override string req
      {
        [Token(Token = "0x6005821"), Address(RVA = "0x12CAA10", Offset = "0x12C9810", VA = "0x112CAA10", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005822")]
      [Address(RVA = "0x12CA980", Offset = "0x12C9780", VA = "0x112CA980")]
      public Api_OptionSet(FlowNode_ReqOption node)
      {
      }

      [Token(Token = "0x6005823")]
      [Address(RVA = "0x12CA6F0", Offset = "0x12C94F0", VA = "0x112CA6F0", Slot = "9")]
      public override bool Start() => new bool();

      [Token(Token = "0x6005824")]
      [Address(RVA = "0x12CA910", Offset = "0x12C9710", VA = "0x112CA910", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005825")]
      [Address(RVA = "0x12CA670", Offset = "0x12C9470", VA = "0x112CA670", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005826")]
      [Address(RVA = "0x12CA420", Offset = "0x12C9220", VA = "0x112CA420", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x2001554")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DDE")]
        [FieldOffset(Offset = "0x8")]
        public Json_PlayerData player;

        [Token(Token = "0x6005828")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
