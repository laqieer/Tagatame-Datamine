// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentRootWindow
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
  [Token(Token = "0x20023E7")]
  public class FriendPresentRootWindow : FlowWindowBase
  {
    [Token(Token = "0x400A25E")]
    [FieldOffset(Offset = "0x30")]
    private FriendPresentRootWindow.SerializeParam m_Param;
    [Token(Token = "0x400A25F")]
    [FieldOffset(Offset = "0x34")]
    private FriendPresentRootWindow.Tab m_Tab;
    [Token(Token = "0x400A260")]
    [FieldOffset(Offset = "0x38")]
    private bool m_Destroy;
    [Token(Token = "0x400A261")]
    [FieldOffset(Offset = "0x3C")]
    private FriendPresentRootWindow.WantContent.ItemSource m_WantSource;
    [Token(Token = "0x400A262")]
    [FieldOffset(Offset = "0x40")]
    private ContentController m_WantController;
    [Token(Token = "0x400A263")]
    [FieldOffset(Offset = "0x44")]
    private FriendPresentRootWindow.ReceiveContent.ItemSource m_ReceiveSource;
    [Token(Token = "0x400A264")]
    [FieldOffset(Offset = "0x48")]
    private ContentController m_ReceiveController;
    [Token(Token = "0x400A265")]
    [FieldOffset(Offset = "0x4C")]
    private FriendPresentRootWindow.SendContent.ItemSource m_SendSource;
    [Token(Token = "0x400A266")]
    [FieldOffset(Offset = "0x50")]
    private ContentController m_SendController;
    [Token(Token = "0x400A267")]
    [FieldOffset(Offset = "0x54")]
    private SerializeValueBehaviour m_ValueList;
    [Token(Token = "0x400A268")]
    [FieldOffset(Offset = "0x58")]
    private Toggle m_ReceiveToggle;
    [Token(Token = "0x400A269")]
    [FieldOffset(Offset = "0x5C")]
    private Toggle m_SendToggle;
    [Token(Token = "0x400A26A")]
    [FieldOffset(Offset = "0x0")]
    private static FriendPresentRootWindow m_Instance;
    [Token(Token = "0x400A26B")]
    [FieldOffset(Offset = "0x4")]
    private static FriendPresentRootWindow.SendStatus m_SendStatus;

    [Token(Token = "0x170015A7")]
    public override string name
    {
      [Token(Token = "0x6009C22"), Address(RVA = "0x5F8080", Offset = "0x5F6E80", VA = "0x105F8080", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015A8")]
    public static FriendPresentRootWindow instance
    {
      [Token(Token = "0x6009C23"), Address(RVA = "0x5F8040", Offset = "0x5F6E40", VA = "0x105F8040")] get
      {
        return (FriendPresentRootWindow) null;
      }
    }

    [Token(Token = "0x6009C24")]
    [Address(RVA = "0x5F7C80", Offset = "0x5F6A80", VA = "0x105F7C80")]
    public static void SetSendStatus(FriendPresentRootWindow.SendStatus status)
    {
    }

    [Token(Token = "0x6009C25")]
    [Address(RVA = "0x5F7390", Offset = "0x5F6190", VA = "0x105F7390", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x6009C26")]
    [Address(RVA = "0x5F7C00", Offset = "0x5F6A00", VA = "0x105F7C00", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x6009C27")]
    [Address(RVA = "0x5F7ED0", Offset = "0x5F6CD0", VA = "0x105F7ED0", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x6009C28")]
    [Address(RVA = "0x5F7CD0", Offset = "0x5F6AD0", VA = "0x105F7CD0")]
    private bool SetTab(FriendPresentRootWindow.Tab tab) => new bool();

    [Token(Token = "0x6009C29")]
    [Address(RVA = "0x5F7110", Offset = "0x5F5F10", VA = "0x105F7110")]
    public void InitializeWantList()
    {
    }

    [Token(Token = "0x6009C2A")]
    [Address(RVA = "0x5F7B70", Offset = "0x5F6970", VA = "0x105F7B70")]
    public void ReleaseWantList()
    {
    }

    [Token(Token = "0x6009C2B")]
    [Address(RVA = "0x5F6900", Offset = "0x5F5700", VA = "0x105F6900")]
    public void InitializeReceiveList()
    {
    }

    [Token(Token = "0x6009C2C")]
    [Address(RVA = "0x5F7A50", Offset = "0x5F6850", VA = "0x105F7A50")]
    public void ReleaseReceiveList()
    {
    }

    [Token(Token = "0x6009C2D")]
    [Address(RVA = "0x5F6CA0", Offset = "0x5F5AA0", VA = "0x105F6CA0")]
    public void InitializeSendList()
    {
    }

    [Token(Token = "0x6009C2E")]
    [Address(RVA = "0x5F7AE0", Offset = "0x5F68E0", VA = "0x105F7AE0")]
    public void ReleaseSendList()
    {
    }

    [Token(Token = "0x6009C2F")]
    [Address(RVA = "0x5F7860", Offset = "0x5F6660", VA = "0x105F7860", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x6009C30")]
    [Address(RVA = "0x4A5B50", Offset = "0x4A4950", VA = "0x104A5B50")]
    public FriendPresentRootWindow()
    {
    }

    [Token(Token = "0x6009C31")]
    [Address(RVA = "0x5F7FF0", Offset = "0x5F6DF0", VA = "0x105F7FF0")]
    static FriendPresentRootWindow()
    {
    }

    [Token(Token = "0x20023E8")]
    public enum Tab
    {
      [Token(Token = "0x400A26D")] NONE,
      [Token(Token = "0x400A26E")] RECEIVE,
      [Token(Token = "0x400A26F")] SEND,
    }

    [Token(Token = "0x20023E9")]
    public enum SendStatus
    {
      [Token(Token = "0x400A271")] NONE,
      [Token(Token = "0x400A272")] UNSENT,
      [Token(Token = "0x400A273")] SENDING,
      [Token(Token = "0x400A274")] SENTFAILED,
      [Token(Token = "0x400A275")] SENDED,
    }

    [Token(Token = "0x20023EA")]
    public static class WantContent
    {
      [Token(Token = "0x400A276")]
      [FieldOffset(Offset = "0x0")]
      public static FriendPresentRootWindow.WantContent.ItemAccessor clickItem;

      [Token(Token = "0x20023EB")]
      public class ItemAccessor
      {
        [Token(Token = "0x400A277")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400A278")]
        [FieldOffset(Offset = "0xC")]
        private FriendPresentItemParam m_Present;
        [Token(Token = "0x400A279")]
        [FieldOffset(Offset = "0x10")]
        private FriendPresentItemIcon m_Icon;

        [Token(Token = "0x170015A9")]
        public ContentNode node
        {
          [Token(Token = "0x6009C32"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x170015AA")]
        public FriendPresentItemParam present
        {
          [Token(Token = "0x6009C33"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (FriendPresentItemParam) null;
          }
        }

        [Token(Token = "0x170015AB")]
        public FriendPresentItemIcon icon
        {
          [Token(Token = "0x6009C34"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (FriendPresentItemIcon) null;
          }
        }

        [Token(Token = "0x170015AC")]
        public int priority
        {
          [Token(Token = "0x6009C35"), Address(RVA = "0x605720", Offset = "0x604520", VA = "0x10605720")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x170015AD")]
        public bool isValid
        {
          [Token(Token = "0x6009C36"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x6009C37")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(FriendPresentItemParam present)
        {
        }

        [Token(Token = "0x6009C38")]
        [Address(RVA = "0x604E00", Offset = "0x603C00", VA = "0x10604E00")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x6009C39")]
        [Address(RVA = "0x605230", Offset = "0x604030", VA = "0x10605230")]
        public void Clear()
        {
        }

        [Token(Token = "0x6009C3A")]
        [Address(RVA = "0x605450", Offset = "0x604250", VA = "0x10605450")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x6009C3B")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x20023EC")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400A27A")]
        [FieldOffset(Offset = "0x10")]
        private List<FriendPresentRootWindow.WantContent.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x6009C3C")]
        [Address(RVA = "0x606930", Offset = "0x605730", VA = "0x10606930", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x6009C3D")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x6009C3E")]
        [Address(RVA = "0x6067A0", Offset = "0x6055A0", VA = "0x106067A0")]
        public void Add(
          FriendPresentRootWindow.WantContent.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x6009C3F")]
        [Address(RVA = "0x606990", Offset = "0x605790", VA = "0x10606990")]
        public void Setup()
        {
        }

        [Token(Token = "0x6009C40")]
        [Address(RVA = "0x607640", Offset = "0x606440", VA = "0x10607640")]
        public ItemSource()
        {
        }

        [Token(Token = "0x20023ED")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400A27B")]
          [FieldOffset(Offset = "0x10")]
          private FriendPresentRootWindow.WantContent.ItemAccessor m_Accessor;

          [Token(Token = "0x6009C41")]
          [Address(RVA = "0x6057E0", Offset = "0x6045E0", VA = "0x106057E0", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x170015AE")]
          public FriendPresentRootWindow.WantContent.ItemAccessor accerror
          {
            [Token(Token = "0x6009C42"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (FriendPresentRootWindow.WantContent.ItemAccessor) null;
            }
          }

          [Token(Token = "0x170015AF")]
          public FriendPresentItemParam present
          {
            [Token(Token = "0x6009C43"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (FriendPresentItemParam) null;
            }
          }

          [Token(Token = "0x6009C44")]
          [Address(RVA = "0x606420", Offset = "0x605220", VA = "0x10606420")]
          public ItemParam(FriendPresentItemParam present)
          {
          }

          [Token(Token = "0x6009C45")]
          [Address(RVA = "0x606030", Offset = "0x604E30", VA = "0x10606030", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C46")]
          [Address(RVA = "0x605A30", Offset = "0x604830", VA = "0x10605A30", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C47")]
          [Address(RVA = "0x605800", Offset = "0x604600", VA = "0x10605800", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x20023EF")]
    public static class ReceiveContent
    {
      [Token(Token = "0x400A27E")]
      [FieldOffset(Offset = "0x0")]
      public static FriendPresentRootWindow.ReceiveContent.ItemAccessor clickItem;

      [Token(Token = "0x20023F0")]
      public class ItemAccessor
      {
        [Token(Token = "0x400A27F")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400A280")]
        [FieldOffset(Offset = "0xC")]
        private FriendPresentReceiveList.FriendPresentReceiveParam m_Param;
        [Token(Token = "0x400A281")]
        [FieldOffset(Offset = "0x10")]
        private FriendPresentItemIcon m_Icon;
        [Token(Token = "0x400A282")]
        [FieldOffset(Offset = "0x14")]
        private SerializeValueBehaviour m_Value;

        [Token(Token = "0x170015B0")]
        public ContentNode node
        {
          [Token(Token = "0x6009C4B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x170015B1")]
        public FriendPresentReceiveList.FriendPresentReceiveParam param
        {
          [Token(Token = "0x6009C4C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (FriendPresentReceiveList.FriendPresentReceiveParam) null;
          }
        }

        [Token(Token = "0x170015B2")]
        public FriendPresentItemParam present
        {
          [Token(Token = "0x6009C4D"), Address(RVA = "0x3DA4C0", Offset = "0x3D92C0", VA = "0x103DA4C0")] get
          {
            return (FriendPresentItemParam) null;
          }
        }

        [Token(Token = "0x170015B3")]
        public FriendPresentItemIcon icon
        {
          [Token(Token = "0x6009C4E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (FriendPresentItemIcon) null;
          }
        }

        [Token(Token = "0x170015B4")]
        public bool isValid
        {
          [Token(Token = "0x6009C4F"), Address(RVA = "0x2B0090", Offset = "0x2AEE90", VA = "0x102B0090")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x6009C50")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(
          FriendPresentReceiveList.FriendPresentReceiveParam param)
        {
        }

        [Token(Token = "0x6009C51")]
        [Address(RVA = "0x604B50", Offset = "0x603950", VA = "0x10604B50")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x6009C52")]
        [Address(RVA = "0x604FB0", Offset = "0x603DB0", VA = "0x10604FB0")]
        public void Clear()
        {
        }

        [Token(Token = "0x6009C53")]
        [Address(RVA = "0x6053E0", Offset = "0x6041E0", VA = "0x106053E0")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x6009C54")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x20023F1")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400A283")]
        [FieldOffset(Offset = "0x10")]
        private List<FriendPresentRootWindow.ReceiveContent.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x6009C55")]
        [Address(RVA = "0x6068F0", Offset = "0x6056F0", VA = "0x106068F0", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x6009C56")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x6009C57")]
        [Address(RVA = "0x606880", Offset = "0x605680", VA = "0x10606880")]
        public void Add(
          FriendPresentRootWindow.ReceiveContent.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x6009C58")]
        [Address(RVA = "0x607020", Offset = "0x605E20", VA = "0x10607020")]
        public void Setup()
        {
        }

        [Token(Token = "0x6009C59")]
        [Address(RVA = "0x607560", Offset = "0x606360", VA = "0x10607560")]
        public ItemSource()
        {
        }

        [Token(Token = "0x20023F2")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400A284")]
          [FieldOffset(Offset = "0x10")]
          private FriendPresentRootWindow.ReceiveContent.ItemAccessor m_Accessor;

          [Token(Token = "0x6009C5A")]
          [Address(RVA = "0x605790", Offset = "0x604590", VA = "0x10605790", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x170015B5")]
          public FriendPresentRootWindow.ReceiveContent.ItemAccessor accerror
          {
            [Token(Token = "0x6009C5B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (FriendPresentRootWindow.ReceiveContent.ItemAccessor) null;
            }
          }

          [Token(Token = "0x170015B6")]
          public FriendPresentReceiveList.FriendPresentReceiveParam param
          {
            [Token(Token = "0x6009C5C"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (FriendPresentReceiveList.FriendPresentReceiveParam) null;
            }
          }

          [Token(Token = "0x170015B7")]
          public FriendPresentItemParam present
          {
            [Token(Token = "0x6009C5D"), Address(RVA = "0x6066A0", Offset = "0x6054A0", VA = "0x106066A0")] get
            {
              return (FriendPresentItemParam) null;
            }
          }

          [Token(Token = "0x6009C5E")]
          [Address(RVA = "0x6063A0", Offset = "0x6051A0", VA = "0x106063A0")]
          public ItemParam(
            FriendPresentReceiveList.FriendPresentReceiveParam param)
          {
          }

          [Token(Token = "0x6009C5F")]
          [Address(RVA = "0x605D50", Offset = "0x604B50", VA = "0x10605D50", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C60")]
          [Address(RVA = "0x605BB0", Offset = "0x6049B0", VA = "0x10605BB0", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C61")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x20023F4")]
    public static class SendContent
    {
      [Token(Token = "0x400A287")]
      [FieldOffset(Offset = "0x0")]
      public static FriendPresentRootWindow.SendContent.ItemAccessor clickItem;

      [Token(Token = "0x20023F5")]
      public class ItemAccessor
      {
        [Token(Token = "0x400A288")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400A289")]
        [FieldOffset(Offset = "0xC")]
        private FriendData m_Friend;
        [Token(Token = "0x400A28A")]
        [FieldOffset(Offset = "0x10")]
        private FriendPresentItemParam m_Present;
        [Token(Token = "0x400A28B")]
        [FieldOffset(Offset = "0x14")]
        private FriendPresentItemIcon m_Icon;
        [Token(Token = "0x400A28C")]
        [FieldOffset(Offset = "0x18")]
        private DataSource m_DataSource;

        [Token(Token = "0x170015B8")]
        public ContentNode node
        {
          [Token(Token = "0x6009C65"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x170015B9")]
        public FriendData friend
        {
          [Token(Token = "0x6009C66"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (FriendData) null;
          }
        }

        [Token(Token = "0x170015BA")]
        public FriendPresentItemParam present
        {
          [Token(Token = "0x6009C67"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (FriendPresentItemParam) null;
          }
        }

        [Token(Token = "0x170015BB")]
        public FriendPresentItemIcon icon
        {
          [Token(Token = "0x6009C68"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
          {
            return (FriendPresentItemIcon) null;
          }
        }

        [Token(Token = "0x170015BC")]
        public bool isValid
        {
          [Token(Token = "0x6009C69"), Address(RVA = "0x6056C0", Offset = "0x6044C0", VA = "0x106056C0")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x6009C6A")]
        [Address(RVA = "0x6054C0", Offset = "0x6042C0", VA = "0x106054C0")]
        public void Setup(FriendData friend)
        {
        }

        [Token(Token = "0x6009C6B")]
        [Address(RVA = "0x604CA0", Offset = "0x603AA0", VA = "0x10604CA0")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x6009C6C")]
        [Address(RVA = "0x605080", Offset = "0x603E80", VA = "0x10605080")]
        public void Clear()
        {
        }

        [Token(Token = "0x6009C6D")]
        [Address(RVA = "0x605370", Offset = "0x604170", VA = "0x10605370")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x6009C6E")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x20023F6")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400A28D")]
        [FieldOffset(Offset = "0x10")]
        private List<FriendPresentRootWindow.SendContent.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x6009C6F")]
        [Address(RVA = "0x606970", Offset = "0x605770", VA = "0x10606970", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x6009C70")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x6009C71")]
        [Address(RVA = "0x606810", Offset = "0x605610", VA = "0x10606810")]
        public void Add(
          FriendPresentRootWindow.SendContent.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x6009C72")]
        [Address(RVA = "0x606BC0", Offset = "0x6059C0", VA = "0x10606BC0")]
        public void Setup()
        {
        }

        [Token(Token = "0x6009C73")]
        [Address(RVA = "0x6075D0", Offset = "0x6063D0", VA = "0x106075D0")]
        public ItemSource()
        {
        }

        [Token(Token = "0x20023F7")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400A28E")]
          [FieldOffset(Offset = "0x10")]
          private FriendPresentRootWindow.SendContent.ItemAccessor m_Accessor;

          [Token(Token = "0x6009C74")]
          [Address(RVA = "0x6057B0", Offset = "0x6045B0", VA = "0x106057B0", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x170015BD")]
          public FriendPresentRootWindow.SendContent.ItemAccessor accerror
          {
            [Token(Token = "0x6009C75"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (FriendPresentRootWindow.SendContent.ItemAccessor) null;
            }
          }

          [Token(Token = "0x170015BE")]
          public FriendData friend
          {
            [Token(Token = "0x6009C76"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (FriendData) null;
            }
          }

          [Token(Token = "0x170015BF")]
          public FriendPresentItemParam present
          {
            [Token(Token = "0x6009C77"), Address(RVA = "0x606680", Offset = "0x605480", VA = "0x10606680")] get
            {
              return (FriendPresentItemParam) null;
            }
          }

          [Token(Token = "0x6009C78")]
          [Address(RVA = "0x606230", Offset = "0x605030", VA = "0x10606230")]
          public ItemParam(FriendData friend)
          {
          }

          [Token(Token = "0x6009C79")]
          [Address(RVA = "0x6061A0", Offset = "0x604FA0", VA = "0x106061A0", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C7A")]
          [Address(RVA = "0x605900", Offset = "0x604700", VA = "0x10605900", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x6009C7B")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x20023F9")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400A291")]
      [FieldOffset(Offset = "0xC")]
      public GameObject tabReceive;
      [Token(Token = "0x400A292")]
      [FieldOffset(Offset = "0x10")]
      public GameObject tabSend;
      [Token(Token = "0x400A293")]
      [FieldOffset(Offset = "0x14")]
      public GameObject wantList;
      [Token(Token = "0x400A294")]
      [FieldOffset(Offset = "0x18")]
      public GameObject receiveList;
      [Token(Token = "0x400A295")]
      [FieldOffset(Offset = "0x1C")]
      public GameObject sendList;

      [Token(Token = "0x170015C0")]
      public override System.Type type
      {
        [Token(Token = "0x6009C7F"), Address(RVA = "0x6076B0", Offset = "0x6064B0", VA = "0x106076B0", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x6009C80")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
