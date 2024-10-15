// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqWishList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015E8")]
  [FlowNode.Pin(220, "ウィッシュリスト設定失敗", FlowNode.PinTypes.Output, 220)]
  [FlowNode.Pin(210, "ウィッシュリスト設定完了", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(200, "Set", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(120, "ウィッシュリスト取得失敗", FlowNode.PinTypes.Output, 120)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Get", FlowNode.PinTypes.Input, 100)]
  [FlowNode.NodeType("System/WebApi/WishList", 32741)]
  [FlowNode.Pin(110, "ウィッシュリスト取得完了", FlowNode.PinTypes.Output, 110)]
  public class FlowNode_ReqWishList : FlowNode_Network
  {
    [Token(Token = "0x4004F8D")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqWishList.ApiBase m_Api;

    [Token(Token = "0x6005A01")]
    [Address(RVA = "0x12E8CD0", Offset = "0x12E7AD0", VA = "0x112E8CD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A02")]
    [Address(RVA = "0x12D5D50", Offset = "0x12D4B50", VA = "0x112D5D50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005A03")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqWishList()
    {
    }

    [Token(Token = "0x20015E9")]
    public class ApiBase
    {
      [Token(Token = "0x4004F8E")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqWishList m_Node;
      [Token(Token = "0x4004F8F")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000986")]
      public virtual string url
      {
        [Token(Token = "0x6005A04"), Address(RVA = "0x12DD470", Offset = "0x12DC270", VA = "0x112DD470", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000987")]
      public virtual string req
      {
        [Token(Token = "0x6005A05"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005A06")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqWishList node)
      {
      }

      [Token(Token = "0x6005A07")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x6005A08")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x6005A09")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x6005A0A")]
      [Address(RVA = "0x12DD350", Offset = "0x12DC150", VA = "0x112DD350", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x20015EA")]
    public class Api_WishList : FlowNode_ReqWishList.ApiBase
    {
      [Token(Token = "0x17000988")]
      public override string url
      {
        [Token(Token = "0x6005A0B"), Address(RVA = "0x12DE710", Offset = "0x12DD510", VA = "0x112DE710", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005A0C")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_WishList(FlowNode_ReqWishList node)
      {
      }

      [Token(Token = "0x6005A0D")]
      [Address(RVA = "0x12C9D20", Offset = "0x12C8B20", VA = "0x112C9D20", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005A0E")]
      [Address(RVA = "0x12DE690", Offset = "0x12DD490", VA = "0x112DE690", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005A0F")]
      [Address(RVA = "0x12DE520", Offset = "0x12DD320", VA = "0x112DE520", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }
    }

    [Token(Token = "0x20015EB")]
    public class Api_WishListSet : FlowNode_ReqWishList.ApiBase
    {
      [Token(Token = "0x4004F90")]
      [FieldOffset(Offset = "0x10")]
      private string m_Id;
      [Token(Token = "0x4004F91")]
      [FieldOffset(Offset = "0x14")]
      private int m_Priority;

      [Token(Token = "0x17000989")]
      public override string url
      {
        [Token(Token = "0x6005A10"), Address(RVA = "0x12DE4F0", Offset = "0x12DD2F0", VA = "0x112DE4F0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700098A")]
      public override string req
      {
        [Token(Token = "0x6005A11"), Address(RVA = "0x12DE420", Offset = "0x12DD220", VA = "0x112DE420", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005A12")]
      [Address(RVA = "0x12DE3E0", Offset = "0x12DD1E0", VA = "0x112DE3E0")]
      public Api_WishListSet(FlowNode_ReqWishList node, string iname, int priority)
      {
      }

      [Token(Token = "0x6005A13")]
      [Address(RVA = "0x12CA910", Offset = "0x12C9710", VA = "0x112CA910", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005A14")]
      [Address(RVA = "0x12DE360", Offset = "0x12DD160", VA = "0x112DE360", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005A15")]
      [Address(RVA = "0x12DE1D0", Offset = "0x12DCFD0", VA = "0x112DE1D0", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x20015EC")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004F92")]
        [FieldOffset(Offset = "0x8")]
        public bool result;

        [Token(Token = "0x6005A16")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
