// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqSupportList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001593")]
  [FlowNode.NodeType("System/ReqSupport/ReqSupportList")]
  [FlowNode.Pin(810, "傭兵リスト取得成功", FlowNode.PinTypes.Output, 810)]
  [FlowNode.Pin(0, "傭兵リスト取得", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "傭兵リスト取得(強制)", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(820, "傭兵リスト取得失敗", FlowNode.PinTypes.Output, 820)]
  [AddComponentMenu("")]
  public class FlowNode_ReqSupportList : FlowNode_Network
  {
    [Token(Token = "0x4004E78")]
    public const int INPUT_GETLIST = 0;
    [Token(Token = "0x4004E79")]
    public const int INPUT_GETLIST_FORCE = 10;
    [Token(Token = "0x4004E7A")]
    public const int OUTPUT_SUCCESS = 810;
    [Token(Token = "0x4004E7B")]
    public const int OUTPUT_FAILED = 820;
    [Token(Token = "0x4004E7C")]
    [FieldOffset(Offset = "0x20")]
    public UnitListWindow m_Window;
    [Token(Token = "0x4004E7D")]
    [FieldOffset(Offset = "0x24")]
    private FlowNode_ReqSupportList.ApiBase m_Api;

    [Token(Token = "0x60058EA")]
    [Address(RVA = "0x12DB460", Offset = "0x12DA260", VA = "0x112DB460", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058EB")]
    [Address(RVA = "0x12C7E10", Offset = "0x12C6C10", VA = "0x112C7E10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058EC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqSupportList()
    {
    }

    [Token(Token = "0x2001594")]
    public class ApiBase
    {
      [Token(Token = "0x4004E7E")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqSupportList m_Node;
      [Token(Token = "0x4004E7F")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000970")]
      public virtual string url
      {
        [Token(Token = "0x60058ED"), Address(RVA = "0x12C99F0", Offset = "0x12C87F0", VA = "0x112C99F0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000971")]
      public virtual string req
      {
        [Token(Token = "0x60058EE"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60058EF")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqSupportList node)
      {
      }

      [Token(Token = "0x60058F0")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x60058F1")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x60058F2")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x60058F3")]
      [Address(RVA = "0x12C9280", Offset = "0x12C8080", VA = "0x112C9280", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x2001595")]
    public class Api_SupportList : FlowNode_ReqSupportList.ApiBase
    {
      [Token(Token = "0x4004E80")]
      [FieldOffset(Offset = "0x10")]
      private EElement m_Element;
      [Token(Token = "0x4004E81")]
      [FieldOffset(Offset = "0x11")]
      private bool m_IsForce;
      [Token(Token = "0x4004E82")]
      [FieldOffset(Offset = "0x14")]
      private List<SupportData> m_Select;

      [Token(Token = "0x17000972")]
      public override string url
      {
        [Token(Token = "0x60058F4"), Address(RVA = "0x12CD0A0", Offset = "0x12CBEA0", VA = "0x112CD0A0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000973")]
      public override string req
      {
        [Token(Token = "0x60058F5"), Address(RVA = "0x12CCDC0", Offset = "0x12CBBC0", VA = "0x112CCDC0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60058F6")]
      [Address(RVA = "0x12CCBC0", Offset = "0x12CB9C0", VA = "0x112CCBC0")]
      public Api_SupportList(FlowNode_ReqSupportList node, EElement element, bool isForce)
      {
      }

      [Token(Token = "0x60058F7")]
      [Address(RVA = "0x12CCB30", Offset = "0x12CB930", VA = "0x112CCB30")]
      public Api_SupportList(FlowNode_ReqSupportList node, EElement element)
      {
      }

      [Token(Token = "0x60058F8")]
      [Address(RVA = "0x12CCAF0", Offset = "0x12CB8F0", VA = "0x112CCAF0", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x60058F9")]
      [Address(RVA = "0x12CCA70", Offset = "0x12CB870", VA = "0x112CCA70", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x60058FA")]
      [Address(RVA = "0x12CC850", Offset = "0x12CB650", VA = "0x112CC850", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x2001596")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004E83")]
        [FieldOffset(Offset = "0x8")]
        public Json_Support[] supports;

        [Token(Token = "0x60058FB")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }

    [Token(Token = "0x2001597")]
    public class SupportList
    {
      [Token(Token = "0x4004E84")]
      [FieldOffset(Offset = "0x8")]
      public EElement m_Element;
      [Token(Token = "0x4004E85")]
      [FieldOffset(Offset = "0xC")]
      public SupportData[] m_SupportData;

      [Token(Token = "0x60058FC")]
      [Address(RVA = "0x396910", Offset = "0x395710", VA = "0x10396910")]
      public SupportList(EElement element)
      {
      }

      [Token(Token = "0x60058FD")]
      [Address(RVA = "0x12EEB40", Offset = "0x12ED940", VA = "0x112EEB40")]
      public void Deserialize(Json_Support[] json)
      {
      }
    }
  }
}
