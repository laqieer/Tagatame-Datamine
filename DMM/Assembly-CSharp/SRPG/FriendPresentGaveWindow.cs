// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentGaveWindow
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
  [Token(Token = "0x20023DD")]
  public class FriendPresentGaveWindow : FlowWindowBase
  {
    [Token(Token = "0x400A243")]
    [FieldOffset(Offset = "0x30")]
    private FriendPresentGaveWindow.Content.ItemSource m_ContentSource;
    [Token(Token = "0x400A244")]
    [FieldOffset(Offset = "0x34")]
    private ContentController m_ContentController;
    [Token(Token = "0x400A245")]
    [FieldOffset(Offset = "0x38")]
    private List<string> m_FriendUidList;
    [Token(Token = "0x400A246")]
    [FieldOffset(Offset = "0x0")]
    private static FriendPresentGaveWindow m_Instance;

    [Token(Token = "0x1700159F")]
    public override string name
    {
      [Token(Token = "0x6009BEF"), Address(RVA = "0x5F5900", Offset = "0x5F4700", VA = "0x105F5900", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015A0")]
    public static FriendPresentGaveWindow instance
    {
      [Token(Token = "0x6009BF0"), Address(RVA = "0x5F58D0", Offset = "0x5F46D0", VA = "0x105F58D0")] get
      {
        return (FriendPresentGaveWindow) null;
      }
    }

    [Token(Token = "0x6009BF1")]
    [Address(RVA = "0x5F5540", Offset = "0x5F4340", VA = "0x105F5540", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x6009BF2")]
    [Address(RVA = "0x5F57C0", Offset = "0x5F45C0", VA = "0x105F57C0", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x6009BF3")]
    [Address(RVA = "0x5F5820", Offset = "0x5F4620", VA = "0x105F5820", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x6009BF4")]
    [Address(RVA = "0x5F51D0", Offset = "0x5F3FD0", VA = "0x105F51D0")]
    public void InitializeContentList()
    {
    }

    [Token(Token = "0x6009BF5")]
    [Address(RVA = "0x5F5730", Offset = "0x5F4530", VA = "0x105F5730")]
    public void ReleaseContentList()
    {
    }

    [Token(Token = "0x6009BF6")]
    [Address(RVA = "0x5F5170", Offset = "0x5F3F70", VA = "0x105F5170")]
    public void ClearFuids()
    {
    }

    [Token(Token = "0x6009BF7")]
    [Address(RVA = "0x5F5120", Offset = "0x5F3F20", VA = "0x105F5120")]
    public void AddUid(string uid)
    {
    }

    [Token(Token = "0x6009BF8")]
    [Address(RVA = "0x5F56E0", Offset = "0x5F44E0", VA = "0x105F56E0", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x6009BF9")]
    [Address(RVA = "0x5F5860", Offset = "0x5F4660", VA = "0x105F5860")]
    public FriendPresentGaveWindow()
    {
    }

    [Token(Token = "0x20023DE")]
    public static class Content
    {
      [Token(Token = "0x400A247")]
      [FieldOffset(Offset = "0x0")]
      public static FriendPresentGaveWindow.Content.ItemAccessor clickItem;

      [Token(Token = "0x20023DF")]
      public class ItemAccessor
      {
        [Token(Token = "0x400A248")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400A249")]
        [FieldOffset(Offset = "0xC")]
        private FriendData m_FriendData;

        [Token(Token = "0x170015A1")]
        public ContentNode node
        {
          [Token(Token = "0x6009BFA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x170015A2")]
        public FriendData friendData
        {
          [Token(Token = "0x6009BFB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (FriendData) null;
          }
        }

        [Token(Token = "0x170015A3")]
        public bool isValid
        {
          [Token(Token = "0x6009BFC"), Address(RVA = "0x2B0090", Offset = "0x2AEE90", VA = "0x102B0090")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x6009BFD")]
        [Address(RVA = "0x6055D0", Offset = "0x6043D0", VA = "0x106055D0")]
        public void Setup(string uid)
        {
        }

        [Token(Token = "0x6009BFE")]
        [Address(RVA = "0x604A90", Offset = "0x603890", VA = "0x10604A90")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x6009BFF")]
        [Address(RVA = "0x6052E0", Offset = "0x6040E0", VA = "0x106052E0")]
        public void Clear()
        {
        }

        [Token(Token = "0x6009C00")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x6009C01")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x20023E1")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400A24B")]
        [FieldOffset(Offset = "0x10")]
        private List<FriendPresentGaveWindow.Content.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x6009C04")]
        [Address(RVA = "0x606910", Offset = "0x605710", VA = "0x10606910", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x6009C05")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x6009C06")]
        [Address(RVA = "0x606730", Offset = "0x605530", VA = "0x10606730")]
        public void Add(
          FriendPresentGaveWindow.Content.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x6009C07")]
        [Address(RVA = "0x607250", Offset = "0x606050", VA = "0x10607250")]
        public void Setup()
        {
        }

        [Token(Token = "0x6009C08")]
        [Address(RVA = "0x6074F0", Offset = "0x6062F0", VA = "0x106074F0")]
        public ItemSource()
        {
        }

        [Token(Token = "0x20023E2")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400A24C")]
          [FieldOffset(Offset = "0x10")]
          private FriendPresentGaveWindow.Content.ItemAccessor m_Accessor;

          [Token(Token = "0x6009C09")]
          [Address(RVA = "0x605790", Offset = "0x604590", VA = "0x10605790", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x170015A4")]
          public FriendPresentGaveWindow.Content.ItemAccessor accerror
          {
            [Token(Token = "0x6009C0A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (FriendPresentGaveWindow.Content.ItemAccessor) null;
            }
          }

          [Token(Token = "0x170015A5")]
          public FriendData friendData
          {
            [Token(Token = "0x6009C0B"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (FriendData) null;
            }
          }

          [Token(Token = "0x6009C0C")]
          [Address(RVA = "0x6064A0", Offset = "0x6052A0", VA = "0x106064A0")]
          public ItemParam(string uid)
          {
          }

          [Token(Token = "0x6009C0D")]
          [Address(RVA = "0x605C80", Offset = "0x604A80", VA = "0x10605C80", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C0E")]
          [Address(RVA = "0x605A00", Offset = "0x604800", VA = "0x10605A00", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C0F")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x20023E4")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400A24F")]
      [FieldOffset(Offset = "0xC")]
      public GameObject list;

      [Token(Token = "0x170015A6")]
      public override System.Type type
      {
        [Token(Token = "0x6009C13"), Address(RVA = "0x607750", Offset = "0x606550", VA = "0x10607750", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x6009C14")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
