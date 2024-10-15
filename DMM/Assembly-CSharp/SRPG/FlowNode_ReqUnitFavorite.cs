// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUnitFavorite
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
  [Token(Token = "0x20015D1")]
  [FlowNode.Pin(100, "お気に入りON", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(110, "お気に入りOFF", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(120, "お気に入り設定ON完了", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(130, "お気に入り設定OFF完了", FlowNode.PinTypes.Output, 130)]
  [FlowNode.Pin(200, "お気に入り設定失敗", FlowNode.PinTypes.Output, 200)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/WebApi/ReqUnitFavorite", 32741)]
  public class FlowNode_ReqUnitFavorite : FlowNode_Network
  {
    [Token(Token = "0x4004F55")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqUnitFavorite.ApiBase m_Api;

    [Token(Token = "0x60059B0")]
    [Address(RVA = "0x12E2E00", Offset = "0x12E1C00", VA = "0x112E2E00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059B1")]
    [Address(RVA = "0x12D5D50", Offset = "0x12D4B50", VA = "0x112D5D50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059B2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUnitFavorite()
    {
    }

    [Token(Token = "0x20015D2")]
    public class ApiBase
    {
      [Token(Token = "0x4004F56")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqUnitFavorite m_Node;
      [Token(Token = "0x4004F57")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000980")]
      public virtual string url
      {
        [Token(Token = "0x60059B3"), Address(RVA = "0x12DD4D0", Offset = "0x12DC2D0", VA = "0x112DD4D0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000981")]
      public virtual string req
      {
        [Token(Token = "0x60059B4"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60059B5")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqUnitFavorite node)
      {
      }

      [Token(Token = "0x60059B6")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x60059B7")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x60059B8")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x60059B9")]
      [Address(RVA = "0x12DD230", Offset = "0x12DC030", VA = "0x112DD230", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x20015D3")]
    public class Api_SetUnitFavorite : FlowNode_ReqUnitFavorite.ApiBase
    {
      [Token(Token = "0x4004F58")]
      [FieldOffset(Offset = "0x10")]
      private List<long> m_OnUniqId;
      [Token(Token = "0x4004F59")]
      [FieldOffset(Offset = "0x14")]
      private List<long> m_OffUniqId;

      [Token(Token = "0x17000982")]
      public override string url
      {
        [Token(Token = "0x60059BA"), Address(RVA = "0x12DDBF0", Offset = "0x12DC9F0", VA = "0x112DDBF0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000983")]
      public override string req
      {
        [Token(Token = "0x60059BB"), Address(RVA = "0x12DD9E0", Offset = "0x12DC7E0", VA = "0x112DD9E0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60059BC")]
      [Address(RVA = "0x12DD840", Offset = "0x12DC640", VA = "0x112DD840")]
      public Api_SetUnitFavorite(FlowNode_ReqUnitFavorite node, bool value)
      {
      }

      [Token(Token = "0x60059BD")]
      [Address(RVA = "0x12DD7B0", Offset = "0x12DC5B0", VA = "0x112DD7B0", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x60059BE")]
      [Address(RVA = "0x12DD730", Offset = "0x12DC530", VA = "0x112DD730", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x60059BF")]
      [Address(RVA = "0x12DD500", Offset = "0x12DC300", VA = "0x112DD500", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x20015D4")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004F5A")]
        [FieldOffset(Offset = "0x8")]
        public Json_Unit[] units;

        [Token(Token = "0x60059C0")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
