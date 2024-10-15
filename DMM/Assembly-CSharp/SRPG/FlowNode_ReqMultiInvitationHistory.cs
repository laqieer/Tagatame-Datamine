// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqMultiInvitationHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200154B")]
  [AddComponentMenu("")]
  [FlowNode.Pin(120, "マルチ招待ログ一覧取得失敗", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(110, "マルチ招待ログ一覧取得完了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "マルチ招待ログ一覧", FlowNode.PinTypes.Input, 100)]
  [FlowNode.NodeType("System/WebApi/MultiInvitationHistory", 32741)]
  public class FlowNode_ReqMultiInvitationHistory : FlowNode_Network
  {
    [Token(Token = "0x4004DC4")]
    public const int INPUT_MULTIINVITATION = 100;
    [Token(Token = "0x4004DC5")]
    public const int OUTPUT_MULTIINVITATION_SUCCESS = 110;
    [Token(Token = "0x4004DC6")]
    public const int OUTPUT_MULTIINVITATION_FAILED = 120;
    [Token(Token = "0x4004DC7")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqMultiInvitationHistory.ApiBase m_Api;

    [Token(Token = "0x6005803")]
    [Address(RVA = "0x12D5C00", Offset = "0x12D4A00", VA = "0x112D5C00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005804")]
    [Address(RVA = "0x12D5D50", Offset = "0x12D4B50", VA = "0x112D5D50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005805")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqMultiInvitationHistory()
    {
    }

    [Token(Token = "0x200154C")]
    public class ApiBase
    {
      [Token(Token = "0x4004DC8")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqMultiInvitationHistory m_Node;
      [Token(Token = "0x4004DC9")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000958")]
      public virtual string url
      {
        [Token(Token = "0x6005806"), Address(RVA = "0x12C9AE0", Offset = "0x12C88E0", VA = "0x112C9AE0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000959")]
      public virtual string req
      {
        [Token(Token = "0x6005807"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005808")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqMultiInvitationHistory node)
      {
      }

      [Token(Token = "0x6005809")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x600580A")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x600580B")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x600580C")]
      [Address(RVA = "0x12C9160", Offset = "0x12C7F60", VA = "0x112C9160", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x200154D")]
    public class Api_MultiInvitationHistory : FlowNode_ReqMultiInvitationHistory.ApiBase
    {
      [Token(Token = "0x4004DCA")]
      [FieldOffset(Offset = "0x10")]
      private int m_Page;

      [Token(Token = "0x1700095A")]
      public override string url
      {
        [Token(Token = "0x600580D"), Address(RVA = "0x12C9E50", Offset = "0x12C8C50", VA = "0x112C9E50", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700095B")]
      public override string req
      {
        [Token(Token = "0x600580E"), Address(RVA = "0x12C9DA0", Offset = "0x12C8BA0", VA = "0x112C9DA0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600580F")]
      [Address(RVA = "0x12C9D60", Offset = "0x12C8B60", VA = "0x112C9D60")]
      public Api_MultiInvitationHistory(FlowNode_ReqMultiInvitationHistory node, int page)
      {
      }

      [Token(Token = "0x6005810")]
      [Address(RVA = "0x12C9D20", Offset = "0x12C8B20", VA = "0x112C9D20", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005811")]
      [Address(RVA = "0x12C9CA0", Offset = "0x12C8AA0", VA = "0x112C9CA0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005812")]
      [Address(RVA = "0x12C9B10", Offset = "0x12C8910", VA = "0x112C9B10", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x200154E")]
      [Serializable]
      public class JsonPlayer
      {
        [Token(Token = "0x4004DCB")]
        [FieldOffset(Offset = "0x8")]
        public string uid;
        [Token(Token = "0x4004DCC")]
        [FieldOffset(Offset = "0xC")]
        public string fuid;
        [Token(Token = "0x4004DCD")]
        [FieldOffset(Offset = "0x10")]
        public string name;
        [Token(Token = "0x4004DCE")]
        [FieldOffset(Offset = "0x14")]
        public int lv;
        [Token(Token = "0x4004DCF")]
        [FieldOffset(Offset = "0x18")]
        public string lastlogin;
        [Token(Token = "0x4004DD0")]
        [FieldOffset(Offset = "0x1C")]
        public Json_Unit unit;
        [Token(Token = "0x4004DD1")]
        [FieldOffset(Offset = "0x20")]
        public JSON_PlayerBuff player_buff;

        [Token(Token = "0x6005813")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JsonPlayer()
        {
        }
      }

      [Token(Token = "0x200154F")]
      [Serializable]
      public class JsonList
      {
        [Token(Token = "0x4004DD2")]
        [FieldOffset(Offset = "0x8")]
        public int id;
        [Token(Token = "0x4004DD3")]
        [FieldOffset(Offset = "0xC")]
        public int roomid;
        [Token(Token = "0x4004DD4")]
        [FieldOffset(Offset = "0x10")]
        public string iname;
        [Token(Token = "0x4004DD5")]
        [FieldOffset(Offset = "0x14")]
        public string btype;
        [Token(Token = "0x4004DD6")]
        [FieldOffset(Offset = "0x18")]
        public string created_at;
        [Token(Token = "0x4004DD7")]
        [FieldOffset(Offset = "0x1C")]
        public FlowNode_ReqMultiInvitationHistory.Api_MultiInvitationHistory.JsonPlayer player;

        [Token(Token = "0x6005814")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JsonList()
        {
        }
      }

      [Token(Token = "0x2001550")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DD8")]
        [FieldOffset(Offset = "0x8")]
        public FlowNode_ReqMultiInvitationHistory.Api_MultiInvitationHistory.JsonList[] list;

        [Token(Token = "0x6005815")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
