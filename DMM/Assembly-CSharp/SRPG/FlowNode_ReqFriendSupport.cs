// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqFriendSupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014F3")]
  [FlowNode.NodeType("System/ReqQuest/ReqFriendSupport", 32741)]
  [FlowNode.Pin(100, "傭兵取得", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(110, "傭兵取得成功", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "傭兵取得失敗", FlowNode.PinTypes.Output, 120)]
  [AddComponentMenu("")]
  public class FlowNode_ReqFriendSupport : FlowNode_Network
  {
    [Token(Token = "0x4004CB6")]
    public const int INPUT_FRIEND_SUPPORT = 100;
    [Token(Token = "0x4004CB7")]
    public const int OUTPUT_FRIEND_SUPPORT_SUCCESS = 110;
    [Token(Token = "0x4004CB8")]
    public const int OUTPUT_FRIEND_SUPPORT_FAILED = 120;
    [Token(Token = "0x4004CB9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour m_SerializeValue;
    [Token(Token = "0x4004CBA")]
    [FieldOffset(Offset = "0x24")]
    private FlowNode_ReqFriendSupport.ApiBase m_Api;

    [Token(Token = "0x6005717")]
    [Address(RVA = "0x12C7CE0", Offset = "0x12C6AE0", VA = "0x112C7CE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005718")]
    [Address(RVA = "0x12C7E10", Offset = "0x12C6C10", VA = "0x112C7E10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005719")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqFriendSupport()
    {
    }

    [Token(Token = "0x20014F4")]
    public class ApiBase
    {
      [Token(Token = "0x4004CBB")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqFriendSupport m_Node;
      [Token(Token = "0x4004CBC")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000941")]
      public virtual string url
      {
        [Token(Token = "0x600571A"), Address(RVA = "0x12B3600", Offset = "0x12B2400", VA = "0x112B3600", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000942")]
      public virtual string req
      {
        [Token(Token = "0x600571B"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600571C")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqFriendSupport node)
      {
      }

      [Token(Token = "0x600571D")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x600571E")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x600571F")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x6005720")]
      [Address(RVA = "0x12B34E0", Offset = "0x12B22E0", VA = "0x112B34E0", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x20014F5")]
    public class Api_FriendSupport : FlowNode_ReqFriendSupport.ApiBase
    {
      [Token(Token = "0x4004CBD")]
      [FieldOffset(Offset = "0x10")]
      private SerializeValueList m_ValueList;

      [Token(Token = "0x17000943")]
      public override string url
      {
        [Token(Token = "0x6005721"), Address(RVA = "0x12B3DF0", Offset = "0x12B2BF0", VA = "0x112B3DF0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000944")]
      public override string req
      {
        [Token(Token = "0x6005722"), Address(RVA = "0x12B3D30", Offset = "0x12B2B30", VA = "0x112B3D30", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005723")]
      [Address(RVA = "0xB2EDF0", Offset = "0xB2DBF0", VA = "0x10B2EDF0")]
      public Api_FriendSupport(FlowNode_ReqFriendSupport node, SerializeValueList valueList)
      {
      }

      [Token(Token = "0x6005724")]
      [Address(RVA = "0x12B3CB0", Offset = "0x12B2AB0", VA = "0x112B3CB0", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005725")]
      [Address(RVA = "0x12B3C00", Offset = "0x12B2A00", VA = "0x112B3C00", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005726")]
      [Address(RVA = "0x12B3630", Offset = "0x12B2430", VA = "0x112B3630", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x20014F6")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004CBE")]
        [FieldOffset(Offset = "0x8")]
        public Json_Unit unit;
        [Token(Token = "0x4004CBF")]
        [FieldOffset(Offset = "0xC")]
        public Json_Unit[] units;
        [Token(Token = "0x4004CC0")]
        [FieldOffset(Offset = "0x10")]
        public JSON_ViewGuild guild;
        [Token(Token = "0x4004CC1")]
        [FieldOffset(Offset = "0x14")]
        public int mastery_rank;
        [Token(Token = "0x4004CC2")]
        [FieldOffset(Offset = "0x18")]
        public JSON_PlayerBuff player_buff;

        [Token(Token = "0x6005727")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }
  }
}
