// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqPresentList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001559")]
  [FlowNode.Pin(200, "一括受け取り", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(210, "プレゼント一括受け取り完了", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(220, "プレゼント一括受け取り失敗", FlowNode.PinTypes.Output, 220)]
  [FlowNode.Pin(300, "一括送付", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(110, "プレゼント一覧取得完了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(320, "プレゼント一括送付失敗", FlowNode.PinTypes.Output, 320)]
  [FlowNode.Pin(400, "贈ってくれた人", FlowNode.PinTypes.Input, 400)]
  [FlowNode.Pin(410, "プレゼント贈ってくれた人完了", FlowNode.PinTypes.Output, 410)]
  [FlowNode.Pin(420, "プレゼント贈ってくれた人失敗", FlowNode.PinTypes.Output, 420)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "一覧取得", FlowNode.PinTypes.Input, 100)]
  [FlowNode.NodeType("System/WebApi/PresentList", 32741)]
  [FlowNode.Pin(120, "プレゼント一覧取得失敗", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(310, "プレゼント一括送付完了", FlowNode.PinTypes.Output, 310)]
  public class FlowNode_ReqPresentList : FlowNode_Network
  {
    [Token(Token = "0x4004DE5")]
    [FieldOffset(Offset = "0x20")]
    private FlowNode_ReqPresentList.ApiBase m_Api;

    [Token(Token = "0x6005832")]
    [Address(RVA = "0x12D6720", Offset = "0x12D5520", VA = "0x112D6720", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005833")]
    [Address(RVA = "0x12D5D50", Offset = "0x12D4B50", VA = "0x112D5D50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005834")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqPresentList()
    {
    }

    [Token(Token = "0x200155A")]
    public class ApiBase
    {
      [Token(Token = "0x4004DE6")]
      [FieldOffset(Offset = "0x8")]
      protected FlowNode_ReqPresentList m_Node;
      [Token(Token = "0x4004DE7")]
      [FieldOffset(Offset = "0xC")]
      protected RequestAPI m_Request;

      [Token(Token = "0x17000960")]
      public virtual string url
      {
        [Token(Token = "0x6005835"), Address(RVA = "0x12C9A50", Offset = "0x12C8850", VA = "0x112C9A50", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000961")]
      public virtual string req
      {
        [Token(Token = "0x6005836"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005837")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public ApiBase(FlowNode_ReqPresentList node)
      {
      }

      [Token(Token = "0x6005838")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
      public virtual void Success()
      {
      }

      [Token(Token = "0x6005839")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
      public virtual void Failed()
      {
      }

      [Token(Token = "0x600583A")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
      public virtual void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x600583B")]
      [Address(RVA = "0x12C95F0", Offset = "0x12C83F0", VA = "0x112C95F0", Slot = "9")]
      public virtual void Start()
      {
      }
    }

    [Token(Token = "0x200155B")]
    public class Api_PresentList : FlowNode_ReqPresentList.ApiBase
    {
      [Token(Token = "0x17000962")]
      public override string url
      {
        [Token(Token = "0x600583C"), Address(RVA = "0x12CC0E0", Offset = "0x12CAEE0", VA = "0x112CC0E0", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600583D")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_PresentList(FlowNode_ReqPresentList node)
      {
      }

      [Token(Token = "0x600583E")]
      [Address(RVA = "0x12C9D20", Offset = "0x12C8B20", VA = "0x112C9D20", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x600583F")]
      [Address(RVA = "0x12CC060", Offset = "0x12CAE60", VA = "0x112CC060", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005840")]
      [Address(RVA = "0x12CBE90", Offset = "0x12CAC90", VA = "0x112CBE90", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }
    }

    [Token(Token = "0x200155C")]
    public class Api_PresentListExec : FlowNode_ReqPresentList.ApiBase
    {
      [Token(Token = "0x17000963")]
      public override string url
      {
        [Token(Token = "0x6005841"), Address(RVA = "0x12CB220", Offset = "0x12CA020", VA = "0x112CB220", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005842")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_PresentListExec(FlowNode_ReqPresentList node)
      {
      }

      [Token(Token = "0x6005843")]
      [Address(RVA = "0x12CA910", Offset = "0x12C9710", VA = "0x112CA910", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005844")]
      [Address(RVA = "0x12CB040", Offset = "0x12C9E40", VA = "0x112CB040", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005845")]
      [Address(RVA = "0x12CB0C0", Offset = "0x12C9EC0", VA = "0x112CB0C0")]
      private RewardData ReceiveDataToRewardData(
        FlowNode_ReqPresentList.Api_PresentListExec.JsonItem receiveData)
      {
        return (RewardData) null;
      }

      [Token(Token = "0x6005846")]
      [Address(RVA = "0x12CAB70", Offset = "0x12C9970", VA = "0x112CAB70", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x200155D")]
      [Serializable]
      public class JsonItem
      {
        [Token(Token = "0x4004DE8")]
        [FieldOffset(Offset = "0x8")]
        public string iname;
        [Token(Token = "0x4004DE9")]
        [FieldOffset(Offset = "0xC")]
        public int num;

        [Token(Token = "0x6005847")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JsonItem()
        {
        }
      }

      [Token(Token = "0x200155E")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DEA")]
        [FieldOffset(Offset = "0x8")]
        public Json_PlayerData player;
        [Token(Token = "0x4004DEB")]
        [FieldOffset(Offset = "0xC")]
        public Json_Item[] items;
        [Token(Token = "0x4004DEC")]
        [FieldOffset(Offset = "0x10")]
        public FlowNode_ReqPresentList.Api_PresentListExec.JsonItem[] presents;

        [Token(Token = "0x6005848")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }

    [Token(Token = "0x200155F")]
    public class Api_PresentListSend : FlowNode_ReqPresentList.ApiBase
    {
      [Token(Token = "0x17000964")]
      public override string url
      {
        [Token(Token = "0x6005849"), Address(RVA = "0x12CBB30", Offset = "0x12CA930", VA = "0x112CBB30", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600584A")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public Api_PresentListSend(FlowNode_ReqPresentList node)
      {
      }

      [Token(Token = "0x600584B")]
      [Address(RVA = "0x12CB920", Offset = "0x12CA720", VA = "0x112CB920", Slot = "9")]
      public override void Start()
      {
      }

      [Token(Token = "0x600584C")]
      [Address(RVA = "0x12CBAF0", Offset = "0x12CA8F0", VA = "0x112CBAF0", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x600584D")]
      [Address(RVA = "0x12CB8A0", Offset = "0x12CA6A0", VA = "0x112CB8A0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x600584E")]
      [Address(RVA = "0x12CB570", Offset = "0x12CA370", VA = "0x112CB570", Slot = "8")]
      public override void Complete(WWWResult www)
      {
      }

      [Token(Token = "0x2001560")]
      [Serializable]
      public class Json
      {
        [Token(Token = "0x4004DED")]
        [FieldOffset(Offset = "0x8")]
        public bool result;
        [Token(Token = "0x4004DEE")]
        [FieldOffset(Offset = "0xC")]
        public JSON_TrophyProgress[] trophyprogs;
        [Token(Token = "0x4004DEF")]
        [FieldOffset(Offset = "0x10")]
        public JSON_TrophyProgress[] bingoprogs;

        [Token(Token = "0x600584F")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Json()
        {
        }
      }
    }

    [Token(Token = "0x2001561")]
    public class Api_PresentListGave : FlowNode_ReqPresentList.ApiBase
    {
      [Token(Token = "0x4004DF0")]
      [FieldOffset(Offset = "0x10")]
      private FriendPresentItemParam m_Param;

      [Token(Token = "0x17000965")]
      public override string url
      {
        [Token(Token = "0x6005850"), Address(RVA = "0x12CB540", Offset = "0x12CA340", VA = "0x112CB540", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6005851")]
      [Address(RVA = "0x12CB450", Offset = "0x12CA250", VA = "0x112CB450")]
      public Api_PresentListGave(FlowNode_ReqPresentList node, GameObject gobj)
      {
      }

      [Token(Token = "0x6005852")]
      [Address(RVA = "0x12CB400", Offset = "0x12CA200", VA = "0x112CB400", Slot = "9")]
      public override void Start()
      {
      }

      [Token(Token = "0x6005853")]
      [Address(RVA = "0x12CB410", Offset = "0x12CA210", VA = "0x112CB410", Slot = "6")]
      public override void Success()
      {
      }

      [Token(Token = "0x6005854")]
      [Address(RVA = "0x12CB3C0", Offset = "0x12CA1C0", VA = "0x112CB3C0", Slot = "7")]
      public override void Failed()
      {
      }

      [Token(Token = "0x6005855")]
      [Address(RVA = "0x12CB250", Offset = "0x12CA050", VA = "0x112CB250")]
      public void Complete()
      {
      }
    }
  }
}
