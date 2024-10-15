// Decompiled with JetBrains decompiler
// Type: SRPG.MultiInvitationSendWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200277E")]
  public class MultiInvitationSendWindow : FlowWindowBase
  {
    [Token(Token = "0x400BA95")]
    private const int CHECK_MAX = 5;
    [Token(Token = "0x400BA96")]
    [FieldOffset(Offset = "0x30")]
    private MultiInvitationSendWindow.SerializeParam m_Param;
    [Token(Token = "0x400BA97")]
    [FieldOffset(Offset = "0x34")]
    private bool m_Destroy;
    [Token(Token = "0x400BA98")]
    [FieldOffset(Offset = "0x38")]
    private MultiInvitationSendWindow.Content.ItemSource m_ContentSource;
    [Token(Token = "0x400BA99")]
    [FieldOffset(Offset = "0x3C")]
    private ContentController m_ContentController;
    [Token(Token = "0x400BA9A")]
    [FieldOffset(Offset = "0x40")]
    private SerializeValueBehaviour m_ValueList;
    [Token(Token = "0x400BA9B")]
    [FieldOffset(Offset = "0x44")]
    private List<string> m_SendList;
    [Token(Token = "0x400BA9C")]
    [FieldOffset(Offset = "0x0")]
    private static MultiInvitationSendWindow m_Instance;
    [Token(Token = "0x400BA9D")]
    [FieldOffset(Offset = "0x4")]
    private static List<string> m_Invited;

    [Token(Token = "0x17001878")]
    public override string name
    {
      [Token(Token = "0x600B123"), Address(RVA = "0x749260", Offset = "0x748060", VA = "0x10749260", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001879")]
    public static MultiInvitationSendWindow instance
    {
      [Token(Token = "0x600B124"), Address(RVA = "0x749220", Offset = "0x748020", VA = "0x10749220")] get
      {
        return (MultiInvitationSendWindow) null;
      }
    }

    [Token(Token = "0x600B125")]
    [Address(RVA = "0x747F30", Offset = "0x746D30", VA = "0x10747F30")]
    public static void ClearInvited()
    {
    }

    [Token(Token = "0x600B126")]
    [Address(RVA = "0x747EC0", Offset = "0x746CC0", VA = "0x10747EC0")]
    public static void AddInvited(string uid)
    {
    }

    [Token(Token = "0x600B127")]
    [Address(RVA = "0x748710", Offset = "0x747510", VA = "0x10748710", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x600B128")]
    [Address(RVA = "0x749050", Offset = "0x747E50", VA = "0x10749050", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x600B129")]
    [Address(RVA = "0x7490C0", Offset = "0x747EC0", VA = "0x107490C0", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x600B12A")]
    [Address(RVA = "0x748C20", Offset = "0x747A20", VA = "0x10748C20")]
    private void RefreshUI()
    {
    }

    [Token(Token = "0x600B12B")]
    [Address(RVA = "0x7480D0", Offset = "0x746ED0", VA = "0x107480D0")]
    public void InitializeContentList()
    {
    }

    [Token(Token = "0x600B12C")]
    [Address(RVA = "0x748F90", Offset = "0x747D90", VA = "0x10748F90")]
    public void ReleaseContentList()
    {
    }

    [Token(Token = "0x600B12D")]
    [Address(RVA = "0x747FD0", Offset = "0x746DD0", VA = "0x10747FD0")]
    public string[] GetSendList() => (string[]) null;

    [Token(Token = "0x600B12E")]
    [Address(RVA = "0x7489C0", Offset = "0x7477C0", VA = "0x107489C0")]
    public bool IsSendList(string uid) => new bool();

    [Token(Token = "0x600B12F")]
    [Address(RVA = "0x748A80", Offset = "0x747880", VA = "0x10748A80", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x600B130")]
    [Address(RVA = "0x7491B0", Offset = "0x747FB0", VA = "0x107491B0")]
    public MultiInvitationSendWindow()
    {
    }

    [Token(Token = "0x600B131")]
    [Address(RVA = "0x749110", Offset = "0x747F10", VA = "0x10749110")]
    static MultiInvitationSendWindow()
    {
    }

    [Token(Token = "0x200277F")]
    public static class Content
    {
      [Token(Token = "0x400BA9E")]
      [FieldOffset(Offset = "0x0")]
      public static MultiInvitationSendWindow.Content.ItemAccessor clickItem;

      [Token(Token = "0x2002780")]
      public class ItemAccessor
      {
        [Token(Token = "0x400BA9F")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400BAA0")]
        [FieldOffset(Offset = "0xC")]
        private FriendData m_Friend;
        [Token(Token = "0x400BAA1")]
        [FieldOffset(Offset = "0x10")]
        private DataSource m_DataSource;
        [Token(Token = "0x400BAA2")]
        [FieldOffset(Offset = "0x14")]
        private Toggle m_Toggle;
        [Token(Token = "0x400BAA3")]
        [FieldOffset(Offset = "0x18")]
        private GameObject m_Hatch;

        [Token(Token = "0x1700187A")]
        public ContentNode node
        {
          [Token(Token = "0x600B132"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x1700187B")]
        public FriendData friend
        {
          [Token(Token = "0x600B133"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (FriendData) null;
          }
        }

        [Token(Token = "0x1700187C")]
        public Toggle tgl
        {
          [Token(Token = "0x600B134"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
          {
            return (Toggle) null;
          }
        }

        [Token(Token = "0x1700187D")]
        public bool isOn
        {
          [Token(Token = "0x600B135"), Address(RVA = "0x745930", Offset = "0x744730", VA = "0x10745930")] set
          {
          }
          [Token(Token = "0x600B136"), Address(RVA = "0x745820", Offset = "0x744620", VA = "0x10745820")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x1700187E")]
        public bool isValid
        {
          [Token(Token = "0x600B137"), Address(RVA = "0x2B0090", Offset = "0x2AEE90", VA = "0x102B0090")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B138")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(FriendData friend)
        {
        }

        [Token(Token = "0x600B139")]
        [Address(RVA = "0x744A20", Offset = "0x743820", VA = "0x10744A20")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x600B13A")]
        [Address(RVA = "0x7456E0", Offset = "0x7444E0", VA = "0x107456E0")]
        public void Clear()
        {
        }

        [Token(Token = "0x600B13B")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x600B13C")]
        [Address(RVA = "0x7457A0", Offset = "0x7445A0", VA = "0x107457A0")]
        public void SetHatch(bool value)
        {
        }

        [Token(Token = "0x600B13D")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x2002781")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400BAA4")]
        [FieldOffset(Offset = "0x10")]
        private List<MultiInvitationSendWindow.Content.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x600B13E")]
        [Address(RVA = "0x745FA0", Offset = "0x744DA0", VA = "0x10745FA0", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x600B13F")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x600B140")]
        [Address(RVA = "0x745EF0", Offset = "0x744CF0", VA = "0x10745EF0")]
        public void Add(
          MultiInvitationSendWindow.Content.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x600B141")]
        [Address(RVA = "0x746420", Offset = "0x745220", VA = "0x10746420")]
        public void Setup()
        {
        }

        [Token(Token = "0x600B142")]
        [Address(RVA = "0x746610", Offset = "0x745410", VA = "0x10746610")]
        public ItemSource()
        {
        }

        [Token(Token = "0x2002782")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400BAA5")]
          [FieldOffset(Offset = "0x10")]
          private MultiInvitationSendWindow.Content.ItemAccessor m_Accessor;

          [Token(Token = "0x600B143")]
          [Address(RVA = "0x605790", Offset = "0x604590", VA = "0x10605790", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x1700187F")]
          public MultiInvitationSendWindow.Content.ItemAccessor accessor
          {
            [Token(Token = "0x600B144"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (MultiInvitationSendWindow.Content.ItemAccessor) null;
            }
          }

          [Token(Token = "0x17001880")]
          public FriendData friend
          {
            [Token(Token = "0x600B145"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (FriendData) null;
            }
          }

          [Token(Token = "0x600B146")]
          [Address(RVA = "0x745D10", Offset = "0x744B10", VA = "0x10745D10")]
          public ItemParam(FriendData friend)
          {
          }

          [Token(Token = "0x600B147")]
          [Address(RVA = "0x745C30", Offset = "0x744A30", VA = "0x10745C30", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x600B148")]
          [Address(RVA = "0x745B40", Offset = "0x744940", VA = "0x10745B40", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x600B149")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x2002784")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400BAA8")]
      [FieldOffset(Offset = "0xC")]
      public GameObject list;

      [Token(Token = "0x17001881")]
      public override System.Type type
      {
        [Token(Token = "0x600B14D"), Address(RVA = "0x768A90", Offset = "0x767890", VA = "0x10768A90", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x600B14E")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
