// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqSupportSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200159A")]
  [FlowNode.Pin(110, "傭兵設定成功", FlowNode.PinTypes.Output, 110)]
  [FlowNode.NodeType("System/ReqSupport/ReqSupportSet", 32741)]
  [FlowNode.Pin(100, "傭兵設定", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(120, "傭兵設定失敗", FlowNode.PinTypes.Output, 120)]
  [AddComponentMenu("")]
  public class FlowNode_ReqSupportSet : FlowNode_Network
  {
    [Token(Token = "0x4004E8A")]
    public const int INPUT_SUPPORT_SET = 100;
    [Token(Token = "0x4004E8B")]
    public const int OUTPUT_SUPPORT_SET_SUCCESS = 110;
    [Token(Token = "0x4004E8C")]
    public const int OUTPUT_SUPPORT_SET_FAILED = 120;
    [Token(Token = "0x4004E8D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SupportSettingRootWindow m_TargetWindow;
    [Token(Token = "0x4004E8E")]
    [FieldOffset(Offset = "0x24")]
    private FlowNode_ReqSupportSet.ApiBase m_Api;

    [Token(Token = "0x6005903")]
    [Address(RVA = "0x12DEC60", Offset = "0x12DDA60", VA = "0x112DEC60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005904")]
    [Address(RVA = "0x12C7E10", Offset = "0x12C6C10", VA = "0x112C7E10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005905")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqSupportSet()
    {
    }

    [Token(Token = "0x200159B")]
    public class ApiBase
    {
      [Token(Token = "0x4004E8F")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqSupportSet m_Node;
      [Token(Token = "0x4004E90")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000974")]
      public virtual string url
      {
        [Token(Token = "0x6005906"), Address(RVA = "0x12DD4A0", Offset = "0x12DC2A0", VA = "0x112DD4A0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000975")]
      public virtual string req
      {
        [Token(Token = "0x6005907"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005908")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqSupportSet node)
      {
      }

      [Token(Token = "0x6005909")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x600590A")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x600590B")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x600590C")]
      [Address(RVA = "0x12DD110", Offset = "0x12DBF10", VA = "0x112DD110", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x200159C")]
    public class Api_SupportSet : FlowNode_ReqSupportSet.ApiBase
    {
      [Token(Token = "0x4004E91")]
      [FieldOffset(Offset = "0x10")]
      private SupportSettingRootWindow.OwnSupportData[] m_SupportData;

      [Token(Token = "0x17000976")]
      public override string url
      {
        [Token(Token = "0x600590D"), Address(RVA = "0x12DE1A0", Offset = "0x12DCFA0", VA = "0x112DE1A0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000977")]
      public override string req
      {
        [Token(Token = "0x600590E"), Address(RVA = "0x12DDFD0", Offset = "0x12DCDD0", VA = "0x112DDFD0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600590F")]
      [Address(RVA = "0xB2EDF0", Offset = "0xB2DBF0", VA = "0x10B2EDF0")]
      public Api_SupportSet(
        FlowNode_ReqSupportSet node,
        SupportSettingRootWindow.OwnSupportData[] ownSupportData)
      {
      }

      [Token(Token = "0x6005910")]
      [Address(RVA = "0x12DDF50", Offset = "0x12DCD50", VA = "0x112DDF50", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005911")]
      [Address(RVA = "0x12DDEA0", Offset = "0x12DCCA0", VA = "0x112DDEA0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005912")]
      [Address(RVA = "0x12DDC20", Offset = "0x12DCA20", VA = "0x112DDC20", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x200159D")]
      [Serializable]
      public class ResponseSupportSet
      {
        [Token(Token = "0x4004E92")]
        [FieldOffset(Offset = "0x8")]
        public JSON_PartyOverWrite[] party_decks;

        [Token(Token = "0x6005913")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ResponseSupportSet()
        {
        }
      }
    }
  }
}
