// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMultiInvitation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200153F")]
  [FlowNode.NodeType("System/WebApi/MultiInvitation", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "マルチ招待一覧", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(110, "マルチ招待一覧取得完了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "マルチ招待一覧取得失敗", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(200, "マルチ招待", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(210, "マルチ招待完了", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(220, "マルチ招待失敗", FlowNode.PinTypes.Output, 220)]
  [FlowNode.Pin(300, "マルチ招待通知取得", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(310, "マルチ招待通知完了", FlowNode.PinTypes.Output, 310)]
  [FlowNode.Pin(320, "マルチ招待通知失敗", FlowNode.PinTypes.Output, 320)]
  public class FlowNode_ReqMultiInvitation : FlowNode_Network
  {
    [Token(Token = "0x4004DA2")]
    public const int INPUT_ROOMINVITATION = 100;
    [Token(Token = "0x4004DA3")]
    public const int OUTPUT_ROOMINVITATION_SUCCESS = 110;
    [Token(Token = "0x4004DA4")]
    public const int OUTPUT_ROOMINVITATION_FAILED = 120;
    [Token(Token = "0x4004DA5")]
    public const int INPUT_ROOMINVITATIONSEND = 200;
    [Token(Token = "0x4004DA6")]
    public const int OUTPUT_ROOMINVITATIONSEND_SUCCESS = 210;
    [Token(Token = "0x4004DA7")]
    public const int OUTPUT_ROOMINVITATIONSEND_FAILED = 220;
    [Token(Token = "0x4004DA8")]
    public const int INPUT_NOTIFYINVITATION = 300;
    [Token(Token = "0x4004DA9")]
    public const int OUTPUT_NOTIFYINVITATION_SUCCESS = 310;
    [Token(Token = "0x4004DAA")]
    public const int OUTPUT_NOTIFYINVITATION_FAILED = 320;
    [Token(Token = "0x4004DAB")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqMultiInvitation.ApiBase m_Api;

    [Token(Token = "0x60057E0")]
    [Address(RVA = "0x12D5DA0", Offset = "0x12D4BA0", VA = "0x112D5DA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057E1")]
    [Address(RVA = "0x12D5D50", Offset = "0x12D4B50", VA = "0x112D5D50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057E2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMultiInvitation()
    {
    }

    [Token(Token = "0x2001540")]
    public class ApiBase
    {
      [Token(Token = "0x4004DAC")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqMultiInvitation m_Node;
      [Token(Token = "0x4004DAD")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000951")]
      public virtual string url
      {
        [Token(Token = "0x60057E3"), Address(RVA = "0x12C9A80", Offset = "0x12C8880", VA = "0x112C9A80", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000952")]
      public virtual string req
      {
        [Token(Token = "0x60057E4"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60057E5")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqMultiInvitation node)
      {
      }

      [Token(Token = "0x60057E6")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x60057E7")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x60057E8")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x60057E9")]
      [Address(RVA = "0x12C94C0", Offset = "0x12C82C0", VA = "0x112C94C0", Slot = "9")]
      public virtual bool Start() => new bool();
    }

    [Token(Token = "0x2001541")]
    public class Api_NotifyInvitation : FlowNode_ReqMultiInvitation.ApiBase
    {
      [Token(Token = "0x17000953")]
      public override string url
      {
        [Token(Token = "0x60057EA"), Address(RVA = "0x12CA3F0", Offset = "0x12C91F0", VA = "0x112CA3F0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000954")]
      public override string req
      {
        [Token(Token = "0x60057EB"), Address(RVA = "0x12CA380", Offset = "0x12C9180", VA = "0x112CA380", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60057EC")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_NotifyInvitation(FlowNode_ReqMultiInvitation node)
      {
      }

      [Token(Token = "0x60057ED")]
      [Address(RVA = "0x12CA0E0", Offset = "0x12C8EE0", VA = "0x112CA0E0", Slot = "9")]
      public override bool Start() => new bool();

      [Token(Token = "0x60057EE")]
      [Address(RVA = "0x12CA2F0", Offset = "0x12C90F0", VA = "0x112CA2F0", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x60057EF")]
      [Address(RVA = "0x12CA020", Offset = "0x12C8E20", VA = "0x112CA020", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x60057F0")]
      [Address(RVA = "0x12C9E80", Offset = "0x12C8C80", VA = "0x112C9E80", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x2001542")]
      [Serializable]
      public class Player
      {
        [Token(Token = "0x4004DAE")]
        [FieldOffset(Offset = "0x8")]
        public int multi_inv;

        [Token(Token = "0x60057F1")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Player()
        {
        }
      }

      [Token(Token = "0x2001543")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DAF")]
        [FieldOffset(Offset = "0x8")]
        public FlowNode_ReqMultiInvitation.Api_NotifyInvitation.Player player;

        [Token(Token = "0x60057F2")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }

    [Token(Token = "0x2001544")]
    public class Api_RoomInvitation : FlowNode_ReqMultiInvitation.ApiBase
    {
      [Token(Token = "0x17000955")]
      public override string url
      {
        [Token(Token = "0x60057F3"), Address(RVA = "0x12CC820", Offset = "0x12CB620", VA = "0x112CC820", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60057F4")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_RoomInvitation(FlowNode_ReqMultiInvitation node)
      {
      }

      [Token(Token = "0x60057F5")]
      [Address(RVA = "0x12C9D20", Offset = "0x12C8B20", VA = "0x112C9D20", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x60057F6")]
      [Address(RVA = "0x12CC7A0", Offset = "0x12CB5A0", VA = "0x112CC7A0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x60057F7")]
      [Address(RVA = "0x12CC620", Offset = "0x12CB420", VA = "0x112CC620", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x2001545")]
      [Serializable]
      public class JsonRoomOwner
      {
        [Token(Token = "0x4004DB0")]
        [FieldOffset(Offset = "0x8")]
        public string name;
        [Token(Token = "0x4004DB1")]
        [FieldOffset(Offset = "0xC")]
        public string fuid;
        [Token(Token = "0x4004DB2")]
        [FieldOffset(Offset = "0x10")]
        public Json_Unit[] units;
        [Token(Token = "0x4004DB3")]
        [FieldOffset(Offset = "0x14")]
        public JSON_PlayerBuff player_buff;

        [Token(Token = "0x60057F8")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JsonRoomOwner()
        {
        }
      }

      [Token(Token = "0x2001546")]
      [Serializable]
      public class JsonRoomQuest
      {
        [Token(Token = "0x4004DB4")]
        [FieldOffset(Offset = "0x8")]
        public string iname;

        [Token(Token = "0x60057F9")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JsonRoomQuest()
        {
        }
      }

      [Token(Token = "0x2001547")]
      [Serializable]
      public class JsonRoom
      {
        [Token(Token = "0x4004DB5")]
        [FieldOffset(Offset = "0x8")]
        public int roomid;
        [Token(Token = "0x4004DB6")]
        [FieldOffset(Offset = "0xC")]
        public string comment;
        [Token(Token = "0x4004DB7")]
        [FieldOffset(Offset = "0x10")]
        public int num;
        [Token(Token = "0x4004DB8")]
        [FieldOffset(Offset = "0x14")]
        public FlowNode_ReqMultiInvitation.Api_RoomInvitation.JsonRoomOwner owner;
        [Token(Token = "0x4004DB9")]
        [FieldOffset(Offset = "0x18")]
        public FlowNode_ReqMultiInvitation.Api_RoomInvitation.JsonRoomQuest quest;
        [Token(Token = "0x4004DBA")]
        [FieldOffset(Offset = "0x1C")]
        public string pwd_hash;
        [Token(Token = "0x4004DBB")]
        [FieldOffset(Offset = "0x20")]
        public int unitlv;
        [Token(Token = "0x4004DBC")]
        [FieldOffset(Offset = "0x24")]
        public int clear;
        [Token(Token = "0x4004DBD")]
        [FieldOffset(Offset = "0x28")]
        public int limit;
        [Token(Token = "0x4004DBE")]
        [FieldOffset(Offset = "0x2C")]
        public string btype;

        [Token(Token = "0x60057FA")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JsonRoom()
        {
        }
      }

      [Token(Token = "0x2001548")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DBF")]
        [FieldOffset(Offset = "0x8")]
        public FlowNode_ReqMultiInvitation.Api_RoomInvitation.JsonRoom[] rooms;

        [Token(Token = "0x60057FB")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }

    [Token(Token = "0x2001549")]
    public class Api_RoomInvitationSend : FlowNode_ReqMultiInvitation.ApiBase
    {
      [Token(Token = "0x4004DC0")]
      [FieldOffset(Offset = "0x10")]
      private int m_RoomType;
      [Token(Token = "0x4004DC1")]
      [FieldOffset(Offset = "0x14")]
      private int m_RoomId;
      [Token(Token = "0x4004DC2")]
      [FieldOffset(Offset = "0x18")]
      private string[] m_Sends;

      [Token(Token = "0x17000956")]
      public override string url
      {
        [Token(Token = "0x60057FC"), Address(RVA = "0x12CC5F0", Offset = "0x12CB3F0", VA = "0x112CC5F0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000957")]
      public override string req
      {
        [Token(Token = "0x60057FD"), Address(RVA = "0x12CC450", Offset = "0x12CB250", VA = "0x112CC450", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60057FE")]
      [Address(RVA = "0x12CC340", Offset = "0x12CB140", VA = "0x112CC340")]
      public Api_RoomInvitationSend(FlowNode_ReqMultiInvitation node)
      {
      }

      [Token(Token = "0x60057FF")]
      [Address(RVA = "0x12CA910", Offset = "0x12C9710", VA = "0x112CA910", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005800")]
      [Address(RVA = "0x12CC2C0", Offset = "0x12CB0C0", VA = "0x112CC2C0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005801")]
      [Address(RVA = "0x12CC110", Offset = "0x12CAF10", VA = "0x112CC110", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x200154A")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DC3")]
        [FieldOffset(Offset = "0x8")]
        public bool result;

        [Token(Token = "0x6005802")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
