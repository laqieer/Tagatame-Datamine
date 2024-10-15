// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentWantWindow
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
  [Token(Token = "0x20023FA")]
  public class FriendPresentWantWindow : FlowWindowBase
  {
    [Token(Token = "0x400A296")]
    [FieldOffset(Offset = "0x30")]
    private FriendPresentWantWindow.Content.ItemSource m_ContentSource;
    [Token(Token = "0x400A297")]
    [FieldOffset(Offset = "0x34")]
    private ContentController m_ContentController;

    [Token(Token = "0x170015C1")]
    public override string name
    {
      [Token(Token = "0x6009C81"), Address(RVA = "0x5F87C0", Offset = "0x5F75C0", VA = "0x105F87C0", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6009C82")]
    [Address(RVA = "0x5F8500", Offset = "0x5F7300", VA = "0x105F8500", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x6009C83")]
    [Address(RVA = "0x5F8760", Offset = "0x5F7560", VA = "0x105F8760", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x6009C84")]
    [Address(RVA = "0x5F8780", Offset = "0x5F7580", VA = "0x105F8780", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x6009C85")]
    [Address(RVA = "0x5F80B0", Offset = "0x5F6EB0", VA = "0x105F80B0")]
    public void InitializeContentList()
    {
    }

    [Token(Token = "0x6009C86")]
    [Address(RVA = "0x5F86D0", Offset = "0x5F74D0", VA = "0x105F86D0")]
    public void ReleaseContentList()
    {
    }

    [Token(Token = "0x6009C87")]
    [Address(RVA = "0x5F8680", Offset = "0x5F7480", VA = "0x105F8680", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x6009C88")]
    [Address(RVA = "0x4A5B50", Offset = "0x4A4950", VA = "0x104A5B50")]
    public FriendPresentWantWindow()
    {
    }

    [Token(Token = "0x20023FB")]
    public static class Content
    {
      [Token(Token = "0x400A298")]
      [FieldOffset(Offset = "0x0")]
      public static FriendPresentWantWindow.Content.ItemAccessor clickItem;

      [Token(Token = "0x20023FC")]
      public class ItemAccessor
      {
        [Token(Token = "0x400A299")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400A29A")]
        [FieldOffset(Offset = "0xC")]
        private FriendPresentItemParam m_Present;
        [Token(Token = "0x400A29B")]
        [FieldOffset(Offset = "0x10")]
        private FriendPresentItemIcon m_Icon;

        [Token(Token = "0x170015C2")]
        public ContentNode node
        {
          [Token(Token = "0x6009C89"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x170015C3")]
        public FriendPresentItemParam present
        {
          [Token(Token = "0x6009C8A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (FriendPresentItemParam) null;
          }
        }

        [Token(Token = "0x170015C4")]
        public FriendPresentItemIcon icon
        {
          [Token(Token = "0x6009C8B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (FriendPresentItemIcon) null;
          }
        }

        [Token(Token = "0x170015C5")]
        public string presentId
        {
          [Token(Token = "0x6009C8C"), Address(RVA = "0x6056E0", Offset = "0x6044E0", VA = "0x106056E0")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x170015C6")]
        public bool isValid
        {
          [Token(Token = "0x6009C8D"), Address(RVA = "0x2B0090", Offset = "0x2AEE90", VA = "0x102B0090")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x6009C8E")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(FriendPresentItemParam present)
        {
        }

        [Token(Token = "0x6009C8F")]
        [Address(RVA = "0x604F00", Offset = "0x603D00", VA = "0x10604F00")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x6009C90")]
        [Address(RVA = "0x605180", Offset = "0x603F80", VA = "0x10605180")]
        public void Clear()
        {
        }

        [Token(Token = "0x6009C91")]
        [Address(RVA = "0x605300", Offset = "0x604100", VA = "0x10605300")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x6009C92")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x20023FD")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400A29C")]
        [FieldOffset(Offset = "0x10")]
        private List<FriendPresentWantWindow.Content.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x6009C93")]
        [Address(RVA = "0x606950", Offset = "0x605750", VA = "0x10606950", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x6009C94")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x6009C95")]
        [Address(RVA = "0x6066C0", Offset = "0x6054C0", VA = "0x106066C0")]
        public void Add(
          FriendPresentWantWindow.Content.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x6009C96")]
        [Address(RVA = "0x606DF0", Offset = "0x605BF0", VA = "0x10606DF0")]
        public void Setup()
        {
        }

        [Token(Token = "0x6009C97")]
        [Address(RVA = "0x607480", Offset = "0x606280", VA = "0x10607480")]
        public ItemSource()
        {
        }

        [Token(Token = "0x20023FE")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400A29D")]
          [FieldOffset(Offset = "0x10")]
          private FriendPresentWantWindow.Content.ItemAccessor m_Accessor;

          [Token(Token = "0x6009C98")]
          [Address(RVA = "0x605790", Offset = "0x604590", VA = "0x10605790", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x170015C7")]
          public FriendPresentWantWindow.Content.ItemAccessor accerror
          {
            [Token(Token = "0x6009C99"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (FriendPresentWantWindow.Content.ItemAccessor) null;
            }
          }

          [Token(Token = "0x170015C8")]
          public FriendPresentItemParam present
          {
            [Token(Token = "0x6009C9A"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (FriendPresentItemParam) null;
            }
          }

          [Token(Token = "0x6009C9B")]
          [Address(RVA = "0x606600", Offset = "0x605400", VA = "0x10606600")]
          public ItemParam(FriendPresentItemParam present)
          {
          }

          [Token(Token = "0x6009C9C")]
          [Address(RVA = "0x605F10", Offset = "0x604D10", VA = "0x10605F10", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C9D")]
          [Address(RVA = "0x605AF0", Offset = "0x6048F0", VA = "0x10605AF0", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C9E")]
          [Address(RVA = "0x605880", Offset = "0x604680", VA = "0x10605880", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x2002400")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400A2A0")]
      [FieldOffset(Offset = "0xC")]
      public GameObject list;

      [Token(Token = "0x170015C9")]
      public override System.Type type
      {
        [Token(Token = "0x6009CA2"), Address(RVA = "0x607700", Offset = "0x606500", VA = "0x10607700", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x6009CA3")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
