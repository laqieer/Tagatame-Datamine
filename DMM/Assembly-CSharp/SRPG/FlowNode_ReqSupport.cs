// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqSupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200158E")]
  [AddComponentMenu("")]
  [FlowNode.Pin(110, "傭兵取得成功", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "傭兵取得", FlowNode.PinTypes.Input, 100)]
  [FlowNode.NodeType("System/ReqSupport/ReqSupport", 32741)]
  [FlowNode.Pin(120, "傭兵取得失敗", FlowNode.PinTypes.Output, 120)]
  public class FlowNode_ReqSupport : FlowNode_Network
  {
    [Token(Token = "0x4004E6D")]
    public const int INPUT_SUPPORT = 100;
    [Token(Token = "0x4004E6E")]
    public const int OUTPUT_SUPPORT_SUCCESS = 110;
    [Token(Token = "0x4004E6F")]
    public const int OUTPUT_SUPPORT_FAILED = 120;
    [Token(Token = "0x4004E70")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SupportSettingRootWindow m_TargetWindow;
    [Token(Token = "0x4004E71")]
    [FieldOffset(Offset = "0x24")]
    private FlowNode_ReqSupport.ApiBase m_Api;

    [Token(Token = "0x60058D8")]
    [Address(RVA = "0x12DB580", Offset = "0x12DA380", VA = "0x112DB580", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058D9")]
    [Address(RVA = "0x12C7E10", Offset = "0x12C6C10", VA = "0x112C7E10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058DA")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqSupport()
    {
    }

    [Token(Token = "0x200158F")]
    public class ApiBase
    {
      [Token(Token = "0x4004E72")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqSupport m_Node;
      [Token(Token = "0x4004E73")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x1700096C")]
      public virtual string url
      {
        [Token(Token = "0x60058DB"), Address(RVA = "0x12C99C0", Offset = "0x12C87C0", VA = "0x112C99C0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700096D")]
      public virtual string req
      {
        [Token(Token = "0x60058DC"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60058DD")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqSupport node)
      {
      }

      [Token(Token = "0x60058DE")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x60058DF")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x60058E0")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x60058E1")]
      [Address(RVA = "0x12C93A0", Offset = "0x12C81A0", VA = "0x112C93A0", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x2001590")]
    public class Api_Support : FlowNode_ReqSupport.ApiBase
    {
      [Token(Token = "0x1700096E")]
      public override string url
      {
        [Token(Token = "0x60058E2"), Address(RVA = "0x12CD430", Offset = "0x12CC230", VA = "0x112CD430", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700096F")]
      public override string req
      {
        [Token(Token = "0x60058E3"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60058E4")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_Support(FlowNode_ReqSupport node)
      {
      }

      [Token(Token = "0x60058E5")]
      [Address(RVA = "0x12C9D20", Offset = "0x12C8B20", VA = "0x112C9D20", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x60058E6")]
      [Address(RVA = "0x12CD3B0", Offset = "0x12CC1B0", VA = "0x112CD3B0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x60058E7")]
      [Address(RVA = "0x12CD0E0", Offset = "0x12CBEE0", VA = "0x112CD0E0", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x2001591")]
      [Serializable]
      public class Json_OwnSupportData
      {
        [Token(Token = "0x4004E74")]
        [FieldOffset(Offset = "0x8")]
        public long iid;
        [Token(Token = "0x4004E75")]
        [FieldOffset(Offset = "0x10")]
        public int elem;

        [Token(Token = "0x60058E8")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json_OwnSupportData()
        {
        }
      }

      [Token(Token = "0x2001592")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004E76")]
        [FieldOffset(Offset = "0x8")]
        public Json_Unit unit;
        [Token(Token = "0x4004E77")]
        [FieldOffset(Offset = "0xC")]
        public Json_Unit[] units;

        [Token(Token = "0x60058E9")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
